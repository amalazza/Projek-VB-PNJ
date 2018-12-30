<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatchManage
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UpdateM = New System.Windows.Forms.Button()
        Me.Names = New System.Windows.Forms.TextBox()
        Me.Insert = New System.Windows.Forms.Button()
        Me.datee = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Code = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tournament = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableEmp = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.TableEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans Unicode", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(88, 29)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(207, 34)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "MATCH DATA"
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
        Me.Label11.Location = New System.Drawing.Point(147, 35)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(321, 37)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "MATCH MANAGEMENT"
        '
        'UpdateM
        '
        Me.UpdateM.Location = New System.Drawing.Point(109, 237)
        Me.UpdateM.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateM.Name = "UpdateM"
        Me.UpdateM.Size = New System.Drawing.Size(89, 28)
        Me.UpdateM.TabIndex = 51
        Me.UpdateM.Text = "Update"
        Me.UpdateM.UseVisualStyleBackColor = True
        '
        'Names
        '
        Me.Names.Location = New System.Drawing.Point(308, 379)
        Me.Names.Margin = New System.Windows.Forms.Padding(2)
        Me.Names.MaxLength = 50
        Me.Names.Name = "Names"
        Me.Names.Size = New System.Drawing.Size(162, 20)
        Me.Names.TabIndex = 50
        '
        'Insert
        '
        Me.Insert.Location = New System.Drawing.Point(209, 237)
        Me.Insert.Margin = New System.Windows.Forms.Padding(2)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(82, 28)
        Me.Insert.TabIndex = 47
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'datee
        '
        Me.datee.Location = New System.Drawing.Point(175, 147)
        Me.datee.Margin = New System.Windows.Forms.Padding(2)
        Me.datee.Name = "datee"
        Me.datee.Size = New System.Drawing.Size(162, 20)
        Me.datee.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(51, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Date"
        '
        'Code
        '
        Me.Code.Enabled = False
        Me.Code.Location = New System.Drawing.Point(175, 99)
        Me.Code.Margin = New System.Windows.Forms.Padding(2)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(162, 20)
        Me.Code.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(184, 383)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Match"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(51, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Match Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.UpdateM)
        Me.Panel2.Controls.Add(Me.tournament)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Insert)
        Me.Panel2.Controls.Add(Me.time)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.datee)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Code)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(133, 256)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(386, 298)
        Me.Panel2.TabIndex = 57
        '
        'tournament
        '
        Me.tournament.Location = New System.Drawing.Point(176, 196)
        Me.tournament.Margin = New System.Windows.Forms.Padding(2)
        Me.tournament.Name = "tournament"
        Me.tournament.Size = New System.Drawing.Size(162, 20)
        Me.tournament.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(52, 196)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Tournament"
        '
        'time
        '
        Me.time.Location = New System.Drawing.Point(175, 171)
        Me.time.Margin = New System.Windows.Forms.Padding(2)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(162, 20)
        Me.time.TabIndex = 39
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
        Me.Label4.Text = "Time"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(308, 221)
        Me.Search.Margin = New System.Windows.Forms.Padding(2)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(162, 20)
        Me.Search.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(184, 225)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Search"
        '
        'TableEmp
        '
        Me.TableEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableEmp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TableEmp.Location = New System.Drawing.Point(57, 109)
        Me.TableEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.TableEmp.Name = "TableEmp"
        Me.TableEmp.RowTemplate.Height = 24
        Me.TableEmp.Size = New System.Drawing.Size(540, 98)
        Me.TableEmp.TabIndex = 53
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(-6, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 98)
        Me.Panel1.TabIndex = 54
        '
        'MatchManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 665)
        Me.Controls.Add(Me.Names)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TableEmp)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MatchManage"
        Me.Text = "MatchManage"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TableEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableEmp As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Search As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Code As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents datee As TextBox
    Friend WithEvents Insert As Button
    Friend WithEvents Names As TextBox
    Friend WithEvents UpdateM As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents tournament As TextBox
    Friend WithEvents time As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
