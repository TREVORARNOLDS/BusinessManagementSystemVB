<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_Delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction_Delete))
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.FormInstructlbl = New System.Windows.Forms.Label()
        Me.DelTranslbl = New System.Windows.Forms.Label()
        Me.TransIDlbl = New System.Windows.Forms.Label()
        Me.TransIDSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(18, 363)
        Me.Backbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(260, 54)
        Me.Backbtn.TabIndex = 17
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'FormInstructlbl
        '
        Me.FormInstructlbl.AutoSize = True
        Me.FormInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormInstructlbl.Location = New System.Drawing.Point(207, 140)
        Me.FormInstructlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FormInstructlbl.Name = "FormInstructlbl"
        Me.FormInstructlbl.Size = New System.Drawing.Size(348, 20)
        Me.FormInstructlbl.TabIndex = 25
        Me.FormInstructlbl.Text = "Search for the transaction you want to delete:"
        '
        'DelTranslbl
        '
        Me.DelTranslbl.AutoSize = True
        Me.DelTranslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelTranslbl.Location = New System.Drawing.Point(195, 46)
        Me.DelTranslbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DelTranslbl.Name = "DelTranslbl"
        Me.DelTranslbl.Size = New System.Drawing.Size(355, 46)
        Me.DelTranslbl.TabIndex = 24
        Me.DelTranslbl.Text = "Delete Transaction"
        '
        'TransIDlbl
        '
        Me.TransIDlbl.AutoSize = True
        Me.TransIDlbl.Location = New System.Drawing.Point(232, 248)
        Me.TransIDlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TransIDlbl.Name = "TransIDlbl"
        Me.TransIDlbl.Size = New System.Drawing.Size(117, 20)
        Me.TransIDlbl.TabIndex = 22
        Me.TransIDlbl.Text = "Transaction ID:"
        '
        'TransIDSrchtxtbx
        '
        Me.TransIDSrchtxtbx.Location = New System.Drawing.Point(356, 242)
        Me.TransIDSrchtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TransIDSrchtxtbx.Name = "TransIDSrchtxtbx"
        Me.TransIDSrchtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.TransIDSrchtxtbx.TabIndex = 20
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(468, 363)
        Me.Searchbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(260, 54)
        Me.Searchbtn.TabIndex = 18
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Transaction_Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 463)
        Me.Controls.Add(Me.FormInstructlbl)
        Me.Controls.Add(Me.DelTranslbl)
        Me.Controls.Add(Me.TransIDlbl)
        Me.Controls.Add(Me.TransIDSrchtxtbx)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.Backbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Transaction_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction_Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents FormInstructlbl As System.Windows.Forms.Label
    Friend WithEvents DelTranslbl As System.Windows.Forms.Label
    Friend WithEvents TransIDlbl As System.Windows.Forms.Label
    Friend WithEvents TransIDSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
End Class
