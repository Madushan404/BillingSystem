<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item_Add
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        TxtName = New TextBox()
        Label14 = New Label()
        NewItemGrid = New DataGridView()
        BtnDelete = New Button()
        Label2 = New Label()
        TxtNameSin = New TextBox()
        Label3 = New Label()
        TxtCode = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        ErrorProvider3 = New ErrorProvider(components)
        Panel1 = New Panel()
        BtnAdd = New Button()
        CType(NewItemGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(31, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(472, 86)
        Label1.TabIndex = 29
        Label1.Text = "ITEM MANAGE"
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Segoe UI", 15.75F)
        TxtName.Location = New Point(226, 297)
        TxtName.Multiline = True
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(529, 46)
        TxtName.TabIndex = 35
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 15.75F)
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(31, 297)
        Label14.Name = "Label14"
        Label14.Size = New Size(126, 30)
        Label14.TabIndex = 34
        Label14.Text = "ITEM NAME"
        ' 
        ' NewItemGrid
        ' 
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.SelectionBackColor = Color.DodgerBlue
        NewItemGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        NewItemGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        NewItemGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        NewItemGrid.BackgroundColor = Color.White
        NewItemGrid.BorderStyle = BorderStyle.Fixed3D
        NewItemGrid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        NewItemGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        NewItemGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        NewItemGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        NewItemGrid.DefaultCellStyle = DataGridViewCellStyle6
        NewItemGrid.Location = New Point(820, 46)
        NewItemGrid.Name = "NewItemGrid"
        NewItemGrid.Size = New Size(1076, 715)
        NewItemGrid.TabIndex = 39
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.LightCoral
        BtnDelete.Font = New Font("Segoe UI", 14.25F)
        BtnDelete.Location = New Point(396, 577)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(359, 85)
        BtnDelete.TabIndex = 40
        BtnDelete.Text = "DELETE"
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(31, 377)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 60)
        Label2.TabIndex = 34
        Label2.Text = "ITEM NAME" & vbCrLf & "(Sinhala) "
        ' 
        ' TxtNameSin
        ' 
        TxtNameSin.Font = New Font("Segoe UI", 15.75F)
        TxtNameSin.Location = New Point(226, 386)
        TxtNameSin.Multiline = True
        TxtNameSin.Name = "TxtNameSin"
        TxtNameSin.Size = New Size(529, 46)
        TxtNameSin.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(31, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 30)
        Label3.TabIndex = 34
        Label3.Text = "ITEM CODE"
        ' 
        ' TxtCode
        ' 
        TxtCode.Font = New Font("Segoe UI", 15.75F)
        TxtCode.Location = New Point(226, 206)
        TxtCode.Multiline = True
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(529, 48)
        TxtCode.TabIndex = 35
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightBlue
        Panel1.Location = New Point(804, 46)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(10, 701)
        Panel1.TabIndex = 41
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = Color.LightGreen
        BtnAdd.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAdd.Location = New Point(31, 577)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(359, 85)
        BtnAdd.TabIndex = 38
        BtnAdd.Text = "ADD "
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' Item_Add
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1908, 773)
        Controls.Add(Panel1)
        Controls.Add(BtnDelete)
        Controls.Add(NewItemGrid)
        Controls.Add(BtnAdd)
        Controls.Add(TxtCode)
        Controls.Add(Label3)
        Controls.Add(TxtNameSin)
        Controls.Add(Label2)
        Controls.Add(TxtName)
        Controls.Add(Label14)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Item_Add"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "Item_Add"
        CType(NewItemGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents NewItemGrid As DataGridView
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNameSin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAdd As Button
End Class
