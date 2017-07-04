<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.DGVAdmin = New System.Windows.Forms.DataGridView()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.cb_Rol = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Contraseña = New System.Windows.Forms.TextBox()
        Me.tb_Usuario = New System.Windows.Forms.TextBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.DGVAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.DGVAdmin)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.btn_Nuevo)
        Me.SplitContainer.Panel2.Controls.Add(Me.cb_Rol)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer.Panel2.Controls.Add(Me.tb_Contraseña)
        Me.SplitContainer.Panel2.Controls.Add(Me.tb_Usuario)
        Me.SplitContainer.Panel2.Controls.Add(Me.btn_Cancelar)
        Me.SplitContainer.Panel2.Controls.Add(Me.btn_Eliminar)
        Me.SplitContainer.Panel2.Controls.Add(Me.btn_Guardar)
        Me.SplitContainer.Panel2.Controls.Add(Me.btn_Modificar)
        Me.SplitContainer.Size = New System.Drawing.Size(755, 456)
        Me.SplitContainer.SplitterDistance = 446
        Me.SplitContainer.TabIndex = 0
        '
        'DGVAdmin
        '
        Me.DGVAdmin.AllowUserToAddRows = False
        Me.DGVAdmin.AllowUserToDeleteRows = False
        Me.DGVAdmin.AllowUserToResizeRows = False
        Me.DGVAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVAdmin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAdmin.Location = New System.Drawing.Point(0, 0)
        Me.DGVAdmin.MultiSelect = False
        Me.DGVAdmin.Name = "DGVAdmin"
        Me.DGVAdmin.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVAdmin.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVAdmin.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVAdmin.Size = New System.Drawing.Size(446, 456)
        Me.DGVAdmin.TabIndex = 2
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Location = New System.Drawing.Point(68, 248)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(178, 33)
        Me.btn_Nuevo.TabIndex = 4
        Me.btn_Nuevo.Text = "Nuevo Usuario"
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'cb_Rol
        '
        Me.cb_Rol.AutoCompleteCustomSource.AddRange(New String() {"Administrador", "Contador", "Usuario"})
        Me.cb_Rol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Rol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Rol.Enabled = False
        Me.cb_Rol.FormattingEnabled = True
        Me.cb_Rol.Items.AddRange(New Object() {"Administrador", "Contador", "Usuario"})
        Me.cb_Rol.Location = New System.Drawing.Point(82, 194)
        Me.cb_Rol.Name = "cb_Rol"
        Me.cb_Rol.Size = New System.Drawing.Size(144, 21)
        Me.cb_Rol.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Rol"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario"
        '
        'tb_Contraseña
        '
        Me.tb_Contraseña.Enabled = False
        Me.tb_Contraseña.Location = New System.Drawing.Point(82, 133)
        Me.tb_Contraseña.Name = "tb_Contraseña"
        Me.tb_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Contraseña.Size = New System.Drawing.Size(144, 20)
        Me.tb_Contraseña.TabIndex = 2
        '
        'tb_Usuario
        '
        Me.tb_Usuario.Enabled = False
        Me.tb_Usuario.Location = New System.Drawing.Point(82, 67)
        Me.tb_Usuario.Name = "tb_Usuario"
        Me.tb_Usuario.Size = New System.Drawing.Size(144, 20)
        Me.tb_Usuario.TabIndex = 1
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Location = New System.Drawing.Point(68, 326)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(178, 33)
        Me.btn_Cancelar.TabIndex = 6
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.LightSalmon
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Location = New System.Drawing.Point(68, 365)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(178, 33)
        Me.btn_Eliminar.TabIndex = 7
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.Color.LightGreen
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Location = New System.Drawing.Point(68, 404)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(178, 33)
        Me.btn_Guardar.TabIndex = 8
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Location = New System.Drawing.Point(68, 287)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(178, 33)
        Me.btn_Modificar.TabIndex = 5
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'ABMUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer)
        Me.Name = "ABMUsuarios"
        Me.Size = New System.Drawing.Size(755, 456)
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.Panel2.PerformLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.DGVAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents DGVAdmin As DataGridView
    Friend WithEvents cb_Rol As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Contraseña As TextBox
    Friend WithEvents tb_Usuario As TextBox
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Nuevo As Button
End Class
