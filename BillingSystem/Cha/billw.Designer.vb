<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billw
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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtqtycal = New TextBox()
        txtpricecal = New TextBox()
        txtqty = New TextBox()
        item_pricetxt = New TextBox()
        itemdgv = New DataGridView()
        Button5 = New Button()
        printbtn = New Button()
        btnadd = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        billdgv = New DataGridView()
        Txtitemname = New TextBox()
        txtqtyg = New TextBox()
        TxtPhNb = New TextBox()
        qtykgtxt = New TextBox()
        TxtCusName = New TextBox()
        Label10 = New Label()
        DGVcus_D = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        Label12 = New Label()
        Label11 = New Label()
        txtcusprice = New TextBox()
        btnDelete = New Button()
        TxtBName = New TextBox()
        TxtBQty = New TextBox()
        TxtBPrice = New TextBox()
        Label2 = New Label()
        Btndaytotal = New Button()
        GroupBox1 = New GroupBox()
        txtqtycal1 = New TextBox()
        Btnlending = New Button()
        Lbltoofday = New Label()
        txttotalbill = New Label()
        Lblbalance = New Label()
        GroupBox2 = New GroupBox()
        Btnbillname = New TextBox()
        Btndot = New Button()
        TextBox2 = New TextBox()
        Btnre = New Button()
        GroupBox3 = New GroupBox()
        CType(itemdgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(billdgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVcus_D, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtqtycal
        ' 
        txtqtycal.Location = New Point(205, 524)
        txtqtycal.Margin = New Padding(3, 2, 3, 2)
        txtqtycal.Name = "txtqtycal"
        txtqtycal.Size = New Size(110, 23)
        txtqtycal.TabIndex = 61
        txtqtycal.Visible = False
        ' 
        ' txtpricecal
        ' 
        txtpricecal.Location = New Point(205, 548)
        txtpricecal.Margin = New Padding(3, 2, 3, 2)
        txtpricecal.Name = "txtpricecal"
        txtpricecal.Size = New Size(110, 23)
        txtpricecal.TabIndex = 60
        txtpricecal.Visible = False
        ' 
        ' txtqty
        ' 
        txtqty.Location = New Point(205, 499)
        txtqty.Margin = New Padding(3, 2, 3, 2)
        txtqty.Name = "txtqty"
        txtqty.Size = New Size(110, 23)
        txtqty.TabIndex = 59
        txtqty.Visible = False
        ' 
        ' item_pricetxt
        ' 
        item_pricetxt.Location = New Point(1433, 756)
        item_pricetxt.Margin = New Padding(3, 2, 3, 2)
        item_pricetxt.Name = "item_pricetxt"
        item_pricetxt.Size = New Size(110, 23)
        item_pricetxt.TabIndex = 58
        ' 
        ' itemdgv
        ' 
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F)
        itemdgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        itemdgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        itemdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        itemdgv.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        itemdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        itemdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        itemdgv.DefaultCellStyle = DataGridViewCellStyle3
        itemdgv.Location = New Point(5, 320)
        itemdgv.Margin = New Padding(3, 2, 3, 2)
        itemdgv.Name = "itemdgv"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        itemdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        itemdgv.RowHeadersWidth = 51
        itemdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        itemdgv.Size = New Size(599, 544)
        itemdgv.TabIndex = 55
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 13.8F)
        Button5.Location = New Point(449, 283)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(155, 29)
        Button5.TabIndex = 52
        Button5.Text = "Reset"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' printbtn
        ' 
        printbtn.Font = New Font("Segoe UI", 18F)
        printbtn.Location = New Point(162, 768)
        printbtn.Margin = New Padding(3, 2, 3, 2)
        printbtn.Name = "printbtn"
        printbtn.Size = New Size(314, 92)
        printbtn.TabIndex = 51
        printbtn.Text = "Print"
        printbtn.UseVisualStyleBackColor = True
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.PaleGreen
        btnadd.Font = New Font("Segoe UI", 13.8F)
        btnadd.ForeColor = Color.Black
        btnadd.Location = New Point(26, 285)
        btnadd.Margin = New Padding(3, 2, 3, 2)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(533, 40)
        btnadd.TabIndex = 50
        btnadd.Text = "Add Bill"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F)
        Label5.Location = New Point(26, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 25)
        Label5.TabIndex = 47
        Label5.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F)
        Label4.Location = New Point(26, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 25)
        Label4.TabIndex = 46
        Label4.Text = "Item Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F)
        Label3.Location = New Point(326, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 25)
        Label3.TabIndex = 45
        Label3.Text = "Phone NB"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F)
        Label1.Location = New Point(7, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 25)
        Label1.TabIndex = 43
        Label1.Text = "Customer Name"
        ' 
        ' billdgv
        ' 
        billdgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        billdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        billdgv.BorderStyle = BorderStyle.None
        billdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        billdgv.Location = New Point(6, 50)
        billdgv.Margin = New Padding(3, 2, 3, 2)
        billdgv.Name = "billdgv"
        billdgv.RowHeadersWidth = 51
        billdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        billdgv.Size = New Size(640, 828)
        billdgv.TabIndex = 42
        ' 
        ' Txtitemname
        ' 
        Txtitemname.Font = New Font("Segoe UI", 13.8F)
        Txtitemname.Location = New Point(143, 219)
        Txtitemname.Margin = New Padding(3, 2, 3, 2)
        Txtitemname.Name = "Txtitemname"
        Txtitemname.Size = New Size(418, 32)
        Txtitemname.TabIndex = 40
        ' 
        ' txtqtyg
        ' 
        txtqtyg.Font = New Font("Segoe UI", 13.8F)
        txtqtyg.Location = New Point(379, 252)
        txtqtyg.Margin = New Padding(3, 2, 3, 2)
        txtqtyg.Name = "txtqtyg"
        txtqtyg.Size = New Size(181, 32)
        txtqtyg.TabIndex = 39
        ' 
        ' TxtPhNb
        ' 
        TxtPhNb.Font = New Font("Segoe UI", 13.8F)
        TxtPhNb.Location = New Point(440, 29)
        TxtPhNb.Margin = New Padding(3, 2, 3, 2)
        TxtPhNb.Name = "TxtPhNb"
        TxtPhNb.Size = New Size(121, 32)
        TxtPhNb.TabIndex = 38
        ' 
        ' qtykgtxt
        ' 
        qtykgtxt.BorderStyle = BorderStyle.FixedSingle
        qtykgtxt.Font = New Font("Segoe UI", 13.8F)
        qtykgtxt.Location = New Point(143, 252)
        qtykgtxt.Margin = New Padding(3, 2, 3, 2)
        qtykgtxt.Name = "qtykgtxt"
        qtykgtxt.Size = New Size(165, 32)
        qtykgtxt.TabIndex = 37
        ' 
        ' TxtCusName
        ' 
        TxtCusName.Font = New Font("Segoe UI", 13.8F)
        TxtCusName.Location = New Point(165, 27)
        TxtCusName.Margin = New Padding(3, 2, 3, 2)
        TxtCusName.Name = "TxtCusName"
        TxtCusName.Size = New Size(123, 32)
        TxtCusName.TabIndex = 35
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F)
        Label10.Location = New Point(173, 560)
        Label10.Name = "Label10"
        Label10.Size = New Size(109, 25)
        Label10.TabIndex = 68
        Label10.Text = "Total of day"
        ' 
        ' DGVcus_D
        ' 
        DGVcus_D.AllowUserToResizeColumns = False
        DGVcus_D.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 12F)
        DGVcus_D.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DGVcus_D.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DGVcus_D.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVcus_D.BorderStyle = BorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DGVcus_D.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        DGVcus_D.ColumnHeadersHeight = 29
        DGVcus_D.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Window
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle7.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        DGVcus_D.DefaultCellStyle = DataGridViewCellStyle7
        DGVcus_D.Location = New Point(5, 50)
        DGVcus_D.Margin = New Padding(3, 2, 3, 2)
        DGVcus_D.Name = "DGVcus_D"
        DGVcus_D.ReadOnly = True
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Control
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DGVcus_D.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DGVcus_D.RowHeadersWidth = 51
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 12F)
        DGVcus_D.RowsDefaultCellStyle = DataGridViewCellStyle9
        DGVcus_D.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVcus_D.Size = New Size(599, 205)
        DGVcus_D.TabIndex = 69
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 13.8F)
        Label12.Location = New Point(173, 655)
        Label12.Name = "Label12"
        Label12.Size = New Size(53, 25)
        Label12.TabIndex = 76
        Label12.Text = "Cash"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 13.8F)
        Label11.Location = New Point(172, 693)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 25)
        Label11.TabIndex = 75
        Label11.Text = "Remain"
        ' 
        ' txtcusprice
        ' 
        txtcusprice.Font = New Font("Segoe UI", 13.8F)
        txtcusprice.Location = New Point(288, 655)
        txtcusprice.Margin = New Padding(3, 2, 3, 2)
        txtcusprice.Name = "txtcusprice"
        txtcusprice.Size = New Size(159, 32)
        txtcusprice.TabIndex = 73
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 13.8F)
        btnDelete.ForeColor = SystemColors.ActiveCaptionText
        btnDelete.Location = New Point(491, 13)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(155, 29)
        btnDelete.TabIndex = 80
        btnDelete.Text = "Reset"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' TxtBName
        ' 
        TxtBName.Location = New Point(337, 499)
        TxtBName.Margin = New Padding(3, 2, 3, 2)
        TxtBName.Name = "TxtBName"
        TxtBName.Size = New Size(110, 23)
        TxtBName.TabIndex = 83
        TxtBName.Visible = False
        ' 
        ' TxtBQty
        ' 
        TxtBQty.Location = New Point(337, 555)
        TxtBQty.Margin = New Padding(3, 2, 3, 2)
        TxtBQty.Name = "TxtBQty"
        TxtBQty.Size = New Size(110, 23)
        TxtBQty.TabIndex = 82
        TxtBQty.Visible = False
        ' 
        ' TxtBPrice
        ' 
        TxtBPrice.Location = New Point(337, 524)
        TxtBPrice.Margin = New Padding(3, 2, 3, 2)
        TxtBPrice.Name = "TxtBPrice"
        TxtBPrice.Size = New Size(110, 23)
        TxtBPrice.TabIndex = 81
        TxtBPrice.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F)
        Label2.Location = New Point(172, 475)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 25)
        Label2.TabIndex = 84
        Label2.Text = "Total of Bill"
        ' 
        ' Btndaytotal
        ' 
        Btndaytotal.Font = New Font("Segoe UI", 12F)
        Btndaytotal.Location = New Point(162, 383)
        Btndaytotal.Margin = New Padding(3, 2, 3, 2)
        Btndaytotal.Name = "Btndaytotal"
        Btndaytotal.Size = New Size(314, 56)
        Btndaytotal.TabIndex = 85
        Btndaytotal.Text = "Daily Bills"
        Btndaytotal.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtqtycal1)
        GroupBox1.Controls.Add(Btnlending)
        GroupBox1.Controls.Add(TxtCusName)
        GroupBox1.Controls.Add(Lbltoofday)
        GroupBox1.Controls.Add(TxtPhNb)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(qtykgtxt)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txttotalbill)
        GroupBox1.Controls.Add(Btndaytotal)
        GroupBox1.Controls.Add(txtqtyg)
        GroupBox1.Controls.Add(txtpricecal)
        GroupBox1.Controls.Add(Txtitemname)
        GroupBox1.Controls.Add(txtqtycal)
        GroupBox1.Controls.Add(TxtBQty)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TxtBName)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtqty)
        GroupBox1.Controls.Add(btnadd)
        GroupBox1.Controls.Add(TxtBPrice)
        GroupBox1.Controls.Add(Lblbalance)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txtcusprice)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(printbtn)
        GroupBox1.Location = New Point(662, 11)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(576, 874)
        GroupBox1.TabIndex = 86
        GroupBox1.TabStop = False
        ' 
        ' txtqtycal1
        ' 
        txtqtycal1.Location = New Point(187, 589)
        txtqtycal1.Margin = New Padding(3, 2, 3, 2)
        txtqtycal1.Name = "txtqtycal1"
        txtqtycal1.Size = New Size(110, 23)
        txtqtycal1.TabIndex = 90
        txtqtycal1.Visible = False
        ' 
        ' Btnlending
        ' 
        Btnlending.Font = New Font("Segoe UI", 13.8F)
        Btnlending.ForeColor = SystemColors.ActiveCaptionText
        Btnlending.Location = New Point(162, 734)
        Btnlending.Margin = New Padding(3, 2, 3, 2)
        Btnlending.Name = "Btnlending"
        Btnlending.Size = New Size(314, 29)
        Btnlending.TabIndex = 81
        Btnlending.Text = "Lending"
        Btnlending.UseVisualStyleBackColor = True
        ' 
        ' Lbltoofday
        ' 
        Lbltoofday.AutoSize = True
        Lbltoofday.Font = New Font("Segoe UI", 13.8F)
        Lbltoofday.Location = New Point(288, 563)
        Lbltoofday.Name = "Lbltoofday"
        Lbltoofday.Size = New Size(0, 25)
        Lbltoofday.TabIndex = 87
        ' 
        ' txttotalbill
        ' 
        txttotalbill.AutoSize = True
        txttotalbill.Font = New Font("Segoe UI", 13.8F)
        txttotalbill.Location = New Point(288, 475)
        txttotalbill.Name = "txttotalbill"
        txttotalbill.Size = New Size(0, 25)
        txttotalbill.TabIndex = 89
        ' 
        ' Lblbalance
        ' 
        Lblbalance.AutoSize = True
        Lblbalance.Font = New Font("Segoe UI", 13.8F)
        Lblbalance.Location = New Point(288, 693)
        Lblbalance.Name = "Lblbalance"
        Lblbalance.Size = New Size(0, 25)
        Lblbalance.TabIndex = 87
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Btnbillname)
        GroupBox2.Controls.Add(Btndot)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(billdgv)
        GroupBox2.Controls.Add(btnDelete)
        GroupBox2.Location = New Point(1244, 7)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(652, 894)
        GroupBox2.TabIndex = 87
        GroupBox2.TabStop = False
        ' 
        ' Btnbillname
        ' 
        Btnbillname.Location = New Point(245, 289)
        Btnbillname.Margin = New Padding(3, 2, 3, 2)
        Btnbillname.Name = "Btnbillname"
        Btnbillname.Size = New Size(110, 23)
        Btnbillname.TabIndex = 84
        Btnbillname.Visible = False
        ' 
        ' Btndot
        ' 
        Btndot.Location = New Point(-37, 490)
        Btndot.Margin = New Padding(3, 2, 3, 2)
        Btndot.Name = "Btndot"
        Btndot.Size = New Size(32, 22)
        Btndot.TabIndex = 82
        Btndot.Text = "Button1"
        Btndot.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(245, 251)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(110, 23)
        TextBox2.TabIndex = 81
        TextBox2.Visible = False
        ' 
        ' Btnre
        ' 
        Btnre.Location = New Point(615, 464)
        Btnre.Margin = New Padding(3, 2, 3, 2)
        Btnre.Name = "Btnre"
        Btnre.Size = New Size(34, 22)
        Btnre.TabIndex = 83
        Btnre.Text = "Button1"
        Btnre.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(DGVcus_D)
        GroupBox3.Controls.Add(Btnre)
        GroupBox3.Controls.Add(itemdgv)
        GroupBox3.Controls.Add(Button5)
        GroupBox3.Location = New Point(10, 7)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(610, 878)
        GroupBox3.TabIndex = 88
        GroupBox3.TabStop = False
        ' 
        ' billw
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1908, 896)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(item_pricetxt)
        Margin = New Padding(3, 2, 3, 2)
        Name = "billw"
        Text = "Form2"
        CType(itemdgv, ComponentModel.ISupportInitialize).EndInit()
        CType(billdgv, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVcus_D, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtqtycal As TextBox
    Friend WithEvents txtpricecal As TextBox
    Friend WithEvents txtqty As TextBox
    Friend WithEvents item_pricetxt As TextBox
    Friend WithEvents itemdgv As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents printbtn As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents billdgv As DataGridView
    Friend WithEvents Txtitemname As TextBox
    Friend WithEvents txtqtyg As TextBox
    Friend WithEvents TxtPhNb As TextBox
    Friend WithEvents qtykgtxt As TextBox
    Friend WithEvents TxtCusName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DGVcus_D As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcusprice As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents TxtBName As TextBox
    Friend WithEvents TxtBQty As TextBox
    Friend WithEvents TxtBPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btndaytotal As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lblbalance As Label
    Friend WithEvents txttotalbill As Label
    Friend WithEvents Lbltoofday As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btnbillname As TextBox
    Friend WithEvents Btnre As Button
    Friend WithEvents Btndot As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Btnlending As Button
    Friend WithEvents txtqtycal1 As TextBox
End Class
