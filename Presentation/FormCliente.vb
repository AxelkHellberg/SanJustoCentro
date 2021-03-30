Imports Domain
Imports System.Data.SqlClient

Public Class FormCobranzas
    Private Sub BotonClose_Click(sender As Object, e As EventArgs) Handles BotonClose.Click
        Me.Close()
    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        TextCliente.Clear()
        TextEfectivo.Clear()
        TextCodigo.Clear()
        TextTarjeta.Clear()
        TextDebito.Clear()
        TextCouta.Clear()
        TextInteres.Clear()
        TextCliente.Focus()
    End Sub


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



#End Region


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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                If String.IsNullOrEmpty(TextCliente.Text) Then
                    MessageBox.Show("Debe rellenar el campo 'Cliente'")
                    Exit Sub
                Else
                    command.CommandText = "select codCliente as Codigo,nombre as Cliente,Deuda as Deuda FROM Cliente WHERE nombre LIKE '%'+@nombre+'%'"
                    command.Parameters.AddWithValue("@nombre", TextCliente.Text)
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
                    DataGridViewBusqueda.Columns(0).Width = 10
                    DataGridViewBusqueda.Columns(1).Width = 30
                    DataGridViewBusqueda.Columns(2).Width = 80
                    DataGridViewBusqueda.Focus()

                Else
                    DataGridViewBusqueda.Columns.Clear()
                    da2.Dispose()
                End If


            End Using
        End Using
    End Sub

    Private Sub DataGridViewBusqueda_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewBusqueda.CellPainting
        TextCliente.Text = DataGridViewBusqueda.CurrentRow.Cells(1).Value.ToString()
        TextCodigo.Text = DataGridViewBusqueda.CurrentRow.Cells(0).Value.ToString()
    End Sub

    Private Sub DataGridViewBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewBusqueda.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TextEfectivo.Clear()
                TextTarjeta.Clear()
                TextDebito.Clear()
                TextCouta.Clear()
                TextInteres.Clear()
                TextEfectivo.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub



    Private Sub TextCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCliente.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Button1_Click(sender, e)
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub Boton3Coutas_Click(sender As Object, e As EventArgs) Handles Boton3Coutas.Click
        If Not String.IsNullOrEmpty(TextInteres.Text) Then
            '   TextEfectivo.Text -= TextInteres.Text
        End If
        If Not String.IsNullOrEmpty(TextTarjeta.Text) Then
            Dim monto As Double = TextTarjeta.Text
            Dim interes As Double
            interes = Convert.ToInt32(monto * 0.2)
            TextInteres.Text = interes
            TextCouta.Text = Convert.ToInt32((monto + interes) / 3)
            '  TextEfectivo.Text += interes
        End If
    End Sub

    Private Sub Cuota1_Click(sender As Object, e As EventArgs) Handles Cuota1.Click
        If Not String.IsNullOrEmpty(TextInteres.Text) Then
            '         TextEfectivo.Text -= TextInteres.Text
        End If
        If Not String.IsNullOrEmpty(TextTarjeta.Text) Then
            Dim monto As Double = TextTarjeta.Text
            Dim interes As Double
            interes = Convert.ToInt32(monto * 0.1)
            TextInteres.Text = interes
            TextCouta.Text = Convert.ToInt32((monto + interes) / 1)
            '    TextEfectivo.Text += interes
        End If
    End Sub

    Private Sub Boton6Coutas_Click(sender As Object, e As EventArgs) Handles Boton6Coutas.Click
        If Not String.IsNullOrEmpty(TextInteres.Text) Then
            '   TextEfectivo.Text -= TextInteres.Text
        End If
        If Not String.IsNullOrEmpty(TextTarjeta.Text) Then
            Dim monto As Double = TextTarjeta.Text
            Dim interes As Double
            interes = Convert.ToInt32(monto * 0.25)
            TextInteres.Text = interes
            TextCouta.Text = Convert.ToInt32((monto + interes) / 6)
            '  TextEfectivo.Text += interes
        End If
    End Sub

    Private Sub Boton12Coutas_Click(sender As Object, e As EventArgs) Handles Boton12Coutas.Click
        If Not String.IsNullOrEmpty(TextInteres.Text) Then
            '  TextEfectivo.Text -= TextInteres.Text
        End If
        If Not String.IsNullOrEmpty(TextTarjeta.Text) Then
            Dim monto As Double = TextTarjeta.Text
            Dim interes As Double
            interes = Convert.ToInt32(monto * 0.3)
            TextInteres.Text = interes
            TextCouta.Text = Convert.ToInt32((monto + interes) / 12)
            '   TextEfectivo.Text += interes
        End If
    End Sub

    Private Sub BotonCobrar_Click(sender As Object, e As EventArgs) Handles BotonCobrar.Click
        Dim userModel As New UserModel()
        Dim valid As Boolean
        Dim efectivo As Double
        Dim tarjeta As Double
        Dim debito As Double
        If Not String.IsNullOrEmpty(TextTarjeta.Text) Then
            efectivo = TextEfectivo.Text
        Else
            efectivo = 0
        End If
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
        If Not String.IsNullOrEmpty(TextDebito.Text) Then
            debito = TextDebito.Text
        Else
            debito = 0
        End If

        valid = userModel.cargarEnCajaCobro(efectivo + tarjeta + interes + debito, efectivo, tarjeta + interes + debito, tarjeta + debito + efectivo, TextCodigo.Text)

        If valid = False Then
            MessageBox.Show("Error al vender el producto" + vbNewLine + "Por favor, intente nuevamente." + vbNewLine + "o llamar a Axel")
        End If

        Button1_Click(sender, e)
        BotonLimpiar_Click(sender, e)

    End Sub


End Class