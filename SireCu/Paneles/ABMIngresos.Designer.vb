<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMIngresos
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
        Me.lb_Titulo = New System.Windows.Forms.Label()
        Me.cb_Trimestre = New System.Windows.Forms.ComboBox()
        Me.lb_Trimestre = New System.Windows.Forms.Label()
        Me.lb_Mes1 = New System.Windows.Forms.Label()
        Me.lb_Mes2 = New System.Windows.Forms.Label()
        Me.lb_Mes3 = New System.Windows.Forms.Label()
        Me.tb_IngresosC1 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosC2 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosC3 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosP1 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosP2 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosP3 = New System.Windows.Forms.TextBox()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.lb_Año = New System.Windows.Forms.Label()
        Me.tb_Año = New System.Windows.Forms.TextBox()
        Me.tb_IngresosO1 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosO2 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosO3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxTrimestre = New System.Windows.Forms.GroupBox()
        Me.GroupBoxIngresos = New System.Windows.Forms.GroupBox()
        Me.GroupBoxTrimestre.SuspendLayout()
        Me.GroupBoxIngresos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_Titulo
        '
        Me.lb_Titulo.AutoSize = True
        Me.lb_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Titulo.Location = New System.Drawing.Point(359, 16)
        Me.lb_Titulo.Name = "lb_Titulo"
        Me.lb_Titulo.Size = New System.Drawing.Size(135, 33)
        Me.lb_Titulo.TabIndex = 0
        Me.lb_Titulo.Text = "Ingresos"
        '
        'cb_Trimestre
        '
        Me.cb_Trimestre.AutoCompleteCustomSource.AddRange(New String() {"Primero", "Segundo", "Tercero", "Cuarto"})
        Me.cb_Trimestre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Trimestre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_Trimestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Trimestre.FormattingEnabled = True
        Me.cb_Trimestre.ItemHeight = 16
        Me.cb_Trimestre.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto"})
        Me.cb_Trimestre.Location = New System.Drawing.Point(386, 34)
        Me.cb_Trimestre.Name = "cb_Trimestre"
        Me.cb_Trimestre.Size = New System.Drawing.Size(121, 24)
        Me.cb_Trimestre.TabIndex = 1
        '
        'lb_Trimestre
        '
        Me.lb_Trimestre.AutoSize = True
        Me.lb_Trimestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Trimestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Trimestre.Location = New System.Drawing.Point(296, 34)
        Me.lb_Trimestre.Name = "lb_Trimestre"
        Me.lb_Trimestre.Size = New System.Drawing.Size(84, 20)
        Me.lb_Trimestre.TabIndex = 2
        Me.lb_Trimestre.Text = "Trimestre"
        '
        'lb_Mes1
        '
        Me.lb_Mes1.AutoSize = True
        Me.lb_Mes1.BackColor = System.Drawing.SystemColors.Control
        Me.lb_Mes1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Mes1.Location = New System.Drawing.Point(19, 86)
        Me.lb_Mes1.Name = "lb_Mes1"
        Me.lb_Mes1.Size = New System.Drawing.Size(50, 23)
        Me.lb_Mes1.TabIndex = 3
        Me.lb_Mes1.Text = "----"
        Me.lb_Mes1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_Mes2
        '
        Me.lb_Mes2.AutoSize = True
        Me.lb_Mes2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Mes2.Location = New System.Drawing.Point(19, 145)
        Me.lb_Mes2.Name = "lb_Mes2"
        Me.lb_Mes2.Size = New System.Drawing.Size(50, 23)
        Me.lb_Mes2.TabIndex = 4
        Me.lb_Mes2.Text = "----"
        Me.lb_Mes2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_Mes3
        '
        Me.lb_Mes3.AutoSize = True
        Me.lb_Mes3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Mes3.Location = New System.Drawing.Point(19, 210)
        Me.lb_Mes3.Name = "lb_Mes3"
        Me.lb_Mes3.Size = New System.Drawing.Size(50, 23)
        Me.lb_Mes3.TabIndex = 5
        Me.lb_Mes3.Text = "----"
        Me.lb_Mes3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_IngresosC1
        '
        Me.tb_IngresosC1.Enabled = False
        Me.tb_IngresosC1.Location = New System.Drawing.Point(124, 85)
        Me.tb_IngresosC1.Name = "tb_IngresosC1"
        Me.tb_IngresosC1.Size = New System.Drawing.Size(106, 26)
        Me.tb_IngresosC1.TabIndex = 2
        Me.tb_IngresosC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_IngresosC2
        '
        Me.tb_IngresosC2.Enabled = False
        Me.tb_IngresosC2.Location = New System.Drawing.Point(124, 144)
        Me.tb_IngresosC2.Name = "tb_IngresosC2"
        Me.tb_IngresosC2.Size = New System.Drawing.Size(106, 26)
        Me.tb_IngresosC2.TabIndex = 5
        Me.tb_IngresosC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_IngresosC3
        '
        Me.tb_IngresosC3.Enabled = False
        Me.tb_IngresosC3.Location = New System.Drawing.Point(124, 209)
        Me.tb_IngresosC3.Name = "tb_IngresosC3"
        Me.tb_IngresosC3.Size = New System.Drawing.Size(106, 26)
        Me.tb_IngresosC3.TabIndex = 8
        Me.tb_IngresosC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_IngresosP1
        '
        Me.tb_IngresosP1.Enabled = False
        Me.tb_IngresosP1.Location = New System.Drawing.Point(284, 85)
        Me.tb_IngresosP1.Name = "tb_IngresosP1"
        Me.tb_IngresosP1.Size = New System.Drawing.Size(106, 26)
        Me.tb_IngresosP1.TabIndex = 3
        Me.tb_IngresosP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_IngresosP2
        '
        Me.tb_IngresosP2.Enabled = False
        Me.tb_IngresosP2.Location = New System.Drawing.Point(284, 144)
        Me.tb_IngresosP2.Name = "tb_IngresosP2"
        Me.tb_IngresosP2.Size = New System.Drawing.Size(106, 26)
        Me.tb_IngresosP2.TabIndex = 6
        Me.tb_IngresosP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_IngresosP3
        '
        Me.tb_IngresosP3.Enabled = False
        Me.tb_IngresosP3.Location = New System.Drawing.Point(284, 209)
        Me.tb_IngresosP3.Name = "tb_IngresosP3"
        Me.tb_IngresosP3.Size = New System.Drawing.Size(106, 26)
        Me.tb_IngresosP3.TabIndex = 9
        Me.tb_IngresosP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.ForeColor = System.Drawing.Color.Green
        Me.btn_Guardar.Location = New System.Drawing.Point(680, 289)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(116, 63)
        Me.btn_Guardar.TabIndex = 11
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modificar.Location = New System.Drawing.Point(680, 128)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(116, 61)
        Me.btn_Modificar.TabIndex = 12
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'lb_Año
        '
        Me.lb_Año.AutoSize = True
        Me.lb_Año.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Año.Location = New System.Drawing.Point(108, 34)
        Me.lb_Año.Name = "lb_Año"
        Me.lb_Año.Size = New System.Drawing.Size(41, 20)
        Me.lb_Año.TabIndex = 11
        Me.lb_Año.Text = "Año"
        '
        'tb_Año
        '
        Me.tb_Año.Location = New System.Drawing.Point(152, 31)
        Me.tb_Año.MaxLength = 4
        Me.tb_Año.Name = "tb_Año"
        Me.tb_Año.ReadOnly = True
        Me.tb_Año.Size = New System.Drawing.Size(49, 26)
        Me.tb_Año.TabIndex = 12
        Me.tb_Año.TabStop = False
        '
        'tb_IngresosO1
        '
        Me.tb_IngresosO1.Enabled = False
        Me.tb_IngresosO1.Location = New System.Drawing.Point(454, 85)
        Me.tb_IngresosO1.Name = "tb_IngresosO1"
        Me.tb_IngresosO1.Size = New System.Drawing.Size(106, 26)
        Me.tb_IngresosO1.TabIndex = 4
        Me.tb_IngresosO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_IngresosO2
        '
        Me.tb_IngresosO2.Enabled = False
        Me.tb_IngresosO2.Location = New System.Drawing.Point(454, 144)
        Me.tb_IngresosO2.Name = "tb_IngresosO2"
        Me.tb_IngresosO2.Size = New System.Drawing.Size(106, 26)
        Me.tb_IngresosO2.TabIndex = 7
        Me.tb_IngresosO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_IngresosO3
        '
        Me.tb_IngresosO3.Enabled = False
        Me.tb_IngresosO3.Location = New System.Drawing.Point(454, 209)
        Me.tb_IngresosO3.Name = "tb_IngresosO3"
        Me.tb_IngresosO3.Size = New System.Drawing.Size(106, 26)
        Me.tb_IngresosO3.TabIndex = 10
        Me.tb_IngresosO3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(265, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Ingresos Provinciales"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Ingresos Central"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(450, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Otros Ingresos"
        '
        'GroupBoxTrimestre
        '
        Me.GroupBoxTrimestre.Controls.Add(Me.lb_Trimestre)
        Me.GroupBoxTrimestre.Controls.Add(Me.lb_Año)
        Me.GroupBoxTrimestre.Controls.Add(Me.tb_Año)
        Me.GroupBoxTrimestre.Controls.Add(Me.cb_Trimestre)
        Me.GroupBoxTrimestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTrimestre.Location = New System.Drawing.Point(42, 66)
        Me.GroupBoxTrimestre.Name = "GroupBoxTrimestre"
        Me.GroupBoxTrimestre.Size = New System.Drawing.Size(605, 79)
        Me.GroupBoxTrimestre.TabIndex = 19
        Me.GroupBoxTrimestre.TabStop = False
        Me.GroupBoxTrimestre.Text = "Seleccione Trimestre"
        '
        'GroupBoxIngresos
        '
        Me.GroupBoxIngresos.Controls.Add(Me.lb_Mes1)
        Me.GroupBoxIngresos.Controls.Add(Me.tb_IngresosC1)
        Me.GroupBoxIngresos.Controls.Add(Me.tb_IngresosO3)
        Me.GroupBoxIngresos.Controls.Add(Me.Label3)
        Me.GroupBoxIngresos.Controls.Add(Me.tb_IngresosO2)
        Me.GroupBoxIngresos.Controls.Add(Me.tb_IngresosP1)
        Me.GroupBoxIngresos.Controls.Add(Me.tb_IngresosP3)
        Me.GroupBoxIngresos.Controls.Add(Me.Label1)
        Me.GroupBoxIngresos.Controls.Add(Me.tb_IngresosC3)
        Me.GroupBoxIngresos.Controls.Add(Me.Label2)
        Me.GroupBoxIngresos.Controls.Add(Me.lb_Mes3)
        Me.GroupBoxIngresos.Controls.Add(Me.tb_IngresosO1)
        Me.GroupBoxIngresos.Controls.Add(Me.tb_IngresosP2)
        Me.GroupBoxIngresos.Controls.Add(Me.lb_Mes2)
        Me.GroupBoxIngresos.Controls.Add(Me.tb_IngresosC2)
        Me.GroupBoxIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxIngresos.Location = New System.Drawing.Point(42, 151)
        Me.GroupBoxIngresos.Name = "GroupBoxIngresos"
        Me.GroupBoxIngresos.Size = New System.Drawing.Size(605, 267)
        Me.GroupBoxIngresos.TabIndex = 20
        Me.GroupBoxIngresos.TabStop = False
        Me.GroupBoxIngresos.Text = "Ingresos Mensuales"
        '
        'ABMIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBoxIngresos)
        Me.Controls.Add(Me.GroupBoxTrimestre)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.lb_Titulo)
        Me.Name = "ABMIngresos"
        Me.Size = New System.Drawing.Size(837, 456)
        Me.GroupBoxTrimestre.ResumeLayout(False)
        Me.GroupBoxTrimestre.PerformLayout()
        Me.GroupBoxIngresos.ResumeLayout(False)
        Me.GroupBoxIngresos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_Titulo As System.Windows.Forms.Label
    Friend WithEvents cb_Trimestre As System.Windows.Forms.ComboBox
    Friend WithEvents lb_Trimestre As System.Windows.Forms.Label
    Friend WithEvents lb_Mes1 As System.Windows.Forms.Label
    Friend WithEvents lb_Mes2 As System.Windows.Forms.Label
    Friend WithEvents lb_Mes3 As System.Windows.Forms.Label
    Friend WithEvents tb_IngresosC1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_IngresosC2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_IngresosC3 As System.Windows.Forms.TextBox
    Friend WithEvents tb_IngresosP1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_IngresosP2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_IngresosP3 As System.Windows.Forms.TextBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents lb_Año As System.Windows.Forms.Label
    Friend WithEvents tb_Año As System.Windows.Forms.TextBox
    Friend WithEvents tb_IngresosO1 As TextBox
    Friend WithEvents tb_IngresosO2 As TextBox
    Friend WithEvents tb_IngresosO3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBoxTrimestre As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxIngresos As System.Windows.Forms.GroupBox
End Class
