﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteEgresoCen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteEgresoCen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Trimestre = New System.Windows.Forms.TextBox()
        Me.tb_Año = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Seccional = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(655, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HerramientasToolStripMenuItem1
        '
        Me.HerramientasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarComoExcelToolStripMenuItem})
        Me.HerramientasToolStripMenuItem1.Name = "HerramientasToolStripMenuItem1"
        Me.HerramientasToolStripMenuItem1.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem1.Text = "Herramientas"
        '
        'GuardarComoExcelToolStripMenuItem
        '
        Me.GuardarComoExcelToolStripMenuItem.Name = "GuardarComoExcelToolStripMenuItem"
        Me.GuardarComoExcelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GuardarComoExcelToolStripMenuItem.Text = "Guardar"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Size = New System.Drawing.Size(655, 417)
        Me.SplitContainer1.SplitterDistance = 118
        Me.SplitContainer1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_Trimestre)
        Me.GroupBox1.Controls.Add(Me.tb_Año)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tb_Seccional)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 104)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Egresos UDA Central"
        '
        'tb_Trimestre
        '
        Me.tb_Trimestre.Enabled = False
        Me.tb_Trimestre.Location = New System.Drawing.Point(526, 63)
        Me.tb_Trimestre.Name = "tb_Trimestre"
        Me.tb_Trimestre.Size = New System.Drawing.Size(81, 20)
        Me.tb_Trimestre.TabIndex = 12
        Me.tb_Trimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_Año
        '
        Me.tb_Año.Enabled = False
        Me.tb_Año.Location = New System.Drawing.Point(526, 28)
        Me.tb_Año.Name = "tb_Año"
        Me.tb_Año.Size = New System.Drawing.Size(81, 20)
        Me.tb_Año.TabIndex = 11
        Me.tb_Año.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Trimestre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(482, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Año"
        '
        'tb_Seccional
        '
        Me.tb_Seccional.Enabled = False
        Me.tb_Seccional.Location = New System.Drawing.Point(65, 75)
        Me.tb_Seccional.Name = "tb_Seccional"
        Me.tb_Seccional.Size = New System.Drawing.Size(137, 20)
        Me.tb_Seccional.TabIndex = 8
        Me.tb_Seccional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Seccional"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv.RowTemplate.DividerHeight = 1
        Me.dgv.RowTemplate.Height = 35
        Me.dgv.RowTemplate.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(655, 295)
        Me.dgv.TabIndex = 3
        '
        'ReporteEgresoCen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 441)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ReporteEgresoCen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents HerramientasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GuardarComoExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Trimestre As TextBox
    Friend WithEvents tb_Año As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_Seccional As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv As DataGridView
End Class
