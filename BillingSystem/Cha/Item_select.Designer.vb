<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item_select
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Item_List = New CheckedListBox()
        Label1 = New Label()
        Selected_List = New ListBox()
        SaveTodayBtn = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SelectAllCheck = New CheckBox()
        TxtSearch = New TextBox()
        Panel1 = New Panel()
        DateTimePicker = New DateTimePicker()
        GroupBox1 = New GroupBox()
        BtnUpdate = New Button()
        Label5 = New Label()
        Label6 = New Label()
        NameCombo = New ComboBox()
        TxtOPrice = New TextBox()
        TxtMPrice = New TextBox()
        TxtG = New TextBox()
        TxtKg = New TextBox()
        TxtCode = New TextBox()
        Label12 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label7 = New Label()
        Label11 = New Label()
        ItemGrid = New DataGridView()
        TxtSerch = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        ErrorProvider3 = New ErrorProvider(components)
        ErrorProvider4 = New ErrorProvider(components)
        ErrorProvider5 = New ErrorProvider(components)
        ErrorProvider6 = New ErrorProvider(components)
        GroupBox1.SuspendLayout()
        CType(ItemGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider4, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider5, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Item_List
        ' 
        Item_List.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Item_List.BorderStyle = BorderStyle.FixedSingle
        Item_List.CheckOnClick = True
        Item_List.Cursor = Cursors.Hand
        Item_List.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Item_List.FormattingEnabled = True
        Item_List.Location = New Point(25, 124)
        Item_List.Name = "Item_List"
        Item_List.Size = New Size(241, 692)
        Item_List.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(616, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 65)
        Label1.TabIndex = 28
        Label1.Text = "Today List"
        ' 
        ' Selected_List
        ' 
        Selected_List.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Selected_List.BorderStyle = BorderStyle.FixedSingle
        Selected_List.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Selected_List.FormattingEnabled = True
        Selected_List.ItemHeight = 29
        Selected_List.Location = New Point(326, 125)
        Selected_List.Name = "Selected_List"
        Selected_List.Size = New Size(241, 698)
        Selected_List.TabIndex = 29
        ' 
        ' SaveTodayBtn
        ' 
        SaveTodayBtn.BackColor = Color.LightGreen
        SaveTodayBtn.Font = New Font("Segoe UI", 18F)
        SaveTodayBtn.Location = New Point(25, 12)
        SaveTodayBtn.Name = "SaveTodayBtn"
        SaveTodayBtn.Size = New Size(542, 47)
        SaveTodayBtn.TabIndex = 30
        SaveTodayBtn.Text = "Save Today List"
        SaveTodayBtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F)
        Label2.ForeColor = Color.DeepSkyBlue
        Label2.Location = New Point(89, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 32)
        Label2.TabIndex = 28
        Label2.Text = "All Items"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 18F)
        Label3.ForeColor = Color.DeepSkyBlue
        Label3.Location = New Point(362, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 32)
        Label3.TabIndex = 28
        Label3.Text = "Selected Items"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.LimeGreen
        Label4.Location = New Point(272, 458)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 31)
        Label4.TabIndex = 28
        Label4.Text = ">>"
        ' 
        ' SelectAllCheck
        ' 
        SelectAllCheck.AutoSize = True
        SelectAllCheck.Font = New Font("Segoe UI", 18F)
        SelectAllCheck.Location = New Point(25, 844)
        SelectAllCheck.Name = "SelectAllCheck"
        SelectAllCheck.Size = New Size(131, 36)
        SelectAllCheck.TabIndex = 31
        SelectAllCheck.Text = "Select All"
        SelectAllCheck.UseVisualStyleBackColor = True
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        TxtSearch.Location = New Point(286, 845)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.PlaceholderText = "  Serch Item"
        TxtSearch.Size = New Size(290, 35)
        TxtSearch.TabIndex = 32
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightBlue
        Panel1.Location = New Point(582, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(10, 877)
        Panel1.TabIndex = 34
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.CalendarFont = New Font("Segoe UI", 18F)
        DateTimePicker.Enabled = False
        DateTimePicker.Location = New Point(1639, 53)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(257, 23)
        DateTimePicker.TabIndex = 36
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BtnUpdate)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(NameCombo)
        GroupBox1.Controls.Add(TxtOPrice)
        GroupBox1.Controls.Add(TxtMPrice)
        GroupBox1.Controls.Add(TxtG)
        GroupBox1.Controls.Add(TxtKg)
        GroupBox1.Controls.Add(TxtCode)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.DeepSkyBlue
        GroupBox1.Location = New Point(616, 67)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1280, 229)
        GroupBox1.TabIndex = 35
        GroupBox1.TabStop = False
        GroupBox1.Text = "ITEMS DETAILS"
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.BackColor = Color.PaleTurquoise
        BtnUpdate.Font = New Font("Segoe UI", 18F)
        BtnUpdate.ForeColor = Color.Black
        BtnUpdate.Location = New Point(886, 163)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(369, 48)
        BtnUpdate.TabIndex = 31
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(526, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 32)
        Label5.TabIndex = 30
        Label5.Text = "g"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(320, 168)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 32)
        Label6.TabIndex = 30
        Label6.Text = "Kg"
        ' 
        ' NameCombo
        ' 
        NameCombo.DropDownStyle = ComboBoxStyle.DropDownList
        NameCombo.Font = New Font("Microsoft Sans Serif", 18F)
        NameCombo.FormattingEnabled = True
        NameCombo.Location = New Point(180, 107)
        NameCombo.Name = "NameCombo"
        NameCombo.Size = New Size(369, 37)
        NameCombo.TabIndex = 29
        ' 
        ' TxtOPrice
        ' 
        TxtOPrice.Font = New Font("Microsoft Sans Serif", 18F)
        TxtOPrice.Location = New Point(886, 110)
        TxtOPrice.Multiline = True
        TxtOPrice.Name = "TxtOPrice"
        TxtOPrice.Size = New Size(369, 35)
        TxtOPrice.TabIndex = 28
        ' 
        ' TxtMPrice
        ' 
        TxtMPrice.Font = New Font("Microsoft Sans Serif", 18F)
        TxtMPrice.Location = New Point(886, 60)
        TxtMPrice.Multiline = True
        TxtMPrice.Name = "TxtMPrice"
        TxtMPrice.Size = New Size(369, 34)
        TxtMPrice.TabIndex = 28
        ' 
        ' TxtG
        ' 
        TxtG.Font = New Font("Microsoft Sans Serif", 18F)
        TxtG.Location = New Point(387, 166)
        TxtG.Multiline = True
        TxtG.Name = "TxtG"
        TxtG.PlaceholderText = "g"
        TxtG.Size = New Size(133, 35)
        TxtG.TabIndex = 28
        ' 
        ' TxtKg
        ' 
        TxtKg.Font = New Font("Microsoft Sans Serif", 18F)
        TxtKg.Location = New Point(180, 165)
        TxtKg.Multiline = True
        TxtKg.Name = "TxtKg"
        TxtKg.PlaceholderText = "Kg"
        TxtKg.Size = New Size(134, 35)
        TxtKg.TabIndex = 28
        ' 
        ' TxtCode
        ' 
        TxtCode.BackColor = Color.White
        TxtCode.Font = New Font("Microsoft Sans Serif", 18F)
        TxtCode.Location = New Point(180, 58)
        TxtCode.Multiline = True
        TxtCode.Name = "TxtCode"
        TxtCode.ReadOnly = True
        TxtCode.Size = New Size(369, 35)
        TxtCode.TabIndex = 28
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ActiveCaptionText
        Label12.Location = New Point(28, 59)
        Label12.Name = "Label12"
        Label12.Size = New Size(135, 32)
        Label12.TabIndex = 24
        Label12.Text = "ITEM CODE"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 18F)
        Label15.ForeColor = SystemColors.ActiveCaptionText
        Label15.Location = New Point(28, 168)
        Label15.Name = "Label15"
        Label15.Size = New Size(123, 32)
        Label15.TabIndex = 25
        Label15.Text = "QUENTITY"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 18F)
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(28, 110)
        Label14.Name = "Label14"
        Label14.Size = New Size(141, 32)
        Label14.TabIndex = 26
        Label14.Text = "ITEM NAME"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 18F)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(619, 110)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 32)
        Label7.TabIndex = 27
        Label7.Text = "OUR PRICE (KG)"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 18F)
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(615, 60)
        Label11.Name = "Label11"
        Label11.Size = New Size(221, 32)
        Label11.TabIndex = 27
        Label11.Text = "MARKET PRICE (KG)"
        ' 
        ' ItemGrid
        ' 
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        DataGridViewCellStyle3.SelectionBackColor = Color.DodgerBlue
        ItemGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        ItemGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ItemGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ItemGrid.BackgroundColor = Color.White
        ItemGrid.BorderStyle = BorderStyle.Fixed3D
        ItemGrid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        ItemGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        ItemGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemGrid.Location = New Point(616, 346)
        ItemGrid.Name = "ItemGrid"
        ItemGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        ItemGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        ItemGrid.ScrollBars = ScrollBars.Vertical
        ItemGrid.SelectionMode = DataGridViewSelectionMode.CellSelect
        ItemGrid.Size = New Size(1280, 534)
        ItemGrid.TabIndex = 39
        ' 
        ' TxtSerch
        ' 
        TxtSerch.Font = New Font("Segoe UI", 18F)
        TxtSerch.Location = New Point(1502, 301)
        TxtSerch.Name = "TxtSerch"
        TxtSerch.PlaceholderText = "Search Item Name"
        TxtSerch.Size = New Size(394, 39)
        TxtSerch.TabIndex = 38
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
        ' ErrorProvider4
        ' 
        ErrorProvider4.ContainerControl = Me
        ' 
        ' ErrorProvider5
        ' 
        ErrorProvider5.ContainerControl = Me
        ' 
        ' ErrorProvider6
        ' 
        ErrorProvider6.ContainerControl = Me
        ' 
        ' Item_select
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1924, 892)
        Controls.Add(ItemGrid)
        Controls.Add(TxtSerch)
        Controls.Add(DateTimePicker)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(TxtSearch)
        Controls.Add(SelectAllCheck)
        Controls.Add(SaveTodayBtn)
        Controls.Add(Selected_List)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Item_List)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Item_select"
        Text = "Item_select"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ItemGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider4, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider5, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Item_List As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Selected_List As ListBox
    Friend WithEvents SaveTodayBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SelectAllCheck As CheckBox
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NameCombo As ComboBox
    Friend WithEvents TxtOPrice As TextBox
    Friend WithEvents TxtMPrice As TextBox
    Friend WithEvents TxtG As TextBox
    Friend WithEvents TxtKg As TextBox
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents ItemGrid As DataGridView
    Friend WithEvents TxtSerch As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents ErrorProvider5 As ErrorProvider
    Friend WithEvents ErrorProvider6 As ErrorProvider
End Class
