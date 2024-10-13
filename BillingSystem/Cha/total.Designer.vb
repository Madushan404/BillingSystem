<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class total
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
        dgvallbill = New DataGridView()
        Label10 = New Label()
        txttobill = New TextBox()
        txttotalbill = New TextBox()
        Label1 = New Label()
        CType(dgvallbill, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvallbill
        ' 
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        dgvallbill.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvallbill.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 13.8F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvallbill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvallbill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 13.8F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvallbill.DefaultCellStyle = DataGridViewCellStyle3
        dgvallbill.Location = New Point(174, 112)
        dgvallbill.Name = "dgvallbill"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 13.8F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvallbill.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvallbill.RowHeadersWidth = 51
        dgvallbill.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvallbill.Size = New Size(1509, 373)
        dgvallbill.TabIndex = 26
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F)
        Label10.Location = New Point(1243, 510)
        Label10.Name = "Label10"
        Label10.Size = New Size(132, 31)
        Label10.TabIndex = 29
        Label10.Text = "Total of day"
        ' 
        ' txttobill
        ' 
        txttobill.Font = New Font("Segoe UI", 13.8F)
        txttobill.Location = New Point(1400, 507)
        txttobill.Name = "txttobill"
        txttobill.ReadOnly = True
        txttobill.Size = New Size(283, 38)
        txttobill.TabIndex = 28
        ' 
        ' txttotalbill
        ' 
        txttotalbill.Location = New Point(22, 14)
        txttotalbill.Name = "txttotalbill"
        txttotalbill.ReadOnly = True
        txttotalbill.Size = New Size(43, 27)
        txttotalbill.TabIndex = 72
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold)
        Label1.Location = New Point(861, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 46)
        Label1.TabIndex = 73
        Label1.Text = "Total of day"
        ' 
        ' total
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1906, 765)
        Controls.Add(Label1)
        Controls.Add(txttotalbill)
        Controls.Add(Label10)
        Controls.Add(txttobill)
        Controls.Add(dgvallbill)
        Name = "total"
        Text = "Form5"
        CType(dgvallbill, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvallbill As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txttobill As TextBox
    Friend WithEvents txttotalbill As TextBox
    Friend WithEvents Label1 As Label
End Class
