<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnLProveedor = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLMarca = New System.Windows.Forms.Button()
        Me.btnLCategoria = New System.Windows.Forms.Button()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.dgvTienda = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtVencimiento = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.btnEdita = New System.Windows.Forms.Button()
        Me.btnElimina = New System.Windows.Forms.Button()
        Me.btnRegistra = New System.Windows.Forms.Button()
        Me.BD_TIENDITADataSet = New BD_TIENDITA.BD_TIENDITADataSet()
        Me.PRODUCTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTOTableAdapter = New BD_TIENDITA.BD_TIENDITADataSetTableAdapters.PRODUCTOTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TIENDITADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLProveedor
        '
        Me.btnLProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLProveedor.Location = New System.Drawing.Point(-194, 304)
        Me.btnLProveedor.Name = "btnLProveedor"
        Me.btnLProveedor.Size = New System.Drawing.Size(174, 47)
        Me.btnLProveedor.TabIndex = 47
        Me.btnLProveedor.Text = "Listado de proveedor"
        Me.btnLProveedor.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(-95, 251)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(41, 47)
        Me.btnEditar.TabIndex = 41
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(-142, 251)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(41, 47)
        Me.btnEliminar.TabIndex = 40
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(-194, 251)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(41, 47)
        Me.btnRegistrar.TabIndex = 39
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-197, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Fecha de vencimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-197, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-197, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-197, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-197, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-197, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Marca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-196, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Categoria:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(14, 307)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(111, 25)
        Me.ToolStrip1.TabIndex = 69
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(15, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 47)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Listado de proveedor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLMarca
        '
        Me.btnLMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLMarca.Location = New System.Drawing.Point(220, 250)
        Me.btnLMarca.Name = "btnLMarca"
        Me.btnLMarca.Size = New System.Drawing.Size(174, 47)
        Me.btnLMarca.TabIndex = 67
        Me.btnLMarca.Text = "Listado de marca"
        Me.btnLMarca.UseVisualStyleBackColor = True
        '
        'btnLCategoria
        '
        Me.btnLCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLCategoria.Location = New System.Drawing.Point(220, 197)
        Me.btnLCategoria.Name = "btnLCategoria"
        Me.btnLCategoria.Size = New System.Drawing.Size(174, 47)
        Me.btnLCategoria.TabIndex = 66
        Me.btnLCategoria.Text = "Listado de categoria"
        Me.btnLCategoria.UseVisualStyleBackColor = True
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(142, 68)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(254, 21)
        Me.cmbProveedor.TabIndex = 65
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(142, 41)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(254, 21)
        Me.cmbMarca.TabIndex = 64
        '
        'cmbCategoria
        '
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(142, 10)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(254, 21)
        Me.cmbCategoria.TabIndex = 63
        '
        'dgvTienda
        '
        Me.dgvTienda.AllowUserToAddRows = False
        Me.dgvTienda.AllowUserToDeleteRows = False
        Me.dgvTienda.AllowUserToResizeColumns = False
        Me.dgvTienda.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTienda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTienda.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTienda.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgvTienda.Location = New System.Drawing.Point(402, 10)
        Me.dgvTienda.Name = "dgvTienda"
        Me.dgvTienda.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTienda.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTienda.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTienda.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTienda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvTienda.Size = New System.Drawing.Size(803, 320)
        Me.dgvTienda.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Fecha de vencimiento:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Stock"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Precio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Nombre"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Proveedor"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Marca"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Categoria:"
        '
        'txtVencimiento
        '
        Me.txtVencimiento.Location = New System.Drawing.Point(142, 171)
        Me.txtVencimiento.Name = "txtVencimiento"
        Me.txtVencimiento.Size = New System.Drawing.Size(254, 20)
        Me.txtVencimiento.TabIndex = 51
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(142, 145)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(254, 20)
        Me.txtStock.TabIndex = 50
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(142, 119)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(254, 20)
        Me.txtPrecio.TabIndex = 49
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(142, 93)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(254, 20)
        Me.txtNombre.TabIndex = 48
        '
        'lblRegistro
        '
        Me.lblRegistro.AutoSize = True
        Me.lblRegistro.Location = New System.Drawing.Point(386, 317)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(10, 13)
        Me.lblRegistro.TabIndex = 70
        Me.lblRegistro.Text = "."
        '
        'btnEdita
        '
        Me.btnEdita.Image = Global.BD_TIENDITA.My.Resources.Resources.edit
        Me.btnEdita.Location = New System.Drawing.Point(109, 197)
        Me.btnEdita.Name = "btnEdita"
        Me.btnEdita.Size = New System.Drawing.Size(41, 47)
        Me.btnEdita.TabIndex = 62
        Me.btnEdita.UseVisualStyleBackColor = True
        '
        'btnElimina
        '
        Me.btnElimina.Image = Global.BD_TIENDITA.My.Resources.Resources.delete
        Me.btnElimina.Location = New System.Drawing.Point(62, 197)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(41, 47)
        Me.btnElimina.TabIndex = 61
        Me.btnElimina.UseVisualStyleBackColor = True
        '
        'btnRegistra
        '
        Me.btnRegistra.Image = Global.BD_TIENDITA.My.Resources.Resources.apply
        Me.btnRegistra.Location = New System.Drawing.Point(15, 197)
        Me.btnRegistra.Name = "btnRegistra"
        Me.btnRegistra.Size = New System.Drawing.Size(41, 47)
        Me.btnRegistra.TabIndex = 60
        Me.btnRegistra.UseVisualStyleBackColor = True
        '
        'BD_TIENDITADataSet
        '
        Me.BD_TIENDITADataSet.DataSetName = "BD_TIENDITADataSet"
        Me.BD_TIENDITADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTOBindingSource
        '
        Me.PRODUCTOBindingSource.DataMember = "PRODUCTO"
        Me.PRODUCTOBindingSource.DataSource = Me.BD_TIENDITADataSet
        '
        'PRODUCTOTableAdapter
        '
        Me.PRODUCTOTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 343)
        Me.Controls.Add(Me.lblRegistro)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLMarca)
        Me.Controls.Add(Me.btnLCategoria)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.btnEdita)
        Me.Controls.Add(Me.btnElimina)
        Me.Controls.Add(Me.btnRegistra)
        Me.Controls.Add(Me.dgvTienda)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtVencimiento)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnLProveedor)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "REGISTRO DE NUEVO PRODUCTO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TIENDITADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLProveedor As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLMarca As Button
    Friend WithEvents btnLCategoria As Button
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents btnEdita As Button
    Friend WithEvents btnElimina As Button
    Friend WithEvents btnRegistra As Button
    Friend WithEvents dgvTienda As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtVencimiento As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblRegistro As Label
    Friend WithEvents BD_TIENDITADataSet As BD_TIENDITADataSet
    Friend WithEvents PRODUCTOBindingSource As BindingSource
    Friend WithEvents PRODUCTOTableAdapter As BD_TIENDITADataSetTableAdapters.PRODUCTOTableAdapter
End Class
