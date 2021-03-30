<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCaja
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCaja))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.BotonRetiro = New System.Windows.Forms.Button()
        Me.ButtonCerrarCaja = New System.Windows.Forms.Button()
        Me.BotonPagar = New System.Windows.Forms.Button()
        Me.Pagos = New System.Windows.Forms.Label()
        Me.Pago = New System.Windows.Forms.Label()
        Me.TextPago = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.TextDescripcion = New System.Windows.Forms.TextBox()
        Me.Confirmaciones = New System.Windows.Forms.Label()
        Me.DataGridViewPago = New System.Windows.Forms.DataGridView()
        Me.DataGridViewConfirmar = New System.Windows.Forms.DataGridView()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BotonClose = New System.Windows.Forms.PictureBox()
        Me.TotalTotal = New System.Windows.Forms.Label()
        Me.TotalTarjeta = New System.Windows.Forms.Label()
        Me.TotalEfectivo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tarjeta = New System.Windows.Forms.Label()
        Me.Efectivo = New System.Windows.Forms.Label()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.DataGridViewPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewConfirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.BotonRetiro)
        Me.PanelContenedor.Controls.Add(Me.ButtonCerrarCaja)
        Me.PanelContenedor.Controls.Add(Me.BotonPagar)
        Me.PanelContenedor.Controls.Add(Me.Pagos)
        Me.PanelContenedor.Controls.Add(Me.Pago)
        Me.PanelContenedor.Controls.Add(Me.TextPago)
        Me.PanelContenedor.Controls.Add(Me.Descripcion)
        Me.PanelContenedor.Controls.Add(Me.TextDescripcion)
        Me.PanelContenedor.Controls.Add(Me.Confirmaciones)
        Me.PanelContenedor.Controls.Add(Me.DataGridViewPago)
        Me.PanelContenedor.Controls.Add(Me.DataGridViewConfirmar)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Controls.Add(Me.TotalTotal)
        Me.PanelContenedor.Controls.Add(Me.TotalTarjeta)
        Me.PanelContenedor.Controls.Add(Me.TotalEfectivo)
        Me.PanelContenedor.Controls.Add(Me.Label1)
        Me.PanelContenedor.Controls.Add(Me.Tarjeta)
        Me.PanelContenedor.Controls.Add(Me.Efectivo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(800, 450)
        Me.PanelContenedor.TabIndex = 0
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
        Me.BotonRetiro.Location = New System.Drawing.Point(502, 403)
        Me.BotonRetiro.Name = "BotonRetiro"
        Me.BotonRetiro.Size = New System.Drawing.Size(105, 43)
        Me.BotonRetiro.TabIndex = 68
        Me.BotonRetiro.Text = "Retiro"
        Me.BotonRetiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonRetiro.UseVisualStyleBackColor = True
        '
        'ButtonCerrarCaja
        '
        Me.ButtonCerrarCaja.FlatAppearance.BorderSize = 0
        Me.ButtonCerrarCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ButtonCerrarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ButtonCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrarCaja.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCerrarCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCerrarCaja.Image = Global.Presentation.My.Resources.Resources.blue_monument_library_roma_12570
        Me.ButtonCerrarCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCerrarCaja.Location = New System.Drawing.Point(648, 404)
        Me.ButtonCerrarCaja.Name = "ButtonCerrarCaja"
        Me.ButtonCerrarCaja.Size = New System.Drawing.Size(106, 44)
        Me.ButtonCerrarCaja.TabIndex = 67
        Me.ButtonCerrarCaja.Text = "Cerrar Caja"
        Me.ButtonCerrarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCerrarCaja.UseVisualStyleBackColor = True
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
        Me.BotonPagar.Location = New System.Drawing.Point(368, 403)
        Me.BotonPagar.Name = "BotonPagar"
        Me.BotonPagar.Size = New System.Drawing.Size(106, 44)
        Me.BotonPagar.TabIndex = 66
        Me.BotonPagar.Text = "  Pagar"
        Me.BotonPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonPagar.UseVisualStyleBackColor = True
        '
        'Pagos
        '
        Me.Pagos.AutoSize = True
        Me.Pagos.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pagos.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Pagos.Location = New System.Drawing.Point(293, 257)
        Me.Pagos.Name = "Pagos"
        Me.Pagos.Size = New System.Drawing.Size(223, 24)
        Me.Pagos.TabIndex = 65
        Me.Pagos.Text = "Movimientos del día "
        '
        'Pago
        '
        Me.Pago.AutoSize = True
        Me.Pago.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pago.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Pago.Location = New System.Drawing.Point(296, 398)
        Me.Pago.Name = "Pago"
        Me.Pago.Size = New System.Drawing.Size(39, 17)
        Me.Pago.TabIndex = 64
        Me.Pago.Text = "Pago"
        '
        'TextPago
        '
        Me.TextPago.Location = New System.Drawing.Point(299, 418)
        Me.TextPago.Name = "TextPago"
        Me.TextPago.Size = New System.Drawing.Size(63, 20)
        Me.TextPago.TabIndex = 63
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Descripcion.Location = New System.Drawing.Point(46, 398)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(79, 17)
        Me.Descripcion.TabIndex = 62
        Me.Descripcion.Text = "Descripción"
        '
        'TextDescripcion
        '
        Me.TextDescripcion.Location = New System.Drawing.Point(49, 418)
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.Size = New System.Drawing.Size(244, 20)
        Me.TextDescripcion.TabIndex = 61
        '
        'Confirmaciones
        '
        Me.Confirmaciones.AutoSize = True
        Me.Confirmaciones.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Confirmaciones.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Confirmaciones.Location = New System.Drawing.Point(322, 75)
        Me.Confirmaciones.Name = "Confirmaciones"
        Me.Confirmaciones.Size = New System.Drawing.Size(129, 24)
        Me.Confirmaciones.TabIndex = 60
        Me.Confirmaciones.Text = "A confirmar"
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
        Me.DataGridViewPago.Location = New System.Drawing.Point(49, 284)
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
        Me.DataGridViewPago.TabIndex = 59
        '
        'DataGridViewConfirmar
        '
        Me.DataGridViewConfirmar.AllowUserToAddRows = False
        Me.DataGridViewConfirmar.AllowUserToDeleteRows = False
        Me.DataGridViewConfirmar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewConfirmar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewConfirmar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridViewConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewConfirmar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewConfirmar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewConfirmar.ColumnHeadersHeight = 30
        Me.DataGridViewConfirmar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewConfirmar.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewConfirmar.EnableHeadersVisualStyles = False
        Me.DataGridViewConfirmar.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewConfirmar.Location = New System.Drawing.Point(49, 102)
        Me.DataGridViewConfirmar.Name = "DataGridViewConfirmar"
        Me.DataGridViewConfirmar.ReadOnly = True
        Me.DataGridViewConfirmar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewConfirmar.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewConfirmar.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewConfirmar.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewConfirmar.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewConfirmar.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewConfirmar.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewConfirmar.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewConfirmar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewConfirmar.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewConfirmar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewConfirmar.Size = New System.Drawing.Size(705, 149)
        Me.DataGridViewConfirmar.TabIndex = 58
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.Label3)
        Me.PanelBarraTitulo.Controls.Add(Me.Label2)
        Me.PanelBarraTitulo.Controls.Add(Me.BotonClose)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(800, 40)
        Me.PanelBarraTitulo.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.Location = New System.Drawing.Point(362, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 24)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "CAJA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "F5 actualizar"
        '
        'BotonClose
        '
        Me.BotonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonClose.Image = CType(resources.GetObject("BotonClose.Image"), System.Drawing.Image)
        Me.BotonClose.Location = New System.Drawing.Point(774, 10)
        Me.BotonClose.Name = "BotonClose"
        Me.BotonClose.Size = New System.Drawing.Size(18, 16)
        Me.BotonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BotonClose.TabIndex = 3
        Me.BotonClose.TabStop = False
        '
        'TotalTotal
        '
        Me.TotalTotal.AutoSize = True
        Me.TotalTotal.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTotal.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalTotal.Location = New System.Drawing.Point(629, 49)
        Me.TotalTotal.Name = "TotalTotal"
        Me.TotalTotal.Size = New System.Drawing.Size(49, 23)
        Me.TotalTotal.TabIndex = 56
        Me.TotalTotal.Text = "0.00"
        '
        'TotalTarjeta
        '
        Me.TotalTarjeta.AutoSize = True
        Me.TotalTarjeta.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTarjeta.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalTarjeta.Location = New System.Drawing.Point(401, 49)
        Me.TotalTarjeta.Name = "TotalTarjeta"
        Me.TotalTarjeta.Size = New System.Drawing.Size(49, 23)
        Me.TotalTarjeta.TabIndex = 55
        Me.TotalTarjeta.Text = "0.00"
        '
        'TotalEfectivo
        '
        Me.TotalEfectivo.AutoSize = True
        Me.TotalEfectivo.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalEfectivo.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalEfectivo.Location = New System.Drawing.Point(138, 49)
        Me.TotalEfectivo.Name = "TotalEfectivo"
        Me.TotalEfectivo.Size = New System.Drawing.Size(49, 23)
        Me.TotalEfectivo.TabIndex = 54
        Me.TotalEfectivo.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Location = New System.Drawing.Point(539, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "TOTAL $"
        '
        'Tarjeta
        '
        Me.Tarjeta.AutoSize = True
        Me.Tarjeta.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tarjeta.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Tarjeta.Location = New System.Drawing.Point(289, 49)
        Me.Tarjeta.Name = "Tarjeta"
        Me.Tarjeta.Size = New System.Drawing.Size(105, 23)
        Me.Tarjeta.TabIndex = 52
        Me.Tarjeta.Text = "TARJETA $"
        '
        'Efectivo
        '
        Me.Efectivo.AutoSize = True
        Me.Efectivo.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Efectivo.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Efectivo.Location = New System.Drawing.Point(12, 49)
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Size = New System.Drawing.Size(118, 23)
        Me.Efectivo.TabIndex = 51
        Me.Efectivo.Text = "EFECTIVO $"
        '
        'FormCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelContenedor)
        Me.KeyPreview = True
        Me.Name = "FormCaja"
        Me.Text = "Form1"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.DataGridViewPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewConfirmar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents DataGridViewConfirmar As DataGridView
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents BotonClose As PictureBox
    Friend WithEvents TotalTotal As Label
    Friend WithEvents TotalTarjeta As Label
    Friend WithEvents TotalEfectivo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Tarjeta As Label
    Friend WithEvents Efectivo As Label
    Friend WithEvents DataGridViewPago As DataGridView
    Friend WithEvents Confirmaciones As Label
    Friend WithEvents Pagos As Label
    Friend WithEvents Pago As Label
    Friend WithEvents TextPago As TextBox
    Friend WithEvents Descripcion As Label
    Friend WithEvents TextDescripcion As TextBox
    Friend WithEvents BotonPagar As Button
    Friend WithEvents ButtonCerrarCaja As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BotonRetiro As Button
    Friend WithEvents Label3 As Label
End Class
