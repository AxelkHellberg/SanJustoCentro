
Imports Domain
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Data.SqlClient
Imports System.IO
Imports CapaComun


Public Class FormVenta

#Region "Inicializacion del FORM VENTA"

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()

                command.Connection = connection
                command.CommandText = "select nombre as Vendedor FROM Vendedor"
                command.CommandType = CommandType.Text

                Dim da2 As New SqlDataAdapter(command)
                Dim tabla As New DataTable

                If da2.Fill(tabla) <> 0 Then

                    Dim db As New BindingSource
                    db.DataSource = tabla
                    DataGridViewVendedores.DataSource = db
                    da2.Dispose()


                Else
                    DataGridViewVendedores.Columns.Clear()
                    da2.Dispose()
                End If

            End Using
        End Using
    End Sub
#End Region

#Region "Conexion a SQL"


    Private connectionString As String
    Public Sub conectar()
        'connectionString = "Server=IGGI662\PRUEBA1; DataBase=VerdaderoBackupSanJusto; integrated security= true"
        connectionString = "Server=45.169.100.7; DataBase=sanjusto_centro; User Id=sanjusto_sanjusto ; Password=sz2dKOe&Y9~J35"
    End Sub
    Public Function GetConnection() As SqlConnection
        conectar()
        Return New SqlConnection(connectionString)
    End Function

#End Region

#Region "Drag Forms"

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    PanelBarraTitulo.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            Me.BringToFront()
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    PanelBarraTitulo.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.BringToFront()
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    PanelBarraTitulo.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            Me.BringToFront()
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub panelContenedor_MouseClick(sender As Object, e As MouseEventArgs) Handles Total.MouseClick
        Me.BringToFront()
    End Sub


#End Region

