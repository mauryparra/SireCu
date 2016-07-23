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
        Me.tb_IngresosP1 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosP2 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosP3 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosO1 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosO2 = New System.Windows.Forms.TextBox()
        Me.tb_IngresosO3 = New System.Windows.Forms.TextBox()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_Titulo
        '
        Me.lb_Titulo.AutoSize = True
        Me.lb_Titulo.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Titulo.Location = New System.Drawing.Point(305, 13)
        Me.lb_Titulo.Name = "lb_Titulo"
        Me.lb_Titulo.Size = New System.Drawing.Size(128, 38)
        Me.lb_Titulo.TabIndex = 0
        Me.lb_Titulo.Text = "Ingresos"
        '
        'cb_Trimestre
        '
        Me.cb_Trimestre.AutoCompleteCustomSource.AddRange(New String() {"Primero", "Segundo", "Tercero", "Cuarto"})
        Me.cb_Trimestre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Trimestre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_Trimestre.FormattingEnabled = True
        Me.cb_Trimestre.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto"})
        Me.cb_Trimestre.Location = New System.Drawing.Point(154, 95)
        Me.cb_Trimestre.Name = "cb_Trimestre"
        Me.cb_Trimestre.Size = New System.Drawing.Size(121, 21)
        Me.cb_Trimestre.TabIndex = 1
        '
        'lb_Trimestre
        '
        Me.lb_Trimestre.AutoSize = True
        Me.lb_Trimestre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_Trimestre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Trimestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Trimestre.Location = New System.Drawing.Point(38, 91)
        Me.lb_Trimestre.Name = "lb_Trimestre"
        Me.lb_Trimestre.Size = New System.Drawing.Size(96, 25)
        Me.lb_Trimestre.TabIndex = 2
        Me.lb_Trimestre.Text = "Trimestre:"
        '
        'lb_Mes1
        '
        Me.lb_Mes1.AutoSize = True
        Me.lb_Mes1.BackColor = System.Drawing.SystemColors.Control
        Me.lb_Mes1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Mes1.Location = New System.Drawing.Point(82, 186)
        Me.lb_Mes1.Name = "lb_Mes1"
        Me.lb_Mes1.Size = New System.Drawing.Size(50, 23)
        Me.lb_Mes1.TabIndex = 3
        Me.lb_Mes1.Text = "----"
        '
        'lb_Mes2
        '
        Me.lb_Mes2.AutoSize = True
        Me.lb_Mes2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Mes2.Location = New System.Drawing.Point(82, 258)
        Me.lb_Mes2.Name = "lb_Mes2"
        Me.lb_Mes2.Size = New System.Drawing.Size(50, 23)
        Me.lb_Mes2.TabIndex = 4
        Me.lb_Mes2.Text = "----"
        '
        'lb_Mes3
        '
        Me.lb_Mes3.AutoSize = True
        Me.lb_Mes3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Mes3.Location = New System.Drawing.Point(82, 331)
        Me.lb_Mes3.Name = "lb_Mes3"
        Me.lb_Mes3.Size = New System.Drawing.Size(50, 23)
        Me.lb_Mes3.TabIndex = 5
        Me.lb_Mes3.Text = "----"
        '
        'tb_IngresosP1
        '
        Me.tb_IngresosP1.Enabled = False
        Me.tb_IngresosP1.Location = New System.Drawing.Point(225, 190)
        Me.tb_IngresosP1.Name = "tb_IngresosP1"
        Me.tb_IngresosP1.Size = New System.Drawing.Size(132, 20)
        Me.tb_IngresosP1.TabIndex = 2
        '
        'tb_IngresosP2
        '
        Me.tb_IngresosP2.Enabled = False
        Me.tb_IngresosP2.Location = New System.Drawing.Point(225, 262)
        Me.tb_IngresosP2.Name = "tb_IngresosP2"
        Me.tb_IngresosP2.Size = New System.Drawing.Size(132, 20)
        Me.tb_IngresosP2.TabIndex = 4
        '
        'tb_IngresosP3
        '
        Me.tb_IngresosP3.Enabled = False
        Me.tb_IngresosP3.Location = New System.Drawing.Point(225, 335)
        Me.tb_IngresosP3.Name = "tb_IngresosP3"
        Me.tb_IngresosP3.Size = New System.Drawing.Size(132, 20)
        Me.tb_IngresosP3.TabIndex = 6
        '
        'tb_IngresosO1
        '
        Me.tb_IngresosO1.Enabled = False
        Me.tb_IngresosO1.Location = New System.Drawing.Point(399, 190)
        Me.tb_IngresosO1.Name = "tb_IngresosO1"
        Me.tb_IngresosO1.Size = New System.Drawing.Size(132, 20)
        Me.tb_IngresosO1.TabIndex = 3
        '
        'tb_IngresosO2
        '
        Me.tb_IngresosO2.Enabled = False
        Me.tb_IngresosO2.Location = New System.Drawing.Point(399, 262)
        Me.tb_IngresosO2.Name = "tb_IngresosO2"
        Me.tb_IngresosO2.Size = New System.Drawing.Size(132, 20)
        Me.tb_IngresosO2.TabIndex = 5
        '
        'tb_IngresosO3
        '
        Me.tb_IngresosO3.Enabled = False
        Me.tb_IngresosO3.Location = New System.Drawing.Point(399, 335)
        Me.tb_IngresosO3.Name = "tb_IngresosO3"
        Me.tb_IngresosO3.Size = New System.Drawing.Size(132, 20)
        Me.tb_IngresosO3.TabIndex = 7
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.Location = New System.Drawing.Point(621, 283)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(116, 63)
        Me.btn_Guardar.TabIndex = 9
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modificar.Location = New System.Drawing.Point(621, 103)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(116, 61)
        Me.btn_Modificar.TabIndex = 8
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'ABMIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.tb_IngresosO3)
        Me.Controls.Add(Me.tb_IngresosO2)
        Me.Controls.Add(Me.tb_IngresosO1)
        Me.Controls.Add(Me.tb_IngresosP3)
        Me.Controls.Add(Me.tb_IngresosP2)
        Me.Controls.Add(Me.tb_IngresosP1)
        Me.Controls.Add(Me.lb_Mes3)
        Me.Controls.Add(Me.lb_Mes2)
        Me.Controls.Add(Me.lb_Mes1)
        Me.Controls.Add(Me.lb_Trimestre)
        Me.Controls.Add(Me.cb_Trimestre)
        Me.Controls.Add(Me.lb_Titulo)
        Me.Name = "ABMIngresos"
        Me.Size = New System.Drawing.Size(773, 420)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_Titulo As System.Windows.Forms.Label
    Friend WithEvents cb_Trimestre As System.Windows.Forms.ComboBox
    Friend WithEvents lb_Trimestre As System.Windows.Forms.Label
    Friend WithEvents lb_Mes1 As System.Windows.Forms.Label
    Friend WithEvents lb_Mes2 As System.Windows.Forms.Label
    Friend WithEvents lb_Mes3 As System.Windows.Forms.Label
    Friend WithEvents tb_IngresosP1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_IngresosP2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_IngresosP3 As System.Windows.Forms.TextBox
    Friend WithEvents tb_IngresosO1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_IngresosO2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_IngresosO3 As System.Windows.Forms.TextBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button

End Class
