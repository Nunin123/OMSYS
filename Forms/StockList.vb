Public Class frmStockList
    Private Sub frmStockList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMSysDataSet1.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.OMSysDataSet1.Stock)

    End Sub
End Class