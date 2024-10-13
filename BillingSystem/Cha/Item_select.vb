
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Imports Mysqlx.XDevAPI.Common

Public Class Item_select




    Public command2 As New MySqlCommand
    Public command As MySqlCommand
    Public command1 As MySqlCommand





    Private Sub Item_select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectdb()

        Dim day_today As Date = DateTime.Now

        'auto update active column
        Dim str As String = "UPDATE inventory SET Date=@date,active=0 WHERE Date < CURDATE()"
        command = New MySqlCommand(str, connect1)
        command.Parameters.AddWithValue("@date", day_today)
        command.ExecuteReader()
        connect1.close()



        'load today list to not selected item name

        Dim str1 As String = "SELECT item_tb.I_Name FROM item_tb LEFT JOIN inventory ON item_tb.I_Name = inventory.Name WHERE inventory.I_Code  IS NULL or inventory.active = 0;"
        command = New MySqlCommand(str1, Connect)
        Dim a = command.ExecuteReader()
        While a.Read()
            Item_List.Items.Add(a(0))
        End While
        a.Close()






        'inventry update part



        'enter default value for text boxes
        TxtKg.Text = 0
        TxtG.Text = 0
        TxtMPrice.Text = 0
        TxtOPrice.Text = 0


        connectdb()

        Try
            ' Replace "YourTableName" and "YourColumnName" with the actual table and column names
            Dim query As String = "SELECT Name FROM inventory WHERE active=1;"
            Using command2 As New MySqlCommand(query, Connect)
                Using reader As MySqlDataReader = command2.ExecuteReader()
                    While reader.Read()
                        ' Add each item from the column to the ComboBox
                        NameCombo.Items.Add(reader.GetString("Name"))
                    End While
                End Using
            End Using

        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error: " & ex.Message)
        End Try


        'Create grid view table column
        Dim dt As New DataTable
        dt.Columns.Add("Date")
        dt.Columns.Add("Code")
        dt.Columns.Add("Name")
        dt.Columns.Add("Sinhla Name")
        dt.Columns.Add("Qantity(g)")
        dt.Columns.Add("Market Price")
        dt.Columns.Add("Our Price")


        'Assing data to da grid cells
        Dim getcolumn As List(Of GridView_clss) = con_table()
        For Each r As GridView_clss In getcolumn
            dt.Rows.Add(r.D, r.Code, r.C_Name, r.I_Name_Sin, r.Quentity, r.Market_Price, r.Our_Price)
        Next
        ItemGrid.DataSource = dt


        'customize Grid column size
        ItemGrid.Columns(0).Width = 250
        ItemGrid.Columns(1).Width = 100
        ItemGrid.Columns(2).Width = 250
        ItemGrid.Columns(3).Width = 250
        ItemGrid.Columns(4).Width = 100
        ItemGrid.Columns(5).Width = 100
        ItemGrid.Columns(6).Width = 100


        ItemGrid.DataSource.DefaultView.Sort = "Date DESC"





    End Sub










    Private Sub Item_List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item_List.SelectedIndexChanged

        Selected_List.Items.Clear()
        For item As Integer = 0 To Item_List.CheckedItems.Count - 1
            Selected_List.Items.Add(Item_List.CheckedItems(item))
        Next


    End Sub



    Public check_add As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveTodayBtn.Click
        connectdb()

        Dim day_t As Date = DateTime.Now

        Dim itemsToRemove As New List(Of Object)
        Try
            For Each item As Object In Selected_List.Items


                If unique_Item("inventory", "Name", item) = True Then

                    connectdb()

                    ' Get Item Code


                    Dim get_code As String = "SELECT I_Code FROM item_tb WHERE I_Name=@code;"
                    command1 = New MySqlCommand(get_code, connect2)
                    command1.Parameters.AddWithValue("@code", item)
                    Dim out As MySqlDataReader = command1.ExecuteReader()




                    'get Item Sinhala name

                    Dim get_SName As String = "SELECT I_Name_Sin FROM item_tb WHERE I_Name=@name;"
                    command2 = New MySqlCommand(get_SName, Connect3)
                    command2.Parameters.AddWithValue("@name", item)
                    Dim S_Name As MySqlDataReader = command2.ExecuteReader()




                    If out.HasRows Then
                        out.Read()
                        Dim itemCode As String = out.GetString("I_Code")
                        out.Close()
                        S_Name.Read()
                        Dim SName As String = S_Name.GetString("I_Name_Sin")
                        S_Name.Close()






                        If unique_Item("inventory", "Name", item) = True Then



                            'INSERT into inventory


                            Dim inventry As String = "INSERT INTO inventory ( Date,I_Code, Name, S_Name, Quantity, M_Price, O_Price,active) VALUES ( @date,@i_Code, @i_Name,@S_name, 0, 0, 0,1);"
                            command = New MySqlCommand(inventry, connect1)
                            command.Parameters.AddWithValue("@date", day_t)
                            command.Parameters.AddWithValue("@i_Code", itemCode)
                            command.Parameters.AddWithValue("@i_Name", item)
                            command.Parameters.AddWithValue("@S_name", SName)
                            check_add = command.ExecuteNonQuery()


                        End If

                    End If


                Else

                    'if already avilible name in table only update active column

                    Dim str As String = "UPDATE inventory SET active = 1 WHERE Name = @item;"
                    Using command As New MySqlCommand(str, connect1)
                        command.Parameters.AddWithValue("@item", item)
                        check_add = command.ExecuteNonQuery()
                    End Using


                End If

            Next




            If check_add > 0 Then

                'output successfull msg

                MessageBox.Show("Today list successfully added .", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Selected_List.Items.Clear()




                'refresh the inventry update part
                'enter default value for text boxes
                TxtKg.Text = 0
                TxtG.Text = 0
                TxtMPrice.Text = 0
                TxtOPrice.Text = 0

                connectdb()

                Try
                    ' Replace "YourTableName" and "YourColumnName" with the actual table and column names
                    Dim query As String = "SELECT Name FROM inventory WHERE active=1;"
                    Using command2 As New MySqlCommand(query, Connect)
                        Using reader As MySqlDataReader = command2.ExecuteReader()
                            While reader.Read()
                                ' Add each item from the column to the ComboBox
                                NameCombo.Items.Add(reader.GetString("Name"))
                            End While
                        End Using
                    End Using

                Catch ex As Exception
                    ' Handle exceptions
                    MessageBox.Show("Error: " & ex.Message)
                End Try



                'Create grid view table column
                Dim dt As New DataTable
                dt.Columns.Add("Date")
                dt.Columns.Add("Code")
                dt.Columns.Add("Name")
                dt.Columns.Add("Sinhla Name")
                dt.Columns.Add("Qantity(g)")
                dt.Columns.Add("Market Price")
                dt.Columns.Add("Our Price")


                'Assing data to da grid cells
                Dim getcolumn As List(Of GridView_clss) = con_table()
                For Each r As GridView_clss In getcolumn
                    dt.Rows.Add(r.D, r.Code, r.C_Name, r.I_Name_Sin, r.Quentity, r.Market_Price, r.Our_Price)
                Next
                ItemGrid.DataSource = dt


                'customize Grid column size
                ItemGrid.Columns(0).Width = 250
                ItemGrid.Columns(1).Width = 100
                ItemGrid.Columns(2).Width = 250
                ItemGrid.Columns(3).Width = 250
                ItemGrid.Columns(4).Width = 100
                ItemGrid.Columns(5).Width = 100
                ItemGrid.Columns(6).Width = 100


                ItemGrid.DataSource.DefaultView.Sort = "Date DESC"


            Else
                MessageBox.Show("Today list NOT added", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SelectAllCheck_CheckedChanged(sender As Object, e As EventArgs) Handles SelectAllCheck.CheckedChanged
        If SelectAllCheck.Checked Then
            ' Select all items in the ListBox
            For i As Integer = 0 To Item_List.Items.Count - 1
                Item_List.SetItemChecked(i, True)

            Next
        Else

            For i As Integer = 0 To Item_List.Items.Count - 1
                Item_List.SetItemChecked(i, False)

            Next
        End If
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        ' Loop through each item in the CheckedListBox
        For i As Integer = 0 To Item_List.Items.Count - 1
            ' Check if the item's text matches the search value (case-insensitive comparison)
            If Item_List.Items(i).ToString().ToLower() = TxtSearch.Text.ToLower() Then
                ' Check the item if found
                Item_List.SetSelected(i, True)
                Exit Sub ' Exit the loop since we found a match
            End If
        Next
    End Sub







    'inventry update part


    Private Sub BtnUpdate_Click_1(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim Name, code, quentity, msg, response As String
        Dim M_price, O_price As Integer
        Dim arrers As New ArrayList


        'validation
        If checkEmpty(TxtCode.Text) Or checkEmpty(TxtKg.Text) Or checkEmpty(TxtG.Text) Or checkEmpty(TxtMPrice.Text) Or checkEmpty(TxtOPrice.Text) Or combo_empty(NameCombo) = True Then

            If checkEmpty(TxtCode.Text) = True Then
                ErrorProvider1.SetError(TxtCode, "Item Code is required")
            End If
            If combo_empty(NameCombo) = True Then
                ErrorProvider2.SetError(NameCombo, "Item name is required")
            End If

            If checkEmpty(TxtG.Text) = True Then
                ErrorProvider3.SetError(TxtG, "Quentity is required")
            End If
            If checkEmpty(TxtKg.Text) = True Then
                ErrorProvider4.SetError(TxtKg, "Quentity is required")
            End If

            If checkEmpty(TxtMPrice.Text) = True Then
                ErrorProvider5.SetError(TxtMPrice, "Market Price is required")
            End If
            If checkEmpty(TxtOPrice.Text) = True Then
                ErrorProvider6.SetError(TxtOPrice, "Our Price is required")
            End If
            arrers.Add("You should Enter values to all filds")
        Else
            If numlen(TxtKg.Text) = False Then
                arrers.Add("Enter valide Kg.")

            End If


            ' If emp_kg(TxtKg.Text, TxtG.Text) = True Then
            'arrers.Add("Enter vlid Qantity")

            'End If

            If Valid_g(TxtG.Text) = False Then
                arrers.Add("Enter valide g.")

            End If



            If ValidPrice(TxtMPrice.Text) = False Then
                arrers.Add("Enter Valid Market Price")
            End If

            If ValidPrice(TxtOPrice.Text) = False Then
                arrers.Add("Enter Valid Our Price")
            End If

        End If

        If arrers.Count >= 1 Then

            MessageBox.Show(String.Join(Environment.NewLine, arrers.ToArray), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim d = Date.Now
            Name = NameCombo.SelectedItem()
            code = TxtCode.Text.ToString()
            quentity = combine_kg(TxtKg.Text, TxtG.Text)
            M_price = TxtMPrice.Text.ToString()
            O_price = TxtOPrice.Text.ToString()


            connectdb()
            Dim updates = "UPDATE `inventory` SET `Date`=@Date, `Quantity`=`Quantity` + @Quentity, `M_Price`=@MPrice, `O_Price`=@OPrice WHERE I_Code = @Code"
            Dim command As New MySqlCommand(updates, Connect)

            command.Parameters.AddWithValue("@Date", d)
            command.Parameters.AddWithValue("@Quentity", quentity)
            command.Parameters.AddWithValue("@MPrice", M_price)
            command.Parameters.AddWithValue("@OPrice", O_price)
            command.Parameters.AddWithValue("@Code", code)



            msg = "You're Going To Update The," & ControlChars.NewLine & ControlChars.NewLine & ControlChars.NewLine & "Item Code is : " & code & ControlChars.NewLine & ControlChars.NewLine & "Item name is : " & Name & ControlChars.NewLine & ControlChars.NewLine & "Quentity is : " & quentity & ControlChars.NewLine & ControlChars.NewLine & "Do You Confirm This?" & ControlChars.NewLine & ControlChars.NewLine & "This Item all data Will be Update."
            response = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If response = MsgBoxResult.Yes Then
                command.ExecuteNonQuery()

                'hide error provider after data update

                ErrorProvider1.SetError(TxtCode, "")
                ErrorProvider2.SetError(NameCombo, "")
                ErrorProvider3.SetError(TxtG, "")
                ErrorProvider4.SetError(TxtKg, "")
                ErrorProvider5.SetError(TxtMPrice, "")
                ErrorProvider6.SetError(TxtOPrice, "")



                'clear text box
                TxtCode.Clear()
                TxtG.Text = 0
                TxtKg.Text = 0
                TxtMPrice.Text = 0
                TxtOPrice.Text = 0
                TxtSerch.Clear()
                NameCombo.Text = ""


                'refresh data gride view
                connectdb()


                'Create grid view table column
                Dim dt As New DataTable
                dt.Columns.Add("Date")
                dt.Columns.Add("Code")
                dt.Columns.Add("Name")
                dt.Columns.Add("Sinhla Name")
                dt.Columns.Add("Qantity(g)")
                dt.Columns.Add("Market Price")
                dt.Columns.Add("Our Price")


                'Assing data to da grid cells
                Dim getcolumn As List(Of GridView_clss) = con_table()
                For Each r As GridView_clss In getcolumn
                    dt.Rows.Add(r.D, r.Code, r.C_Name, r.I_Name_Sin, r.Quentity, r.Market_Price, r.Our_Price)
                Next
                ItemGrid.DataSource = dt


                'customize Grid column size
                ItemGrid.Columns(0).Width = 250
                ItemGrid.Columns(1).Width = 100
                ItemGrid.Columns(2).Width = 250
                ItemGrid.Columns(3).Width = 250
                ItemGrid.Columns(4).Width = 100
                ItemGrid.Columns(5).Width = 100
                ItemGrid.Columns(6).Width = 100


                ItemGrid.DataSource.DefaultView.Sort = "Date DESC"

            Else
                MessageBox.Show("Data Update process NOT successfully.", "Update Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If
    End Sub

    Private Sub ItemGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemGrid.CellClick
        Try
            ' Get the index of the clicked row
            Dim rowIndex = e.RowIndex


            If rowIndex >= 0 AndAlso rowIndex < ItemGrid.Rows.Count Then
                Dim dr = ItemGrid.Rows(rowIndex)
                DateTimePicker.Value = Convert.ToDateTime(dr.Cells(0).Value)
                TxtCode.Text = dr.Cells(1).Value.ToString
                NameCombo.Text = dr.Cells(2).Value.ToString
                TxtKg.Text = Math.Floor(dr.Cells(4).Value / 1000)
                TxtG.Text = dr.Cells(4).Value Mod 100
                TxtMPrice.Text = dr.Cells(5).Value.ToString
                TxtOPrice.Text = dr.Cells(6).Value.ToString
            End If
        Catch ex As Exception
            ' Handle the exception if needed
            MessageBox.Show("Cell Click Error" & ex.Message)
        End Try
    End Sub


    Private Sub TxtSerch_TextChanged_1(sender As Object, e As EventArgs) Handles TxtSerch.TextChanged
        TryCast(ItemGrid.DataSource, DataTable).DefaultView.RowFilter = String.Format("Name like'%" & TxtSerch.Text & "%'")
    End Sub

    Private Sub NameCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameCombo.SelectedIndexChanged

        'get row index according to combobox selection
        Dim rowIndex = GetRowIndexByCondition(ItemGrid, "Name", NameCombo.SelectedItem.ToString)


        If rowIndex >= 0 Then
            Dim dr = ItemGrid.Rows(rowIndex)
            DateTimePicker.Value = Convert.ToDateTime(dr.Cells(0).Value)
            TxtCode.Text = get_code(NameCombo.SelectedItem)
            TxtKg.Text = Math.Floor(dr.Cells(4).Value / 1000)
            TxtG.Text = dr.Cells(4).Value Mod 100
            TxtMPrice.Text = dr.Cells(5).Value.ToString
            TxtOPrice.Text = dr.Cells(6).Value.ToString
        Else
            MessageBox.Show("Your Selected Value not in the table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
End Class