Imports MySql.Data.MySqlClient

Public Class login

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttotalbill.Text = billw.TextBoxValue
        TxtCusName.Text = billw.TextBoxValue1
        TxtPhNb.Text = billw.TextBoxValue2
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If txttotalbill.Text = "" AndAlso TxtCusName.Text = "" AndAlso TxtPhNb.Text = "" Then
            MessageBox.Show("Please Enter Customer Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Validate username and password
            If TxtName.Text = "admin" AndAlso TxtPw.Text = "123" Then
                ' Call a method to insert data into the database
                InsertDataIntoDatabase()
                'billw.Show()
                Me.Hide()
            Else
                ' Display a message box if the username or password is incorrect
                MessageBox.Show("Incorrect username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


        Dim form2Instance As billw = CType(Application.OpenForms("Form2"), billw)

        ' Clearing DataGridView in Form2
        If form2Instance IsNot Nothing Then
            form2Instance.ClearDataGridView()
        End If

        ' Me.Close()


    End Sub
    Private Sub InsertDataIntoDatabase()
        OpenDb()

        Dim str As String
        str = "INSERT INTO `after_p_bill`(`Date`,`Name`, `Ph_Number`, `Total`) VALUES (@date,@name,@ph,@total)"



        Dim commad As New MySqlCommand(str, conn)
        ' Insert Data into Customer Registration Table"
        commad.Parameters.AddWithValue("@date", DateAndTime.Now)
        commad.Parameters.AddWithValue("@name", TxtCusName.Text)
        commad.Parameters.AddWithValue("@ph", TxtPhNb.Text)
        commad.Parameters.AddWithValue("@total", txttotalbill.Text)

        Try
            Dim result As Integer = commad.ExecuteNonQuery()
            If result > 0 Then
                ' MsgBox("New Bill added!", vbInformation + vbOKOnly, "Add Bill")
                ' Clear textboxes after successful insertion
                txttotalbill.Text = ""
                TxtName.Text = ""
                TxtPw.Text = ""
            Else
                MsgBox("Not added", vbExclamation + vbOKOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation + vbOKOnly, "Error")
        Finally
            commad.Dispose()
            CloseDb()
        End Try
    End Sub

    Private Sub TxtCusName_TextChanged(sender As Object, e As EventArgs) Handles TxtCusName.TextChanged

    End Sub

    Private Sub TxtPhNb_TextChanged(sender As Object, e As EventArgs) Handles TxtPhNb.TextChanged
    End Sub

    Private Sub txttotalbill_TextChanged(sender As Object, e As EventArgs) Handles txttotalbill.TextChanged
    End Sub
End Class
