Public Class Listado_de_marca
    Private Sub Listado_de_marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_TIENDITADataSet.MARCA' Puede moverla o quitarla según sea necesario.
        Me.MARCATableAdapter.Fill(Me.BD_TIENDITADataSet.MARCA)

    End Sub
End Class