<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.ToolStripContainerPrincipal = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStripPrincipal = New System.Windows.Forms.StatusStrip()
        Me.MenuStripPrincipal = New System.Windows.Forms.MenuStrip()
        Me.SplitContainerPrincipal = New System.Windows.Forms.SplitContainer()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainerPrincipal.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainerPrincipal.ContentPanel.SuspendLayout()
        Me.ToolStripContainerPrincipal.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainerPrincipal.SuspendLayout()
        Me.MenuStripPrincipal.SuspendLayout()
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPrincipal.SuspendLayout()
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
        Me.ToolStripContainerPrincipal.ContentPanel.Size = New System.Drawing.Size(784, 365)
        Me.ToolStripContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainerPrincipal.LeftToolStripPanelVisible = False
        Me.ToolStripContainerPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainerPrincipal.Name = "ToolStripContainerPrincipal"
        Me.ToolStripContainerPrincipal.RightToolStripPanelVisible = False
        Me.ToolStripContainerPrincipal.Size = New System.Drawing.Size(784, 411)
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
        Me.StatusStripPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.StatusStripPrincipal.Name = "StatusStripPrincipal"
        Me.StatusStripPrincipal.Size = New System.Drawing.Size(784, 22)
        Me.StatusStripPrincipal.TabIndex = 0
        '
        'MenuStripPrincipal
        '
        Me.MenuStripPrincipal.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStripPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPrincipal.Name = "MenuStripPrincipal"
        Me.MenuStripPrincipal.Size = New System.Drawing.Size(784, 24)
        Me.MenuStripPrincipal.TabIndex = 0
        Me.MenuStripPrincipal.Text = "MenuStrip1"
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
        Me.SplitContainerPrincipal.Size = New System.Drawing.Size(784, 365)
        Me.SplitContainerPrincipal.SplitterDistance = 200
        Me.SplitContainerPrincipal.SplitterWidth = 1
        Me.SplitContainerPrincipal.TabIndex = 0
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
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.ToolStripContainerPrincipal)
        Me.MainMenuStrip = Me.MenuStripPrincipal
        Me.Name = "Principal"
        Me.Text = "SireCu"
        Me.ToolStripContainerPrincipal.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainerPrincipal.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainerPrincipal.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainerPrincipal.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainerPrincipal.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainerPrincipal.ResumeLayout(False)
        Me.ToolStripContainerPrincipal.PerformLayout()
        Me.MenuStripPrincipal.ResumeLayout(False)
        Me.MenuStripPrincipal.PerformLayout()
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainerPrincipal As System.Windows.Forms.ToolStripContainer
    Friend WithEvents StatusStripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStripPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents SplitContainerPrincipal As System.Windows.Forms.SplitContainer
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
