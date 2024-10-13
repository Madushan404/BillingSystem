<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Positioncmb = New ComboBox()
        Passwordlbl = New Label()
        Positionlbl = New Label()
        UserNamelbl = New Label()
        Passwordtb = New TextBox()
        UserNametb = New TextBox()
        usersdgv = New DataGridView()
        ShowPasswordcb = New CheckBox()
        UserIDtb = New TextBox()
        Label1 = New Label()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        AddCustomerbtn = New FontAwesome.Sharp.IconButton()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        SecurityPasswordlbl = New Label()
        SecurityPasswordtb = New TextBox()
        CType(usersdgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Positioncmb
        ' 
        Positioncmb.Font = New Font("Microsoft Sans Serif", 18F)
        Positioncmb.FormattingEnabled = True
        Positioncmb.Location = New Point(291, 351)
        Positioncmb.Margin = New Padding(5, 4, 5, 4)
        Positioncmb.Name = "Positioncmb"
        Positioncmb.Size = New Size(789, 44)
        Positioncmb.TabIndex = 26
        ' 
        ' Passwordlbl
        ' 
        Passwordlbl.AutoSize = True
        Passwordlbl.Font = New Font("Segoe UI", 15.75F)
        Passwordlbl.Location = New Point(31, 588)
        Passwordlbl.Margin = New Padding(5, 0, 5, 0)
        Passwordlbl.Name = "Passwordlbl"
        Passwordlbl.Size = New Size(155, 37)
        Passwordlbl.TabIndex = 25
        Passwordlbl.Text = "PASSWORD"
        ' 
        ' Positionlbl
        ' 
        Positionlbl.AutoSize = True
        Positionlbl.Font = New Font("Segoe UI", 15.75F)
        Positionlbl.Location = New Point(31, 351)
        Positionlbl.Margin = New Padding(5, 0, 5, 0)
        Positionlbl.Name = "Positionlbl"
        Positionlbl.Size = New Size(134, 37)
        Positionlbl.TabIndex = 23
        Positionlbl.Text = "POSITION"
        ' 
        ' UserNamelbl
        ' 
        UserNamelbl.AutoSize = True
        UserNamelbl.Font = New Font("Segoe UI", 15.75F)
        UserNamelbl.Location = New Point(31, 465)
        UserNamelbl.Margin = New Padding(5, 0, 5, 0)
        UserNamelbl.Name = "UserNamelbl"
        UserNamelbl.Size = New Size(162, 37)
        UserNamelbl.TabIndex = 24
        UserNamelbl.Text = "USER NAME"
        ' 
        ' Passwordtb
        ' 
        Passwordtb.Font = New Font("Microsoft Sans Serif", 18F)
        Passwordtb.Location = New Point(291, 588)
        Passwordtb.Margin = New Padding(5, 4, 5, 4)
        Passwordtb.Name = "Passwordtb"
        Passwordtb.PasswordChar = "*"c
        Passwordtb.Size = New Size(789, 41)
        Passwordtb.TabIndex = 19
        ' 
        ' UserNametb
        ' 
        UserNametb.Font = New Font("Microsoft Sans Serif", 18F)
        UserNametb.Location = New Point(291, 465)
        UserNametb.Margin = New Padding(5, 4, 5, 4)
        UserNametb.Name = "UserNametb"
        UserNametb.Size = New Size(789, 41)
        UserNametb.TabIndex = 20
        ' 
        ' usersdgv
        ' 
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usersdgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        usersdgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        usersdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        usersdgv.BackgroundColor = Color.White
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        usersdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        usersdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        usersdgv.DefaultCellStyle = DataGridViewCellStyle3
        usersdgv.Location = New Point(1189, 143)
        usersdgv.Margin = New Padding(5, 4, 5, 4)
        usersdgv.Name = "usersdgv"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        usersdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        usersdgv.RowHeadersWidth = 51
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usersdgv.RowsDefaultCellStyle = DataGridViewCellStyle5
        usersdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        usersdgv.Size = New Size(720, 896)
        usersdgv.TabIndex = 27
        ' 
        ' ShowPasswordcb
        ' 
        ShowPasswordcb.AutoSize = True
        ShowPasswordcb.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ShowPasswordcb.Location = New Point(926, 643)
        ShowPasswordcb.Margin = New Padding(5, 4, 5, 4)
        ShowPasswordcb.Name = "ShowPasswordcb"
        ShowPasswordcb.Size = New Size(176, 27)
        ShowPasswordcb.TabIndex = 28
        ShowPasswordcb.Text = "SHOW PASSWORD"
        ShowPasswordcb.UseVisualStyleBackColor = True
        ' 
        ' UserIDtb
        ' 
        UserIDtb.Location = New Point(691, 71)
        UserIDtb.Margin = New Padding(5, 4, 5, 4)
        UserIDtb.Name = "UserIDtb"
        UserIDtb.Size = New Size(132, 27)
        UserIDtb.TabIndex = 29
        UserIDtb.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(31, 204)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 50)
        Label1.TabIndex = 30
        Label1.Text = "REGISTRATION"
        ' 
        ' IconButton1
        ' 
        IconButton1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Crimson
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 40
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(818, 999)
        IconButton1.Margin = New Padding(3, 4, 3, 4)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(263, 113)
        IconButton1.TabIndex = 31
        IconButton1.Text = "Delete "
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' IconButton2
        ' 
        IconButton2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton2.IconColor = Color.DeepSkyBlue
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 40
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(458, 999)
        IconButton2.Margin = New Padding(3, 4, 3, 4)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(263, 113)
        IconButton2.TabIndex = 32
        IconButton2.Text = "Update "
        IconButton2.UseVisualStyleBackColor = True
        ' 
        ' AddCustomerbtn
        ' 
        AddCustomerbtn.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        AddCustomerbtn.IconChar = FontAwesome.Sharp.IconChar.None
        AddCustomerbtn.IconColor = Color.LimeGreen
        AddCustomerbtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        AddCustomerbtn.IconSize = 40
        AddCustomerbtn.ImageAlign = ContentAlignment.MiddleLeft
        AddCustomerbtn.Location = New Point(95, 999)
        AddCustomerbtn.Margin = New Padding(3, 4, 3, 4)
        AddCustomerbtn.Name = "AddCustomerbtn"
        AddCustomerbtn.Padding = New Padding(11, 13, 11, 13)
        AddCustomerbtn.Size = New Size(263, 113)
        AddCustomerbtn.TabIndex = 34
        AddCustomerbtn.Text = "Add "
        AddCustomerbtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(187), CByte(222), CByte(251))
        PictureBox1.Location = New Point(1121, 89)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(11, 1131)
        PictureBox1.TabIndex = 35
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(1189, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 50)
        Label2.TabIndex = 36
        Label2.Text = "DETAILS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 48F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(5), CByte(25), CByte(35))
        Label3.Location = New Point(15, 36)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(597, 106)
        Label3.TabIndex = 37
        Label3.Text = "USER MANAGE"
        ' 
        ' SecurityPasswordlbl
        ' 
        SecurityPasswordlbl.AutoSize = True
        SecurityPasswordlbl.Font = New Font("Segoe UI", 15.75F)
        SecurityPasswordlbl.Location = New Point(31, 720)
        SecurityPasswordlbl.Margin = New Padding(5, 0, 5, 0)
        SecurityPasswordlbl.Name = "SecurityPasswordlbl"
        SecurityPasswordlbl.Size = New Size(191, 37)
        SecurityPasswordlbl.TabIndex = 39
        SecurityPasswordlbl.Text = "VERIFICATION "
        ' 
        ' SecurityPasswordtb
        ' 
        SecurityPasswordtb.Font = New Font("Microsoft Sans Serif", 18F)
        SecurityPasswordtb.Location = New Point(291, 720)
        SecurityPasswordtb.Margin = New Padding(5, 4, 5, 4)
        SecurityPasswordtb.Name = "SecurityPasswordtb"
        SecurityPasswordtb.Size = New Size(789, 41)
        SecurityPasswordtb.TabIndex = 38
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1924, 1055)
        Controls.Add(SecurityPasswordlbl)
        Controls.Add(SecurityPasswordtb)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(IconButton1)
        Controls.Add(IconButton2)
        Controls.Add(AddCustomerbtn)
        Controls.Add(Label1)
        Controls.Add(UserIDtb)
        Controls.Add(ShowPasswordcb)
        Controls.Add(usersdgv)
        Controls.Add(Positioncmb)
        Controls.Add(Passwordlbl)
        Controls.Add(Positionlbl)
        Controls.Add(UserNamelbl)
        Controls.Add(Passwordtb)
        Controls.Add(UserNametb)
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form4"
        Text = "Form4"
        CType(usersdgv, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Positioncmb As ComboBox
    Friend WithEvents Passwordlbl As Label
    Friend WithEvents Positionlbl As Label
    Friend WithEvents UserNamelbl As Label
    Friend WithEvents Passwordtb As TextBox
    Friend WithEvents UserNametb As TextBox
    Friend WithEvents usersdgv As DataGridView
    Friend WithEvents ShowPasswordcb As CheckBox
    Friend WithEvents UserIDtb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents AddCustomerbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SecurityPasswordlbl As Label
    Friend WithEvents SecurityPasswordtb As TextBox
End Class
