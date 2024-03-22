<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Main))
        Me.Productsbtn = New System.Windows.Forms.Button()
        Me.Customersbtn = New System.Windows.Forms.Button()
        Me.Suppliersbtn = New System.Windows.Forms.Button()
        Me.Logoutbtn = New System.Windows.Forms.Button()
        Me.EmployeeMainTitlelbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Productsbtn
        '
        Me.Productsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Productsbtn.Location = New System.Drawing.Point(74, 145)
        Me.Productsbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Productsbtn.Name = "Productsbtn"
        Me.Productsbtn.Size = New System.Drawing.Size(240, 105)
        Me.Productsbtn.TabIndex = 8
        Me.Productsbtn.Text = "Products"
        Me.Productsbtn.UseVisualStyleBackColor = True
        '
        'Customersbtn
        '
        Me.Customersbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Customersbtn.Location = New System.Drawing.Point(354, 145)
        Me.Customersbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Customersbtn.Name = "Customersbtn"
        Me.Customersbtn.Size = New System.Drawing.Size(240, 105)
        Me.Customersbtn.TabIndex = 9
        Me.Customersbtn.Text = "Customers"
        Me.Customersbtn.UseVisualStyleBackColor = True
        '
        'Suppliersbtn
        '
        Me.Suppliersbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Suppliersbtn.Location = New System.Drawing.Point(74, 274)
        Me.Suppliersbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Suppliersbtn.Name = "Suppliersbtn"
        Me.Suppliersbtn.Size = New System.Drawing.Size(520, 105)
        Me.Suppliersbtn.TabIndex = 10
        Me.Suppliersbtn.Text = "Suppliers"
        Me.Suppliersbtn.UseVisualStyleBackColor = True
        '
        'Logoutbtn
        '
        Me.Logoutbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logoutbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Logoutbtn.Location = New System.Drawing.Point(548, 15)
        Me.Logoutbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Logoutbtn.Name = "Logoutbtn"
        Me.Logoutbtn.Size = New System.Drawing.Size(99, 45)
        Me.Logoutbtn.TabIndex = 11
        Me.Logoutbtn.Text = "Logout"
        Me.Logoutbtn.UseVisualStyleBackColor = True
        '
        'EmployeeMainTitlelbl
        '
        Me.EmployeeMainTitlelbl.AutoSize = True
        Me.EmployeeMainTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeMainTitlelbl.Location = New System.Drawing.Point(129, 38)
        Me.EmployeeMainTitlelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmployeeMainTitlelbl.Name = "EmployeeMainTitlelbl"
        Me.EmployeeMainTitlelbl.Size = New System.Drawing.Size(405, 46)
        Me.EmployeeMainTitlelbl.TabIndex = 16
        Me.EmployeeMainTitlelbl.Text = "Employee Main Menu"
        '
        'Employee_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Logoutbtn
        Me.ClientSize = New System.Drawing.Size(664, 426)
        Me.Controls.Add(Me.EmployeeMainTitlelbl)
        Me.Controls.Add(Me.Logoutbtn)
        Me.Controls.Add(Me.Suppliersbtn)
        Me.Controls.Add(Me.Customersbtn)
        Me.Controls.Add(Me.Productsbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Employee_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee_Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Productsbtn As System.Windows.Forms.Button
    Friend WithEvents Customersbtn As System.Windows.Forms.Button
    Friend WithEvents Suppliersbtn As System.Windows.Forms.Button
    Friend WithEvents Logoutbtn As System.Windows.Forms.Button
    Friend WithEvents EmployeeMainTitlelbl As System.Windows.Forms.Label
End Class
