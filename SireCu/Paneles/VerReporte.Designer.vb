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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBoxTrimestre = New System.Windows.Forms.GroupBox()
        Me.btn_Ver = New System.Windows.Forms.Button()
        Me.lb_Trimestre = New System.Windows.Forms.Label()
        Me.lb_Año = New System.Windows.Forms.Label()
        Me.tb_Año = New System.Windows.Forms.TextBox()
        Me.cb_Trimestre = New System.Windows.Forms.ComboBox()
        Me.dgv_Reportes = New System.Windows.Forms.DataGridView()
        Me.bttn_Qfiltro = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBoxTrimestre.SuspendLayout()
        CType(Me.dgv_Reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBoxTrimestre)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv_Reportes)
        Me.SplitContainer1.Size = New System.Drawing.Size(755, 456)
        Me.SplitContainer1.SplitterDistance = 117
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBoxTrimestre
        '
        Me.GroupBoxTrimestre.Controls.Add(Me.bttn_Qfiltro)
        Me.GroupBoxTrimestre.Controls.Add(Me.btn_Ver)
        Me.GroupBoxTrimestre.Controls.Add(Me.lb_Trimestre)
        Me.GroupBoxTrimestre.Controls.Add(Me.lb_Año)
        Me.GroupBoxTrimestre.Controls.Add(Me.tb_Año)
        Me.GroupBoxTrimestre.Controls.Add(Me.cb_Trimestre)
        Me.GroupBoxTrimestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTrimestre.Location = New System.Drawing.Point(41, 8)
        Me.GroupBoxTrimestre.Name = "GroupBoxTrimestre"
        Me.GroupBoxTrimestre.Size = New System.Drawing.Size(695, 99)
        Me.GroupBoxTrimestre.TabIndex = 24
        Me.GroupBoxTrimestre.TabStop = False
        Me.GroupBoxTrimestre.Text = "Filtrar Reportes"
        '
        'btn_Ver
        '
        Me.btn_Ver.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ver.ForeColor = System.Drawing.Color.Green
        Me.btn_Ver.Location = New System.Drawing.Point(441, 30)
        Me.btn_Ver.Name = "btn_Ver"
        Me.btn_Ver.Size = New System.Drawing.Size(81, 52)
        Me.btn_Ver.TabIndex = 4
        Me.btn_Ver.Text = "Ver"
        Me.btn_Ver.UseVisualStyleBackColor = True
        '
        'lb_Trimestre
        '
        Me.lb_Trimestre.AutoSize = True
        Me.lb_Trimestre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_Trimestre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Trimestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_Trimestre.Location = New System.Drawing.Point(144, 65)
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
        Me.lb_Año.Location = New System.Drawing.Point(174, 28)
        Me.lb_Año.Name = "lb_Año"
        Me.lb_Año.Size = New System.Drawing.Size(40, 25)
        Me.lb_Año.TabIndex = 11
        Me.lb_Año.Text = "Año"
        '
        'tb_Año
        '
        Me.tb_Año.BackColor = System.Drawing.SystemColors.Window
        Me.tb_Año.Location = New System.Drawing.Point(246, 27)
        Me.tb_Año.MaxLength = 4
        Me.tb_Año.Name = "tb_Año"
        Me.tb_Año.Size = New System.Drawing.Size(121, 26)
        Me.tb_Año.TabIndex = 1
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
        Me.cb_Trimestre.Location = New System.Drawing.Point(246, 65)
        Me.cb_Trimestre.Name = "cb_Trimestre"
        Me.cb_Trimestre.Size = New System.Drawing.Size(121, 24)
        Me.cb_Trimestre.TabIndex = 2
        '
        'dgv_Reportes
        '
        Me.dgv_Reportes.AllowUserToAddRows = False
        Me.dgv_Reportes.AllowUserToDeleteRows = False
        Me.dgv_Reportes.AllowUserToResizeColumns = False
        Me.dgv_Reportes.AllowUserToResizeRows = False
        Me.dgv_Reportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Reportes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Reportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Reportes.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Reportes.Name = "dgv_Reportes"
        Me.dgv_Reportes.ReadOnly = True
        Me.dgv_Reportes.Size = New System.Drawing.Size(755, 335)
        Me.dgv_Reportes.TabIndex = 0
        '
        'bttn_Qfiltro
        '
        Me.bttn_Qfiltro.Enabled = False
        Me.bttn_Qfiltro.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn_Qfiltro.ForeColor = System.Drawing.Color.Green
        Me.bttn_Qfiltro.Location = New System.Drawing.Point(571, 30)
        Me.bttn_Qfiltro.Name = "bttn_Qfiltro"
        Me.bttn_Qfiltro.Size = New System.Drawing.Size(81, 52)
        Me.bttn_Qfiltro.TabIndex = 12
        Me.bttn_Qfiltro.Text = "Quitar Filtros"
        Me.bttn_Qfiltro.UseVisualStyleBackColor = True
        '
        'VerReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "VerReporte"
        Me.Size = New System.Drawing.Size(755, 456)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBoxTrimestre.ResumeLayout(False)
        Me.GroupBoxTrimestre.PerformLayout()
        CType(Me.dgv_Reportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBoxTrimestre As GroupBox
    Friend WithEvents btn_Ver As Button
    Friend WithEvents lb_Trimestre As Label
    Friend WithEvents lb_Año As Label
    Friend WithEvents tb_Año As TextBox
    Friend WithEvents cb_Trimestre As ComboBox
    Friend WithEvents dgv_Reportes As DataGridView
    Friend WithEvents bttn_Qfiltro As Button
End Class
