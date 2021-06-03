<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCobranzas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCobranzas))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.Cuota1 = New System.Windows.Forms.Button()
        Me.Boton6Coutas = New System.Windows.Forms.Button()
        Me.Boton12Coutas = New System.Windows.Forms.Button()
        Me.Boton3Coutas = New System.Windows.Forms.Button()
        Me.Cuota = New System.Windows.Forms.Label()
        Me.Interes = New System.Windows.Forms.Label()
        Me.TextCouta = New System.Windows.Forms.TextBox()
        Me.TextInteres = New System.Windows.Forms.TextBox()
        Me.Credito = New System.Windows.Forms.Label()
        Me.Debito = New System.Windows.Forms.Label()
        Me.TextDebito = New System.Windows.Forms.TextBox()
        Me.TextTarjeta = New System.Windows.Forms.TextBox()
        Me.CodigoBarra = New System.Windows.Forms.Label()
        Me.TextCodigo = New System.Windows.Forms.TextBox()
        Me.Busqueda = New System.Windows.Forms.Label()
        Me.DataGridViewBusqueda = New System.Windows.Forms.DataGridView()
        Me.BotonCobrar = New System.Windows.Forms.Button()
        Me.Efectivo = New System.Windows.Forms.Label()
        Me.TextEfectivo = New System.Windows.Forms.TextBox()
        Me.BotonLimpiar = New System.Windows.Forms.Button()
        Me.BotonBuscar = New System.Windows.Forms.Button()
        Me.NombreCliente = New System.Windows.Forms.Label()
        Me.TextCliente = New System.Windows.Forms.TextBox()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.COBRANZAS = New System.Windows.Forms.Label()
        Me.BotonClose = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.Label1)
        Me.PanelContenedor.Controls.Add(Me.DataGridViewProductos)
        Me.PanelContenedor.Controls.Add(Me.Cuota1)
        Me.PanelContenedor.Controls.Add(Me.Boton6Coutas)
        Me.PanelContenedor.Controls.Add(Me.Boton12Coutas)
        Me.PanelContenedor.Controls.Add(Me.Boton3Coutas)
        Me.PanelContenedor.Controls.Add(Me.Cuota)
        Me.PanelContenedor.Controls.Add(Me.Interes)
        Me.PanelContenedor.Controls.Add(Me.TextCouta)
        Me.PanelContenedor.Controls.Add(Me.TextInteres)
        Me.PanelContenedor.Controls.Add(Me.Credito)
        Me.PanelContenedor.Controls.Add(Me.Debito)
        Me.PanelContenedor.Controls.Add(Me.TextDebito)
        Me.PanelContenedor.Controls.Add(Me.TextTarjeta)
        Me.PanelContenedor.Controls.Add(Me.CodigoBarra)
        Me.PanelContenedor.Controls.Add(Me.TextCodigo)
        Me.PanelContenedor.Controls.Add(Me.Busqueda)
        Me.PanelContenedor.Controls.Add(Me.DataGridViewBusqueda)
        Me.PanelContenedor.Controls.Add(Me.BotonCobrar)
        Me.PanelContenedor.Controls.Add(Me.Efectivo)
        Me.PanelContenedor.Controls.Add(Me.TextEfectivo)
        Me.PanelContenedor.Controls.Add(Me.BotonLimpiar)
        Me.PanelContenedor.Controls.Add(Me.BotonBuscar)
        Me.PanelContenedor.Controls.Add(Me.NombreCliente)
        Me.PanelContenedor.Controls.Add(Me.TextCliente)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(783, 405)
        Me.PanelContenedor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Location = New System.Drawing.Point(353, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Productos"
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.AllowUserToAddRows = False
        Me.DataGridViewProductos.AllowUserToDeleteRows = False
        Me.DataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewProductos.ColumnHeadersHeight = 30
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewProductos.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewProductos.EnableHeadersVisualStyles = False
        Me.DataGridViewProductos.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewProductos.Location = New System.Drawing.Point(41, 275)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.ReadOnly = True
        Me.DataGridViewProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewProductos.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewProductos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewProductos.Size = New System.Drawing.Size(705, 112)
        Me.DataGridViewProductos.TabIndex = 79
        '
        'Cuota1
        '
        Me.Cuota1.FlatAppearance.BorderSize = 0
        Me.Cuota1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Cuota1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Cuota1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cuota1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuota1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cuota1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cuota1.Location = New System.Drawing.Point(515, 97)
        Me.Cuota1.Name = "Cuota1"
        Me.Cuota1.Size = New System.Drawing.Size(24, 23)
        Me.Cuota1.TabIndex = 78
        Me.Cuota1.Text = "1"
        Me.Cuota1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cuota1.UseVisualStyleBackColor = True
        '
        'Boton6Coutas
        '
        Me.Boton6Coutas.FlatAppearance.BorderSize = 0
        Me.Boton6Coutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Boton6Coutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Boton6Coutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton6Coutas.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton6Coutas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Boton6Coutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton6Coutas.Location = New System.Drawing.Point(575, 97)
        Me.Boton6Coutas.Name = "Boton6Coutas"
        Me.Boton6Coutas.Size = New System.Drawing.Size(24, 23)
        Me.Boton6Coutas.TabIndex = 77
        Me.Boton6Coutas.Text = "6"
        Me.Boton6Coutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Boton6Coutas.UseVisualStyleBackColor = True
        '
        'Boton12Coutas
        '
        Me.Boton12Coutas.FlatAppearance.BorderSize = 0
        Me.Boton12Coutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Boton12Coutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Boton12Coutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton12Coutas.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton12Coutas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Boton12Coutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton12Coutas.Location = New System.Drawing.Point(605, 98)
        Me.Boton12Coutas.Name = "Boton12Coutas"
        Me.Boton12Coutas.Size = New System.Drawing.Size(31, 23)
        Me.Boton12Coutas.TabIndex = 76
        Me.Boton12Coutas.Text = "12"
        Me.Boton12Coutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Boton12Coutas.UseVisualStyleBackColor = True
        '
        'Boton3Coutas
        '
        Me.Boton3Coutas.FlatAppearance.BorderSize = 0
        Me.Boton3Coutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Boton3Coutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Boton3Coutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton3Coutas.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton3Coutas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Boton3Coutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton3Coutas.Location = New System.Drawing.Point(545, 97)
        Me.Boton3Coutas.Name = "Boton3Coutas"
        Me.Boton3Coutas.Size = New System.Drawing.Size(24, 23)
        Me.Boton3Coutas.TabIndex = 75
        Me.Boton3Coutas.Text = "3"
        Me.Boton3Coutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Boton3Coutas.UseVisualStyleBackColor = True
        '
        'Cuota
        '
        Me.Cuota.AutoSize = True
        Me.Cuota.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuota.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Cuota.Location = New System.Drawing.Point(575, 61)
        Me.Cuota.Name = "Cuota"
        Me.Cuota.Size = New System.Drawing.Size(45, 17)
        Me.Cuota.TabIndex = 74
        Me.Cuota.Text = "Cuota"
        '
        'Interes
        '
        Me.Interes.AutoSize = True
        Me.Interes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Interes.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Interes.Location = New System.Drawing.Point(506, 60)
        Me.Interes.Name = "Interes"
        Me.Interes.Size = New System.Drawing.Size(48, 17)
        Me.Interes.TabIndex = 73
        Me.Interes.Text = "Interés"
        '
        'TextCouta
        '
        Me.TextCouta.Location = New System.Drawing.Point(578, 77)
        Me.TextCouta.Name = "TextCouta"
        Me.TextCouta.ReadOnly = True
        Me.TextCouta.Size = New System.Drawing.Size(63, 20)
        Me.TextCouta.TabIndex = 45
        '
        'TextInteres
        '
        Me.TextInteres.Location = New System.Drawing.Point(509, 77)
        Me.TextInteres.Name = "TextInteres"
        Me.TextInteres.ReadOnly = True
        Me.TextInteres.Size = New System.Drawing.Size(63, 20)
        Me.TextInteres.TabIndex = 44
        '
        'Credito
        '
        Me.Credito.AutoSize = True
        Me.Credito.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credito.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Credito.Location = New System.Drawing.Point(437, 57)
        Me.Credito.Name = "Credito"
        Me.Credito.Size = New System.Drawing.Size(53, 17)
        Me.Credito.TabIndex = 70
        Me.Credito.Text = "Credito"
        '
        'Debito
        '
        Me.Debito.AutoSize = True
        Me.Debito.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Debito.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Debito.Location = New System.Drawing.Point(368, 57)
        Me.Debito.Name = "Debito"
        Me.Debito.Size = New System.Drawing.Size(49, 17)
        Me.Debito.TabIndex = 69
        Me.Debito.Text = "Debito"
        '
        'TextDebito
        '
        Me.TextDebito.Location = New System.Drawing.Point(371, 77)
        Me.TextDebito.Name = "TextDebito"
        Me.TextDebito.Size = New System.Drawing.Size(63, 20)
        Me.TextDebito.TabIndex = 42
        '
        'TextTarjeta
        '
        Me.TextTarjeta.Location = New System.Drawing.Point(440, 77)
        Me.TextTarjeta.Name = "TextTarjeta"
        Me.TextTarjeta.Size = New System.Drawing.Size(63, 20)
        Me.TextTarjeta.TabIndex = 43
        '
        'CodigoBarra
        '
        Me.CodigoBarra.AutoSize = True
        Me.CodigoBarra.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoBarra.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.CodigoBarra.Location = New System.Drawing.Point(24, 57)
        Me.CodigoBarra.Name = "CodigoBarra"
        Me.CodigoBarra.Size = New System.Drawing.Size(52, 17)
        Me.CodigoBarra.TabIndex = 50
        Me.CodigoBarra.Text = "Codigo"
        '
        'TextCodigo
        '
        Me.TextCodigo.Location = New System.Drawing.Point(27, 77)
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.ReadOnly = True
        Me.TextCodigo.Size = New System.Drawing.Size(57, 20)
        Me.TextCodigo.TabIndex = 49
        '
        'Busqueda
        '
        Me.Busqueda.AutoSize = True
        Me.Busqueda.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Busqueda.Location = New System.Drawing.Point(353, 103)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(112, 24)
        Me.Busqueda.TabIndex = 48
        Me.Busqueda.Text = "Busqueda"
        '
        'DataGridViewBusqueda
        '
        Me.DataGridViewBusqueda.AllowUserToAddRows = False
        Me.DataGridViewBusqueda.AllowUserToDeleteRows = False
        Me.DataGridViewBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewBusqueda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewBusqueda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridViewBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewBusqueda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBusqueda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewBusqueda.ColumnHeadersHeight = 30
        Me.DataGridViewBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewBusqueda.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewBusqueda.EnableHeadersVisualStyles = False
        Me.DataGridViewBusqueda.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewBusqueda.Location = New System.Drawing.Point(41, 130)
        Me.DataGridViewBusqueda.Name = "DataGridViewBusqueda"
        Me.DataGridViewBusqueda.ReadOnly = True
        Me.DataGridViewBusqueda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBusqueda.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewBusqueda.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBusqueda.Size = New System.Drawing.Size(705, 112)
        Me.DataGridViewBusqueda.TabIndex = 47
        '
        'BotonCobrar
        '
        Me.BotonCobrar.FlatAppearance.BorderSize = 0
        Me.BotonCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCobrar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCobrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonCobrar.Image = CType(resources.GetObject("BotonCobrar.Image"), System.Drawing.Image)
        Me.BotonCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonCobrar.Location = New System.Drawing.Point(647, 66)
        Me.BotonCobrar.Name = "BotonCobrar"
        Me.BotonCobrar.Size = New System.Drawing.Size(104, 43)
        Me.BotonCobrar.TabIndex = 46
        Me.BotonCobrar.Text = "Cobrar"
        Me.BotonCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonCobrar.UseVisualStyleBackColor = True
        '
        'Efectivo
        '
        Me.Efectivo.AutoSize = True
        Me.Efectivo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Efectivo.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Efectivo.Location = New System.Drawing.Point(299, 57)
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Size = New System.Drawing.Size(58, 17)
        Me.Efectivo.TabIndex = 45
        Me.Efectivo.Text = "Efectivo"
        '
        'TextEfectivo
        '
        Me.TextEfectivo.Location = New System.Drawing.Point(302, 77)
        Me.TextEfectivo.Name = "TextEfectivo"
        Me.TextEfectivo.Size = New System.Drawing.Size(63, 20)
        Me.TextEfectivo.TabIndex = 41
        '
        'BotonLimpiar
        '
        Me.BotonLimpiar.FlatAppearance.BorderSize = 0
        Me.BotonLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonLimpiar.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonLimpiar.Location = New System.Drawing.Point(88, 104)
        Me.BotonLimpiar.Name = "BotonLimpiar"
        Me.BotonLimpiar.Size = New System.Drawing.Size(48, 20)
        Me.BotonLimpiar.TabIndex = 43
        Me.BotonLimpiar.Text = "Limpiar"
        Me.BotonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonLimpiar.UseVisualStyleBackColor = True
        '
        'BotonBuscar
        '
        Me.BotonBuscar.FlatAppearance.BorderSize = 0
        Me.BotonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonBuscar.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonBuscar.Location = New System.Drawing.Point(24, 103)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Size = New System.Drawing.Size(48, 20)
        Me.BotonBuscar.TabIndex = 42
        Me.BotonBuscar.Text = "Buscar"
        Me.BotonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonBuscar.UseVisualStyleBackColor = True
        '
        'NombreCliente
        '
        Me.NombreCliente.AutoSize = True
        Me.NombreCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreCliente.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.NombreCliente.Location = New System.Drawing.Point(87, 57)
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Size = New System.Drawing.Size(51, 17)
        Me.NombreCliente.TabIndex = 41
        Me.NombreCliente.Text = "Cliente"
        '
        'TextCliente
        '
        Me.TextCliente.Location = New System.Drawing.Point(90, 77)
        Me.TextCliente.Name = "TextCliente"
        Me.TextCliente.Size = New System.Drawing.Size(206, 20)
        Me.TextCliente.TabIndex = 40
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.COBRANZAS)
        Me.PanelBarraTitulo.Controls.Add(Me.BotonClose)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(783, 40)
        Me.PanelBarraTitulo.TabIndex = 12
        '
        'COBRANZAS
        '
        Me.COBRANZAS.AutoSize = True
        Me.COBRANZAS.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COBRANZAS.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.COBRANZAS.Location = New System.Drawing.Point(12, 9)
        Me.COBRANZAS.Name = "COBRANZAS"
        Me.COBRANZAS.Size = New System.Drawing.Size(136, 24)
        Me.COBRANZAS.TabIndex = 76
        Me.COBRANZAS.Text = "COBRANZAS"
        '
        'BotonClose
        '
        Me.BotonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonClose.Image = CType(resources.GetObject("BotonClose.Image"), System.Drawing.Image)
        Me.BotonClose.Location = New System.Drawing.Point(757, 10)
        Me.BotonClose.Name = "BotonClose"
        Me.BotonClose.Size = New System.Drawing.Size(18, 16)
        Me.BotonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BotonClose.TabIndex = 3
        Me.BotonClose.TabStop = False
        '
        'FormCobranzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 405)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Name = "FormCobranzas"
        Me.Text = "FormCliente"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents COBRANZAS As Label
    Friend WithEvents BotonClose As PictureBox
    Friend WithEvents BotonCobrar As Button
    Friend WithEvents Efectivo As Label
    Friend WithEvents TextEfectivo As TextBox
    Friend WithEvents BotonLimpiar As Button
    Friend WithEvents BotonBuscar As Button
    Friend WithEvents NombreCliente As Label
    Friend WithEvents TextCliente As TextBox
    Friend WithEvents Busqueda As Label
    Friend WithEvents DataGridViewBusqueda As DataGridView
    Friend WithEvents CodigoBarra As Label
    Friend WithEvents TextCodigo As TextBox
    Friend WithEvents TextDebito As TextBox
    Friend WithEvents TextTarjeta As TextBox
    Friend WithEvents Credito As Label
    Friend WithEvents Debito As Label
    Friend WithEvents Interes As Label
    Friend WithEvents TextCouta As TextBox
    Friend WithEvents TextInteres As TextBox
    Friend WithEvents Cuota As Label
    Friend WithEvents Cuota1 As Button
    Friend WithEvents Boton6Coutas As Button
    Friend WithEvents Boton12Coutas As Button
    Friend WithEvents Boton3Coutas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewProductos As DataGridView
End Class
