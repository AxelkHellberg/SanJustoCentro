Imports Domain
Imports System.Data.SqlClient
Imports CapaComun

Public Class FormCaja
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        cargarEnDataGridConfirmar()
        volverCaja()
    End Sub


#Region "Confirmar Venta"

    Private Function confirmarVenta() As Boolean
        Dim userModel As New UserModel()
        Dim valid As Boolean 'codprod,vendedor,total,efectivo,tarjeta,interes,fecha,ajuste
        Dim tarjeta As Double = DataGridViewConfirmar.CurrentRow.Cells(4).Value
        Dim efectivo As Double = DataGridViewConfirmar.CurrentRow.Cells(3).Value
        Dim interes As Double = DataGridViewConfirmar.CurrentRow.Cells(5).Value

        'If tarjeta <> 0 Then
        '    TotalTarjeta.Text += tarjeta + interes
        '    TotalTarjeta.Text = FormatNumber(TotalTarjeta.Text, 0)
        'End If
        'If efectivo <> 0 Then
        '    TotalEfectivo.Text += efectivo
        '    TotalEfectivo.Text = FormatNumber(TotalEfectivo.Text, 0)
        'End If
        'TotalTotal.Text += efectivo + tarjeta + interes
        'TotalTotal.Text = FormatNumber(TotalTotal.Text, 0)
        valid = userModel.cargarEnCaja(efectivo + tarjeta + interes, efectivo, tarjeta + interes, DataGridViewConfirmar.CurrentRow.Cells(0).Value)

        If valid = False Then
            MessageBox.Show("Error al confirmar la venta" + vbNewLine + "Por favor, intente nuevamente." + vbNewLine + "o llamar a Axel")
            Return False
        End If

        volverCaja()
        cargarEnDataGridConfirmar()

        Return True

    End Function

#End Region

#Region "Elimianr Venta"

    Private Function eliminarVenta() As Boolean
        Dim userModel As New UserModel()
        Dim valid As Boolean
        Dim codVenta As Integer = DataGridViewConfirmar.CurrentRow.Cells(0).Value

        valid = userModel.eliminarVenta(codVenta)

        If valid = False Then
            MessageBox.Show("Error al confirmar la venta" + vbNewLine + "Por favor, intente nuevamente." + vbNewLine + "o llamar a Axel")
            Return False
        End If

        Dim i As Integer
        i = DataGridViewConfirmar.CurrentRow.Index
        DataGridViewConfirmar.Rows.RemoveAt(i)

        Return True

    End Function

#End Region

#Region "volver caja"
    Private Function volverCaja()
        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection

                command.CommandText = "SELECT total From Caja WHERE sucursal=@sucu"
                command.Parameters.AddWithValue("@sucu", sucursalPA)
                command.CommandType = CommandType.Text
                TotalTotal.Text = FormatNumber(command.ExecuteScalar(), 0)
                command.CommandText = "SELECT efectivo From Caja WHERE sucursal=@sucu"
                TotalEfectivo.Text = FormatNumber(command.ExecuteScalar(), 0)
                command.CommandText = "SELECT tarjeta From Caja WHERE sucursal=@sucu"
                TotalTarjeta.Text = FormatNumber(command.ExecuteScalar(), 0)

            End Using
        End Using
        Return True
    End Function
#End Region

#Region "FuncionCargarEnDataGrid"
    Private Function cargarEnDataGridConfirmar()
        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection

                command.CommandText = "SELECT distinct v.codVenta as Codigo,codVendedor as Vendedor, total as Total, efectivo As Efectivo, tarjeta As Tarjeta,interes as Interes, FORMAT(fecha,'hh:mm:ss tt') as Hora, ajuste as Ajuste FROM Confirmacion v INNER JOIN Vende ven ON v.codVenta=ven.codVenta WHERE sucursal=@sucu"
                command.Parameters.AddWithValue("@sucu", sucursalPA)
                command.CommandType = CommandType.Text

                Dim da2 As New SqlDataAdapter(command)
                Dim tabla As New DataTable

                If da2.Fill(tabla) <> 0 Then

                    DataGridViewConfirmar.Columns.Clear()
                    Dim db As New BindingSource
                    db.DataSource = tabla
                    DataGridViewConfirmar.DataSource = db
                    da2.Dispose()
                    DataGridViewConfirmar.BeginEdit(False)

                Else
                    DataGridViewConfirmar.Columns.Clear()
                    da2.Dispose()
                End If

                DataGridViewConfirmar.Focus()

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

