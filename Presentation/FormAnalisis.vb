Imports System.Data.SqlClient
Imports Domain

Public Class FormAnalisis
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
    Private Sub panelContenedor_MouseClick(sender As Object, e As MouseEventArgs) Handles Hasta.MouseClick
        Me.BringToFront()
    End Sub


#End Region

#Region "Funciones esenciales"

    Private Function Sumar(
        ByVal nombre_Columna As String,
        ByVal Dgv As DataGridView, ByVal cod As String) As Double

        Dim total As Double = 0
        Dim codVenta As Integer = 0
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                If codVenta <> Dgv.Item(cod.ToLower, i).Value Then
                    total = total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
                    codVenta = Dgv.Item(cod.ToLower, i).Value
                End If
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

    Private Sub BotonClose_Click(sender As Object, e As EventArgs) Handles BotonClose.Click
        Me.Close()
    End Sub

    Private Sub BotonTesoro_Click(sender As Object, e As EventArgs) Handles BotonVentas.Click
        buscarVentasEntreFecha()
    End Sub

    Private Function buscarVentasEntreFecha() As Boolean
        Try
            DataGridViewBusqueda.AllowUserToDeleteRows = False
            Dim userModel As New UserModel()
            Using connection = GetConnection()
                connection.Open()
                Using command = New SqlCommand()

                    command.Connection = connection
                    If CheckSucursal1.Checked = True And CheckSucursal2.Checked = True And CheckSucursal3.Checked Then
                        command.CommandText = "DECLARE @fec1 smalldatetime
                                           DECLARE @fec2 smalldatetime
                                           SET @fec1 = @fecha1
                                           SET @fec2 = @fecha2
                                           SELECT v2.codVenta As CodVenta,p.descripcion As Descripcion,v2.codVendedor as Vendedor ,v1.efectivo as Efectivo,v1.tarjeta as Tarjeta,v1.interes as Interes,v1.total as Total,FORMAT(v2.fecha,'dd/MM/yyyy hh:mm:ss tt') as Fecha
                                           FROM Vende v2 INNER JOIN Producto p ON p.codigo=v2.codProd INNER JOIN Venta v1 ON v1.codVenta=v2.codVenta
                                           WHERE FORMAT(v2.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2
                                           ORDER BY v2.codVenta"
                    Else
                        If (CheckSucursal1.Checked = True And CheckSucursal2.Checked = True And CheckSucursal3.Checked = False) Or (CheckSucursal1.Checked = True And CheckSucursal2.Checked = False And CheckSucursal3.Checked = True) Or (CheckSucursal1.Checked = False And CheckSucursal2.Checked = True And CheckSucursal3.Checked = True) Then
                            DataGridViewBusqueda.Columns.Clear()
                            MessageBox.Show("Error no puede elegir de a pares.")
                            Return False
                        Else
                            If CheckSucursal1.Checked = True Then
                                command.CommandText = "DECLARE @fec1 smalldatetime
                                           DECLARE @fec2 smalldatetime
                                           SET @fec1 = @fecha1
                                           SET @fec2 = @fecha2
                                           SELECT v2.codVenta As CodVenta,p.descripcion As Descripcion,v2.codVendedor as Vendedor ,v1.efectivo as Efectivo,v1.tarjeta as Tarjeta,v1.interes as Interes,v1.total as Total,FORMAT(v2.fecha,'dd/MM/yyyy hh:mm:ss tt') as Fecha
                                           FROM Vende v2 INNER JOIN Producto p ON p.codigo=v2.codProd INNER JOIN Venta v1 ON v1.codVenta=v2.codVenta
                                           WHERE v1.sucursal='Peru' and FORMAT(v2.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2
                                            ORDER BY v2.codVenta"
                            Else
                                If CheckSucursal2.Checked = True Then
                                    command.CommandText = "DECLARE @fec1 smalldatetime
                                           DECLARE @fec2 smalldatetime
                                           SET @fec1 = @fecha1
                                           SET @fec2 = @fecha2
                                           SELECT v2.codVenta As CodVenta,p.descripcion As Descripcion,v2.codVendedor as Vendedor ,v1.efectivo as Efectivo,v1.tarjeta as Tarjeta,v1.interes as Interes,v1.total as Total,FORMAT(v2.fecha,'dd/MM/yyyy hh:mm:ss tt') as Fecha
                                           FROM Vende v2 INNER JOIN Producto p ON p.codigo=v2.codProd INNER JOIN Venta v1 ON v1.codVenta=v2.codVenta
                                           WHERE v1.sucursal='Arieta' and FORMAT(v2.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2
                                            ORDER BY v2.codVenta"
                                Else
                                    If CheckSucursal3.Checked = True Then
                                        command.CommandText = "DECLARE @fec1 smalldatetime
                                           DECLARE @fec2 smalldatetime
                                           SET @fec1 = @fecha1
                                           SET @fec2 = @fecha2
                                           SELECT v2.codVenta As CodVenta,p.descripcion As Descripcion,v2.codVendedor as Vendedor ,v1.efectivo as Efectivo,v1.tarjeta as Tarjeta,v1.interes as Interes,v1.total as Total,FORMAT(v2.fecha,'dd/MM/yyyy hh:mm:ss tt') as Fecha
                                           FROM Vende v2 INNER JOIN Producto p ON p.codigo=v2.codProd INNER JOIN Venta v1 ON v1.codVenta=v2.codVenta
                                           WHERE v1.sucursal='Arieta2' and FORMAT(v2.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2
                                            ORDER BY v2.codVenta"
                                    Else
                                        DataGridViewBusqueda.Columns.Clear()
                                        Return True
                                    End If
                                End If
                            End If
                        End If
                    End If
                        'If CheckSucursal1.Checked = True And CheckSucursal2.Checked = True Then
                        '    command.CommandText = "DECLARE @fec1 smalldatetime
                        '                       DECLARE @fec2 smalldatetime
                        '                       SET @fec1 = @fecha1
                        '                       SET @fec2 = @fecha2
                        '                       SELECT v2.codVenta As CodVenta,p.descripcion As Descripcion,v2.codVendedor as Vendedor ,v1.efectivo as Efectivo,v1.tarjeta as Tarjeta,v1.interes as Interes,v1.total as Total,FORMAT(v2.fecha,'dd/MM/yyyy hh:mm:ss tt') as Fecha
                        '                       FROM Vende v2 INNER JOIN Producto p ON p.codigo=v2.codProd INNER JOIN Venta v1 ON v1.codVenta=v2.codVenta
                        '                       WHERE FORMAT(v2.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2
                        '                       ORDER BY v2.codVenta"
                        'Else
                        '    If CheckSucursal1.Checked = True Then
                        '        command.CommandText = "DECLARE @fec1 smalldatetime
                        '                       DECLARE @fec2 smalldatetime
                        '                       SET @fec1 = @fecha1
                        '                       SET @fec2 = @fecha2
                        '                       SELECT v2.codVenta As CodVenta,p.descripcion As Descripcion,v2.codVendedor as Vendedor ,v1.efectivo as Efectivo,v1.tarjeta as Tarjeta,v1.interes as Interes,v1.total as Total,FORMAT(v2.fecha,'dd/MM/yyyy hh:mm:ss tt') as Fecha
                        '                       FROM Vende v2 INNER JOIN Producto p ON p.codigo=v2.codProd INNER JOIN Venta v1 ON v1.codVenta=v2.codVenta
                        '                       WHERE v1.sucursal='Peru' and FORMAT(v2.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2
                        '                        ORDER BY v2.codVenta"
                        '    Else
                        '        command.CommandText = "DECLARE @fec1 smalldatetime
                        '                       DECLARE @fec2 smalldatetime
                        '                       SET @fec1 = @fecha1
                        '                       SET @fec2 = @fecha2
                        '                       SELECT v2.codVenta As CodVenta,p.descripcion As Descripcion,v2.codVendedor as Vendedor ,v1.efectivo as Efectivo,v1.tarjeta as Tarjeta,v1.interes as Interes,v1.total as Total,FORMAT(v2.fecha,'dd/MM/yyyy hh:mm:ss tt') as Fecha
                        '                       FROM Vende v2 INNER JOIN Producto p ON p.codigo=v2.codProd INNER JOIN Venta v1 ON v1.codVenta=v2.codVenta
                        '                       WHERE v1.sucursal='Arieta' and FORMAT(v2.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2
                        '                        ORDER BY v2.codVenta"
                        '    End If
                        'End If
                        command.Parameters.AddWithValue("@fecha2", Format(DateTimePickerHasta.Value.Date, "yyyy/MM/dd"))
                    command.Parameters.AddWithValue("@fecha1", Format(DateTimePickerDesde.Value.Date, "yyyy/MM/dd"))
                    command.CommandType = CommandType.Text


                    Dim da2 As New SqlDataAdapter(command)
                    Dim tabla As New DataTable

                    If da2.Fill(tabla) <> 0 Then

                        DataGridViewBusqueda.Columns.Clear()
                        Dim db As New BindingSource
                        db.SuspendBinding()
                        db.DataSource = tabla
                        DataGridViewBusqueda.DataSource = db
                        da2.Dispose()
                        DataGridViewBusqueda.BeginEdit(False)
                        DataGridViewBusqueda.Columns(0).Width = 15
                        DataGridViewBusqueda.Columns(1).Width = 65
                        DataGridViewBusqueda.Columns(2).Width = 30
                        DataGridViewBusqueda.Columns(3).Width = 15
                        DataGridViewBusqueda.Columns(4).Width = 15
                        DataGridViewBusqueda.Columns(5).Width = 15
                        DataGridViewBusqueda.Columns(6).Width = 20
                        DataGridViewBusqueda.Columns(7).Width = 60

                        db.ResumeBinding()
                    Else
                        DataGridViewBusqueda.Columns.Clear()
                        da2.Dispose()
                    End If
                    DataGridViewBusqueda.Focus()

                End Using
            End Using
            Dim precioTotal As Double = Sumar(DataGridViewBusqueda.Columns(6).Name, DataGridViewBusqueda, DataGridViewBusqueda.Columns(0).Name)
            TotalNum.Text = FormatNumber(precioTotal.ToString(), 0)

            Return True
        Catch ex As Exception
            MessageBox.Show("Error intente de nuevo.")
        Return False
        End Try
    End Function

    Private Sub BotonComisiones_Click(sender As Object, e As EventArgs) Handles BotonComisiones.Click
        DataGridViewBusqueda.AllowUserToDeleteRows = False
        DataGridViewBusqueda.Columns.Clear()
        Dim totalVendido As Double
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
                    DataGridViewBusqueda.DataSource = db
                    da2.Dispose()
                    DataGridViewBusqueda.BeginEdit(False)

                Else
                    DataGridViewBusqueda.Columns.Clear()
                    da2.Dispose()
                End If

                Dim total As DataGridViewColumn = New DataGridViewTextBoxColumn()
                DataGridViewBusqueda.Columns.Add(total)

                Dim i As Integer
                i = 0
                DataGridViewBusqueda.Columns(1).HeaderText = "Total"
                If DataGridViewBusqueda.Rows.Count > 0 Then
                    For Each Fila As DataGridViewRow In DataGridViewBusqueda.Rows
                        If Not Fila Is Nothing Then

                            command.CommandText = "SELECT SUM(tarjeta+efectivo)
                                                   FROM TotalVendidoPorVendedorEntreFechas(@vendedor,@fecha1,@fecha2)"
                            '     WHERE v2.fecha BETWEEN FORMAT(@fec1,'dd/MM/yyyy hh:mm:ss tt') and FORMAT(@fec2,'dd/MM/yyyy hh:mm:ss tt')

                            command.Parameters.AddWithValue("@fecha2", Format(DateTimePickerHasta.Value.Date, "yyyy/MM/dd"))
                            command.Parameters.AddWithValue("@fecha1", Format(DateTimePickerDesde.Value.Date, "yyyy/MM/dd"))
                            command.Parameters.AddWithValue("@vendedor", Fila.Cells(0).Value().ToString())
                            command.CommandType = CommandType.Text

                            Try
                                totalVendido = command.ExecuteScalar()
                                Fila.Cells(1).Value = totalVendido
                            Catch ex As Exception
                                Fila.Cells(1).Value = 0
                            End Try
                            command.Parameters.clear()
                        End If
                        i += 1
                    Next
                End If

                DataGridViewBusqueda.Focus()

            End Using
        End Using

    End Sub

    Private Sub BotonMovimientos_Click(sender As Object, e As EventArgs) Handles BotonMovimientos.Click
        DataGridViewBusqueda.AllowUserToDeleteRows = False
        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                If CheckSucursal3.Checked = True And CheckSucursal1.Checked = False And CheckSucursal2.Checked = False Then
                    command.CommandText = "DECLARE @fec1 smalldatetime
                                               DECLARE @fec2 smalldatetime
                                               SET @fec1 = @fecha1
                                               SET @fec2 = @fecha2
                                               SELECT descripcion As Descripcion,FORMAT(fecha,'hh:mm:ss tt') As Fecha,total As Pago,desde as Desde,sucursal as Sucursal 
                                               FROM Pago p
                                               WHERE sucursal='Arieta2' and FORMAT(p.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2"
                Else
                    If CheckSucursal1.Checked = True And CheckSucursal2.Checked = False Then
                        command.CommandText = "DECLARE @fec1 smalldatetime
                                               DECLARE @fec2 smalldatetime
                                               SET @fec1 = @fecha1
                                               SET @fec2 = @fecha2
                                               SELECT descripcion As Descripcion,FORMAT(fecha,'hh:mm:ss tt') As Fecha,total As Pago,desde as Desde,sucursal as Sucursal 
                                               FROM Pago p
                                               WHERE sucursal='Peru' and FORMAT(p.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2"
                    Else
                        If CheckSucursal2.Checked = True And CheckSucursal1.Checked = False And CheckSucursal3.Checked = False Then
                            command.CommandText = "DECLARE @fec1 smalldatetime
                                           DECLARE @fec2 smalldatetime
                                           SET @fec1 = @fecha1
                                           SET @fec2 = @fecha2
                                           SELECT descripcion As Descripcion,FORMAT(fecha,'hh:mm:ss tt') As Fecha,total As Pago,desde as Desde,sucursal as Sucursal 
                                           FROM Pago p
                                           WHERE sucursal='Arieta' and FORMAT(p.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2"
                        Else
                            MessageBox.Show("Error, unicamente se puede elegir de a una sucursal.")
                            Exit Sub
                        End If
                    End If
                End If
                'If CheckSucursal1.Checked = True And CheckSucursal2.Checked = True Then
                '    command.CommandText = "DECLARE @fec1 smalldatetime
                '                           DECLARE @fec2 smalldatetime
                '                           SET @fec1 = @fecha1
                '                           SET @fec2 = @fecha2
                '                            SELECT descripcion As Descripcion,FORMAT(fecha,'hh:mm:ss tt') As Fecha,total As Pago,desde as Desde,sucursal as Sucursal
                '                           FROM Pago p
                '                           WHERE FORMAT(p.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2"
                'Else
                '    If CheckSucursal1.Checked = True Then
                '        command.CommandText = "DECLARE @fec1 smalldatetime
                '                               DECLARE @fec2 smalldatetime
                '                               SET @fec1 = @fecha1
                '                               SET @fec2 = @fecha2
                '                               SELECT descripcion As Descripcion,FORMAT(fecha,'hh:mm:ss tt') As Fecha,total As Pago,desde as Desde,sucursal as Sucursal 
                '                               FROM Pago p
                '                               WHERE sucursal='Peru' and FORMAT(p.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2"
                '    Else
                '        command.CommandText = "DECLARE @fec1 smalldatetime
                '                           DECLARE @fec2 smalldatetime
                '                           SET @fec1 = @fecha1
                '                           SET @fec2 = @fecha2
                '                           SELECT descripcion As Descripcion,FORMAT(fecha,'hh:mm:ss tt') As Fecha,total As Pago,desde as Desde,sucursal as Sucursal 
                '                           FROM Pago p
                '                           WHERE sucursal='Arieta' and FORMAT(p.fecha,'yyyy/MM/dd') BETWEEN @fec1 and @fec2"
                '    End If
                'End If
                command.Parameters.AddWithValue("@fecha2", Format(DateTimePickerHasta.Value.Date, "yyyy/MM/dd"))
                command.Parameters.AddWithValue("@fecha1", Format(DateTimePickerDesde.Value.Date, "yyyy/MM/dd"))
                command.CommandType = CommandType.Text

                Dim da2 As New SqlDataAdapter(command)
                Dim tabla As New DataTable

                If da2.Fill(tabla) <> 0 Then

                    DataGridViewBusqueda.Columns.Clear()
                    Dim db As New BindingSource
                    db.DataSource = tabla
                    DataGridViewBusqueda.DataSource = db
                    da2.Dispose()
                    DataGridViewBusqueda.BeginEdit(False)

                Else
                    DataGridViewBusqueda.Columns.Clear()
                    da2.Dispose()
                End If


            End Using
        End Using
    End Sub

    Private Sub BotonProductos_Click(sender As Object, e As EventArgs) Handles BotonProductos.Click
        Try
            DataGridViewBusqueda.AllowUserToDeleteRows = True
            Dim userModel As New UserModel()
            Using connection = GetConnection()
                connection.Open()
                Using command = New SqlCommand()

                    command.Connection = connection
                    command.CommandText = "SELECT codigo as Codigo,descripcion as Descripcion,stockPeru+stockArieta as Stock,precio As Precio
                                            FROM Producto"
                    command.CommandType = CommandType.Text


                    Dim da2 As New SqlDataAdapter(command)
                    Dim tabla As New DataTable

                    If da2.Fill(tabla) <> 0 Then

                        DataGridViewBusqueda.Columns.Clear()
                        Dim db As New BindingSource
                        db.DataSource = tabla
                        DataGridViewBusqueda.DataSource = db
                        da2.Dispose()
                        DataGridViewBusqueda.BeginEdit(False)
                    Else
                        DataGridViewBusqueda.Columns.Clear()
                        da2.Dispose()
                    End If

                    DataGridViewBusqueda.Focus()

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error intente de nuevo.")
        End Try
    End Sub

    Private Sub BotonExportarExcel_Click(sender As Object, e As EventArgs) Handles BotonExportarExcel.Click
        '  ProgressBar1.Visible = True
        ' BackgroundWorker2.RunWorkerAsync()
        ' ProgressBar1.Visible = False
        llenarExcel(DataGridViewBusqueda)
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        llenarExcel(DataGridViewBusqueda)
    End Sub

    Private Sub DataGridViewBusqueda_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridViewBusqueda.UserDeletingRow
        Dim codigo = DataGridViewBusqueda.CurrentRow.Cells(0).Value

        Dim userModel As New UserModel()
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "DELETE FROM Producto WHERE codigo=@cod"
                command.Parameters.AddWithValue("@cod", codigo)
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            DataGridViewBusqueda.AllowUserToDeleteRows = False
            Dim userModel As New UserModel()
            Using connection = GetConnection()
                connection.Open()
                Using command = New SqlCommand()

                    command.Connection = connection
                    command.CommandText = "DECLARE @fec1 smalldatetime
                                           DECLARE @fec2 smalldatetime
                                           SET @fec1 = @fecha1
                                           SET @fec2 = @fecha2
                                           SELECT codProd,descripcion,cantidad,stock,cantidad-stock as Reponer
                                           FROM sanjusto_sanjusto.reposicion(@fec1,@fec2)"

                    command.Parameters.AddWithValue("@fecha2", Format(DateTimePickerHasta.Value.Date, "yyyy/MM/dd"))
                    command.Parameters.AddWithValue("@fecha1", Format(DateTimePickerDesde.Value.Date, "yyyy/MM/dd"))
                    command.CommandType = CommandType.Text


                    Dim da2 As New SqlDataAdapter(command)
                    Dim tabla As New DataTable

                    If da2.Fill(tabla) <> 0 Then

                        DataGridViewBusqueda.Columns.Clear()
                        Dim db As New BindingSource
                        db.SuspendBinding()
                        db.DataSource = tabla
                        DataGridViewBusqueda.DataSource = db
                        da2.Dispose()
                        DataGridViewBusqueda.Columns(0).Width = 200
                        DataGridViewBusqueda.Columns(1).Width = 250
                        db.ResumeBinding()
                    Else
                        DataGridViewBusqueda.Columns.Clear()
                        da2.Dispose()
                    End If
                    DataGridViewBusqueda.Focus()

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error intente de nuevo.")
        End Try
    End Sub
End Class