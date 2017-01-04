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
        Me.lb_Titulo = New System.Windows.Forms.Label()
        Me.tbNComprobante = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbTComprobante
        '
        Me.tbTComprobante.AutoCompleteCustomSource.AddRange(New String() {"Factura A", "Factura B", "Factura C", "Recibo A", "Recibo B", "Recibo C", "Recibo X", "Tique Fact. A", "Tique Fact. B", "Tique Fact. C", "Tique", "Pasaje", "Extracto Bancario", "Otro"})
        Me.tbTComprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbTComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbTComprobante.FormattingEnabled = True
        Me.tbTComprobante.Items.AddRange(New Object() {"Factura A", "Factura B", "Factura C", "Recibo A", "Recibo B", "Recibo C", "Recibo X", "Tique Fact. A", "Tique Fact. B", "Tique Fact. C", "Tique", "Pasaje", "Extracto Bancario", "Otro"})
        Me.tbTComprobante.Location = New System.Drawing.Point(524, 133)
        Me.tbTComprobante.Name = "tbTComprobante"
        Me.tbTComprobante.Size = New System.Drawing.Size(163, 21)
        Me.tbTComprobante.TabIndex = 7
        '
        'bttnConsultar
        '
        Me.bttnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnConsultar.Location = New System.Drawing.Point(561, 378)
        Me.bttnConsultar.Name = "bttnConsultar"
        Me.bttnConsultar.Size = New System.Drawing.Size(126, 59)
        Me.bttnConsultar.TabIndex = 60
        Me.bttnConsultar.TabStop = False
        Me.bttnConsultar.Text = "Consultar"
        Me.bttnConsultar.UseVisualStyleBackColor = True
        '
        'tbPVenta
        '
        Me.tbPVenta.Location = New System.Drawing.Point(524, 180)
        Me.tbPVenta.Name = "tbPVenta"
        Me.tbPVenta.Size = New System.Drawing.Size(59, 20)
        Me.tbPVenta.TabIndex = 8
        '
        'tbReintegro
        '
        Me.tbReintegro.Location = New System.Drawing.Point(155, 228)
        Me.tbReintegro.MaxLength = 2
        Me.tbReintegro.Name = "tbReintegro"
        Me.tbReintegro.Size = New System.Drawing.Size(156, 20)
        Me.tbReintegro.TabIndex = 6
        '
        'lbYear
        '
        Me.lbYear.AutoSize = True
        Me.lbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbYear.Location = New System.Drawing.Point(682, 60)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(22, 12)
        Me.lbYear.TabIndex = 59
        Me.lbYear.Text = "Año"
        '
        'lbMonth
        '
        Me.lbMonth.AutoSize = True
        Me.lbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMonth.Location = New System.Drawing.Point(625, 60)
        Me.lbMonth.Name = "lbMonth"
        Me.lbMonth.Size = New System.Drawing.Size(24, 12)
        Me.lbMonth.TabIndex = 58
        Me.lbMonth.Text = "Mes"
        '
        'lbDay
        '
        Me.lbDay.AutoSize = True
        Me.lbDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDay.Location = New System.Drawing.Point(582, 60)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(19, 12)
        Me.lbDay.TabIndex = 57
        Me.lbDay.Text = "Dia"
        '
        'tbYear
        '
        Me.tbYear.Enabled = False
        Me.tbYear.Location = New System.Drawing.Point(668, 73)
        Me.tbYear.MaxLength = 4
        Me.tbYear.Name = "tbYear"
        Me.tbYear.Size = New System.Drawing.Size(54, 20)
        Me.tbYear.TabIndex = 45
        Me.tbYear.TabStop = False
        '
        'tbMonth
        '
        Me.tbMonth.Location = New System.Drawing.Point(621, 73)
        Me.tbMonth.MaxLength = 2
        Me.tbMonth.Name = "tbMonth"
        Me.tbMonth.Size = New System.Drawing.Size(34, 20)
        Me.tbMonth.TabIndex = 3
        '
        'tbDay
        '
        Me.tbDay.Location = New System.Drawing.Point(577, 73)
        Me.tbDay.MaxLength = 2
        Me.tbDay.Name = "tbDay"
        Me.tbDay.Size = New System.Drawing.Size(33, 20)
        Me.tbDay.TabIndex = 2
        '
        'lbSmonto
        '
        Me.lbSmonto.AutoSize = True
        Me.lbSmonto.Location = New System.Drawing.Point(505, 231)
        Me.lbSmonto.Name = "lbSmonto"
        Me.lbSmonto.Size = New System.Drawing.Size(13, 13)
        Me.lbSmonto.TabIndex = 55
        Me.lbSmonto.Text = "$"
        '
        'lbTComprobante
        '
        Me.lbTComprobante.AutoSize = True
        Me.lbTComprobante.Location = New System.Drawing.Point(403, 136)
        Me.lbTComprobante.Name = "lbTComprobante"
        Me.lbTComprobante.Size = New System.Drawing.Size(109, 13)
        Me.lbTComprobante.TabIndex = 54
        Me.lbTComprobante.Text = "Tipo de Comprobante"
        '
        'tbMonto
        '
        Me.tbMonto.Location = New System.Drawing.Point(524, 228)
        Me.tbMonto.Name = "tbMonto"
        Me.tbMonto.Size = New System.Drawing.Size(163, 20)
        Me.tbMonto.TabIndex = 10
        Me.tbMonto.Tag = ""
        '
        'tbGasto
        '
        Me.tbGasto.AutoCompleteCustomSource.AddRange(New String() {"Administrativos", "Alquileres", "Bancarios", "Coparticipación", "Desenvolvimiento", "Filiales", "Franqueo y Encomiendas", "Honorarios", "Impuestos y servicios", "Librería e impresiones", "Seguros", "Movilidad y traslado", "Prensa y difusión", "Prestaciones", "Subsidios"})
        Me.tbGasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbGasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbGasto.FormattingEnabled = True
        Me.tbGasto.Items.AddRange(New Object() {"Administrativos", "Alquileres", "Aplicables a Coparticipación", "Bancarios", "Coparticipación", "Desenvolvimiento", "Filiales", "Franqueo y Encomiendas", "Honorarios", "Impuestos y servicios", "Librería e impresiones", "Seguros", "Movilidad y traslado", "Prensa y difusión", "Prestaciones", "Subsidios"})
        Me.tbGasto.Location = New System.Drawing.Point(155, 135)
        Me.tbGasto.Name = "tbGasto"
        Me.tbGasto.Size = New System.Drawing.Size(156, 21)
        Me.tbGasto.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Green
        Me.btnGuardar.Location = New System.Drawing.Point(561, 291)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(126, 61)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lbGasto
        '
        Me.lbGasto.AutoSize = True
        Me.lbGasto.Location = New System.Drawing.Point(55, 138)
        Me.lbGasto.Name = "lbGasto"
        Me.lbGasto.Size = New System.Drawing.Size(50, 13)
        Me.lbGasto.TabIndex = 53
        Me.lbGasto.Text = "Gasto de"
        '
        'ckCentral
        '
        Me.ckCentral.AutoSize = True
        Me.ckCentral.Location = New System.Drawing.Point(263, 291)
        Me.ckCentral.Name = "ckCentral"
        Me.ckCentral.Size = New System.Drawing.Size(85, 17)
        Me.ckCentral.TabIndex = 12
        Me.ckCentral.Text = "UDA Central"
        Me.ckCentral.UseVisualStyleBackColor = True
        '
        'ckLarioja
        '
        Me.ckLarioja.AutoSize = True
        Me.ckLarioja.BackColor = System.Drawing.SystemColors.Control
        Me.ckLarioja.Location = New System.Drawing.Point(96, 291)
        Me.ckLarioja.Name = "ckLarioja"
        Me.ckLarioja.Size = New System.Drawing.Size(91, 17)
        Me.ckLarioja.TabIndex = 11
        Me.ckLarioja.Text = "UDA La Rioja"
        Me.ckLarioja.UseVisualStyleBackColor = False
        '
        'tbNombre
        '
        Me.tbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbNombre.BackColor = System.Drawing.SystemColors.Window
        Me.tbNombre.Location = New System.Drawing.Point(44, 85)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(197, 20)
        Me.tbNombre.TabIndex = 1
        '
        'lbMes
        '
        Me.lbMes.AutoSize = True
        Me.lbMes.Location = New System.Drawing.Point(42, 231)
        Me.lbMes.Name = "lbMes"
        Me.lbMes.Size = New System.Drawing.Size(91, 13)
        Me.lbMes.TabIndex = 48
        Me.lbMes.Text = "Mes de Reintegro"
        '
        'lbComentario
        '
        Me.lbComentario.AutoSize = True
        Me.lbComentario.Location = New System.Drawing.Point(32, 378)
        Me.lbComentario.Name = "lbComentario"
        Me.lbComentario.Size = New System.Drawing.Size(60, 13)
        Me.lbComentario.TabIndex = 46
        Me.lbComentario.Text = "Comentario"
        '
        'lbMonto
        '
        Me.lbMonto.AutoSize = True
        Me.lbMonto.Location = New System.Drawing.Point(453, 231)
        Me.lbMonto.Name = "lbMonto"
        Me.lbMonto.Size = New System.Drawing.Size(37, 13)
        Me.lbMonto.TabIndex = 44
        Me.lbMonto.Text = "Monto"
        '
        'lbProveedor
        '
        Me.lbProveedor.AutoSize = True
        Me.lbProveedor.Location = New System.Drawing.Point(55, 183)
        Me.lbProveedor.Name = "lbProveedor"
        Me.lbProveedor.Size = New System.Drawing.Size(56, 13)
        Me.lbProveedor.TabIndex = 42
        Me.lbProveedor.Text = "Proveedor"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(41, 60)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(92, 13)
        Me.lbNombre.TabIndex = 40
        Me.lbNombre.Text = "Nombre y Apellido"
        '
        'lbNComprobante
        '
        Me.lbNComprobante.AutoSize = True
        Me.lbNComprobante.Location = New System.Drawing.Point(425, 183)
        Me.lbNComprobante.Name = "lbNComprobante"
        Me.lbNComprobante.Size = New System.Drawing.Size(85, 13)
        Me.lbNComprobante.TabIndex = 37
        Me.lbNComprobante.Text = "N° Comprobante"
        '
        'tbComentario
        '
        Me.tbComentario.Location = New System.Drawing.Point(114, 357)
        Me.tbComentario.Multiline = True
        Me.tbComentario.Name = "tbComentario"
        Me.tbComentario.Size = New System.Drawing.Size(317, 60)
        Me.tbComentario.TabIndex = 13
        '
        'tbProveedor
        '
        Me.tbProveedor.Location = New System.Drawing.Point(155, 180)
        Me.tbProveedor.Name = "tbProveedor"
        Me.tbProveedor.Size = New System.Drawing.Size(156, 20)
        Me.tbProveedor.TabIndex = 5
        '
        'lb_Titulo
        '
        Me.lb_Titulo.AutoSize = True
        Me.lb_Titulo.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Titulo.Location = New System.Drawing.Point(288, 11)
        Me.lb_Titulo.Name = "lb_Titulo"
        Me.lb_Titulo.Size = New System.Drawing.Size(193, 38)
        Me.lb_Titulo.TabIndex = 62
        Me.lb_Titulo.Text = "Nuevo Egreso"
        '
        'tbNComprobante
        '
        Me.tbNComprobante.Location = New System.Drawing.Point(590, 180)
        Me.tbNComprobante.Name = "tbNComprobante"
        Me.tbNComprobante.Size = New System.Drawing.Size(97, 20)
        Me.tbNComprobante.TabIndex = 9
        '
        'ABMEgresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.tbNComprobante)
        Me.Controls.Add(Me.lb_Titulo)
        Me.Controls.Add(Me.tbTComprobante)
        Me.Controls.Add(Me.bttnConsultar)
        Me.Controls.Add(Me.tbPVenta)
        Me.Controls.Add(Me.tbReintegro)
        Me.Controls.Add(Me.lbYear)
        Me.Controls.Add(Me.lbMonth)
        Me.Controls.Add(Me.lbDay)
        Me.Controls.Add(Me.tbYear)
        Me.Controls.Add(Me.tbMonth)
        Me.Controls.Add(Me.tbDay)
        Me.Controls.Add(Me.lbSmonto)
        Me.Controls.Add(Me.lbTComprobante)
        Me.Controls.Add(Me.tbMonto)
        Me.Controls.Add(Me.tbGasto)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lbGasto)
        Me.Controls.Add(Me.ckCentral)
        Me.Controls.Add(Me.ckLarioja)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lbMes)
        Me.Controls.Add(Me.lbComentario)
        Me.Controls.Add(Me.lbMonto)
        Me.Controls.Add(Me.lbProveedor)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbNComprobante)
        Me.Controls.Add(Me.tbComentario)
        Me.Controls.Add(Me.tbProveedor)
        Me.Name = "ABMEgresos"
        Me.Size = New System.Drawing.Size(755, 456)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbTComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents bttnConsultar As System.Windows.Forms.Button
    Friend WithEvents tbPVenta As System.Windows.Forms.TextBox
    Friend WithEvents tbReintegro As System.Windows.Forms.TextBox
    Friend WithEvents lbYear As System.Windows.Forms.Label
    Friend WithEvents lbMonth As System.Windows.Forms.Label
    Friend WithEvents lbDay As System.Windows.Forms.Label
    Friend WithEvents tbYear As System.Windows.Forms.TextBox
    Friend WithEvents tbMonth As System.Windows.Forms.TextBox
    Friend WithEvents tbDay As System.Windows.Forms.TextBox
    Friend WithEvents lbSmonto As System.Windows.Forms.Label
    Friend WithEvents lbTComprobante As System.Windows.Forms.Label
    Friend WithEvents tbMonto As System.Windows.Forms.TextBox
    Friend WithEvents tbGasto As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lbGasto As System.Windows.Forms.Label
    Friend WithEvents ckCentral As System.Windows.Forms.CheckBox
    Friend WithEvents ckLarioja As System.Windows.Forms.CheckBox
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents lbMes As System.Windows.Forms.Label
    Friend WithEvents lbComentario As System.Windows.Forms.Label
    Friend WithEvents lbMonto As System.Windows.Forms.Label
    Friend WithEvents lbProveedor As System.Windows.Forms.Label
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbNComprobante As System.Windows.Forms.Label
    Friend WithEvents tbComentario As System.Windows.Forms.TextBox
    Friend WithEvents tbProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lb_Titulo As System.Windows.Forms.Label
    Friend WithEvents tbNComprobante As System.Windows.Forms.TextBox

End Class
