<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Change_Password))
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.CurrentPasstxtbx = New System.Windows.Forms.TextBox()
        Me.NewPasstxtbx = New System.Windows.Forms.TextBox()
        Me.CurrPasslbl = New System.Windows.Forms.Label()
        Me.NewPasslbl = New System.Windows.Forms.Label()
        Me.ChangePassbtn = New System.Windows.Forms.Button()
        Me.ChangePassTitlelbl = New System.Windows.Forms.Label()
        Me.PassReqSubTitlelbl = New System.Windows.Forms.Label()
        Me.PassReqlbl = New System.Windows.Forms.Label()
        Me.ConfirmPasstxtbx = New System.Windows.Forms.TextBox()
        Me.ConfirmPasslbl = New System.Windows.Forms.Label()
        Me.Usernametxtbx = New System.Windows.Forms.TextBox()
        Me.Usernamelbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Backbtn
        '
        Me.Backbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(56, 548)
        Me.Backbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(393, 105)
        Me.Backbtn.TabIndex = 24
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'CurrentPasstxtbx
        '
        Me.CurrentPasstxtbx.Location = New System.Drawing.Point(120, 285)
        Me.CurrentPasstxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CurrentPasstxtbx.Name = "CurrentPasstxtbx"
        Me.CurrentPasstxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CurrentPasstxtbx.Size = New System.Drawing.Size(368, 26)
        Me.CurrentPasstxtbx.TabIndex = 21
        '
        'NewPasstxtbx
        '
        Me.NewPasstxtbx.Location = New System.Drawing.Point(120, 383)
        Me.NewPasstxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NewPasstxtbx.Name = "NewPasstxtbx"
        Me.NewPasstxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPasstxtbx.Size = New System.Drawing.Size(368, 26)
        Me.NewPasstxtbx.TabIndex = 22
        '
        'CurrPasslbl
        '
        Me.CurrPasslbl.AutoSize = True
        Me.CurrPasslbl.Location = New System.Drawing.Point(64, 243)
        Me.CurrPasslbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CurrPasslbl.Name = "CurrPasslbl"
        Me.CurrPasslbl.Size = New System.Drawing.Size(135, 20)
        Me.CurrPasslbl.TabIndex = 12
        Me.CurrPasslbl.Text = "Current Password"
        '
        'NewPasslbl
        '
        Me.NewPasslbl.AutoSize = True
        Me.NewPasslbl.Location = New System.Drawing.Point(64, 335)
        Me.NewPasslbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NewPasslbl.Name = "NewPasslbl"
        Me.NewPasslbl.Size = New System.Drawing.Size(113, 20)
        Me.NewPasslbl.TabIndex = 13
        Me.NewPasslbl.Text = "New Password"
        '
        'ChangePassbtn
        '
        Me.ChangePassbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.ChangePassbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangePassbtn.Location = New System.Drawing.Point(566, 548)
        Me.ChangePassbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChangePassbtn.Name = "ChangePassbtn"
        Me.ChangePassbtn.Size = New System.Drawing.Size(393, 105)
        Me.ChangePassbtn.TabIndex = 25
        Me.ChangePassbtn.Text = "Change Password"
        Me.ChangePassbtn.UseVisualStyleBackColor = True
        '
        'ChangePassTitlelbl
        '
        Me.ChangePassTitlelbl.AutoSize = True
        Me.ChangePassTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePassTitlelbl.Location = New System.Drawing.Point(291, 48)
        Me.ChangePassTitlelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChangePassTitlelbl.Name = "ChangePassTitlelbl"
        Me.ChangePassTitlelbl.Size = New System.Drawing.Size(456, 46)
        Me.ChangePassTitlelbl.TabIndex = 15
        Me.ChangePassTitlelbl.Text = "Change Password Menu"
        '
        'PassReqSubTitlelbl
        '
        Me.PassReqSubTitlelbl.AutoSize = True
        Me.PassReqSubTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassReqSubTitlelbl.Location = New System.Drawing.Point(543, 218)
        Me.PassReqSubTitlelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PassReqSubTitlelbl.Name = "PassReqSubTitlelbl"
        Me.PassReqSubTitlelbl.Size = New System.Drawing.Size(289, 29)
        Me.PassReqSubTitlelbl.TabIndex = 16
        Me.PassReqSubTitlelbl.Text = "Password Requirements: "
        '
        'PassReqlbl
        '
        Me.PassReqlbl.AutoSize = True
        Me.PassReqlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassReqlbl.Location = New System.Drawing.Point(579, 268)
        Me.PassReqlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PassReqlbl.Name = "PassReqlbl"
        Me.PassReqlbl.Size = New System.Drawing.Size(362, 175)
        Me.PassReqlbl.TabIndex = 17
        Me.PassReqlbl.Text = "Must be at least 6 characters long." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Must contain one number. (0-9)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Must con" &
    "tain one lowercase letter. (a-z)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Must contain one uppercase letter. (A-Z)"
        '
        'ConfirmPasstxtbx
        '
        Me.ConfirmPasstxtbx.Location = New System.Drawing.Point(120, 478)
        Me.ConfirmPasstxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConfirmPasstxtbx.Name = "ConfirmPasstxtbx"
        Me.ConfirmPasstxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasstxtbx.Size = New System.Drawing.Size(368, 26)
        Me.ConfirmPasstxtbx.TabIndex = 23
        '
        'ConfirmPasslbl
        '
        Me.ConfirmPasslbl.AutoSize = True
        Me.ConfirmPasslbl.Location = New System.Drawing.Point(66, 440)
        Me.ConfirmPasslbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ConfirmPasslbl.Name = "ConfirmPasslbl"
        Me.ConfirmPasslbl.Size = New System.Drawing.Size(137, 20)
        Me.ConfirmPasslbl.TabIndex = 19
        Me.ConfirmPasslbl.Text = "Confirm Password"
        '
        'Usernametxtbx
        '
        Me.Usernametxtbx.Location = New System.Drawing.Point(120, 192)
        Me.Usernametxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Usernametxtbx.Name = "Usernametxtbx"
        Me.Usernametxtbx.Size = New System.Drawing.Size(368, 26)
        Me.Usernametxtbx.TabIndex = 20
        '
        'Usernamelbl
        '
        Me.Usernamelbl.AutoSize = True
        Me.Usernamelbl.Location = New System.Drawing.Point(64, 146)
        Me.Usernamelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Usernamelbl.Name = "Usernamelbl"
        Me.Usernamelbl.Size = New System.Drawing.Size(468, 20)
        Me.Usernamelbl.TabIndex = 21
        Me.Usernamelbl.Text = "Username (For the account of the password you want to change)"
        '
        'Change_Password
        '
        Me.AcceptButton = Me.ChangePassbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 688)
        Me.Controls.Add(Me.Usernamelbl)
        Me.Controls.Add(Me.Usernametxtbx)
        Me.Controls.Add(Me.ConfirmPasslbl)
        Me.Controls.Add(Me.ConfirmPasstxtbx)
        Me.Controls.Add(Me.PassReqlbl)
        Me.Controls.Add(Me.PassReqSubTitlelbl)
        Me.Controls.Add(Me.ChangePassTitlelbl)
        Me.Controls.Add(Me.ChangePassbtn)
        Me.Controls.Add(Me.NewPasslbl)
        Me.Controls.Add(Me.CurrPasslbl)
        Me.Controls.Add(Me.NewPasstxtbx)
        Me.Controls.Add(Me.CurrentPasstxtbx)
        Me.Controls.Add(Me.Backbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Change_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents CurrentPasstxtbx As System.Windows.Forms.TextBox
    Friend WithEvents NewPasstxtbx As System.Windows.Forms.TextBox
    Friend WithEvents CurrPasslbl As System.Windows.Forms.Label
    Friend WithEvents NewPasslbl As System.Windows.Forms.Label
    Friend WithEvents ChangePassbtn As System.Windows.Forms.Button
    Friend WithEvents ChangePassTitlelbl As System.Windows.Forms.Label
    Friend WithEvents PassReqSubTitlelbl As System.Windows.Forms.Label
    Friend WithEvents PassReqlbl As System.Windows.Forms.Label
    Friend WithEvents ConfirmPasstxtbx As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmPasslbl As System.Windows.Forms.Label
    Friend WithEvents Usernametxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Usernamelbl As System.Windows.Forms.Label
End Class