#Region "Botones"



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                If String.IsNullOrEmpty(TextCodigoBarra.Text) Then
                    If String.IsNullOrEmpty(TextDescripcion.Text) Then
                        MessageBox.Show("Debe rellenar al menos el campo 'Codigo' o 'Descripcion'")
                        Exit Sub
                    Else

                        command.CommandText = "select codigo As Codigo,descripcion As Descripcion,stockPeru As 'Stock Peru',stockArieta As 'Stock A3300',stockArieta2 as 'Stock A3100',precio As Precio FROM Producto WHERE descripcion LIKE '%'+@desc+'%'"
                        command.Parameters.AddWithValue("@desc", TextDescripcion.Text)
                        command.CommandType = CommandType.Text
                        TextDescripcion.Clear()
                    End If
                Else

                    command.CommandText = "select codigo As Codigo,descripcion As Descripcion,stockPeru As 'Stock Peru',stockArieta As 'Stock A3300',stockArieta2 as 'Stock A3100',precio As Precio FROM Producto WHERE codigo = @cod"
                    command.Parameters.AddWithValue("@cod", TextCodigoBarra.Text)
                    command.CommandType = CommandType.Text

                End If

                Dim da2 As New SqlDataAdapter(command)
                Dim tabla As New DataTable

                If da2.Fill(tabla) <> 0 Then

                    DataGridViewBusqueda.Columns.Clear()
                    Dim db As New BindingSource
                    db.DataSource = tabla
                    DataGridViewBusqueda.DataSource = db
                    da2.Dispose()
                    DataGridViewBusqueda.BeginEdit(False)
                    DataGridViewBusqueda.Columns(0).Width = 40
                    DataGridViewBusqueda.Columns(1).Width = 80
                    DataGridViewBusqueda.Columns(2).Width = 20
                    DataGridViewBusqueda.Columns(3).Width = 20
                    DataGridViewBusqueda.Columns(4).Width = 20
                    DataGridViewBusqueda.Columns(5).Width = 80

                Else
                    DataGridViewBusqueda.Columns.Clear()
                    da2.Dispose()
                End If

                DataGridViewBusqueda.Focus()

            End Using
        End Using

    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        TextCodigoBarra.Clear()
        TextCodigoBarra.Focus()
        TextDescripcion.Clear()
        TextCant.Clear()
    End Sub

    Private Sub BotonAgregar_Click(sender As Object, e As EventArgs) Handles BotonAgregar.Click
        If String.IsNullOrEmpty(TextCodigoBarra.Text) Or String.IsNullOrEmpty(TextCant.Text) Or String.IsNullOrEmpty(TextDescripcion.Text) Then
            MessageBox.Show("Error en el relleno de campos.")
        Else
            DataGridViewVenta.Rows.Add(TextCodigoBarra.Text.Trim(), TextDescripcion.Text.Trim(), TextCant.Text.Trim(), DataGridViewBusqueda.CurrentRow.Cells(5).Value.ToString())
            DataGridViewVenta.ColumnHeadersVisible = True
            TextCodigoBarra.Clear()
            TextDescripcion.Clear()
            TextCouta.Clear()
            TextCant.Clear()
            TextCodigoBarra.Focus()
        End If
    End Sub

    Private Sub BotonConfirmar_Click(sender As Object, e As EventArgs) Handles BotonConfirmar.Click
        Dim campo1 As String
        Dim campo3 As String

        Dim userModel As New UserModel()
        Dim valid As Boolean

        Dim tarjeta As Double
        Dim codVenta As Integer
        Dim ajuste As Double
        Dim debito As Double
        Dim precioProducto As Double
        If Not String.IsNullOrEmpty(TextTarjeta.Text) Then
            tarjeta = TextTarjeta.Text
        Else
            tarjeta = 0
        End If
        Dim interes As Double
        If Not String.IsNullOrEmpty(TextInteres.Text) Then
            interes = TextInteres.Text
        Else
            interes = 0
        End If
        If Not String.IsNullOrEmpty(TextAjuste.Text) Then
            ajuste = TextAjuste.Text
        Else
            ajuste = 0
        End If
        If Not String.IsNullOrEmpty(TextDebito.Text) Then
            debito = TextDebito.Text
        Else
            debito = 0
        End If

        If CheckCliente.Checked = False Then
            'Si la venta es a un consumidor final . . .
            codVenta = userModel.InsertarEnConfirmar(TotalNum.Text, ajuste, TextEfectivo.Text, tarjeta + debito, interes)
        Else
            'Si la venta es a un cliente en particular . . .
            codVenta = userModel.descontarSaldoCliente(TotalNum.Text, ajuste, TextEfectivo.Text, tarjeta + debito, interes, ClienteAsignado.Text)

        End If

        For i As Integer = 0 To DataGridViewVenta.Rows.Count - 1
            campo1 = DataGridViewVenta.Rows(i).Cells(0).Value.ToString
            campo3 = DataGridViewVenta.Rows(i).Cells(2).Value.ToString
            precioProducto = DataGridViewVenta.Rows(i).Cells(3).Value.ToString
            If String.IsNullOrEmpty(TextTarjeta.Text) Then
                TextTarjeta.Text = "0"
            End If
            If String.IsNullOrEmpty(TextAjuste.Text) Then
                TextAjuste.Text = "0"
            End If

            If CheckCliente.Checked = True Then
                userModel.agregarCompraCliente(campo1, campo3, ClienteAsignado.Text, precioProducto)
            End If


            valid = userModel.VenderProductos(campo1, campo3, DataGridViewVendedores.CurrentRow.Cells(0).Value.ToString, codVenta)

            If valid = False Then
                MessageBox.Show("Error al vender el producto" + vbNewLine + "Por favor, intente nuevamente." + vbNewLine + "o llamar a Axel")
            End If

        Next
        DataGridViewBusqueda.Columns.Clear()
        DataGridViewVenta.Rows.Clear()
        TextAjuste.Clear()
        TextDebito.Clear()
        TextTarjeta.Clear()
        TextEfectivo.Clear()
        TextInteres.Clear()
        TextCodigoBarra.Focus()
        TotalNum.Text = "0.00"
        DataGridViewVenta.ColumnHeadersVisible = False
        CheckCliente.Checked = False
    End Sub

    Private Sub Boton3Coutas_Click(sender As Object, e As EventArgs) Handles Boton3Coutas.Click
        If Not String.IsNullOrEmpty(TextInteres.Text) Then
            TotalNum.Text -= TextInteres.Text
        End If
        If Not String.IsNullOrEmpty(TextTarjeta.Text) Then
            Dim monto As Double = TextTarjeta.Text
            Dim interes As Double
            interes = Convert.ToInt32(monto * 0.2)
            TextInteres.Text = interes
            TextCouta.Text = Convert.ToInt32((monto + interes) / 3)
            TotalNum.Text += interes
        End If
    End Sub

    Private Sub Boton6Coutas_Click(sender As Object, e As EventArgs) Handles Boton6Coutas.Click
        If Not String.IsNullOrEmpty(TextInteres.Text) Then
            TotalNum.Text -= TextInteres.Text
        End If
        If Not String.IsNullOrEmpty(TextTarjeta.Text) Then
            Dim monto As Double = TextTarjeta.Text
            Dim interes As Double
            interes = Convert.ToInt32(monto * 0.25)
            TextInteres.Text = interes
            TextCouta.Text = Convert.ToInt32((monto + interes) / 6)
            TotalNum.Text += interes
        End If
    End Sub

    Private Sub Boton12Coutas_Click(sender As Object, e As EventArgs) Handles Boton12Coutas.Click
        If Not String.IsNullOrEmpty(TextInteres.Text) Then
            TotalNum.Text -= TextInteres.Text
        End If
        If Not String.IsNullOrEmpty(TextTarjeta.Text) Then
            Dim monto As Double = TextTarjeta.Text
            Dim interes As Double
            interes = Convert.ToInt32(monto * 0.3)
            TextInteres.Text = interes
            TextCouta.Text = Convert.ToInt32((monto + interes) / 12)
            TotalNum.Text += interes
        End If
    End Sub

    Private Sub Cuota1_Click(sender As Object, e As EventArgs) Handles Cuota1.Click
        If Not String.IsNullOrEmpty(TextInteres.Text) Then
            TotalNum.Text -= TextInteres.Text
        End If
        If Not String.IsNullOrEmpty(TextTarjeta.Text) Then
            Dim monto As Double = TextTarjeta.Text
            Dim interes As Double
            interes = Convert.ToInt32(monto * 0.1)
            TextInteres.Text = interes
            TextCouta.Text = Convert.ToInt32((monto + interes) / 1)
            TotalNum.Text += interes
        End If
    End Sub


