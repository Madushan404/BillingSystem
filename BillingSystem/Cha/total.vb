Imports MySql.Data.MySqlClient

Public Class total

    Public Shared TextBoxValue As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        upadatetable2()
        sumprice1()
        dgvallbill.ReadOnly = True



        ' If the bill data grid is not empty, execute the code
        TextBoxValue = txttotalbill.Text




    End Sub





    Dim sqldt1 As New DataTable
    Dim sqlrd1 As MySqlDataReader
    Dim sqlcmd1 As New MySqlCommand
    Private Sub upadatetable2()

        Dim todayDate As String = DateTime.Now.ToString("yyyy-MM-dd")

        dgvallbill.DataSource = Nothing
        dgvallbill.Refresh()
        sqldt1.Clear()

        OpenDb()
        sqlcmd1.Connection = conn
        sqlcmd1.CommandText = "SELECT bill_no AS `Bill No`, `Date` AS `Date`, Total AS Total FROM bill WHERE DATE(date) = CURDATE()"
        sqlrd1 = sqlcmd1.ExecuteReader
        sqldt1.Load(sqlrd1)
        sqlrd1.Close()
        CloseDb()

        dgvallbill.DataSource = sqldt1
        dgvallbill.Columns("Bill No").Width = 400 ' Adjust the width as needed
        dgvallbill.Columns("Date").Width = 520 ' Adjust the width as needed
        dgvallbill.Columns("Total").Width = 520 ' Adjust the width as needed

        dgvallbill.BackgroundColor = dgvallbill.Parent.BackColor

    End Sub


    Sub sumprice1()
        Dim to_price As Long
        Dim totalval As Long = 0
        For rawitem As Long = 0 To dgvallbill.RowCount - 1
            totalval = totalval + Val(dgvallbill.Rows(rawitem).Cells(2).Value)
        Next
        to_price = totalval

        txttobill.Text = to_price

    End Sub

End Class