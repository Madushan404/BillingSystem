<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Passwordlbl = New Label()
        UserNamelbl = New Label()
        ShowPasswordcb = New CheckBox()
        Loginbtn = New Button()
        Passwordtb = New TextBox()
        UserNametb = New TextBox()
        Positioncmb = New ComboBox()
        Positionlbl = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        ErrorProvider3 = New ErrorProvider(components)
        Label1 = New Label()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Passwordlbl
        ' 
        Passwordlbl.AutoSize = True
        Passwordlbl.BackColor = Color.Transparent
        Passwordlbl.Font = New Font("Segoe UI", 20.25F)
        Passwordlbl.ForeColor = Color.Black
        Passwordlbl.Location = New Point(63, 392)
        Passwordlbl.Margin = New Padding(4, 0, 4, 0)
        Passwordlbl.Name = "Passwordlbl"
        Passwordlbl.Size = New Size(128, 37)
        Passwordlbl.TabIndex = 16
        Passwordlbl.Text = "Password"
        ' 
        ' UserNamelbl
        ' 
        UserNamelbl.AutoSize = True
        UserNamelbl.BackColor = Color.Transparent
        UserNamelbl.Font = New Font("Segoe UI", 20.25F)
        UserNamelbl.ForeColor = Color.Black
        UserNamelbl.Location = New Point(63, 333)
        UserNamelbl.Margin = New Padding(4, 0, 4, 0)
        UserNamelbl.Name = "UserNamelbl"
        UserNamelbl.Size = New Size(148, 37)
        UserNamelbl.TabIndex = 15
        UserNamelbl.Text = "User Name"
        ' 
        ' ShowPasswordcb
        ' 
        ShowPasswordcb.AutoSize = True
        ShowPasswordcb.BackColor = Color.Transparent
        ShowPasswordcb.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ShowPasswordcb.ForeColor = Color.Black
        ShowPasswordcb.Location = New Point(467, 440)
        ShowPasswordcb.Margin = New Padding(4, 3, 4, 3)
        ShowPasswordcb.Name = "ShowPasswordcb"
        ShowPasswordcb.Size = New Size(169, 34)
        ShowPasswordcb.TabIndex = 14
        ShowPasswordcb.Text = "Show Password"
        ShowPasswordcb.UseVisualStyleBackColor = False
        ' 
        ' Loginbtn
        ' 
        Loginbtn.BackColor = Color.LimeGreen
        Loginbtn.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        Loginbtn.ForeColor = Color.White
        Loginbtn.Location = New Point(63, 496)
        Loginbtn.Margin = New Padding(4, 3, 4, 3)
        Loginbtn.Name = "Loginbtn"
        Loginbtn.Size = New Size(574, 72)
        Loginbtn.TabIndex = 13
        Loginbtn.Text = "Log-in"
        Loginbtn.UseVisualStyleBackColor = False
        ' 
        ' Passwordtb
        ' 
        Passwordtb.Font = New Font("Segoe UI", 20.25F)
        ErrorProvider3.SetIconAlignment(Passwordtb, ErrorIconAlignment.BottomRight)
        Passwordtb.Location = New Point(249, 392)
        Passwordtb.Margin = New Padding(4, 3, 4, 3)
        Passwordtb.Name = "Passwordtb"
        Passwordtb.PasswordChar = "*"c
        Passwordtb.Size = New Size(387, 43)
        Passwordtb.TabIndex = 11
        ' 
        ' UserNametb
        ' 
        UserNametb.Font = New Font("Segoe UI", 20.25F)
        ErrorProvider3.SetIconAlignment(UserNametb, ErrorIconAlignment.BottomRight)
        UserNametb.Location = New Point(249, 333)
        UserNametb.Margin = New Padding(4, 3, 4, 3)
        UserNametb.Name = "UserNametb"
        UserNametb.Size = New Size(387, 43)
        UserNametb.TabIndex = 12
        ' 
        ' Positioncmb
        ' 
        Positioncmb.Font = New Font("Segoe UI", 20.25F)
        Positioncmb.FormattingEnabled = True
        ErrorProvider2.SetIconAlignment(Positioncmb, ErrorIconAlignment.BottomRight)
        Positioncmb.Location = New Point(249, 274)
        Positioncmb.Margin = New Padding(4, 3, 4, 3)
        Positioncmb.Name = "Positioncmb"
        Positioncmb.Size = New Size(387, 45)
        Positioncmb.TabIndex = 17
        ' 
        ' Positionlbl
        ' 
        Positionlbl.AutoSize = True
        Positionlbl.BackColor = Color.Transparent
        Positionlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Positionlbl.ForeColor = Color.Black
        Positionlbl.Location = New Point(63, 274)
        Positionlbl.Margin = New Padding(4, 0, 4, 0)
        Positionlbl.Name = "Positionlbl"
        Positionlbl.Size = New Size(112, 37)
        Positionlbl.TabIndex = 15
        Positionlbl.Text = "Position"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' ErrorProvider3
        ' 
        ErrorProvider3.ContainerControl = Me
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(120, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(478, 86)
        Label1.TabIndex = 18
        Label1.Text = "SYSTEM LOGIN"
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.Transparent
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users
        IconPictureBox1.IconColor = Color.White
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 133
        IconPictureBox1.Location = New Point(300, 117)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(133, 133)
        IconPictureBox1.TabIndex = 19
        IconPictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(202), CByte(240), CByte(248))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(706, 636)
        Controls.Add(IconPictureBox1)
        Controls.Add(Label1)
        Controls.Add(Positioncmb)
        Controls.Add(Passwordlbl)
        Controls.Add(Positionlbl)
        Controls.Add(UserNamelbl)
        Controls.Add(ShowPasswordcb)
        Controls.Add(Loginbtn)
        Controls.Add(Passwordtb)
        Controls.Add(UserNametb)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Positioncmb As ComboBox
    Friend WithEvents Passwordlbl As Label
    Friend WithEvents UserNamelbl As Label
    Friend WithEvents ShowPasswordcb As CheckBox
    Friend WithEvents Loginbtn As Button
    Friend WithEvents Passwordtb As TextBox
    Friend WithEvents UserNametb As TextBox
    Friend WithEvents Positionlbl As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
