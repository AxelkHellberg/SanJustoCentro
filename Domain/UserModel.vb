Imports System.Data
Imports DataAccess
Imports System.Runtime.InteropServices

Public Class UserModel
    Dim userDao As New UserDao()

    Public Function Login(user As String, pass As String) As Boolean
        Return userDao.Login(user, pass)
    End Function

    Public Function InsertarProducto(codigo As String, desc As String, cantP As Integer, cantA As Integer, costo As Single, porcentaje As Single, precio As Single, cantA2 As Integer) As Boolean
        Return userDao.InsertarProducto(codigo, desc, cantP, cantA, costo, porcentaje, precio, cantA2)
    End Function
    Public Function AcumularProducto(codigo As String, cantP As Integer, cantA As Integer, costo As Single, porcentaje As Single, precio As Single, cantA2 As Integer) As Boolean
        Return userDao.AcumularProducto(codigo, cantP, cantA, costo, porcentaje, precio, cantA2)
    End Function
    Public Function ComprarProductos(codigo As String, desc As String, cantP As Integer, cantA As Integer, costo As Single, porcentaje As Single, precio As Single, cantA2 As Integer) As Boolean
        Return userDao.ComprarProductosUserDao(codigo, desc, cantP, cantA, costo, porcentaje, precio, cantA2)
    End Function

    Public Function VenderProductos(codigo As String, cant As Integer, vendedor As String, codVenta As Integer) As Boolean
        Return userDao.VenderProductosUserDao(codigo, cant, vendedor, codVenta)
    End Function
    Public Function InsertarEnConfirmar(total As Single, ajuste As Single, efectivo As Single, tarjeta As Single, interes As Single) As Integer
        Return userDao.InsertarEnConfirmarUserDao(total, ajuste, efectivo, tarjeta, interes)
    End Function

    Public Function cargarEnCaja(total As Single, efectivo As Single, tarjeta As Single, codVenta As Integer) As Boolean
        Return userDao.cargarEnCajaUserDao(total, efectivo, tarjeta, codVenta)
    End Function

    Public Function cargarEnCajaCobro(total As Single, efectivo As Single, tarjeta As Single, tarjetaSinInteres As Single, codCli As Integer) As Boolean
        Return userDao.cargarEnCajaCobroUserDao(total, efectivo, tarjeta, tarjetaSinInteres, codCli)
    End Function

    Public Function Pagar(pago As Double, sucursal As String, descripcion As String) As Boolean
        Return userDao.PagarUserDao(pago, sucursal, descripcion)
    End Function

    Public Function PagarTesoro(pago As Double, sucursal As String, descripcion As String) As Boolean
        Return userDao.PagarTesoroUserDao(pago, sucursal, descripcion)
    End Function

    Public Function CerrarCaja(efectivo As Double) As Boolean
        Return userDao.CerrarCajaUserDao(efectivo)
    End Function

    Public Function Comprobar(pass As String, objeto As String) As Boolean
        Return userDao.ComprobarUserDao(pass, objeto)
    End Function

    Public Function Retiro(efectivo As Double) As Boolean
        Return userDao.RetiroUserDao(efectivo)
    End Function

    Public Function eliminarVenta(codVenta As Integer) As Boolean
        Return userDao.eliminarVentaUserDao(codVenta)
    End Function

    Public Function RetirarTesoro(total As Double) As Boolean
        Return userDao.RetirarTesoroUserDao(total)
    End Function

    Public Function agregarCliente(nombre As String) As Boolean
        Return userDao.agregarClienteUserDao(nombre)
    End Function

    Public Function descontarSaldoCliente(total As Single, ajuste As Single, efectivo As Single, tarjeta As Single, interes As Single, nombre As String) As Integer
        Return userDao.descontarSaldoClienteUserDao(total, ajuste, efectivo, tarjeta, interes, nombre)
    End Function




End Class
