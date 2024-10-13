Imports MySql.Data.MySqlClient

Public Class Inventry_user
    Public code As String
    Public n, q As String
    Public connect2 As New MySqlConnection




    Private Sub Inventry_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub AllGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AllGrid.CellContentClick
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

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Item_Add.Show()
    End Sub
End Class