<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventry_user
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
        BtnAdd = New Button()
        TxtSearch = New TextBox()
        Label1 = New Label()
        AllGrid = New DataGridView()
        CType(AllGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = Color.LightGreen
        BtnAdd.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAdd.Location = New Point(1667, 66)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(229, 43)
        BtnAdd.TabIndex = 45
        BtnAdd.Text = "Add Item"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Font = New Font("Segoe UI", 14.25F)
        TxtSearch.Location = New Point(911, 72)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.PlaceholderText = "    Search Item Name"
        TxtSearch.Size = New Size(750, 33)
        TxtSearch.TabIndex = 44
        TxtSearch.Text = " "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(12, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 86)
        Label1.TabIndex = 43
        Label1.Text = "STORE"
        ' 
        ' AllGrid
        ' 
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        DataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue
        AllGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        AllGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        AllGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        AllGrid.BackgroundColor = Color.White
        AllGrid.BorderStyle = BorderStyle.None
        AllGrid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        AllGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        AllGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        AllGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        AllGrid.DefaultCellStyle = DataGridViewCellStyle3
        AllGrid.Location = New Point(12, 122)
        AllGrid.Name = "AllGrid"
        AllGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        AllGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        AllGrid.Size = New Size(1884, 677)
        AllGrid.TabIndex = 42
        ' 
        ' Inventry_user
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1908, 830)
        Controls.Add(BtnAdd)
        Controls.Add(TxtSearch)
        Controls.Add(Label1)
        Controls.Add(AllGrid)
        Name = "Inventry_user"
        Text = "Inventry_user"
        CType(AllGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AllGrid As DataGridView
End Class
