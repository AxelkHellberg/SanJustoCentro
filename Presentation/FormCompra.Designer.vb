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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalNum = New System.Windows.Forms.Label()
        Me.CantArieta = New System.Windows.Forms.Label()
        Me.TextCantArieta = New System.Windows.Forms.TextBox()
        Me.BotonLimpiar = New System.Windows.Forms.Button()
        Me.BotonExportarExcel = New System.Windows.Forms.Button()
        Me.BotonConfirmar = New System.Windows.Forms.Button()
        Me.Busqueda = New System.Windows.Forms.Label()
        Me.DetalleCompra = New System.Windows.Forms.Label()
        Me.DataGridViewCompra = New System.Windows.Forms.DataGridView()
        Me.BotonAgregar = New System.Windows.Forms.Button()
        Me.DataGridViewBusqueda = New System.Windows.Forms.DataGridView()
        Me.Porcentaje = New System.Windows.Forms.Label()
        Me.TextPorcentaje = New System.Windows.Forms.TextBox()
        Me.BotonBuscar = New System.Windows.Forms.Button()
        Me.Precio = New System.Windows.Forms.Label()
        Me.TextPrecio = New System.Windows.Forms.TextBox()
        Me.Costo = New System.Windows.Forms.Label()
        Me.TextCosto = New System.Windows.Forms.TextBox()
        Me.CantidadPeru = New System.Windows.Forms.Label()
        Me.TextCantPeru = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.TextDescripcion = New System.Windows.Forms.TextBox()
        Me.CodigoBarra = New System.Windows.Forms.Label()
        Me.TextCodigoBarra = New System.Windows.Forms.TextBox()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.tabla = New System.Data.DataTable()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextCantArieta2 = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A3100 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelContenedor.SuspendLayout()
        CType(Me.DataGridViewCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.panelContenedor.Controls.Add(Me.Label2)
        Me.panelContenedor.Controls.Add(Me.TextCantArieta2)
        Me.panelContenedor.Controls.Add(Me.Label1)
        Me.panelContenedor.Controls.Add(Me.TotalNum)
        Me.panelContenedor.Controls.Add(Me.CantArieta)
        Me.panelContenedor.Controls.Add(Me.TextCantArieta)
        Me.panelContenedor.Controls.Add(Me.BotonLimpiar)
        Me.panelContenedor.Controls.Add(Me.BotonExportarExcel)
        Me.panelContenedor.Controls.Add(Me.BotonConfirmar)
        Me.panelContenedor.Controls.Add(Me.Busqueda)
        Me.panelContenedor.Controls.Add(Me.DetalleCompra)
        Me.panelContenedor.Controls.Add(Me.DataGridViewCompra)
        Me.panelContenedor.Controls.Add(Me.BotonAgregar)
        Me.panelContenedor.Controls.Add(Me.DataGridViewBusqueda)
        Me.panelContenedor.Controls.Add(Me.Porcentaje)
        Me.panelContenedor.Controls.Add(Me.TextPorcentaje)
        Me.panelContenedor.Controls.Add(Me.BotonBuscar)
        Me.panelContenedor.Controls.Add(Me.Precio)
        Me.panelContenedor.Controls.Add(Me.TextPrecio)
        Me.panelContenedor.Controls.Add(Me.Costo)
        Me.panelContenedor.Controls.Add(Me.TextCosto)
        Me.panelContenedor.Controls.Add(Me.CantidadPeru)
        Me.panelContenedor.Controls.Add(Me.TextCantPeru)
        Me.panelContenedor.Controls.Add(Me.Descripcion)
        Me.panelContenedor.Controls.Add(Me.TextDescripcion)
        Me.panelContenedor.Controls.Add(Me.CodigoBarra)
        Me.panelContenedor.Controls.Add(Me.TextCodigoBarra)
        Me.panelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(812, 482)
        Me.panelContenedor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Location = New System.Drawing.Point(29, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 34)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "TOTAL $"
        '
        'TotalNum
        '
        Me.TotalNum.AutoSize = True
        Me.TotalNum.Font = New System.Drawing.Font("Century Gothic", 20.75!)
        Me.TotalNum.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalNum.Location = New System.Drawing.Point(195, 436)
        Me.TotalNum.Name = "TotalNum"
        Me.TotalNum.Size = New System.Drawing.Size(70, 34)
        Me.TotalNum.TabIndex = 43
        Me.TotalNum.Text = "0.00"
        '
        'CantArieta
        '
        Me.CantArieta.AutoSize = True
        Me.CantArieta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantArieta.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.CantArieta.Location = New System.Drawing.Point(419, 66)
        Me.CantArieta.Name = "CantArieta"
        Me.CantArieta.Size = New System.Drawing.Size(39, 16)
        Me.CantArieta.TabIndex = 35
        Me.CantArieta.Text = "A3300"
        '
        'TextCantArieta
        '
        Me.TextCantArieta.Location = New System.Drawing.Point(420, 85)
        Me.TextCantArieta.Name = "TextCantArieta"
        Me.TextCantArieta.Size = New System.Drawing.Size(40, 20)
        Me.TextCantArieta.TabIndex = 13
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
        Me.BotonLimpiar.Location = New System.Drawing.Point(124, 108)
        Me.BotonLimpiar.Name = "BotonLimpiar"
        Me.BotonLimpiar.Size = New System.Drawing.Size(48, 20)
        Me.BotonLimpiar.TabIndex = 33
        Me.BotonLimpiar.Text = "Limpiar"
        Me.BotonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonLimpiar.UseVisualStyleBackColor = True
        '
        'BotonExportarExcel
        '
        Me.BotonExportarExcel.FlatAppearance.BorderSize = 0
        Me.BotonExportarExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonExportarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonExportarExcel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonExportarExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonExportarExcel.Image = Global.Presentation.My.Resources.Resources.application_office_excel_2474
        Me.BotonExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonExportarExcel.Location = New System.Drawing.Point(511, 427)
        Me.BotonExportarExcel.Name = "BotonExportarExcel"
        Me.BotonExportarExcel.Size = New System.Drawing.Size(127, 43)
        Me.BotonExportarExcel.TabIndex = 32
        Me.BotonExportarExcel.Text = "Exportar"
        Me.BotonExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonExportarExcel.UseVisualStyleBackColor = True
        '
        'BotonConfirmar
        '
        Me.BotonConfirmar.FlatAppearance.BorderSize = 0
        Me.BotonConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonConfirmar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonConfirmar.Image = Global.Presentation.My.Resources.Resources.bluefilefolder_azul_archivo_12582__2_
        Me.BotonConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonConfirmar.Location = New System.Drawing.Point(660, 426)
        Me.BotonConfirmar.Name = "BotonConfirmar"
        Me.BotonConfirmar.Size = New System.Drawing.Size(127, 43)
        Me.BotonConfirmar.TabIndex = 31
        Me.BotonConfirmar.Text = "Confirmar"
        Me.BotonConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonConfirmar.UseVisualStyleBackColor = True
        '
        'Busqueda
        '
        Me.Busqueda.AutoSize = True
        Me.Busqueda.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Busqueda.Location = New System.Drawing.Point(338, 107)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(112, 24)
        Me.Busqueda.TabIndex = 30
        Me.Busqueda.Text = "Busqueda"
        '
        'DetalleCompra
        '
        Me.DetalleCompra.AutoSize = True
        Me.DetalleCompra.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetalleCompra.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.DetalleCompra.Location = New System.Drawing.Point(299, 261)
        Me.DetalleCompra.Name = "DetalleCompra"
        Me.DetalleCompra.Size = New System.Drawing.Size(208, 24)
        Me.DetalleCompra.TabIndex = 29
        Me.DetalleCompra.Text = "Detalle de compra"
        '
        'DataGridViewCompra
        '
        Me.DataGridViewCompra.AllowUserToAddRows = False
        Me.DataGridViewCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridViewCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewCompra.ColumnHeadersHeight = 30
        Me.DataGridViewCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewCompra.ColumnHeadersVisible = False
        Me.DataGridViewCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column7, Me.A3100, Me.Column4, Me.Column6, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewCompra.EnableHeadersVisualStyles = False
        Me.DataGridViewCompra.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewCompra.Location = New System.Drawing.Point(26, 288)
        Me.DataGridViewCompra.Name = "DataGridViewCompra"
        Me.DataGridViewCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewCompra.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewCompra.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewCompra.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewCompra.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewCompra.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewCompra.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewCompra.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewCompra.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewCompra.Size = New System.Drawing.Size(761, 132)
        Me.DataGridViewCompra.TabIndex = 28
        '
        'BotonAgregar
        '
        Me.BotonAgregar.FlatAppearance.BorderSize = 0
        Me.BotonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAgregar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonAgregar.Image = Global.Presentation.My.Resources.Resources.logout__1_11
        Me.BotonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonAgregar.Location = New System.Drawing.Point(695, 74)
        Me.BotonAgregar.Name = "BotonAgregar"
        Me.BotonAgregar.Size = New System.Drawing.Size(104, 43)
        Me.BotonAgregar.TabIndex = 18
        Me.BotonAgregar.Text = "Agregar"
        Me.BotonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonAgregar.UseVisualStyleBackColor = True
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
        Me.DataGridViewBusqueda.Location = New System.Drawing.Point(26, 134)
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
        Me.DataGridViewBusqueda.Size = New System.Drawing.Size(761, 112)
        Me.DataGridViewBusqueda.TabIndex = 26
        '
        'Porcentaje
        '
        Me.Porcentaje.AutoSize = True
        Me.Porcentaje.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Porcentaje.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Porcentaje.Location = New System.Drawing.Point(592, 65)
        Me.Porcentaje.Name = "Porcentaje"
        Me.Porcentaje.Size = New System.Drawing.Size(17, 17)
        Me.Porcentaje.TabIndex = 25
        Me.Porcentaje.Text = "%"
        '
        'TextPorcentaje
        '
        Me.TextPorcentaje.Location = New System.Drawing.Point(581, 85)
        Me.TextPorcentaje.Name = "TextPorcentaje"
        Me.TextPorcentaje.Size = New System.Drawing.Size(40, 20)
        Me.TextPorcentaje.TabIndex = 16
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
        Me.BotonBuscar.Location = New System.Drawing.Point(35, 108)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Size = New System.Drawing.Size(48, 20)
        Me.BotonBuscar.TabIndex = 23
        Me.BotonBuscar.Text = "Buscar"
        Me.BotonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonBuscar.UseVisualStyleBackColor = True
        '
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Precio.Location = New System.Drawing.Point(626, 65)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(46, 17)
        Me.Precio.TabIndex = 19
        Me.Precio.Text = "Precio"
        '
        'TextPrecio
        '
        Me.TextPrecio.Location = New System.Drawing.Point(627, 85)
        Me.TextPrecio.Name = "TextPrecio"
        Me.TextPrecio.Size = New System.Drawing.Size(63, 20)
        Me.TextPrecio.TabIndex = 17
        '
        'Costo
        '
        Me.Costo.AutoSize = True
        Me.Costo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costo.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Costo.Location = New System.Drawing.Point(511, 65)
        Me.Costo.Name = "Costo"
        Me.Costo.Size = New System.Drawing.Size(43, 17)
        Me.Costo.TabIndex = 17
        Me.Costo.Text = "Costo"
        '
        'TextCosto
        '
        Me.TextCosto.Location = New System.Drawing.Point(511, 85)
        Me.TextCosto.Name = "TextCosto"
        Me.TextCosto.Size = New System.Drawing.Size(64, 20)
        Me.TextCosto.TabIndex = 15
        '
        'CantidadPeru
        '
        Me.CantidadPeru.AutoSize = True
        Me.CantidadPeru.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadPeru.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.CantidadPeru.Location = New System.Drawing.Point(371, 65)
        Me.CantidadPeru.Name = "CantidadPeru"
        Me.CantidadPeru.Size = New System.Drawing.Size(34, 17)
        Me.CantidadPeru.TabIndex = 15
        Me.CantidadPeru.Text = "Peru"
        '
        'TextCantPeru
        '
        Me.TextCantPeru.Location = New System.Drawing.Point(374, 85)
        Me.TextCantPeru.Name = "TextCantPeru"
        Me.TextCantPeru.Size = New System.Drawing.Size(40, 20)
        Me.TextCantPeru.TabIndex = 12
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Descripcion.Location = New System.Drawing.Point(121, 65)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(79, 17)
        Me.Descripcion.TabIndex = 13
        Me.Descripcion.Text = "Descripción"
        '
        'TextDescripcion
        '
        Me.TextDescripcion.Location = New System.Drawing.Point(124, 85)
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.Size = New System.Drawing.Size(244, 20)
        Me.TextDescripcion.TabIndex = 11
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
        '
        'TextCodigoBarra
        '
        Me.TextCodigoBarra.Location = New System.Drawing.Point(26, 85)
        Me.TextCodigoBarra.Name = "TextCodigoBarra"
        Me.TextCodigoBarra.Size = New System.Drawing.Size(92, 20)
        Me.TextCodigoBarra.TabIndex = 10
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.Label3)
        Me.PanelBarraTitulo.Controls.Add(Me.btnClose)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(812, 40)
        Me.PanelBarraTitulo.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.Location = New System.Drawing.Point(338, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "COMPRA"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Presentation.My.Resources.Resources.x_close_icon_white
        Me.btnClose.Location = New System.Drawing.Point(786, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(18, 16)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Location = New System.Drawing.Point(465, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "A3100"
        '
        'TextCantArieta2
        '
        Me.TextCantArieta2.Location = New System.Drawing.Point(466, 85)
        Me.TextCantArieta2.Name = "TextCantArieta2"
        Me.TextCantArieta2.Size = New System.Drawing.Size(40, 20)
        Me.TextCantArieta2.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripcion"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cant Peru"
        Me.Column3.Name = "Column3"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Cant A3300"
        Me.Column7.Name = "Column7"
        '
        'A3100
        '
        Me.A3100.HeaderText = "Cant A3100"
        Me.A3100.Name = "A3100"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Costo"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Porcentaje"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio"
        Me.Column5.Name = "Column5"
        '
        'FormCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 482)
        Me.Controls.Add(Me.panelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(812, 675)
        Me.MinimumSize = New System.Drawing.Size(375, 310)
        Me.Name = "FormCompra"
        Me.Text = "Form2"
        Me.panelContenedor.ResumeLayout(False)
        Me.panelContenedor.PerformLayout()
        CType(Me.DataGridViewCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents TextCodigoBarra As TextBox
    Friend WithEvents CodigoBarra As Label
    Friend WithEvents Descripcion As Label
    Friend WithEvents TextDescripcion As TextBox
    Friend WithEvents CantidadPeru As Label
    Friend WithEvents TextCantPeru As TextBox
    Friend WithEvents Precio As Label
    Friend WithEvents TextPrecio As TextBox
    Friend WithEvents Costo As Label
    Friend WithEvents TextCosto As TextBox
    Friend WithEvents BotonBuscar As Button
    Friend WithEvents Porcentaje As Label
    Friend WithEvents TextPorcentaje As TextBox
    Friend WithEvents DataGridViewBusqueda As DataGridView
    Friend WithEvents BotonAgregar As Button
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tabla As DataTable
    Friend WithEvents DataGridViewCompra As DataGridView
    Friend WithEvents Busqueda As Label
    Friend WithEvents DetalleCompra As Label
    Friend WithEvents BotonConfirmar As Button
    Friend WithEvents BotonExportarExcel As Button
    Friend WithEvents BotonLimpiar As Button
    Friend WithEvents CantArieta As Label
    Friend WithEvents TextCantArieta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalNum As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextCantArieta2 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents A3100 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
