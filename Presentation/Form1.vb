Imports Domain
Imports System.Data.SqlClient
Public Class FormCliente
    Private Sub BotonClose_Click(sender As Object, e As EventArgs) Handles BotonClose.Click
        Me.Close()
    End Sub

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

    Private Sub panelContenedor_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelContenedor.MouseClick
        Me.BringToFront()
    End Sub



#End Region

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                If String.IsNullOrEmpty(TextCliente.Text) Then
                    MessageBox.Show("Debe rellenar el campo 'Cliente'")
                    Exit Sub
                Else
                    command.CommandText = "select nombre as Cliente FROM Cliente WHERE nombre LIKE '%'+@nombre+'%'"
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
                    DataGridViewBusqueda.Columns(0).Width = 80
                    DataGridViewBusqueda.Focus()

                Else
                    DataGridViewBusqueda.Columns.Clear()
                    MessageBox.Show("No se encontro ningun cliente.")
                    da2.Dispose()
                End If


            End Using
        End Using
    End Sub

    Private Sub TextCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCliente.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonBuscar_Click(sender, e)
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        TextCliente.Clear()
    End Sub

    Private Sub BotonAgregarCliente_Click(sender As Object, e As EventArgs) Handles BotonAgregarCliente.Click
        Dim userModel As New UserModel()
        Try
            Dim valid = userModel.agregarCliente(TextCliente.Text)
            BotonBuscar_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Error no puede existir dos clientes con el mismo nombre.")
        End Try
    End Sub

    Private Sub DataGridViewBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewBusqueda.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Dim frm As FormVenta = CType(Owner, FormVenta)
                frm.ClienteAsignado.Text = DataGridViewBusqueda.CurrentRow.Cells(0).Value.ToString()
                frm.CheckCliente.Checked = True
                e.SuppressKeyPress = True
                Me.Close()
        End Select
    End Sub

    Private Sub DataGridViewBusqueda_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewBusqueda.DoubleClick
        Dim frm As FormVenta = CType(Owner, FormVenta)
        frm.ClienteAsignado.Text = DataGridViewBusqueda.CurrentRow.Cells(0).Value.ToString()
        frm.CheckCliente.Checked = True
        Me.Close()
    End Sub

    Private Sub DataGridViewBusqueda_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewBusqueda.CellPainting
        TextCliente.Text = DataGridViewBusqueda.CurrentRow.Cells(0).Value.ToString()
    End Sub
End Class