﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.ToolStripContainerPrincipal = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStripPrincipal = New System.Windows.Forms.StatusStrip()
        Me.stat_Label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stat_Bar = New System.Windows.Forms.ToolStripProgressBar()
        Me.TStripLabelSaldo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainerPrincipal = New System.Windows.Forms.SplitContainer()
        Me.RadioButtonABMAdmin = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEgresos = New System.Windows.Forms.RadioButton()
        Me.RadioButtonIngresos = New System.Windows.Forms.RadioButton()
        Me.MenuStripPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStripContainerPrincipal.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainerPrincipal.ContentPanel.SuspendLayout()
        Me.ToolStripContainerPrincipal.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainerPrincipal.SuspendLayout()
        Me.StatusStripPrincipal.SuspendLayout()
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPrincipal.Panel1.SuspendLayout()
        Me.SplitContainerPrincipal.SuspendLayout()
        Me.MenuStripPrincipal.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripContainerPrincipal
        '
        '
        'ToolStripContainerPrincipal.BottomToolStripPanel
        '
        Me.ToolStripContainerPrincipal.BottomToolStripPanel.Controls.Add(Me.StatusStripPrincipal)
        '
        'ToolStripContainerPrincipal.ContentPanel
        '
        Me.ToolStripContainerPrincipal.ContentPanel.Controls.Add(Me.SplitContainerPrincipal)
        Me.ToolStripContainerPrincipal.ContentPanel.Size = New System.Drawing.Size(982, 465)
        Me.ToolStripContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainerPrincipal.LeftToolStripPanelVisible = False
        Me.ToolStripContainerPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainerPrincipal.Name = "ToolStripContainerPrincipal"
        Me.ToolStripContainerPrincipal.RightToolStripPanelVisible = False
        Me.ToolStripContainerPrincipal.Size = New System.Drawing.Size(982, 511)
        Me.ToolStripContainerPrincipal.TabIndex = 0
        Me.ToolStripContainerPrincipal.Text = "ToolStripContainer1"
        '
        'ToolStripContainerPrincipal.TopToolStripPanel
        '
        Me.ToolStripContainerPrincipal.TopToolStripPanel.Controls.Add(Me.MenuStripPrincipal)
        '
        'StatusStripPrincipal
        '
        Me.StatusStripPrincipal.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stat_Label, Me.stat_Bar, Me.TStripLabelSaldo, Me.ToolStripStatusLabel1})
        Me.StatusStripPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.StatusStripPrincipal.Name = "StatusStripPrincipal"
        Me.StatusStripPrincipal.Size = New System.Drawing.Size(982, 22)
        Me.StatusStripPrincipal.TabIndex = 0
        '
        'stat_Label
        '
        Me.stat_Label.Name = "stat_Label"
        Me.stat_Label.Size = New System.Drawing.Size(928, 17)
        Me.stat_Label.Spring = True
        Me.stat_Label.Text = "Conectado"
        Me.stat_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stat_Bar
        '
        Me.stat_Bar.Name = "stat_Bar"
        Me.stat_Bar.Size = New System.Drawing.Size(100, 16)
        Me.stat_Bar.Visible = False
        '
        'TStripLabelSaldo
        '
        Me.TStripLabelSaldo.Name = "TStripLabelSaldo"
        Me.TStripLabelSaldo.Size = New System.Drawing.Size(39, 17)
        Me.TStripLabelSaldo.Text = "Saldo:"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'SplitContainerPrincipal
        '
        Me.SplitContainerPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainerPrincipal.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerPrincipal.IsSplitterFixed = True
        Me.SplitContainerPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerPrincipal.Name = "SplitContainerPrincipal"
        '
        'SplitContainerPrincipal.Panel1
        '
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.RadioButtonABMAdmin)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.RadioButtonEgresos)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.RadioButtonIngresos)
        Me.SplitContainerPrincipal.Size = New System.Drawing.Size(982, 465)
        Me.SplitContainerPrincipal.SplitterDistance = 200
        Me.SplitContainerPrincipal.SplitterWidth = 1
        Me.SplitContainerPrincipal.TabIndex = 0
        '
        'RadioButtonABMAdmin
        '
        Me.RadioButtonABMAdmin.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonABMAdmin.AutoSize = True
        Me.RadioButtonABMAdmin.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonABMAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonABMAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonABMAdmin.Location = New System.Drawing.Point(3, 127)
        Me.RadioButtonABMAdmin.MinimumSize = New System.Drawing.Size(190, 30)
        Me.RadioButtonABMAdmin.Name = "RadioButtonABMAdmin"
        Me.RadioButtonABMAdmin.Size = New System.Drawing.Size(190, 30)
        Me.RadioButtonABMAdmin.TabIndex = 2
        Me.RadioButtonABMAdmin.Text = "Administrar"
        Me.RadioButtonABMAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButtonABMAdmin.UseVisualStyleBackColor = False
        '
        'RadioButtonEgresos
        '
        Me.RadioButtonEgresos.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonEgresos.AutoSize = True
        Me.RadioButtonEgresos.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonEgresos.Location = New System.Drawing.Point(3, 70)
        Me.RadioButtonEgresos.MinimumSize = New System.Drawing.Size(190, 30)
        Me.RadioButtonEgresos.Name = "RadioButtonEgresos"
        Me.RadioButtonEgresos.Size = New System.Drawing.Size(190, 30)
        Me.RadioButtonEgresos.TabIndex = 1
        Me.RadioButtonEgresos.Text = "Egresos"
        Me.RadioButtonEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButtonEgresos.UseVisualStyleBackColor = False
        '
        'RadioButtonIngresos
        '
        Me.RadioButtonIngresos.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonIngresos.AutoSize = True
        Me.RadioButtonIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButtonIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonIngresos.Location = New System.Drawing.Point(3, 13)
        Me.RadioButtonIngresos.MinimumSize = New System.Drawing.Size(190, 30)
        Me.RadioButtonIngresos.Name = "RadioButtonIngresos"
        Me.RadioButtonIngresos.Size = New System.Drawing.Size(190, 30)
        Me.RadioButtonIngresos.TabIndex = 0
        Me.RadioButtonIngresos.Text = "Ingresos"
        Me.RadioButtonIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButtonIngresos.UseVisualStyleBackColor = True
        '
        'MenuStripPrincipal
        '
        Me.MenuStripPrincipal.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStripPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPrincipal.Name = "MenuStripPrincipal"
        Me.MenuStripPrincipal.Size = New System.Drawing.Size(982, 24)
        Me.MenuStripPrincipal.TabIndex = 0
        Me.MenuStripPrincipal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 511)
        Me.Controls.Add(Me.ToolStripContainerPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripPrincipal
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SireCu"
        Me.ToolStripContainerPrincipal.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainerPrincipal.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainerPrincipal.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainerPrincipal.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainerPrincipal.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainerPrincipal.ResumeLayout(False)
        Me.ToolStripContainerPrincipal.PerformLayout()
        Me.StatusStripPrincipal.ResumeLayout(False)
        Me.StatusStripPrincipal.PerformLayout()
        Me.SplitContainerPrincipal.Panel1.ResumeLayout(False)
        Me.SplitContainerPrincipal.Panel1.PerformLayout()
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPrincipal.ResumeLayout(False)
        Me.MenuStripPrincipal.ResumeLayout(False)
        Me.MenuStripPrincipal.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainerPrincipal As System.Windows.Forms.ToolStripContainer
    Friend WithEvents StatusStripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStripPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents SplitContainerPrincipal As System.Windows.Forms.SplitContainer
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadioButtonIngresos As System.Windows.Forms.RadioButton
    Friend WithEvents stat_Label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stat_Bar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents RadioButtonEgresos As System.Windows.Forms.RadioButton
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents TStripLabelSaldo As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents RadioButtonABMAdmin As RadioButton
End Class
