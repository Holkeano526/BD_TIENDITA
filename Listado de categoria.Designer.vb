<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_de_categoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listado_de_categoria))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDECATEGORIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TIENDITADataSet = New BD_TIENDITA.BD_TIENDITADataSet()
        Me.CATEGORIATableAdapter = New BD_TIENDITA.BD_TIENDITADataSetTableAdapters.CATEGORIATableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TIENDITADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "LISTADO DE CATEGORIAS:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDECATEGORIADataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CATEGORIABindingSource
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(11, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(243, 183)
        Me.DataGridView1.TabIndex = 26
        '
        'IDECATEGORIADataGridViewTextBoxColumn
        '
        Me.IDECATEGORIADataGridViewTextBoxColumn.DataPropertyName = "IDE_CATEGORIA"
        Me.IDECATEGORIADataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.IDECATEGORIADataGridViewTextBoxColumn.Name = "IDECATEGORIADataGridViewTextBoxColumn"
        Me.IDECATEGORIADataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CATEGORIABindingSource
        '
        Me.CATEGORIABindingSource.DataMember = "CATEGORIA"
        Me.CATEGORIABindingSource.DataSource = Me.BD_TIENDITADataSet
        '
        'BD_TIENDITADataSet
        '
        Me.BD_TIENDITADataSet.DataSetName = "BD_TIENDITADataSet"
        Me.BD_TIENDITADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CATEGORIATableAdapter
        '
        Me.CATEGORIATableAdapter.ClearBeforeFill = True
        '
        'Listado_de_categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 240)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Listado_de_categoria"
        Me.Text = "Listado de categoria:"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TIENDITADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BD_TIENDITADataSet As BD_TIENDITADataSet
    Friend WithEvents CATEGORIABindingSource As BindingSource
    Friend WithEvents CATEGORIATableAdapter As BD_TIENDITADataSetTableAdapters.CATEGORIATableAdapter
    Friend WithEvents IDECATEGORIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
