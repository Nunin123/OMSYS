Imports System.Data.SqlClient
Public Class frmMainScreen

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim j As Integer

    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMSysDataSet6.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter1.Fill(Me.OMSysDataSet6.Customer)
        'TODO: This line of code loads data into the 'OMSysDataSet5.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.OMSysDataSet5.Customer)
        'TODO: This line of code loads data into the 'OMSysDataSet4.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter1.Fill(Me.OMSysDataSet4.Stock)
        'TODO: This line of code loads data into the 'OMSysDataSet3.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.OMSysDataSet3.Stock)
        'TODO: This line of code loads data into the 'OMSysDataSet2.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.OMSysDataSet2.Orders)

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lor-raine Manalo\source\repos\OMSys\OMSys.mdf;Integrated Security=True;Connect Timeout=30"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()


        displayCustomerData()
        displayOrderData()
        displayStockData()
    End Sub

    Private Sub btnAddC_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        If txtFname.Text = "" Or txtLname.Text = "" Then
            MessageBox.Show("Incomplete field/s.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Customer values('" +
                txtFname.Text + "','" + txtMname.Text + "','" + txtLname.Text + "','" + txtEmail.Text +
                "','" + txtContactNo.Text + "')"
            cmd.ExecuteNonQuery()

            txtFname.Text = ""
            txtMname.Text = ""
            txtLname.Text = ""
            txtEmail.Text = ""
            txtContactNo.Text = ""

            displayCustomerData()
        End If


    End Sub
    Public Sub displayCustomerData()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Customer"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvCustomer.DataSource = dt
    End Sub

    Public Sub displayStockData()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Stock"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvStock.DataSource = dt
    End Sub

    Public Sub displayOrderData()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Orders"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvOrder.DataSource = dt
    End Sub

    Private Sub btnAddP_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click


        If txtPType.Text = "" Or txtPname.Text = "" Or txtPprice.Text = "" Then
            MessageBox.Show("Incomplete field/s.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Stock values('" +
                txtPType.Text + "','" + txtPname.Text + "','" + txtPprice.Text + "','" + txtPQuantity.Text + "')"
            cmd.ExecuteNonQuery()

            txtPType.Text = ""
            txtPname.Text = ""
            txtPprice.Text = ""
            txtPQuantity.Text = ""
            displayStockData()
        End If

    End Sub

    Private Sub btnAddO_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click

        If txtCId.Text = "" Or txtPid.Text = "" Or txtTPrice.Text = "" Or cboStatus.Text = "" Then
            MessageBox.Show("Incomplete field/s.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Orders values('" +
                txtCId.Text + "','" + txtPid.Text + "','" + txtTPrice.Text + "','" + txtDesc.Text + "','" + cboStatus.Text + "')"
            cmd.ExecuteNonQuery()

            txtCId.Text = ""
            txtPid.Text = ""
            txtTPrice.Text = ""
            txtDesc.Text = ""
            cboStatus.Text = ""

            displayOrderData()
        End If

    End Sub

    Private Sub dgvOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellClick

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(dgvOrder.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Orders where Order_ID = " & i & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read
                txtCId.Text = dr.GetInt32(1).ToString()
                txtPid.Text = dr.GetInt32(2).ToString()
                txtTPrice.Text = dr.GetDecimal(3).ToString()
                txtDesc.Text = dr.GetString(4).ToString()
                cboStatus.Text = dr.GetString(5).ToString()
            End While
        Catch ex As Exception

        End Try



        'If e.ColumnIndex = 1 Then

        'MessageBox.Show("Name: " & getfirstname & "" & getmiddlename & "" & getlastname & vbCrLf &
        '               "Email address: " & getemailadd & vbCrLf &
        '               "Contact number: " & getcontacno)
        'End If
    End Sub

    Private Sub btnUpdateOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Dim choice As DialogResult = MessageBox.Show("Update order details?", "Update", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update Orders set Customer_ID='" + txtCId.Text + "',Product_ID='" + txtPid.Text +
                "',Order_total='" + txtTPrice.Text + "',Order_description='" + txtDesc.Text + "',Order_status='" + cboStatus.Text +
                "' where Order_ID = " & i & ""
            cmd.ExecuteNonQuery()

            txtCId.Text = ""
            txtPid.Text = ""
            txtTPrice.Text = ""
            txtDesc.Text = ""
            cboStatus.Text = ""

            displayOrderData()
        End If
    End Sub

    Private Sub btnDeleteOrder_Click(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        j = Convert.ToInt32(dgvOrder.SelectedCells.Item(0).Value.ToString())

        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from Orders where Order_ID='" & j & "'"
            cmd.ExecuteNonQuery()

            txtCId.Text = ""
            txtPid.Text = ""
            txtTPrice.Text = ""
            txtDesc.Text = ""
            cboStatus.Text = ""

            displayOrderData()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearchOrder.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Orders where Customer_ID='" + txtSearchOrder.Text + "'"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvOrder.DataSource = dt
    End Sub

    Private Sub btnAllOrders_Click(sender As Object, e As EventArgs) Handles btnAllOrders.Click
        displayOrderData()
    End Sub

    Private Sub btnSearchStock_Click(sender As Object, e As EventArgs) Handles btnSearchStock.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Stock where Product_name='" + txtSearchStock.Text + "'"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvStock.DataSource = dt
    End Sub

    Private Sub btnAllStocks_Click(sender As Object, e As EventArgs) Handles btnAllStocks.Click
        displayStockData()
    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Customer where Customer_firstName='" + txtSearchCustomer.Text + "'"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvCustomer.DataSource = dt
    End Sub

    Private Sub btnAllCustomers_Click(sender As Object, e As EventArgs) Handles btnAllCustomers.Click
        displayCustomerData()
    End Sub

    Private Sub dgvStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStock.CellClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(dgvStock.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Stock where Product_ID = " & i & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read
                txtPType.Text = dr.GetString(1).ToString()
                txtPname.Text = dr.GetString(2).ToString()
                txtPprice.Text = dr.GetDecimal(3).ToString()
                txtPQuantity.Text = dr.GetInt32(4).ToString()
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Dim choice As DialogResult = MessageBox.Show("Update product details?", "Update", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update Stock set Product_type='" + txtPType.Text + "',Product_name='" + txtPname.Text +
                "',Product_price='" + txtPprice.Text + "',Quantity='" + txtPQuantity.Text + "' where Product_ID = " & i & ""
            cmd.ExecuteNonQuery()

            txtPType.Text = ""
            txtPname.Text = ""
            txtPprice.Text = ""
            txtPQuantity.Text = ""

            displayStockData()
        End If
    End Sub

    Private Sub btnDeleteStock_Click(sender As Object, e As EventArgs) Handles btnDeleteStock.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        j = Convert.ToInt32(dgvStock.SelectedCells.Item(0).Value.ToString())

        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this stock?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from Stock where Product_ID='" & j & "'"
            cmd.ExecuteNonQuery()

            txtPType.Text = ""
            txtPname.Text = ""
            txtPprice.Text = ""
            txtPQuantity.Text = ""

            displayStockData()
        End If

    End Sub

    Private Sub btnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Dim choice As DialogResult = MessageBox.Show("Update customer details?", "Update", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update Customer set Customer_firstName='" + txtFname.Text + "',Customer_middleName='" + txtMname.Text +
                "',Customer_lastName='" + txtLname.Text + "',Customer_email='" + txtEmail.Text +
                "',Customer_contactNo='" + txtContactNo.Text + "' where Customer_ID = " & i & ""
            cmd.ExecuteNonQuery()

            txtFname.Text = ""
            txtMname.Text = ""
            txtLname.Text = ""
            txtEmail.Text = ""
            txtContactNo.Text = ""

            displayCustomerData()
        End If
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        j = Convert.ToInt32(dgvCustomer.SelectedCells.Item(0).Value.ToString())

        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to remove this customer?", "Remove", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from Customer where Customer_ID='" & j & "'"
            cmd.ExecuteNonQuery()

            txtFname.Text = ""
            txtMname.Text = ""
            txtLname.Text = ""
            txtEmail.Text = ""
            txtContactNo.Text = ""

            displayCustomerData()
        End If
    End Sub

    Private Sub dgvCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(dgvCustomer.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Customer where Customer_ID = " & i & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read
                txtFname.Text = dr.GetString(1).ToString()
                txtMname.Text = dr.GetString(2).ToString()
                txtLname.Text = dr.GetString(3).ToString()
                txtEmail.Text = dr.GetString(4).ToString()
                txtContactNo.Text = dr.GetString(5).ToString()
            End While
        Catch ex As Exception

        End Try
    End Sub
End Class