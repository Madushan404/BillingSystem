<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class billg
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        qtykgtxt = New TextBox()
        txtqtyg = New TextBox()
        TxtItemname = New TextBox()
        billdgv = New DataGridView()
        Label4 = New Label()
        Label5 = New Label()
        btnadd = New Button()
        printbtn = New Button()
        Button5 = New Button()
        itemdgv = New DataGridView()
        Label10 = New Label()
        item_pricetxt = New TextBox()
        txtqty = New TextBox()
        txtpricecal = New TextBox()
        txtqtycal = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        btnDelete = New Button()
        LblBillNo = New Label()
        TxtBName = New TextBox()
        TxtBQty = New TextBox()
        TxtBPrice = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        txtcusprice = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        txtqtycal1 = New TextBox()
        Lbltoofday = New Label()
        Lblbalance = New Label()
        Lbltotalbill = New Label()
        Lbltotalday = New Label()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        Btnbillname = New TextBox()
        TextBox2 = New TextBox()
        Btndot = New Button()
        Btnre = New Button()
        GroupBox3 = New GroupBox()
        Label6 = New Label()
        GroupBox4 = New GroupBox()
        Label2 = New Label()
        CType(billdgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(itemdgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' qtykgtxt
        ' 
        qtykgtxt.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        qtykgtxt.Location = New Point(156, 153)
        qtykgtxt.Margin = New Padding(3, 2, 3, 2)
        qtykgtxt.Name = "qtykgtxt"
        qtykgtxt.Size = New Size(186, 35)
        qtykgtxt.TabIndex = 4
        ' 
        ' txtqtyg
        ' 
        txtqtyg.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtqtyg.Location = New Point(361, 153)
        txtqtyg.Margin = New Padding(3, 2, 3, 2)
        txtqtyg.Name = "txtqtyg"
        txtqtyg.Size = New Size(189, 35)
        txtqtyg.TabIndex = 6
        ' 
        ' TxtItemname
        ' 
        TxtItemname.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtItemname.Location = New Point(156, 98)
        TxtItemname.Margin = New Padding(3, 2, 3, 2)
        TxtItemname.Name = "TxtItemname"
        TxtItemname.Size = New Size(394, 35)
        TxtItemname.TabIndex = 7
        ' 
        ' billdgv
        ' 
        billdgv.AllowUserToResizeColumns = False
        billdgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New Font("Adobe Clean SemiCondensed", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        billdgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        billdgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        billdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        billdgv.BorderStyle = BorderStyle.None
        billdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        billdgv.DefaultCellStyle = DataGridViewCellStyle2
        billdgv.Location = New Point(6, 53)
        billdgv.Margin = New Padding(3, 2, 3, 2)
        billdgv.Name = "billdgv"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        billdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        billdgv.RowHeadersWidth = 51
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 12F)
        billdgv.RowsDefaultCellStyle = DataGridViewCellStyle4
        billdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        billdgv.Size = New Size(640, 873)
        billdgv.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(33, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 30)
        Label4.TabIndex = 13
        Label4.Text = "Item Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(41, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 30)
        Label5.TabIndex = 14
        Label5.Text = "Quantity"
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.LightBlue
        btnadd.FlatStyle = FlatStyle.Popup
        btnadd.Font = New Font("Segoe UI", 13.8F)
        btnadd.Location = New Point(34, 232)
        btnadd.Margin = New Padding(3, 2, 3, 2)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(516, 82)
        btnadd.TabIndex = 18
        btnadd.Text = "Add Bill"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' printbtn
        ' 
        printbtn.BackColor = Color.Blue
        printbtn.Font = New Font("Segoe UI", 18F)
        printbtn.ForeColor = SystemColors.HighlightText
        printbtn.Location = New Point(34, 374)
        printbtn.Margin = New Padding(3, 2, 3, 2)
        printbtn.Name = "printbtn"
        printbtn.Size = New Size(516, 110)
        printbtn.TabIndex = 20
        printbtn.Text = "Bill"
        printbtn.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LightCoral
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(422, 16)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(234, 29)
        Button5.TabIndex = 21
        Button5.Text = "Reset"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' itemdgv
        ' 
        itemdgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        itemdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        itemdgv.BorderStyle = BorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        itemdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        itemdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 13.8F)
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        itemdgv.DefaultCellStyle = DataGridViewCellStyle6
        itemdgv.Location = New Point(0, 53)
        itemdgv.Margin = New Padding(3, 2, 3, 2)
        itemdgv.Name = "itemdgv"
        itemdgv.RowHeadersWidth = 51
        itemdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        itemdgv.Size = New Size(656, 834)
        itemdgv.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F)
        Label10.Location = New Point(84, 174)
        Label10.Name = "Label10"
        Label10.Size = New Size(109, 25)
        Label10.TabIndex = 27
        Label10.Text = "Total of day"
        ' 
        ' item_pricetxt
        ' 
        item_pricetxt.Location = New Point(482, 19)
        item_pricetxt.Margin = New Padding(3, 2, 3, 2)
        item_pricetxt.Name = "item_pricetxt"
        item_pricetxt.Size = New Size(10, 23)
        item_pricetxt.TabIndex = 31
        item_pricetxt.Visible = False
        ' 
        ' txtqty
        ' 
        txtqty.Location = New Point(482, 47)
        txtqty.Margin = New Padding(3, 2, 3, 2)
        txtqty.Name = "txtqty"
        txtqty.Size = New Size(10, 23)
        txtqty.TabIndex = 32
        txtqty.Visible = False
        ' 
        ' txtpricecal
        ' 
        txtpricecal.Location = New Point(482, 73)
        txtpricecal.Margin = New Padding(3, 2, 3, 2)
        txtpricecal.Name = "txtpricecal"
        txtpricecal.Size = New Size(10, 23)
        txtpricecal.TabIndex = 33
        txtpricecal.Visible = False
        ' 
        ' txtqtycal
        ' 
        txtqtycal.Location = New Point(482, 98)
        txtqtycal.Margin = New Padding(3, 2, 3, 2)
        txtqtycal.Name = "txtqtycal"
        txtqtycal.Size = New Size(10, 23)
        txtqtycal.TabIndex = 34
        txtqtycal.Visible = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.LightCoral
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(407, 17)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(234, 29)
        btnDelete.TabIndex = 36
        btnDelete.Text = "Cancel Bill"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' LblBillNo
        ' 
        LblBillNo.AutoSize = True
        LblBillNo.Location = New Point(95, 65)
        LblBillNo.Name = "LblBillNo"
        LblBillNo.Size = New Size(0, 32)
        LblBillNo.TabIndex = 39
        ' 
        ' TxtBName
        ' 
        TxtBName.Location = New Point(498, 24)
        TxtBName.Margin = New Padding(3, 2, 3, 2)
        TxtBName.Name = "TxtBName"
        TxtBName.Size = New Size(10, 23)
        TxtBName.TabIndex = 46
        TxtBName.Visible = False
        ' 
        ' TxtBQty
        ' 
        TxtBQty.Location = New Point(498, 73)
        TxtBQty.Margin = New Padding(3, 2, 3, 2)
        TxtBQty.Name = "TxtBQty"
        TxtBQty.Size = New Size(10, 23)
        TxtBQty.TabIndex = 45
        TxtBQty.Visible = False
        ' 
        ' TxtBPrice
        ' 
        TxtBPrice.Location = New Point(498, 48)
        TxtBPrice.Margin = New Padding(3, 2, 3, 2)
        TxtBPrice.Name = "TxtBPrice"
        TxtBPrice.Size = New Size(10, 23)
        TxtBPrice.TabIndex = 44
        TxtBPrice.Visible = False
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 13.8F)
        Label12.Location = New Point(84, 241)
        Label12.Name = "Label12"
        Label12.Size = New Size(53, 25)
        Label12.TabIndex = 81
        Label12.Text = "Cash"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 13.8F)
        Label11.Location = New Point(84, 286)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 25)
        Label11.TabIndex = 80
        Label11.Text = "Remain"
        ' 
        ' txtcusprice
        ' 
        txtcusprice.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtcusprice.Font = New Font("Segoe UI", 18F)
        txtcusprice.Location = New Point(218, 232)
        txtcusprice.Margin = New Padding(3, 2, 3, 2)
        txtcusprice.Name = "txtcusprice"
        txtcusprice.Size = New Size(289, 39)
        txtcusprice.TabIndex = 78
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F)
        Label1.Location = New Point(84, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 82
        Label1.Text = "Total of Bill"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightSteelBlue
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtqtycal1)
        GroupBox1.Controls.Add(Lbltoofday)
        GroupBox1.Controls.Add(TxtBName)
        GroupBox1.Controls.Add(TxtBQty)
        GroupBox1.Controls.Add(Lblbalance)
        GroupBox1.Controls.Add(TxtBPrice)
        GroupBox1.Controls.Add(Lbltotalbill)
        GroupBox1.Controls.Add(Lbltotalday)
        GroupBox1.Controls.Add(txtqtycal)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(txtpricecal)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(txtqty)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(item_pricetxt)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txtcusprice)
        GroupBox1.Controls.Add(printbtn)
        GroupBox1.Location = New Point(662, 389)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(576, 501)
        GroupBox1.TabIndex = 84
        GroupBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkCyan
        Label3.Location = New Point(425, 6)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 40)
        Label3.TabIndex = 85
        Label3.Text = "Create Bill"
        ' 
        ' txtqtycal1
        ' 
        txtqtycal1.Location = New Point(498, 98)
        txtqtycal1.Margin = New Padding(3, 2, 3, 2)
        txtqtycal1.Name = "txtqtycal1"
        txtqtycal1.Size = New Size(10, 23)
        txtqtycal1.TabIndex = 87
        txtqtycal1.Visible = False
        ' 
        ' Lbltoofday
        ' 
        Lbltoofday.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Lbltoofday.AutoSize = True
        Lbltoofday.Font = New Font("Segoe UI", 13.8F)
        Lbltoofday.Location = New Point(218, 174)
        Lbltoofday.Name = "Lbltoofday"
        Lbltoofday.Size = New Size(0, 25)
        Lbltoofday.TabIndex = 85
        ' 
        ' Lblbalance
        ' 
        Lblbalance.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Lblbalance.AutoSize = True
        Lblbalance.Font = New Font("Segoe UI", 18F)
        Lblbalance.Location = New Point(218, 280)
        Lblbalance.Name = "Lblbalance"
        Lblbalance.Size = New Size(0, 32)
        Lblbalance.TabIndex = 86
        ' 
        ' Lbltotalbill
        ' 
        Lbltotalbill.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Lbltotalbill.AutoSize = True
        Lbltotalbill.Font = New Font("Segoe UI", 18F)
        Lbltotalbill.Location = New Point(218, 117)
        Lbltotalbill.Name = "Lbltotalbill"
        Lbltotalbill.Size = New Size(0, 32)
        Lbltotalbill.TabIndex = 85
        ' 
        ' Lbltotalday
        ' 
        Lbltotalday.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Lbltotalday.AutoSize = True
        Lbltotalday.Location = New Point(163, 174)
        Lbltotalday.Name = "Lbltotalday"
        Lbltotalday.Size = New Size(0, 15)
        Lbltotalday.TabIndex = 83
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Btnbillname)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(billdgv)
        GroupBox2.Controls.Add(btnDelete)
        GroupBox2.Location = New Point(1249, -2)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(652, 894)
        GroupBox2.TabIndex = 87
        GroupBox2.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.FlatStyle = FlatStyle.Popup
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(6, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 30)
        Label7.TabIndex = 87
        Label7.Text = "Billing List"
        ' 
        ' Btnbillname
        ' 
        Btnbillname.Location = New Point(112, 307)
        Btnbillname.Margin = New Padding(3, 2, 3, 2)
        Btnbillname.Name = "Btnbillname"
        Btnbillname.Size = New Size(110, 23)
        Btnbillname.TabIndex = 43
        Btnbillname.Visible = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(112, 269)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(110, 23)
        TextBox2.TabIndex = 40
        TextBox2.Visible = False
        ' 
        ' Btndot
        ' 
        Btndot.Location = New Point(626, 880)
        Btndot.Margin = New Padding(3, 2, 3, 2)
        Btndot.Name = "Btndot"
        Btndot.Size = New Size(10, 10)
        Btndot.TabIndex = 41
        Btndot.Text = "Button1"
        Btndot.UseVisualStyleBackColor = True
        ' 
        ' Btnre
        ' 
        Btnre.Location = New Point(558, 518)
        Btnre.Margin = New Padding(3, 2, 3, 2)
        Btnre.Name = "Btnre"
        Btnre.Size = New Size(53, 22)
        Btnre.TabIndex = 42
        Btnre.Text = "Button1"
        Btnre.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.White
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(GroupBox4)
        GroupBox3.Controls.Add(Btndot)
        GroupBox3.Controls.Add(GroupBox1)
        GroupBox3.Controls.Add(itemdgv)
        GroupBox3.Controls.Add(Button5)
        GroupBox3.Location = New Point(5, -2)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(1244, 894)
        GroupBox3.TabIndex = 88
        GroupBox3.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(0, 16)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 30)
        Label6.TabIndex = 86
        Label6.Text = "Today Vegi List"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Gainsboro
        GroupBox4.BackgroundImageLayout = ImageLayout.Center
        GroupBox4.Controls.Add(Label2)
        GroupBox4.Controls.Add(TxtItemname)
        GroupBox4.Controls.Add(qtykgtxt)
        GroupBox4.Controls.Add(txtqtyg)
        GroupBox4.Controls.Add(LblBillNo)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Controls.Add(btnadd)
        GroupBox4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox4.ForeColor = SystemColors.ActiveCaptionText
        GroupBox4.Location = New Point(662, 16)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(576, 368)
        GroupBox4.TabIndex = 85
        GroupBox4.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveBorder
        Label2.Location = New Point(421, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 40)
        Label2.TabIndex = 84
        Label2.Text = "Add to Bill"
        ' 
        ' billg
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1908, 896)
        Controls.Add(GroupBox3)
        Controls.Add(Btnre)
        Controls.Add(GroupBox2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "billg"
        Text = "Form1"
        CType(billdgv, ComponentModel.ISupportInitialize).EndInit()
        CType(itemdgv, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents txttobill As TextBox
    Friend WithEvents qtykgtxt As TextBox
    Friend WithEvents txtqtyg As TextBox
    Friend WithEvents TxtItemname As TextBox
    Friend WithEvents billdgv As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents printbtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents itemdgv As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents item_pricetxt As TextBox
    Friend WithEvents txtqty As TextBox
    Friend WithEvents txtpricecal As TextBox
    Friend WithEvents txtqtycal As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnDelete As Button
    Friend WithEvents LblBillNo As Label
    Friend WithEvents TxtBName As TextBox
    Friend WithEvents TxtBQty As TextBox
    Friend WithEvents TxtBPrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcusprice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lbltotalday As Label
    Friend WithEvents Lbltotalbill As Label
    Friend WithEvents Lblbalance As Label
    Friend WithEvents Lbltoofday As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Btndot As Button
    Friend WithEvents Btnre As Button
    Friend WithEvents Btnbillname As TextBox
    Friend WithEvents txtqtycal1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
