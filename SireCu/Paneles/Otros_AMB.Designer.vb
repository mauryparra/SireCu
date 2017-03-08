<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Otros_AMB
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgv_otros = New System.Windows.Forms.DataGridView()
        Me.tb_editar = New System.Windows.Forms.TextBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.cb_tabla = New System.Windows.Forms.ComboBox()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv_otros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv_otros)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Eliminar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tb_editar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Cancelar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cb_tabla)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_Guardar)
        Me.SplitContainer1.Size = New System.Drawing.Size(381, 201)
        Me.SplitContainer1.SplitterDistance = 226
        Me.SplitContainer1.TabIndex = 0
        '
        'dgv_otros
        '
        Me.dgv_otros.AllowUserToAddRows = False
        Me.dgv_otros.AllowUserToDeleteRows = False
        Me.dgv_otros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_otros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_otros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_otros.Location = New System.Drawing.Point(0, 0)
        Me.dgv_otros.MultiSelect = False
        Me.dgv_otros.Name = "dgv_otros"
        Me.dgv_otros.ReadOnly = True
        Me.dgv_otros.Size = New System.Drawing.Size(226, 201)
        Me.dgv_otros.TabIndex = 0
        '
        'tb_editar
        '
        Me.tb_editar.Location = New System.Drawing.Point(8, 69)
        Me.tb_editar.Name = "tb_editar"
        Me.tb_editar.Size = New System.Drawing.Size(131, 20)
        Me.tb_editar.TabIndex = 5
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(41, 166)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 4
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'cb_tabla
        '
        Me.cb_tabla.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_tabla.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_tabla.FormattingEnabled = True
        Me.cb_tabla.Items.AddRange(New Object() {"Proveedor", "Tipo de Comprobante", "Tipo de Gasto", "Persona"})
        Me.cb_tabla.Location = New System.Drawing.Point(8, 19)
        Me.cb_tabla.Name = "cb_tabla"
        Me.cb_tabla.Size = New System.Drawing.Size(131, 21)
        Me.cb_tabla.TabIndex = 3
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Location = New System.Drawing.Point(8, 108)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(64, 36)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "Guardar Nuevo"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(78, 108)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(64, 36)
        Me.btn_Eliminar.TabIndex = 6
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Otros_AMB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 201)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Otros_AMB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SireCu"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv_otros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgv_otros As DataGridView
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents cb_tabla As ComboBox
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents tb_editar As TextBox
    Friend WithEvents btn_Eliminar As Button
End Class