#End Region

#Region "KeyDown/KeyPress/KeyUp"


    Private Sub TextCodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCodigoBarra.KeyDown, TextDescripcion.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Button1_Click(sender, e)
                e.SuppressKeyPress = True
        End Select
    End Sub



    Private Sub DataGridViewBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewBusqueda.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TextCant.Clear()
                TextCant.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub TextCant_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCant.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonAgregar_Click(sender, e)
                e.SuppressKeyPress = True
        End Select
    End Sub


    Private Sub TextTarjeta_KeyDown(sender As Object, e As KeyEventArgs) Handles TextTarjeta.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                e.SuppressKeyPress = True
                Dim efectivo As Double = TextEfectivo.Text
                '     Dim efectivo As Double = TotalNum.Text
                If Not String.IsNullOrEmpty(TextTarjeta.Text) And Not String.Equals(TextTarjeta.Text, "0") Then
                    Dim tarjeta As Double = TextTarjeta.Text
                    efectivo -= tarjeta
                Else
                    efectivo = Sumar(Column4.Name, DataGridViewVenta, Column3.Name)
                    TotalNum.Text = FormatNumber(efectivo.ToString(), 2)
                    TextEfectivo.Text = efectivo
                    TextTarjeta.Clear()
                    TextInteres.Clear()
                    TextDebito.Clear()
                    TextAjuste.Clear()
                    TextCouta.Clear()
                End If
                TextEfectivo.Text = efectivo
        End Select
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextDebito.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                e.SuppressKeyPress = True
                Dim efectivo As Double = TextEfectivo.Text
                '    Dim efectivo As Double = TotalNum.Text
                If Not String.IsNullOrEmpty(TextDebito.Text) And Not String.Equals(TextDebito.Text, "0") Then
                    Dim tarjeta As Double = TextDebito.Text
                    efectivo -= tarjeta
                Else
                    efectivo = Sumar(Column4.Name, DataGridViewVenta, Column3.Name)
                    TotalNum.Text = FormatNumber(efectivo.ToString(), 2)
                    TextEfectivo.Text = efectivo
                    TextTarjeta.Clear()
                    TextDebito.Clear()
                    TextInteres.Clear()
                    TextAjuste.Clear()
                    TextCouta.Clear()
                End If
                TextEfectivo.Text = efectivo
        End Select
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextAjuste.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                e.SuppressKeyPress = True
                Dim total As Double = TotalNum.Text
                If String.IsNullOrEmpty(TextTarjeta.Text) Then
                    If Not String.IsNullOrEmpty(TextAjuste.Text) Or TextAjuste.Text = "0" Then
                        Dim ajuste As Double = TextAjuste.Text
                        total += ajuste
                        TextEfectivo.Text += ajuste
                    Else
                        total = Sumar(Column4.Name, DataGridViewVenta, Column3.Name)
                    End If
                    TotalNum.Text = total
                Else
                    If Not String.IsNullOrEmpty(TextAjuste.Text) Or TextAjuste.Text = "0" Then
                        Dim ajuste As Double = TextAjuste.Text
                        total += ajuste
                        TextTarjeta.Text += ajuste
                        If Not String.IsNullOrEmpty(TextInteres.Text) Or TextInteres.Text = "0" Then
                            TotalNum.Text -= TextInteres.Text
                        End If
                        TotalNum.Text += ajuste
                        TextCouta.Clear()
                        TextInteres.Clear()
                    Else
                        total = Sumar(Column4.Name, DataGridViewVenta, Column3.Name)
                    End If
                End If
        End Select
    End Sub


