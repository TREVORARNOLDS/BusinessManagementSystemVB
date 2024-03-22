<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transactions))
        Me.TransactionsTitlelbl = New System.Windows.Forms.Label()
        Me.TransDisplayrchtxtbx = New System.Windows.Forms.RichTextBox()
        Me.CustIDlbl = New System.Windows.Forms.Label()
        Me.ProdIDlbl = New System.Windows.Forms.Label()
        Me.CustIDtxtbx = New System.Windows.Forms.TextBox()
        Me.ProdIDtxtbx = New System.Windows.Forms.TextBox()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.SearchAllbtn = New System.Windows.Forms.Button()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.Datedttmpkr = New System.Windows.Forms.DateTimePicker()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.TransIDlbl = New System.Windows.Forms.Label()
        Me.TransIDtxtbx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TransactionsTitlelbl
        '
        Me.TransactionsTitlelbl.AutoSize = True
        Me.TransactionsTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionsTitlelbl.Location = New System.Drawing.Point(208, 42)
        Me.TransactionsTitlelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TransactionsTitlelbl.Name = "TransactionsTitlelbl"
        Me.TransactionsTitlelbl.Size = New System.Drawing.Size(477, 46)
        Me.TransactionsTitlelbl.TabIndex = 3
        Me.TransactionsTitlelbl.Text = "Transaction Search Menu"
        '
        'TransDisplayrchtxtbx
        '
        Me.TransDisplayrchtxtbx.Location = New System.Drawing.Point(18, 123)
        Me.TransDisplayrchtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TransDisplayrchtxtbx.Name = "TransDisplayrchtxtbx"
        Me.TransDisplayrchtxtbx.ReadOnly = True
        Me.TransDisplayrchtxtbx.Size = New System.Drawing.Size(553, 482)
        Me.TransDisplayrchtxtbx.TabIndex = 42
        Me.TransDisplayrchtxtbx.Text = ""
        '
        'CustIDlbl
        '
        Me.CustIDlbl.AutoSize = True
        Me.CustIDlbl.Location = New System.Drawing.Point(585, 249)
        Me.CustIDlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CustIDlbl.Name = "CustIDlbl"
        Me.CustIDlbl.Size = New System.Drawing.Size(95, 20)
        Me.CustIDlbl.TabIndex = 23
        Me.CustIDlbl.Text = "CustomerID"
        '
        'ProdIDlbl
        '
        Me.ProdIDlbl.AutoSize = True
        Me.ProdIDlbl.Location = New System.Drawing.Point(585, 206)
        Me.ProdIDlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProdIDlbl.Name = "ProdIDlbl"
        Me.ProdIDlbl.Size = New System.Drawing.Size(85, 20)
        Me.ProdIDlbl.TabIndex = 22
        Me.ProdIDlbl.Text = "Product ID"
        '
        'CustIDtxtbx
        '
        Me.CustIDtxtbx.Location = New System.Drawing.Point(699, 248)
        Me.CustIDtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CustIDtxtbx.Name = "CustIDtxtbx"
        Me.CustIDtxtbx.Size = New System.Drawing.Size(193, 26)
        Me.CustIDtxtbx.TabIndex = 33
        '
        'ProdIDtxtbx
        '
        Me.ProdIDtxtbx.Location = New System.Drawing.Point(699, 206)
        Me.ProdIDtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProdIDtxtbx.Name = "ProdIDtxtbx"
        Me.ProdIDtxtbx.Size = New System.Drawing.Size(193, 26)
        Me.ProdIDtxtbx.TabIndex = 32
        '
        'Clearbtn
        '
        Me.Clearbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clearbtn.Location = New System.Drawing.Point(600, 505)
        Me.Clearbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(122, 103)
        Me.Clearbtn.TabIndex = 37
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = True
        '
        'SearchAllbtn
        '
        Me.SearchAllbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchAllbtn.Location = New System.Drawing.Point(744, 372)
        Me.SearchAllbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchAllbtn.Name = "SearchAllbtn"
        Me.SearchAllbtn.Size = New System.Drawing.Size(120, 103)
        Me.SearchAllbtn.TabIndex = 36
        Me.SearchAllbtn.Text = "Show All"
        Me.SearchAllbtn.UseVisualStyleBackColor = True
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(744, 505)
        Me.Backbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(120, 103)
        Me.Backbtn.TabIndex = 41
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'Datedttmpkr
        '
        Me.Datedttmpkr.Location = New System.Drawing.Point(699, 294)
        Me.Datedttmpkr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Datedttmpkr.Name = "Datedttmpkr"
        Me.Datedttmpkr.ShowCheckBox = True
        Me.Datedttmpkr.Size = New System.Drawing.Size(193, 26)
        Me.Datedttmpkr.TabIndex = 34
        Me.Datedttmpkr.Value = New Date(2014, 12, 10, 0, 0, 0, 0)
        '
        'Datelbl
        '
        Me.Datelbl.AutoSize = True
        Me.Datelbl.Location = New System.Drawing.Point(585, 297)
        Me.Datelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(44, 20)
        Me.Datelbl.TabIndex = 25
        Me.Datelbl.Text = "Date"
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(600, 372)
        Me.Searchbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(122, 103)
        Me.Searchbtn.TabIndex = 35
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Deletebtn
        '
        Me.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Deletebtn.Location = New System.Drawing.Point(600, 635)
        Me.Deletebtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(264, 80)
        Me.Deletebtn.TabIndex = 40
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editbtn.Location = New System.Drawing.Point(306, 635)
        Me.Editbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(264, 80)
        Me.Editbtn.TabIndex = 39
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Addbtn
        '
        Me.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Addbtn.Location = New System.Drawing.Point(18, 635)
        Me.Addbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(255, 80)
        Me.Addbtn.TabIndex = 38
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = True
        '
        'TransIDlbl
        '
        Me.TransIDlbl.AutoSize = True
        Me.TransIDlbl.Location = New System.Drawing.Point(584, 163)
        Me.TransIDlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TransIDlbl.Name = "TransIDlbl"
        Me.TransIDlbl.Size = New System.Drawing.Size(109, 20)
        Me.TransIDlbl.TabIndex = 30
        Me.TransIDlbl.Text = "TransactionID"
        '
        'TransIDtxtbx
        '
        Me.TransIDtxtbx.Location = New System.Drawing.Point(699, 158)
        Me.TransIDtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TransIDtxtbx.Name = "TransIDtxtbx"
        Me.TransIDtxtbx.Size = New System.Drawing.Size(193, 26)
        Me.TransIDtxtbx.TabIndex = 31
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 751)
        Me.Controls.Add(Me.TransIDtxtbx)
        Me.Controls.Add(Me.TransIDlbl)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.Datelbl)
        Me.Controls.Add(Me.Datedttmpkr)
        Me.Controls.Add(Me.CustIDlbl)
        Me.Controls.Add(Me.ProdIDlbl)
        Me.Controls.Add(Me.CustIDtxtbx)
        Me.Controls.Add(Me.ProdIDtxtbx)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.SearchAllbtn)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.TransDisplayrchtxtbx)
        Me.Controls.Add(Me.TransactionsTitlelbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Transactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transactions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransactionsTitlelbl As System.Windows.Forms.Label
    Friend WithEvents TransDisplayrchtxtbx As System.Windows.Forms.RichTextBox
    Friend WithEvents CustIDlbl As System.Windows.Forms.Label
    Friend WithEvents ProdIDlbl As System.Windows.Forms.Label
    Friend WithEvents CustIDtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents ProdIDtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Clearbtn As System.Windows.Forms.Button
    Friend WithEvents SearchAllbtn As System.Windows.Forms.Button
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents Datedttmpkr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Datelbl As System.Windows.Forms.Label
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
    Friend WithEvents Deletebtn As System.Windows.Forms.Button
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents Addbtn As System.Windows.Forms.Button
    Friend WithEvents TransIDlbl As System.Windows.Forms.Label
    Friend WithEvents TransIDtxtbx As System.Windows.Forms.TextBox
End Class
