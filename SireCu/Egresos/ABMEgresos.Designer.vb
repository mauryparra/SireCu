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
        Me.TabPageModificar = New System.Windows.Forms.TabPage()
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
        Me.tbGasto = New System.Windows.Forms.ComboBox()
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
        Me.SplitContainerModificar = New System.Windows.Forms.SplitContainer()
        Me.TabControl.SuspendLayout()
        Me.TabPageAgregar.SuspendLayout()
        Me.TabPageModificar.SuspendLayout()
        CType(Me.SplitContainerModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerModificar.SuspendLayout()
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
        Me.TabPageAgregar.Controls.Add(Me.tbGasto)
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
        'tbNComprobante
        '
        Me.tbNComprobante.Location = New System.Drawing.Point(603, 171)
        Me.tbNComprobante.Name = "tbNComprobante"
        Me.tbNComprobante.Size = New System.Drawing.Size(97, 22)
        Me.tbNComprobante.TabIndex = 71
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
        Me.tbTComprobante.AutoCompleteCustomSource.AddRange(New String() {"Factura A", "Factura B", "Factura C", "Recibo A", "Recibo B", "Recibo C", "Recibo X", "Tique Fact. A", "Tique Fact. B", "Tique Fact. C", "Tique", "Pasaje", "Extracto Bancario", "Otro"})
        Me.tbTComprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbTComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbTComprobante.FormattingEnabled = True
        Me.tbTComprobante.Items.AddRange(New Object() {"Factura A", "Factura B", "Factura C", "Recibo A", "Recibo B", "Recibo C", "Recibo X", "Tique Fact. A", "Tique Fact. B", "Tique Fact. C", "Tique", "Pasaje", "Extracto Bancario", "Otro"})
        Me.tbTComprobante.Location = New System.Drawing.Point(537, 126)
        Me.tbTComprobante.Name = "tbTComprobante"
        Me.tbTComprobante.Size = New System.Drawing.Size(163, 24)
        Me.tbTComprobante.TabIndex = 69
        '
        'bttnConsultar
        '
        Me.bttnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnConsultar.Location = New System.Drawing.Point(603, 308)
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
        Me.tbPVenta.TabIndex = 70
        '
        'tbReintegro
        '
        Me.tbReintegro.Location = New System.Drawing.Point(151, 215)
        Me.tbReintegro.MaxLength = 2
        Me.tbReintegro.Name = "tbReintegro"
        Me.tbReintegro.Size = New System.Drawing.Size(156, 22)
        Me.tbReintegro.TabIndex = 68
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
        Me.tbYear.TabIndex = 81
        Me.tbYear.TabStop = False
        '
        'tbMonth
        '
        Me.tbMonth.Location = New System.Drawing.Point(580, 82)
        Me.tbMonth.MaxLength = 2
        Me.tbMonth.Name = "tbMonth"
        Me.tbMonth.Size = New System.Drawing.Size(34, 22)
        Me.tbMonth.TabIndex = 65
        '
        'tbDay
        '
        Me.tbDay.Location = New System.Drawing.Point(537, 82)
        Me.tbDay.MaxLength = 2
        Me.tbDay.Name = "tbDay"
        Me.tbDay.Size = New System.Drawing.Size(33, 22)
        Me.tbDay.TabIndex = 64
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
        Me.tbMonto.TabIndex = 72
        Me.tbMonto.Tag = ""
        '
        'tbGasto
        '
        Me.tbGasto.AutoCompleteCustomSource.AddRange(New String() {"Administrativos", "Alquileres", "Bancarios", "Coparticipación", "Desenvolvimiento", "Filiales", "Franqueo y Encomiendas", "Honorarios", "Impuestos y servicios", "Librería e impresiones", "Seguros", "Movilidad y traslado", "Prensa y difusión", "Prestaciones", "Subsidios"})
        Me.tbGasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbGasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbGasto.FormattingEnabled = True
        Me.tbGasto.Items.AddRange(New Object() {"Administrativos", "Alquileres", "Aplicables a Coparticipación", "Bancarios", "Coparticipación", "Desenvolvimiento", "Filiales", "Franqueo y Encomiendas", "Honorarios", "Impuestos y servicios", "Librería e impresiones", "Seguros", "Movilidad y traslado", "Prensa y difusión", "Prestaciones", "Subsidios"})
        Me.tbGasto.Location = New System.Drawing.Point(151, 126)
        Me.tbGasto.Name = "tbGasto"
        Me.tbGasto.Size = New System.Drawing.Size(156, 24)
        Me.tbGasto.TabIndex = 66
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Green
        Me.btnGuardar.Location = New System.Drawing.Point(467, 308)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(126, 61)
        Me.btnGuardar.TabIndex = 76
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
        Me.ckCentral.TabIndex = 74
        Me.ckCentral.Text = "UDA Central"
        Me.ckCentral.UseVisualStyleBackColor = True
        '
        'ckLarioja
        '
        Me.ckLarioja.AutoSize = True
        Me.ckLarioja.BackColor = System.Drawing.SystemColors.Control
        Me.ckLarioja.Location = New System.Drawing.Point(110, 282)
        Me.ckLarioja.Name = "ckLarioja"
        Me.ckLarioja.Size = New System.Drawing.Size(109, 20)
        Me.ckLarioja.TabIndex = 73
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
        Me.tbNombre.TabIndex = 63
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
        Me.tbComentario.TabIndex = 75
        '
        'tbProveedor
        '
        Me.tbProveedor.Location = New System.Drawing.Point(151, 171)
        Me.tbProveedor.Name = "tbProveedor"
        Me.tbProveedor.Size = New System.Drawing.Size(156, 22)
        Me.tbProveedor.TabIndex = 67
        '
        'SplitContainerModificar
        '
        Me.SplitContainerModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerModificar.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerModificar.Name = "SplitContainerModificar"
        Me.SplitContainerModificar.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainerModificar.Size = New System.Drawing.Size(741, 421)
        Me.SplitContainerModificar.SplitterDistance = 201
        Me.SplitContainerModificar.TabIndex = 0
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
        CType(Me.SplitContainerModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerModificar.ResumeLayout(False)
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
    Friend WithEvents tbGasto As ComboBox
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
End Class
