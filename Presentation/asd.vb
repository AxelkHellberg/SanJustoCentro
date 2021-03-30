
Imports Domain
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class FormCompra

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
    End Sub

    Private connectionString As String
    Public Sub conectar()
        connectionString = "Server=IGGI662\PRUEBA1; DataBase=CentroComputacion; integrated security = true"
    End Sub
    Public Function GetConnection() As SqlConnection
        conectar()
        Return New SqlConnection(connectionString)
    End Function

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

    Private Sub AgregarProducto_MouseClick(sender As Object, e As MouseEventArgs)
        sender.visible = False
    End Sub

    Private Sub BotonValidar_Click(sender As Object, e As EventArgs) Handles BotonValidar.Click
        TextCant.Hide()
        Cantidad.Hide()
        TextCosto.Hide()
        Costo.Hide()
        TextPrecio.Hide()
        Precio.Hide()
        BotonConfirmarAgregar.Hide()
        BotonConfirmarAcumular.Hide()
        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                If String.IsNullOrEmpty(TextCodigoBarra.Text) Then
                    If String.IsNullOrEmpty(TextDescripcion.Text) Then
                        MessageBox.Show("Debe rellenar al menos el campo 'Codigo' o 'Descripcion'")
                    Else

                        command.CommandText = "select * FROM Producto WHERE descripcion LIKE '%'+@desc+'%'"
                        command.Parameters.AddWithValue("@desc", TextDescripcion.Text)
                        command.CommandType = CommandType.Text

                    End If
                Else
                    If String.IsNullOrEmpty(TextDescripcion.Text) Then

                        command.CommandText = "select * FROM Producto WHERE codigo LIKE '%'+@cod+'%'"
                        command.Parameters.AddWithValue("@cod", TextCodigoBarra.Text)
                        command.CommandType = CommandType.Text

                    Else

                        command.CommandText = "select * FROM Producto WHERE descripcion LIKE '%'+@desc+'%' AND codigo LIKE '%'+@cod+'%'"
                        command.Parameters.AddWithValue("@desc", TextDescripcion.Text)
                        command.Parameters.AddWithValue("@cod", TextCodigoBarra.Text)
                        command.CommandType = CommandType.Text

                    End If
                End If

                Dim da2 As New SqlDataAdapter(command)
                Dim tabla As New DataTable

                If da2.Fill(tabla) <> 0 Then

                    DataGridView1.Columns.Clear()
                    Dim db As New BindingSource
                    db.DataSource = tabla
                    DataGridView1.DataSource = db
                    da2.Dispose()
                    BotonConfirmarAcumular.Show()
                Else
                    DataGridView1.Columns.Clear()
                    da2.Dispose()
                    BotonConfirmarAgregar.Show()
                End If
                '      If rd.HasRows Then
                '    ListBox1.Items.Clear()
                '    ListBox1.Items.Add(rd)
                '    rd.Dispose()
                '    BotonConfirmarAcumular.Show()
                '    Else
                '    rd.Dispose()
                '    BotonConfirmarAgregar.Show()
                '   End If




            End Using
        End Using


        'ESTA PARTE VA CUANDO SELECCIONA EL PRODUCTO
        TextPorcentaje.Show()
        Porcentaje.Show()
        TextCant.Show()
        Cantidad.Show()
        TextCosto.Show()
        Costo.Show()
        TextPrecio.Show()
        Precio.Show()
    End Sub

    Private Sub TextCant_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCant.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonConfirmarAcumular_Click(sender, e)
        End Select
    End Sub

    Private Sub TextDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles TextDescripcion.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonValidar_Click(sender, e)
        End Select
    End Sub

    Private Sub TextCodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCodigoBarra.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonValidar_Click(sender, e)
        End Select
    End Sub

    Private Sub BotonConfirmarAgregar_Click(sender As Object, e As EventArgs) Handles BotonConfirmarAgregar.Click
        Dim userModel As New UserModel()
        Dim valid = userModel.InsertarProducto(TextCodigoBarra.Text, TextDescripcion.Text, TextCant.Text, TextCosto.Text, TextPrecio.Text)
        If valid = True Then
            TextCant.Hide()
            Cantidad.Hide()
            TextCosto.Hide()
            Costo.Hide()
            TextPrecio.Hide()
            Precio.Hide()
            TextDescripcion.Hide()
            Descripcion.Hide()
            BotonConfirmarAgregar.Hide()
            BotonConfirmarAcumular.Hide()
        Else
            MessageBox.Show("Error al cargar el producto" + vbNewLine + "Por favor, intente nuevamente.")
        End If
        TextCodigoBarra.Clear()
        TextDescripcion.Clear()
        TextCant.Clear()
        TextCosto.Clear()
        TextPrecio.Clear()
    End Sub

    Private Sub BotonConfirmarAcumular_Click(sender As Object, e As EventArgs) Handles BotonConfirmarAcumular.Click
        If String.IsNullOrEmpty(TextCodigoBarra.Text) Or String.IsNullOrEmpty(TextCant.Text) Or String.IsNullOrEmpty(TextCosto.Text) Or String.IsNullOrEmpty(TextPrecio.Text) Then
            MessageBox.Show("Error en el relleno de campos.")
        Else
            Dim userModel As New UserModel()
            Dim valid = userModel.AcumularProducto(TextCodigoBarra.Text, TextCant.Text, TextCosto.Text, TextPrecio.Text)
            If valid = True Then
                TextCant.Hide()
                Cantidad.Hide()
                TextCosto.Hide()
                Costo.Hide()
                TextPrecio.Hide()
                Precio.Hide()
                TextDescripcion.Hide()
                Descripcion.Hide()
                BotonConfirmarAgregar.Hide()
                BotonConfirmarAcumular.Hide()
            Else
                MessageBox.Show("Error al acumular el producto" + vbNewLine + "Por favor, intente nuevamente.")
            End If
            TextCodigoBarra.Clear()
            TextDescripcion.Clear()
            TextCant.Clear()
            TextCosto.Clear()
            TextPrecio.Clear()
        End If
    End Sub


#End Region

#Region "Boton cerrar"

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region


#Region "KeyPress"
    Public Sub SoloNumero(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Error no se permiten letras en este campo.")
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub TextCodigoBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCodigoBarra.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TextCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCosto.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TextPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPrecio.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TextCant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCant.KeyPress
        SoloNumero(e)
    End Sub










#End Region

End Class

