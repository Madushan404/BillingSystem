Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports MySql.Data.MySqlClient





Public Class Invantry_All
    Public code As String
    Public n, q As String
    Public connect2 As New MySqlConnection


    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        TryCast(AllGrid.DataSource, DataTable).DefaultView.RowFilter = String.Format(" Name like'%" & TxtSearch.Text & "%'")
    End Sub

    Private Sub Invantry_All_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Create grid view table column
        Dim dt As New DataTable

        dt.Columns.Add("Date")
        dt.Columns.Add("Code")
        dt.Columns.Add("Name")
        dt.Columns.Add("Qantity(g)")
        dt.Columns.Add("Market Price")
        dt.Columns.Add("Our Price")


        'Assing data to da grid cells
        Dim getcolumn As List(Of GridView_clss) = inv_all()
        For Each r As GridView_clss In getcolumn
            dt.Rows.Add(r.D, r.Code, r.C_Name, r.Quentity, r.Market_Price, r.Our_Price)
        Next
        AllGrid.DataSource = dt


        'customize Grid column size
        AllGrid.Columns(0).Width = 250
        AllGrid.Columns(1).Width = 200
        AllGrid.Columns(2).Width = 370
        AllGrid.Columns(3).Width = 200
        AllGrid.Columns(4).Width = 200
        AllGrid.Columns(5).Width = 200

        AllGrid.DataSource.DefaultView.Sort = "Date DESC"
    End Sub




    Private Sub AllGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AllGrid.CellClick

        ' After a cell is clicked, load data to the form
        Try
            ' Get the index of the clicked row
            Dim rowIndex = e.RowIndex

            ' Make sure the click is on a valid row
            If rowIndex >= 0 AndAlso rowIndex < AllGrid.Rows.Count Then
                Dim dr = AllGrid.Rows(rowIndex)

                code = dr.Cells(1).Value.ToString
                n = dr.Cells(2).Value.ToString
                q = dr.Cells(3).Value.ToString



            End If
        Catch ex As Exception
            ' Handle the exception if needed
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click


        Dim query = "DELETE FROM inventory WHERE Name = @name"
        Using str As New MySqlCommand(query, Connect)
            str.Parameters.AddWithValue("@name", n)


            If unique_Item("inventory", "Name", n) = False Then
                'confirm Message to delete data
                Dim response, Msg As String



                Msg = "You're Going To Delete The," & ControlChars.NewLine & ControlChars.NewLine & ControlChars.NewLine & "Item name is : " & n & ControlChars.NewLine & ControlChars.NewLine & "Do You Confirm This?" & ControlChars.NewLine & ControlChars.NewLine & "This Item all data Will be Permanently Deleted. This Process Can't Be Undo"


                response = MessageBox.Show(Msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Error)


                If response = MsgBoxResult.Yes Then

                    str.ExecuteNonQuery()

                    MessageBox.Show("Data Delete process was successfull.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)




                    'Refresh grid 
                    Dim dt As New DataTable

                    dt.Columns.Add("Date")
                    dt.Columns.Add("Code")
                    dt.Columns.Add("Name")
                    dt.Columns.Add("Qantity(g)")
                    dt.Columns.Add("Market Price")
                    dt.Columns.Add("Our Price")


                    'Assing data to da grid cells
                    Dim getcolumn = inv_all()

                    For Each r In getcolumn
                        dt.Rows.Add(r.D, r.Code, r.C_Name, r.Quentity, r.Market_Price, r.Our_Price)
                    Next
                    AllGrid.DataSource = dt


                    'customize Grid column size
                    AllGrid.Columns(0).Width = 250
                    AllGrid.Columns(1).Width = 200
                    AllGrid.Columns(2).Width = 370
                    AllGrid.Columns(3).Width = 200
                    AllGrid.Columns(4).Width = 200
                    AllGrid.Columns(5).Width = 200

                    AllGrid.DataSource.DefaultView.Sort = "Date DESC"



                Else
                    MessageBox.Show("Data delete process NOT successfully.", "Delete Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("That Item is not in the table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        End Using

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Item_Add.Show()


    End Sub




    'reset quentity
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

        Dim query = "UPDATE inventory SET Quantity = 0 WHERE Name = @name"
        Using reset As New MySqlCommand(query, Connect)
            reset.Parameters.AddWithValue("@name", n)



            Dim response, Msg As String

            Msg = "You're Going To Reset Quentity in " & ControlChars.NewLine & ControlChars.NewLine & ControlChars.NewLine & "Item name is : " & n & ControlChars.NewLine & ControlChars.NewLine & "Do You Confirm This?" & ControlChars.NewLine & ControlChars.NewLine & "This Process Can't Be Undo"

            response = MessageBox.Show(Msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Error)


            If response = MsgBoxResult.Yes Then

                reset.ExecuteNonQuery()

                MessageBox.Show("Qentity Reset process was successfull.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)




                'Refresh grid 
                Dim dt As New DataTable

                dt.Columns.Add("Date")
                dt.Columns.Add("Code")
                dt.Columns.Add("Name")
                dt.Columns.Add("Qantity(g)")
                dt.Columns.Add("Market Price")
                dt.Columns.Add("Our Price")


                'Assing data to da grid cells
                Dim getcolumn = inv_all()

                For Each r In getcolumn
                    dt.Rows.Add(r.D, r.Code, r.C_Name, r.Quentity, r.Market_Price, r.Our_Price)
                Next
                AllGrid.DataSource = dt


                'customize Grid column size
                AllGrid.Columns(0).Width = 250
                AllGrid.Columns(1).Width = 200
                AllGrid.Columns(2).Width = 370
                AllGrid.Columns(3).Width = 200
                AllGrid.Columns(4).Width = 200
                AllGrid.Columns(5).Width = 200

                AllGrid.DataSource.DefaultView.Sort = "Date DESC"



            Else
                MessageBox.Show("Quentity Reset process NOT successfully.", "Reset Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End Using
    End Sub
End Class