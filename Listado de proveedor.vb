Public Class Listado_de_proveedor
    Private Sub Listado_de_proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_TIENDITADataSet.PROVEEDOR' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORTableAdapter.Fill(Me.BD_TIENDITADataSet.PROVEEDOR)

    End Sub
End Class