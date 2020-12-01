Imports System.Data.SqlClient
Public Class frmOrderList

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub frmOrderList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMSysDataSet.Order' table. You can move, or remove it, as needed.
        'Me.OrderTableAdapter.Fill(Me.OMSysDataSet.Order)

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lor-raine Manalo\source\repos\OMSys\OMSys.mdf;Integrated Security=True;Connect Timeout=30"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        displayData()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Orders values('" +
            txtCustomerID.Text + "','" + txtProductID.Text + "','" + txtTotalPrice.Text + "','" + txtDescription.Text +
            "','" + txtStatus.Text + "')"
        cmd.ExecuteNonQuery()

        displayData()

    End Sub

    Public Sub displayData()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Orders"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

End Class