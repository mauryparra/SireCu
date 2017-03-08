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
        Me.tbNComprobante = New System.Windows.Forms.TextBox()
        Me.lb_Titulo = New System.Windows.Forms.Label()
        Me.tbTComprobante = New System.Windows.Forms.ComboBox()
        Me.bttnConsultar = New System.Windows.Forms.Button()
        Me.tbPVenta = New System.Windows.Forms.TextBox()
        Me.tbReintegro = New System.Windows.Forms.TextBox()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.lbMonth = New System.Windows.Forms.Label()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.tbYear = New System.Windows.Forms.TextBox()
        Me.tbMonth = New System.Windows.Forms.TextBox()
        Me.tbDay = New System.Windows.Forms.TextBox()
        Me.lbSmonto = New System.Windows.Forms.Label()
        Me.lbTComprobante = New System.Windows.Forms.Label()
        Me.tbMonto = New System.Windows.Forms.TextBox()
        Me.tbTGasto = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lbGasto = New System.Windows.Forms.Label()
        Me.ckCentral = New System.Windows.Forms.CheckBox()
        Me.ckLarioja = New System.Windows.Forms.CheckBox()
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
        Me.DataGridViewModificar = New System.Windows.Forms.DataGridView()
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
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerMesReintegro = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxSeccional = New System.Windows.Forms.ComboBox()
        Me.LabelSeccional = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.TabPageAgregar.SuspendLayout()
        Me.TabPageModificar.SuspendLayout()
        CType(Me.SplitContainerModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerModificar.Panel1.SuspendLayout()
        Me.SplitContainerModificar.Panel2.SuspendLayout()
        Me.SplitContainerModificar.SuspendLayout()
        Me.ToolStripContainerModificar.ContentPanel.SuspendLayout()
        Me.ToolStripContainerModificar.SuspendLayout()
        CType(Me.DataGridViewModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageAgregar)
        Me.TabControl.Controls.Add(Me.TabPageModificar)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(755, 456)
        Me.TabControl.TabIndex = 0
        '
        'TabPageAgregar
        '
        Me.TabPageAgregar.Controls.Add(Me.tbNComprobante)
        Me.TabPageAgregar.Controls.Add(Me.lb_Titulo)
        Me.TabPageAgregar.Controls.Add(Me.tbTComprobante)
        Me.TabPageAgregar.Controls.Add(Me.bttnConsultar)
        Me.TabPageAgregar.Controls.Add(Me.tbPVenta)
        Me.TabPageAgregar.Controls.Add(Me.tbReintegro)
        Me.TabPageAgregar.Controls.Add(Me.lbYear)
        Me.TabPageAgregar.Controls.Add(Me.lbMonth)
        Me.TabPageAgregar.Controls.Add(Me.lbDay)
        Me.TabPageAgregar.Controls.Add(Me.tbYear)
        Me.TabPageAgregar.Controls.Add(Me.tbMonth)
        Me.TabPageAgregar.Controls.Add(Me.tbDay)
        Me.TabPageAgregar.Controls.Add(Me.lbSmonto)
        Me.TabPageAgregar.Controls.Add(Me.lbTComprobante)
        Me.TabPageAgregar.Controls.Add(Me.tbMonto)
        Me.TabPageAgregar.Controls.Add(Me.tbTGasto)
        Me.TabPageAgregar.Controls.Add(Me.btnGuardar)
        Me.TabPageAgregar.Controls.Add(Me.lbGasto)
        Me.TabPageAgregar.Controls.Add(Me.ckCentral)
        Me.TabPageAgregar.Controls.Add(Me.ckLarioja)
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
        'tbNComprobante
        '
        Me.tbNComprobante.Location = New System.Drawing.Point(603, 171)
        Me.tbNComprobante.Name = "tbNComprobante"
        Me.tbNComprobante.Size = New System.Drawing.Size(97, 22)
        Me.tbNComprobante.TabIndex = 9
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
        Me.tbTComprobante.Items.AddRange(New Object() {"Factura A", "Factura B", "Factura C", "Recibo A", "Recibo B", "Recibo C", "Recibo X", "Tique Fact. A", "Tique Fact. B", "Tique Fact. C", "Tique", "Pasaje", "Extracto Bancario", "Otro"})
        Me.tbTComprobante.Location = New System.Drawing.Point(537, 126)
        Me.tbTComprobante.Name = "tbTComprobante"
        Me.tbTComprobante.Size = New System.Drawing.Size(163, 24)
        Me.tbTComprobante.TabIndex = 7
        '
        'bttnConsultar
        '
        Me.bttnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnConsultar.Location = New System.Drawing.Point(603, 324)
        Me.bttnConsultar.Name = "bttnConsultar"
        Me.bttnConsultar.Size = New System.Drawing.Size(126, 61)
        Me.bttnConsultar.TabIndex = 90
        Me.bttnConsultar.TabStop = False
        Me.bttnConsultar.Text = "Consultar"
        Me.bttnConsultar.UseVisualStyleBackColor = True
        '
        'tbPVenta
        '
        Me.tbPVenta.Location = New System.Drawing.Point(537, 171)
        Me.tbPVenta.Name = "tbPVenta"
        Me.tbPVenta.Size = New System.Drawing.Size(56, 22)
        Me.tbPVenta.TabIndex = 8
        '
        'tbReintegro
        '
        Me.tbReintegro.AutoCompleteCustomSource.AddRange(New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.tbReintegro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbReintegro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbReintegro.Location = New System.Drawing.Point(151, 215)
        Me.tbReintegro.MaxLength = 2
        Me.tbReintegro.Name = "tbReintegro"
        Me.tbReintegro.Size = New System.Drawing.Size(156, 22)
        Me.tbReintegro.TabIndex = 10
        '
        'lbYear
        '
        Me.lbYear.AutoSize = True
        Me.lbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbYear.Location = New System.Drawing.Point(621, 67)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(22, 12)
        Me.lbYear.TabIndex = 89
        Me.lbYear.Text = "Año"
        '
        'lbMonth
        '
        Me.lbMonth.AutoSize = True
        Me.lbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMonth.Location = New System.Drawing.Point(578, 67)
        Me.lbMonth.Name = "lbMonth"
        Me.lbMonth.Size = New System.Drawing.Size(24, 12)
        Me.lbMonth.TabIndex = 88
        Me.lbMonth.Text = "Mes"
        '
        'lbDay
        '
        Me.lbDay.AutoSize = True
        Me.lbDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDay.Location = New System.Drawing.Point(535, 67)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(19, 12)
        Me.lbDay.TabIndex = 87
        Me.lbDay.Text = "Dia"
        '
        'tbYear
        '
        Me.tbYear.Enabled = False
        Me.tbYear.Location = New System.Drawing.Point(623, 82)
        Me.tbYear.MaxLength = 4
        Me.tbYear.Name = "tbYear"
        Me.tbYear.Size = New System.Drawing.Size(54, 22)
        Me.tbYear.TabIndex = 4
        Me.tbYear.TabStop = False
        '
        'tbMonth
        '
        Me.tbMonth.Location = New System.Drawing.Point(580, 82)
        Me.tbMonth.MaxLength = 2
        Me.tbMonth.Name = "tbMonth"
        Me.tbMonth.Size = New System.Drawing.Size(34, 22)
        Me.tbMonth.TabIndex = 3
        '
        'tbDay
        '
        Me.tbDay.Location = New System.Drawing.Point(537, 82)
        Me.tbDay.MaxLength = 2
        Me.tbDay.Name = "tbDay"
        Me.tbDay.Size = New System.Drawing.Size(33, 22)
        Me.tbDay.TabIndex = 2
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
        Me.tbMonto.TabIndex = 11
        Me.tbMonto.Tag = ""
        '
        'tbTGasto
        '
        Me.tbTGasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbTGasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbTGasto.FormattingEnabled = True
        Me.tbTGasto.Items.AddRange(New Object() {"Administrativos", "Alquileres", "Aplicables a Coparticipación", "Bancarios", "Coparticipación", "Desenvolvimiento", "Filiales", "Franqueo y Encomiendas", "Honorarios", "Impuestos y servicios", "Librería e impresiones", "Seguros", "Movilidad y traslado", "Prensa y difusión", "Prestaciones", "Subsidios"})
        Me.tbTGasto.Location = New System.Drawing.Point(151, 126)
        Me.tbTGasto.Name = "tbTGasto"
        Me.tbTGasto.Size = New System.Drawing.Size(156, 24)
        Me.tbTGasto.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Green
        Me.btnGuardar.Location = New System.Drawing.Point(467, 324)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(126, 61)
        Me.btnGuardar.TabIndex = 15
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
        'ckCentral
        '
        Me.ckCentral.AutoSize = True
        Me.ckCentral.Location = New System.Drawing.Point(248, 282)
        Me.ckCentral.Name = "ckCentral"
        Me.ckCentral.Size = New System.Drawing.Size(101, 20)
        Me.ckCentral.TabIndex = 13
        Me.ckCentral.Text = "UDA Central"
        Me.ckCentral.UseVisualStyleBackColor = True
        '
        'ckLarioja
        '
        Me.ckLarioja.AutoSize = True
        Me.ckLarioja.BackColor = System.Drawing.Color.White
        Me.ckLarioja.Location = New System.Drawing.Point(110, 282)
        Me.ckLarioja.Name = "ckLarioja"
        Me.ckLarioja.Size = New System.Drawing.Size(109, 20)
        Me.ckLarioja.TabIndex = 12
        Me.ckLarioja.Text = "UDA La Rioja"
        Me.ckLarioja.UseVisualStyleBackColor = False
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
        Me.tbComentario.Size = New System.Drawing.Size(317, 100)
        Me.tbComentario.TabIndex = 14
        '
        'tbProveedor
        '
        Me.tbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbProveedor.Location = New System.Drawing.Point(151, 171)
        Me.tbProveedor.Name = "tbProveedor"
        Me.tbProveedor.Size = New System.Drawing.Size(156, 22)
        Me.tbProveedor.TabIndex = 6
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
        Me.ToolStripContainerModificar.ContentPanel.Controls.Add(Me.DataGridViewModificar)
        Me.ToolStripContainerModificar.ContentPanel.Size = New System.Drawing.Size(741, 176)
        Me.ToolStripContainerModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainerModificar.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainerModificar.Name = "ToolStripContainerModificar"
        Me.ToolStripContainerModificar.Size = New System.Drawing.Size(741, 201)
        Me.ToolStripContainerModificar.TabIndex = 0
        Me.ToolStripContainerModificar.Text = "ToolStripContainer1"
        '
        'DataGridViewModificar
        '
        Me.DataGridViewModificar.AllowUserToAddRows = False
        Me.DataGridViewModificar.AllowUserToDeleteRows = False
        Me.DataGridViewModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewModificar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nro_comprobante, Me.tipo_comprobante_id, Me.tipo_comprobante_nombre, Me.proveedor_id, Me.proveedor_nombre, Me.categoria_gasto_id, Me.categoria_nombre, Me.persona_id, Me.persona_nombre, Me.fecha, Me.seccional_id, Me.seccional_nombre, Me.mes_reintegro, Me.monto, Me.comentario})
        Me.DataGridViewModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewModificar.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewModificar.Name = "DataGridViewModificar"
        Me.DataGridViewModificar.ReadOnly = True
        Me.DataGridViewModificar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewModificar.Size = New System.Drawing.Size(741, 176)
        Me.DataGridViewModificar.TabIndex = 0
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
        Me.ComboBoxTipoComprobante.Items.AddRange(New Object() {"Factura A", "Factura B", "Factura C", "Recibo A", "Recibo B", "Recibo C", "Recibo X", "Tique Fact. A", "Tique Fact. B", "Tique Fact. C", "Tique", "Pasaje", "Extracto Bancario", "Otro"})
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
        Me.TextBoxMonto.TabIndex = 101
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
        Me.ComboBoxCategGasto.TabIndex = 95
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.Green
        Me.ButtonGuardar.Location = New System.Drawing.Point(529, 157)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(163, 56)
        Me.ButtonGuardar.TabIndex = 105
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
        Me.TextBoxComentario.TabIndex = 104
        '
        'TextBoxProveedor
        '
        Me.TextBoxProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBoxProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxProveedor.Location = New System.Drawing.Point(145, 71)
        Me.TextBoxProveedor.Name = "TextBoxProveedor"
        Me.TextBoxProveedor.Size = New System.Drawing.Size(197, 22)
        Me.TextBoxProveedor.TabIndex = 96
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.CustomFormat = ""
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(529, 13)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(163, 22)
        Me.DateTimePickerFecha.TabIndex = 115
        Me.DateTimePickerFecha.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
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
        'DateTimePickerMesReintegro
        '
        Me.DateTimePickerMesReintegro.CustomFormat = ""
        Me.DateTimePickerMesReintegro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerMesReintegro.Location = New System.Drawing.Point(145, 99)
        Me.DateTimePickerMesReintegro.Name = "DateTimePickerMesReintegro"
        Me.DateTimePickerMesReintegro.Size = New System.Drawing.Size(197, 22)
        Me.DateTimePickerMesReintegro.TabIndex = 117
        Me.DateTimePickerMesReintegro.Value = New Date(2017, 3, 4, 19, 31, 9, 0)
        '
        'ComboBoxSeccional
        '
        Me.ComboBoxSeccional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxSeccional.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxSeccional.FormattingEnabled = True
        Me.ComboBoxSeccional.Location = New System.Drawing.Point(145, 127)
        Me.ComboBoxSeccional.Name = "ComboBoxSeccional"
        Me.ComboBoxSeccional.Size = New System.Drawing.Size(197, 24)
        Me.ComboBoxSeccional.TabIndex = 118
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
        CType(Me.DataGridViewModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageAgregar As TabPage
    Friend WithEvents tbNComprobante As TextBox
    Friend WithEvents lb_Titulo As Label
    Friend WithEvents tbTComprobante As ComboBox
    Friend WithEvents bttnConsultar As Button
    Friend WithEvents tbPVenta As TextBox
    Friend WithEvents tbReintegro As TextBox
    Friend WithEvents lbYear As Label
    Friend WithEvents lbMonth As Label
    Friend WithEvents lbDay As Label
    Friend WithEvents tbYear As TextBox
    Friend WithEvents tbMonth As TextBox
    Friend WithEvents tbDay As TextBox
    Friend WithEvents lbSmonto As Label
    Friend WithEvents lbTComprobante As Label
    Friend WithEvents tbMonto As TextBox
    Friend WithEvents tbTGasto As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lbGasto As Label
    Friend WithEvents ckCentral As CheckBox
    Friend WithEvents ckLarioja As CheckBox
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
    Friend WithEvents DataGridViewModificar As DataGridView
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
End Class
