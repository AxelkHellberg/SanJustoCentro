<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAnalisis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnalisis))
        Me.Hasta = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonExportarExcel = New System.Windows.Forms.Button()
        Me.BotonProductos = New System.Windows.Forms.Button()
        Me.TotalNum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckSucursal2 = New System.Windows.Forms.CheckBox()
        Me.CheckSucursal1 = New System.Windows.Forms.CheckBox()
        Me.BotonMovimientos = New System.Windows.Forms.Button()
        Me.DateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.BotonVentas = New System.Windows.Forms.Button()
        Me.BotonComisiones = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Desde = New System.Windows.Forms.Label()
        Me.DataGridViewBusqueda = New System.Windows.Forms.DataGridView()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BotonClose = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.CheckSucursal3 = New System.Windows.Forms.CheckBox()
        Me.Hasta.SuspendLayout()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hasta
        '
        Me.Hasta.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Hasta.Controls.Add(Me.CheckSucursal3)
        Me.Hasta.Controls.Add(Me.Button1)
        Me.Hasta.Controls.Add(Me.BotonExportarExcel)
        Me.Hasta.Controls.Add(Me.BotonProductos)
        Me.Hasta.Controls.Add(Me.TotalNum)
        Me.Hasta.Controls.Add(Me.Label2)
        Me.Hasta.Controls.Add(Me.CheckSucursal2)
        Me.Hasta.Controls.Add(Me.CheckSucursal1)
        Me.Hasta.Controls.Add(Me.BotonMovimientos)
        Me.Hasta.Controls.Add(Me.DateTimePickerHasta)
        Me.Hasta.Controls.Add(Me.DateTimePickerDesde)
        Me.Hasta.Controls.Add(Me.BotonVentas)
        Me.Hasta.Controls.Add(Me.BotonComisiones)
        Me.Hasta.Controls.Add(Me.Label1)
        Me.Hasta.Controls.Add(Me.Desde)
        Me.Hasta.Controls.Add(Me.DataGridViewBusqueda)
        Me.Hasta.Controls.Add(Me.PanelBarraTitulo)
        Me.Hasta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hasta.Location = New System.Drawing.Point(0, 0)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Size = New System.Drawing.Size(800, 450)
        Me.Hasta.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = Global.Presentation.My.Resources.Resources.seo1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(516, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 45)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "Reposición"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.BotonExportarExcel.Location = New System.Drawing.Point(648, 395)
        Me.BotonExportarExcel.Name = "BotonExportarExcel"
        Me.BotonExportarExcel.Size = New System.Drawing.Size(127, 43)
        Me.BotonExportarExcel.TabIndex = 104
        Me.BotonExportarExcel.Text = "Exportar"
        Me.BotonExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonExportarExcel.UseVisualStyleBackColor = True
        '
        'BotonProductos
        '
        Me.BotonProductos.FlatAppearance.BorderSize = 0
        Me.BotonProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonProductos.Image = Global.Presentation.My.Resources.Resources.payment1
        Me.BotonProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonProductos.Location = New System.Drawing.Point(373, 98)
        Me.BotonProductos.Name = "BotonProductos"
        Me.BotonProductos.Size = New System.Drawing.Size(131, 45)
        Me.BotonProductos.TabIndex = 103
        Me.BotonProductos.Text = "Productos"
        Me.BotonProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonProductos.UseVisualStyleBackColor = True
        '
        'TotalNum
        '
        Me.TotalNum.AutoSize = True
        Me.TotalNum.Font = New System.Drawing.Font("Century Gothic", 20.75!)
        Me.TotalNum.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalNum.Location = New System.Drawing.Point(167, 397)
        Me.TotalNum.Name = "TotalNum"
        Me.TotalNum.Size = New System.Drawing.Size(70, 34)
        Me.TotalNum.TabIndex = 102
        Me.TotalNum.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Location = New System.Drawing.Point(39, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 34)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "TOTAL $"
        '
        'CheckSucursal2
        '
        Me.CheckSucursal2.AutoSize = True
        Me.CheckSucursal2.Checked = True
        Me.CheckSucursal2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckSucursal2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSucursal2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CheckSucursal2.Location = New System.Drawing.Point(286, 117)
        Me.CheckSucursal2.Name = "CheckSucursal2"
        Me.CheckSucursal2.Size = New System.Drawing.Size(58, 20)
        Me.CheckSucursal2.TabIndex = 100
        Me.CheckSucursal2.Text = "A3300"
        Me.CheckSucursal2.UseVisualStyleBackColor = True
        '
        'CheckSucursal1
        '
        Me.CheckSucursal1.AutoSize = True
        Me.CheckSucursal1.Checked = True
        Me.CheckSucursal1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckSucursal1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSucursal1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CheckSucursal1.Location = New System.Drawing.Point(286, 63)
        Me.CheckSucursal1.Name = "CheckSucursal1"
        Me.CheckSucursal1.Size = New System.Drawing.Size(51, 20)
        Me.CheckSucursal1.TabIndex = 99
        Me.CheckSucursal1.Text = "Peru"
        Me.CheckSucursal1.UseVisualStyleBackColor = True
        '
        'BotonMovimientos
        '
        Me.BotonMovimientos.FlatAppearance.BorderSize = 0
        Me.BotonMovimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonMovimientos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonMovimientos.Image = Global.Presentation.My.Resources.Resources.phone_book__1_11
        Me.BotonMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonMovimientos.Location = New System.Drawing.Point(657, 47)
        Me.BotonMovimientos.Name = "BotonMovimientos"
        Me.BotonMovimientos.Size = New System.Drawing.Size(131, 45)
        Me.BotonMovimientos.TabIndex = 98
        Me.BotonMovimientos.Text = "Movimientos"
        Me.BotonMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonMovimientos.UseVisualStyleBackColor = True
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.CalendarFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerHasta.CalendarTitleBackColor = System.Drawing.SystemColors.MenuText
        Me.DateTimePickerHasta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(30, 109)
        Me.DateTimePickerHasta.Name = "DateTimePickerHasta"
        Me.DateTimePickerHasta.Size = New System.Drawing.Size(219, 21)
        Me.DateTimePickerHasta.TabIndex = 97
        '
        'DateTimePickerDesde
        '
        Me.DateTimePickerDesde.CalendarFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDesde.CalendarTitleBackColor = System.Drawing.SystemColors.MenuText
        Me.DateTimePickerDesde.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(30, 67)
        Me.DateTimePickerDesde.Name = "DateTimePickerDesde"
        Me.DateTimePickerDesde.Size = New System.Drawing.Size(219, 21)
        Me.DateTimePickerDesde.TabIndex = 96
        '
        'BotonVentas
        '
        Me.BotonVentas.FlatAppearance.BorderSize = 0
        Me.BotonVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonVentas.Image = Global.Presentation.My.Resources.Resources.bar_graph1
        Me.BotonVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonVentas.Location = New System.Drawing.Point(373, 47)
        Me.BotonVentas.Name = "BotonVentas"
        Me.BotonVentas.Size = New System.Drawing.Size(131, 45)
        Me.BotonVentas.TabIndex = 95
        Me.BotonVentas.Text = "Ventas"
        Me.BotonVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonVentas.UseVisualStyleBackColor = True
        '
        'BotonComisiones
        '
        Me.BotonComisiones.FlatAppearance.BorderSize = 0
        Me.BotonComisiones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonComisiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonComisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonComisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonComisiones.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonComisiones.Image = Global.Presentation.My.Resources.Resources.person_settings1
        Me.BotonComisiones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonComisiones.Location = New System.Drawing.Point(516, 47)
        Me.BotonComisiones.Name = "BotonComisiones"
        Me.BotonComisiones.Size = New System.Drawing.Size(131, 45)
        Me.BotonComisiones.TabIndex = 94
        Me.BotonComisiones.Text = "Comisiones"
        Me.BotonComisiones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonComisiones.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Location = New System.Drawing.Point(30, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Hasta"
        '
        'Desde
        '
        Me.Desde.AutoSize = True
        Me.Desde.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Desde.Location = New System.Drawing.Point(27, 47)
        Me.Desde.Name = "Desde"
        Me.Desde.Size = New System.Drawing.Size(46, 17)
        Me.Desde.TabIndex = 85
        Me.Desde.Text = "Desde"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBusqueda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewBusqueda.ColumnHeadersHeight = 30
        Me.DataGridViewBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewBusqueda.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewBusqueda.EnableHeadersVisualStyles = False
        Me.DataGridViewBusqueda.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewBusqueda.Location = New System.Drawing.Point(16, 143)
        Me.DataGridViewBusqueda.Name = "DataGridViewBusqueda"
        Me.DataGridViewBusqueda.ReadOnly = True
        Me.DataGridViewBusqueda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBusqueda.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewBusqueda.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBusqueda.Size = New System.Drawing.Size(772, 237)
        Me.DataGridViewBusqueda.TabIndex = 29
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.Label3)
        Me.PanelBarraTitulo.Controls.Add(Me.BotonClose)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(800, 40)
        Me.PanelBarraTitulo.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "ANALISIS"
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
        'BackgroundWorker2
        '
        '
        'CheckSucursal3
        '
        Me.CheckSucursal3.AutoSize = True
        Me.CheckSucursal3.Checked = True
        Me.CheckSucursal3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckSucursal3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSucursal3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CheckSucursal3.Location = New System.Drawing.Point(286, 90)
        Me.CheckSucursal3.Name = "CheckSucursal3"
        Me.CheckSucursal3.Size = New System.Drawing.Size(58, 20)
        Me.CheckSucursal3.TabIndex = 106
        Me.CheckSucursal3.Text = "A3100"
        Me.CheckSucursal3.UseVisualStyleBackColor = True
        '
        'FormAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Hasta)
        Me.Name = "FormAnalisis"
        Me.Text = "FormAnalisis"
        Me.Hasta.ResumeLayout(False)
        Me.Hasta.PerformLayout()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Hasta As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents BotonClose As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewBusqueda As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Desde As Label
    Friend WithEvents BotonComisiones As Button
    Public WithEvents BotonVentas As Button
    Friend WithEvents BotonMovimientos As Button
    Friend WithEvents CheckSucursal2 As CheckBox
    Friend WithEvents CheckSucursal1 As CheckBox
    Friend WithEvents TotalNum As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BotonProductos As Button
    Public WithEvents DateTimePickerDesde As DateTimePicker
    Public WithEvents DateTimePickerHasta As DateTimePicker
    Friend WithEvents BotonExportarExcel As Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckSucursal3 As CheckBox
End Class
