
Imports Domain
Imports System.Data.SqlClient



Public Class FormCompra

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
    End Sub

#Region "Coneccion a SQL"

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
    Private Sub panelContenedor_MouseClick(sender As Object, e As MouseEventArgs) Handles panelContenedor.MouseClick
        Me.BringToFront()
    End Sub

    Private Sub PanelBarraTitulo_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseClick
        Me.BringToFront()
    End Sub

#End Region

#Region "Botones"
    Private Sub BotonExportarExcel_Click(sender As Object, e As EventArgs) Handles BotonExportarExcel.Click
        llenarExcel(DataGridViewCompra)
    End Sub


    Private Sub BotonValidar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
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

                        command.CommandText = "select codigo as Codigo,descripcion as Descripcion,costo as Costo,precio as Precio,stockPeru as 'Stock Peru',stockArieta as 'Stock A3300',stockArieta2 as 'Stock A3100',porcentaje as '%%' FROM Producto WHERE descripcion LIKE '%'+@desc+'%'"
                        command.Parameters.AddWithValue("@desc", TextDescripcion.Text)
                        command.CommandType = CommandType.Text

                    End If
                Else

                    command.CommandText = "select codigo as Codigo,descripcion as Descripcion,costo as Costo,precio as Precio,stockPeru as 'Stock Peru',stockArieta as 'Stock A3300',stockArieta2 as 'Stock A3100',porcentaje as '%%' FROM Producto WHERE codigo LIKE '%'+@cod+'%'"
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
                    DataGridViewBusqueda.Columns(5).Width = 20
                    DataGridViewBusqueda.Columns(6).Width = 20
                    DataGridViewBusqueda.Columns(7).Width = 50

                Else
                    DataGridViewBusqueda.Columns.Clear()
                    da2.Dispose()
                End If

                DataGridViewBusqueda.Focus()

            End Using
        End Using

    End Sub



    Private Sub BotonConfirmar_Click(sender As Object, e As EventArgs) Handles BotonAgregar.Click
        If String.IsNullOrEmpty(TextCodigoBarra.Text) Or String.IsNullOrEmpty(TextCantPeru.Text) Or String.IsNullOrEmpty(TextCosto.Text) Or String.IsNullOrEmpty(TextPrecio.Text) Or String.IsNullOrEmpty(TextPorcentaje.Text) Then
            MessageBox.Show("Error en el relleno de campos.")
        Else
            DataGridViewCompra.Rows.Add(TextCodigoBarra.Text.Trim(), TextDescripcion.Text.Trim(), TextCantPeru.Text.Trim(), TextCantArieta.Text.Trim(), TextCantArieta2.Text.Trim(), TextCosto.Text.Trim(), TextPorcentaje.Text.Trim(), TextPrecio.Text.Trim())
            DataGridViewCompra.Columns(0).Width = 40
            DataGridViewCompra.Columns(1).Width = 80
            DataGridViewCompra.Columns(2).Width = 20
            DataGridViewCompra.Columns(3).Width = 20
            DataGridViewCompra.Columns(4).Width = 20
            DataGridViewCompra.Columns(5).Width = 20
            DataGridViewCompra.Columns(6).Width = 20
            DataGridViewCompra.Columns(7).Width = 50
            DataGridViewCompra.ColumnHeadersVisible = True
            TextCodigoBarra.Clear()
            TextDescripcion.Clear()
            TextCantPeru.Clear()
            TextCantArieta.Clear()
            TextCantArieta2.Clear()
            TextCosto.Clear()
            TextPrecio.Clear()
            TextPorcentaje.Clear()
            TextCodigoBarra.Focus()
        End If
    End Sub

    Private Sub BotonConfirmar_Click_1(sender As Object, e As EventArgs) Handles BotonConfirmar.Click
        Dim campo1 As String
        Dim campo2 As String
        Dim campo3 As String
        Dim campo4 As String
        Dim campo5 As String
        Dim campo6 As String
        Dim campo7 As String
        Dim campo8 As String
        For i As Integer = 0 To DataGridViewCompra.Rows.Count - 1
            Dim userModel As New UserModel()
            campo1 = DataGridViewCompra.Rows(i).Cells(0).Value.ToString
            campo2 = DataGridViewCompra.Rows(i).Cells(1).Value.ToString
            campo3 = DataGridViewCompra.Rows(i).Cells(2).Value.ToString
            campo4 = DataGridViewCompra.Rows(i).Cells(3).Value.ToString
            campo8 = DataGridViewCompra.Rows(i).Cells(4).Value.ToString
            campo5 = DataGridViewCompra.Rows(i).Cells(5).Value.ToString
            campo6 = DataGridViewCompra.Rows(i).Cells(6).Value.ToString
            campo7 = DataGridViewCompra.Rows(i).Cells(7).Value.ToString

            Dim valid = userModel.ComprarProductos(campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8)

            If valid = False Then
                MessageBox.Show("Error al acumular el producto" + vbNewLine + "Por favor, intente nuevamente.")
            End If

        Next
        DataGridViewBusqueda.Columns.Clear()
        DataGridViewCompra.Rows.Clear()
        TextCodigoBarra.Focus()
        DataGridViewCompra.ColumnHeadersVisible = False
    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        TextCodigoBarra.Clear()
        TextCodigoBarra.Focus()
        TextDescripcion.Clear()
        TextCantPeru.Clear()
        TextCosto.Clear()
        TextPorcentaje.Clear()
        TextPrecio.Clear()
        TextCantArieta.Clear()
    End Sub

