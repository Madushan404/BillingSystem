<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        PanelDesktop = New Panel()
        Panel1 = New Panel()
        WholeSalebtn = New FontAwesome.Sharp.IconButton()
        LogOutbtn = New FontAwesome.Sharp.IconButton()
        LendingBillsbtn = New FontAwesome.Sharp.IconButton()
        Inventorybtn = New FontAwesome.Sharp.IconButton()
        TodayItemsbtn = New FontAwesome.Sharp.IconButton()
        Billingbtn = New FontAwesome.Sharp.IconButton()
        AddCustomerbtn = New FontAwesome.Sharp.IconButton()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = Color.White
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(0, 118)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(1924, 890)
        PanelDesktop.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(WholeSalebtn)
        Panel1.Controls.Add(LogOutbtn)
        Panel1.Controls.Add(LendingBillsbtn)
        Panel1.Controls.Add(Inventorybtn)
        Panel1.Controls.Add(TodayItemsbtn)
        Panel1.Controls.Add(Billingbtn)
        Panel1.Controls.Add(AddCustomerbtn)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1924, 118)
        Panel1.TabIndex = 0
        ' 
        ' WholeSalebtn
        ' 
        WholeSalebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        WholeSalebtn.IconChar = FontAwesome.Sharp.IconChar.None
        WholeSalebtn.IconColor = Color.Black
        WholeSalebtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        WholeSalebtn.Location = New Point(1182, 20)
        WholeSalebtn.Name = "WholeSalebtn"
        WholeSalebtn.Size = New Size(192, 74)
        WholeSalebtn.TabIndex = 1
        WholeSalebtn.Text = "Whole Sale"
        WholeSalebtn.UseVisualStyleBackColor = True
        ' 
        ' LogOutbtn
        ' 
        LogOutbtn.BackColor = Color.Red
        LogOutbtn.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold)
        LogOutbtn.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket
        LogOutbtn.IconColor = Color.White
        LogOutbtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        LogOutbtn.IconSize = 35
        LogOutbtn.Location = New Point(1789, -1)
        LogOutbtn.Name = "LogOutbtn"
        LogOutbtn.Size = New Size(132, 118)
        LogOutbtn.TabIndex = 1
        LogOutbtn.UseVisualStyleBackColor = False
        ' 
        ' LendingBillsbtn
        ' 
        LendingBillsbtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        LendingBillsbtn.IconChar = FontAwesome.Sharp.IconChar.None
        LendingBillsbtn.IconColor = Color.Black
        LendingBillsbtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        LendingBillsbtn.Location = New Point(984, 20)
        LendingBillsbtn.Name = "LendingBillsbtn"
        LendingBillsbtn.Size = New Size(192, 74)
        LendingBillsbtn.TabIndex = 1
        LendingBillsbtn.Text = "Lending Bills"
        LendingBillsbtn.UseVisualStyleBackColor = True
        ' 
        ' Inventorybtn
        ' 
        Inventorybtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Inventorybtn.IconChar = FontAwesome.Sharp.IconChar.Warehouse
        Inventorybtn.IconColor = Color.Black
        Inventorybtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        Inventorybtn.IconSize = 40
        Inventorybtn.ImageAlign = ContentAlignment.MiddleLeft
        Inventorybtn.Location = New Point(786, 20)
        Inventorybtn.Name = "Inventorybtn"
        Inventorybtn.Padding = New Padding(10)
        Inventorybtn.Size = New Size(192, 74)
        Inventorybtn.TabIndex = 1
        Inventorybtn.Text = "    Inventory"
        Inventorybtn.UseVisualStyleBackColor = True
        ' 
        ' TodayItemsbtn
        ' 
        TodayItemsbtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        TodayItemsbtn.IconChar = FontAwesome.Sharp.IconChar.RectangleList
        TodayItemsbtn.IconColor = Color.Black
        TodayItemsbtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        TodayItemsbtn.IconSize = 40
        TodayItemsbtn.ImageAlign = ContentAlignment.MiddleLeft
        TodayItemsbtn.Location = New Point(588, 20)
        TodayItemsbtn.Name = "TodayItemsbtn"
        TodayItemsbtn.Padding = New Padding(10)
        TodayItemsbtn.Size = New Size(192, 74)
        TodayItemsbtn.TabIndex = 1
        TodayItemsbtn.Text = "Today Iist"
        TodayItemsbtn.UseVisualStyleBackColor = True
        ' 
        ' Billingbtn
        ' 
        Billingbtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Billingbtn.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar
        Billingbtn.IconColor = Color.Black
        Billingbtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        Billingbtn.IconSize = 40
        Billingbtn.ImageAlign = ContentAlignment.MiddleLeft
        Billingbtn.Location = New Point(390, 20)
        Billingbtn.Name = "Billingbtn"
        Billingbtn.Padding = New Padding(10)
        Billingbtn.Size = New Size(192, 74)
        Billingbtn.TabIndex = 1
        Billingbtn.Text = "    Billing"
        Billingbtn.UseVisualStyleBackColor = True
        ' 
        ' AddCustomerbtn
        ' 
        AddCustomerbtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddCustomerbtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        AddCustomerbtn.IconColor = Color.Black
        AddCustomerbtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        AddCustomerbtn.IconSize = 40
        AddCustomerbtn.ImageAlign = ContentAlignment.MiddleLeft
        AddCustomerbtn.Location = New Point(1380, 20)
        AddCustomerbtn.Name = "AddCustomerbtn"
        AddCustomerbtn.Padding = New Padding(10)
        AddCustomerbtn.Size = New Size(192, 74)
        AddCustomerbtn.TabIndex = 1
        AddCustomerbtn.Text = "Add Customer"
        AddCustomerbtn.TextAlign = ContentAlignment.MiddleRight
        AddCustomerbtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(72, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(221, 118)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1008)
        Controls.Add(PanelDesktop)
        Controls.Add(Panel1)
        Name = "Form6"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AddCustomerbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Inventorybtn As FontAwesome.Sharp.IconButton
    Friend WithEvents TodayItemsbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Billingbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents LogOutbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents WholeSalebtn As FontAwesome.Sharp.IconButton
    Friend WithEvents LendingBillsbtn As FontAwesome.Sharp.IconButton

End Class
