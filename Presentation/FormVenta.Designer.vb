<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.BotonBuscar = New System.Windows.Forms.Button()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.TextDescripcion = New System.Windows.Forms.TextBox()
        Me.CodigoBarra = New System.Windows.Forms.Label()
        Me.TextCodigoBarra = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.BotonClose = New System.Windows.Forms.PictureBox()
        Me.panelContenedor.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.panelContenedor.Controls.Add(Me.BotonBuscar)
        Me.panelContenedor.Controls.Add(Me.Descripcion)
        Me.panelContenedor.Controls.Add(Me.TextDescripcion)
        Me.panelContenedor.Controls.Add(Me.CodigoBarra)
        Me.panelContenedor.Controls.Add(Me.TextCodigoBarra)
        Me.panelContenedor.Controls.Add(Me.ListBox2)
        Me.panelContenedor.Controls.Add(Me.ListBox1)
        Me.panelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(831, 475)
        Me.panelContenedor.TabIndex = 0
        '
        'BotonBuscar
        '
        Me.BotonBuscar.FlatAppearance.BorderSize = 0
        Me.BotonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BotonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonBuscar.Image = Global.Presentation.My.Resources.Resources.magnifier
        Me.BotonBuscar.Location = New System.Drawing.Point(300, 74)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Size = New System.Drawing.Size(43, 37)
        Me.BotonBuscar.TabIndex = 17
        Me.BotonBuscar.UseVisualStyleBackColor = True
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Descripcion.Location = New System.Drawing.Point(85, 62)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(79, 17)
        Me.Descripcion.TabIndex = 16
        Me.Descripcion.Text = "Descripción"
        '
        'TextDescripcion
        '
        Me.TextDescripcion.Location = New System.Drawing.Point(88, 82)
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.Size = New System.Drawing.Size(206, 20)
        Me.TextDescripcion.TabIndex = 15
        '
        'CodigoBarra
        '
        Me.CodigoBarra.AutoSize = True
        Me.CodigoBarra.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoBarra.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.CodigoBarra.Location = New System.Drawing.Point(20, 62)
        Me.CodigoBarra.Name = "CodigoBarra"
        Me.CodigoBarra.Size = New System.Drawing.Size(52, 17)
        Me.CodigoBarra.TabIndex = 14
        Me.CodigoBarra.Text = "Codigo"
        '
        'TextCodigoBarra
        '
        Me.TextCodigoBarra.Location = New System.Drawing.Point(23, 82)
        Me.TextCodigoBarra.Name = "TextCodigoBarra"
        Me.TextCodigoBarra.Size = New System.Drawing.Size(59, 20)
        Me.TextCodigoBarra.TabIndex = 13
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(488, 122)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(320, 277)
        Me.ListBox2.TabIndex = 12
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(23, 122)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(320, 277)
        Me.ListBox1.TabIndex = 11
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.BotonClose)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(831, 40)
        Me.PanelBarraTitulo.TabIndex = 10
        '
        'BotonClose
        '
        Me.BotonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonClose.Image = Global.Presentation.My.Resources.Resources.x_close_icon_white
        Me.BotonClose.Location = New System.Drawing.Point(805, 10)
        Me.BotonClose.Name = "BotonClose"
        Me.BotonClose.Size = New System.Drawing.Size(18, 16)
        Me.BotonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BotonClose.TabIndex = 3
        Me.BotonClose.TabStop = False
        '
        'FormVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 475)
        Me.Controls.Add(Me.panelContenedor)
        Me.MinimumSize = New System.Drawing.Size(847, 514)
        Me.Name = "FormVenta"
        Me.Text = "vImports System.Runtime.InteropServices"
        Me.panelContenedor.ResumeLayout(False)
        Me.panelContenedor.PerformLayout()
        Me.PanelBarraTitulo.ResumeLayout(False)
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents BotonClose As PictureBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextCodigoBarra As TextBox
    Friend WithEvents CodigoBarra As Label
    Friend WithEvents TextDescripcion As TextBox
    Friend WithEvents BotonBuscar As Button
    Friend WithEvents Descripcion As Label
End Class
