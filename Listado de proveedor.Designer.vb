<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_de_proveedor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listado_de_proveedor))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDEPROVEEDORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZONSOCIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORREODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVEEDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TIENDITADataSet = New BD_TIENDITA.BD_TIENDITADataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PROVEEDORTableAdapter = New BD_TIENDITA.BD_TIENDITADataSetTableAdapters.PROVEEDORTableAdapter()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TIENDITADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDEPROVEEDORDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.RAZONSOCIALDataGridViewTextBoxColumn, Me.CONTACTODataGridViewTextBoxColumn, Me.CORREODataGridViewTextBoxColumn, Me.TELEFONODataGridViewTextBoxColumn, Me.RUCDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.PROVEEDORBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 45)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(744, 183)
        Me.DataGridView2.TabIndex = 2
        '
        'IDEPROVEEDORDataGridViewTextBoxColumn
        '
        Me.IDEPROVEEDORDataGridViewTextBoxColumn.DataPropertyName = "IDE_PROVEEDOR"
        Me.IDEPROVEEDORDataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.IDEPROVEEDORDataGridViewTextBoxColumn.Name = "IDEPROVEEDORDataGridViewTextBoxColumn"
        Me.IDEPROVEEDORDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RAZONSOCIALDataGridViewTextBoxColumn
        '
        Me.RAZONSOCIALDataGridViewTextBoxColumn.DataPropertyName = "RAZON_SOCIAL"
        Me.RAZONSOCIALDataGridViewTextBoxColumn.HeaderText = "RAZON SOCIAL"
        Me.RAZONSOCIALDataGridViewTextBoxColumn.Name = "RAZONSOCIALDataGridViewTextBoxColumn"
        Me.RAZONSOCIALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONTACTODataGridViewTextBoxColumn
        '
        Me.CONTACTODataGridViewTextBoxColumn.DataPropertyName = "CONTACTO"
        Me.CONTACTODataGridViewTextBoxColumn.HeaderText = "CONTACTO"
        Me.CONTACTODataGridViewTextBoxColumn.Name = "CONTACTODataGridViewTextBoxColumn"
        Me.CONTACTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CORREODataGridViewTextBoxColumn
        '
        Me.CORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO"
        Me.CORREODataGridViewTextBoxColumn.HeaderText = "CORREO"
        Me.CORREODataGridViewTextBoxColumn.Name = "CORREODataGridViewTextBoxColumn"
        Me.CORREODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TELEFONODataGridViewTextBoxColumn
        '
        Me.TELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO"
        Me.TELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO"
        Me.TELEFONODataGridViewTextBoxColumn.Name = "TELEFONODataGridViewTextBoxColumn"
        Me.TELEFONODataGridViewTextBoxColumn.ReadOnly = True
        '
        'RUCDataGridViewTextBoxColumn
        '
        Me.RUCDataGridViewTextBoxColumn.DataPropertyName = "RUC"
        Me.RUCDataGridViewTextBoxColumn.HeaderText = "RUC"
        Me.RUCDataGridViewTextBoxColumn.Name = "RUCDataGridViewTextBoxColumn"
        Me.RUCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PROVEEDORBindingSource
        '
        Me.PROVEEDORBindingSource.DataMember = "PROVEEDOR"
        Me.PROVEEDORBindingSource.DataSource = Me.BD_TIENDITADataSet
        '
        'BD_TIENDITADataSet
        '
        Me.BD_TIENDITADataSet.DataSetName = "BD_TIENDITADataSet"
        Me.BD_TIENDITADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "LISTADO PROVEEDOR:"
        '
        'PROVEEDORTableAdapter
        '
        Me.PROVEEDORTableAdapter.ClearBeforeFill = True
        '
        'Listado_de_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 240)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Listado_de_proveedor"
        Me.Text = "Listado de proveedor:"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TIENDITADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BD_TIENDITADataSet As BD_TIENDITADataSet
    Friend WithEvents PROVEEDORBindingSource As BindingSource
    Friend WithEvents PROVEEDORTableAdapter As BD_TIENDITADataSetTableAdapters.PROVEEDORTableAdapter
    Friend WithEvents IDEPROVEEDORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RAZONSOCIALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CORREODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RUCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
