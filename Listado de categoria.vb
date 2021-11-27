Public Class Listado_de_categoria
    Private Sub Listado_de_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_TIENDITADataSet.CATEGORIA' Puede moverla o quitarla según sea necesario.
        Me.CATEGORIATableAdapter.Fill(Me.BD_TIENDITADataSet.CATEGORIA)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class