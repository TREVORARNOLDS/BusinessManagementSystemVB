<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
        Me.ProductsTitlelbl = New System.Windows.Forms.Label()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.ProductDisplayrchtxtbx = New System.Windows.Forms.RichTextBox()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.SearchAllbtn = New System.Windows.Forms.Button()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Nametxtbx = New System.Windows.Forms.TextBox()
        Me.IDtxtbx = New System.Windows.Forms.TextBox()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProductsTitlelbl
        '
        Me.ProductsTitlelbl.AutoSize = True
        Me.ProductsTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsTitlelbl.Location = New System.Drawing.Point(255, 38)
        Me.ProductsTitlelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductsTitlelbl.Name = "ProductsTitlelbl"
        Me.ProductsTitlelbl.Size = New System.Drawing.Size(407, 46)
        Me.ProductsTitlelbl.TabIndex = 2
        Me.ProductsTitlelbl.Text = "Product Search Menu"
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(600, 662)
        Me.Backbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(285, 62)
        Me.Backbtn.TabIndex = 9
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'ProductDisplayrchtxtbx
        '
        Me.ProductDisplayrchtxtbx.Location = New System.Drawing.Point(18, 152)
        Me.ProductDisplayrchtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProductDisplayrchtxtbx.Name = "ProductDisplayrchtxtbx"
        Me.ProductDisplayrchtxtbx.ReadOnly = True
        Me.ProductDisplayrchtxtbx.Size = New System.Drawing.Size(553, 482)
        Me.ProductDisplayrchtxtbx.TabIndex = 8
        Me.ProductDisplayrchtxtbx.TabStop = False
        Me.ProductDisplayrchtxtbx.Text = ""
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(600, 285)
        Me.Searchbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(285, 62)
        Me.Searchbtn.TabIndex = 3
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'SearchAllbtn
        '
        Me.SearchAllbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchAllbtn.Location = New System.Drawing.Point(600, 408)
        Me.SearchAllbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchAllbtn.Name = "SearchAllbtn"
        Me.SearchAllbtn.Size = New System.Drawing.Size(285, 62)
        Me.SearchAllbtn.TabIndex = 4
        Me.SearchAllbtn.Text = "Show All"
        Me.SearchAllbtn.UseVisualStyleBackColor = True
        '
        'Clearbtn
        '
        Me.Clearbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clearbtn.Location = New System.Drawing.Point(600, 531)
        Me.Clearbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(285, 62)
        Me.Clearbtn.TabIndex = 5
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = True
        '
        'Nametxtbx
        '
        Me.Nametxtbx.Location = New System.Drawing.Point(682, 152)
        Me.Nametxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Nametxtbx.Name = "Nametxtbx"
        Me.Nametxtbx.Size = New System.Drawing.Size(200, 26)
        Me.Nametxtbx.TabIndex = 1
        '
        'IDtxtbx
        '
        Me.IDtxtbx.Location = New System.Drawing.Point(682, 220)
        Me.IDtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IDtxtbx.Name = "IDtxtbx"
        Me.IDtxtbx.Size = New System.Drawing.Size(200, 26)
        Me.IDtxtbx.TabIndex = 2
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.Location = New System.Drawing.Point(598, 157)
        Me.Namelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(51, 20)
        Me.Namelbl.TabIndex = 14
        Me.Namelbl.Text = "Name"
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Location = New System.Drawing.Point(598, 225)
        Me.IDlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(26, 20)
        Me.IDlbl.TabIndex = 15
        Me.IDlbl.Text = "ID"
        '
        'Addbtn
        '
        Me.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Addbtn.Location = New System.Drawing.Point(15, 662)
        Me.Addbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(150, 62)
        Me.Addbtn.TabIndex = 6
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editbtn.Location = New System.Drawing.Point(202, 662)
        Me.Editbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(150, 62)
        Me.Editbtn.TabIndex = 7
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Deletebtn
        '
        Me.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Deletebtn.Location = New System.Drawing.Point(390, 662)
        Me.Deletebtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(150, 62)
        Me.Deletebtn.TabIndex = 8
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = True
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 803)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.Namelbl)
        Me.Controls.Add(Me.IDtxtbx)
        Me.Controls.Add(Me.Nametxtbx)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.SearchAllbtn)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.ProductDisplayrchtxtbx)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.ProductsTitlelbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductsTitlelbl As System.Windows.Forms.Label
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents ProductDisplayrchtxtbx As System.Windows.Forms.RichTextBox
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
    Friend WithEvents SearchAllbtn As System.Windows.Forms.Button
    Friend WithEvents Clearbtn As System.Windows.Forms.Button
    Friend WithEvents Nametxtbx As System.Windows.Forms.TextBox
    Friend WithEvents IDtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Namelbl As System.Windows.Forms.Label
    Friend WithEvents IDlbl As System.Windows.Forms.Label
    Friend WithEvents Addbtn As System.Windows.Forms.Button
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents Deletebtn As System.Windows.Forms.Button
End Class
