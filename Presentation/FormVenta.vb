Imports System.Runtime.InteropServices
Imports Domamain
Public Class FormVenta

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


#End Region

#Region "Botones cerrar"
    Private Sub BotonClose_Click(sender As Object, e As EventArgs) Handles BotonClose.Click
        Me.Close()
    End Sub

#End Region

#Region "Cambiar formulario de tamaño"

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

    Private Sub PanelBarraTitulo_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseClick

    End Sub


#End Region

#Region "Boton Buscar"
    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        Dim userModel As New UserModel()
        If String.IsNullOrEmpty(TextCodigoBarra.Text) Then
            If String.IsNullOrEmpty(TextDescripcion.Text) Then
                MessageBox.Show("Debe rellenar algun campo")
            Else
                Dim valid = userModel.BuscarPorDescripcion(TextDescripcion.Text)
            End If
        Else
            If String.IsNullOrEmpty(TextDescripcion.Text) Then
                Dim valid = userModel.BuscarPorCodigo(TextCodigoBarra.Text)
            Else
                Dim valid = userModel.BuscarPorCodigoAndDescripcion(TextCodigoBarra.Text, TextDescripcion.Text)
            End If
        End If

        If valid = True Then
            Dim frm As New FormPrincipal()
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña invalido." + vbNewLine + "Por favor, intente nuevamente.")
            txtPass.Clear()
            txtPass.Focus()
        End If
    End Sub


#End Region

End Class