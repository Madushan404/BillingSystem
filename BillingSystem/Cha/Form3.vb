Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient

Public Class Form3

    Public Sub Test()
        OpenDb()
        Dim dt As New DataTable()
        dt.Columns.Add("Customer ID")
        dt.Columns.Add("Customer Name")
        dt.Columns.Add("Mobile Number")
        dt.Columns.Add("Other Details")
        Dim newulist As List(Of DatabaseData) = Getusers()

        For Each r As DatabaseData In newulist
            dt.Rows.Add(r.C_Id, r.C_name, r.C_Mobile, r.O_Details)
        Next

        CustomerDetailsdgv.DataSource = dt
        CustomerDetailsdgv.Columns(0).Width = 270
        CustomerDetailsdgv.Columns(1).Width = 300
        CustomerDetailsdgv.Columns(2).Width = 310
        CustomerDetailsdgv.Columns(3).Width = 310

        CustomerDetailsdgv.Columns(0).Visible = False

        CloseDb()

    End Sub

    Private Sub CustomerDetailsdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDetailsdgv.CellClick
        If e.RowIndex >= 0 Then
            Dim cat As DataGridViewRow
            cat = CustomerDetailsdgv.Rows(e.RowIndex)
            Idtb.Text = cat.Cells(0).Value.ToString
            CustomerNametb.Text = cat.Cells(1).Value.ToString
            MobileNumbertb.Text = cat.Cells(2).Value.ToString
            OtherDetailstb.Text = cat.Cells(3).Value.ToString
        End If
    End Sub



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Test()
    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        Dim errors As New ArrayList
        If empty(CustomerNametb.Text) Then
            errors.Add(1)
        ElseIf empty(MobileNumbertb.Text) Then
            errors.Add(1)
        End If
        If errors.Count <= 0 Then
            OpenDb()

            If MessageBox.Show("Do You want To Delete selected Customer?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                Dim str1 = "DELETE FROM `customer_tb` WHERE `Customer_ID`=@CId"
                Dim command As New MySqlCommand(str1, conn)
                Dim selectone As String
                selectone = Idtb.Text
                Dim res As Boolean
                command.Parameters.Add("@CId", MySqlDbType.Int64).Value = selectone
                res = command.ExecuteNonQuery
                If res Then
                    '' MessageBox.Show("Successfully Data Deleted", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim row_index = CustomerDetailsdgv.CurrentRow.Index
                    CustomerDetailsdgv.Rows.RemoveAt(row_index)
                    Idtb.Text = ""
                    CustomerNametb.Text = ""
                    MobileNumbertb.Text = ""
                    OtherDetailstb.Text = ""

                End If
            Else
                '' MessageBox.Show("Data Not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Idtb.Text = ""
                CustomerNametb.Text = ""
                MobileNumbertb.Text = ""
                OtherDetailstb.Text = ""
            End If

        Else
            MessageBox.Show("Please Enter Valid Data", "Errors Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CloseDb()
    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn2.Click
        Dim errors As New ArrayList
        If empty(CustomerNametb.Text) Then
            errors.Add(1)
        ElseIf empty(MobileNumbertb.Text) Then
            errors.Add(1)
        End If
        If errors.Count <= 0 Then

            OpenDb()
            If MessageBox.Show("Do You want To Update selected Customer?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then


                Dim str1 As String = "UPDATE `customer_tb` SET `Customer_Name`=@C_name,`Mobile_Number`=@S_Mobile,`Other_Details`=@O_Details where Customer_ID =@C_Id"
                Dim command As New MySqlCommand(str1, conn)
                command.Parameters.AddWithValue("@C_Id", Idtb.Text)
                command.Parameters.AddWithValue("@C_name", CustomerNametb.Text.Replace(" ", ""))
                command.Parameters.AddWithValue("@S_Mobile", MobileNumbertb.Text.Replace(" ", ""))
                command.Parameters.AddWithValue("@O_Details", OtherDetailstb.Text.Replace(" ", ""))

                Dim res As Boolean

                res = command.ExecuteNonQuery
                Idtb.Text = ""
                CustomerNametb.Text = ""
                MobileNumbertb.Text = ""
                OtherDetailstb.Text = ""

                If res Then
                    ''MessageBox.Show("Successfully Data Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    ''MsgBox("Data NOT Updated")
                End If
            Else
                Idtb.Text = ""
                CustomerNametb.Text = ""
                MobileNumbertb.Text = ""
                OtherDetailstb.Text = ""
            End If
        Else
            MessageBox.Show("Please Enter Valid Data", "Errors Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CloseDb()

        Test()
    End Sub
    Private Sub Form3_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        SearchCustomertb.Text = ""
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click, Button1.Click
        Idtb.Text = ""
        CustomerNametb.Text = ""
        MobileNumbertb.Text = ""
        OtherDetailstb.Text = ""
        SearchCustomertb.Text = ""
    End Sub
    Private Sub SearchCustomertbTextChanged(sender As Object, e As EventArgs) Handles SearchCustomertb.TextChanged
        ' Perform the search dynamically as the user types
        PerformSearch()
    End Sub
    Private Sub PerformSearch()
        Try
            OpenDb()
            Dim query As String = "SELECT * FROM `customer_tb` WHERE Customer_Name LIKE @SearchTerm OR Mobile_Number LIKE @SearchTerm1"
            Using Command As New MySqlCommand(query, conn)
                ' Set the parameter value with the search term
                Command.Parameters.AddWithValue("@SearchTerm", "%" & SearchCustomertb.Text & "%")
                Command.Parameters.AddWithValue("@SearchTerm1", "%" & SearchCustomertb.Text & "%")
                ' Create a SqlDataAdapter to fill a DataTable with the results
                Using adapter As New MySqlDataAdapter(Command)
                    Dim dataTable As New DataTable()

                    ' Fill the DataTable with the results
                    adapter.Fill(dataTable)

                    ' Display the results in the DataGridView
                    CustomerDetailsdgv.DataSource = dataTable
                End Using
            End Using
            CloseDb()
        Catch ex As Exception
            MessageBox.Show("Enter Correct data: " & ex.Message)
        End Try
    End Sub

    Private Sub AddCustomerbtn_Click_1(sender As Object, e As EventArgs) Handles AddCustomerbtn2.Click
        Dim C_name, O_Details, str As String
        Dim C_Mobile As String
        Dim result As Boolean
        C_name = CustomerNametb.Text.Replace(" ", "")
        C_Mobile = MobileNumbertb.Text.Replace(" ", "")
        O_Details = OtherDetailstb.Text.Replace(" ", "")
        Dim errors As New ArrayList
        Dim regex1 = New Regex("^([0-9]{10})$")

        If Not regex1.IsMatch(MobileNumbertb.Text.Trim) Then
            errors.Add("Please Enter Valid Mobile Number!")
            ErrorProvider1.SetError(MobileNumbertb, "Please Enter Valid Mobile Number!")
        Else
            ErrorProvider1.SetError(MobileNumbertb, String.Empty)
        End If

        If empty(C_name) Then
            errors.Add("Customer Name is Required!")
            ErrorProvider2.SetError(CustomerNametb, "Please Enter Customer Name!")
        Else
            ErrorProvider2.SetError(CustomerNametb, String.Empty)
        End If

        If empty(C_Mobile) Then
            ''errors.Add("Customer Mobile Number is Required")
            errors.Add("")
        End If

        If errors.Count < 1 Then
            OpenDb
            str = "INSERT INTO `customer_tb`(`Customer_Name`, `Mobile_Number`, `Other_Details`) VALUES (@C_Name,@C_Mobile,@O_Details)"
            ''' Insert data into Customer Table
            Dim command As New MySqlCommand(str, conn)
            command.Parameters.Add("@C_Name", MySqlDbType.VarChar).Value = C_name
            command.Parameters.Add("@C_Mobile", MySqlDbType.Int64).Value = C_Mobile
            command.Parameters.Add("@O_Details", MySqlDbType.VarChar).Value = O_Details
            Try
                result = command.ExecuteNonQuery
                If result = True Then
                    MsgBox("New Customer added!", vbInformation + vbOKOnly, "Add Customer")
                    '''After the data insert All the textboxs will clear their datas
                    CustomerNametb.Text = ""
                    MobileNumbertb.Text = ""
                    OtherDetailstb.Text = ""
                    command.Parameters.Clear
                Else
                    MsgBox("Customer Not added", vbExclamation + vbOKOnly, "Error")

                End If
            Catch ex As Exception
                MessageBox.Show("This customer is Already Registerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CustomerNametb.Text = ""
                MobileNumbertb.Text = ""
                OtherDetailstb.Text = ""
            End Try
        Else
            ''MessageBox.Show(String.Join(Environment.NewLine, errors.ToArray), "Pleace Enter Valid Details!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        CloseDb
        Test
    End Sub

End Class