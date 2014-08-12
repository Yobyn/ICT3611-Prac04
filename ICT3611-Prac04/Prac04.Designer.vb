<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prac04
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAddContact = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.LOadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.userName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.phoneNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Phone Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Category:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(125, 100)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(157, 20)
        Me.txtName.TabIndex = 3
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(125, 128)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(157, 20)
        Me.txtPhoneNumber.TabIndex = 4
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(125, 159)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(157, 20)
        Me.txtCategory.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(770, 37)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(596, 39)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(157, 20)
        Me.txtSearch.TabIndex = 8
        '
        'btnAddContact
        '
        Me.btnAddContact.Location = New System.Drawing.Point(160, 209)
        Me.btnAddContact.Name = "btnAddContact"
        Me.btnAddContact.Size = New System.Drawing.Size(120, 23)
        Me.btnAddContact.TabIndex = 9
        Me.btnAddContact.Text = "Add to Contact"
        Me.btnAddContact.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOadToolStripMenuItem, Me.ProgramToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(862, 24)
        Me.MenuStrip2.TabIndex = 14
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'LOadToolStripMenuItem
        '
        Me.LOadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem1, Me.SaveToolStripMenuItem})
        Me.LOadToolStripMenuItem.Name = "LOadToolStripMenuItem"
        Me.LOadToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.LOadToolStripMenuItem.Text = "File"
        '
        'LoadToolStripMenuItem1
        '
        Me.LoadToolStripMenuItem1.Name = "LoadToolStripMenuItem1"
        Me.LoadToolStripMenuItem1.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem1.Text = "Load"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lstView
        '
        Me.lstView.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.lstView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.userName, Me.phoneNumber, Me.category})
        Me.lstView.Location = New System.Drawing.Point(326, 75)
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(524, 243)
        Me.lstView.TabIndex = 15
        Me.lstView.UseCompatibleStateImageBehavior = False
        Me.lstView.View = System.Windows.Forms.View.Details
        '
        'userName
        '
        Me.userName.Text = "Name"
        Me.userName.Width = 187
        '
        'phoneNumber
        '
        Me.phoneNumber.Text = "PhoneNumber"
        Me.phoneNumber.Width = 185
        '
        'category
        '
        Me.category.Text = "Category"
        Me.category.Width = 148
        '
        'openFileDialog
        '
        Me.openFileDialog.FileName = "openFileDialog"
        '
        'Prac04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 330)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.btnAddContact)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Prac04"
        Me.Text = "ICT3611-Prac04"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnAddContact As System.Windows.Forms.Button
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents LOadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents userName As System.Windows.Forms.ColumnHeader
    Friend WithEvents phoneNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents category As System.Windows.Forms.ColumnHeader
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveFileDialog As System.Windows.Forms.SaveFileDialog

End Class
