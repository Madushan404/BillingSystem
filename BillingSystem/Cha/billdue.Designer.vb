<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billdue
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
        Dgvafterpay = New DataGridView()
        Btnpay = New Button()
        Txtname = New TextBox()
        Label2 = New Label()
        CType(Dgvafterpay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Dgvafterpay
        ' 
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Dgvafterpay.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Dgvafterpay.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 13.8F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Dgvafterpay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Dgvafterpay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 13.8F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Dgvafterpay.DefaultCellStyle = DataGridViewCellStyle3
        Dgvafterpay.Location = New Point(201, 170)
        Dgvafterpay.Margin = New Padding(3, 2, 3, 2)
        Dgvafterpay.Name = "Dgvafterpay"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 13.8F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        Dgvafterpay.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Dgvafterpay.RowHeadersWidth = 51
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 13.8F)
        Dgvafterpay.RowsDefaultCellStyle = DataGridViewCellStyle5
        Dgvafterpay.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dgvafterpay.Size = New Size(1455, 487)
        Dgvafterpay.TabIndex = 0
        ' 
        ' Btnpay
        ' 
        Btnpay.Font = New Font("Segoe UI", 18F)
        Btnpay.Location = New Point(1414, 694)
        Btnpay.Margin = New Padding(3, 2, 3, 2)
        Btnpay.Name = "Btnpay"
        Btnpay.Size = New Size(242, 58)
        Btnpay.TabIndex = 1
        Btnpay.Text = "Paid"
        Btnpay.UseVisualStyleBackColor = True
        ' 
        ' Txtname
        ' 
        Txtname.Font = New Font("Segoe UI", 18F)
        Txtname.Location = New Point(1242, 127)
        Txtname.Margin = New Padding(3, 2, 3, 2)
        Txtname.Name = "Txtname"
        Txtname.Size = New Size(405, 39)
        Txtname.TabIndex = 3
        Txtname.Text = "Search"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label2.Location = New Point(234, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 32)
        Label2.TabIndex = 4
        Label2.Text = "Bills due"
        ' 
        ' billdue
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1668, 763)
        Controls.Add(Label2)
        Controls.Add(Txtname)
        Controls.Add(Btnpay)
        Controls.Add(Dgvafterpay)
        Margin = New Padding(3, 2, 3, 2)
        Name = "billdue"
        Text = "Form4"
        CType(Dgvafterpay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Dgvafterpay As DataGridView
    Friend WithEvents Btnpay As Button
    Friend WithEvents Txtname As TextBox
    Friend WithEvents Label2 As Label
End Class
