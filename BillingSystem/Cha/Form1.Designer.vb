<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        CustomerNametb = New TextBox()
        MobileNumbertb = New TextBox()
        OtherDetailstb = New TextBox()
        CustomerNamelbl = New Label()
        MobileNumberlbl = New Label()
        OtherDetailslbl = New Label()
        SearchCustomertb = New TextBox()
        SearchCustomerlbl = New Label()
        CustomerDetailsdgv = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        Label1 = New Label()
        AddCustomerbtn = New FontAwesome.Sharp.IconButton()
        PictureBox1 = New PictureBox()
        CType(CustomerDetailsdgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CustomerNametb
        ' 
        CustomerNametb.BorderStyle = BorderStyle.FixedSingle
        CustomerNametb.Font = New Font("Microsoft Sans Serif", 18F)
        CustomerNametb.Location = New Point(255, 171)
        CustomerNametb.Margin = New Padding(4, 3, 4, 3)
        CustomerNametb.Name = "CustomerNametb"
        CustomerNametb.Size = New Size(598, 35)
        CustomerNametb.TabIndex = 0
        ' 
        ' MobileNumbertb
        ' 
        MobileNumbertb.Font = New Font("Microsoft Sans Serif", 18F)
        MobileNumbertb.Location = New Point(255, 263)
        MobileNumbertb.Margin = New Padding(4, 3, 4, 3)
        MobileNumbertb.Name = "MobileNumbertb"
        MobileNumbertb.Size = New Size(598, 35)
        MobileNumbertb.TabIndex = 0
        ' 
        ' OtherDetailstb
        ' 
        OtherDetailstb.Font = New Font("Microsoft Sans Serif", 18F)
        OtherDetailstb.Location = New Point(255, 350)
        OtherDetailstb.Margin = New Padding(4, 3, 4, 3)
        OtherDetailstb.Multiline = True
        OtherDetailstb.Name = "OtherDetailstb"
        OtherDetailstb.Size = New Size(598, 97)
        OtherDetailstb.TabIndex = 0
        ' 
        ' CustomerNamelbl
        ' 
        CustomerNamelbl.AutoSize = True
        CustomerNamelbl.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustomerNamelbl.ForeColor = Color.FromArgb(CByte(5), CByte(25), CByte(35))
        CustomerNamelbl.Location = New Point(23, 169)
        CustomerNamelbl.Margin = New Padding(4, 0, 4, 0)
        CustomerNamelbl.Name = "CustomerNamelbl"
        CustomerNamelbl.Size = New Size(90, 31)
        CustomerNamelbl.TabIndex = 1
        CustomerNamelbl.Text = "Name"
        ' 
        ' MobileNumberlbl
        ' 
        MobileNumberlbl.AutoSize = True
        MobileNumberlbl.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        MobileNumberlbl.Location = New Point(23, 267)
        MobileNumberlbl.Margin = New Padding(4, 0, 4, 0)
        MobileNumberlbl.Name = "MobileNumberlbl"
        MobileNumberlbl.Size = New Size(209, 31)
        MobileNumberlbl.TabIndex = 1
        MobileNumberlbl.Text = "Mobile Number"
        ' 
        ' OtherDetailslbl
        ' 
        OtherDetailslbl.AutoSize = True
        OtherDetailslbl.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        OtherDetailslbl.Location = New Point(23, 350)
        OtherDetailslbl.Margin = New Padding(4, 0, 4, 0)
        OtherDetailslbl.Name = "OtherDetailslbl"
        OtherDetailslbl.Size = New Size(194, 31)
        OtherDetailslbl.TabIndex = 1
        OtherDetailslbl.Text = "Other Details "
        ' 
        ' SearchCustomertb
        ' 
        SearchCustomertb.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchCustomertb.Location = New Point(1268, 167)
        SearchCustomertb.Margin = New Padding(4, 3, 4, 3)
        SearchCustomertb.Name = "SearchCustomertb"
        SearchCustomertb.Size = New Size(575, 39)
        SearchCustomertb.TabIndex = 0
        ' 
        ' SearchCustomerlbl
        ' 
        SearchCustomerlbl.AutoSize = True
        SearchCustomerlbl.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        SearchCustomerlbl.Location = New Point(1020, 167)
        SearchCustomerlbl.Margin = New Padding(4, 0, 4, 0)
        SearchCustomerlbl.Name = "SearchCustomerlbl"
        SearchCustomerlbl.Size = New Size(240, 31)
        SearchCustomerlbl.TabIndex = 1
        SearchCustomerlbl.Text = "Search Customer"
        ' 
        ' CustomerDetailsdgv
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        CustomerDetailsdgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        CustomerDetailsdgv.BackgroundColor = Color.White
        CustomerDetailsdgv.BorderStyle = BorderStyle.Fixed3D
        CustomerDetailsdgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        CustomerDetailsdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        CustomerDetailsdgv.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        CustomerDetailsdgv.DefaultCellStyle = DataGridViewCellStyle3
        CustomerDetailsdgv.Location = New Point(1020, 222)
        CustomerDetailsdgv.Margin = New Padding(4, 3, 4, 3)
        CustomerDetailsdgv.Name = "CustomerDetailsdgv"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        CustomerDetailsdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        CustomerDetailsdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        CustomerDetailsdgv.Size = New Size(823, 533)
        CustomerDetailsdgv.TabIndex = 4
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(5), CByte(25), CByte(35))
        Label1.Location = New Point(4, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(553, 73)
        Label1.TabIndex = 1
        Label1.Text = "Customer Module"
        ' 
        ' AddCustomerbtn
        ' 
        AddCustomerbtn.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddCustomerbtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        AddCustomerbtn.IconColor = Color.LimeGreen
        AddCustomerbtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        AddCustomerbtn.IconSize = 40
        AddCustomerbtn.ImageAlign = ContentAlignment.MiddleLeft
        AddCustomerbtn.Location = New Point(623, 670)
        AddCustomerbtn.Name = "AddCustomerbtn"
        AddCustomerbtn.Padding = New Padding(10)
        AddCustomerbtn.Size = New Size(230, 85)
        AddCustomerbtn.TabIndex = 20
        AddCustomerbtn.Text = "Add "
        AddCustomerbtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(187), CByte(222), CByte(251))
        PictureBox1.Location = New Point(981, 67)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(10, 780)
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1924, 969)
        Controls.Add(PictureBox1)
        Controls.Add(AddCustomerbtn)
        Controls.Add(CustomerDetailsdgv)
        Controls.Add(SearchCustomerlbl)
        Controls.Add(OtherDetailslbl)
        Controls.Add(MobileNumberlbl)
        Controls.Add(Label1)
        Controls.Add(CustomerNamelbl)
        Controls.Add(OtherDetailstb)
        Controls.Add(MobileNumbertb)
        Controls.Add(SearchCustomertb)
        Controls.Add(CustomerNametb)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = " "
        WindowState = FormWindowState.Maximized
        CType(CustomerDetailsdgv, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents CustomerNametb As TextBox
    Friend WithEvents MobileNumbertb As TextBox
    Friend WithEvents OtherDetailstb As TextBox
    Friend WithEvents CustomerNamelbl As Label
    Friend WithEvents MobileNumberlbl As Label
    Friend WithEvents OtherDetailslbl As Label
    Friend WithEvents SearchCustomertb As TextBox
    Friend WithEvents SearchCustomerlbl As Label
    Friend WithEvents CustomerDetailsdgv As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents AddCustomerbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
