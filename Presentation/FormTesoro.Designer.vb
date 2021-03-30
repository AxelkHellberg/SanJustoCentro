<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTesoro
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTesoro))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.TotalTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pagos = New System.Windows.Forms.Label()
        Me.BotonPagar = New System.Windows.Forms.Button()
        Me.Pago = New System.Windows.Forms.Label()
        Me.TextPago = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.TextDescripcion = New System.Windows.Forms.TextBox()
        Me.DataGridViewPago = New System.Windows.Forms.DataGridView()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BotonClose = New System.Windows.Forms.PictureBox()
        Me.BotonRetiro = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalTotalArieta = New System.Windows.Forms.Label()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.DataGridViewPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.TotalTotalArieta)
        Me.PanelContenedor.Controls.Add(Me.Label4)
        Me.PanelContenedor.Controls.Add(Me.BotonRetiro)
        Me.PanelContenedor.Controls.Add(Me.TotalTotal)
        Me.PanelContenedor.Controls.Add(Me.Label2)
        Me.PanelContenedor.Controls.Add(Me.Pagos)
        Me.PanelContenedor.Controls.Add(Me.BotonPagar)
        Me.PanelContenedor.Controls.Add(Me.Pago)
        Me.PanelContenedor.Controls.Add(Me.TextPago)
        Me.PanelContenedor.Controls.Add(Me.Descripcion)
        Me.PanelContenedor.Controls.Add(Me.TextDescripcion)
        Me.PanelContenedor.Controls.Add(Me.DataGridViewPago)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(766, 347)
        Me.PanelContenedor.TabIndex = 0
        '
        'TotalTotal
        '
        Me.TotalTotal.AutoSize = True
        Me.TotalTotal.Font = New System.Drawing.Font("Century Gothic", 25.0!, System.Drawing.FontStyle.Bold)
        Me.TotalTotal.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalTotal.Location = New System.Drawing.Point(478, 60)
        Me.TotalTotal.Name = "TotalTotal"
        Me.TotalTotal.Size = New System.Drawing.Size(84, 40)
        Me.TotalTotal.TabIndex = 83
        Me.TotalTotal.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Location = New System.Drawing.Point(75, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 40)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "TESORO CENTRAL $"
        '
        'Pagos
        '
        Me.Pagos.AutoSize = True
        Me.Pagos.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pagos.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Pagos.Location = New System.Drawing.Point(273, 154)
        Me.Pagos.Name = "Pagos"
        Me.Pagos.Size = New System.Drawing.Size(217, 24)
        Me.Pagos.TabIndex = 76
        Me.Pagos.Text = "Movimientos del día"
        '
        'BotonPagar
        '
        Me.BotonPagar.FlatAppearance.BorderSize = 0
        Me.BotonPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonPagar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonPagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonPagar.Image = Global.Presentation.My.Resources.Resources.pngegg__2_
        Me.BotonPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonPagar.Location = New System.Drawing.Point(362, 302)
        Me.BotonPagar.Name = "BotonPagar"
        Me.BotonPagar.Size = New System.Drawing.Size(106, 44)
        Me.BotonPagar.TabIndex = 81
        Me.BotonPagar.Text = "  Pagar"
        Me.BotonPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonPagar.UseVisualStyleBackColor = True
        '
        'Pago
        '
        Me.Pago.AutoSize = True
        Me.Pago.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pago.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Pago.Location = New System.Drawing.Point(290, 297)
        Me.Pago.Name = "Pago"
        Me.Pago.Size = New System.Drawing.Size(39, 17)
        Me.Pago.TabIndex = 80
        Me.Pago.Text = "Pago"
        '
        'TextPago
        '
        Me.TextPago.Location = New System.Drawing.Point(293, 317)
        Me.TextPago.Name = "TextPago"
        Me.TextPago.Size = New System.Drawing.Size(63, 20)
        Me.TextPago.TabIndex = 79
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Descripcion.Location = New System.Drawing.Point(40, 297)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(79, 17)
        Me.Descripcion.TabIndex = 78
        Me.Descripcion.Text = "Descripción"
        '
        'TextDescripcion
        '
        Me.TextDescripcion.Location = New System.Drawing.Point(43, 317)
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.Size = New System.Drawing.Size(244, 20)
        Me.TextDescripcion.TabIndex = 77
        '
        'DataGridViewPago
        '
        Me.DataGridViewPago.AllowUserToAddRows = False
        Me.DataGridViewPago.AllowUserToDeleteRows = False
        Me.DataGridViewPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewPago.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridViewPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPago.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPago.ColumnHeadersHeight = 30
        Me.DataGridViewPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewPago.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewPago.EnableHeadersVisualStyles = False
        Me.DataGridViewPago.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewPago.Location = New System.Drawing.Point(38, 181)
        Me.DataGridViewPago.Name = "DataGridViewPago"
        Me.DataGridViewPago.ReadOnly = True
        Me.DataGridViewPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPago.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewPago.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewPago.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewPago.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewPago.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewPago.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewPago.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewPago.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewPago.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPago.Size = New System.Drawing.Size(705, 111)
        Me.DataGridViewPago.TabIndex = 75
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.Label3)
        Me.PanelBarraTitulo.Controls.Add(Me.Label1)
        Me.PanelBarraTitulo.Controls.Add(Me.BotonClose)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(766, 40)
        Me.PanelBarraTitulo.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.Location = New System.Drawing.Point(351, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "TESORO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 24)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "F5 actualizar"
        '
        'BotonClose
        '
        Me.BotonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonClose.Image = CType(resources.GetObject("BotonClose.Image"), System.Drawing.Image)
        Me.BotonClose.Location = New System.Drawing.Point(740, 10)
        Me.BotonClose.Name = "BotonClose"
        Me.BotonClose.Size = New System.Drawing.Size(18, 16)
        Me.BotonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BotonClose.TabIndex = 3
        Me.BotonClose.TabStop = False
        '
        'BotonRetiro
        '
        Me.BotonRetiro.FlatAppearance.BorderSize = 0
        Me.BotonRetiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonRetiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonRetiro.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonRetiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonRetiro.Image = Global.Presentation.My.Resources.Resources.payment1
        Me.BotonRetiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonRetiro.Location = New System.Drawing.Point(627, 301)
        Me.BotonRetiro.Name = "BotonRetiro"
        Me.BotonRetiro.Size = New System.Drawing.Size(105, 43)
        Me.BotonRetiro.TabIndex = 84
        Me.BotonRetiro.Text = "Retiro"
        Me.BotonRetiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonRetiro.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label4.Location = New System.Drawing.Point(75, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(326, 40)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "TESORO ARIETA    $"
        '
        'TotalTotalArieta
        '
        Me.TotalTotalArieta.AutoSize = True
        Me.TotalTotalArieta.Font = New System.Drawing.Font("Century Gothic", 25.0!, System.Drawing.FontStyle.Bold)
        Me.TotalTotalArieta.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalTotalArieta.Location = New System.Drawing.Point(478, 100)
        Me.TotalTotalArieta.Name = "TotalTotalArieta"
        Me.TotalTotalArieta.Size = New System.Drawing.Size(84, 40)
        Me.TotalTotalArieta.TabIndex = 86
        Me.TotalTotalArieta.Text = "0.00"
        '
        'FormTesoro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(766, 347)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Name = "FormTesoro"
        Me.Text = "Tesoro"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.DataGridViewPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents TotalTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Pagos As Label
    Friend WithEvents BotonPagar As Button
    Friend WithEvents Pago As Label
    Friend WithEvents TextPago As TextBox
    Friend WithEvents Descripcion As Label
    Friend WithEvents TextDescripcion As TextBox
    Friend WithEvents DataGridViewPago As DataGridView
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BotonClose As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BotonRetiro As Button
    Friend WithEvents TotalTotalArieta As Label
    Friend WithEvents Label4 As Label
End Class
