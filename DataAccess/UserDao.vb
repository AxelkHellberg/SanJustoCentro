Imports System.Data
Imports System.Data.SqlClient
Imports CapaComun


Public Class UserDao
    Inherits ConnectionToSql

    Public Function Login(user As String, pass As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select *FROM users WHERE LoginName=@user and Password=@pass"
                command.Parameters.AddWithValue("@user", user)
                command.Parameters.AddWithValue("@pass", pass)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        idUser = reader.GetString(0)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function InsertarProducto(codigo As String, desc As String, cantP As Integer, cantA As Integer, costo As Single, porcentaje As Single, precio As Single, cantA2 As Integer) As Boolean


        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()

                command.Connection = connection
                command.CommandText = "BEGIN Try BEGIN TRANSACTION INSERT INTO Producto VALUES (@cod,@desc,@costo,@precio,@cantP,@cantA,@porcentaje,@cantA2) COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                command.Parameters.AddWithValue("@cod", codigo)
                command.Parameters.AddWithValue("@desc", desc)
                command.Parameters.AddWithValue("@cantP", cantP)
                command.Parameters.AddWithValue("@cantA", cantA)
                command.Parameters.AddWithValue("@cantA2", cantA2)
                command.Parameters.AddWithValue("@costo", costo)
                command.Parameters.AddWithValue("@porcentaje", porcentaje)
                command.Parameters.AddWithValue("@precio", precio)
                command.CommandType = CommandType.Text

                Dim rd = command.ExecuteNonQuery()
                If rd = 0 Then
                    Return False
                Else
                    Return True
                End If
            End Using
        End Using

    End Function

    Public Function AcumularProducto(codigo As String, cantP As Integer, cantA As Integer, costo As Single, porcentaje As Single, precio As Single, cantA2 As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "BEGIN Try BEGIN TRANSACTION UPDATE Producto SET stockPeru+=@cantP,stockArieta+=@cantA,stockArieta2+=@cantA2,costo=@costo,precio=@precio,porcentaje=@porcentaje WHERE codigo=@codigo COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                command.Parameters.AddWithValue("@codigo", codigo)
                command.Parameters.AddWithValue("@cantP", cantP)
                command.Parameters.AddWithValue("@cantA", cantA)
                command.Parameters.AddWithValue("@cantA2", cantA2)
                command.Parameters.AddWithValue("@costo", costo)
                command.Parameters.AddWithValue("@porcentaje", porcentaje)
                command.Parameters.AddWithValue("@precio", precio)
                command.CommandType = CommandType.Text
                Dim rd = command.ExecuteNonQuery()
                If rd = 0 Then
                    Return False
                Else
                    Return True
                End If
            End Using
        End Using
    End Function

    Public Function ComprarProductosUserDao(codigo As String, desc As String, cantP As Integer, cantA As Integer, costo As Single, porcentaje As Single, precio As Single, cantA2 As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select codigo FROM Producto WHERE codigo=@cod"
                command.Parameters.AddWithValue("@cod", codigo)
                command.CommandType = CommandType.Text
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                If rd.HasRows Then
                    rd.Dispose()
                    Return AcumularProducto(codigo, cantP, cantA, costo, porcentaje, precio, cantA2)
                Else
                    Return InsertarProducto(codigo, desc, cantP, cantA, costo, porcentaje, precio, cantA2)
                End If
            End Using
        End Using
    End Function

    Public Function VenderProductosUserDao(codigo As String, cant As Integer, vendedor As String, codVenta As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection

                If sucursalPA = "Peru" Then
                    command.CommandText = "BEGIN Try BEGIN TRANSACTION update Producto set stockPeru-=@cant WHERE codigo=@cod insert into Vende values(@codVenta,@cod,@vendedor,sanjusto_sanjusto.DevolverFecha(),@cant) COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                Else
                    If sucursalPA = "Arieta" And sucursalAltura = "3395" Then
                        command.CommandText = "BEGIN Try BEGIN TRANSACTION update Producto set stockArieta-=@cant WHERE codigo=@cod insert into Vende values(@codVenta,@cod,@vendedor,sanjusto_sanjusto.DevolverFecha(),@cant) COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                    Else
                        command.CommandText = "BEGIN Try BEGIN TRANSACTION update Producto set stockArieta2-=@cant WHERE codigo=@cod insert into Vende values(@codVenta,@cod,@vendedor,sanjusto_sanjusto.DevolverFecha(),@cant) COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                    End If
                End If
                command.Parameters.AddWithValue("@cod", codigo)
                command.Parameters.AddWithValue("@cant", cant)
                command.Parameters.AddWithValue("@codVenta", codVenta)
                command.Parameters.AddWithValue("@vendedor", vendedor)
                command.CommandType = CommandType.Text
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()
                'command.CommandText = "insert into Vende values(@codVenta,@cod,@vendedor,sanjusto_sanjusto.DevolverFecha(),@cant)"
                'command.Parameters.AddWithValue("@vendedor", vendedor)
                'command.Parameters.AddWithValue("@codVenta", codVenta)
                'rd = command.ExecuteReader()
                'rd.Dispose()

                Return True

            End Using
        End Using
    End Function

    Public Function InsertarEnConfirmarUserDao(total As Single, ajuste As Single, efectivo As Single, tarjeta As Single, interes As Single) As Integer
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "BEGIN Try BEGIN TRANSACTION insert into Venta (sucursal,total,efectivo,tarjeta,ajuste,interes) values(@sucu,@total,@efectivo,@tarjeta,@ajuste,@interes) insert into Confirmacion (sucursal,total,efectivo,tarjeta,ajuste,interes) values(@sucu,@total,@efectivo,@tarjeta,@ajuste,@interes) COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                If sucursalPA = "Peru" Then
                    command.Parameters.AddWithValue("@sucu", sucursalPA)
                Else
                    If sucursalAltura = "3100" Then
                        command.Parameters.AddWithValue("@sucu", "Arieta2")
                    Else
                        command.Parameters.AddWithValue("@sucu", "Arieta")
                    End If
                End If
                command.Parameters.AddWithValue("@total", total)
                command.Parameters.AddWithValue("@efectivo", efectivo)
                command.Parameters.AddWithValue("@tarjeta", tarjeta)
                command.Parameters.AddWithValue("@ajuste", ajuste)
                command.Parameters.AddWithValue("@interes", interes)
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()
                'command.CommandText = "insert into Confirmacion (sucursal,total,efectivo,tarjeta,ajuste,interes) values(@sucu,@total,@efectivo,@tarjeta,@ajuste,@interes)"
                'rd = command.ExecuteReader()
                'rd.Dispose()
                command.CommandText = "SELECT sanjusto_sanjusto.UltimoInsertado()"
                Dim CodVenta As Integer = command.ExecuteScalar()
                Return CodVenta

            End Using
        End Using
    End Function
    Public Function cargarEnCajaUserDao(total As Single, efectivo As Single, tarjeta As Single, codVenta As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                If sucursalPA = "Peru" Then
                    command.CommandText = "BEGIN TRY BEGIN TRANSACTION UPDATE Caja SET total+=@total,efectivo+=@efectivo,tarjeta+=@tarjeta WHERE sucursal=@sucu  DELETE FROM Confirmacion WHERE codVenta=@codVenta COMMIT TRANSACTION; END TRY BEGIN CATCH ROLLBACK TRANSACTION; END CATCH;"
                Else
                    If sucursalAltura = "3100" Then
                        command.CommandText = "BEGIN TRY BEGIN TRANSACTION UPDATE Caja SET total+=@total,efectivo+=@efectivo,tarjeta+=@tarjeta WHERE sucursal='Arieta2'  DELETE FROM Confirmacion WHERE codVenta=@codVenta COMMIT TRANSACTION; END TRY BEGIN CATCH ROLLBACK TRANSACTION; END CATCH;"
                    Else
                        command.CommandText = "BEGIN TRY BEGIN TRANSACTION UPDATE Caja SET total+=@total,efectivo+=@efectivo,tarjeta+=@tarjeta WHERE sucursal=@sucu  DELETE FROM Confirmacion WHERE codVenta=@codVenta COMMIT TRANSACTION; END TRY BEGIN CATCH ROLLBACK TRANSACTION; END CATCH;"
                    End If
                End If
                command.Parameters.AddWithValue("@sucu", sucursalPA)
                command.Parameters.AddWithValue("@total", total)
                command.Parameters.AddWithValue("@efectivo", efectivo)
                command.Parameters.AddWithValue("@tarjeta", tarjeta)
                command.Parameters.AddWithValue("@codVenta", codVenta)
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()
                'command.CommandText = "DELETE FROM Confirmacion WHERE codVenta=@codVenta"
                'command.Parameters.AddWithValue("@codVenta", codVenta)
                'rd = command.ExecuteReader()
                'rd.Dispose()
                Return True
            End Using
        End Using
    End Function

    Public Function cargarEnCajaCobroUserDao(total As Single, efectivo As Single, tarjeta As Single, descontar As Single, codCli As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "BEGIN TRY BEGIN TRANSACTION INSERT INTO PagoDeCliente VALUES(@codCli,@efectivo,@tarjeta,sanjusto_sanjusto.DevolverFecha(),@totalEfTar) UPDATE Cliente SET Deuda-=@descontar where codCliente=@codCli COMMIT TRANSACTION; END TRY BEGIN CATCH ROLLBACK TRANSACTION; END CATCH;"
                If sucursalPA = "Peru" Then
                    command.Parameters.AddWithValue("@sucu", sucursalPA)
                Else
                    If sucursalAltura = "3100" Then
                        command.Parameters.AddWithValue("@sucu", "Arieta2")
                    Else
                        command.Parameters.AddWithValue("@sucu", sucursalPA)

                    End If
                End If
                command.Parameters.AddWithValue("@total", total)
                command.Parameters.AddWithValue("@descontar", descontar)
                command.Parameters.AddWithValue("@codCli", codCli)
                command.Parameters.AddWithValue("@efectivo", efectivo)
                command.Parameters.AddWithValue("@tarjeta", tarjeta)
                command.Parameters.AddWithValue("@totalEfTar", tarjeta + efectivo)
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()
                command.CommandText = "BEGIN TRY BEGIN TRANSACTION UPDATE Caja SET total+=@total,efectivo+=@efectivo,tarjeta+=@tarjeta WHERE sucursal=@sucu COMMIT TRANSACTION; END TRY BEGIN CATCH ROLLBACK TRANSACTION; END CATCH;"
                rd = command.ExecuteReader()
                rd.Dispose()
                'command.CommandText = "DELETE FROM Confirmacion WHERE codVenta=@codVenta"
                'command.Parameters.AddWithValue("@codVenta", codVenta)
                'rd = command.ExecuteReader()
                'rd.Dispose()
                Return True
            End Using
        End Using
    End Function

    Public Function PagarUserDao(pago As Double, sucursal As String, descripcion As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "BEGIN Try BEGIN TRANSACTION UPDATE Caja SET efectivo-=@pago WHERE sucursal=@sucu INSERT INTO Pago (descripcion,total,fecha,sucursal,desde) values(@desc,@pago,sanjusto_sanjusto.DevolverFecha(),@sucu,'Caja') COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                If sucursalPA = "Peru" Then
                    command.Parameters.AddWithValue("@sucu", sucursalPA)
                Else
                    If sucursalAltura = "3100" Then
                        command.Parameters.AddWithValue("@sucu", "Arieta2")
                    Else
                        command.Parameters.AddWithValue("@sucu", sucursalPA)

                    End If
                End If
                command.Parameters.AddWithValue("@pago", pago)
                command.Parameters.AddWithValue("@desc", descripcion)
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()
                'command.CommandText = "INSERT INTO Pago (descripcion,total,fecha,sucursal) values(@desc,@pago,sanjusto_sanjusto.DevolverFecha(),@sucu)"
                'command.Parameters.AddWithValue("@desc", descripcion)
                'rd = command.ExecuteReader()
                'rd.Dispose()

                Return True
            End Using
        End Using
    End Function

    Public Function PagarTesoroUserDao(pago As Double, sucursal As String, descripcion As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.Parameters.AddWithValue("@sucu", sucursal)
                command.Parameters.AddWithValue("@pago", pago)
                command.Parameters.AddWithValue("@desc", descripcion)
                If sucursalPA = "Arieta" Then
                    If sucursalAltura = "3100" Then
                        command.CommandText = "BEGIN Try BEGIN TRANSACTION UPDATE Tesoro SET efectivo-=@pago WHERE sucursal='Arieta2' INSERT INTO Pago (descripcion,total,fecha,sucursal,desde) values(@desc,@pago,sanjusto_sanjusto.DevolverFecha(),'A3100','Tesoro ARIETA 3100') COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                    Else
                        command.CommandText = "BEGIN Try BEGIN TRANSACTION UPDATE Tesoro SET efectivo-=@pago WHERE sucursal='Arieta' INSERT INTO Pago (descripcion,total,fecha,sucursal,desde) values(@desc,@pago,sanjusto_sanjusto.DevolverFecha(),'A3300','Tesoro ARIETA 3300') COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                    End If
                Else
                    command.CommandText = "BEGIN Try BEGIN TRANSACTION UPDATE Tesoro SET efectivo-=@pago WHERE sucursal='Peru' INSERT INTO Pago (descripcion,total,fecha,sucursal,desde) values(@desc,@pago,sanjusto_sanjusto.DevolverFecha(),'Peru','Tesoro PERU') COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                End If
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()
                'command.CommandText = "INSERT INTO Pago (descripcion,total,fecha,sucursal) values(@desc,@pago,sanjusto_sanjusto.DevolverFecha(),@sucu)"
                'command.Parameters.AddWithValue("@desc", descripcion)
                '' command.Parameters.AddWithValue("@fecha", DateTime.Today)
                'rd = command.ExecuteReader()
                'rd.Dispose()

                Return True
            End Using
        End Using
    End Function

    Public Function CerrarCajaUserDao(efectivo As Double) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "BEGIN Try BEGIN TRANSACTION UPDATE Caja SET total=0,efectivo=0,tarjeta=0 WHERE sucursal=@sucu UPDATE Tesoro SET efectivo+=@total WHERE sucursal=@sucu COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                If sucursalPA = "Peru" Then
                    command.Parameters.AddWithValue("@sucu", sucursalPA)
                Else
                    If sucursalAltura = "3100" Then
                        command.Parameters.AddWithValue("@sucu", "Arieta2")
                    Else
                        command.Parameters.AddWithValue("@sucu", sucursalPA)

                    End If
                End If
                command.Parameters.AddWithValue("@total", efectivo)
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()
                'command.CommandText = "UPDATE Tesoro SET efectivo+=@total WHERE sucursal=@sucu"
                'command.Parameters.AddWithValue("@total", efectivo)
                'rd = command.ExecuteReader()
                'rd.Dispose()
                Return True
            End Using
        End Using
    End Function

    Public Function ComprobarUserDao(pass As String, objeto As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select * FROM pass WHERE pass=@pass and objeto=@objeto"
                command.Parameters.AddWithValue("@objeto", objeto)
                command.Parameters.AddWithValue("@pass", pass)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function RetiroUserDao(efectivo As Double) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "BEGIN Try BEGIN TRANSACTION INSERT INTO Pago (descripcion,total,fecha,sucursal,desde) VALUES('RETIRO',@total,sanjusto_sanjusto.DevolverFecha(),@sucu,'Caja') UPDATE Caja SET efectivo-=@total WHERE sucursal=@sucu  UPDATE Tesoro SET efectivo+=@total WHERE sucursal=@sucu COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                command.Parameters.AddWithValue("@total", efectivo)
                If sucursalPA = "Peru" Then
                    command.Parameters.AddWithValue("@sucu", sucursalPA)
                Else
                    If sucursalAltura = "3100" Then
                        command.Parameters.AddWithValue("@sucu", "Arieta2")
                    Else
                        command.Parameters.AddWithValue("@sucu", sucursalPA)

                    End If
                End If
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()
                'command.CommandText = "UPDATE Tesoro SET efectivo+=@total WHERE sucursal=@sucu"
                'rd = command.ExecuteReader()
                'rd.Dispose()
                Return True
            End Using
        End Using
    End Function

    Public Function eliminarVentaUserDao(codVenta As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "EXEC sanjusto_sanjusto.eliminarVenta @cod = @codventa"
                command.Parameters.AddWithValue("@codventa", codVenta)
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()
                Return True
            End Using
        End Using
    End Function

    Public Function RetirarTesoroUserDao(total As Double) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.Parameters.AddWithValue("@sucu", sucursalPA)
                command.Parameters.AddWithValue("@pago", total)
                If sucursalPA = "Arieta" And sucursalAltura = "3395" Then
                    command.CommandText = "BEGIN Try BEGIN TRANSACTION UPDATE Tesoro SET efectivo-=@pago WHERE sucursal='Arieta' UPDATE Tesoro SET efectivo+=@pago WHERE sucursal='Peru' INSERT INTO Pago (descripcion,total,fecha,sucursal,desde) values('RETIRO DE TESORO ARIETA 3300',@pago,sanjusto_sanjusto.DevolverFecha(),@sucu,'Tesoro') COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                Else
                    command.CommandText = "BEGIN Try BEGIN TRANSACTION UPDATE Tesoro SET efectivo-=@pago WHERE sucursal='Arieta2' UPDATE Tesoro SET efectivo+=@pago WHERE sucursal='Peru' INSERT INTO Pago (descripcion,total,fecha,sucursal,desde) values('RETIRO DE TESORO ARIETA 3100',@pago,sanjusto_sanjusto.DevolverFecha(),@sucu,'Tesoro') COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                End If
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()

                Return True
            End Using
        End Using
    End Function
    Public Function agregarClienteUserDao(nombre As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "BEGIN Try BEGIN TRANSACTION INSERT INTO Cliente (nombre,Deuda) VALUES(@nombre,0) COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                command.Parameters.AddWithValue("@nombre", nombre)
                Dim rd As SqlDataReader

                rd = command.ExecuteReader()
                rd.Dispose()

                Return True
            End Using
        End Using
    End Function

    Public Function agregarCompraClienteUserDao(codProd As String, cant As Integer, cliente As String, precioProducto As Double) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "BEGIN Try BEGIN TRANSACTION INSERT INTO ClienteRetiroProducto (codCliente,codProd,cant,fechaCompra,precioProducto) VALUES(@cliente,@codProd,@cant,sanjusto_sanjusto.DevolverFecha(),@precioProducto) COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                command.Parameters.AddWithValue("@cliente", cliente)
                command.Parameters.AddWithValue("@codProd", codProd)
                command.Parameters.AddWithValue("@cant", cant)
                command.Parameters.AddWithValue("@precioProducto", precioProducto)
                Dim rd As SqlDataReader

                rd = command.ExecuteReader()
                rd.Dispose()

                Return True
            End Using
        End Using
    End Function


    Public Function descontarSaldoClienteUserDao(total As Single, ajuste As Single, efectivo As Single, tarjeta As Single, interes As Single, nombre As String) As Integer
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "BEGIN Try BEGIN TRANSACTION UPDATE Cliente SET Deuda+=@total where nombre=@nombre insert into Venta (sucursal,total,efectivo,tarjeta,ajuste,interes) values(@sucu,@total,@efectivo,@tarjeta,@ajuste,@interes) insert into Confirmacion (sucursal,total,efectivo,tarjeta,ajuste,interes) values(@sucu,@total,@efectivo,@tarjeta,@ajuste,@interes) COMMIT TRANSACTION; End Try BEGIN Catch ROLLBACK TRANSACTION; End Catch;"
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@total", total)
                If sucursalPA = "Peru" Then
                    command.Parameters.AddWithValue("@sucu", sucursalPA)
                Else
                    If sucursalAltura = "3100" Then
                        command.Parameters.AddWithValue("@sucu", "Arieta2")
                    Else
                        command.Parameters.AddWithValue("@sucu", sucursalPA)

                    End If
                End If
                command.Parameters.AddWithValue("@efectivo", efectivo)
                command.Parameters.AddWithValue("@tarjeta", tarjeta)
                command.Parameters.AddWithValue("@ajuste", ajuste)
                command.Parameters.AddWithValue("@interes", interes)
                Dim rd As SqlDataReader
                rd = command.ExecuteReader()
                rd.Dispose()
                command.CommandText = "SELECT sanjusto_sanjusto.UltimoInsertado()"
                Dim CodVenta As Integer = command.ExecuteScalar()
                command.CommandText = "DELETE FROM Confirmacion WHERE codventa=@codven"
                command.Parameters.AddWithValue("@codven", CodVenta)
                rd = command.ExecuteReader()
                rd.Dispose()
                Return CodVenta
            End Using
        End Using
    End Function



End Class
