Imports MySql.Data.MySqlClient

Public Class billdue
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        upadatetable2()
        Dgvafterpay.ReadOnly = True
    End Sub

    Private Sub upadatetable2()
        Dim sqldt1 As New DataTable
        Dim sqlrd1 As MySqlDataReader
        Dim sqlcmd1 As New MySqlCommand
        Dim todayDate As String = DateTime.Now.ToString("yyyy-MM-dd")

        Dgvafterpay.DataSource = Nothing
        Dgvafterpay.Refresh()
        sqldt1.Clear()

        OpenDb()
        sqlcmd1.Connection = conn
        sqlcmd1.CommandText = "SELECT*FROM details_db.after_p_bill Order By Date DESC"
        sqlrd1 = sqlcmd1.ExecuteReader
        sqldt1.Load(sqlrd1)
        sqlrd1.Close()
        CloseDb()

        Dgvafterpay.DataSource = sqldt1

        Dgvafterpay.Columns("bill_no").Width = 200 ' Adjust the width as needed
        Dgvafterpay.Columns("Date").Width = 300 ' Adjust the width as needed
        Dgvafterpay.Columns("Name").Width = 360 ' Adjust the width as needed
        Dgvafterpay.Columns("Ph_Number").Width = 320 ' Adjust the width as needed
        Dgvafterpay.Columns("Total").Width = 320 ' Adjust the width as needed


        Dgvafterpay.Columns("bill_no").HeaderText = "Bill No"
        Dgvafterpay.Columns("Date").HeaderText = "Date"
        Dgvafterpay.Columns("Name").HeaderText = "Customer Name"
        Dgvafterpay.Columns("Ph_Number").HeaderText = "Phone NB"
        Dgvafterpay.Columns("Total").HeaderText = "Total"







        'Dim cellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
        'cellStyle.Font = New Font("Arial", 12) ' You can adjust the font size here
        'Dgvafterpay.DefaultCellStyle = cellStyle

        'For Each column As DataGridViewColumn In Dgvafterpay.Columns
        '    column.HeaderCell.Style.Font = New Font("Arial", 14, FontStyle.Bold) ' You can adjust the font size and style here
        'Next

        Dgvafterpay.BackgroundColor = Dgvafterpay.Parent.BackColor




    End Sub

    Private Sub Btnpay_Click(sender As Object, e As EventArgs) Handles Btnpay.Click
        ' Check if any row is selected
        If Dgvafterpay.SelectedRows.Count > 0 Then
            ' Retrieve the selected row
            Dim selectedRow As DataGridViewRow = Dgvafterpay.SelectedRows(0)

            ' Check if the selected row is not empty
            If Not IsRowEmpty(selectedRow) Then
                ' Extract values from the selected row
                Dim billNo As String = selectedRow.Cells("bill_no").Value.ToString()
                Dim dateValue As String = selectedRow.Cells("Date").Value.ToString()
                Dim name As String = selectedRow.Cells("Name").Value.ToString()
                Dim phoneNu As String = selectedRow.Cells("Ph_Number").Value.ToString()
                Dim total As String = selectedRow.Cells("Total").Value.ToString()

                ' Open database connection
                OpenDb()

                ' Define the SQL command to insert into the new table
                Dim strInsert As String = "INSERT INTO `after_p_bill_tb`(`Date`, `Cus_Name`, `Phone_nb`, `Total`) VALUES (@dateValue,@name,@phoneNu,@total)"

                ' Create MySqlCommand object for insertion
                Dim insertCommand As New MySqlCommand(strInsert, conn)

                ' Add parameters to the insert command
                insertCommand.Parameters.AddWithValue("@dateValue", dateValue)
                insertCommand.Parameters.AddWithValue("@name", name)
                insertCommand.Parameters.AddWithValue("@phoneNu", phoneNu)
                insertCommand.Parameters.AddWithValue("@total", total)

                ' Define the SQL command to delete from the original table
                Dim strDelete As String = "DELETE FROM after_p_bill WHERE bill_no = @billNo AND Name = @name"

                ' Create MySqlCommand object for deletion
                Dim deleteCommand As New MySqlCommand(strDelete, conn)

                ' Add parameters to the delete command
                deleteCommand.Parameters.AddWithValue("@billNo", billNo)
                deleteCommand.Parameters.AddWithValue("@name", name)

                ' Execute the commands in a transaction
                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                Try
                    ' Execute the insert command
                    insertCommand.ExecuteNonQuery()

                    ' Execute the delete command
                    deleteCommand.ExecuteNonQuery()

                    ' Commit the transaction
                    transaction.Commit()

                    MsgBox("Delected!", vbInformation + vbOKOnly, "Data Moved")
                Catch ex As Exception
                    ' Rollback the transaction if an exception occurs
                    transaction.Rollback()
                    MsgBox(ex.Message, vbExclamation + vbOKOnly, "Error")
                Finally
                    ' Dispose commands and close connection
                    insertCommand.Dispose()
                    deleteCommand.Dispose()
                    CloseDb()
                End Try

                ' Remove the row from the DataGridView
                Dgvafterpay.Rows.Remove(selectedRow)
            Else
                MessageBox.Show("Please select a row to move.", "Empty Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select a row to move.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function IsRowEmpty(row As DataGridViewRow) As Boolean
        For Each cell As DataGridViewCell In row.Cells
            If Not String.IsNullOrEmpty(cell.Value?.ToString()) Then
                Return False
            End If
        Next
        Return True
    End Function





    Private Sub Btnsale_Click(sender As Object, e As EventArgs)
        billg.Show()
        Hide()
    End Sub
End Class