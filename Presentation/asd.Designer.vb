<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCompra
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Porcentaje = New System.Windows.Forms.Label()
        Me.TextPorcentaje = New System.Windows.Forms.TextBox()
        Me.BotonValidar = New System.Windows.Forms.Button()
        Me.BotonConfirmarAcumular = New System.Windows.Forms.Button()
        Me.BotonConfirmarAgregar = New System.Windows.Forms.Button()
        Me.Precio = New System.Windows.Forms.Label()
        Me.TextPrecio = New System.Windows.Forms.TextBox()
        Me.Costo = New System.Windows.Forms.Label()
        Me.TextCosto = New System.Windows.Forms.TextBox()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.TextCant = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.TextDescripcion = New System.Windows.Forms.TextBox()
        Me.CodigoBarra = New System.Windows.Forms.Label()
        Me.TextCodigoBarra = New System.Windows.Forms.TextBox()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.panelContenedor.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.panelContenedor.Controls.Add(Me.DataGridView1)
        Me.panelContenedor.Controls.Add(Me.Porcentaje)
        Me.panelContenedor.Controls.Add(Me.TextPorcentaje)
        Me.panelContenedor.Controls.Add(Me.BotonValidar)
        Me.panelContenedor.Controls.Add(Me.BotonConfirmarAcumular)
        Me.panelContenedor.Controls.Add(Me.BotonConfirmarAgregar)
        Me.panelContenedor.Controls.Add(Me.Precio)
        Me.panelContenedor.Controls.Add(Me.TextPrecio)
        Me.panelContenedor.Controls.Add(Me.Costo)
        Me.panelContenedor.Controls.Add(Me.TextCosto)
        Me.panelContenedor.Controls.Add(Me.Cantidad)
        Me.panelContenedor.Controls.Add(Me.TextCant)
        Me.panelContenedor.Controls.Add(Me.Descripcion)
        Me.panelContenedor.Controls.Add(Me.TextDescripcion)
        Me.panelContenedor.Controls.Add(Me.CodigoBarra)
        Me.panelContenedor.Controls.Add(Me.TextCodigoBarra)
        Me.panelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(595, 336)
        Me.panelContenedor.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(26, 134)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.Size = New System.Drawing.Size(452, 153)
        Me.DataGridView1.TabIndex = 26
        '
        'Porcentaje
        '
        Me.Porcentaje.AutoSize = True
        Me.Porcentaje.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Porcentaje.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Porcentaje.Location = New System.Drawing.Point(400, 65)
        Me.Porcentaje.Name = "Porcentaje"
        Me.Porcentaje.Size = New System.Drawing.Size(17, 17)
        Me.Porcentaje.TabIndex = 25
        Me.Porcentaje.Text = "%"
        Me.Porcentaje.Visible = False
        '
        'TextPorcentaje
        '
        Me.TextPorcentaje.Location = New System.Drawing.Point(389, 85)
        Me.TextPorcentaje.Name = "TextPorcentaje"
        Me.TextPorcentaje.Size = New System.Drawing.Size(40, 20)
        Me.TextPorcentaje.TabIndex = 24
        Me.TextPorcentaje.Visible = False
        '
        'BotonValidar
        '
        Me.BotonValidar.FlatAppearance.BorderSize = 0
        Me.BotonValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonValidar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonValidar.Location = New System.Drawing.Point(35, 108)
        Me.BotonValidar.Name = "BotonValidar"
        Me.BotonValidar.Size = New System.Drawing.Size(43, 20)
        Me.BotonValidar.TabIndex = 23
        Me.BotonValidar.Text = "Validar"
        Me.BotonValidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonValidar.UseVisualStyleBackColor = True
        Me.BotonValidar.Visible = False
        '
        'BotonConfirmarAcumular
        '
        Me.BotonConfirmarAcumular.FlatAppearance.BorderSize = 0
        Me.BotonConfirmarAcumular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonConfirmarAcumular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonConfirmarAcumular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonConfirmarAcumular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonConfirmarAcumular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonConfirmarAcumular.Image = Global.Presentation.My.Resources.Resources.bluefilefolder_azul_archivo_12582__2_
        Me.BotonConfirmarAcumular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonConfirmarAcumular.Location = New System.Drawing.Point(484, 70)
        Me.BotonConfirmarAcumular.Name = "BotonConfirmarAcumular"
        Me.BotonConfirmarAcumular.Size = New System.Drawing.Size(104, 46)
        Me.BotonConfirmarAcumular.TabIndex = 21
        Me.BotonConfirmarAcumular.Text = "Acumular"
        Me.BotonConfirmarAcumular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonConfirmarAcumular.UseVisualStyleBackColor = True
        Me.BotonConfirmarAcumular.Visible = False
        '
        'BotonConfirmarAgregar
        '
        Me.BotonConfirmarAgregar.FlatAppearance.BorderSize = 0
        Me.BotonConfirmarAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonConfirmarAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonConfirmarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonConfirmarAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonConfirmarAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonConfirmarAgregar.Image = Global.Presentation.My.Resources.Resources.bluefilefolder_azul_archivo_12582__2_
        Me.BotonConfirmarAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonConfirmarAgregar.Location = New System.Drawing.Point(493, 70)
        Me.BotonConfirmarAgregar.Name = "BotonConfirmarAgregar"
        Me.BotonConfirmarAgregar.Size = New System.Drawing.Size(95, 46)
        Me.BotonConfirmarAgregar.TabIndex = 20
        Me.BotonConfirmarAgregar.Text = "Agregar"
        Me.BotonConfirmarAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonConfirmarAgregar.UseVisualStyleBackColor = True
        Me.BotonConfirmarAgregar.Visible = False
        '
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Precio.Location = New System.Drawing.Point(432, 65)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(46, 17)
        Me.Precio.TabIndex = 19
        Me.Precio.Text = "Precio"
        Me.Precio.Visible = False
        '
        'TextPrecio
        '
        Me.TextPrecio.Location = New System.Drawing.Point(435, 85)
        Me.TextPrecio.Name = "TextPrecio"
        Me.TextPrecio.Size = New System.Drawing.Size(40, 20)
        Me.TextPrecio.TabIndex = 18
        Me.TextPrecio.Visible = False
        '
        'Costo
        '
        Me.Costo.AutoSize = True
        Me.Costo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costo.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Costo.Location = New System.Drawing.Point(340, 65)
        Me.Costo.Name = "Costo"
        Me.Costo.Size = New System.Drawing.Size(43, 17)
        Me.Costo.TabIndex = 17
        Me.Costo.Text = "Costo"
        Me.Costo.Visible = False
        '
        'TextCosto
        '
        Me.TextCosto.Location = New System.Drawing.Point(343, 85)
        Me.TextCosto.Name = "TextCosto"
        Me.TextCosto.Size = New System.Drawing.Size(40, 20)
        Me.TextCosto.TabIndex = 16
        Me.TextCosto.Visible = False
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Cantidad.Location = New System.Drawing.Point(300, 65)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(37, 17)
        Me.Cantidad.TabIndex = 15
        Me.Cantidad.Text = "Cant"
        Me.Cantidad.Visible = False
        '
        'TextCant
        '
        Me.TextCant.Location = New System.Drawing.Point(303, 85)
        Me.TextCant.Name = "TextCant"
        Me.TextCant.Size = New System.Drawing.Size(34, 20)
        Me.TextCant.TabIndex = 14
        Me.TextCant.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Descripcion.Location = New System.Drawing.Point(88, 65)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(79, 17)
        Me.Descripcion.TabIndex = 13
        Me.Descripcion.Text = "Descripción"
        Me.Descripcion.Visible = False
        '
        'TextDescripcion
        '
        Me.TextDescripcion.Location = New System.Drawing.Point(91, 85)
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.Size = New System.Drawing.Size(206, 20)
        Me.TextDescripcion.TabIndex = 12
        Me.TextDescripcion.Visible = False
        '
        'CodigoBarra
        '
        Me.CodigoBarra.AutoSize = True
        Me.CodigoBarra.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoBarra.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.CodigoBarra.Location = New System.Drawing.Point(23, 65)
        Me.CodigoBarra.Name = "CodigoBarra"
        Me.CodigoBarra.Size = New System.Drawing.Size(52, 17)
        Me.CodigoBarra.TabIndex = 11
        Me.CodigoBarra.Text = "Codigo"
        Me.CodigoBarra.Visible = False
        '
        'TextCodigoBarra
        '
        Me.TextCodigoBarra.Location = New System.Drawing.Point(26, 85)
        Me.TextCodigoBarra.Name = "TextCodigoBarra"
        Me.TextCodigoBarra.Size = New System.Drawing.Size(59, 20)
        Me.TextCodigoBarra.TabIndex = 10
        Me.TextCodigoBarra.Visible = False
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.btnClose)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(595, 40)
        Me.PanelBarraTitulo.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Presentation.My.Resources.Resources.x_close_icon_white
        Me.btnClose.Location = New System.Drawing.Point(569, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(18, 16)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        '
        'FormCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(595, 336)
        Me.Controls.Add(Me.panelContenedor)
        Me.MaximumSize = New System.Drawing.Size(675, 610)
        Me.MinimumSize = New System.Drawing.Size(375, 310)
        Me.Name = "FormCompra"
        Me.Text = "Form2"
        Me.panelContenedor.ResumeLayout(False)
        Me.panelContenedor.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents TextCodigoBarra As TextBox
    Friend WithEvents CodigoBarra As Label
    Friend WithEvents Descripcion As Label
    Friend WithEvents TextDescripcion As TextBox
    Friend WithEvents Cantidad As Label
    Friend WithEvents TextCant As TextBox
    Friend WithEvents Precio As Label
    Friend WithEvents TextPrecio As TextBox
    Friend WithEvents Costo As Label
    Friend WithEvents TextCosto As TextBox
    Friend WithEvents BotonConfirmarAgregar As Button
    Friend WithEvents BotonConfirmarAcumular As Button
    Friend WithEvents BotonValidar As Button
    Friend WithEvents Porcentaje As Label
    Friend WithEvents TextPorcentaje As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
