<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMAdmin
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
        Me.SplitContainerAdmin = New System.Windows.Forms.SplitContainer()
        Me.DGVAdmin = New System.Windows.Forms.DataGridView()
        Me.LEditar = New System.Windows.Forms.Label()
        Me.LTabla = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.TBModificar = New System.Windows.Forms.TextBox()
        Me.CBTabla = New System.Windows.Forms.ComboBox()
        CType(Me.SplitContainerAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerAdmin.Panel1.SuspendLayout()
        Me.SplitContainerAdmin.Panel2.SuspendLayout()
        Me.SplitContainerAdmin.SuspendLayout()
        CType(Me.DGVAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerAdmin
        '
        Me.SplitContainerAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerAdmin.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainerAdmin.IsSplitterFixed = True
        Me.SplitContainerAdmin.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerAdmin.Name = "SplitContainerAdmin"
        '
        'SplitContainerAdmin.Panel1
        '
        Me.SplitContainerAdmin.Panel1.Controls.Add(Me.DGVAdmin)
        '
        'SplitContainerAdmin.Panel2
        '
        Me.SplitContainerAdmin.Panel2.Controls.Add(Me.LEditar)
        Me.SplitContainerAdmin.Panel2.Controls.Add(Me.LTabla)
        Me.SplitContainerAdmin.Panel2.Controls.Add(Me.BCancelar)
        Me.SplitContainerAdmin.Panel2.Controls.Add(Me.BEliminar)
        Me.SplitContainerAdmin.Panel2.Controls.Add(Me.BGuardar)
        Me.SplitContainerAdmin.Panel2.Controls.Add(Me.TBModificar)
        Me.SplitContainerAdmin.Panel2.Controls.Add(Me.CBTabla)
        Me.SplitContainerAdmin.Size = New System.Drawing.Size(755, 456)
        Me.SplitContainerAdmin.SplitterDistance = 530
        Me.SplitContainerAdmin.TabIndex = 0
        '
        'DGVAdmin
        '
        Me.DGVAdmin.AllowUserToAddRows = False
        Me.DGVAdmin.AllowUserToDeleteRows = False
        Me.DGVAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAdmin.Location = New System.Drawing.Point(0, 0)
        Me.DGVAdmin.Name = "DGVAdmin"
        Me.DGVAdmin.ReadOnly = True
        Me.DGVAdmin.Size = New System.Drawing.Size(530, 456)
        Me.DGVAdmin.TabIndex = 0
        '
        'LEditar
        '
        Me.LEditar.AutoSize = True
        Me.LEditar.Location = New System.Drawing.Point(17, 150)
        Me.LEditar.Name = "LEditar"
        Me.LEditar.Size = New System.Drawing.Size(37, 13)
        Me.LEditar.TabIndex = 6
        Me.LEditar.Text = "Editar:"
        '
        'LTabla
        '
        Me.LTabla.AutoSize = True
        Me.LTabla.Location = New System.Drawing.Point(17, 98)
        Me.LTabla.Name = "LTabla"
        Me.LTabla.Size = New System.Drawing.Size(53, 13)
        Me.LTabla.TabIndex = 5
        Me.LTabla.Text = "Modificar:"
        '
        'BCancelar
        '
        Me.BCancelar.Enabled = False
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Location = New System.Drawing.Point(17, 316)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(186, 23)
        Me.BCancelar.TabIndex = 4
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.MistyRose
        Me.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminar.Location = New System.Drawing.Point(17, 265)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(186, 23)
        Me.BEliminar.TabIndex = 3
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.Honeydew
        Me.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGuardar.Location = New System.Drawing.Point(17, 214)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(186, 23)
        Me.BGuardar.TabIndex = 2
        Me.BGuardar.Text = "Guardar Nuevo"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'TBModificar
        '
        Me.TBModificar.Location = New System.Drawing.Point(17, 166)
        Me.TBModificar.Name = "TBModificar"
        Me.TBModificar.Size = New System.Drawing.Size(186, 20)
        Me.TBModificar.TabIndex = 1
        '
        'CBTabla
        '
        Me.CBTabla.FormattingEnabled = True
        Me.CBTabla.Items.AddRange(New Object() {"Proveedor", "Tipo de Comprobante", "Tipo de Gasto", "Persona", "Seccional"})
        Me.CBTabla.Location = New System.Drawing.Point(17, 117)
        Me.CBTabla.Name = "CBTabla"
        Me.CBTabla.Size = New System.Drawing.Size(186, 21)
        Me.CBTabla.TabIndex = 0
        '
        'ABMAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerAdmin)
        Me.Name = "ABMAdmin"
        Me.Size = New System.Drawing.Size(755, 456)
        Me.SplitContainerAdmin.Panel1.ResumeLayout(False)
        Me.SplitContainerAdmin.Panel2.ResumeLayout(False)
        Me.SplitContainerAdmin.Panel2.PerformLayout()
        CType(Me.SplitContainerAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerAdmin.ResumeLayout(False)
        CType(Me.DGVAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerAdmin As SplitContainer
    Friend WithEvents DGVAdmin As DataGridView
    Friend WithEvents CBTabla As ComboBox
    Friend WithEvents TBModificar As TextBox
    Friend WithEvents BCancelar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents LEditar As Label
    Friend WithEvents LTabla As Label
End Class
