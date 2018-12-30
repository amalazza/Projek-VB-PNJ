<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Salary = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Insert = New System.Windows.Forms.Button()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Position = New System.Windows.Forms.ComboBox()
        Me.Names = New System.Windows.Forms.TextBox()
        Me.UpdateE = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TableEmp = New System.Windows.Forms.DataGridView()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TableEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(190, 343)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(190, 372)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Id
        '
        Me.Id.Location = New System.Drawing.Point(314, 339)
        Me.Id.Margin = New System.Windows.Forms.Padding(2)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(162, 20)
        Me.Id.TabIndex = 2
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(314, 426)
        Me.Address.Margin = New System.Windows.Forms.Padding(2)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(162, 20)
        Me.Address.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(190, 426)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(190, 396)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gender"
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(314, 453)
        Me.Phone.Margin = New System.Windows.Forms.Padding(2)
        Me.Phone.MaxLength = 16
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(162, 20)
        Me.Phone.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(190, 487)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Position"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(190, 457)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Phone Number"
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(314, 546)
        Me.Username.Margin = New System.Windows.Forms.Padding(2)
        Me.Username.MaxLength = 16
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(162, 20)
        Me.Username.TabIndex = 15
        '
        'Salary
        '
        Me.Salary.Location = New System.Drawing.Point(314, 513)
        Me.Salary.Margin = New System.Windows.Forms.Padding(2)
        Me.Salary.MaxLength = 11
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(162, 20)
        Me.Salary.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(190, 546)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "User Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(190, 517)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Salary"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(314, 575)
        Me.Password.Margin = New System.Windows.Forms.Padding(2)
        Me.Password.MaxLength = 16
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(162, 20)
        Me.Password.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(190, 579)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Password"
        '
        'Insert
        '
        Me.Insert.Location = New System.Drawing.Point(292, 620)
        Me.Insert.Margin = New System.Windows.Forms.Padding(2)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(82, 28)
        Me.Insert.TabIndex = 19
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'Gender
        '
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.Gender.Location = New System.Drawing.Point(314, 394)
        Me.Gender.Margin = New System.Windows.Forms.Padding(2)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(162, 21)
        Me.Gender.TabIndex = 20
        Me.Gender.Text = "Male"
        '
        'Position
        '
        Me.Position.FormattingEnabled = True
        Me.Position.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.Position.Location = New System.Drawing.Point(314, 484)
        Me.Position.Margin = New System.Windows.Forms.Padding(2)
        Me.Position.Name = "Position"
        Me.Position.Size = New System.Drawing.Size(162, 21)
        Me.Position.TabIndex = 21
        Me.Position.Text = "Admin"
        '
        'Names
        '
        Me.Names.Location = New System.Drawing.Point(314, 368)
        Me.Names.Margin = New System.Windows.Forms.Padding(2)
        Me.Names.MaxLength = 50
        Me.Names.Name = "Names"
        Me.Names.Size = New System.Drawing.Size(162, 20)
        Me.Names.TabIndex = 22
        '
        'UpdateE
        '
        Me.UpdateE.Location = New System.Drawing.Point(192, 620)
        Me.UpdateE.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateE.Name = "UpdateE"
        Me.UpdateE.Size = New System.Drawing.Size(89, 28)
        Me.UpdateE.TabIndex = 23
        Me.UpdateE.Text = "Update"
        Me.UpdateE.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(387, 620)
        Me.Delete.Margin = New System.Windows.Forms.Padding(2)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(88, 28)
        Me.Delete.TabIndex = 24
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Typewriter", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(147, 35)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(378, 37)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "EMPLOYEE MANAGEMENT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(0, -15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 98)
        Me.Panel1.TabIndex = 28
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(28, 25)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 55)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TableEmp
        '
        Me.TableEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableEmp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TableEmp.Location = New System.Drawing.Point(63, 98)
        Me.TableEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.TableEmp.Name = "TableEmp"
        Me.TableEmp.RowTemplate.Height = 24
        Me.TableEmp.Size = New System.Drawing.Size(540, 98)
        Me.TableEmp.TabIndex = 28
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(314, 210)
        Me.Search.Margin = New System.Windows.Forms.Padding(2)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(162, 20)
        Me.Search.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(190, 214)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Search"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(139, 245)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 412)
        Me.Panel2.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans Unicode", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(88, 29)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(247, 34)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "EMPLOYEE DATA"
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(651, 665)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.UpdateE)
        Me.Controls.Add(Me.Names)
        Me.Controls.Add(Me.Position)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Salary)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TableEmp)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TableEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Id As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Phone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Salary As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Insert As Button
    Friend WithEvents Gender As ComboBox
    Friend WithEvents Position As ComboBox
    Friend WithEvents Names As TextBox
    Friend WithEvents UpdateE As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableEmp As DataGridView
    Friend WithEvents Search As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Button4 As Button
End Class
