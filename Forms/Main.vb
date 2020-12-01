Public Class frmMain
    Private Sub btnManageOrder_Click(sender As Object, e As EventArgs) Handles btnManageOrder.Click
        Dim ManageOrder As New frmOrderList

        ManageOrder.Show()
    End Sub

    Private Sub btnManageStock_Click(sender As Object, e As EventArgs) Handles btnManageStock.Click
        Dim ManageStock As New frmStockList

        ManageStock.Show()
    End Sub
End Class