Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Test()
    End Sub
    Public Sub Test()
        OpenDb()
        Dim dt As New DataTable()
        dt.Columns.Add("Customer Name")
        dt.Columns.Add("Mobile Number")
        dt.Columns.Add("Other Details")
        Dim newulist As List(Of DatabaseData) = Getusers()

        For Each r As DatabaseData In newulist
            dt.Rows.Add(r.C_name, r.C_Mobile, r.O_Details)
        Next

        CustomerDetailsdgv.DataSource = dt
        'CustomerDetailsdgv.Columns(0).Width = 150
        CustomerDetailsdgv.Columns(0).Width = 270
        CustomerDetailsdgv.Columns(1).Width = 200
        CustomerDetailsdgv.Columns(2).Width = 310
        CloseDb()
    End Sub

    Private Sub AddCustomerbtn_Click(sender As Object, e As EventArgs) Handles AddCustomerbtn.Click
        Dim C_name, O_Details, str As String
        Dim C_Mobile As String
        Dim result As Boolean
        C_name = CustomerNametb.Text.Replace(" ", "")
        C_Mobile = MobileNumbertb.Text.Replace(" ", "")
        O_Details = OtherDetailstb.Text.Replace(" ", "")
        Dim errors As New ArrayList
        Dim regex1 As Regex = New Regex("^([0-9]{10})$")

        If Not regex1.IsMatch(MobileNumbertb.Text.Trim()) Then
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
            OpenDb()
            str = "INSERT INTO `customer_tb`(`Customer_Name`, `Mobile_Number`, `Other_Details`) VALUES (@C_Name,@C_Mobile,@O_Details)"
            ''' Insert data into Customer Table
            Dim command As New MySqlCommand(str, conn)
            command.Parameters.Add("@C_Name", MySqlDbType.VarChar).Value = C_name
            command.Parameters.Add("@C_Mobile", MySqlDbType.Int64).Value = C_Mobile
            command.Parameters.Add("@O_Details", MySqlDbType.VarChar).Value = O_Details
            Try
                result = command.ExecuteNonQuery()
                If result = True Then
                    MsgBox("New Customer added!", vbInformation + vbOKOnly, "Add Customer")
                    '''After the data insert All the textboxs will clear their datas
                    CustomerNametb.Text = ""
                    MobileNumbertb.Text = ""
                    OtherDetailstb.Text = ""
                    command.Parameters.Clear()
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

        CloseDb()
        Test()
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
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        SearchCustomertb.Text = ""
    End Sub


End Class
