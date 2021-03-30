<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BotonCobranzas = New System.Windows.Forms.Button()
        Me.BotonAnalisis = New System.Windows.Forms.Button()
        Me.BotonTesoro = New System.Windows.Forms.Button()
        Me.BotonCaja = New System.Windows.Forms.Button()
        Me.BotonCompra = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.TextoTelefono = New System.Windows.Forms.Label()
        Me.TextoSucursal = New System.Windows.Forms.Label()
        Me.TextoPrincipal = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.TextoAltura = New System.Windows.Forms.Label()
        Me.panelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.panelContenedor.Controls.Add(Me.PanelFormularios)
        Me.panelContenedor.Controls.Add(Me.PanelMenu)
        Me.panelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(900, 650)
        Me.panelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.White
        Me.PanelFormularios.Controls.Add(Me.PictureBox1)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(131, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(769, 610)
        Me.PanelFormularios.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Presentation.My.Resources.Resources._695664d2490fd207af48a719d4fc3df3_icono_de_la_computadora_de_escritorio_by_vexels
        Me.PictureBox1.Location = New System.Drawing.Point(200, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(374, 263)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BotonCobranzas)
        Me.PanelMenu.Controls.Add(Me.BotonAnalisis)
        Me.PanelMenu.Controls.Add(Me.BotonTesoro)
        Me.PanelMenu.Controls.Add(Me.BotonCaja)
        Me.PanelMenu.Controls.Add(Me.BotonCompra)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(131, 610)
        Me.PanelMenu.TabIndex = 1
        '
        'BotonCobranzas
        '
        Me.BotonCobranzas.FlatAppearance.BorderSize = 0
        Me.BotonCobranzas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonCobranzas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonCobranzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCobranzas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCobranzas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonCobranzas.Image = Global.Presentation.My.Resources.Resources.seo11
        Me.BotonCobranzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonCobranzas.Location = New System.Drawing.Point(3, 255)
        Me.BotonCobranzas.Name = "BotonCobranzas"
        Me.BotonCobranzas.Size = New System.Drawing.Size(131, 45)
        Me.BotonCobranzas.TabIndex = 5
        Me.BotonCobranzas.Text = "Cobranzas"
        Me.BotonCobranzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonCobranzas.UseVisualStyleBackColor = True
        '
        'BotonAnalisis
        '
        Me.BotonAnalisis.FlatAppearance.BorderSize = 0
        Me.BotonAnalisis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonAnalisis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAnalisis.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonAnalisis.Image = Global.Presentation.My.Resources.Resources.calendar__1_1
        Me.BotonAnalisis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonAnalisis.Location = New System.Drawing.Point(3, 204)
        Me.BotonAnalisis.Name = "BotonAnalisis"
        Me.BotonAnalisis.Size = New System.Drawing.Size(131, 45)
        Me.BotonAnalisis.TabIndex = 4
        Me.BotonAnalisis.Text = "Analisis"
        Me.BotonAnalisis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonAnalisis.UseVisualStyleBackColor = True
        '
        'BotonTesoro
        '
        Me.BotonTesoro.FlatAppearance.BorderSize = 0
        Me.BotonTesoro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonTesoro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonTesoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonTesoro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonTesoro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonTesoro.Image = Global.Presentation.My.Resources.Resources.bar_graph1
        Me.BotonTesoro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonTesoro.Location = New System.Drawing.Point(0, 153)
        Me.BotonTesoro.Name = "BotonTesoro"
        Me.BotonTesoro.Size = New System.Drawing.Size(131, 45)
        Me.BotonTesoro.TabIndex = 3
        Me.BotonTesoro.Text = "Tesoro"
        Me.BotonTesoro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonTesoro.UseVisualStyleBackColor = True
        '
        'BotonCaja
        '
        Me.BotonCaja.FlatAppearance.BorderSize = 0
        Me.BotonCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonCaja.Image = Global.Presentation.My.Resources.Resources.phone_book__1_1
        Me.BotonCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonCaja.Location = New System.Drawing.Point(0, 51)
        Me.BotonCaja.Name = "BotonCaja"
        Me.BotonCaja.Size = New System.Drawing.Size(131, 45)
        Me.BotonCaja.TabIndex = 2
        Me.BotonCaja.Text = "Caja"
        Me.BotonCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonCaja.UseVisualStyleBackColor = True
        '
        'BotonCompra
        '
        Me.BotonCompra.FlatAppearance.BorderSize = 0
        Me.BotonCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonCompra.Image = Global.Presentation.My.Resources.Resources.person_settings1
        Me.BotonCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonCompra.Location = New System.Drawing.Point(3, 102)
        Me.BotonCompra.Name = "BotonCompra"
        Me.BotonCompra.Size = New System.Drawing.Size(131, 45)
        Me.BotonCompra.TabIndex = 1
        Me.BotonCompra.Text = "Compra"
        Me.BotonCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonCompra.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = Global.Presentation.My.Resources.Resources.payment1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Venta"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.TextoAltura)
        Me.PanelBarraTitulo.Controls.Add(Me.TextoTelefono)
        Me.PanelBarraTitulo.Controls.Add(Me.TextoSucursal)
        Me.PanelBarraTitulo.Controls.Add(Me.TextoPrincipal)
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimize)
        Me.PanelBarraTitulo.Controls.Add(Me.btnClose)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(900, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'TextoTelefono
        '
        Me.TextoTelefono.AutoSize = True
        Me.TextoTelefono.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoTelefono.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextoTelefono.Location = New System.Drawing.Point(436, 9)
        Me.TextoTelefono.Name = "TextoTelefono"
        Me.TextoTelefono.Size = New System.Drawing.Size(117, 25)
        Me.TextoTelefono.TabIndex = 41
        Me.TextoTelefono.Text = "4651-1601"
        '
        'TextoSucursal
        '
        Me.TextoSucursal.AutoSize = True
        Me.TextoSucursal.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoSucursal.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextoSucursal.Location = New System.Drawing.Point(267, 9)
        Me.TextoSucursal.Name = "TextoSucursal"
        Me.TextoSucursal.Size = New System.Drawing.Size(0, 25)
        Me.TextoSucursal.TabIndex = 40
        '
        'TextoPrincipal
        '
        Me.TextoPrincipal.AutoSize = True
        Me.TextoPrincipal.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoPrincipal.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextoPrincipal.Location = New System.Drawing.Point(141, 9)
        Me.TextoPrincipal.Name = "TextoPrincipal"
        Me.TextoPrincipal.Size = New System.Drawing.Size(136, 25)
        Me.TextoPrincipal.TabIndex = 39
        Me.TextoPrincipal.Text = "Sucursal de "
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = Global.Presentation.My.Resources.Resources.Minimize
        Me.btnRestaurar.Location = New System.Drawing.Point(850, 10)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(18, 16)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaurar.TabIndex = 6
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = Global.Presentation.My.Resources.Resources.maximize3
        Me.btnMaximizar.Location = New System.Drawing.Point(850, 10)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(18, 16)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 5
        Me.btnMaximizar.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = Global.Presentation.My.Resources.Resources.Material_icons_01_08_512
        Me.btnMinimize.Location = New System.Drawing.Point(826, 10)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(18, 16)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Presentation.My.Resources.Resources.x_close_icon_white
        Me.btnClose.Location = New System.Drawing.Point(874, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(18, 16)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        '
        'TextoAltura
        '
        Me.TextoAltura.AutoSize = True
        Me.TextoAltura.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoAltura.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextoAltura.Location = New System.Drawing.Point(346, 9)
        Me.TextoAltura.Name = "TextoAltura"
        Me.TextoAltura.Size = New System.Drawing.Size(0, 25)
        Me.TextoAltura.TabIndex = 42
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 650)
        Me.Controls.Add(Me.panelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.panelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelContenedor As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents BotonCompra As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextoSucursal As Label
    Friend WithEvents TextoPrincipal As Label
    Friend WithEvents TextoTelefono As Label
    Friend WithEvents BotonCaja As Button
    Public WithEvents BotonTesoro As Button
    Public WithEvents BotonAnalisis As Button
    Public WithEvents BotonCobranzas As Button
    Friend WithEvents TextoAltura As Label
End Class
