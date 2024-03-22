<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_Edit))
        Me.EditProductTitlelbl = New System.Windows.Forms.Label()
        Me.NameSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.IDSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.SearchInstructlbl = New System.Windows.Forms.Label()
        Me.NameSearchlbl = New System.Windows.Forms.Label()
        Me.IDSearchlbl = New System.Windows.Forms.Label()
        Me.EditInstructlbl = New System.Windows.Forms.Label()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.NameChngtxtbx = New System.Windows.Forms.TextBox()
        Me.IDChngtxtbx = New System.Windows.Forms.TextBox()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.DescChngtxtbx = New System.Windows.Forms.TextBox()
        Me.WeiChngtxtbx = New System.Windows.Forms.TextBox()
        Me.PriChngtxtbx = New System.Windows.Forms.TextBox()
        Me.MatChngtxtbx = New System.Windows.Forms.TextBox()
        Me.StockChngtxtbx = New System.Windows.Forms.TextBox()
        Me.DimChngtxtbx = New System.Windows.Forms.TextBox()
        Me.MacNumChngtxtbx = New System.Windows.Forms.TextBox()
        Me.WiSiChngtxtbx = New System.Windows.Forms.TextBox()
        Me.Desclbl = New System.Windows.Forms.Label()
        Me.Weilbl = New System.Windows.Forms.Label()
        Me.Prilbl = New System.Windows.Forms.Label()
        Me.Matlbl = New System.Windows.Forms.Label()
        Me.Stocklbl = New System.Windows.Forms.Label()
        Me.Dimenslbl = New System.Windows.Forms.Label()
        Me.MacNumlbl = New System.Windows.Forms.Label()
        Me.WiSilbl = New System.Windows.Forms.Label()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EditProductTitlelbl
        '
        Me.EditProductTitlelbl.AutoSize = True
        Me.EditProductTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditProductTitlelbl.Location = New System.Drawing.Point(260, 14)
        Me.EditProductTitlelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EditProductTitlelbl.Name = "EditProductTitlelbl"
        Me.EditProductTitlelbl.Size = New System.Drawing.Size(239, 46)
        Me.EditProductTitlelbl.TabIndex = 5
        Me.EditProductTitlelbl.Text = "Edit Product"
        '
        'NameSrchtxtbx
        '
        Me.NameSrchtxtbx.Location = New System.Drawing.Point(184, 149)
        Me.NameSrchtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameSrchtxtbx.Name = "NameSrchtxtbx"
        Me.NameSrchtxtbx.Size = New System.Drawing.Size(506, 26)
        Me.NameSrchtxtbx.TabIndex = 6
        '
        'IDSrchtxtbx
        '
        Me.IDSrchtxtbx.Location = New System.Drawing.Point(184, 202)
        Me.IDSrchtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IDSrchtxtbx.Name = "IDSrchtxtbx"
        Me.IDSrchtxtbx.Size = New System.Drawing.Size(506, 26)
        Me.IDSrchtxtbx.TabIndex = 7
        '
        'SearchInstructlbl
        '
        Me.SearchInstructlbl.AutoSize = True
        Me.SearchInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchInstructlbl.Location = New System.Drawing.Point(18, 94)
        Me.SearchInstructlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SearchInstructlbl.Name = "SearchInstructlbl"
        Me.SearchInstructlbl.Size = New System.Drawing.Size(319, 20)
        Me.SearchInstructlbl.TabIndex = 8
        Me.SearchInstructlbl.Text = "Search for the product that you want to edit:"
        '
        'NameSearchlbl
        '
        Me.NameSearchlbl.AutoSize = True
        Me.NameSearchlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameSearchlbl.Location = New System.Drawing.Point(63, 149)
        Me.NameSearchlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameSearchlbl.Name = "NameSearchlbl"
        Me.NameSearchlbl.Size = New System.Drawing.Size(110, 20)
        Me.NameSearchlbl.TabIndex = 9
        Me.NameSearchlbl.Text = "Product Name"
        '
        'IDSearchlbl
        '
        Me.IDSearchlbl.AutoSize = True
        Me.IDSearchlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDSearchlbl.Location = New System.Drawing.Point(88, 202)
        Me.IDSearchlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDSearchlbl.Name = "IDSearchlbl"
        Me.IDSearchlbl.Size = New System.Drawing.Size(85, 20)
        Me.IDSearchlbl.TabIndex = 10
        Me.IDSearchlbl.Text = "Product ID"
        '
        'EditInstructlbl
        '
        Me.EditInstructlbl.AutoSize = True
        Me.EditInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditInstructlbl.Location = New System.Drawing.Point(18, 320)
        Me.EditInstructlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EditInstructlbl.Name = "EditInstructlbl"
        Me.EditInstructlbl.Size = New System.Drawing.Size(303, 20)
        Me.EditInstructlbl.TabIndex = 11
        Me.EditInstructlbl.Text = "Enter the details that you want to change:"
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namelbl.Location = New System.Drawing.Point(63, 369)
        Me.Namelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(110, 20)
        Me.Namelbl.TabIndex = 12
        Me.Namelbl.Text = "Product Name"
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDlbl.Location = New System.Drawing.Point(88, 409)
        Me.IDlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(81, 20)
        Me.IDlbl.TabIndex = 13
        Me.IDlbl.Text = "Unique ID"
        '
        'NameChngtxtbx
        '
        Me.NameChngtxtbx.Location = New System.Drawing.Point(184, 369)
        Me.NameChngtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameChngtxtbx.Name = "NameChngtxtbx"
        Me.NameChngtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.NameChngtxtbx.TabIndex = 14
        '
        'IDChngtxtbx
        '
        Me.IDChngtxtbx.Location = New System.Drawing.Point(184, 409)
        Me.IDChngtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IDChngtxtbx.Name = "IDChngtxtbx"
        Me.IDChngtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.IDChngtxtbx.TabIndex = 15
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(18, 608)
        Me.Backbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(375, 57)
        Me.Backbtn.TabIndex = 16
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editbtn.Location = New System.Drawing.Point(402, 608)
        Me.Editbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(375, 57)
        Me.Editbtn.TabIndex = 17
        Me.Editbtn.Text = "Edit/Save"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'DescChngtxtbx
        '
        Me.DescChngtxtbx.Location = New System.Drawing.Point(184, 449)
        Me.DescChngtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DescChngtxtbx.Name = "DescChngtxtbx"
        Me.DescChngtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.DescChngtxtbx.TabIndex = 18
        '
        'WeiChngtxtbx
        '
        Me.WeiChngtxtbx.Location = New System.Drawing.Point(184, 489)
        Me.WeiChngtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WeiChngtxtbx.Name = "WeiChngtxtbx"
        Me.WeiChngtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.WeiChngtxtbx.TabIndex = 19
        '
        'PriChngtxtbx
        '
        Me.PriChngtxtbx.Location = New System.Drawing.Point(184, 529)
        Me.PriChngtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PriChngtxtbx.Name = "PriChngtxtbx"
        Me.PriChngtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.PriChngtxtbx.TabIndex = 20
        '
        'MatChngtxtbx
        '
        Me.MatChngtxtbx.Location = New System.Drawing.Point(512, 365)
        Me.MatChngtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MatChngtxtbx.Name = "MatChngtxtbx"
        Me.MatChngtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.MatChngtxtbx.TabIndex = 22
        '
        'StockChngtxtbx
        '
        Me.StockChngtxtbx.Location = New System.Drawing.Point(512, 409)
        Me.StockChngtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StockChngtxtbx.Name = "StockChngtxtbx"
        Me.StockChngtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.StockChngtxtbx.TabIndex = 23
        '
        'DimChngtxtbx
        '
        Me.DimChngtxtbx.Location = New System.Drawing.Point(512, 449)
        Me.DimChngtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DimChngtxtbx.Name = "DimChngtxtbx"
        Me.DimChngtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.DimChngtxtbx.TabIndex = 24
        '
        'MacNumChngtxtbx
        '
        Me.MacNumChngtxtbx.Location = New System.Drawing.Point(512, 489)
        Me.MacNumChngtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MacNumChngtxtbx.Name = "MacNumChngtxtbx"
        Me.MacNumChngtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.MacNumChngtxtbx.TabIndex = 25
        '
        'WiSiChngtxtbx
        '
        Me.WiSiChngtxtbx.Location = New System.Drawing.Point(512, 529)
        Me.WiSiChngtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WiSiChngtxtbx.Name = "WiSiChngtxtbx"
        Me.WiSiChngtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.WiSiChngtxtbx.TabIndex = 26
        '
        'Desclbl
        '
        Me.Desclbl.AutoSize = True
        Me.Desclbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desclbl.Location = New System.Drawing.Point(86, 449)
        Me.Desclbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Desclbl.Name = "Desclbl"
        Me.Desclbl.Size = New System.Drawing.Size(89, 20)
        Me.Desclbl.TabIndex = 27
        Me.Desclbl.Text = "Description"
        '
        'Weilbl
        '
        Me.Weilbl.AutoSize = True
        Me.Weilbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weilbl.Location = New System.Drawing.Point(114, 489)
        Me.Weilbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Weilbl.Name = "Weilbl"
        Me.Weilbl.Size = New System.Drawing.Size(59, 20)
        Me.Weilbl.TabIndex = 28
        Me.Weilbl.Text = "Weight"
        '
        'Prilbl
        '
        Me.Prilbl.AutoSize = True
        Me.Prilbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prilbl.Location = New System.Drawing.Point(129, 529)
        Me.Prilbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Prilbl.Name = "Prilbl"
        Me.Prilbl.Size = New System.Drawing.Size(44, 20)
        Me.Prilbl.TabIndex = 29
        Me.Prilbl.Text = "Price"
        '
        'Matlbl
        '
        Me.Matlbl.AutoSize = True
        Me.Matlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Matlbl.Location = New System.Drawing.Point(436, 365)
        Me.Matlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Matlbl.Name = "Matlbl"
        Me.Matlbl.Size = New System.Drawing.Size(65, 20)
        Me.Matlbl.TabIndex = 30
        Me.Matlbl.Text = "Material"
        '
        'Stocklbl
        '
        Me.Stocklbl.AutoSize = True
        Me.Stocklbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stocklbl.Location = New System.Drawing.Point(450, 409)
        Me.Stocklbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Stocklbl.Name = "Stocklbl"
        Me.Stocklbl.Size = New System.Drawing.Size(50, 20)
        Me.Stocklbl.TabIndex = 31
        Me.Stocklbl.Text = "Stock"
        '
        'Dimenslbl
        '
        Me.Dimenslbl.AutoSize = True
        Me.Dimenslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dimenslbl.Location = New System.Drawing.Point(411, 449)
        Me.Dimenslbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Dimenslbl.Name = "Dimenslbl"
        Me.Dimenslbl.Size = New System.Drawing.Size(92, 20)
        Me.Dimenslbl.TabIndex = 32
        Me.Dimenslbl.Text = "Dimensions"
        '
        'MacNumlbl
        '
        Me.MacNumlbl.AutoSize = True
        Me.MacNumlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MacNumlbl.Location = New System.Drawing.Point(370, 489)
        Me.MacNumlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MacNumlbl.Name = "MacNumlbl"
        Me.MacNumlbl.Size = New System.Drawing.Size(129, 20)
        Me.MacNumlbl.TabIndex = 33
        Me.MacNumlbl.Text = "Machine Number"
        '
        'WiSilbl
        '
        Me.WiSilbl.AutoSize = True
        Me.WiSilbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WiSilbl.Location = New System.Drawing.Point(424, 534)
        Me.WiSilbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WiSilbl.Name = "WiSilbl"
        Me.WiSilbl.Size = New System.Drawing.Size(76, 20)
        Me.WiSilbl.TabIndex = 34
        Me.WiSilbl.Text = "Wire Size"
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(268, 249)
        Me.Searchbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(234, 45)
        Me.Searchbtn.TabIndex = 35
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Product_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 683)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.WiSilbl)
        Me.Controls.Add(Me.MacNumlbl)
        Me.Controls.Add(Me.Dimenslbl)
        Me.Controls.Add(Me.Stocklbl)
        Me.Controls.Add(Me.Matlbl)
        Me.Controls.Add(Me.Prilbl)
        Me.Controls.Add(Me.Weilbl)
        Me.Controls.Add(Me.Desclbl)
        Me.Controls.Add(Me.WiSiChngtxtbx)
        Me.Controls.Add(Me.MacNumChngtxtbx)
        Me.Controls.Add(Me.DimChngtxtbx)
        Me.Controls.Add(Me.StockChngtxtbx)
        Me.Controls.Add(Me.MatChngtxtbx)
        Me.Controls.Add(Me.PriChngtxtbx)
        Me.Controls.Add(Me.WeiChngtxtbx)
        Me.Controls.Add(Me.DescChngtxtbx)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.IDChngtxtbx)
        Me.Controls.Add(Me.NameChngtxtbx)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.Namelbl)
        Me.Controls.Add(Me.EditInstructlbl)
        Me.Controls.Add(Me.IDSearchlbl)
        Me.Controls.Add(Me.NameSearchlbl)
        Me.Controls.Add(Me.SearchInstructlbl)
        Me.Controls.Add(Me.IDSrchtxtbx)
        Me.Controls.Add(Me.NameSrchtxtbx)
        Me.Controls.Add(Me.EditProductTitlelbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Product_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product_Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EditProductTitlelbl As System.Windows.Forms.Label
    Friend WithEvents NameSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents IDSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents SearchInstructlbl As System.Windows.Forms.Label
    Friend WithEvents NameSearchlbl As System.Windows.Forms.Label
    Friend WithEvents IDSearchlbl As System.Windows.Forms.Label
    Friend WithEvents EditInstructlbl As System.Windows.Forms.Label
    Friend WithEvents Namelbl As System.Windows.Forms.Label
    Friend WithEvents IDlbl As System.Windows.Forms.Label
    Friend WithEvents NameChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents IDChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents DescChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents WeiChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents PriChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents MatChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents StockChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents DimChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents MacNumChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents WiSiChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Desclbl As System.Windows.Forms.Label
    Friend WithEvents Weilbl As System.Windows.Forms.Label
    Friend WithEvents Prilbl As System.Windows.Forms.Label
    Friend WithEvents Matlbl As System.Windows.Forms.Label
    Friend WithEvents Stocklbl As System.Windows.Forms.Label
    Friend WithEvents Dimenslbl As System.Windows.Forms.Label
    Friend WithEvents MacNumlbl As System.Windows.Forms.Label
    Friend WithEvents WiSilbl As System.Windows.Forms.Label
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
End Class