#End Region

#Region "Funciones esenciales"

    Private Function Sumar(
        ByVal nombre_Columna As String,
        ByVal Dgv As DataGridView, ByVal cant As String) As Double

        Dim total As Double = 0

        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value) * Dgv.Item(cant.ToLower, i).Value
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' retornar el valor  
        Return total

    End Function


#End Region

#Region "Datas Grids Views eventos"


    Private Sub DataGridViewBusqueda_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewBusqueda.CellPainting
        TextCodigoBarra.Text = DataGridViewBusqueda.CurrentRow.Cells(0).Value.ToString()
        TextDescripcion.Text = DataGridViewBusqueda.CurrentRow.Cells(1).Value.ToString()
    End Sub


    Private Sub DataGridViewVenta_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridViewVenta.RowsAdded
        Dim precioTotal As Double = Sumar(Column4.Name, DataGridViewVenta, Column3.Name)
        TotalNum.Text = FormatNumber(precioTotal.ToString(), 2)
        TextEfectivo.Text = precioTotal
        TextTarjeta.Clear()
        TextDebito.Clear()
        TextInteres.Clear()
        TextAjuste.Clear()
        TextCouta.Clear()
    End Sub

    Private Sub DataGridViewVenta_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridViewVenta.RowsRemoved
        Dim precioTotal As Double = Sumar(Column4.Name, DataGridViewVenta, Column3.Name)
        TotalNum.Text = FormatNumber(precioTotal.ToString(), 2)
        TextEfectivo.Text = precioTotal
        TextTarjeta.Clear()
        TextDebito.Clear()
        TextCouta.Clear()
        TextAjuste.Clear()
        TextInteres.Clear()
    End Sub

    Private Sub DataGridViewVendedores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVendedores.CellContentDoubleClick
        Dim usermodel As New UserModel()
        Using connection = GetConnection()
            connection.open()
            Using command = New SqlCommand()
                command.connection = connection
                command.commandtext = "select sum(efectivo+tarjeta) from totalvendidoporvendedor(@vendedor)"
                command.parameters.addwithvalue("@vendedor", DataGridViewVendedores.CurrentRow.Cells(0).Value.ToString)
                command.commandtype = CommandType.Text
                Try
                    TotalVendedor.Text = FormatNumber(command.executescalar(), 0)
                Catch ex As Exception
                    TotalVendedor.Text = 0.00
                End Try

            End Using
        End Using
    End Sub



#End Region

#Region "Clientes"
    Private Sub CheckCliente_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCliente.CheckedChanged
        If CheckCliente.Checked = False Then
            ClienteAsignado.Text = "Consumidor final"
            TextDebito.Enabled = True
            TextTarjeta.Enabled = True
        Else
            TextDebito.Enabled = False
            TextTarjeta.Enabled = False
        End If
    End Sub

    Private Function CheckForm(_form As Form) As Form

        For Each f As Form In Application.OpenForms
            If f.Name = _form.Name Then
                Return f
            End If
        Next

        Return Nothing

    End Function

    Private Sub BotonCliente_Click(sender As Object, e As EventArgs) Handles BotonCliente.Click
        Dim Formulario As Form
        Formulario = CheckForm(FormCliente) 'Busca el formulario en la coleccion'
        If Formulario Is Nothing Then
            'Formulario = FormCliente
            'Formulario.FormBorderStyle = FormBorderStyle.None
            'Formulario.Dock = DockStyle.None
            'Formulario.Show()
            'Formulario.BringToFront()
            Dim frm As New FormCliente
            AddOwnedForm(frm)
            frm.FormBorderStyle = FormBorderStyle.None
            frm.ShowDialog()
        Else
            Formulario.BringToFront()
        End If
    End Sub

