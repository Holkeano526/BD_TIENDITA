Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Form1
    Dim strcomando As String
    Dim conexion As String
    Dim adapter As SqlDataAdapter
    Dim data As DataSet

    Dim strcomando2 As String
    Dim conexion2 As String
    Dim adapter2 As SqlDataAdapter
    Dim data2 As DataSet

    Dim strcomando3 As String
    Dim conexion3 As String
    Dim adapter3 As SqlDataAdapter
    Dim data3 As DataSet

    Private dtProducto As New BD_TIENDITADataSet.PRODUCTODataTable
    Private taProducto As New BD_TIENDITADataSetTableAdapters.PRODUCTOTableAdapter
    Private registro As BD_TIENDITADataSet.PRODUCTORow
    Private numeroregistro As String
    Private editar As Boolean = False
    Private key As String
    Private Sub btnRegistra_Click(sender As Object, e As EventArgs) Handles btnRegistra.Click
        If (Me.editar) Then
            registro = dtProducto.FindByIDE_PRODUCTO(Me.key)
            registro.IDE_CATEGORIA = cmbCategoria.Text
            registro.IDE_MARCA = cmbMarca.Text
            registro.IDE_PROVEEDOR = cmbProveedor.Text
            registro.NOMBRE = txtNombre.Text
            registro.PRECIO = txtPrecio.Text
            registro.STOCK = txtStock.Text
            registro.FEC_VEN = txtVencimiento.Text

            taProducto.Update(registro)
            Me.editar = False

            txtNombre.Text = ""
            txtPrecio.Text = ""
            txtStock.Text = ""
            txtVencimiento.Text = ""
        Else
            Me.registro = dtProducto.NewPRODUCTORow()
            Me.registro.IDE_CATEGORIA = cmbCategoria.Text
            Me.registro.IDE_MARCA = cmbMarca.Text
            Me.registro.IDE_PROVEEDOR = cmbProveedor.Text
            Me.registro.NOMBRE = txtNombre.Text
            Me.registro.PRECIO = txtPrecio.Text
            Me.registro.STOCK = txtStock.Text
            Me.registro.FEC_VEN = txtVencimiento.Text

            dtProducto.AddPRODUCTORow(Me.registro)
            taProducto.Update(dtProducto)

            txtNombre.Text = ""
            txtPrecio.Text = ""
            txtStock.Text = ""
            txtVencimiento.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_TIENDITADataSet.PRODUCTO' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOTableAdapter.Fill(Me.BD_TIENDITADataSet.PRODUCTO)
        conexion = "Data Source=.;Initial Catalog=BD_TIENDITA;Integrated Security=True"
        strcomando = "select*from categoria"
        adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion)
        data = New DataSet
        adapter.Fill(data)
        cmbCategoria.DataSource = data.Tables(0)
        cmbCategoria.DisplayMember = "ide_categoria"
        cmbCategoria.ValueMember = "ide_categoria"

        conexion2 = "Data Source=.;Initial Catalog=BD_TIENDITA;Integrated Security=True"
        strcomando2 = "select*from marca"
        adapter2 = New System.Data.SqlClient.SqlDataAdapter(strcomando2, conexion2)
        data2 = New DataSet
        adapter2.Fill(data2)
        cmbMarca.DataSource = data2.Tables(0)
        cmbMarca.DisplayMember = "ide_marca"
        cmbMarca.ValueMember = "ide_marca"

        conexion3 = "Data Source=.;Initial Catalog=BD_TIENDITA;Integrated Security=True"
        strcomando3 = "select*from proveedor"
        adapter3 = New System.Data.SqlClient.SqlDataAdapter(strcomando3, conexion3)
        data3 = New DataSet
        adapter3.Fill(data3)
        cmbProveedor.DataSource = data3.Tables(0)
        cmbProveedor.DisplayMember = "ide_proveedor"
        cmbProveedor.ValueMember = "ide_proveedor"

        Me.dtProducto = Me.taProducto.GetData()
        dgvTienda.DataSource = Me.dtProducto
        txtNombre.Focus()
    End Sub

    Private Sub dgvTienda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTienda.CellContentClick

    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Me.registro = dtProducto.Rows(Me.numeroregistro)
        registro.Delete()
        Try
            taProducto.Update(dtProducto)
            MsgBox("Se elimino el producto con exito")
        Catch ex As Exception
            MsgBox("No se pudo eliminar el producto")
        End Try
    End Sub

    Private Sub btnEdita_Click(sender As Object, e As EventArgs) Handles btnEdita.Click
        Me.editar = True
        Me.key = dgvTienda.CurrentRow.Cells.Item(0).Value.ToString()
        cmbCategoria.Text = dgvTienda.CurrentRow.Cells.Item(1).Value.ToString()
        cmbMarca.Text = dgvTienda.CurrentRow.Cells.Item(2).Value.ToString()
        cmbProveedor.Text = dgvTienda.CurrentRow.Cells.Item(3).Value.ToString()
        txtNombre.Text = dgvTienda.CurrentRow.Cells.Item(4).Value.ToString()
        txtPrecio.Text = dgvTienda.CurrentRow.Cells.Item(5).Value.ToString()
        txtStock.Text = dgvTienda.CurrentRow.Cells.Item(6).Value.ToString()
        txtVencimiento.Text = dgvTienda.CurrentRow.Cells.Item(7).Value.ToString()
    End Sub

    Private Sub dgvTienda_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTienda.SelectionChanged
        lblRegistro.Text = dgvTienda.CurrentRow.Index.ToString()
        Me.numeroregistro = dgvTienda.CurrentRow.Index.ToString()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Listado_de_proveedor.Show()
    End Sub

    Private Sub btnLCategoria_Click(sender As Object, e As EventArgs) Handles btnLCategoria.Click
        Listado_de_categoria.Show()
    End Sub

    Private Sub btnLMarca_Click(sender As Object, e As EventArgs) Handles btnLMarca.Click
        Listado_de_marca.Show()
    End Sub
End Class