#Region "Boton cerrar"

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#End Region

#Region "KeyPress/KeyDown"


    Private Sub TextDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles TextDescripcion.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TextCodigoBarra.Clear()
                BotonValidar_Click(sender, e)
                TextCantPeru.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub


    Public Sub SoloNumero(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Error no se permiten letras en este campo.")
        Else
            e.Handled = False
        End If
    End Sub


    Private Sub DataGridViewBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewBusqueda.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TextCantPeru.Clear()
                TextCantPeru.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub TextPorcentaje_KeyUp(sender As Object, e As KeyEventArgs) Handles TextPorcentaje.KeyUp, TextCosto.KeyUp, TextCantPeru.KeyUp
        If Not String.IsNullOrEmpty(TextPorcentaje.Text) And Not String.IsNullOrEmpty(TextCosto.Text) Then
            Dim porc As Single
            Dim costo As Single
            costo = Convert.ToSingle(TextCosto.Text)
            porc = Convert.ToSingle(TextPorcentaje.Text)
            TextPrecio.Text = Convert.ToString(((porc / 100) * costo) + costo)
        End If
    End Sub

    Private Sub TextCant_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCantPeru.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TextCantArieta.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub
    Private Sub TextCosto_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCosto.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TextPorcentaje.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub TextPorcentaje_KeyDown(sender As Object, e As KeyEventArgs) Handles TextPorcentaje.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TextPrecio.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub TextPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles TextPrecio.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonConfirmar_Click(sender, e)
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub TextCodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCodigoBarra.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonValidar_Click(sender, e)
                TextCantPeru.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub TextCantArieta_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCantArieta.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TextCantArieta2.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub TextCantArieta2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCantArieta2.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TextCosto.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub

#End Region

#Region "DataGridViews"

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewBusqueda.CellPainting
        TextCodigoBarra.Text = DataGridViewBusqueda.CurrentRow.Cells(0).Value.ToString()
        TextDescripcion.Text = DataGridViewBusqueda.CurrentRow.Cells(1).Value.ToString()
        TextCosto.Text = DataGridViewBusqueda.CurrentRow.Cells(2).Value.ToString()
        TextPorcentaje.Text = DataGridViewBusqueda.CurrentRow.Cells(6).Value.ToString()
        TextPrecio.Text = DataGridViewBusqueda.CurrentRow.Cells(3).Value.ToString()
    End Sub
    Private Sub DataGridViewCompra_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridViewCompra.RowsAdded
        Dim precioTotal As Double = Sumar(Column4.Name, DataGridViewCompra, Column3.Name, Column7.Name, A3100.Name)
        TotalNum.Text = FormatNumber(precioTotal.ToString(), 2)
    End Sub

    Private Sub DataGridViewCompra_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridViewCompra.RowsRemoved
        Dim precioTotal As Double = Sumar(Column4.Name, DataGridViewCompra, Column3.Name, Column7.Name, A3100.Name)
        TotalNum.Text = FormatNumber(precioTotal.ToString(), 2)
    End Sub

#End Region

#Region "Funciones esenciales"

    Private Function Sumar(
    ByVal nombre_Columna As String,
    ByVal Dgv As DataGridView, ByVal cantPeru As String, ByVal cantArieta As String, ByVal cantArieta2 As String) As Double

        Dim total As Double = 0

        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value) * (CDbl(Dgv.Item(cantPeru.ToLower, i).Value) + CDbl(Dgv.Item(cantArieta.ToLower, i).Value + CDbl(Dgv.Item(cantArieta2.ToLower, i).Value)))
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' retornar el valor  
        Return total

    End Function




#End Region

End Class

