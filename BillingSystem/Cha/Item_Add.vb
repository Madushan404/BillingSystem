Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Item_Add


    Private Sub Item_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectdb()

        'Create grid view table column
        Dim dt As New DataTable

        dt.Columns.Add("Item Code")
        dt.Columns.Add("Item Name")
        dt.Columns.Add("Item Sinhala Name")


        'Assing data to da grid cells
        Dim getcolumn As List(Of GridView_clss) = con_tb_NewItem()
        For Each r As GridView_clss In getcolumn
            dt.Rows.Add(r.I_code, r.C_Name, r.I_Name_Sin)
        Next
        NewItemGrid.DataSource = dt

        'customize Grid column size

        NewItemGrid.Columns(0).Width = 250
        NewItemGrid.Columns(1).Width = 350
        NewItemGrid.Columns(2).Width = 350
    End Sub





    Private Sub NewItemGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles NewItemGrid.CellClick
        ' After a cell is clicked, load data to the form
        Try
            ' Get the index of the clicked row
            Dim rowIndex As Integer = e.RowIndex

            ' Make sure the click is on a valid row
            If rowIndex >= 0 AndAlso rowIndex < NewItemGrid.Rows.Count Then
                Dim dr As DataGridViewRow = NewItemGrid.Rows(rowIndex)

                TxtCode.Text = dr.Cells(0).Value.ToString()
                TxtName.Text = dr.Cells(1).Value.ToString()
                TxtNameSin.Text = dr.Cells(2).Value.ToString()
            End If
        Catch ex As Exception
            ' Handle the exception if needed
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub





    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        'Data add to the databace
        Try
            connectdb()

            Dim arrers As New ArrayList


            'validation
            If checkEmpty(TxtCode.Text) = True Then

                If checkEmpty(TxtCode.Text) = True Then
                    ErrorProvider1.SetError(TxtCode, "Item Code is required")
                End If


                If checkEmpty(TxtName.Text) = True Then
                    ErrorProvider2.SetError(TxtName, "Item Name is required")
                End If

                If checkEmpty(TxtNameSin.Text) = True Then
                    ErrorProvider3.SetError(TxtNameSin, "Item Name is required")
                End If

                arrers.Add("Fill required Feald")


            Else

                If VALID_Name(TxtName.Text) = False Then
                    ErrorProvider1.SetError(TxtCode, "Enter Valid Item Code ")
                    arrers.Add("Enter Valid Item Code")
                End If

                If unique_Item("item_tb", "I_Code", TxtCode.Text) = False Then
                    arrers.Add("That item Code already Exsist")
                End If

                'Name validation
                If VALID_Name(TxtName.Text) = False Then
                    ErrorProvider2.SetError(TxtName, "Enter Valid Item Name ")
                    arrers.Add("Enter Valid Item Name")
                End If

                If unique_Item("item_tb", "I_Name", TxtName.Text) = False Then
                    arrers.Add("That item Name already Exsist")
                End If

                'sinhala name validate
                If IsSinhala(TxtNameSin.Text) = False Then
                    ErrorProvider3.SetError(TxtNameSin, "Enter Valid Sinhala Item Name ")
                    arrers.Add("Enter Valid Item Sinhala Name")
                End If

                If unique_Item("item_tb", "I_Name_Sin", TxtNameSin.Text) = False Then
                    arrers.Add("That item Sinhala Name already Exsist")
                End If

            End If


            If arrers.Count >= 1 Then

                MessageBox.Show(String.Join(Environment.NewLine, arrers.ToArray), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else



                Dim para As String
                para = "INSERT INTO item_tb(I_Code,I_Name,I_Name_Sin) VALUES (@ICode,@name,@NameSin);"

                command = New MySqlCommand(para, Connect)

                command.Parameters.AddWithValue("@ICode", TxtCode.Text)
                command.Parameters.AddWithValue("@name", TxtName.Text)
                command.Parameters.AddWithValue("@NameSin", TxtNameSin.Text)


                'check data is entered in the table
                Dim check_add As Integer = command.ExecuteNonQuery()
                If check_add > 0 Then
                    MessageBox.Show("Registration successfully.", "Sucsessful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    '  after registor clear enter data              
                    TxtName.Clear()
                    TxtCode.Clear()
                    TxtNameSin.Clear()
                    ErrorProvider1.SetError(TxtCode, "")
                    ErrorProvider2.SetError(TxtName, "")
                    ErrorProvider3.SetError(TxtNameSin, "")




                Else
                    MessageBox.Show("Registration Fail", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        connectdb()
        'Create grid view table column
        Dim dt As New DataTable

        dt.Columns.Add("Item Code")
        dt.Columns.Add("Item Name")
        dt.Columns.Add("Item Sinhala Name")


        'Assing data to da grid cells
        Dim getcolumn As List(Of GridView_clss) = con_tb_NewItem()
        For Each r As GridView_clss In getcolumn
            dt.Rows.Add(r.I_code, r.C_Name, r.I_Name_Sin)
        Next
        NewItemGrid.DataSource = dt

        'customize Grid column size


        NewItemGrid.Columns(0).Width = 250
        NewItemGrid.Columns(1).Width = 350
        NewItemGrid.Columns(2).Width = 350
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        connectdb()

        Dim query As String = "DELETE FROM item_tb WHERE  I_Name = @name"
        Using cmd As New MySqlCommand(query, Connect)
            cmd.Parameters.AddWithValue("@name", TxtName.Text)

            If unique_Item("item_tb", "I_Name", TxtName.Text) = False Then
                'confirm Message to delete data
                Dim response, Msg, name As String

                name = TxtName.Text

                Msg = "You're Going To Delete The," & ControlChars.NewLine & ControlChars.NewLine & ControlChars.NewLine & "Item name is : " & name & ControlChars.NewLine & ControlChars.NewLine & "Do You Confirm This?" & ControlChars.NewLine & ControlChars.NewLine & "This Item all data Will be Permanently Deleted. This Process Can't Be Undone"


                response = MessageBox.Show(Msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Error)


                If response = MsgBoxResult.Yes Then
                    If unique_Item("inventory", "Name", name) = True Then
                        cmd.ExecuteNonQuery()
                        Connect.Close()
                        MessageBox.Show("Data Delete process was successfull.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("That item Already Save in your Inventry. if you want to delete that item; You should firstly delete it from inventry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MessageBox.Show("Data delete process NOT successfully.", "Delete Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


                End If

            Else
                MessageBox.Show("That Item is not in the table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        End Using


        connectdb()

        'Create grid view table column
        Dim dt As New DataTable

        dt.Columns.Add("Item Code")
        dt.Columns.Add("Item Name")
        dt.Columns.Add("Item Sinhala Name")


        'Assing data to da grid cells
        Dim getcolumn As List(Of GridView_clss) = con_tb_NewItem()
        For Each r As GridView_clss In getcolumn
            dt.Rows.Add(r.I_code, r.C_Name, r.I_Name_Sin)
        Next
        NewItemGrid.DataSource = dt

        'customize Grid column size


        NewItemGrid.Columns(0).Width = 250
        NewItemGrid.Columns(1).Width = 350
        NewItemGrid.Columns(2).Width = 350
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class