#End Region

#Region "BackGroundWorker PDF"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BotonPresupuesto.Click
        BackgroundWorker1.RunWorkerAsync(2000)  'Esto pra llamar a que funcione el backgroundworker
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim oDoc As New iTextSharp.text.Document(PageSize.LEGAL, 0, 0, 200, 0)
        Dim pdfw As iTextSharp.text.pdf.PdfWriter
        Dim cb As PdfContentByte
        Dim fuente As iTextSharp.text.pdf.BaseFont
        Dim fuenteTitulos As iTextSharp.text.pdf.BaseFont
        Dim NombreArchivo As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Presupuesto\Presupuesto.pdf"
        Dim colu As Integer
        If CheckPresupuesto.Checked = True Then
            colu = 3
        Else
            colu = 4
        End If

        Dim tabla As New pdf.PdfPTable(colu)
        '   Dim fondoPauta1Pag As Image
        Dim logoIGM As Image

        Try
            pdfw = PdfWriter.GetInstance(oDoc, New FileStream(NombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None))
        Catch ex As UnauthorizedAccessException
            MsgBox("Error al generar o guardar el documento: " & ex.ToString(), MsgBoxStyle.Critical, "Error iTextSharp")
            Exit Sub
        End Try

        Try
            '----------->Apertura del documento.
            oDoc.Open()
            cb = pdfw.DirectContent
            'Agregamos una pagina.
            oDoc.NewPage()
            'Márgenes
            oDoc.SetMargins(28.5, 28.5, 70, 35)
            'Iniciamos el flujo de bytes.
            cb.BeginText()
            'Instanciamos el objeto para la tipo de letra.
            fuente = FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont
            fuenteTitulos = FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.BOLD).BaseFont
            'Seteamos el tipo de letra y el tamaño.
            cb.SetFontAndSize(fuente, 14)
            'Seteamos el color del texto a escribir.
            'cb.SetColorFill(iTextSharp.text.Color.BLACK)

            '----------->Texto a escribir en el PDF
            'Aclaracion: Por alguna razon la coordenada vertical siempre es tomada desde el borde inferior (de ahi que se calcule como "PageSize.A4.Height - 50")
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 310, PageSize.LEGAL.Height - 55, 0)



            '----------->Construcción cabecera
            ''Fondo de celdas
            'fondoPauta1Pag = iTextSharp.text.Image.GetInstance("C:\Users\axel\Desktop\ProyectoCentroComputacion\sanjustocentro.png") 'Dirreccion a la imagen que se hace referencia
            '' basePauta.BorderColor = pdf.PatternColor.WHITE
            'fondoPauta1Pag.SetAbsolutePosition(-50, 115) 'Posicion en el eje cartesiano
            'fondoPauta1Pag.ScaleAbsoluteWidth(700) 'Ancho de la imagen
            'fondoPauta1Pag.ScaleAbsoluteHeight(900) 'Altura de la imagen
            'oDoc.Add(fondoPauta1Pag)
            ''Fin fondo de celdas
            'Logo IGM
            logoIGM = iTextSharp.text.Image.GetInstance(My.Computer.FileSystem.SpecialDirectories.Desktop & "\Presupuesto\Logo\sanjustocentrocomputacion.png") 'Dirreccion a la imagen que se hace referencia
            logoIGM.SetAbsolutePosition(56, 850) 'Posicion en el eje cartesiano
            logoIGM.ScaleAbsoluteWidth(170) 'Ancho de la imagen
            logoIGM.ScaleAbsoluteHeight(170) 'Altura de la imagen
            oDoc.Add(logoIGM)
            'Fin logo IGM, añade logo igm a la pauta
            cb.SetFontAndSize(fuente, 9)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "San Justo Centro Computacion", 430, PageSize.LEGAL.Height - 55, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, sucursalPA & " " & sucursalAltura, 430, PageSize.LEGAL.Height - 63, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "San Justo", 430, PageSize.LEGAL.Height - 71, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "4651-1601", 430, PageSize.LEGAL.Height - 79, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "www.sanjustocentrocomputacion.com", 430, PageSize.LEGAL.Height - 87, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Instagram: san_justo_centro_computacion", 430, PageSize.LEGAL.Height - 95, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "WhatsApp: 11 2752-2840", 430, PageSize.LEGAL.Height - 105, 0)
            'Fin código ISO IGM
            '---------------------->Fin cabecera
            'Fin logo IGM, añade logo igm a la pauta
            '---------------------->Fin cabecera
            Threading.Thread.Sleep(500)
            'BackgroundWorker1.ReportProgress(15)
            '----------->Construcción cuerpo presentación

            Dim monto As Double = TotalNum.Text
            Dim interes As Double
            Dim cuota3 As Double
            Dim cuota6 As Double
            Dim cuota12 As Double

            interes = Convert.ToInt32(monto * 0.2)
            cuota3 = Convert.ToInt32((monto + interes) / 3)

            interes = Convert.ToInt32(monto * 0.25)
            cuota6 = Convert.ToInt32((monto + interes) / 6)

            interes = Convert.ToInt32(monto * 0.3)
            cuota12 = Convert.ToInt32((monto + interes) / 12)


            cb.SetFontAndSize(fuente, 8)
            Dim thisDay As Date = Date.Today
            cb.ShowTextAligned(100, "Vendedor: " & DataGridViewVendedores.CurrentRow.Cells(0).Value.ToString, 60, PageSize.LEGAL.Height - 154, 0)
            cb.ShowTextAligned(100, "Fecha: " & thisDay.ToString("D"), 60, PageSize.LEGAL.Height - 169, 0)
            cb.SetFontAndSize(fuente, 12)
            cb.ShowTextAligned(100, "3 Cuotas de: " & cuota3.ToString() & "   6 Coutas de: " & cuota6.ToString() & "   12 Cuotas de: " & cuota12.ToString() & "    TOTAL: " & monto.ToString(), 60, PageSize.LEGAL.Height - 190, 0)
            '---------------------->Fin cuerpo presentación

