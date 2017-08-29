<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CerrarTrimestre
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
        Me.tb_Info = New System.Windows.Forms.TextBox()
        Me.btn_Ver = New System.Windows.Forms.Button()
        Me.lb_Trimestre = New System.Windows.Forms.Label()
        Me.lb_Año = New System.Windows.Forms.Label()
        Me.tb_Año = New System.Windows.Forms.TextBox()
        Me.cb_Trimestre = New System.Windows.Forms.ComboBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_Info
        '
        Me.tb_Info.Enabled = False
        Me.tb_Info.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Info.Location = New System.Drawing.Point(526, 89)
        Me.tb_Info.Multiline = True
        Me.tb_Info.Name = "tb_Info"
        Me.tb_Info.Size = New System.Drawing.Size(247, 283)
        Me.tb_Info.TabIndex = 0
        '
        'btn_Ver
        '
        Me.btn_Ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ver.ForeColor = System.Drawing.Color.Green
        Me.btn_Ver.Location = New System.Drawing.Point(366, 142)
        Me.btn_Ver.Name = "btn_Ver"
        Me.btn_Ver.Size = New System.Drawing.Size(99, 70)
        Me.btn_Ver.TabIndex = 15
        Me.btn_Ver.Text = "Ver"
        Me.btn_Ver.UseVisualStyleBackColor = True
        '
        'lb_Trimestre
        '
        Me.lb_Trimestre.AutoSize = True
        Me.lb_Trimestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Trimestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Trimestre.Location = New System.Drawing.Point(86, 240)
        Me.lb_Trimestre.Name = "lb_Trimestre"
        Me.lb_Trimestre.Size = New System.Drawing.Size(84, 20)
        Me.lb_Trimestre.TabIndex = 13
        Me.lb_Trimestre.Text = "Trimestre"
        '
        'lb_Año
        '
        Me.lb_Año.AutoSize = True
        Me.lb_Año.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Año.Location = New System.Drawing.Point(107, 189)
        Me.lb_Año.Name = "lb_Año"
        Me.lb_Año.Size = New System.Drawing.Size(41, 20)
        Me.lb_Año.TabIndex = 16
        Me.lb_Año.Text = "Año"
        '
        'tb_Año
        '
        Me.tb_Año.BackColor = System.Drawing.SystemColors.Window
        Me.tb_Año.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Año.Location = New System.Drawing.Point(176, 186)
        Me.tb_Año.MaxLength = 4
        Me.tb_Año.Name = "tb_Año"
        Me.tb_Año.Size = New System.Drawing.Size(121, 26)
        Me.tb_Año.TabIndex = 12
        Me.tb_Año.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cb_Trimestre.Location = New System.Drawing.Point(176, 240)
        Me.cb_Trimestre.Name = "cb_Trimestre"
        Me.cb_Trimestre.Size = New System.Drawing.Size(121, 24)
        Me.cb_Trimestre.TabIndex = 14
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Enabled = False
        Me.btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cerrar.ForeColor = System.Drawing.Color.Green
        Me.btn_Cerrar.Location = New System.Drawing.Point(366, 240)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(99, 70)
        Me.btn_Cerrar.TabIndex = 17
        Me.btn_Cerrar.Text = "Cerrar Trimestre"
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'CerrarTrimestre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.btn_Ver)
        Me.Controls.Add(Me.lb_Trimestre)
        Me.Controls.Add(Me.lb_Año)
        Me.Controls.Add(Me.tb_Año)
        Me.Controls.Add(Me.cb_Trimestre)
        Me.Controls.Add(Me.tb_Info)
        Me.Name = "CerrarTrimestre"
        Me.Size = New System.Drawing.Size(837, 456)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_Info As TextBox
    Friend WithEvents btn_Ver As Button
    Friend WithEvents lb_Trimestre As Label
    Friend WithEvents lb_Año As Label
    Friend WithEvents tb_Año As TextBox
    Friend WithEvents cb_Trimestre As ComboBox
    Friend WithEvents btn_Cerrar As Button
End Class
