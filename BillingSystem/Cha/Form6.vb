Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class Form6
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = Color.FromArgb(248, 249, 250)
            currentBtn.IconColor = Color.FromArgb(248, 249, 250)
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            'leftBorderBtn.BackColor = customColor
            'leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            'leftBorderBtn.Visible = True
            'leftBorderBtn.BringToFront()
            'current Form icon'
            'IconCurrentForm.IconChar = currentBtn.IconChar
            'IconCurrentForm.IconColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(255, 255, 255)
            currentBtn.ForeColor = Color.FromArgb(0, 0, 0)
            currentBtn.IconColor = Color.FromArgb(0, 0, 0)
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub


    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        'lblFormTitle.Text = childForm.Text
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        ' IconCurrentForm.IconChar = IconChar.Home
        ' IconCurrentForm.IconColor = Color.MediumPurple
        'lblFormTitle.Text = "Home"
    End Sub

    Private Sub AddCustomerbtn_Click(sender As Object, e As EventArgs) Handles AddCustomerbtn.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New Form1)
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New Form5)
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles LogOutbtn.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Billingbtn_Click(sender As Object, e As EventArgs) Handles Billingbtn.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New billg)
    End Sub

    Private Sub TodayItemsbtn_Click(sender As Object, e As EventArgs) Handles TodayItemsbtn.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New Item_select)
    End Sub

    Private Sub Inventorybtn_Click(sender As Object, e As EventArgs) Handles Inventorybtn.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New Inventry_user)
    End Sub

    Private Sub WholeSalebtn_Click(sender As Object, e As EventArgs) Handles WholeSalebtn.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New billw)
    End Sub

    Private Sub LendingBillsbtn_Click(sender As Object, e As EventArgs) Handles LendingBillsbtn.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New billdue)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New Form5)
    End Sub

    Public Structure RGBColors
        Public Shared color1 As Color = Color.FromArgb(3, 4, 94)
        Public Shared color2 As Color = Color.FromArgb(249, 118, 176)
        Public Shared color3 As Color = Color.FromArgb(253, 138, 114)
        Public Shared color4 As Color = Color.FromArgb(95, 77, 221)
        Public Shared color5 As Color = Color.FromArgb(249, 88, 155)
        Public Shared color6 As Color = Color.FromArgb(24, 161, 251)
    End Structure
End Class