#Region "Tabla a PDF"

            If CheckPresupuesto.Checked = False Then

                For Each row As DataGridViewRow In DataGridViewVenta.Rows

                    For Each col As DataGridViewColumn In DataGridViewVenta.Columns

                        Dim val As String = Convert.ToString(row.Cells(col.Index).Value)
                        tabla.AddCell(val)
                    Next

                Next
            Else
                For Each row As DataGridViewRow In DataGridViewVenta.Rows



                    Dim cod As String = Convert.ToString(row.Cells(0).Value)
                    Dim nombre As String = Convert.ToString(row.Cells(1).Value)
                    Dim cant As String = Convert.ToString(row.Cells(2).Value)
                    tabla.AddCell(cod)
                    tabla.AddCell(nombre)
                    tabla.AddCell(cant)


                Next
            End If
            'Se agrega el PDFTable al documento.
            oDoc.Add(tabla)


#End Region



            '----------->Fin del flujo de bytes.
            cb.EndText()
            'Forzamos vaciamiento del buffer.
            pdfw.Flush()
            'Cerramos el documento, fin pagina 2.
            oDoc.Close()
            oDoc.CloseDocument()
            System.Diagnostics.Process.Start(My.Computer.FileSystem.SpecialDirectories.Desktop & "\Presupuesto\Presupuesto.pdf")

        Catch ex As Exception
            MsgBox("Error en GenerarDocumento(): " & ex.ToString, MsgBoxStyle.Critical, "Error generando PDF ")
            'Si hubo una excepcion y el archivo existe
            If File.Exists(NombreArchivo) Then
                'Cerramos el documento si esta abierto.
                'desbloqueamos el archivo para su eliminacion.
                If oDoc.IsOpen Then oDoc.Close()
                'lo eliminamos de disco.
                File.Delete(NombreArchivo)
                MsgBox("Error en GenerarDocumento(): " & ex.ToString, MsgBoxStyle.Critical, "Error generando PDF ")
            End If
            Throw New Exception("Error al generar archivo PDF (" & ex.Message & ")")
        Finally ' vacian las variables de flujo.
            cb = Nothing
            pdfw = Nothing
            oDoc = Nothing
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

#End Region

#Region " asd "


#End Region





End Class