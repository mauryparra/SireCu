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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageAgregar = New System.Windows.Forms.TabPage()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpReintegro = New System.Windows.Forms.DateTimePicker()
        Me.lbSeccional = New System.Windows.Forms.Label()
        Me.tbSeccional = New System.Windows.Forms.ComboBox()
        Me.tbNComprobante = New System.Windows.Forms.TextBox()
        Me.lb_Titulo = New System.Windows.Forms.Label()
        Me.tbTComprobante = New System.Windows.Forms.ComboBox()
        Me.tbPVenta = New System.Windows.Forms.TextBox()
        Me.lbSmonto = New System.Windows.Forms.Label()
        Me.lbTComprobante = New System.Windows.Forms.Label()
        Me.tbMonto = New System.Windows.Forms.TextBox()
        Me.tbTGasto = New System.Windows.Forms.ComboBox()
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
        Me.TabPageModificar = New System.Windows.Forms.TabPage()
        Me.SplitContainerModificar = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainerModificar = New System.Windows.Forms.ToolStripContainer()
        Me.DGVModificar = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TabPagePapelera = New System.Windows.Forms.TabPage()
        Me.SplitContainerPapelera = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainerPapelera = New System.Windows.Forms.ToolStripContainer()
        Me.DGVPapelera = New System.Windows.Forms.DataGridView()
        Me.bPapeleraRestaurar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpPapeleraReintegro = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpPapeleraFecha = New System.Windows.Forms.DateTimePicker()
        Me.tbPapeleraNComprobante = New System.Windows.Forms.TextBox()
        Me.tbPapeleraPVenta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbPapeleraMonto = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbPapeleraNombre = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbPapeleraComentario = New System.Windows.Forms.TextBox()
        Me.tbPapeleraProveedor = New System.Windows.Forms.TextBox()
        Me.tbPapeleraTipoGasto = New System.Windows.Forms.TextBox()
        Me.tbPapeleraSeccional = New System.Windows.Forms.TextBox()
        Me.tbPapeleraTipoComprobante = New System.Windows.Forms.TextBox()
        Me.PapeleraId = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TabControl.SuspendLayout()
        Me.TabPageAgregar.SuspendLayout()
        Me.TabPageModificar.SuspendLayout()
        CType(Me.SplitContainerModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerModificar.Panel1.SuspendLayout()
        Me.SplitContainerModificar.Panel2.SuspendLayout()
        Me.SplitContainerModificar.SuspendLayout()
        Me.ToolStripContainerModificar.ContentPanel.SuspendLayout()
        Me.ToolStripContainerModificar.SuspendLayout()
        CType(Me.DGVModificar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPageAgregar.Controls.Add(Me.lbFecha)
        Me.TabPageAgregar.Controls.Add(Me.dtpFecha)
        Me.TabPageAgregar.Controls.Add(Me.dtpReintegro)
        Me.TabPageAgregar.Controls.Add(Me.lbSeccional)
        Me.TabPageAgregar.Controls.Add(Me.tbSeccional)
        Me.TabPageAgregar.Controls.Add(Me.tbNComprobante)
        Me.TabPageAgregar.Controls.Add(Me.lb_Titulo)
        Me.TabPageAgregar.Controls.Add(Me.tbTComprobante)
        Me.TabPageAgregar.Controls.Add(Me.tbPVenta)
        Me.TabPageAgregar.Controls.Add(Me.lbSmonto)
        Me.TabPageAgregar.Controls.Add(Me.lbTComprobante)
        Me.TabPageAgregar.Controls.Add(Me.tbMonto)
        Me.TabPageAgregar.Controls.Add(Me.tbTGasto)
        Me.TabPageAgregar.Controls.Add(Me.btnGuardar)
        Me.TabPageAgregar.Controls.Add(Me.lbGasto)
        Me.TabPageAgregar.Controls.Add(Me.tbNombre)
        Me.TabPageAgregar.Controls.Add(Me.lbMes)
        Me.TabPageAgregar.Controls.Add(Me.lbComentario)
        Me.TabPageAgregar.Controls.Add(Me.lbMonto)
        Me.TabPageAgregar.Controls.Add(Me.lbProveedor)
        Me.TabPageAgregar.Controls.Add(Me.lbNombre)
        Me.TabPageAgregar.Controls.Add(Me.lbNComprobante)
        Me.TabPageAgregar.Controls.Add(Me.tbComentario)
        Me.TabPageAgregar.Controls.Add(Me.tbProveedor)
        Me.TabPageAgregar.Location = New System.Drawing.Point(4, 25)
        Me.TabPageAgregar.Name = "TabPageAgregar"
        Me.TabPageAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAgregar.Size = New System.Drawing.Size(747, 427)
        Me.TabPageAgregar.TabIndex = 0
        Me.TabPageAgregar.Text = "Agregar"
        Me.TabPageAgregar.UseVisualStyleBackColor = True
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(391, 87)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(49, 16)
        Me.lbFecha.TabIndex = 457
        Me.lbFecha.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(537, 82)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(163, 22)
        Me.dtpFecha.TabIndex = 8
        Me.dtpFecha.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
        '
        'dtpReintegro
        '
        Me.dtpReintegro.Checked = False
        Me.dtpReintegro.CustomFormat = "MM/yyyy"
        Me.dtpReintegro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReintegro.Location = New System.Drawing.Point(151, 213)
        Me.dtpReintegro.Name = "dtpReintegro"
        Me.dtpReintegro.ShowCheckBox = True
        Me.dtpReintegro.ShowUpDown = True
        Me.dtpReintegro.Size = New System.Drawing.Size(156, 22)
        Me.dtpReintegro.TabIndex = 6
        Me.dtpReintegro.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
        '
        'lbSeccional
        '
        Me.lbSeccional.AutoSize = True
        Me.lbSeccional.Location = New System.Drawing.Point(32, 264)
        Me.lbSeccional.Name = "lbSeccional"
        Me.lbSeccional.Size = New System.Drawing.Size(68, 16)
        Me.lbSeccional.TabIndex = 93
        Me.lbSeccional.Text = "Seccional"
        '
        'tbSeccional
        '
        Me.tbSeccional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbSeccional.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbSeccional.FormattingEnabled = True
        Me.tbSeccional.Location = New System.Drawing.Point(151, 261)
        Me.tbSeccional.Name = "tbSeccional"
        Me.tbSeccional.Size = New System.Drawing.Size(156, 24)
        Me.tbSeccional.TabIndex = 7
        '
        'tbNComprobante
        '
        Me.tbNComprobante.Location = New System.Drawing.Point(603, 171)
        Me.tbNComprobante.Name = "tbNComprobante"
        Me.tbNComprobante.Size = New System.Drawing.Size(97, 22)
        Me.tbNComprobante.TabIndex = 11
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
        'tbTComprobante
        '
        Me.tbTComprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbTComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbTComprobante.FormattingEnabled = True
        Me.tbTComprobante.Location = New System.Drawing.Point(537, 126)
        Me.tbTComprobante.Name = "tbTComprobante"
        Me.tbTComprobante.Size = New System.Drawing.Size(163, 24)
        Me.tbTComprobante.TabIndex = 9
        '
        'tbPVenta
        '
        Me.tbPVenta.Location = New System.Drawing.Point(537, 171)
        Me.tbPVenta.Name = "tbPVenta"
        Me.tbPVenta.Size = New System.Drawing.Size(56, 22)
        Me.tbPVenta.TabIndex = 10
        '
        'lbSmonto
        '
        Me.lbSmonto.AutoSize = True
        Me.lbSmonto.Location = New System.Drawing.Point(516, 218)
        Me.lbSmonto.Name = "lbSmonto"
        Me.lbSmonto.Size = New System.Drawing.Size(15, 16)
        Me.lbSmonto.TabIndex = 86
        Me.lbSmonto.Text = "$"
        '
        'lbTComprobante
        '
        Me.lbTComprobante.AutoSize = True
        Me.lbTComprobante.Location = New System.Drawing.Point(391, 129)
        Me.lbTComprobante.Name = "lbTComprobante"
        Me.lbTComprobante.Size = New System.Drawing.Size(140, 16)
        Me.lbTComprobante.TabIndex = 85
        Me.lbTComprobante.Text = "Tipo de Comprobante"
        '
        'tbMonto
        '
        Me.tbMonto.Location = New System.Drawing.Point(537, 215)
        Me.tbMonto.Name = "tbMonto"
        Me.tbMonto.Size = New System.Drawing.Size(163, 22)
        Me.tbMonto.TabIndex = 12
        Me.tbMonto.Tag = ""
        '
        'tbTGasto
        '
        Me.tbTGasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbTGasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbTGasto.FormattingEnabled = True
        Me.tbTGasto.Location = New System.Drawing.Point(151, 126)
        Me.tbTGasto.Name = "tbTGasto"
        Me.tbTGasto.Size = New System.Drawing.Size(156, 24)
        Me.tbTGasto.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Green
        Me.btnGuardar.Location = New System.Drawing.Point(551, 320)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(126, 61)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lbGasto
        '
        Me.lbGasto.AutoSize = True
        Me.lbGasto.Location = New System.Drawing.Point(28, 129)
        Me.lbGasto.Name = "lbGasto"
        Me.lbGasto.Size = New System.Drawing.Size(63, 16)
        Me.lbGasto.TabIndex = 84
        Me.lbGasto.Text = "Gasto de"
        '
        'tbNombre
        '
        Me.tbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbNombre.BackColor = System.Drawing.SystemColors.Window
        Me.tbNombre.Location = New System.Drawing.Point(151, 82)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(197, 22)
        Me.tbNombre.TabIndex = 1
        '
        'lbMes
        '
        Me.lbMes.AutoSize = True
        Me.lbMes.Location = New System.Drawing.Point(28, 218)
        Me.lbMes.Name = "lbMes"
        Me.lbMes.Size = New System.Drawing.Size(115, 16)
        Me.lbMes.TabIndex = 83
        Me.lbMes.Text = "Mes de Reintegro"
        '
        'lbComentario
        '
        Me.lbComentario.AutoSize = True
        Me.lbComentario.Location = New System.Drawing.Point(28, 311)
        Me.lbComentario.Name = "lbComentario"
        Me.lbComentario.Size = New System.Drawing.Size(77, 16)
        Me.lbComentario.TabIndex = 82
        Me.lbComentario.Text = "Comentario"
        '
        'lbMonto
        '
        Me.lbMonto.AutoSize = True
        Me.lbMonto.Location = New System.Drawing.Point(391, 218)
        Me.lbMonto.Name = "lbMonto"
        Me.lbMonto.Size = New System.Drawing.Size(45, 16)
        Me.lbMonto.TabIndex = 80
        Me.lbMonto.Text = "Monto"
        '
        'lbProveedor
        '
        Me.lbProveedor.AutoSize = True
        Me.lbProveedor.Location = New System.Drawing.Point(28, 174)
        Me.lbProveedor.Name = "lbProveedor"
        Me.lbProveedor.Size = New System.Drawing.Size(72, 16)
        Me.lbProveedor.TabIndex = 79
        Me.lbProveedor.Text = "Proveedor"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(28, 85)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(120, 16)
        Me.lbNombre.TabIndex = 78
        Me.lbNombre.Text = "Nombre y Apellido"
        '
        'lbNComprobante
        '
        Me.lbNComprobante.AutoSize = True
        Me.lbNComprobante.Location = New System.Drawing.Point(391, 174)
        Me.lbNComprobante.Name = "lbNComprobante"
        Me.lbNComprobante.Size = New System.Drawing.Size(107, 16)
        Me.lbNComprobante.TabIndex = 77
        Me.lbNComprobante.Text = "N° Comprobante"
        '
        'tbComentario
        '
        Me.tbComentario.Location = New System.Drawing.Point(111, 308)
        Me.tbComentario.Multiline = True
        Me.tbComentario.Name = "tbComentario"
        Me.tbComentario.Size = New System.Drawing.Size(387, 100)
        Me.tbComentario.TabIndex = 13
        '
        'tbProveedor
        '
        Me.tbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbProveedor.Location = New System.Drawing.Point(151, 171)
        Me.tbProveedor.Name = "tbProveedor"
        Me.tbProveedor.Size = New System.Drawing.Size(156, 22)
        Me.tbProveedor.TabIndex = 5
        '
        'TabPageModificar
        '
        Me.TabPageModificar.Controls.Add(Me.SplitContainerModificar)
        Me.TabPageModificar.Location = New System.Drawing.Point(4, 25)
        Me.TabPageModificar.Name = "TabPageModificar"
        Me.TabPageModificar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageModificar.Size = New System.Drawing.Size(747, 427)
        Me.TabPageModificar.TabIndex = 1
        Me.TabPageModificar.Text = "Modificar"
        Me.TabPageModificar.UseVisualStyleBackColor = True
        '
        'SplitContainerModificar
        '
        Me.SplitContainerModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerModificar.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerModificar.Name = "SplitContainerModificar"
        Me.SplitContainerModificar.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerModificar.Panel1
        '
        Me.SplitContainerModificar.Panel1.Controls.Add(Me.ToolStripContainerModificar)
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
        Me.SplitContainerModificar.Size = New System.Drawing.Size(741, 421)
        Me.SplitContainerModificar.SplitterDistance = 201
        Me.SplitContainerModificar.TabIndex = 0
        '
        'ToolStripContainerModificar
        '
        '
        'ToolStripContainerModificar.ContentPanel
        '
        Me.ToolStripContainerModificar.ContentPanel.Controls.Add(Me.DGVModificar)
        Me.ToolStripContainerModificar.ContentPanel.Size = New System.Drawing.Size(741, 176)
        Me.ToolStripContainerModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainerModificar.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainerModificar.Name = "ToolStripContainerModificar"
        Me.ToolStripContainerModificar.Size = New System.Drawing.Size(741, 201)
        Me.ToolStripContainerModificar.TabIndex = 0
        Me.ToolStripContainerModificar.Text = "ToolStripContainer1"
        '
        'DGVModificar
        '
        Me.DGVModificar.AllowUserToAddRows = False
        Me.DGVModificar.AllowUserToDeleteRows = False
        Me.DGVModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVModificar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nro_comprobante, Me.tipo_comprobante_id, Me.tipo_comprobante_nombre, Me.proveedor_id, Me.proveedor_nombre, Me.categoria_gasto_id, Me.categoria_nombre, Me.persona_id, Me.persona_nombre, Me.fecha, Me.seccional_id, Me.seccional_nombre, Me.mes_reintegro, Me.monto, Me.comentario})
        Me.DGVModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVModificar.Location = New System.Drawing.Point(0, 0)
        Me.DGVModificar.Name = "DGVModificar"
        Me.DGVModificar.ReadOnly = True
        Me.DGVModificar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVModificar.Size = New System.Drawing.Size(741, 176)
        Me.DGVModificar.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
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
        Me.ButtonEliminar.Location = New System.Drawing.Point(529, 182)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(163, 31)
        Me.ButtonEliminar.TabIndex = 103
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'LabelSeccional
        '
        Me.LabelSeccional.AutoSize = True
        Me.LabelSeccional.Location = New System.Drawing.Point(22, 130)
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
        Me.ComboBoxSeccional.Location = New System.Drawing.Point(145, 127)
        Me.ComboBoxSeccional.Name = "ComboBoxSeccional"
        Me.ComboBoxSeccional.Size = New System.Drawing.Size(197, 24)
        Me.ComboBoxSeccional.TabIndex = 95
        '
        'DateTimePickerMesReintegro
        '
        Me.DateTimePickerMesReintegro.Checked = False
        Me.DateTimePickerMesReintegro.CustomFormat = "MM/yyyy"
        Me.DateTimePickerMesReintegro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerMesReintegro.Location = New System.Drawing.Point(145, 99)
        Me.DateTimePickerMesReintegro.Name = "DateTimePickerMesReintegro"
        Me.DateTimePickerMesReintegro.ShowCheckBox = True
        Me.DateTimePickerMesReintegro.ShowUpDown = True
        Me.DateTimePickerMesReintegro.Size = New System.Drawing.Size(197, 22)
        Me.DateTimePickerMesReintegro.TabIndex = 94
        Me.DateTimePickerMesReintegro.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Fecha:"
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.CustomFormat = ""
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(529, 13)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(163, 22)
        Me.DateTimePickerFecha.TabIndex = 96
        Me.DateTimePickerFecha.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
        '
        'TextBoxNroComprobante
        '
        Me.TextBoxNroComprobante.Location = New System.Drawing.Point(595, 71)
        Me.TextBoxNroComprobante.Name = "TextBoxNroComprobante"
        Me.TextBoxNroComprobante.Size = New System.Drawing.Size(97, 22)
        Me.TextBoxNroComprobante.TabIndex = 99
        '
        'ComboBoxTipoComprobante
        '
        Me.ComboBoxTipoComprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxTipoComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxTipoComprobante.FormattingEnabled = True
        Me.ComboBoxTipoComprobante.Location = New System.Drawing.Point(529, 41)
        Me.ComboBoxTipoComprobante.Name = "ComboBoxTipoComprobante"
        Me.ComboBoxTipoComprobante.Size = New System.Drawing.Size(163, 24)
        Me.ComboBoxTipoComprobante.TabIndex = 97
        '
        'TextBoxPVenta
        '
        Me.TextBoxPVenta.Location = New System.Drawing.Point(529, 71)
        Me.TextBoxPVenta.Name = "TextBoxPVenta"
        Me.TextBoxPVenta.Size = New System.Drawing.Size(56, 22)
        Me.TextBoxPVenta.TabIndex = 98
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(508, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 16)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(383, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 16)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Tipo de Comprobante"
        '
        'TextBoxMonto
        '
        Me.TextBoxMonto.Location = New System.Drawing.Point(529, 99)
        Me.TextBoxMonto.Name = "TextBoxMonto"
        Me.TextBoxMonto.Size = New System.Drawing.Size(163, 22)
        Me.TextBoxMonto.TabIndex = 100
        Me.TextBoxMonto.Tag = ""
        '
        'ComboBoxCategGasto
        '
        Me.ComboBoxCategGasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxCategGasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxCategGasto.FormattingEnabled = True
        Me.ComboBoxCategGasto.Location = New System.Drawing.Point(145, 41)
        Me.ComboBoxCategGasto.Name = "ComboBoxCategGasto"
        Me.ComboBoxCategGasto.Size = New System.Drawing.Size(197, 24)
        Me.ComboBoxCategGasto.TabIndex = 92
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.Green
        Me.ButtonGuardar.Location = New System.Drawing.Point(529, 145)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(163, 31)
        Me.ButtonGuardar.TabIndex = 102
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 44)
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
        Me.TextBoxNombre.Location = New System.Drawing.Point(145, 13)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(197, 22)
        Me.TextBoxNombre.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 16)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Mes de Reintegro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Comentario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(383, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Monto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Proveedor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Nombre y Apellido"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(383, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 16)
        Me.Label12.TabIndex = 106
        Me.Label12.Text = "N° Comprobante"
        '
        'TextBoxComentario
        '
        Me.TextBoxComentario.Location = New System.Drawing.Point(145, 157)
        Me.TextBoxComentario.Multiline = True
        Me.TextBoxComentario.Name = "TextBoxComentario"
        Me.TextBoxComentario.Size = New System.Drawing.Size(378, 56)
        Me.TextBoxComentario.TabIndex = 101
        '
        'TextBoxProveedor
        '
        Me.TextBoxProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBoxProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxProveedor.Location = New System.Drawing.Point(145, 71)
        Me.TextBoxProveedor.Name = "TextBoxProveedor"
        Me.TextBoxProveedor.Size = New System.Drawing.Size(197, 22)
        Me.TextBoxProveedor.TabIndex = 93
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
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.tbPapeleraTipoComprobante)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.tbPapeleraSeccional)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.tbPapeleraTipoGasto)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.bPapeleraRestaurar)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.dtpPapeleraReintegro)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.dtpPapeleraFecha)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.tbPapeleraNComprobante)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.tbPapeleraPVenta)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.tbPapeleraMonto)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.tbPapeleraNombre)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.Label16)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.Label17)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.Label18)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.Label19)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.Label20)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.Label21)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.tbPapeleraComentario)
        Me.SplitContainerPapelera.Panel2.Controls.Add(Me.tbPapeleraProveedor)
        Me.SplitContainerPapelera.Size = New System.Drawing.Size(741, 421)
        Me.SplitContainerPapelera.SplitterDistance = 201
        Me.SplitContainerPapelera.TabIndex = 1
        '
        'ToolStripContainerPapelera
        '
        '
        'ToolStripContainerPapelera.ContentPanel
        '
        Me.ToolStripContainerPapelera.ContentPanel.Controls.Add(Me.DGVPapelera)
        Me.ToolStripContainerPapelera.ContentPanel.Size = New System.Drawing.Size(741, 176)
        Me.ToolStripContainerPapelera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainerPapelera.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainerPapelera.Name = "ToolStripContainerPapelera"
        Me.ToolStripContainerPapelera.Size = New System.Drawing.Size(741, 201)
        Me.ToolStripContainerPapelera.TabIndex = 0
        Me.ToolStripContainerPapelera.Text = "ToolStripContainer1"
        '
        'DGVPapelera
        '
        Me.DGVPapelera.AllowUserToAddRows = False
        Me.DGVPapelera.AllowUserToDeleteRows = False
        Me.DGVPapelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPapelera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PapeleraId, Me.PapeleraNroComprobante, Me.PapeleraTComprobanteId, Me.PapeleraTipoComprobante, Me.PapeleraProveedorId, Me.PapeleraProveedor, Me.PapeleraCategoriaGastoId, Me.PapeleraCategoriaGasto, Me.PapeleraPersonaId, Me.PapeleraPersona, Me.PapeleraFecha, Me.PapeleraSeccionalId, Me.PapeleraSeccional, Me.PapeleraReintegro, Me.PapeleraMonto, Me.PapeleraComentario})
        Me.DGVPapelera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVPapelera.Location = New System.Drawing.Point(0, 0)
        Me.DGVPapelera.Name = "DGVPapelera"
        Me.DGVPapelera.ReadOnly = True
        Me.DGVPapelera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPapelera.Size = New System.Drawing.Size(741, 176)
        Me.DGVPapelera.TabIndex = 0
        '
        'bPapeleraRestaurar
        '
        Me.bPapeleraRestaurar.Enabled = False
        Me.bPapeleraRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPapeleraRestaurar.ForeColor = System.Drawing.Color.Red
        Me.bPapeleraRestaurar.Location = New System.Drawing.Point(529, 157)
        Me.bPapeleraRestaurar.Name = "bPapeleraRestaurar"
        Me.bPapeleraRestaurar.Size = New System.Drawing.Size(163, 56)
        Me.bPapeleraRestaurar.TabIndex = 103
        Me.bPapeleraRestaurar.Text = "Restaurar"
        Me.bPapeleraRestaurar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Seccional"
        '
        'dtpPapeleraReintegro
        '
        Me.dtpPapeleraReintegro.Checked = False
        Me.dtpPapeleraReintegro.CustomFormat = "MM/yyyy"
        Me.dtpPapeleraReintegro.Enabled = False
        Me.dtpPapeleraReintegro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPapeleraReintegro.Location = New System.Drawing.Point(145, 99)
        Me.dtpPapeleraReintegro.Name = "dtpPapeleraReintegro"
        Me.dtpPapeleraReintegro.ShowCheckBox = True
        Me.dtpPapeleraReintegro.ShowUpDown = True
        Me.dtpPapeleraReintegro.Size = New System.Drawing.Size(197, 22)
        Me.dtpPapeleraReintegro.TabIndex = 94
        Me.dtpPapeleraReintegro.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Fecha:"
        '
        'dtpPapeleraFecha
        '
        Me.dtpPapeleraFecha.CustomFormat = ""
        Me.dtpPapeleraFecha.Enabled = False
        Me.dtpPapeleraFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPapeleraFecha.Location = New System.Drawing.Point(529, 13)
        Me.dtpPapeleraFecha.Name = "dtpPapeleraFecha"
        Me.dtpPapeleraFecha.Size = New System.Drawing.Size(163, 22)
        Me.dtpPapeleraFecha.TabIndex = 96
        Me.dtpPapeleraFecha.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
        '
        'tbPapeleraNComprobante
        '
        Me.tbPapeleraNComprobante.Enabled = False
        Me.tbPapeleraNComprobante.Location = New System.Drawing.Point(595, 71)
        Me.tbPapeleraNComprobante.Name = "tbPapeleraNComprobante"
        Me.tbPapeleraNComprobante.Size = New System.Drawing.Size(97, 22)
        Me.tbPapeleraNComprobante.TabIndex = 99
        '
        'tbPapeleraPVenta
        '
        Me.tbPapeleraPVenta.Enabled = False
        Me.tbPapeleraPVenta.Location = New System.Drawing.Point(529, 71)
        Me.tbPapeleraPVenta.Name = "tbPapeleraPVenta"
        Me.tbPapeleraPVenta.Size = New System.Drawing.Size(56, 22)
        Me.tbPapeleraPVenta.TabIndex = 98
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(508, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 16)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "$"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(383, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 16)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Tipo de Comprobante"
        '
        'tbPapeleraMonto
        '
        Me.tbPapeleraMonto.Enabled = False
        Me.tbPapeleraMonto.Location = New System.Drawing.Point(529, 99)
        Me.tbPapeleraMonto.Name = "tbPapeleraMonto"
        Me.tbPapeleraMonto.Size = New System.Drawing.Size(163, 22)
        Me.tbPapeleraMonto.TabIndex = 100
        Me.tbPapeleraMonto.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 16)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "Gasto de"
        '
        'tbPapeleraNombre
        '
        Me.tbPapeleraNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbPapeleraNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbPapeleraNombre.BackColor = System.Drawing.SystemColors.Window
        Me.tbPapeleraNombre.Enabled = False
        Me.tbPapeleraNombre.Location = New System.Drawing.Point(145, 13)
        Me.tbPapeleraNombre.Name = "tbPapeleraNombre"
        Me.tbPapeleraNombre.Size = New System.Drawing.Size(197, 22)
        Me.tbPapeleraNombre.TabIndex = 91
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 16)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Mes de Reintegro"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 161)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 16)
        Me.Label17.TabIndex = 110
        Me.Label17.Text = "Comentario"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(383, 102)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 16)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Monto"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 108
        Me.Label19.Text = "Proveedor"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(22, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 16)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "Nombre y Apellido"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(383, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(107, 16)
        Me.Label21.TabIndex = 106
        Me.Label21.Text = "N° Comprobante"
        '
        'tbPapeleraComentario
        '
        Me.tbPapeleraComentario.Enabled = False
        Me.tbPapeleraComentario.Location = New System.Drawing.Point(145, 157)
        Me.tbPapeleraComentario.Multiline = True
        Me.tbPapeleraComentario.Name = "tbPapeleraComentario"
        Me.tbPapeleraComentario.Size = New System.Drawing.Size(378, 56)
        Me.tbPapeleraComentario.TabIndex = 101
        '
        'tbPapeleraProveedor
        '
        Me.tbPapeleraProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbPapeleraProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbPapeleraProveedor.Enabled = False
        Me.tbPapeleraProveedor.Location = New System.Drawing.Point(145, 71)
        Me.tbPapeleraProveedor.Name = "tbPapeleraProveedor"
        Me.tbPapeleraProveedor.Size = New System.Drawing.Size(197, 22)
        Me.tbPapeleraProveedor.TabIndex = 93
        '
        'tbPapeleraTipoGasto
        '
        Me.tbPapeleraTipoGasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbPapeleraTipoGasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbPapeleraTipoGasto.BackColor = System.Drawing.SystemColors.Window
        Me.tbPapeleraTipoGasto.Enabled = False
        Me.tbPapeleraTipoGasto.Location = New System.Drawing.Point(145, 41)
        Me.tbPapeleraTipoGasto.Name = "tbPapeleraTipoGasto"
        Me.tbPapeleraTipoGasto.Size = New System.Drawing.Size(197, 22)
        Me.tbPapeleraTipoGasto.TabIndex = 120
        '
        'tbPapeleraSeccional
        '
        Me.tbPapeleraSeccional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbPapeleraSeccional.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbPapeleraSeccional.BackColor = System.Drawing.SystemColors.Window
        Me.tbPapeleraSeccional.Enabled = False
        Me.tbPapeleraSeccional.Location = New System.Drawing.Point(145, 127)
        Me.tbPapeleraSeccional.Name = "tbPapeleraSeccional"
        Me.tbPapeleraSeccional.Size = New System.Drawing.Size(197, 22)
        Me.tbPapeleraSeccional.TabIndex = 121
        '
        'tbPapeleraTipoComprobante
        '
        Me.tbPapeleraTipoComprobante.Enabled = False
        Me.tbPapeleraTipoComprobante.Location = New System.Drawing.Point(529, 41)
        Me.tbPapeleraTipoComprobante.Name = "tbPapeleraTipoComprobante"
        Me.tbPapeleraTipoComprobante.Size = New System.Drawing.Size(163, 22)
        Me.tbPapeleraTipoComprobante.TabIndex = 122
        Me.tbPapeleraTipoComprobante.Tag = ""
        '
        'PapeleraId
        '
        Me.PapeleraId.HeaderText = "Id"
        Me.PapeleraId.Name = "PapeleraId"
        Me.PapeleraId.ReadOnly = True
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
        Me.TabPageModificar.ResumeLayout(False)
        Me.SplitContainerModificar.Panel1.ResumeLayout(False)
        Me.SplitContainerModificar.Panel2.ResumeLayout(False)
        Me.SplitContainerModificar.Panel2.PerformLayout()
        CType(Me.SplitContainerModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerModificar.ResumeLayout(False)
        Me.ToolStripContainerModificar.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainerModificar.ResumeLayout(False)
        Me.ToolStripContainerModificar.PerformLayout()
        CType(Me.DGVModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePapelera.ResumeLayout(False)
        Me.SplitContainerPapelera.Panel1.ResumeLayout(False)
        Me.SplitContainerPapelera.Panel2.ResumeLayout(False)
        Me.SplitContainerPapelera.Panel2.PerformLayout()
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
    Friend WithEvents tbNComprobante As TextBox
    Friend WithEvents lb_Titulo As Label
    Friend WithEvents tbTComprobante As ComboBox
    Friend WithEvents tbPVenta As TextBox
    Friend WithEvents lbSmonto As Label
    Friend WithEvents lbTComprobante As Label
    Friend WithEvents tbMonto As TextBox
    Friend WithEvents tbTGasto As ComboBox
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
    Friend WithEvents TabPageModificar As TabPage
    Friend WithEvents SplitContainerModificar As SplitContainer
    Friend WithEvents ToolStripContainerModificar As ToolStripContainer
    Friend WithEvents DGVModificar As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
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
    Friend WithEvents DateTimePickerFecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelSeccional As Label
    Friend WithEvents ComboBoxSeccional As ComboBox
    Friend WithEvents DateTimePickerMesReintegro As DateTimePicker
    Friend WithEvents lbSeccional As Label
    Friend WithEvents tbSeccional As ComboBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents dtpReintegro As DateTimePicker
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents TabPagePapelera As TabPage
    Friend WithEvents SplitContainerPapelera As SplitContainer
    Friend WithEvents ToolStripContainerPapelera As ToolStripContainer
    Friend WithEvents DGVPapelera As DataGridView
    Friend WithEvents bPapeleraRestaurar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpPapeleraReintegro As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpPapeleraFecha As DateTimePicker
    Friend WithEvents tbPapeleraNComprobante As TextBox
    Friend WithEvents tbPapeleraPVenta As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbPapeleraMonto As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbPapeleraNombre As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents tbPapeleraComentario As TextBox
    Friend WithEvents tbPapeleraProveedor As TextBox
    Friend WithEvents tbPapeleraTipoComprobante As TextBox
    Friend WithEvents tbPapeleraSeccional As TextBox
    Friend WithEvents tbPapeleraTipoGasto As TextBox
    Friend WithEvents PapeleraId As DataGridViewTextBoxColumn
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
End Class
