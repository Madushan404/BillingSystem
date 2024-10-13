Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Relational
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports System.Data.Common
Imports System.Data.SqlTypes
Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class billw
    Dim connectionString As String = "Server=your_server;Database=your_database;Uid=your_username;Pwd=your_password;"
    Dim connection As New MySqlConnection(connectionString)
    Dim adapter As New MySqlDataAdapter()
    Dim dataTable As New DataTable()


    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Regular)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centremargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font aligment

        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "------------------------------------------------------------------------------------"

        Dim currentDateAndTime As String = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss")
        Dim currentDateAndTime1 As String = DateTime.Now.ToString("yyyyMMddHHmm")
        'e.Graphics.DrawString("Bill Statement", f14, Brushes.Black, centremargin, 5, center)
        'e.Graphics.DrawString("Adress", f10, Brushes.Black, centremargin, 25, center)
        'e.Graphics.DrawString("Telephone NB", f8, Brushes.Black, centremargin, 40, center)

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 60)
        e.Graphics.DrawString(currentDateAndTime1, f8, Brushes.Black, 70, 60)

        e.Graphics.DrawString("Tel ", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString("0777610305 / 0777100920", f8, Brushes.Black, 70, 75)

        Dim customerName As String = TxtCusName.Text
        Dim phnb As String = TxtPhNb.Text

        e.Graphics.DrawString("Customer Name ", f8, Brushes.Black, 0, 90)
        e.Graphics.DrawString(":", f8, Brushes.Black, 70, 90)
        e.Graphics.DrawString(customerName, f8, Brushes.Black, 90, 90)

        e.Graphics.DrawString("Phone No ", f8, Brushes.Black, 120, 90)
        e.Graphics.DrawString(":", f8, Brushes.Black, 170, 90)
        e.Graphics.DrawString(phnb, f8, Brushes.Black, 180, 90)

        e.Graphics.DrawString("Date & Time", f8, Brushes.Black, 0, 105)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 105)
        e.Graphics.DrawString(currentDateAndTime, f8, Brushes.Black, 70, 105)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 115)

        e.Graphics.DrawString("නම", f8, Brushes.Black, 0, 125)
        e.Graphics.DrawString("බර(Kg)", f8, Brushes.Black, 65, 125)
        e.Graphics.DrawString(" මිල රු.)", f8, Brushes.Black, rightmargin, 125, right)

        Dim imagePath As String = "C:\Users\Hishara\Desktop\BillingSystem\Hedder.jpg" ' Specify the path to your image file
        Dim image As Image = Image.FromFile(imagePath)
        Dim imageWidth As Integer = 180 ' Adjust the width of the image as needed
        Dim imageHeight As Integer = 50 ' Adjust the height of the image as needed
        Dim imageX As Integer = 40 ' Adjust the X position of the image as needed
        Dim imageY As Integer = 0 ' Adjust the Y position of the image as needed
        Dim imageRect As New Rectangle(imageX, imageY, imageWidth, imageHeight)
        e.Graphics.DrawImage(image, imageRect)

        ' Dispose the image after use to release resources
        image.Dispose()


        'DGV Position

        Dim height As Integer
        Dim i As Long
        For row As Integer = 0 To billdgv.RowCount - 1
            height += 15
            If billdgv.Rows(row).Cells(1).Value IsNot Nothing Then
                e.Graphics.DrawString(billdgv.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, 0, 135 + height)
                e.Graphics.DrawString(billdgv.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 65, 135 + height)
                i = billdgv.Rows(row).Cells(2).Value
                billdgv.Rows(row).Cells(2).Value = Format(i, "0.00")
                e.Graphics.DrawString(billdgv.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, rightmargin, 135 + height, right)

            End If

        Next

        Dim height2 As Integer
        height2 = 145 + height

        sumprice()

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("එකතුව රු.: " & Format(t_price, "##,##0"), f10b, Brushes.Black, rightmargin, 15 + height2, right)
        ' e.Graphics.DrawString("Qty", f10b, Brushes.Black, 0, 15 + height2)


        'e.Graphics.DrawString("~ Thank For Shopping ~", f10, Brushes.Black, centremargin, 40 + height2, center)
        'e.Graphics.DrawString("Shop name", f10, Brushes.Black, centremargin, 55 + height2, center)

        Dim imagePath1 As String = "C:\Users\Hishara\Desktop\BillingSystem\footer.jpg" ' Specify the path to your image file
        Dim image1 As Image = Image.FromFile(imagePath1)
        Dim imageWidth1 As Integer = 180 ' Adjust the width of the image as needed
        Dim imageHeight1 As Integer = 50 ' Adjust the height of the image as needed
        Dim imageX1 As Integer = 40 ' Adjust the X position of the image as needed
        Dim imageY1 As Integer = 40 + height2 ' Adjust the Y position of the image as needed
        Dim imageRect1 As New Rectangle(imageX1, imageY1, imageWidth1, imageHeight1)
        e.Graphics.DrawImage(image1, imageRect1)

        ' Dispose the image after use to release resources
        image1.Dispose()
    End Sub

    Dim t_price As Long
    Dim r_qty As Long

    Sub sumprice()

        Dim countprice As Long = 0
        For rawitem As Long = 0 To billdgv.RowCount - 1
            countprice = countprice + Val(billdgv.Rows(rawitem).Cells(2).Value) '* Val(billdgv.Rows(rawitem).Cells(1).Value)
        Next
        t_price = countprice

    End Sub


    'Sub sumprice1()
    '    Dim to_price As Long
    '    Dim totalval As Long = 0
    '    For rawitem As Long = 0 To dgvallbill.RowCount - 1
    '        totalval = totalval + Val(dgvallbill.Rows(rawitem).Cells(2).Value)
    '    Next
    '    to_price = totalval

    '    txttobill.Text = to_price

    'End Sub

    Private Sub SaveAsPDF()
        Dim currentDateAndTime As String = DateTime.Now.ToString("yyyyMMddHHmm")

        ' Create a SaveFileDialog instance
        Dim saveFileDialog As New SaveFileDialog()

        ' Set properties of the save file dialog
        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
        saveFileDialog.FileName = $"Bill_{currentDateAndTime}.pdf"

        ' Show the save file dialog to the user
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path from the save file dialog
            Dim pdfFilename As String = saveFileDialog.FileName

            Using pdf As New PdfDocument()
                pdf.Info.Title = "Bill Statement"

                Dim page As PdfPage = pdf.AddPage()
                Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
                Dim font As XFont = New XFont("Calibri", 8)

                ' Draw bill details similar to what you did in PD_PrintPage event
                Dim height As Integer = 0
                Dim line As String = "------------------------------------------------------------------------------------"
                Dim currentDateAndTimeFormatted As String = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss")
                Dim currentDateAndTimeFormatted1 As String = DateTime.Now.ToString("yyyyMMddHHmm")

                ' Draw invoice ID, Cashier, and Date & Time
                gfx.DrawString("Invoice ID", font, XBrushes.Black, 0, 60)
                gfx.DrawString(":", font, XBrushes.Black, 50, 60)
                gfx.DrawString(currentDateAndTimeFormatted1, font, XBrushes.Black, 70, 60)

                gfx.DrawString("Tel ", font, XBrushes.Black, 0, 75)
                gfx.DrawString(":", font, XBrushes.Black, 50, 75)
                gfx.DrawString("0777610305 / 0777100920", font, XBrushes.Black, 70, 75)


                Dim customerName As String = TxtCusName.Text
                Dim phnb As String = TxtPhNb.Text

                gfx.DrawString("Customer Name ", font, XBrushes.Black, 0, 90)
                gfx.DrawString(":", font, XBrushes.Black, 50, 90)
                gfx.DrawString(customerName, font, XBrushes.Black, 70, 90)


                gfx.DrawString("Phone Nb ", font, XBrushes.Black, 120, 90)
                gfx.DrawString(":", font, XBrushes.Black, 170, 90)
                gfx.DrawString(phnb, font, XBrushes.Black, 180, 90)



                gfx.DrawString("Date & Time", font, XBrushes.Black, 0, 105)
                gfx.DrawString(":", font, XBrushes.Black, 50, 105)
                gfx.DrawString(currentDateAndTimeFormatted, font, XBrushes.Black, 70, 105)

                gfx.DrawString(line, font, XBrushes.Black, 0, 115)

                gfx.DrawString("නම", font, XBrushes.Black, 0, 125)
                gfx.DrawString("බර(Kg)", font, XBrushes.Black, 65, 125)
                gfx.DrawString(" මිල රු.)", font, XBrushes.Black, page.Width.Point - 10, 125)


                ' Draw image
                Dim imagePath As String = "C:\Users\Hishara\Desktop\BillingSystem\Hedder.jpg" ' Specify the path to your image file
                Dim image As XImage = XImage.FromFile(imagePath)
                gfx.DrawImage(image, 40, 0)

                ' Draw bill items
                For row As Integer = 0 To billdgv.RowCount - 1
                    height += 15
                    If billdgv.Rows(row).Cells(1).Value IsNot Nothing Then
                        gfx.DrawString(billdgv.Rows(row).Cells(0).Value.ToString(), font, XBrushes.Black, 0, 135 + height)
                        gfx.DrawString(billdgv.Rows(row).Cells(1).Value.ToString(), font, XBrushes.Black, 65, 135 + height)
                        gfx.DrawString(Format(Val(billdgv.Rows(row).Cells(2).Value), "0.00"), font, XBrushes.Black, page.Width.Point - 10, 135 + height)
                    End If
                Next

                ' Draw total
                Dim totalHeight As Integer = 145 + height
                Dim total As String = "එකතුව රු.: " & Format(t_price, "##,##0")
                gfx.DrawString(line, font, XBrushes.Black, 0, totalHeight)
                ' Adjust the X-coordinate to right-align the total text
                Dim totalTextWidth As Double = gfx.MeasureString(total, font).Width
                gfx.DrawString(total, font, XBrushes.Black, page.Width.Point - totalTextWidth, 15 + totalHeight)

                ' Draw footer
                Dim imagePath1 As String = "C:\Users\Hishara\Desktop\BillingSystem\footer.jpg" ' Specify the path to your image file
                Dim image1 As XImage = XImage.FromFile(imagePath1)
                gfx.DrawImage(image1, 40, 40 + totalHeight)

                pdf.Save(pdfFilename)
            End Using

            ' MessageBox.Show("PDF file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click

        If billdgv.Rows.Count = 1 Then
            MessageBox.Show("Please Add The Item")
        Else
            PPD.Document = PD
            PPD.ShowDialog()
            SaveAsPDF()

            OpenDb()

            Dim str As String

            str = "INSERT INTO `bill`(`Date`, `Total`) VALUES (@date,@total)"
            Dim commad As New MySqlCommand(str, conn)
            'Insert Data into Customer Registration Table"

            commad.Parameters.AddWithValue("@date", DateAndTime.Now)

            commad.Parameters.Add("@total", MySqlDbType.VarChar).Value = txttotalbill.Text
            Try
                result = commad.ExecuteNonQuery()
                If result = True Then
                    ' MsgBox("New Bill added!", vbInformation + vbOKOnly, "Add Bill")
                    ''''After the data insert All the textboxs will clear their datas
                    'TxtName.Text = ""
                    'TxtNicnb.Text = ""
                    'TxtConnb.Text = ""

                    commad.Parameters.Clear()
                Else
                    MsgBox("Not added", vbExclamation + vbOKOnly, "Error")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbExclamation + vbOKOnly, "Error")
            End Try
            CloseDb()



            'upadatetable2()

            billdgv.Rows.Clear()
            itemsList.Clear()

            'sumprice1()

            Gettotal()


            TxtCusName.Text = ""
            TxtPhNb.Text = ""
            Lblbalance.Text = ""
            txttotalbill.Text = ""
        End If






    End Sub







    'Data  gridwive Load


    Dim sqlquary As String
    Dim sqldt As New DataTable
    Dim sqlrd As MySqlDataReader
    Dim sqlcmd As New MySqlCommand

    Private Sub upadatetable()
        itemdgv.DataSource = Nothing
        itemdgv.Refresh()
        sqldt.Clear()

        OpenDb()
        sqlcmd.Connection = conn
        sqlcmd.CommandText = "SELECT I_Code AS `Item Code`, `Name` AS `Item Name`, Quantity AS `Quantity`, O_Price AS `Price (1Kg)` FROM inventory WHERE active = 1"

        sqlrd = sqlcmd.ExecuteReader
        sqldt.Load(sqlrd)
        sqlrd.Close()
        CloseDb()

        itemdgv.DataSource = sqldt

        itemdgv.Columns("Item Code").Width = 80 ' Adjust the width as needed
        itemdgv.Columns("Item Name").Width = 225 ' Adjust the width as needed
        itemdgv.Columns("Quantity").Width = 175 ' Adjust the width as needed
        itemdgv.Columns("Price (1Kg)").Width = 175 ' Adjust the width as needed



        itemdgv.BackgroundColor = billdgv.Parent.BackColor


        AddHandler itemdgv.CellFormatting, AddressOf itemdgv_CellFormatting
    End Sub

    Private Sub itemdgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If itemdgv.Columns(e.ColumnIndex).Name = "Quantity" Then
            If e.Value IsNot Nothing Then
                ' Divide the value by 1000 and format it
                Dim quantity As Decimal
                If Decimal.TryParse(e.Value.ToString(), quantity) Then
                    e.Value = (quantity / 1000).ToString("N3") ' Format with 3 decimal places
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub


    Dim sqldt1 As New DataTable
    Dim sqlrd1 As MySqlDataReader
    Dim sqlcmd1 As New MySqlCommand


    '  Dim sqlquary1 As String

    'Private Sub upadatetable2()

    '    Dim todayDate As String = DateTime.Now.ToString("yyyy-MM-dd")

    '    dgvallbill.DataSource = Nothing
    '    dgvallbill.Refresh()
    '    sqldt1.Clear()

    '    OpenDb()
    '    sqlcmd1.Connection = conn
    '    sqlcmd1.CommandText = "SELECT bill_no AS `Bill No`, `Date` AS `Date`, Total AS Total FROM veg_shop.bill WHERE DATE(date) = CURDATE()"
    '    sqlrd1 = sqlcmd1.ExecuteReader
    '    sqldt1.Load(sqlrd1)
    '    sqlrd1.Close()
    '    CloseDb()

    '    dgvallbill.DataSource = sqldt1

    'End Sub




    Private itemsList As New List(Of Item)
    Private isFirstSelection As Boolean = True
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        upadatetable()

        ' LoadTodayBillsIntoDataGridView()
        ' upadatetable2()
        upadatetable3()

        ' sumprice1()

        UpdateAvailabilityInDataGridView()

        'billdgv.Columns.Add("ItemName", "Item Name")
        'billdgv.Columns.Add("Quantity", "Quantity")
        'billdgv.Columns.Add("Price", "Price")
        SetupDataGridView()

        billdgv.ReadOnly = True
        itemdgv.ReadOnly = True
        'dgvallbill.ReadOnly = True
        DGVcus_D.ReadOnly = True




        Gettotal()
        Me.KeyPreview = True

        billdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub
    Private Sub billdgv_SelectionChanged(sender As Object, e As EventArgs) Handles billdgv.SelectionChanged
        If isFirstSelection AndAlso billdgv.SelectedRows.Count > 0 Then
            isFirstSelection = False
            billdgv.ClearSelection()
        End If
    End Sub

    Private Sub billdgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles billdgv.CellClick
        If e.RowIndex >= 0 Then ' Check if a valid row is clicked
            billdgv.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub Gettotal()

        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

        ' SQL query to retrieve total for the current date from the bill table
        Dim query As String = $"SELECT SUM(Total) AS TotalAmount FROM details_db.bill WHERE Date = '{currentDate}'"

        ' Create a MySqlCommand to execute the query
        Using command As New MySqlCommand(query)
            ' Open the database connection
            OpenDb()

            ' Set the connection for the command
            command.Connection = conn

            ' Execute the query and get the result
            Dim result As Object = command.ExecuteScalar()

            ' Check if the result is not null
            If result IsNot DBNull.Value Then
                ' Set the total value to the text box
                Lbltoofday.Text = Convert.ToDecimal(result).ToString("0.00")
            Else
                ' If result is null, display a message or handle it as needed
                ' MessageBox.Show("No total amount found.")
            End If

            ' Close the database connection
            CloseDb()
        End Using
    End Sub

    Private Sub SetupDataGridView()
        ' Clear existing columns if any
        billdgv.Columns.Clear()

        ' Add columns
        Dim itemNameColumn As New DataGridViewTextBoxColumn()
        itemNameColumn.Name = "ItemName"
        itemNameColumn.HeaderText = "Item Name"
        billdgv.Columns.Add(itemNameColumn)

        Dim quantityColumn As New DataGridViewTextBoxColumn()
        quantityColumn.Name = "Quantity"
        quantityColumn.HeaderText = "Quantity"
        billdgv.Columns.Add(quantityColumn)

        Dim priceColumn As New DataGridViewTextBoxColumn()
        priceColumn.Name = "Price"
        priceColumn.HeaderText = "Price"
        billdgv.Columns.Add(priceColumn)

        ' Adjust column widths
        billdgv.Columns("ItemName").Width = 327 ' Adjust the width as needed
        billdgv.Columns("Quantity").Width = 204 ' Adjust the width as needed
        billdgv.Columns("Price").Width = 204 ' Adjust the width as needed

        ' Adjust font size for column headers
        For Each column As DataGridViewColumn In billdgv.Columns
            column.HeaderCell.Style.Font = New Font("Arial", 14, FontStyle.Bold) ' You can adjust the font size and style here
        Next

        ' Adjust font size for cells
        Dim cellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
        cellStyle.Font = New Font("Arial", 14) ' You can adjust the font size here
        billdgv.DefaultCellStyle = cellStyle

        billdgv.BackgroundColor = billdgv.Parent.BackColor

    End Sub


    'Search in text box DGV

    Public Sub FilterData1(valueToSeserch As String)

        OpenDb()


        Dim searchQuery As String = "SELECT I_Code AS `Item Code`, `Name` AS `Item Name`, Quantity AS `Quantity`, O_Price AS `Price (1Kg)` FROM inventory WHERE Name OR I_Code like '%" & valueToSeserch & "%' AND active = 1"

        Dim command As New MySqlCommand(searchQuery, conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        itemdgv.DataSource = table


        CloseDb()
    End Sub

    Private Sub itm_nametxt_TextChanged(sender As Object, e As EventArgs) Handles Txtitemname.TextChanged

        FilterData1(Txtitemname.Text)

    End Sub






    'Textbox validating part


    Private Sub qtykgtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qtykgtxt.KeyPress
        ' Check if the pressed key is a digit or a control key (like Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If not a digit or control key, set e.Handled to true to ignore the key press
            e.Handled = True
        End If
    End Sub

    Private Sub txtqtyg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqtyg.KeyPress
        ' Check if the pressed key is a digit or a control key (like Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If not a digit or control key, set e.Handled to true to ignore the key press
            e.Handled = True
        End If

        ' Check if the length of the text after adding the pressed key would exceed three characters
        If txtqtyg.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the length exceeds three and the pressed key is not a control key (like Backspace), ignore the key press
            e.Handled = True
        End If
    End Sub
    Private Sub TxtItemname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtitemname.KeyPress
        ' Check if the pressed key is an alphabetic character or a control key
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If not an alphabetic character or a control key, set e.Handled to true to ignore the key press
            e.Handled = True
        End If
    End Sub





    Private Sub UpdateAvailabilityInDataGridView()
        ' Suspend the DataGridView's layout logic while we perform updates
        itemdgv.SuspendLayout()

        ' Iterate through each row in the DataGridView in reverse order
        For i As Integer = itemdgv.Rows.Count - 1 To 0 Step -1
            Dim row As DataGridViewRow = itemdgv.Rows(i)

            ' Check if the row is not a new row (i.e., not in an uncommitted state)
            If Not row.IsNewRow Then
                ' Check if available_qty is zero
                If Convert.ToInt32(row.Cells("Quantity").Value) <= 0 Then
                    ' If available_qty is zero, hide the row
                    itemdgv.Rows.RemoveAt(i)
                End If
            End If
        Next

        ' Resume the DataGridView's layout logic after updates are done
        itemdgv.ResumeLayout()
    End Sub




    'Select data grid wive and get Item price and qty in the text box


    'Private Sub itemdgv_MouseClick(sender As Object, e As MouseEventArgs) Handles itemdgv.MouseClick



    '    Try
    '        Dim dr As DataGridViewRow = itemdgv.SelectedRows(0)
    '        item_pricetxt.Text = dr.Cells(2).Value.ToString()
    '        txtqty.Text = dr.Cells(3).Value.ToString()
    '        Txtitemname.Text = dr.Cells(1).Value.ToString()


    '    Catch ex As Exception

    '    End Try


    'End Sub

    Private Sub itemdgv_MouseClick(sender As Object, e As MouseEventArgs) Handles itemdgv.MouseClick
        Try
            If itemdgv.SelectedRows.Count > 0 Then ' Check if there are selected rows
                Dim dr As DataGridViewRow = itemdgv.SelectedRows(0)
                If dr.Cells(3).Value IsNot Nothing Then ' Check if the cell value is not null
                    item_pricetxt.Text = dr.Cells(3).Value.ToString()
                End If
                If dr.Cells(2).Value IsNot Nothing Then ' Check if the cell value is not null
                    txtqty.Text = dr.Cells(2).Value.ToString()
                End If
                If dr.Cells(1).Value IsNot Nothing Then ' Check if the cell value is not null
                    Txtitemname.Text = dr.Cells(1).Value.ToString()
                End If
            End If
        Catch ex As Exception
            ' Handle any other exceptions here
        End Try
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Trigger the Click event of the "Add" button
            btnadd.PerformClick()
        End If
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Btndot.PerformClick()
        'txtqtyg.Text = "0"

        Dim val1, val2, val3, val4 As Integer
        Dim val6, val5, val7, val8 As Double

        If txtpricecal.Text = "" Then
            txtpricecal.Text = 0

        End If

        If txtqtycal.Text = "" Then
            txtqtycal.Text = 0

        End If

        If txtqtyg.Text = "g" Or txtqtyg.Text = "" Then
            txtqtyg.Text = 0

        End If

        If txtqtycal1.Text = "" Then
            txtqtycal1.Text = 0
        End If

        If qtykgtxt.Text = "Kg" Or qtykgtxt.Text = "" Then
            qtykgtxt.Text = 0
        End If

        If item_pricetxt.Text = "" Then
            item_pricetxt.Text = 0
        End If

        If txtqtyg.Text = 0 And qtykgtxt.Text = 0 Then
            ErrorProvider1.SetError(qtykgtxt, "Please add Quantity")
            qtykgtxt.Focus()
        Else
            ErrorProvider1.SetError(qtykgtxt, String.Empty)

            If qtykgtxt.Text = "" Then
                ErrorProvider1.SetError(qtykgtxt, "Please add Quantity")
                qtykgtxt.Focus()
            Else
                ErrorProvider1.SetError(qtykgtxt, String.Empty)
                val1 = Convert.ToInt64(qtykgtxt.Text)
                val2 = Convert.ToInt64(txtqtyg.Text)
                val3 = Convert.ToInt64(item_pricetxt.Text)

                val4 = val1 * 1000
                val5 = val4 + val2
                val6 = val3 / 1000
                val7 = val6 * val5
                val8 = val5 / 1000

                txtpricecal.Text = val7.ToString("0.00")
                txtqtycal.Text = val5.ToString("0.000")
                txtqtycal1.Text = val8.ToString("0.000")

            End If
        End If

        Lblbalance.Text = ""




        Dim itemName2 As String = TextBox2.Text
        Dim itemName As String = Txtitemname.Text
        Dim quantity As Decimal = Decimal.Parse(txtqtycal.Text)
        Dim quantity1 As Decimal = Decimal.Parse(txtqtycal1.Text)
        Dim price As Decimal = Decimal.Parse(txtpricecal.Text)

        OpenDb()

        Dim result As Integer
        Dim str As String

        ' Check if either of the TextBoxes contains a non-zero value
        If txtqtycal.Text = "0" AndAlso txtqtyg.Text = "0" Then
            ErrorProvider1.SetError(qtykgtxt, "Please add Quantity")
            qtykgtxt.Focus()
        Else
            ErrorProvider1.SetError(Txtitemname, String.Empty)
            If String.IsNullOrWhiteSpace(Txtitemname.Text) Then
                ErrorProvider1.SetError(Txtitemname, "Enter Item name")
                Txtitemname.Focus()
                If qtykgtxt.Text > txtqty.Text Then
                    MessageBox.Show("Not Enough Quantity(kg) For Selected Vegi!")

                Else
                    ErrorProvider1.SetError(Txtitemname, String.Empty)

                    ' Use parameterized query to avoid SQL injection
                    str = "UPDATE inventory SET Quantity = Quantity - @Quantity WHERE Name = @ItemName"
                    Using commad As New MySqlCommand(str, conn)
                        commad.Parameters.AddWithValue("@Quantity", txtqtycal.Text)
                        commad.Parameters.AddWithValue("@ItemName", Txtitemname.Text)

                        Try
                            result = commad.ExecuteNonQuery()

                            If result > 0 Then
                                ' MsgBox("Item Updated!", vbInformation + vbOKOnly, "Update Item")
                                ' After the data insert, clear the textboxes
                                txtqtycal.Clear()
                                Txtitemname.Clear()
                            Else
                                MsgBox("Not updated", vbExclamation + vbOKOnly, "Error")
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message, vbExclamation + vbOKOnly, "Error")
                        End Try
                    End Using

                    ' Check if the item already exists in the list
                    Dim existingItem As Item = itemsList.Find(Function(item) item.Name = itemName2)

                    If existingItem IsNot Nothing Then
                        ' Update existing item
                        existingItem.Quantity += quantity1
                        existingItem.Price += price
                    Else
                        ' Add a new item to the list
                        Dim newItem As New Item(itemName2, quantity1, price)
                        itemsList.Add(newItem)
                    End If

                    ' Update DataGridView
                    UpdateDataGridView()

                    ' Clear TextBoxes for the next entry
                    ClearTextBoxes()
                End If

                Dim totalll As Decimal = 0
                For Each row As DataGridViewRow In billdgv.Rows
                    totalll += row.Cells("Price").Value
                Next
                txttotalbill.Text = totalll.ToString("0.00")
            End If
        End If



        UpdateAvailabilityInDataGridView()



        clear_fields()
        upadatetable3()


        DGVcus_D.Refresh()
        'TxtCusName.Text = ""
        'TxtPhNb.Text = ""

    End Sub

    Private Sub Btndot_Click(sender As Object, e As EventArgs) Handles Btndot.Click
        ' Retrieve the value from the textbox
        Dim itemName1 As String = Txtitemname.Text.Trim()

        ' SQL query to retrieve the I_Name_Sin value from the database
        Dim query As String = "SELECT I_Name_Sin FROM item_tb WHERE I_Name = @ItemName"

        OpenDb()

        Using command As New MySqlCommand(query, conn)
            ' Add parameter to the query to prevent SQL injection
            command.Parameters.AddWithValue("@ItemName", itemName1)
            Try
                ' Execute the query and retrieve the I_Name_Sin value
                Dim result1 As Object = command.ExecuteScalar()

                ' Check if the result is not null
                If result1 IsNot Nothing Then
                    ' Display the retrieved value in the textbox
                    TextBox2.Text = result1.ToString()
                Else
                    MessageBox.Show("Item not found in the database.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If TxtBPrice.Text = "" And TxtBQty.Text = "" Then
            MsgBox("Please Select the row.", vbExclamation + vbOKOnly, "Error")

        Else

            Btnre.PerformClick()

            If billdgv.SelectedRows.Count > 0 Then
                If txttotalbill.Text = "" Then
                Else

                    Dim selectedRow As DataGridViewRow = billdgv.SelectedRows(0)

                    Dim selectedPrice As Decimal = Convert.ToDecimal(selectedRow.Cells("Price").Value)
                    Dim currentTotal As Decimal = Convert.ToDecimal(txttotalbill.Text)
                    txttotalbill.Text = (currentTotal - selectedPrice).ToString("0.00")


                    If TxtBName.Text = "" And TxtBPrice.Text = "" Then
                        'do nothing
                    Else
                        Dim itemName As String = TxtBName.Text
                        Dim quantity As Integer = TxtBPrice.Text
                        OpenDb()

                        Dim result As Integer
                        Dim str As String

                        str = "UPDATE inventory SET Quantity = Quantity + @Quantity WHERE Name = @ItemName"
                        Using command As New MySqlCommand(str, conn)
                            command.Parameters.AddWithValue("@Quantity", quantity)
                            command.Parameters.AddWithValue("@ItemName", itemName)

                            Try
                                result = command.ExecuteNonQuery()
                                If result > 0 Then
                                    ' Item Updated Successfully
                                Else
                                    ' Update Failed
                                End If
                            Catch ex As Exception
                                ' Handle Exception
                            End Try
                        End Using
                        'Else
                        ' No row selected in the DataGridView
                    End If
                End If
            End If



            If billdgv.SelectedRows.Count > 0 Then
                ' Iterate through each selected row
                For Each selectedRow As DataGridViewRow In billdgv.SelectedRows
                    ' Retrieve the index of the selected row
                    Dim rowIndex As Integer = selectedRow.Index

                    ' Ensure that the index is valid
                    If rowIndex >= 0 AndAlso rowIndex < itemsList.Count Then
                        ' Remove the corresponding item from the itemsList
                        itemsList.RemoveAt(rowIndex)
                    End If
                Next

                ' Update the DataGridView to reflect the changes
                UpdateDataGridView()
            End If
        End If

        ' Clear the textboxes
        TxtBPrice.Text = ""
        TxtBName.Text = ""
        TxtBQty.Text = ""

        UpdateAvailabilityInDataGridView()
        itemdgv.DataSource = Nothing
        itemdgv.Refresh()
        sqldt.Clear()

        OpenDb()
        sqlcmd.Connection = conn
        sqlcmd.CommandText = "SELECT I_Code AS `Item Code`, `Name` AS `Item Name`, Quantity AS `Quantity`, O_Price AS `Price (1Kg)` FROM inventory WHERE active = 1"

        sqlrd = sqlcmd.ExecuteReader
        sqldt.Load(sqlrd)
        sqlrd.Close()
        CloseDb()

        itemdgv.DataSource = sqldt

        itemdgv.Columns("Item Code").Width = 80 ' Adjust the width as needed
        itemdgv.Columns("Item Name").Width = 225 ' Adjust the width as needed
        itemdgv.Columns("Quantity").Width = 175 ' Adjust the width as needed
        itemdgv.Columns("Price (1Kg)").Width = 175 ' Adjust the width as needed



        itemdgv.BackgroundColor = billdgv.Parent.BackColor
        UpdateAvailabilityInDataGridView()

    End Sub

    Private Sub Btnre_Click(sender As Object, e As EventArgs) Handles Btnre.Click
        ' Retrieve the value from the textbox
        Dim itemName1 As String = Btnbillname.Text.Trim()

        ' SQL query to retrieve the I_Name_Sin value from the database
        Dim query As String = "SELECT I_Name FROM item_tb WHERE I_Name_Sin = @ItemName"

        OpenDb()

        Using command As New MySqlCommand(query, conn)
            ' Add parameter to the query to prevent SQL injection
            command.Parameters.AddWithValue("@ItemName", itemName1)
            Try
                ' Execute the query and retrieve the I_Name_Sin value
                Dim result1 As Object = command.ExecuteScalar()

                ' Check if the result is not null
                If result1 IsNot Nothing Then
                    ' Display the retrieved value in the textbox
                    TxtBName.Text = result1.ToString()
                Else
                    ' MessageBox.Show("Item not found in the database.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub billdgv_MouseClick(sender As Object, e As MouseEventArgs) Handles billdgv.MouseClick
        If billdgv.SelectedRows.Count > 0 AndAlso Not IsNothing(billdgv.SelectedRows(0)) Then
            Dim dr As DataGridViewRow = billdgv.SelectedRows(0)

            ' Check if any cell in the selected row is null or empty
            Dim isEmpty As Boolean = False
            For Each cell As DataGridViewCell In dr.Cells
                If String.IsNullOrWhiteSpace(Convert.ToString(cell.Value)) Then
                    isEmpty = True
                    Exit For
                End If
            Next

            If Not isEmpty Then
                Try
                    Btnbillname.Text = dr.Cells(0).Value.ToString()
                    TxtBQty.Text = dr.Cells(2).Value.ToString()

                    ' Multiply the value in Cells(1) by 1000 and set it to TxtBPrice
                    Dim price As Decimal
                    If Decimal.TryParse(dr.Cells(1).Value.ToString(), price) Then
                        Dim multipliedPrice As Decimal = price * 1000
                        TxtBPrice.Text = multipliedPrice.ToString()
                    Else
                        TxtBPrice.Text = "Invalid Price" ' Handle invalid price case
                    End If
                Catch ex As Exception
                    ' Handle any exceptions here if necessary
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                ' All textboxes are empty or null, do nothing
            End If
        End If
    End Sub






    Private Sub UpdateDataGridView()
        ' Clear the DataGridView
        billdgv.Rows.Clear()

        ' Populate the DataGridView with the updated itemsList
        For Each item As Item In itemsList
            billdgv.Rows.Add(item.Name, item.Quantity, item.Price)
        Next
    End Sub

    Private Sub ClearTextBoxes()
        ' Clear the TextBoxes
        Txtitemname.Text = ""
        txtqtycal.Text = ""
        txtpricecal.Text = ""
    End Sub




    Private Function GetAvailableQuantity(itemName As String) As Integer
        Dim availableQty As Integer = 0

        Try
            ' SQL query to retrieve the available quantity for the specified item name
            Dim sql As String = "SELECT Quantity FROM inventory WHERE Name = @ItemName"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ItemName", itemName)

                ' OpenDb() method is assumed to be available in your code
                OpenDb()

                ' Execute the query and retrieve the available quantity
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                    availableQty = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            ' Handle any exceptions that might occur during the database retrieval
            MsgBox(ex.Message, vbExclamation + vbOKOnly, "Error")
        Finally
            ' CloseDb() method is assumed to be available in your code
            CloseDb()
        End Try

        Return availableQty
    End Function



    Private Sub clear_fields()
        Txtitemname.Text = ""
        qtykgtxt.Text = ""
        item_pricetxt.Text = ""
        txtqtycal.Text = ""
        txtqtyg.Text = ""
        txtpricecal.Text = ""
        txtqty.Text = ""



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Txtitemname.Text = ""
        qtykgtxt.Text = ""
        item_pricetxt.Text = ""
        txtqtycal.Text = ""
        txtpricecal.Text = ""
        txtqtyg.Text = ""
        txtqty.Text = ""
        txttotalbill.Text = ""
        txttotalbill.Text = ""
        TxtCusName.Text = ""
        TxtPhNb.Text = ""

        UpdateAvailabilityInDataGridView()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtcusprice.TextChanged



        If Not String.IsNullOrEmpty(txttotalbill.Text) AndAlso Not String.IsNullOrEmpty(txtcusprice.Text) Then
            ' Parse the values from the TextBoxes
            Dim totalBill As Double = Double.Parse(txttotalbill.Text)
            Dim customerPrice As Double = Double.Parse(txtcusprice.Text)

            ' Calculate the remaining balance
            Dim remainingBalance As Double = totalBill - customerPrice

            ' Update the txtbalance TextBox with the remaining balance
            Lblbalance.Text = remainingBalance.ToString()
        End If





    End Sub




    Private Sub Txtsale_Click(sender As Object, e As EventArgs)

        billg.Show()
        Hide()

    End Sub
    Private number As Integer = 0




    'New Update...............................................................................................................................




    Dim sqldt3 As New DataTable
    Dim sqlrd3 As MySqlDataReader
    Dim sqlcmd3 As New MySqlCommand

    Private Sub upadatetable3()
        DGVcus_D.DataSource = Nothing
        DGVcus_D.Refresh()
        sqldt3.Clear()

        OpenDb()
        sqlcmd3.Connection = conn
        sqlcmd3.CommandText = "SELECT `Customer_Name`AS 'Customer Name',`Mobile_Number`AS 'Mobile Number',`Other_Details`AS 'Details' FROM `customer_tb`"
        sqlrd3 = sqlcmd3.ExecuteReader
        sqldt3.Load(sqlrd3)
        sqlrd3.Close()
        CloseDb()

        DGVcus_D.DataSource = sqldt3

        'DGVcus_D.Columns("Customer ID").Width = 80 ' Adjust the width as needed
        DGVcus_D.Columns("Customer Name").Width = 200 ' Adjust the width as needed
        DGVcus_D.Columns("Mobile Number").Width = 190 ' Adjust the width as needed
        DGVcus_D.Columns("Details").Width = 190 ' Adjust the width as needed

        'Dim cellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
        'cellStyle.Font = New Font("Arial", 12) ' You can adjust the font size here
        'DGVcus_D.DefaultCellStyle = cellStyle

        'For Each column As DataGridViewColumn In DGVcus_D.Columns
        '    column.HeaderCell.Style.Font = New Font("Arial", 14, FontStyle.Bold) ' You can adjust the font size and style here
        'Next

        DGVcus_D.BackgroundColor = DGVcus_D.Parent.BackColor



    End Sub





    Public Sub FilterData2(valueToSearch As String)
        OpenDb()

        Dim searchQuery As String = "SELECT `Customer_Name`AS 'Customer Name',`Mobile_Number`AS 'Mobile Number',`Other_Details`AS 'Details' FROM customer_tb WHERE Customer_Name LIKE '%" & valueToSearch & "%'"

        Dim command As New MySqlCommand(searchQuery, conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DGVcus_D.DataSource = table

        CloseDb()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtCusName.TextChanged
        FilterData2(TxtCusName.Text)
    End Sub







    Private Sub DGVcus_D_MouseClick(sender As Object, e As MouseEventArgs) Handles DGVcus_D.MouseClick

        If DGVcus_D.SelectedRows.Count > 0 AndAlso Not IsNothing(DGVcus_D.SelectedRows(0)) Then
            Dim dr As DataGridViewRow = DGVcus_D.SelectedRows(0)

            ' Check if any cell in the selected row is null or empty
            Dim isEmpty As Boolean = False
            For Each cell As DataGridViewCell In dr.Cells
                If String.IsNullOrWhiteSpace(Convert.ToString(cell.Value)) Then
                    isEmpty = True
                    Exit For
                End If
            Next

            If Not isEmpty Then
                Try

                    TxtPhNb.Text = dr.Cells(1).Value.ToString()
                    TxtCusName.Text = dr.Cells(0).Value.ToString()
                Catch ex As Exception
                    ' Handle any exceptions here if necessary
                End Try
            Else
                ' All textboxes are empty or null, do nothing
            End If
        End If



    End Sub







    Public Shared TextBoxValue As String
    Public Shared TextBoxValue1 As String
    Public Shared TextBoxValue2 As String
    Private Sub Btnlending_Click(sender As Object, e As EventArgs)

        If TxtCusName.Text = "" AndAlso TxtPhNb.Text = "" Then
            ErrorProvider1.SetError(TxtCusName, "Please Enter Customer Details")
            TxtCusName.Focus()


            'MessageBox.Show("Please Enter Customer Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ErrorProvider1.SetError(TxtCusName, String.Empty)
            If billdgv.Rows.Count = 1 Then
                MessageBox.Show("Please Add The Item")
            Else
                ' If the bill data grid is not empty, execute the code
                TextBoxValue = txttotalbill.Text
                TextBoxValue1 = TxtCusName.Text
                TextBoxValue2 = TxtPhNb.Text

                ' Open Form3
                Dim form3 As New login
                form3.Show()
                Hide()
            End If
        End If
        SaveAsPDF()
        TxtCusName.Text = ""
        TxtPhNb.Text = ""
    End Sub

    Private Sub Txtpay_Click(sender As Object, e As EventArgs)

        billdue.Show

    End Sub



    Public Sub ClearDataGridView()
        billdgv.Rows.Clear()
    End Sub

    Private Sub Btndaytotal_Click(sender As Object, e As EventArgs) Handles Btndaytotal.Click
        Dim frm5 As New total

        frm5.txttotalbill.Text = Me.txttotalbill.Text

        frm5.Show()


    End Sub

    Public Property WatermarkText As String
    Public Property WatermarkText1 As String

    Public Sub New()
        InitializeComponent()
        ' Set default watermark text and appearance
        WatermarkText = "Kg"
        WatermarkText1 = "g"
        qtykgtxt.Text = WatermarkText
        txtqtyg.Text = WatermarkText1
        qtykgtxt.ForeColor = Color.Gray
        qtykgtxt.TextAlign = HorizontalAlignment.Right
        txtqtyg.ForeColor = Color.Gray
        txtqtyg.TextAlign = HorizontalAlignment.Right

    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles qtykgtxt.Enter
        If qtykgtxt.Text = WatermarkText Then
            qtykgtxt.Text = ""
            qtykgtxt.ForeColor = SystemColors.WindowText ' Change text color to default
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles qtykgtxt.Leave
        If String.IsNullOrWhiteSpace(qtykgtxt.Text) Then
            qtykgtxt.Text = WatermarkText
            qtykgtxt.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles txtqtyg.Enter
        If txtqtyg.Text = WatermarkText1 Then
            txtqtyg.Text = ""
            txtqtyg.ForeColor = SystemColors.WindowText ' Change text color to default
        End If
    End Sub
    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles txtqtyg.Leave
        If String.IsNullOrWhiteSpace(txtqtyg.Text) Then
            txtqtyg.Text = WatermarkText1
            txtqtyg.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Btnlending_Click_1(sender As Object, e As EventArgs) Handles Btnlending.Click
        If TxtCusName.Text = "" AndAlso TxtPhNb.Text = "" Then
            ErrorProvider1.SetError(TxtCusName, "Please Enter Customer Details")
            TxtCusName.Focus()


            'MessageBox.Show("Please Enter Customer Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ErrorProvider1.SetError(TxtCusName, String.Empty)
            If billdgv.Rows.Count = 1 Then
                MessageBox.Show("Please Add The Item")
            Else
                ' If the bill data grid is not empty, execute the code
                TextBoxValue = txttotalbill.Text
                TextBoxValue1 = TxtCusName.Text
                TextBoxValue2 = TxtPhNb.Text

                ' Open Form3
                Dim form3 As New login
                form3.Show()
                'Hide()
            End If
        End If
        If TxtCusName.Text = "" AndAlso TxtPhNb.Text = "" Then

        Else
            SaveAsPDF()
        End If

        TxtCusName.Text = ""
        TxtPhNb.Text = ""
        billdgv.Rows.Clear()
    End Sub
End Class











'Public Class Item1
'    Public Property Name As String
'    Public Property Quantity As Decimal
'    Public Property Price As Decimal

'    Public Sub New(name As String, quantity As Decimal, price As Decimal)
'        Me.Name = name
'        Me.Quantity = quantity
'        Me.Price = price
'    End Sub
'End Class



