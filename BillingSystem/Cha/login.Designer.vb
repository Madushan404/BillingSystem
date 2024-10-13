<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        BtnOk = New Button()
        TxtName = New TextBox()
        TxtPw = New TextBox()
        Lblname = New Label()
        Label2 = New Label()
        txttotalbill = New TextBox()
        TxtPhNb = New TextBox()
        TxtCusName = New TextBox()
        SuspendLayout()
        ' 
        ' BtnOk
        ' 
        BtnOk.Font = New Font("Segoe UI", 18F)
        BtnOk.Location = New Point(355, 277)
        BtnOk.Name = "BtnOk"
        BtnOk.Size = New Size(194, 53)
        BtnOk.TabIndex = 0
        BtnOk.TabStop = False
        BtnOk.Text = "OK"
        BtnOk.UseVisualStyleBackColor = True
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Segoe UI", 18F)
        TxtName.Location = New Point(287, 67)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(331, 47)
        TxtName.TabIndex = 1
        ' 
        ' TxtPw
        ' 
        TxtPw.Font = New Font("Segoe UI", 18F)
        TxtPw.Location = New Point(287, 179)
        TxtPw.Name = "TxtPw"
        TxtPw.Size = New Size(331, 47)
        TxtPw.TabIndex = 2
        ' 
        ' Lblname
        ' 
        Lblname.AutoSize = True
        Lblname.Font = New Font("Segoe UI", 18F)
        Lblname.Location = New Point(136, 67)
        Lblname.Name = "Lblname"
        Lblname.Size = New Size(97, 41)
        Lblname.TabIndex = 3
        Lblname.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F)
        Label2.Location = New Point(136, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 41)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' txttotalbill
        ' 
        txttotalbill.Location = New Point(0, 41)
        txttotalbill.Name = "txttotalbill"
        txttotalbill.Size = New Size(69, 27)
        txttotalbill.TabIndex = 5
        txttotalbill.Visible = False
        ' 
        ' TxtPhNb
        ' 
        TxtPhNb.Location = New Point(0, 131)
        TxtPhNb.Name = "TxtPhNb"
        TxtPhNb.Size = New Size(69, 27)
        TxtPhNb.TabIndex = 6
        TxtPhNb.Visible = False
        ' 
        ' TxtCusName
        ' 
        TxtCusName.Location = New Point(0, 87)
        TxtCusName.Name = "TxtCusName"
        TxtCusName.Size = New Size(69, 27)
        TxtCusName.TabIndex = 7
        TxtCusName.Visible = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(TxtCusName)
        Controls.Add(TxtPhNb)
        Controls.Add(txttotalbill)
        Controls.Add(Label2)
        Controls.Add(Lblname)
        Controls.Add(TxtPw)
        Controls.Add(TxtName)
        Controls.Add(BtnOk)
        Name = "login"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnOk As Button
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtPw As TextBox
    Friend WithEvents Lblname As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txttotalbill As TextBox
    Friend WithEvents TxtPhNb As TextBox
    Friend WithEvents TxtCusName As TextBox
End Class
