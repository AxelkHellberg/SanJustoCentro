Imports CapaComun
Imports Domain
Imports System.Data.SqlClient


Public Class FormTesoro

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        actualizarTesoro()
        cargarEnDataGridPagos()
        If sucursalPA = "Peru" Then
            BotonRetiro.Visible = False
        End If
    End Sub

#Region "Botones"

    Private Sub BotonClose_Click(sender As Object, e As EventArgs) Handles BotonClose.Click
        Me.Close()
    End Sub


    Private Sub BotonPagar_Click(sender As Object, e As EventArgs) Handles BotonPagar.Click
        If MessageBox.Show("Desea realizar un pago de " & TextPago.Text & " desde el tesoro?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If String.IsNullOrEmpty(TextPago.Text) Or String.IsNullOrEmpty(TextDescripcion.Text) Then
                MessageBox.Show("Error en el relleno de campos.")
            Else
                Dim pago As Double = TextPago.Text
                Dim desc As String = TextDescripcion.Text
                Dim total As Double = TotalTotal.Text
                Dim userModel As New UserModel()

                Dim valid = userModel.PagarTesoro(pago, sucursalPA, desc)
                If valid = False Then
                    MessageBox.Show("Error al realizar el pago" + vbNewLine + "Por favor, intente nuevamente.")
                End If
                total -= pago
                TotalTotal.Text = FormatNumber(total, 0)
                TextDescripcion.Clear()
                TextPago.Clear()
                cargarEnDataGridPagos()

            End If
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

#Region "Movimiento Ventana"
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        PanelBarraTitulo.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            Me.BringToFront()
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
            DataGridViewPago.Focus()
        End If

    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
        PanelBarraTitulo.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)


        If MoveForm Then
            Me.BringToFront()
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
            DataGridViewPago.Focus()
        End If

    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
        PanelBarraTitulo.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)


        If e.Button = MouseButtons.Left Then
            Me.BringToFront()
            MoveForm = False
            Me.Cursor = Cursors.Default
            DataGridViewPago.Focus()
        End If
    End Sub
    Private Sub panelContenedor_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelContenedor.MouseClick
        Me.BringToFront()
        DataGridViewPago.Focus()
    End Sub

    Private Sub PanelBarraTitulo_MouseClick(sender As Object, e As MouseEventArgs)
        Me.BringToFront()
        DataGridViewPago.Focus()
    End Sub
#End Region

#Region "Funciones esenciales"


    Private Function actualizarTesoro()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT efectivo FROM Tesoro WHERE sucursal='Peru'"
                command.CommandType = CommandType.Text
                TotalTotal.Text = FormatNumber(command.ExecuteScalar(), 0)
                command.CommandText = "SELECT efectivo FROM Tesoro WHERE sucursal='Arieta'"
                TotalTotalArieta.Text = FormatNumber(command.ExecuteScalar(), 0)
                command.CommandText = "SELECT efectivo FROM Tesoro WHERE sucursal='Arieta2'"
                TotalTotalArieta2.Text = FormatNumber(command.ExecuteScalar(), 0)
            End Using
        End Using
        Return True
    End Function

    Private Function cargarEnDataGridPagos()
        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection

                command.CommandText = "SELECT descripcion As Descripcion,FORMAT(fecha,'hh:mm:ss tt') As Fecha,total As Pago,desde as Desde,sucursal as Sucursal FROM Pago WHERE FORMAT(fecha,'dd/MM/yyyy')=FORMAT(sanjusto_sanjusto.DevolverFecha(),'dd/MM/yyyy')"
                command.CommandType = CommandType.Text

                Dim da2 As New SqlDataAdapter(command)
                Dim tabla As New DataTable

                If da2.Fill(tabla) <> 0 Then

                    DataGridViewPago.Columns.Clear()
                    Dim db As New BindingSource
                    db.DataSource = tabla
                    DataGridViewPago.DataSource = db
                    da2.Dispose()
                    DataGridViewPago.BeginEdit(False)

                Else
                    DataGridViewPago.Columns.Clear()
                    da2.Dispose()
                End If


            End Using
        End Using
        Return True
    End Function

#End Region

#Region "Data Grid View"

    Private Sub DataGridViewPago_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewPago.KeyDown
        Select Case e.KeyData
            Case Keys.F5
                cargarEnDataGridPagos()
                actualizarTesoro()
        End Select
    End Sub

    Private Sub BotonRetiro_Click(sender As Object, e As EventArgs) Handles BotonRetiro.Click
        If MessageBox.Show("Desea realizar un retiro de " & TextPago.Text & " desde el tesoro?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim userModel As New UserModel()
            Dim valid = userModel.RetirarTesoro(TextPago.Text)
            Dim pago As Double = TextPago.Text
            If valid = False Then
                MessageBox.Show("Error al realizar el retiro" + vbNewLine + "Por favor, intente nuevamente.")
            End If
            TotalTotal.Text -= pago
            actualizarTesoro()
        End If
    End Sub
#End Region

End Class