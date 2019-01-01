<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuyTicket
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtGate = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtTotPrice = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSeatLeft = New System.Windows.Forms.Label()
        Me.cboDate = New System.Windows.Forms.ComboBox()
        Me.cboMatch = New System.Windows.Forms.ComboBox()
        Me.cboTribune = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblHargaTiketSatuan = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 133)
        Me.Panel1.TabIndex = 55
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(37, 31)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 68)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Typewriter", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(271, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(260, 45)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "BUY TICKET"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 165)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "EMP ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 212)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Match"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 258)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 308)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 354)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Tribune"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 404)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Gate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 492)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 543)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Total Price"
        '
        'txtEmpId
        '
        Me.txtEmpId.Location = New System.Drawing.Point(145, 161)
        Me.txtEmpId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(132, 22)
        Me.txtEmpId.TabIndex = 64
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(145, 304)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(132, 22)
        Me.txtTime.TabIndex = 67
        '
        'txtGate
        '
        Me.txtGate.Location = New System.Drawing.Point(145, 400)
        Me.txtGate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGate.Name = "txtGate"
        Me.txtGate.Size = New System.Drawing.Size(132, 22)
        Me.txtGate.TabIndex = 69
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(145, 489)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(132, 22)
        Me.txtQuantity.TabIndex = 70
        '
        'txtTotPrice
        '
        Me.txtTotPrice.Location = New System.Drawing.Point(145, 539)
        Me.txtTotPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotPrice.Name = "txtTotPrice"
        Me.txtTotPrice.Size = New System.Drawing.Size(132, 22)
        Me.txtTotPrice.TabIndex = 71
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(309, 486)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(100, 28)
        Me.btnCheck.TabIndex = 75
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(559, 374)
        Me.btnBuy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(163, 75)
        Me.btnBuy.TabIndex = 76
        Me.btnBuy.Text = "Buy"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(555, 212)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 17)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Seat Left"
        '
        'lblSeatLeft
        '
        Me.lblSeatLeft.AutoSize = True
        Me.lblSeatLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatLeft.Location = New System.Drawing.Point(629, 193)
        Me.lblSeatLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeatLeft.Name = "lblSeatLeft"
        Me.lblSeatLeft.Size = New System.Drawing.Size(0, 46)
        Me.lblSeatLeft.TabIndex = 78
        '
        'cboDate
        '
        Me.cboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDate.FormattingEnabled = True
        Me.cboDate.Location = New System.Drawing.Point(145, 255)
        Me.cboDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboDate.Name = "cboDate"
        Me.cboDate.Size = New System.Drawing.Size(160, 24)
        Me.cboDate.TabIndex = 80
        '
        'cboMatch
        '
        Me.cboMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMatch.FormattingEnabled = True
        Me.cboMatch.Location = New System.Drawing.Point(145, 208)
        Me.cboMatch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMatch.Name = "cboMatch"
        Me.cboMatch.Size = New System.Drawing.Size(160, 24)
        Me.cboMatch.TabIndex = 81
        '
        'cboTribune
        '
        Me.cboTribune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTribune.FormattingEnabled = True
        Me.cboTribune.Location = New System.Drawing.Point(145, 351)
        Me.cboTribune.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTribune.Name = "cboTribune"
        Me.cboTribune.Size = New System.Drawing.Size(160, 24)
        Me.cboTribune.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(327, 354)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 17)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Rp"
        '
        'lblHargaTiketSatuan
        '
        Me.lblHargaTiketSatuan.AutoSize = True
        Me.lblHargaTiketSatuan.Location = New System.Drawing.Point(363, 354)
        Me.lblHargaTiketSatuan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHargaTiketSatuan.Name = "lblHargaTiketSatuan"
        Me.lblHargaTiketSatuan.Size = New System.Drawing.Size(0, 17)
        Me.lblHargaTiketSatuan.TabIndex = 84
        '
        'BuyTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 578)
        Me.Controls.Add(Me.lblHargaTiketSatuan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboTribune)
        Me.Controls.Add(Me.cboMatch)
        Me.Controls.Add(Me.cboDate)
        Me.Controls.Add(Me.lblSeatLeft)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtTotPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtGate)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtEmpId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BuyTicket"
        Me.Text = "BuyTicket"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmpId As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtGate As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtTotPrice As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnBuy As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSeatLeft As Label
    Friend WithEvents cboDate As ComboBox
    Friend WithEvents cboMatch As ComboBox
    Friend WithEvents cboTribune As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblHargaTiketSatuan As Label
End Class
