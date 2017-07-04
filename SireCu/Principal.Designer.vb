<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btn_Administrar = New System.Windows.Forms.Button()
        Me.btn_VerReporte = New System.Windows.Forms.Button()
        Me.btn_SubirReporte = New System.Windows.Forms.Button()
        Me.btn_Egresos = New System.Windows.Forms.Button()
        Me.btn_Ingresos = New System.Windows.Forms.Button()
        Me.bttn_Login = New System.Windows.Forms.Button()
        Me.MenuStripPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeccionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.stat_Label.Size = New System.Drawing.Size(957, 17)
        Me.stat_Label.Spring = True
        Me.stat_Label.Text = "Desconectado"
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
        Me.TStripLabelSaldo.Size = New System.Drawing.Size(10, 17)
        Me.TStripLabelSaldo.Text = " "
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
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.btn_Administrar)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.btn_VerReporte)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.btn_SubirReporte)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.btn_Egresos)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.btn_Ingresos)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.bttn_Login)
        Me.SplitContainerPrincipal.Size = New System.Drawing.Size(982, 465)
        Me.SplitContainerPrincipal.SplitterDistance = 200
        Me.SplitContainerPrincipal.SplitterWidth = 1
        Me.SplitContainerPrincipal.TabIndex = 0
        '
        'btn_Administrar
        '
        Me.btn_Administrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Administrar.Enabled = False
        Me.btn_Administrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Administrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_Administrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Administrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Administrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Administrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Administrar.Location = New System.Drawing.Point(3, 410)
        Me.btn_Administrar.Name = "btn_Administrar"
        Me.btn_Administrar.Size = New System.Drawing.Size(190, 30)
        Me.btn_Administrar.TabIndex = 6
        Me.btn_Administrar.TabStop = False
        Me.btn_Administrar.Text = "Administrar"
        Me.btn_Administrar.UseVisualStyleBackColor = False
        '
        'btn_VerReporte
        '
        Me.btn_VerReporte.BackColor = System.Drawing.SystemColors.Control
        Me.btn_VerReporte.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_VerReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_VerReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_VerReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_VerReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VerReporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_VerReporte.Location = New System.Drawing.Point(3, 179)
        Me.btn_VerReporte.Name = "btn_VerReporte"
        Me.btn_VerReporte.Size = New System.Drawing.Size(190, 30)
        Me.btn_VerReporte.TabIndex = 3
        Me.btn_VerReporte.TabStop = False
        Me.btn_VerReporte.Text = "Ver Reporte"
        Me.btn_VerReporte.UseVisualStyleBackColor = False
        '
        'btn_SubirReporte
        '
        Me.btn_SubirReporte.BackColor = System.Drawing.SystemColors.Control
        Me.btn_SubirReporte.Enabled = False
        Me.btn_SubirReporte.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_SubirReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_SubirReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_SubirReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SubirReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SubirReporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_SubirReporte.Location = New System.Drawing.Point(3, 235)
        Me.btn_SubirReporte.Name = "btn_SubirReporte"
        Me.btn_SubirReporte.Size = New System.Drawing.Size(190, 30)
        Me.btn_SubirReporte.TabIndex = 4
        Me.btn_SubirReporte.TabStop = False
        Me.btn_SubirReporte.Text = "Subir Reporte"
        Me.btn_SubirReporte.UseVisualStyleBackColor = False
        '
        'btn_Egresos
        '
        Me.btn_Egresos.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Egresos.Enabled = False
        Me.btn_Egresos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Egresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_Egresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Egresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Egresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Egresos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Egresos.Location = New System.Drawing.Point(3, 79)
        Me.btn_Egresos.Name = "btn_Egresos"
        Me.btn_Egresos.Size = New System.Drawing.Size(190, 30)
        Me.btn_Egresos.TabIndex = 2
        Me.btn_Egresos.TabStop = False
        Me.btn_Egresos.Text = "Egresos"
        Me.btn_Egresos.UseVisualStyleBackColor = False
        '
        'btn_Ingresos
        '
        Me.btn_Ingresos.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Ingresos.Enabled = False
        Me.btn_Ingresos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Ingresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_Ingresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Ingresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Ingresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ingresos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Ingresos.Location = New System.Drawing.Point(3, 25)
        Me.btn_Ingresos.Name = "btn_Ingresos"
        Me.btn_Ingresos.Size = New System.Drawing.Size(190, 30)
        Me.btn_Ingresos.TabIndex = 1
        Me.btn_Ingresos.TabStop = False
        Me.btn_Ingresos.Text = "Ingresos"
        Me.btn_Ingresos.UseVisualStyleBackColor = False
        '
        'bttn_Login
        '
        Me.bttn_Login.BackColor = System.Drawing.SystemColors.Control
        Me.bttn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bttn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.bttn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.bttn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn_Login.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bttn_Login.Location = New System.Drawing.Point(3, 356)
        Me.bttn_Login.Name = "bttn_Login"
        Me.bttn_Login.Size = New System.Drawing.Size(190, 30)
        Me.bttn_Login.TabIndex = 5
        Me.bttn_Login.TabStop = False
        Me.bttn_Login.Text = "Login"
        Me.bttn_Login.UseVisualStyleBackColor = False
        '
        'MenuStripPrincipal
        '
        Me.MenuStripPrincipal.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.UsuariosToolStripMenuItem})
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
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeccionalToolStripMenuItem})
        Me.EditarToolStripMenuItem.Enabled = False
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'SeccionalToolStripMenuItem
        '
        Me.SeccionalToolStripMenuItem.Name = "SeccionalToolStripMenuItem"
        Me.SeccionalToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.SeccionalToolStripMenuItem.Text = "Seccional"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Enabled = False
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AdministrarUsuariosToolStripMenuItem
        '
        Me.AdministrarUsuariosToolStripMenuItem.Name = "AdministrarUsuariosToolStripMenuItem"
        Me.AdministrarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AdministrarUsuariosToolStripMenuItem.Text = "Administrar Usuarios"
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
    Friend WithEvents stat_Label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stat_Bar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents TStripLabelSaldo As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeccionalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bttn_Login As Button
    Friend WithEvents btn_Ingresos As Button
    Friend WithEvents btn_Egresos As Button
    Friend WithEvents btn_SubirReporte As Button
    Friend WithEvents btn_VerReporte As Button
    Friend WithEvents btn_Administrar As Button
End Class
