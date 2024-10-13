<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        CustomerDetailsdgv = New DataGridView()
        SearchCustomerlbl = New Label()
        OtherDetailslbl = New Label()
        MobileNumberlbl = New Label()
        CustomerNamelbl = New Label()
        OtherDetailstb = New TextBox()
        MobileNumbertb = New TextBox()
        SearchCustomertb = New TextBox()
        CustomerNametb = New TextBox()
        Idtb = New TextBox()
        Label1 = New Label()
        AddCustomerbtn2 = New FontAwesome.Sharp.IconButton()
        Deletebtn = New FontAwesome.Sharp.IconButton()
        Button1 = New Button()
        Clearbtn = New FontAwesome.Sharp.IconButton()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        PictureBox1 = New PictureBox()
        Updatebtn = New Button()
        AddCustomerbtn = New Button()
        CType(CustomerDetailsdgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CustomerDetailsdgv
        ' 
        CustomerDetailsdgv.AccessibleRole = AccessibleRole.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue
        CustomerDetailsdgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        CustomerDetailsdgv.BackgroundColor = Color.White
        CustomerDetailsdgv.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        CustomerDetailsdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        CustomerDetailsdgv.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        CustomerDetailsdgv.DefaultCellStyle = DataGridViewCellStyle3
        CustomerDetailsdgv.Location = New Point(1166, 296)
        CustomerDetailsdgv.Margin = New Padding(5, 4, 5, 4)
        CustomerDetailsdgv.Name = "CustomerDetailsdgv"
        CustomerDetailsdgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Yellow
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        CustomerDetailsdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        CustomerDetailsdgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CustomerDetailsdgv.RowsDefaultCellStyle = DataGridViewCellStyle5
        CustomerDetailsdgv.ScrollBars = ScrollBars.Vertical
        CustomerDetailsdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        CustomerDetailsdgv.Size = New Size(1018, 980)
        CustomerDetailsdgv.TabIndex = 16
        ' 
        ' SearchCustomerlbl
        ' 
        SearchCustomerlbl.AutoSize = True
        SearchCustomerlbl.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        SearchCustomerlbl.Location = New Point(1166, 232)
        SearchCustomerlbl.Margin = New Padding(5, 0, 5, 0)
        SearchCustomerlbl.Name = "SearchCustomerlbl"
        SearchCustomerlbl.Size = New Size(296, 39)
        SearchCustomerlbl.TabIndex = 9
        SearchCustomerlbl.Text = "Search Customer"
        ' 
        ' OtherDetailslbl
        ' 
        OtherDetailslbl.AutoSize = True
        OtherDetailslbl.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        OtherDetailslbl.Location = New Point(15, 469)
        OtherDetailslbl.Margin = New Padding(5, 0, 5, 0)
        OtherDetailslbl.Name = "OtherDetailslbl"
        OtherDetailslbl.Size = New Size(238, 39)
        OtherDetailslbl.TabIndex = 10
        OtherDetailslbl.Text = "Other Details "
        ' 
        ' MobileNumberlbl
        ' 
        MobileNumberlbl.AutoSize = True
        MobileNumberlbl.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        MobileNumberlbl.Location = New Point(15, 359)
        MobileNumberlbl.Margin = New Padding(5, 0, 5, 0)
        MobileNumberlbl.Name = "MobileNumberlbl"
        MobileNumberlbl.Size = New Size(261, 39)
        MobileNumberlbl.TabIndex = 11
        MobileNumberlbl.Text = "Mobile Number"
        ' 
        ' CustomerNamelbl
        ' 
        CustomerNamelbl.AutoSize = True
        CustomerNamelbl.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        CustomerNamelbl.Location = New Point(15, 236)
        CustomerNamelbl.Margin = New Padding(5, 0, 5, 0)
        CustomerNamelbl.Name = "CustomerNamelbl"
        CustomerNamelbl.Size = New Size(112, 39)
        CustomerNamelbl.TabIndex = 12
        CustomerNamelbl.Text = "Name"
        ' 
        ' OtherDetailstb
        ' 
        OtherDetailstb.BorderStyle = BorderStyle.FixedSingle
        OtherDetailstb.Font = New Font("Segoe UI", 18F)
        OtherDetailstb.Location = New Point(291, 467)
        OtherDetailstb.Margin = New Padding(5, 4, 5, 4)
        OtherDetailstb.Multiline = True
        OtherDetailstb.Name = "OtherDetailstb"
        OtherDetailstb.Size = New Size(762, 129)
        OtherDetailstb.TabIndex = 5
        ' 
        ' MobileNumbertb
        ' 
        MobileNumbertb.BorderStyle = BorderStyle.FixedSingle
        MobileNumbertb.Font = New Font("Segoe UI", 18F)
        MobileNumbertb.Location = New Point(291, 356)
        MobileNumbertb.Margin = New Padding(5, 4, 5, 4)
        MobileNumbertb.Name = "MobileNumbertb"
        MobileNumbertb.Size = New Size(762, 47)
        MobileNumbertb.TabIndex = 6
        ' 
        ' SearchCustomertb
        ' 
        SearchCustomertb.BorderStyle = BorderStyle.FixedSingle
        SearchCustomertb.Font = New Font("Segoe UI", 18F)
        SearchCustomertb.Location = New Point(1449, 229)
        SearchCustomertb.Margin = New Padding(5, 4, 5, 4)
        SearchCustomertb.Name = "SearchCustomertb"
        SearchCustomertb.Size = New Size(657, 47)
        SearchCustomertb.TabIndex = 7
        ' 
        ' CustomerNametb
        ' 
        CustomerNametb.BorderStyle = BorderStyle.FixedSingle
        CustomerNametb.Font = New Font("Segoe UI", 18F)
        CustomerNametb.Location = New Point(291, 232)
        CustomerNametb.Margin = New Padding(5, 4, 5, 4)
        CustomerNametb.Name = "CustomerNametb"
        CustomerNametb.Size = New Size(762, 47)
        CustomerNametb.TabIndex = 8
        ' 
        ' Idtb
        ' 
        Idtb.Location = New Point(670, 64)
        Idtb.Margin = New Padding(5, 4, 5, 4)
        Idtb.Name = "Idtb"
        Idtb.Size = New Size(132, 27)
        Idtb.TabIndex = 17
        Idtb.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(5), CByte(25), CByte(35))
        Label1.Location = New Point(5, 12)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(879, 91)
        Label1.TabIndex = 18
        Label1.Text = "CUSTOMER MANAGE"
        ' 
        ' AddCustomerbtn2
        ' 
        AddCustomerbtn2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        AddCustomerbtn2.IconChar = FontAwesome.Sharp.IconChar.None
        AddCustomerbtn2.IconColor = Color.LimeGreen
        AddCustomerbtn2.IconFont = FontAwesome.Sharp.IconFont.Auto
        AddCustomerbtn2.IconSize = 40
        AddCustomerbtn2.ImageAlign = ContentAlignment.MiddleLeft
        AddCustomerbtn2.Location = New Point(27, 836)
        AddCustomerbtn2.Margin = New Padding(3, 4, 3, 4)
        AddCustomerbtn2.Name = "AddCustomerbtn2"
        AddCustomerbtn2.Padding = New Padding(11, 13, 11, 13)
        AddCustomerbtn2.Size = New Size(262, 57)
        AddCustomerbtn2.TabIndex = 19
        AddCustomerbtn2.Text = "Add "
        AddCustomerbtn2.UseVisualStyleBackColor = True
        ' 
        ' Deletebtn
        ' 
        Deletebtn.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Deletebtn.IconChar = FontAwesome.Sharp.IconChar.None
        Deletebtn.IconColor = Color.Crimson
        Deletebtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        Deletebtn.IconSize = 40
        Deletebtn.ImageAlign = ContentAlignment.MiddleLeft
        Deletebtn.Location = New Point(758, 836)
        Deletebtn.Margin = New Padding(3, 4, 3, 4)
        Deletebtn.Name = "Deletebtn"
        Deletebtn.Size = New Size(263, 113)
        Deletebtn.TabIndex = 19
        Deletebtn.Text = "Delete "
        Deletebtn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.Desktop
        Button1.Location = New Point(539, 1329)
        Button1.Margin = New Padding(5, 4, 5, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(263, 113)
        Button1.TabIndex = 13
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Clearbtn
        ' 
        Clearbtn.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Clearbtn.IconChar = FontAwesome.Sharp.IconChar.None
        Clearbtn.IconColor = SystemColors.ActiveCaptionText
        Clearbtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        Clearbtn.IconSize = 40
        Clearbtn.ImageAlign = ContentAlignment.MiddleLeft
        Clearbtn.Location = New Point(27, 1003)
        Clearbtn.Margin = New Padding(3, 4, 3, 4)
        Clearbtn.Name = "Clearbtn"
        Clearbtn.Padding = New Padding(11, 13, 11, 13)
        Clearbtn.Size = New Size(263, 113)
        Clearbtn.TabIndex = 19
        Clearbtn.Text = "Clear"
        Clearbtn.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(187), CByte(222), CByte(251))
        PictureBox1.Location = New Point(1121, 89)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(11, 1187)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Updatebtn
        ' 
        Updatebtn.BackColor = Color.PaleTurquoise
        Updatebtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Updatebtn.Location = New Point(432, 747)
        Updatebtn.Margin = New Padding(3, 4, 3, 4)
        Updatebtn.Name = "Updatebtn"
        Updatebtn.Size = New Size(262, 57)
        Updatebtn.TabIndex = 42
        Updatebtn.Text = "UPDATE"
        Updatebtn.UseVisualStyleBackColor = False
        ' 
        ' AddCustomerbtn
        ' 
        AddCustomerbtn.BackColor = Color.LightGreen
        AddCustomerbtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AddCustomerbtn.Location = New Point(406, 853)
        AddCustomerbtn.Margin = New Padding(3, 4, 3, 4)
        AddCustomerbtn.Name = "AddCustomerbtn"
        AddCustomerbtn.Size = New Size(262, 57)
        AddCustomerbtn.TabIndex = 43
        AddCustomerbtn.Text = "ADD"
        AddCustomerbtn.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1924, 1055)
        Controls.Add(AddCustomerbtn)
        Controls.Add(Updatebtn)
        Controls.Add(PictureBox1)
        Controls.Add(Deletebtn)
        Controls.Add(Clearbtn)
        Controls.Add(AddCustomerbtn2)
        Controls.Add(Label1)
        Controls.Add(Idtb)
        Controls.Add(CustomerDetailsdgv)
        Controls.Add(Button1)
        Controls.Add(SearchCustomerlbl)
        Controls.Add(OtherDetailslbl)
        Controls.Add(MobileNumberlbl)
        Controls.Add(CustomerNamelbl)
        Controls.Add(OtherDetailstb)
        Controls.Add(MobileNumbertb)
        Controls.Add(SearchCustomertb)
        Controls.Add(CustomerNametb)
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form3"
        Text = "Form3"
        CType(CustomerDetailsdgv, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents CustomerDetailsdgv As DataGridView
    Friend WithEvents gg As Button
    Friend WithEvents SearchCustomerlbl As Label
    Friend WithEvents OtherDetailslbl As Label
    Friend WithEvents MobileNumberlbl As Label
    Friend WithEvents CustomerNamelbl As Label
    Friend WithEvents OtherDetailstb As TextBox
    Friend WithEvents MobileNumbertb As TextBox
    Friend WithEvents SearchCustomertb As TextBox
    Friend WithEvents CustomerNametb As TextBox
    Friend WithEvents Idtb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddCustomerbtn2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Deletebtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Updatebtn2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Clearbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Updatebtn As Button
    Friend WithEvents AddCustomerbtn As Button
End Class
