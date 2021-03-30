Imports System.Runtime.InteropServices
Imports CapaComun
Public Class FormPrincipal

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        TextoSucursal.Text = sucursalPA
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        PictureBox1_Click(Nothing, Nothing)
        permisos()
    End Sub

#Region "Seguridad"
    Private Sub permisos()
        If idUser = "vendedor" Then
            BotonTesoro.Enabled = False
            BotonCompra.Enabled = False
            BotonCaja.Enabled = False
            BotonAnalisis.Enabled = False
            BotonCobranzas.Enabled = False
        End If
    End Sub

#End Region



#Region "Funcionalidades del Formulario"

    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    Dim cGrip As Integer = 10
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15
    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.panelContenedor.Region = region
        Me.Invalidate()
    End Sub
    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

#Region "Form Behaviors"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub

#End Region

#Region "Drag Forms"

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    PanelBarraTitulo.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            '    Me.BringToFront()
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    PanelBarraTitulo.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            '    Me.BringToFront()
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    PanelBarraTitulo.MouseUp  ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            '    Me.BringToFront()
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub


#End Region

#End Region

#Region "Botones"

    Public Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion'
        'Si form no fue econtrado/ no existe'
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.None
            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub BotonCaja_Click(sender As Object, e As EventArgs) Handles BotonCaja.Click
        AbrirFormEnPanel(Of FormCaja)()
    End Sub

    Public Sub BotonTesoro_Click(sender As Object, e As EventArgs) Handles BotonTesoro.Click
        AbrirFormEnPanel(Of FormTesoro)()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BotonAnalisis.Click
        AbrirFormEnPanel(Of FormAnalisis)()
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles BotonCobranzas.Click
        AbrirFormEnPanel(Of FormCobranzas)()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel(Of FormVenta)()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BotonCompra.Click
        AbrirFormEnPanel(Of FormCompra)()
    End Sub

#End Region

End Class