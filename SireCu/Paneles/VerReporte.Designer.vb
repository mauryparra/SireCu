<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerReporte
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
        Me.GroupBoxSeleccion = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Reporte = New System.Windows.Forms.ComboBox()
        Me.btn_Abrir = New System.Windows.Forms.Button()
        Me.lb_Trimestre = New System.Windows.Forms.Label()
        Me.lb_Año = New System.Windows.Forms.Label()
        Me.tb_Año = New System.Windows.Forms.TextBox()
        Me.cb_Trimestre = New System.Windows.Forms.ComboBox()
        Me.GroupBoxSeleccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxSeleccion
        '
        Me.GroupBoxSeleccion.Controls.Add(Me.Label1)
        Me.GroupBoxSeleccion.Controls.Add(Me.cb_Reporte)
        Me.GroupBoxSeleccion.Controls.Add(Me.btn_Abrir)
        Me.GroupBoxSeleccion.Controls.Add(Me.lb_Trimestre)
        Me.GroupBoxSeleccion.Controls.Add(Me.lb_Año)
        Me.GroupBoxSeleccion.Controls.Add(Me.tb_Año)
        Me.GroupBoxSeleccion.Controls.Add(Me.cb_Trimestre)
        Me.GroupBoxSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSeleccion.Location = New System.Drawing.Point(29, 81)
        Me.GroupBoxSeleccion.Name = "GroupBoxSeleccion"
        Me.GroupBoxSeleccion.Size = New System.Drawing.Size(695, 304)
        Me.GroupBoxSeleccion.TabIndex = 23
        Me.GroupBoxSeleccion.TabStop = False
        Me.GroupBoxSeleccion.Text = "Selección de Reporte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(212, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Reporte"
        '
        'cb_Reporte
        '
        Me.cb_Reporte.AutoCompleteCustomSource.AddRange(New String() {"Ingresos", "Egresos Seccional", "Egresos Central", "Ingresos - Gastos"})
        Me.cb_Reporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Reporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_Reporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Reporte.FormattingEnabled = True
        Me.cb_Reporte.ItemHeight = 16
        Me.cb_Reporte.Items.AddRange(New Object() {"Ingresos", "Egresos Seccional", "Egresos Central", "Ingresos - Gastos"})
        Me.cb_Reporte.Location = New System.Drawing.Point(294, 128)
        Me.cb_Reporte.Name = "cb_Reporte"
        Me.cb_Reporte.Size = New System.Drawing.Size(203, 24)
        Me.cb_Reporte.TabIndex = 3
        '
        'btn_Abrir
        '
        Me.btn_Abrir.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Abrir.ForeColor = System.Drawing.Color.Green
        Me.btn_Abrir.Location = New System.Drawing.Point(318, 222)
        Me.btn_Abrir.Name = "btn_Abrir"
        Me.btn_Abrir.Size = New System.Drawing.Size(81, 41)
        Me.btn_Abrir.TabIndex = 4
        Me.btn_Abrir.Text = "Abrir"
        Me.btn_Abrir.UseVisualStyleBackColor = True
        '
        'lb_Trimestre
        '
        Me.lb_Trimestre.AutoSize = True
        Me.lb_Trimestre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_Trimestre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Trimestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Trimestre.Location = New System.Drawing.Point(380, 51)
        Me.lb_Trimestre.Name = "lb_Trimestre"
        Me.lb_Trimestre.Size = New System.Drawing.Size(89, 25)
        Me.lb_Trimestre.TabIndex = 2
        Me.lb_Trimestre.Text = "Trimestre"
        '
        'lb_Año
        '
        Me.lb_Año.AutoSize = True
        Me.lb_Año.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_Año.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Año.Location = New System.Drawing.Point(132, 51)
        Me.lb_Año.Name = "lb_Año"
        Me.lb_Año.Size = New System.Drawing.Size(40, 25)
        Me.lb_Año.TabIndex = 11
        Me.lb_Año.Text = "Año"
        '
        'tb_Año
        '
        Me.tb_Año.BackColor = System.Drawing.SystemColors.Window
        Me.tb_Año.Location = New System.Drawing.Point(178, 50)
        Me.tb_Año.MaxLength = 4
        Me.tb_Año.Name = "tb_Año"
        Me.tb_Año.Size = New System.Drawing.Size(49, 26)
        Me.tb_Año.TabIndex = 1
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
        Me.cb_Trimestre.Location = New System.Drawing.Point(482, 51)
        Me.cb_Trimestre.Name = "cb_Trimestre"
        Me.cb_Trimestre.Size = New System.Drawing.Size(121, 24)
        Me.cb_Trimestre.TabIndex = 2
        '
        'VerReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.GroupBoxSeleccion)
        Me.Name = "VerReporte"
        Me.Size = New System.Drawing.Size(755, 456)
        Me.GroupBoxSeleccion.ResumeLayout(False)
        Me.GroupBoxSeleccion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxSeleccion As GroupBox
    Friend WithEvents btn_Abrir As Button
    Friend WithEvents lb_Trimestre As Label
    Friend WithEvents lb_Año As Label
    Friend WithEvents tb_Año As TextBox
    Friend WithEvents cb_Trimestre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_Reporte As ComboBox
End Class
