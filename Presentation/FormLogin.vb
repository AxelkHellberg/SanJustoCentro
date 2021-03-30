Imports System.Runtime.InteropServices
Imports Domain
Imports CapaComun
Public Class FormLogin
#Region "Form Behaviors"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

#Region "Drag Forms"

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region

#Region "Customize Controls"
    Private Sub CustomizeComponents()
        'txtUser
        txtUser.AutoSize = False
        txtUser.Size = New Size(270, 28)
        'txtPass
        txtPass.AutoSize = False
        txtPass.Size = New Size(270, 28)
        txtPass.UseSystemPasswordChar = True
    End Sub
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = Button1.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        Button1.Region = New Region(buttonPath)
    End Sub
#End Region
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CustomizeComponents()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextSucursal.Text) Or String.IsNullOrEmpty(txtPass.Text) Or String.IsNullOrEmpty(txtUser.Text) Then
            MessageBox.Show("Debe rellenar TODOS los campos.")
            Exit Sub
        End If
        If TextSucursal.Text = 1 Then
            sucursalPA = "Peru"
            sucursalAltura = "2517"
        Else
            If TextSucursal.Text = 2 Then
                sucursalPA = "Arieta"
                sucursalAltura = "3395"
            Else
                If TextSucursal.Text = 3 Then
                    sucursalPA = "Arieta"
                    sucursalAltura = "3100"
                Else
                    MessageBox.Show("Error en la sucursal.")
                    Exit Sub
                End If
            End If
        End If
        Dim userModel As New UserModel()
        Dim validLogin = userModel.Login(txtUser.Text, txtPass.Text)
        If validLogin = True Then
            Dim frm As New FormPrincipal()
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña invalido." + vbNewLine + "Por favor, intente nuevamente.")
            txtPass.Clear()
            txtPass.Focus()
        End If
    End Sub


    Private Sub TextSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles TextSucursal.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            Button1_Click(sender, e)
        End If
    End Sub

End Class
