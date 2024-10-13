Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Loginbtn_Click_1(sender As Object, e As EventArgs) Handles Loginbtn.Click

        Dim uname, pass As String
            Dim posi As String
            uname = UserNametb.Text
            pass = Passwordtb.Text
            posi = Positioncmb.SelectedValue
            Dim errors As New ArrayList

            If empty(posi) Then
                ErrorProvider1.SetError(Positioncmb, "Please Select Position")
            Else
                ErrorProvider1.SetError(Positioncmb, String.Empty)
            End If

            If empty(uname) Then

                errors.Add("Please Enter User Name")

            End If
            If empty(pass) Then

                errors.Add("Please Enter Password")

            End If

            If errors.Count < 1 Then
                OpenDb()
                Dim Str As String
            '  Dim depass = Encrypt(Passwordtb.Text)
            Str = "SELECT * FROM users_tb WHERE Position = '" & posi & "' and User_name = '" & UserNametb.Text & "' and Password = '" & pass & "'"
            Dim command As New MySqlCommand(Str, conn)
                Dim adap As MySqlDataAdapter = New MySqlDataAdapter(command)
                Dim dt As DataTable = New DataTable()
                adap.Fill(dt)

                If (dt.Rows.Count > 0) Then
                    '' MessageBox.Show("log in as " + dt.Rows(0)(2))
                    If Positioncmb.SelectedIndex = 0 Then
                        'MessageBox.Show("Login as admin")
                        UserNametb.Text = ""
                        Passwordtb.Text = ""
                        Positioncmb.Text = ""
                        Form8.Show()
                        Me.Hide()

                    ElseIf Positioncmb.SelectedIndex = 1 Then
                        'MessageBox.Show("Login as user")
                        UserNametb.Text = ""
                        Passwordtb.Text = ""
                        Positioncmb.Text = ""
                        Me.Hide()
                        Form6.Show()
                    Else

                        UserNametb.Text = ""
                        Passwordtb.Text = ""
                        Positioncmb.Text = ""
                    End If
                Else

                    MessageBox.Show("Invalid Log-In ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show(String.Join(Environment.NewLine, errors.ToArray), "Error Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        CloseDb()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Positioncmb.DropDownStyle = ComboBoxStyle.DropDownList



        OpenDb()


        'LoadDataIntoComboBox()
        Dim cus_query As String
        Dim da As New MySqlDataAdapter
        Dim cus_dt As New DataTable
        cus_query = "SELECT `po_Name`,`po_id` FROM `position_tb`"
        da.SelectCommand = New MySqlCommand(cus_query, conn)
        da.Fill(cus_dt)
        Positioncmb.DataSource = cus_dt
        Positioncmb.DisplayMember = "po_Name"
        Positioncmb.ValueMember = "po_id"
        'customer_id = Convert.ToInt32(cuscombo.SelectedValue)
        'customer_id = Positioncmb.SelectedValue
        CloseDb()
    End Sub

    Private Sub ShowPasswordcb_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordcb.CheckedChanged
        If ShowPasswordcb.Checked = False Then
            Passwordtb.PasswordChar = "*"
        Else
            Passwordtb.PasswordChar = ""
        End If
    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Load or show Form2
            Dim uname, pass As String
            Dim posi As String
            uname = UserNametb.Text
            pass = Passwordtb.Text
            posi = Positioncmb.SelectedValue
            Dim errors As New ArrayList

            If empty(posi) Then
                ErrorProvider1.SetError(Positioncmb, "Please Select Position")
            Else
                ErrorProvider1.SetError(Positioncmb, String.Empty)
            End If

            If empty(uname) Then

                errors.Add("Please Enter User Name")

            End If
            If empty(pass) Then

                errors.Add("Please Enter Password")

            End If

            If errors.Count < 1 Then
                OpenDb()
                Dim Str As String
                Dim depass = Encrypt(Passwordtb.Text)
                Str = "SELECT * FROM users_tb WHERE Position = '" & posi & "' and User_name = '" & UserNametb.Text & "' and Password = '" & depass & "'"
                Dim command As New MySqlCommand(Str, conn)
                Dim adap As MySqlDataAdapter = New MySqlDataAdapter(command)
                Dim dt As DataTable = New DataTable()
                adap.Fill(dt)

                If (dt.Rows.Count > 0) Then
                    '' MessageBox.Show("log in as " + dt.Rows(0)(2))
                    If Positioncmb.SelectedIndex = 0 Then
                        'MessageBox.Show("Login as admin")
                        UserNametb.Text = ""
                        Passwordtb.Text = ""
                        Positioncmb.Text = ""
                        Form8.Show()
                        Me.Hide()

                    ElseIf Positioncmb.SelectedIndex = 1 Then
                        'MessageBox.Show("Login as user")
                        UserNametb.Text = ""
                        Passwordtb.Text = ""
                        Positioncmb.Text = ""
                        Me.Hide()
                        Form6.Show()
                    Else

                        UserNametb.Text = ""
                        Passwordtb.Text = ""
                        Positioncmb.Text = ""
                    End If
                Else

                    MessageBox.Show("Invalid Log-In ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show(String.Join(Environment.NewLine, errors.ToArray), "Error Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

End Class