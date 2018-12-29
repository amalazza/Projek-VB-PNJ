<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeatManage
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.matchid = New System.Windows.Forms.TextBox()
        Me.capacity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gate = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Delete = New System.Windows.Forms.Button()
        Me.price = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UpdateS = New System.Windows.Forms.Button()
        Me.Insert = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tribune_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableEmp = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Searchh = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.TableEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(190, 387)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Match"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(190, 229)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Search"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(51, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Gate"
        '
        'matchid
        '
        Me.matchid.Location = New System.Drawing.Point(314, 383)
        Me.matchid.Margin = New System.Windows.Forms.Padding(2)
        Me.matchid.MaxLength = 50
        Me.matchid.Name = "matchid"
        Me.matchid.Size = New System.Drawing.Size(162, 20)
        Me.matchid.TabIndex = 59
        '
        'capacity
        '
        Me.capacity.Location = New System.Drawing.Point(176, 196)
        Me.capacity.Margin = New System.Windows.Forms.Padding(2)
        Me.capacity.Name = "capacity"
        Me.capacity.Size = New System.Drawing.Size(162, 20)
        Me.capacity.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(52, 196)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Capacity"
        '
        'gate
        '
        Me.gate.Location = New System.Drawing.Point(175, 171)
        Me.gate.Margin = New System.Windows.Forms.Padding(2)
        Me.gate.Name = "gate"
        Me.gate.Size = New System.Drawing.Size(162, 20)
        Me.gate.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Delete)
        Me.Panel2.Controls.Add(Me.price)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.UpdateS)
        Me.Panel2.Controls.Add(Me.capacity)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Insert)
        Me.Panel2.Controls.Add(Me.gate)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.tribune_name)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(139, 260)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(386, 298)
        Me.Panel2.TabIndex = 64
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(71, 259)
        Me.Delete.Margin = New System.Windows.Forms.Padding(2)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(89, 28)
        Me.Delete.TabIndex = 54
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'price
        '
        Me.price.Location = New System.Drawing.Point(176, 220)
        Me.price.Margin = New System.Windows.Forms.Padding(2)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(162, 20)
        Me.price.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(52, 220)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Price"
        '
        'UpdateS
        '
        Me.UpdateS.Location = New System.Drawing.Point(162, 259)
        Me.UpdateS.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateS.Name = "UpdateS"
        Me.UpdateS.Size = New System.Drawing.Size(89, 28)
        Me.UpdateS.TabIndex = 51
        Me.UpdateS.Text = "Update"
        Me.UpdateS.UseVisualStyleBackColor = True
        '
        'Insert
        '
        Me.Insert.Location = New System.Drawing.Point(255, 259)
        Me.Insert.Margin = New System.Windows.Forms.Padding(2)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(82, 28)
        Me.Insert.TabIndex = 47
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans Unicode", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(107, 28)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(174, 34)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "SEAT DATA"
        '
        'tribune_name
        '
        Me.tribune_name.Location = New System.Drawing.Point(175, 147)
        Me.tribune_name.Margin = New System.Windows.Forms.Padding(2)
        Me.tribune_name.Name = "tribune_name"
        Me.tribune_name.Size = New System.Drawing.Size(162, 20)
        Me.tribune_name.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(51, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Tribune Name"
        '
        'TableEmp
        '
        Me.TableEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableEmp.Location = New System.Drawing.Point(63, 113)
        Me.TableEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.TableEmp.Name = "TableEmp"
        Me.TableEmp.RowTemplate.Height = 24
        Me.TableEmp.Size = New System.Drawing.Size(540, 98)
        Me.TableEmp.TabIndex = 60
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 98)
        Me.Panel1.TabIndex = 61
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Typewriter", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(203, 27)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(302, 37)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "SEAT MANAGEMENT"
        '
        'Searchh
        '
        Me.Searchh.Location = New System.Drawing.Point(272, 226)
        Me.Searchh.Name = "Searchh"
        Me.Searchh.Size = New System.Drawing.Size(174, 20)
        Me.Searchh.TabIndex = 65
        '
        'SeatManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 665)
        Me.Controls.Add(Me.Searchh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.matchid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableEmp)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SeatManage"
        Me.Text = "Seat"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TableEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableEmp As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents tribune_name As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Insert As Button
    Friend WithEvents UpdateS As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents gate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents capacity As TextBox
    Friend WithEvents matchid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents price As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Delete As Button
    Friend WithEvents Searchh As TextBox
End Class