#Region "Funcion Sumar"

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

#Region "Botones"

    Private Sub BotonClose_Click_1(sender As Object, e As EventArgs) Handles BotonClose.Click
        Me.Close()
    End Sub

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
            DataGridViewConfirmar.Focus()
        End If

    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
        PanelBarraTitulo.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)


        If MoveForm Then
            Me.BringToFront()
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
            DataGridViewConfirmar.Focus()
        End If

    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
        PanelBarraTitulo.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)


        If e.Button = MouseButtons.Left Then
            Me.BringToFront()
            MoveForm = False
            Me.Cursor = Cursors.Default
            DataGridViewConfirmar.Focus()
        End If
    End Sub
    Private Sub panelContenedor_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelContenedor.MouseClick
        Me.BringToFront()
        DataGridViewConfirmar.Focus()
    End Sub

    Private Sub PanelBarraTitulo_MouseClick(sender As Object, e As MouseEventArgs)
        Me.BringToFront()
        DataGridViewConfirmar.Focus()
    End Sub


#End Region

#Region "KeyDown"
    Private Sub DataGridViewConfirmar_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewConfirmar.KeyDown
        Select Case e.KeyData
            Case Keys.F5
                cargarEnDataGridPagos()
                cargarEnDataGridConfirmar()
                volverCaja()
            Case Keys.Enter
                confirmarVenta()
            Case Keys.F12
                eliminarVenta()
        End Select
    End Sub

    Private Sub TextDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles TextDescripcion.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TextPago.Focus()
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub TextPago_KeyDown(sender As Object, e As KeyEventArgs) Handles TextPago.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BotonPagar_Click(sender, e)
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub BotonPagar_Click(sender As Object, e As EventArgs) Handles BotonPagar.Click
        If MessageBox.Show("Desea realizar un pago de " & TextPago.Text & " desde la caja?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If String.IsNullOrEmpty(TextPago.Text) Or String.IsNullOrEmpty(TextDescripcion.Text) Then
                MessageBox.Show("Error en el relleno de campos.")
            Else
                Dim pago As Double = TextPago.Text
                Dim desc As String = TextDescripcion.Text
                Dim userModel As New UserModel()

                Dim valid = userModel.Pagar(pago, sucursalPA, desc)
                If valid = False Then
                    MessageBox.Show("Error al realizar el pago" + vbNewLine + "Por favor, intente nuevamente.")
                End If
                TotalEfectivo.Text -= pago
                TextDescripcion.Clear()
                TextPago.Clear()
                cargarEnDataGridPagos()

            End If
        End If
    End Sub

#End Region

#Region "Evento Clic"
    Private Sub DataGridViewConfirmar_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridViewConfirmar.MouseClick
        Me.BringToFront()
    End Sub

    Private Sub ButtonCerrarCaja_Click(sender As Object, e As EventArgs) Handles ButtonCerrarCaja.Click
        If MessageBox.Show("Desea cerrar la caja?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim userModel As New UserModel()

            Dim valid = userModel.CerrarCaja(TotalEfectivo.Text)
            If valid = False Then
                MessageBox.Show("Error al realizar el pago" + vbNewLine + "Por favor, intente nuevamente.")
            End If
            volverCaja()
            DataGridViewPago.Columns.Clear()
        End If
    End Sub

    Private Sub BotonRetiro_Click(sender As Object, e As EventArgs) Handles BotonRetiro.Click
        If MessageBox.Show("Desea realizar un retiro de " & TextPago.Text & " desde la caja?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim userModel As New UserModel()
            Dim valid = userModel.Retiro(TextPago.Text)
            Dim pago As Double = TextPago.Text
            If valid = False Then
                MessageBox.Show("Error al realizar el retiro" + vbNewLine + "Por favor, intente nuevamente.")
            End If
            TotalEfectivo.Text -= pago
        End If
    End Sub





#End Region

End Class