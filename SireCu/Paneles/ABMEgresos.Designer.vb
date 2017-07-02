<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMEgresos
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMEgresos))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageAgregar = New System.Windows.Forms.TabPage()
        Me.GroupBoxAgregar = New System.Windows.Forms.GroupBox()
        Me.cbTComprobante = New System.Windows.Forms.ComboBox()
        Me.cbSeccional = New System.Windows.Forms.ComboBox()
        Me.cbTGasto = New System.Windows.Forms.ComboBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpReintegro = New System.Windows.Forms.DateTimePicker()
        Me.lbSeccional = New System.Windows.Forms.Label()
        Me.tbNComprobante = New System.Windows.Forms.TextBox()
        Me.tbPVenta = New System.Windows.Forms.TextBox()
        Me.lbSmonto = New System.Windows.Forms.Label()
        Me.lbTComprobante = New System.Windows.Forms.Label()
        Me.tbMonto = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lbGasto = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lbMes = New System.Windows.Forms.Label()
        Me.lbComentario = New System.Windows.Forms.Label()
        Me.lbMonto = New System.Windows.Forms.Label()
        Me.lbProveedor = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbNComprobante = New System.Windows.Forms.Label()
        Me.tbComentario = New System.Windows.Forms.TextBox()
        Me.tbProveedor = New System.Windows.Forms.TextBox()
        Me.lb_Titulo = New System.Windows.Forms.Label()
        Me.TabPageModificar = New System.Windows.Forms.TabPage()
        Me.ToolStripContainerModificar = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainerModificar = New System.Windows.Forms.SplitContainer()
        Me.DGVModificar = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nro_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_comprobante_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_comprobante_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria_gasto_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.persona_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.persona_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seccional_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seccional_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mes_reintegro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.LabelSeccional = New System.Windows.Forms.Label()
        Me.ComboBoxSeccional = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerMesReintegro = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxNroComprobante = New System.Windows.Forms.TextBox()
        Me.ComboBoxTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.TextBoxPVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxMonto = New System.Windows.Forms.TextBox()
        Me.ComboBoxCategGasto = New System.Windows.Forms.ComboBox()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxComentario = New System.Windows.Forms.TextBox()
        Me.TextBoxProveedor = New System.Windows.Forms.TextBox()
        Me.ToolStripModificar = New System.Windows.Forms.ToolStrip()
        Me.TSLabelTrimestre = New System.Windows.Forms.ToolStripLabel()
        Me.TSComboBoxTrimestre = New System.Windows.Forms.ToolStripComboBox()
        Me.TSLabelAño = New System.Windows.Forms.ToolStripLabel()
        Me.TSTextBoxAño = New System.Windows.Forms.ToolStripTextBox()
        Me.TSLabelMes = New System.Windows.Forms.ToolStripLabel()
        Me.TSComboBoxMes = New System.Windows.Forms.ToolStripComboBox()
        Me.TSLabelFiltro1 = New System.Windows.Forms.ToolStripLabel()
        Me.TSComboBoxFiltro1 = New System.Windows.Forms.ToolStripComboBox()
        Me.TSComboBoxOpera1 = New System.Windows.Forms.ToolStripComboBox()
        Me.TSTextBoxFiltro1 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSLabelFiltro2 = New System.Windows.Forms.ToolStripLabel()
        Me.TSComboBoxFiltro2 = New System.Windows.Forms.ToolStripComboBox()
        Me.TSComboBoxOpera2 = New System.Windows.Forms.ToolStripComboBox()
        Me.TSTextBoxFiltro2 = New System.Windows.Forms.ToolStripTextBox()
        Me.TabPagePapelera = New System.Windows.Forms.TabPage()
        Me.SplitContainerPapelera = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainerPapelera = New System.Windows.Forms.ToolStripContainer()
        Me.DGVPapelera = New System.Windows.Forms.DataGridView()
        Me.PapeleraId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraSeleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PapeleraNroComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraTComprobanteId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraTipoComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraProveedorId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraCategoriaGastoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraCategoriaGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraPersonaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraSeccionalId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraSeccional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraReintegro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapeleraComentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bPapeleraEliminar = New System.Windows.Forms.Button()
        Me.bPapeleraVaciarPapelera = New System.Windows.Forms.Button()
        Me.bPapeleraRestaurar = New System.Windows.Forms.Button()
        Me.TSButtonFiltrar = New System.Windows.Forms.ToolStripButton()
        Me.TSButtonQuitarFiltros = New System.Windows.Forms.ToolStripButton()
        Me.TabControl.SuspendLayout()
        Me.TabPageAgregar.SuspendLayout()
        Me.GroupBoxAgregar.SuspendLayout()
        Me.TabPageModificar.SuspendLayout()
        Me.ToolStripContainerModificar.ContentPanel.SuspendLayout()
        Me.ToolStripContainerModificar.RightToolStripPanel.SuspendLayout()
        Me.ToolStripContainerModificar.SuspendLayout()
        CType(Me.SplitContainerModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerModificar.Panel1.SuspendLayout()
        Me.SplitContainerModificar.Panel2.SuspendLayout()
        Me.SplitContainerModificar.SuspendLayout()
        CType(Me.DGVModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripModificar.SuspendLayout()
        Me.TabPagePapelera.SuspendLayout()
        CType(Me.SplitContainerPapelera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPapelera.Panel1.SuspendLayout()
        Me.SplitContainerPapelera.Panel2.SuspendLayout()
        Me.SplitContainerPapelera.SuspendLayout()
        Me.ToolStripContainerPapelera.ContentPanel.SuspendLayout()
        Me.ToolStripContainerPapelera.SuspendLayout()
        CType(Me.DGVPapelera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageAgregar)
        Me.TabControl.Controls.Add(Me.TabPageModificar)
        Me.TabControl.Controls.Add(Me.TabPagePapelera)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(755, 456)
        Me.TabControl.TabIndex = 0
        Me.TabControl.TabStop = False
        '
        'TabPageAgregar
        '
        Me.TabPageAgregar.Controls.Add(Me.GroupBoxAgregar)
        Me.TabPageAgregar.Controls.Add(Me.lb_Titulo)
        Me.TabPageAgregar.Location = New System.Drawing.Point(4, 25)
        Me.TabPageAgregar.Name = "TabPageAgregar"
        Me.TabPageAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAgregar.Size = New System.Drawing.Size(747, 427)
        Me.TabPageAgregar.TabIndex = 0
        Me.TabPageAgregar.Text = "Agregar"
        Me.TabPageAgregar.UseVisualStyleBackColor = True
        '
        'GroupBoxAgregar
        '
        Me.GroupBoxAgregar.Controls.Add(Me.cbTComprobante)
        Me.GroupBoxAgregar.Controls.Add(Me.cbSeccional)
        Me.GroupBoxAgregar.Controls.Add(Me.cbTGasto)
        Me.GroupBoxAgregar.Controls.Add(Me.lbFecha)
        Me.GroupBoxAgregar.Controls.Add(Me.dtpFecha)
        Me.GroupBoxAgregar.Controls.Add(Me.dtpReintegro)
        Me.GroupBoxAgregar.Controls.Add(Me.lbSeccional)
        Me.GroupBoxAgregar.Controls.Add(Me.tbNComprobante)
        Me.GroupBoxAgregar.Controls.Add(Me.tbPVenta)
        Me.GroupBoxAgregar.Controls.Add(Me.lbSmonto)
        Me.GroupBoxAgregar.Controls.Add(Me.lbTComprobante)
        Me.GroupBoxAgregar.Controls.Add(Me.tbMonto)
        Me.GroupBoxAgregar.Controls.Add(Me.btnGuardar)
        Me.GroupBoxAgregar.Controls.Add(Me.lbGasto)
        Me.GroupBoxAgregar.Controls.Add(Me.tbNombre)
        Me.GroupBoxAgregar.Controls.Add(Me.lbMes)
        Me.GroupBoxAgregar.Controls.Add(Me.lbComentario)
        Me.GroupBoxAgregar.Controls.Add(Me.lbMonto)
        Me.GroupBoxAgregar.Controls.Add(Me.lbProveedor)
        Me.GroupBoxAgregar.Controls.Add(Me.lbNombre)
        Me.GroupBoxAgregar.Controls.Add(Me.lbNComprobante)
        Me.GroupBoxAgregar.Controls.Add(Me.tbComentario)
        Me.GroupBoxAgregar.Controls.Add(Me.tbProveedor)
        Me.GroupBoxAgregar.Location = New System.Drawing.Point(6, 43)
        Me.GroupBoxAgregar.Name = "GroupBoxAgregar"
        Me.GroupBoxAgregar.Size = New System.Drawing.Size(735, 378)
        Me.GroupBoxAgregar.TabIndex = 92
        Me.GroupBoxAgregar.TabStop = False
        Me.GroupBoxAgregar.Text = "Agregar Nuevo Egreso"
        '
        'cbTComprobante
        '
        Me.cbTComprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbTComprobante.FormattingEnabled = True
        Me.cbTComprobante.Location = New System.Drawing.Point(539, 84)
        Me.cbTComprobante.Name = "cbTComprobante"
        Me.cbTComprobante.Size = New System.Drawing.Size(163, 24)
        Me.cbTComprobante.TabIndex = 464
        '
        'cbSeccional
        '
        Me.cbSeccional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbSeccional.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbSeccional.FormattingEnabled = True
        Me.cbSeccional.Location = New System.Drawing.Point(153, 219)
        Me.cbSeccional.Name = "cbSeccional"
        Me.cbSeccional.Size = New System.Drawing.Size(156, 24)
        Me.cbSeccional.TabIndex = 462
        '
        'cbTGasto
        '
        Me.cbTGasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTGasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbTGasto.FormattingEnabled = True
        Me.cbTGasto.Location = New System.Drawing.Point(153, 84)
        Me.cbTGasto.Name = "cbTGasto"
        Me.cbTGasto.Size = New System.Drawing.Size(156, 24)
        Me.cbTGasto.TabIndex = 459
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(393, 45)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(49, 16)
        Me.lbFecha.TabIndex = 480
        Me.lbFecha.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(539, 40)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(163, 22)
        Me.dtpFecha.TabIndex = 463
        Me.dtpFecha.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
        '
        'dtpReintegro
        '
        Me.dtpReintegro.Checked = False
        Me.dtpReintegro.CustomFormat = "MM/yyyy"
        Me.dtpReintegro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReintegro.Location = New System.Drawing.Point(153, 171)
        Me.dtpReintegro.Name = "dtpReintegro"
        Me.dtpReintegro.ShowCheckBox = True
        Me.dtpReintegro.ShowUpDown = True
        Me.dtpReintegro.Size = New System.Drawing.Size(156, 22)
        Me.dtpReintegro.TabIndex = 461
        Me.dtpReintegro.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
        '
        'lbSeccional
        '
        Me.lbSeccional.AutoSize = True
        Me.lbSeccional.Location = New System.Drawing.Point(34, 222)
        Me.lbSeccional.Name = "lbSeccional"
        Me.lbSeccional.Size = New System.Drawing.Size(68, 16)
        Me.lbSeccional.TabIndex = 479
        Me.lbSeccional.Text = "Seccional"
        '
        'tbNComprobante
        '
        Me.tbNComprobante.Location = New System.Drawing.Point(605, 129)
        Me.tbNComprobante.Name = "tbNComprobante"
        Me.tbNComprobante.Size = New System.Drawing.Size(97, 22)
        Me.tbNComprobante.TabIndex = 466
        '
        'tbPVenta
        '
        Me.tbPVenta.Location = New System.Drawing.Point(539, 129)
        Me.tbPVenta.Name = "tbPVenta"
        Me.tbPVenta.Size = New System.Drawing.Size(56, 22)
        Me.tbPVenta.TabIndex = 465
        '
        'lbSmonto
        '
        Me.lbSmonto.AutoSize = True
        Me.lbSmonto.Location = New System.Drawing.Point(518, 176)
        Me.lbSmonto.Name = "lbSmonto"
        Me.lbSmonto.Size = New System.Drawing.Size(15, 16)
        Me.lbSmonto.TabIndex = 478
        Me.lbSmonto.Text = "$"
        '
        'lbTComprobante
        '
        Me.lbTComprobante.AutoSize = True
        Me.lbTComprobante.Location = New System.Drawing.Point(393, 87)
        Me.lbTComprobante.Name = "lbTComprobante"
        Me.lbTComprobante.Size = New System.Drawing.Size(140, 16)
        Me.lbTComprobante.TabIndex = 477
        Me.lbTComprobante.Text = "Tipo de Comprobante"
        '
        'tbMonto
        '
        Me.tbMonto.Location = New System.Drawing.Point(539, 173)
        Me.tbMonto.Name = "tbMonto"
        Me.tbMonto.Size = New System.Drawing.Size(163, 22)
        Me.tbMonto.TabIndex = 467
        Me.tbMonto.Tag = ""
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Green
        Me.btnGuardar.Location = New System.Drawing.Point(553, 278)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(126, 61)
        Me.btnGuardar.TabIndex = 469
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lbGasto
        '
        Me.lbGasto.AutoSize = True
        Me.lbGasto.Location = New System.Drawing.Point(30, 87)
        Me.lbGasto.Name = "lbGasto"
        Me.lbGasto.Size = New System.Drawing.Size(63, 16)
        Me.lbGasto.TabIndex = 476
        Me.lbGasto.Text = "Gasto de"
        '
        'tbNombre
        '
        Me.tbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbNombre.BackColor = System.Drawing.SystemColors.Window
        Me.tbNombre.Location = New System.Drawing.Point(153, 40)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(197, 22)
        Me.tbNombre.TabIndex = 458
        '
        'lbMes
        '
        Me.lbMes.AutoSize = True
        Me.lbMes.Location = New System.Drawing.Point(30, 176)
        Me.lbMes.Name = "lbMes"
        Me.lbMes.Size = New System.Drawing.Size(115, 16)
        Me.lbMes.TabIndex = 475
        Me.lbMes.Text = "Mes de Reintegro"
        '
        'lbComentario
        '
        Me.lbComentario.AutoSize = True
        Me.lbComentario.Location = New System.Drawing.Point(30, 269)
        Me.lbComentario.Name = "lbComentario"
        Me.lbComentario.Size = New System.Drawing.Size(77, 16)
        Me.lbComentario.TabIndex = 474
        Me.lbComentario.Text = "Comentario"
        '
        'lbMonto
        '
        Me.lbMonto.AutoSize = True
        Me.lbMonto.Location = New System.Drawing.Point(393, 176)
        Me.lbMonto.Name = "lbMonto"
        Me.lbMonto.Size = New System.Drawing.Size(45, 16)
        Me.lbMonto.TabIndex = 473
        Me.lbMonto.Text = "Monto"
        '
        'lbProveedor
        '
        Me.lbProveedor.AutoSize = True
        Me.lbProveedor.Location = New System.Drawing.Point(30, 132)
        Me.lbProveedor.Name = "lbProveedor"
        Me.lbProveedor.Size = New System.Drawing.Size(72, 16)
        Me.lbProveedor.TabIndex = 472
        Me.lbProveedor.Text = "Proveedor"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(30, 43)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(120, 16)
        Me.lbNombre.TabIndex = 471
        Me.lbNombre.Text = "Nombre y Apellido"
        '
        'lbNComprobante
        '
        Me.lbNComprobante.AutoSize = True
        Me.lbNComprobante.Location = New System.Drawing.Point(393, 132)
        Me.lbNComprobante.Name = "lbNComprobante"
        Me.lbNComprobante.Size = New System.Drawing.Size(107, 16)
        Me.lbNComprobante.TabIndex = 470
        Me.lbNComprobante.Text = "N° Comprobante"
        '
        'tbComentario
        '
        Me.tbComentario.Location = New System.Drawing.Point(113, 266)
        Me.tbComentario.Multiline = True
        Me.tbComentario.Name = "tbComentario"
        Me.tbComentario.Size = New System.Drawing.Size(387, 100)
        Me.tbComentario.TabIndex = 468
        '
        'tbProveedor
        '
        Me.tbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbProveedor.Location = New System.Drawing.Point(153, 129)
        Me.tbProveedor.Name = "tbProveedor"
        Me.tbProveedor.Size = New System.Drawing.Size(156, 22)
        Me.tbProveedor.TabIndex = 460
        '
        'lb_Titulo
        '
        Me.lb_Titulo.AutoSize = True
        Me.lb_Titulo.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Titulo.Location = New System.Drawing.Point(284, 2)
        Me.lb_Titulo.Name = "lb_Titulo"
        Me.lb_Titulo.Size = New System.Drawing.Size(193, 38)
        Me.lb_Titulo.TabIndex = 91
        Me.lb_Titulo.Text = "Nuevo Egreso"
        '
        'TabPageModificar
        '
        Me.TabPageModificar.Controls.Add(Me.ToolStripContainerModificar)
        Me.TabPageModificar.Location = New System.Drawing.Point(4, 25)
        Me.TabPageModificar.Name = "TabPageModificar"
        Me.TabPageModificar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageModificar.Size = New System.Drawing.Size(747, 427)
        Me.TabPageModificar.TabIndex = 1
        Me.TabPageModificar.Text = "Modificar"
        Me.TabPageModificar.UseVisualStyleBackColor = True
        '
        'ToolStripContainerModificar
        '
        Me.ToolStripContainerModificar.BottomToolStripPanelVisible = False
        '
        'ToolStripContainerModificar.ContentPanel
        '
        Me.ToolStripContainerModificar.ContentPanel.Controls.Add(Me.SplitContainerModificar)
        Me.ToolStripContainerModificar.ContentPanel.Size = New System.Drawing.Size(595, 421)
        Me.ToolStripContainerModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainerModificar.LeftToolStripPanelVisible = False
        Me.ToolStripContainerModificar.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainerModificar.Name = "ToolStripContainerModificar"
        '
        'ToolStripContainerModificar.RightToolStripPanel
        '
        Me.ToolStripContainerModificar.RightToolStripPanel.Controls.Add(Me.ToolStripModificar)
        Me.ToolStripContainerModificar.Size = New System.Drawing.Size(741, 421)
        Me.ToolStripContainerModificar.TabIndex = 1
        Me.ToolStripContainerModificar.Text = "ToolStripContainer1"
        Me.ToolStripContainerModificar.TopToolStripPanelVisible = False
        '
        'SplitContainerModificar
        '
        Me.SplitContainerModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerModificar.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerModificar.Name = "SplitContainerModificar"
        Me.SplitContainerModificar.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerModificar.Panel1
        '
        Me.SplitContainerModificar.Panel1.Controls.Add(Me.DGVModificar)
        '
        'SplitContainerModificar.Panel2
        '
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.ButtonEliminar)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.LabelSeccional)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.ComboBoxSeccional)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.DateTimePickerMesReintegro)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.DateTimePickerFecha)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.TextBoxNroComprobante)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.ComboBoxTipoComprobante)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.TextBoxPVenta)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.TextBoxMonto)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.ComboBoxCategGasto)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.ButtonGuardar)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.TextBoxNombre)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.TextBoxComentario)
        Me.SplitContainerModificar.Panel2.Controls.Add(Me.TextBoxProveedor)
        Me.SplitContainerModificar.Size = New System.Drawing.Size(595, 421)
        Me.SplitContainerModificar.SplitterDistance = 201
        Me.SplitContainerModificar.TabIndex = 1
        '
        'DGVModificar
        '
        Me.DGVModificar.AllowUserToAddRows = False
        Me.DGVModificar.AllowUserToDeleteRows = False
        Me.DGVModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVModificar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.seleccionado, Me.nro_comprobante, Me.tipo_comprobante_id, Me.tipo_comprobante_nombre, Me.proveedor_id, Me.proveedor_nombre, Me.categoria_gasto_id, Me.categoria_nombre, Me.persona_id, Me.persona_nombre, Me.fecha, Me.seccional_id, Me.seccional_nombre, Me.mes_reintegro, Me.monto, Me.comentario})
        Me.DGVModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVModificar.Location = New System.Drawing.Point(0, 0)
        Me.DGVModificar.Name = "DGVModificar"
        Me.DGVModificar.ReadOnly = True
        Me.DGVModificar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVModificar.Size = New System.Drawing.Size(595, 201)
        Me.DGVModificar.TabIndex = 1
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'seleccionado
        '
        Me.seleccionado.HeaderText = "Seleccionado"
        Me.seleccionado.Name = "seleccionado"
        Me.seleccionado.ReadOnly = True
        '
        'nro_comprobante
        '
        Me.nro_comprobante.HeaderText = "Nro Comprobante"
        Me.nro_comprobante.Name = "nro_comprobante"
        Me.nro_comprobante.ReadOnly = True
        '
        'tipo_comprobante_id
        '
        Me.tipo_comprobante_id.HeaderText = "tipo_comprobante_id"
        Me.tipo_comprobante_id.Name = "tipo_comprobante_id"
        Me.tipo_comprobante_id.ReadOnly = True
        Me.tipo_comprobante_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tipo_comprobante_id.Visible = False
        '
        'tipo_comprobante_nombre
        '
        Me.tipo_comprobante_nombre.HeaderText = "Tipo Comprobante"
        Me.tipo_comprobante_nombre.Name = "tipo_comprobante_nombre"
        Me.tipo_comprobante_nombre.ReadOnly = True
        '
        'proveedor_id
        '
        Me.proveedor_id.HeaderText = "proveedor_id"
        Me.proveedor_id.Name = "proveedor_id"
        Me.proveedor_id.ReadOnly = True
        Me.proveedor_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.proveedor_id.Visible = False
        '
        'proveedor_nombre
        '
        Me.proveedor_nombre.HeaderText = "Proveedor"
        Me.proveedor_nombre.Name = "proveedor_nombre"
        Me.proveedor_nombre.ReadOnly = True
        '
        'categoria_gasto_id
        '
        Me.categoria_gasto_id.HeaderText = "categoria_gasto_id"
        Me.categoria_gasto_id.Name = "categoria_gasto_id"
        Me.categoria_gasto_id.ReadOnly = True
        Me.categoria_gasto_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.categoria_gasto_id.Visible = False
        '
        'categoria_nombre
        '
        Me.categoria_nombre.HeaderText = "Categoria Gasto"
        Me.categoria_nombre.Name = "categoria_nombre"
        Me.categoria_nombre.ReadOnly = True
        '
        'persona_id
        '
        Me.persona_id.HeaderText = "persona_id"
        Me.persona_id.Name = "persona_id"
        Me.persona_id.ReadOnly = True
        Me.persona_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.persona_id.Visible = False
        '
        'persona_nombre
        '
        Me.persona_nombre.HeaderText = "Persona"
        Me.persona_nombre.Name = "persona_nombre"
        Me.persona_nombre.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'seccional_id
        '
        Me.seccional_id.HeaderText = "seccional_id"
        Me.seccional_id.Name = "seccional_id"
        Me.seccional_id.ReadOnly = True
        Me.seccional_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.seccional_id.Visible = False
        '
        'seccional_nombre
        '
        Me.seccional_nombre.HeaderText = "Seccional"
        Me.seccional_nombre.Name = "seccional_nombre"
        Me.seccional_nombre.ReadOnly = True
        '
        'mes_reintegro
        '
        Me.mes_reintegro.HeaderText = "Mes Reintegro"
        Me.mes_reintegro.Name = "mes_reintegro"
        Me.mes_reintegro.ReadOnly = True
        '
        'monto
        '
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'comentario
        '
        Me.comentario.HeaderText = "Comentario"
        Me.comentario.Name = "comentario"
        Me.comentario.ReadOnly = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.Red
        Me.ButtonEliminar.Location = New System.Drawing.Point(449, 182)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(150, 31)
        Me.ButtonEliminar.TabIndex = 103
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'LabelSeccional
        '
        Me.LabelSeccional.AutoSize = True
        Me.LabelSeccional.Location = New System.Drawing.Point(13, 130)
        Me.LabelSeccional.Name = "LabelSeccional"
        Me.LabelSeccional.Size = New System.Drawing.Size(68, 16)
        Me.LabelSeccional.TabIndex = 119
        Me.LabelSeccional.Text = "Seccional"
        '
        'ComboBoxSeccional
        '
        Me.ComboBoxSeccional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxSeccional.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxSeccional.FormattingEnabled = True
        Me.ComboBoxSeccional.Location = New System.Drawing.Point(133, 127)
        Me.ComboBoxSeccional.Name = "ComboBoxSeccional"
        Me.ComboBoxSeccional.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxSeccional.TabIndex = 95
        '
        'DateTimePickerMesReintegro
        '
        Me.DateTimePickerMesReintegro.Checked = False
        Me.DateTimePickerMesReintegro.CustomFormat = "MM/yyyy"
        Me.DateTimePickerMesReintegro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerMesReintegro.Location = New System.Drawing.Point(133, 99)
        Me.DateTimePickerMesReintegro.Name = "DateTimePickerMesReintegro"
        Me.DateTimePickerMesReintegro.ShowCheckBox = True
        Me.DateTimePickerMesReintegro.ShowUpDown = True
        Me.DateTimePickerMesReintegro.Size = New System.Drawing.Size(160, 22)
        Me.DateTimePickerMesReintegro.TabIndex = 94
        Me.DateTimePickerMesReintegro.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(305, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Fecha:"
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.CustomFormat = ""
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(444, 13)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(160, 22)
        Me.DateTimePickerFecha.TabIndex = 96
        Me.DateTimePickerFecha.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
        '
        'TextBoxNroComprobante
        '
        Me.TextBoxNroComprobante.Location = New System.Drawing.Point(499, 71)
        Me.TextBoxNroComprobante.Name = "TextBoxNroComprobante"
        Me.TextBoxNroComprobante.Size = New System.Drawing.Size(105, 22)
        Me.TextBoxNroComprobante.TabIndex = 99
        '
        'ComboBoxTipoComprobante
        '
        Me.ComboBoxTipoComprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxTipoComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxTipoComprobante.FormattingEnabled = True
        Me.ComboBoxTipoComprobante.Location = New System.Drawing.Point(444, 41)
        Me.ComboBoxTipoComprobante.Name = "ComboBoxTipoComprobante"
        Me.ComboBoxTipoComprobante.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxTipoComprobante.TabIndex = 97
        '
        'TextBoxPVenta
        '
        Me.TextBoxPVenta.Location = New System.Drawing.Point(444, 71)
        Me.TextBoxPVenta.Name = "TextBoxPVenta"
        Me.TextBoxPVenta.Size = New System.Drawing.Size(49, 22)
        Me.TextBoxPVenta.TabIndex = 98
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(423, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 16)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 16)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Tipo de Comprobante"
        '
        'TextBoxMonto
        '
        Me.TextBoxMonto.Location = New System.Drawing.Point(444, 99)
        Me.TextBoxMonto.Name = "TextBoxMonto"
        Me.TextBoxMonto.Size = New System.Drawing.Size(160, 22)
        Me.TextBoxMonto.TabIndex = 100
        Me.TextBoxMonto.Tag = ""
        '
        'ComboBoxCategGasto
        '
        Me.ComboBoxCategGasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxCategGasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxCategGasto.FormattingEnabled = True
        Me.ComboBoxCategGasto.Location = New System.Drawing.Point(133, 41)
        Me.ComboBoxCategGasto.Name = "ComboBoxCategGasto"
        Me.ComboBoxCategGasto.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxCategGasto.TabIndex = 92
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.Green
        Me.ButtonGuardar.Location = New System.Drawing.Point(449, 145)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(150, 31)
        Me.ButtonGuardar.TabIndex = 102
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Gasto de"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBoxNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxNombre.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNombre.Location = New System.Drawing.Point(133, 13)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(160, 22)
        Me.TextBoxNombre.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 16)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Mes de Reintegro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Comentario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(305, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Monto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Proveedor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Nombre y Apellido"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(305, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 16)
        Me.Label12.TabIndex = 106
        Me.Label12.Text = "N° Comprobante"
        '
        'TextBoxComentario
        '
        Me.TextBoxComentario.Location = New System.Drawing.Point(133, 157)
        Me.TextBoxComentario.Multiline = True
        Me.TextBoxComentario.Name = "TextBoxComentario"
        Me.TextBoxComentario.Size = New System.Drawing.Size(300, 56)
        Me.TextBoxComentario.TabIndex = 101
        '
        'TextBoxProveedor
        '
        Me.TextBoxProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBoxProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxProveedor.Location = New System.Drawing.Point(133, 71)
        Me.TextBoxProveedor.Name = "TextBoxProveedor"
        Me.TextBoxProveedor.Size = New System.Drawing.Size(160, 22)
        Me.TextBoxProveedor.TabIndex = 93
        '
        'ToolStripModificar
        '
        Me.ToolStripModificar.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripModificar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripModificar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLabelTrimestre, Me.TSComboBoxTrimestre, Me.TSLabelAño, Me.TSTextBoxAño, Me.TSLabelMes, Me.TSComboBoxMes, Me.TSLabelFiltro1, Me.TSComboBoxFiltro1, Me.TSComboBoxOpera1, Me.TSTextBoxFiltro1, Me.TSLabelFiltro2, Me.TSComboBoxFiltro2, Me.TSComboBoxOpera2, Me.TSTextBoxFiltro2, Me.TSButtonFiltrar, Me.TSButtonQuitarFiltros})
        Me.ToolStripModificar.Location = New System.Drawing.Point(0, 3)
        Me.ToolStripModificar.Name = "ToolStripModificar"
        Me.ToolStripModificar.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripModificar.Size = New System.Drawing.Size(146, 398)
        Me.ToolStripModificar.TabIndex = 0
        '
        'TSLabelTrimestre
        '
        Me.TSLabelTrimestre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSLabelTrimestre.Name = "TSLabelTrimestre"
        Me.TSLabelTrimestre.Size = New System.Drawing.Size(139, 15)
        Me.TSLabelTrimestre.Text = "Trimestre: "
        '
        'TSComboBoxTrimestre
        '
        Me.TSComboBoxTrimestre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TSComboBoxTrimestre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TSComboBoxTrimestre.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.TSComboBoxTrimestre.Items.AddRange(New Object() {"", "Primero", "Segundo", "Tercero", "Cuarto"})
        Me.TSComboBoxTrimestre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSComboBoxTrimestre.Name = "TSComboBoxTrimestre"
        Me.TSComboBoxTrimestre.Size = New System.Drawing.Size(139, 23)
        '
        'TSLabelAño
        '
        Me.TSLabelAño.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSLabelAño.Name = "TSLabelAño"
        Me.TSLabelAño.Size = New System.Drawing.Size(139, 15)
        Me.TSLabelAño.Text = "Año: "
        '
        'TSTextBoxAño
        '
        Me.TSTextBoxAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TSTextBoxAño.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSTextBoxAño.Name = "TSTextBoxAño"
        Me.TSTextBoxAño.Size = New System.Drawing.Size(139, 23)
        '
        'TSLabelMes
        '
        Me.TSLabelMes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSLabelMes.Name = "TSLabelMes"
        Me.TSLabelMes.Size = New System.Drawing.Size(139, 15)
        Me.TSLabelMes.Text = "Mes:"
        '
        'TSComboBoxMes
        '
        Me.TSComboBoxMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TSComboBoxMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TSComboBoxMes.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.TSComboBoxMes.Items.AddRange(New Object() {"", "01 - Enero", "02 - Febrero", "03 - Marzo", "04 - Abril", "05 - Mayo", "06 - Junio", "07 - Julio", "08 - Agosto", "09 - Septiembre", "10 - Octubre", "11 - Noviembre", "12 - Diciembre"})
        Me.TSComboBoxMes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSComboBoxMes.Name = "TSComboBoxMes"
        Me.TSComboBoxMes.Size = New System.Drawing.Size(139, 23)
        '
        'TSLabelFiltro1
        '
        Me.TSLabelFiltro1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSLabelFiltro1.Name = "TSLabelFiltro1"
        Me.TSLabelFiltro1.Size = New System.Drawing.Size(139, 15)
        Me.TSLabelFiltro1.Text = "Filtrar Por:"
        '
        'TSComboBoxFiltro1
        '
        Me.TSComboBoxFiltro1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TSComboBoxFiltro1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TSComboBoxFiltro1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.TSComboBoxFiltro1.Items.AddRange(New Object() {"", "Nro Comprobante", "Tipo Comprobante", "Proveedor", "Categoria Gasto", "Persona", "Fecha", "Seccional", "Mes Reintegro", "Monto", "Comentario", "Seleccionado"})
        Me.TSComboBoxFiltro1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSComboBoxFiltro1.Name = "TSComboBoxFiltro1"
        Me.TSComboBoxFiltro1.Size = New System.Drawing.Size(139, 23)
        Me.TSComboBoxFiltro1.ToolTipText = "Seleccione columna por la cual desea filtrar"
        '
        'TSComboBoxOpera1
        '
        Me.TSComboBoxOpera1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.TSComboBoxOpera1.Items.AddRange(New Object() {"*", "="})
        Me.TSComboBoxOpera1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSComboBoxOpera1.Name = "TSComboBoxOpera1"
        Me.TSComboBoxOpera1.Size = New System.Drawing.Size(139, 23)
        Me.TSComboBoxOpera1.Text = "*"
        Me.TSComboBoxOpera1.ToolTipText = "Elija entre buscar resultados apróximados o exactos"
        '
        'TSTextBoxFiltro1
        '
        Me.TSTextBoxFiltro1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TSTextBoxFiltro1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSTextBoxFiltro1.Name = "TSTextBoxFiltro1"
        Me.TSTextBoxFiltro1.Size = New System.Drawing.Size(139, 23)
        Me.TSTextBoxFiltro1.ToolTipText = "Ingresar valores por los cuales quiere filtrar la tabla."
        '
        'TSLabelFiltro2
        '
        Me.TSLabelFiltro2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSLabelFiltro2.Name = "TSLabelFiltro2"
        Me.TSLabelFiltro2.Size = New System.Drawing.Size(139, 15)
        Me.TSLabelFiltro2.Text = "Filtro Adicional: "
        '
        'TSComboBoxFiltro2
        '
        Me.TSComboBoxFiltro2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TSComboBoxFiltro2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TSComboBoxFiltro2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.TSComboBoxFiltro2.Items.AddRange(New Object() {"", "Nro Comprobante", "Tipo Comprobante", "Proveedor", "Categoria Gasto", "Persona", "Fecha", "Seccional", "Mes Reintegro", "Monto", "Comentario", "Seleccionado"})
        Me.TSComboBoxFiltro2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSComboBoxFiltro2.Name = "TSComboBoxFiltro2"
        Me.TSComboBoxFiltro2.Size = New System.Drawing.Size(139, 23)
        Me.TSComboBoxFiltro2.ToolTipText = "Seleccione columna por la cual desea filtrar"
        '
        'TSComboBoxOpera2
        '
        Me.TSComboBoxOpera2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.TSComboBoxOpera2.Items.AddRange(New Object() {"*", "="})
        Me.TSComboBoxOpera2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSComboBoxOpera2.Name = "TSComboBoxOpera2"
        Me.TSComboBoxOpera2.Size = New System.Drawing.Size(139, 23)
        Me.TSComboBoxOpera2.Text = "*"
        Me.TSComboBoxOpera2.ToolTipText = "Elija entre buscar resultados apróximados o exactos"
        '
        'TSTextBoxFiltro2
        '
        Me.TSTextBoxFiltro2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TSTextBoxFiltro2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSTextBoxFiltro2.Name = "TSTextBoxFiltro2"
        Me.TSTextBoxFiltro2.Size = New System.Drawing.Size(139, 23)
        '
        'TabPagePapelera
        '
        Me.TabPagePapelera.Controls.Add(Me.SplitContainerPapelera)
        Me.TabPagePapelera.Location = New System.Drawing.Point(4, 25)
        Me.TabPagePapelera.Name = "TabPagePapelera"
        Me.TabPagePapelera.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePapelera.Size = New System.Drawing.Size(747, 427)
        Me.TabPagePapelera.TabIndex = 2
        Me.TabPagePapelera.Text = "Papelera"
        Me.TabPagePapelera.UseVisualStyleBackColor = True
        '
        'SplitContainerPapelera
        '
        Me.SplitContainerPapelera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerPapelera.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerPapelera.Name = "SplitContainerPapelera"
        Me.SplitContainerPapelera.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerPapelera.Panel1
        '
        Me.SplitContainerPapelera.Panel1.Controls.Add(Me.ToolStripContainerPapelera)
        '
        'SplitContainerPapelera.Panel2
        '
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.bPapeleraEliminar)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.bPapeleraVaciarPapelera)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.bPapeleraRestaurar)
        Me.SplitContainerPapelera.Size = New System.Drawing.Size(741, 421)
        Me.SplitContainerPapelera.SplitterDistance = 350
        Me.SplitContainerPapelera.TabIndex = 1
        '
        'ToolStripContainerPapelera
        '
        '
        'ToolStripContainerPapelera.ContentPanel
        '
        Me.ToolStripContainerPapelera.ContentPanel.Controls.Add(Me.DGVPapelera)
        Me.ToolStripContainerPapelera.ContentPanel.Size = New System.Drawing.Size(741, 325)
        Me.ToolStripContainerPapelera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainerPapelera.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainerPapelera.Name = "ToolStripContainerPapelera"
        Me.ToolStripContainerPapelera.Size = New System.Drawing.Size(741, 350)
        Me.ToolStripContainerPapelera.TabIndex = 0
        Me.ToolStripContainerPapelera.Text = "ToolStripContainer1"
        '
        'DGVPapelera
        '
        Me.DGVPapelera.AllowUserToAddRows = False
        Me.DGVPapelera.AllowUserToDeleteRows = False
        Me.DGVPapelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPapelera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PapeleraId, Me.PapeleraSeleccionado, Me.PapeleraNroComprobante, Me.PapeleraTComprobanteId, Me.PapeleraTipoComprobante, Me.PapeleraProveedorId, Me.PapeleraProveedor, Me.PapeleraCategoriaGastoId, Me.PapeleraCategoriaGasto, Me.PapeleraPersonaId, Me.PapeleraPersona, Me.PapeleraFecha, Me.PapeleraSeccionalId, Me.PapeleraSeccional, Me.PapeleraReintegro, Me.PapeleraMonto, Me.PapeleraComentario})
        Me.DGVPapelera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVPapelera.Location = New System.Drawing.Point(0, 0)
        Me.DGVPapelera.Name = "DGVPapelera"
        Me.DGVPapelera.ReadOnly = True
        Me.DGVPapelera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPapelera.Size = New System.Drawing.Size(741, 325)
        Me.DGVPapelera.TabIndex = 0
        '
        'PapeleraId
        '
        Me.PapeleraId.HeaderText = "Id"
        Me.PapeleraId.Name = "PapeleraId"
        Me.PapeleraId.ReadOnly = True
        Me.PapeleraId.Visible = False
        '
        'PapeleraSeleccionado
        '
        Me.PapeleraSeleccionado.HeaderText = "Seleccionado"
        Me.PapeleraSeleccionado.Name = "PapeleraSeleccionado"
        Me.PapeleraSeleccionado.ReadOnly = True
        '
        'PapeleraNroComprobante
        '
        Me.PapeleraNroComprobante.HeaderText = "Nro Comprobante"
        Me.PapeleraNroComprobante.Name = "PapeleraNroComprobante"
        Me.PapeleraNroComprobante.ReadOnly = True
        '
        'PapeleraTComprobanteId
        '
        Me.PapeleraTComprobanteId.HeaderText = "tipo_comprobante_id"
        Me.PapeleraTComprobanteId.Name = "PapeleraTComprobanteId"
        Me.PapeleraTComprobanteId.ReadOnly = True
        Me.PapeleraTComprobanteId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PapeleraTComprobanteId.Visible = False
        '
        'PapeleraTipoComprobante
        '
        Me.PapeleraTipoComprobante.HeaderText = "Tipo Comprobante"
        Me.PapeleraTipoComprobante.Name = "PapeleraTipoComprobante"
        Me.PapeleraTipoComprobante.ReadOnly = True
        '
        'PapeleraProveedorId
        '
        Me.PapeleraProveedorId.HeaderText = "proveedor_id"
        Me.PapeleraProveedorId.Name = "PapeleraProveedorId"
        Me.PapeleraProveedorId.ReadOnly = True
        Me.PapeleraProveedorId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PapeleraProveedorId.Visible = False
        '
        'PapeleraProveedor
        '
        Me.PapeleraProveedor.HeaderText = "Proveedor"
        Me.PapeleraProveedor.Name = "PapeleraProveedor"
        Me.PapeleraProveedor.ReadOnly = True
        '
        'PapeleraCategoriaGastoId
        '
        Me.PapeleraCategoriaGastoId.HeaderText = "categoria_gasto_id"
        Me.PapeleraCategoriaGastoId.Name = "PapeleraCategoriaGastoId"
        Me.PapeleraCategoriaGastoId.ReadOnly = True
        Me.PapeleraCategoriaGastoId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PapeleraCategoriaGastoId.Visible = False
        '
        'PapeleraCategoriaGasto
        '
        Me.PapeleraCategoriaGasto.HeaderText = "Categoria Gasto"
        Me.PapeleraCategoriaGasto.Name = "PapeleraCategoriaGasto"
        Me.PapeleraCategoriaGasto.ReadOnly = True
        '
        'PapeleraPersonaId
        '
        Me.PapeleraPersonaId.HeaderText = "persona_id"
        Me.PapeleraPersonaId.Name = "PapeleraPersonaId"
        Me.PapeleraPersonaId.ReadOnly = True
        Me.PapeleraPersonaId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PapeleraPersonaId.Visible = False
        '
        'PapeleraPersona
        '
        Me.PapeleraPersona.HeaderText = "Persona"
        Me.PapeleraPersona.Name = "PapeleraPersona"
        Me.PapeleraPersona.ReadOnly = True
        '
        'PapeleraFecha
        '
        Me.PapeleraFecha.HeaderText = "Fecha"
        Me.PapeleraFecha.Name = "PapeleraFecha"
        Me.PapeleraFecha.ReadOnly = True
        '
        'PapeleraSeccionalId
        '
        Me.PapeleraSeccionalId.HeaderText = "seccional_id"
        Me.PapeleraSeccionalId.Name = "PapeleraSeccionalId"
        Me.PapeleraSeccionalId.ReadOnly = True
        Me.PapeleraSeccionalId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PapeleraSeccionalId.Visible = False
        '
        'PapeleraSeccional
        '
        Me.PapeleraSeccional.HeaderText = "Seccional"
        Me.PapeleraSeccional.Name = "PapeleraSeccional"
        Me.PapeleraSeccional.ReadOnly = True
        '
        'PapeleraReintegro
        '
        Me.PapeleraReintegro.HeaderText = "Mes Reintegro"
        Me.PapeleraReintegro.Name = "PapeleraReintegro"
        Me.PapeleraReintegro.ReadOnly = True
        '
        'PapeleraMonto
        '
        Me.PapeleraMonto.HeaderText = "Monto"
        Me.PapeleraMonto.Name = "PapeleraMonto"
        Me.PapeleraMonto.ReadOnly = True
        '
        'PapeleraComentario
        '
        Me.PapeleraComentario.HeaderText = "Comentario"
        Me.PapeleraComentario.Name = "PapeleraComentario"
        Me.PapeleraComentario.ReadOnly = True
        '
        'bPapeleraEliminar
        '
        Me.bPapeleraEliminar.Enabled = False
        Me.bPapeleraEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPapeleraEliminar.ForeColor = System.Drawing.Color.Red
        Me.bPapeleraEliminar.Location = New System.Drawing.Point(289, 5)
        Me.bPapeleraEliminar.Name = "bPapeleraEliminar"
        Me.bPapeleraEliminar.Size = New System.Drawing.Size(163, 56)
        Me.bPapeleraEliminar.TabIndex = 105
        Me.bPapeleraEliminar.Text = "Eliminar Permanetemente"
        Me.bPapeleraEliminar.UseVisualStyleBackColor = True
        '
        'bPapeleraVaciarPapelera
        '
        Me.bPapeleraVaciarPapelera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPapeleraVaciarPapelera.ForeColor = System.Drawing.Color.Red
        Me.bPapeleraVaciarPapelera.Location = New System.Drawing.Point(486, 5)
        Me.bPapeleraVaciarPapelera.Name = "bPapeleraVaciarPapelera"
        Me.bPapeleraVaciarPapelera.Size = New System.Drawing.Size(163, 56)
        Me.bPapeleraVaciarPapelera.TabIndex = 104
        Me.bPapeleraVaciarPapelera.Text = "Vaciar Papelera"
        Me.bPapeleraVaciarPapelera.UseVisualStyleBackColor = True
        '
        'bPapeleraRestaurar
        '
        Me.bPapeleraRestaurar.Enabled = False
        Me.bPapeleraRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPapeleraRestaurar.ForeColor = System.Drawing.Color.Red
        Me.bPapeleraRestaurar.Location = New System.Drawing.Point(91, 5)
        Me.bPapeleraRestaurar.Name = "bPapeleraRestaurar"
        Me.bPapeleraRestaurar.Size = New System.Drawing.Size(163, 56)
        Me.bPapeleraRestaurar.TabIndex = 103
        Me.bPapeleraRestaurar.Text = "Restaurar"
        Me.bPapeleraRestaurar.UseVisualStyleBackColor = True
        '
        'TSButtonFiltrar
        '
        Me.TSButtonFiltrar.BackColor = System.Drawing.Color.LightGreen
        Me.TSButtonFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSButtonFiltrar.Image = CType(resources.GetObject("TSButtonFiltrar.Image"), System.Drawing.Image)
        Me.TSButtonFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSButtonFiltrar.Margin = New System.Windows.Forms.Padding(3)
        Me.TSButtonFiltrar.Name = "TSButtonFiltrar"
        Me.TSButtonFiltrar.Padding = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.TSButtonFiltrar.Size = New System.Drawing.Size(139, 23)
        Me.TSButtonFiltrar.Text = "Filtrar"
        '
        'TSButtonQuitarFiltros
        '
        Me.TSButtonQuitarFiltros.BackColor = System.Drawing.Color.LightBlue
        Me.TSButtonQuitarFiltros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSButtonQuitarFiltros.Image = CType(resources.GetObject("TSButtonQuitarFiltros.Image"), System.Drawing.Image)
        Me.TSButtonQuitarFiltros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSButtonQuitarFiltros.Margin = New System.Windows.Forms.Padding(3)
        Me.TSButtonQuitarFiltros.Name = "TSButtonQuitarFiltros"
        Me.TSButtonQuitarFiltros.Padding = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.TSButtonQuitarFiltros.Size = New System.Drawing.Size(139, 23)
        Me.TSButtonQuitarFiltros.Text = "Quitar Filtros"
        '
        'ABMEgresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.TabControl)
        Me.Name = "ABMEgresos"
        Me.Size = New System.Drawing.Size(755, 456)
        Me.TabControl.ResumeLayout(False)
        Me.TabPageAgregar.ResumeLayout(False)
        Me.TabPageAgregar.PerformLayout()
        Me.GroupBoxAgregar.ResumeLayout(False)
        Me.GroupBoxAgregar.PerformLayout()
        Me.TabPageModificar.ResumeLayout(False)
        Me.ToolStripContainerModificar.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainerModificar.RightToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainerModificar.RightToolStripPanel.PerformLayout()
        Me.ToolStripContainerModificar.ResumeLayout(False)
        Me.ToolStripContainerModificar.PerformLayout()
        Me.SplitContainerModificar.Panel1.ResumeLayout(False)
        Me.SplitContainerModificar.Panel2.ResumeLayout(False)
        Me.SplitContainerModificar.Panel2.PerformLayout()
        CType(Me.SplitContainerModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerModificar.ResumeLayout(False)
        CType(Me.DGVModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripModificar.ResumeLayout(False)
        Me.ToolStripModificar.PerformLayout()
        Me.TabPagePapelera.ResumeLayout(False)
        Me.SplitContainerPapelera.Panel1.ResumeLayout(False)
        Me.SplitContainerPapelera.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerPapelera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPapelera.ResumeLayout(False)
        Me.ToolStripContainerPapelera.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainerPapelera.ResumeLayout(False)
        Me.ToolStripContainerPapelera.PerformLayout()
        CType(Me.DGVPapelera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageAgregar As TabPage
    Friend WithEvents lb_Titulo As Label
    Friend WithEvents TabPageModificar As TabPage
    Friend WithEvents TabPagePapelera As TabPage
    Friend WithEvents SplitContainerPapelera As SplitContainer
    Friend WithEvents ToolStripContainerPapelera As ToolStripContainer
    Friend WithEvents DGVPapelera As DataGridView
    Friend WithEvents bPapeleraRestaurar As Button
    Friend WithEvents bPapeleraVaciarPapelera As Button
    Friend WithEvents bPapeleraEliminar As Button
    Friend WithEvents PapeleraId As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraSeleccionado As DataGridViewCheckBoxColumn
    Friend WithEvents PapeleraNroComprobante As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraTComprobanteId As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraTipoComprobante As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraProveedorId As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraProveedor As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraCategoriaGastoId As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraCategoriaGasto As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraPersonaId As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraPersona As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraFecha As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraSeccionalId As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraSeccional As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraReintegro As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraMonto As DataGridViewTextBoxColumn
    Friend WithEvents PapeleraComentario As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripContainerModificar As ToolStripContainer
    Friend WithEvents SplitContainerModificar As SplitContainer
    Friend WithEvents DGVModificar As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents seleccionado As DataGridViewCheckBoxColumn
    Friend WithEvents nro_comprobante As DataGridViewTextBoxColumn
    Friend WithEvents tipo_comprobante_id As DataGridViewTextBoxColumn
    Friend WithEvents tipo_comprobante_nombre As DataGridViewTextBoxColumn
    Friend WithEvents proveedor_id As DataGridViewTextBoxColumn
    Friend WithEvents proveedor_nombre As DataGridViewTextBoxColumn
    Friend WithEvents categoria_gasto_id As DataGridViewTextBoxColumn
    Friend WithEvents categoria_nombre As DataGridViewTextBoxColumn
    Friend WithEvents persona_id As DataGridViewTextBoxColumn
    Friend WithEvents persona_nombre As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents seccional_id As DataGridViewTextBoxColumn
    Friend WithEvents seccional_nombre As DataGridViewTextBoxColumn
    Friend WithEvents mes_reintegro As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents comentario As DataGridViewTextBoxColumn
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents LabelSeccional As Label
    Friend WithEvents ComboBoxSeccional As ComboBox
    Friend WithEvents DateTimePickerMesReintegro As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickerFecha As DateTimePicker
    Friend WithEvents TextBoxNroComprobante As TextBox
    Friend WithEvents ComboBoxTipoComprobante As ComboBox
    Friend WithEvents TextBoxPVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxMonto As TextBox
    Friend WithEvents ComboBoxCategGasto As ComboBox
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxComentario As TextBox
    Friend WithEvents TextBoxProveedor As TextBox
    Friend WithEvents ToolStripModificar As ToolStrip
    Friend WithEvents TSLabelTrimestre As ToolStripLabel
    Friend WithEvents TSComboBoxTrimestre As ToolStripComboBox
    Friend WithEvents TSLabelAño As ToolStripLabel
    Friend WithEvents TSTextBoxAño As ToolStripTextBox
    Friend WithEvents TSLabelFiltro1 As ToolStripLabel
    Friend WithEvents TSComboBoxFiltro1 As ToolStripComboBox
    Friend WithEvents TSComboBoxOpera1 As ToolStripComboBox
    Friend WithEvents TSTextBoxFiltro1 As ToolStripTextBox
    Friend WithEvents TSLabelFiltro2 As ToolStripLabel
    Friend WithEvents TSComboBoxFiltro2 As ToolStripComboBox
    Friend WithEvents TSComboBoxOpera2 As ToolStripComboBox
    Friend WithEvents TSTextBoxFiltro2 As ToolStripTextBox
    Friend WithEvents TSButtonFiltrar As ToolStripButton
    Friend WithEvents TSButtonQuitarFiltros As ToolStripButton
    Friend WithEvents GroupBoxAgregar As GroupBox
    Friend WithEvents cbTComprobante As ComboBox
    Friend WithEvents cbSeccional As ComboBox
    Friend WithEvents cbTGasto As ComboBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents dtpReintegro As DateTimePicker
    Friend WithEvents lbSeccional As Label
    Friend WithEvents tbNComprobante As TextBox
    Friend WithEvents tbPVenta As TextBox
    Friend WithEvents lbSmonto As Label
    Friend WithEvents lbTComprobante As Label
    Friend WithEvents tbMonto As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lbGasto As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lbMes As Label
    Friend WithEvents lbComentario As Label
    Friend WithEvents lbMonto As Label
    Friend WithEvents lbProveedor As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbNComprobante As Label
    Friend WithEvents tbComentario As TextBox
    Friend WithEvents tbProveedor As TextBox
    Friend WithEvents TSLabelMes As ToolStripLabel
    Friend WithEvents TSComboBoxMes As ToolStripComboBox
End Class
