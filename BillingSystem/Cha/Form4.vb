Imports System.Text
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1

Public Class Form4

    Private Function ContainsSpaceInMiddle(input As String) As Boolean
        For i As Integer = 1 To input.Length - 2
            If input(i) = " " Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub ShowPasswordcb_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordcb.CheckedChanged
        If ShowPasswordcb.Checked = False Then
            Passwordtb.PasswordChar = "*"
        Else
            Passwordtb.PasswordChar = ""
        End If
    End Sub

    Public Sub Test()
        OpenDb()
        Dim dt As New DataTable()
        dt.Columns.Add("User Id")
        dt.Columns.Add("Position")
        dt.Columns.Add("User Name")
        Dim newulist As List(Of userdata) = users()
        For Each r As userdata In newulist
            dt.Rows.Add(r.U_id, r.position, r.username)
        Next

        usersdgv.DataSource = dt
        usersdgv.Columns(0).Width = 250
        usersdgv.Columns(1).Width = 250
        usersdgv.Columns(2).Width = 250
        ''usersdgv.Columns(3).Width = 10
        CloseDb()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Test()
        Dim cus_query As String
        Dim da As New MySqlDataAdapter
        Dim cus_dt As New DataTable
        cus_query = "SELECT `po_Name`,`po_id` FROM `position_tb` "
        da.SelectCommand = New MySqlCommand(cus_query, conn)
        da.Fill(cus_dt)
        Positioncmb.DataSource = cus_dt
        Positioncmb.DisplayMember = "po_Name"
        Positioncmb.ValueMember = "po_id"
    End Sub

    Public Function users() As List(Of userdata)

        Dim u_details As New List(Of userdata)
        Dim command As New MySqlCommand
        Dim A = "SELECT User_ID,User_Name,position_tb.po_name FROM users_tb INNER JOIN position_tb ON users_tb.Position = position_tb.po_id"
        command = New MySqlCommand(A, conn)
        Dim result = command.ExecuteReader
        For Each i In result
            u_details.Add(New userdata With {.U_id = result("User_ID"), .position = result("po_Name"), .username = result("User_Name")})
        Next
        Return u_details
    End Function


    Private Sub usersdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles usersdgv.CellClick
        If e.RowIndex >= 0 Then
            Dim cat As DataGridViewRow
            cat = usersdgv.Rows(e.RowIndex)
            UserIDtb.Text = cat.Cells(0).Value.ToString
            Positioncmb.Text = cat.Cells(1).Value.ToString
            UserNametb.Text = cat.Cells(2).Value.ToString
            ''Passwordtb.Text = cat.Cells(3).Value.ToString
        End If
    End Sub



    Private Sub AddCustomerbtn_Click(sender As Object, e As EventArgs) Handles AddCustomerbtn.Click
        Dim U_name, pass, possi, str As String
        Dim result As Boolean
        U_name = UserNametb.Text.Replace(" ", "")
        pass = Encrypt(Passwordtb.Text.Replace(" ", ""))
        possi = Positioncmb.SelectedValue
        Dim errors As New ArrayList

        If empty(U_name) Then
            errors.Add("Enter User Name")
        End If
        If empty(pass) Then
            errors.Add("Enter Password")
        ElseIf Passwordtb.Text = "" OrElse ContainsSpaceInMiddle(Passwordtb.Text) Then
            errors.Add("Password cannot contain spaces in the middle.")
        End If
        If empty(possi) Then
            errors.Add("Select Possition")
        End If
        If errors.Count < 1 Then
            If MessageBox.Show("Do You want To Add This User?", "Add New User", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                OpenDb()
                str = "INSERT INTO `users_tb`(`Position`, `User_Name`, `Password`)  VALUES (@Posi,@UName,@Pass)"
                ''str = "INSERT INTO `users`(`Position`, `User_Name`, `Password`)  VALUES (@Posi,@UName,MD5(@Pass))"
                Dim command As New MySqlCommand(str, conn)
                command.Parameters.Add("@UName", MySqlDbType.VarChar).Value = U_name
                command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = pass
                command.Parameters.Add("@Posi", MySqlDbType.VarChar).Value = possi
                Try
                    result = command.ExecuteNonQuery()
                    If result = True Then
                        ''MsgBox("New User Added!", vbInformation + vbOKOnly, "Add User")
                        UserNametb.Text = ""
                        Passwordtb.Text = ""
                        Positioncmb.Text = ""
                        command.Parameters.Clear()
                    Else
                        MsgBox("Not added", vbExclamation + vbOKOnly, "Error")
                        UserNametb.Text = ""
                        Passwordtb.Text = ""
                        Positioncmb.Text = ""
                    End If
                Catch ex As Exception
                    MessageBox.Show("This User is Already Registerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    UserNametb.Text = ""
                    Passwordtb.Text = ""
                    Positioncmb.Text = ""
                End Try
            Else
                '' MessageBox.Show(String.Join(Environment.NewLine, errors.ToArray), "Errors Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                UserNametb.Text = ""
                Passwordtb.Text = ""
                Positioncmb.Text = ""

            End If
        Else
            MessageBox.Show(String.Join(Environment.NewLine, errors.ToArray), "Error Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ''MessageBox.Show(" Enter User Details", "Not Added!", MessageBoxButtons.OK)
        End If
        Test()
        CloseDb()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        'If MessageBox.Show("Please enter the Security code for Update user", "Security!", MessageBoxButtons.OKCancel) = DialogResult.OK Then
        '    ' SecurityPasswordlbl.Visible = True
        '    'SecurityPasswordtb.Visible = True

        If SecurityPasswordtb.Text = "admin123" Then

            Dim errors As New ArrayList

            If empty(UserNametb.Text) Then
                errors.Add("Enter User Name")
            End If
            If empty(Passwordtb.Text) Then
                errors.Add("Enter Password")
            ElseIf Passwordtb.Text = "" OrElse ContainsSpaceInMiddle(Passwordtb.Text) Then
                errors.Add("Password cannot contain spaces in the middle.")

            End If
            If empty(Positioncmb.Text) Then
                errors.Add("Select Possition")
            End If

            If errors.Count <= 0 Then
                OpenDb()
                If MessageBox.Show("Do You want To Update selected User?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Dim str1 As String = "UPDATE users_tb SET Position=@position,User_Name=@u_name,Password=@password where User_ID =@u_Id"
                    Dim command As New MySqlCommand(str1, conn)
                    command.Parameters.AddWithValue("@u_Id", UserIDtb.Text.Replace(" ", ""))
                    command.Parameters.AddWithValue("@position", Positioncmb.SelectedValue)
                    command.Parameters.AddWithValue("@u_name", UserNametb.Text.Replace(" ", ""))
                    command.Parameters.AddWithValue("@password", Encrypt(Passwordtb.Text).Replace(" ", ""))

                    Dim res As Boolean
                    res = command.ExecuteNonQuery
                    UserIDtb.Text = ""
                    Positioncmb.Text = ""
                    UserNametb.Text = ""
                    SecurityPasswordtb.Text = ""
                    Passwordtb.Text = ""

                    If res Then
                        MessageBox.Show("Successfully Data Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else

                        MsgBox("Data NOT Updated")
                    End If
                Else
                    UserIDtb.Text = ""
                    Positioncmb.Text = ""
                    UserNametb.Text = ""
                    Passwordtb.Text = ""
                    SecurityPasswordtb.Text = ""
                End If
            Else
                MessageBox.Show(String.Join(Environment.NewLine, errors.ToArray), "Error Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            Test()
            CloseDb()

        Else
            MessageBox.Show("Please enter Correct  Security code for Update user", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            UserIDtb.Text = ""
            Positioncmb.Text = ""
            UserNametb.Text = ""
            Passwordtb.Text = ""
            SecurityPasswordtb.Text = ""
            SecurityPasswordlbl.Visible = False
            SecurityPasswordtb.Visible = False

            SecurityPasswordlbl.Visible = True
            SecurityPasswordtb.Visible = True
        End If









        'Else

        '    UserIDtb.Text = ""
        '    Positioncmb.Text = ""
        '    UserNametb.Text = ""
        '    Passwordtb.Text = ""
        '    SecurityPasswordlbl.Visible = False
        '    SecurityPasswordtb.Visible = False

        'End If










    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim errors As New ArrayList
        If empty(UserNametb.Text) Then
            errors.Add(1)
        ElseIf empty(Positioncmb.Text) Then
            errors.Add(1)
        End If
        If errors.Count <= 0 Then
            OpenDb()
            If MessageBox.Show("Do You want To Delete selected User?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                Dim str1 As String = "DELETE FROM `users_tb` WHERE `User_ID`=@uId"
                Dim command As New MySqlCommand(str1, conn)
                Dim selectone As String
                selectone = UserIDtb.Text
                Dim res As Boolean
                command.Parameters.Add("@uId", MySqlDbType.Int64).Value = selectone
                res = command.ExecuteNonQuery
                If res Then
                    '' MessageBox.Show("Successfully Data Deleted", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim row_index = usersdgv.CurrentRow.Index
                    usersdgv.Rows.RemoveAt(row_index)
                    UserIDtb.Text = ""
                    Positioncmb.Text = ""
                    UserNametb.Text = ""
                    Passwordtb.Text = ""

                End If
            Else
                '' MessageBox.Show("Data Not deleted", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UserIDtb.Text = ""
                Positioncmb.Text = ""
                UserNametb.Text = ""
                Passwordtb.Text = ""
            End If

        Else
            MessageBox.Show("Please Enter Valid Data", "Errors Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CloseDb()
    End Sub

    Private Sub SecurityPasswordtb_TextChanged(sender As Object, e As EventArgs) Handles SecurityPasswordtb.TextChanged

    End Sub
End Class