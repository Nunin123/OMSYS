Imports System.Data.SqlClient
Public Class AddCustomer

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lor-raine Manalo\source\repos\OMSys\OMSys.mdf;Integrated Security=True;Connect Timeout=30"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        displayData()
    End Sub
    Public Sub displayData()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Customer"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        frmMainScreen.dgvCustomer.DataSource = dt
    End Sub

    Private Sub btnAddC_Click(sender As Object, e As EventArgs)

    End Sub
End Class