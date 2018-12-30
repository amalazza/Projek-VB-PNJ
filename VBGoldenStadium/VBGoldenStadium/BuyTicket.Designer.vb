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
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtGate = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtTotPrice = New System.Windows.Forms.TextBox()
        Me.lblHargaTiketSatuan = New System.Windows.Forms.Label()
        Me.cboMatch = New System.Windows.Forms.ComboBox()
        Me.cboTribune = New System.Windows.Forms.ComboBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSeatLeft = New System.Windows.Forms.Label()
        Me.txtMatch = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 108)
        Me.Panel1.TabIndex = 55
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
        Me.Label11.Location = New System.Drawing.Point(203, 43)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(207, 37)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "BUY TICKET"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "EMP ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Match"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Tribune"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Gate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 441)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Total Price"
        '
        'txtEmpId
        '
        Me.txtEmpId.Location = New System.Drawing.Point(109, 131)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpId.TabIndex = 64
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(109, 232)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 66
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(109, 274)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTime.TabIndex = 67
        '
        'txtGate
        '
        Me.txtGate.Location = New System.Drawing.Point(109, 354)
        Me.txtGate.Name = "txtGate"
        Me.txtGate.Size = New System.Drawing.Size(100, 20)
        Me.txtGate.TabIndex = 69
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(109, 397)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 70
        '
        'txtTotPrice
        '
        Me.txtTotPrice.Location = New System.Drawing.Point(109, 438)
        Me.txtTotPrice.Name = "txtTotPrice"
        Me.txtTotPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtTotPrice.TabIndex = 71
        '
        'lblHargaTiketSatuan
        '
        Me.lblHargaTiketSatuan.AutoSize = True
        Me.lblHargaTiketSatuan.Location = New System.Drawing.Point(248, 317)
        Me.lblHargaTiketSatuan.Name = "lblHargaTiketSatuan"
        Me.lblHargaTiketSatuan.Size = New System.Drawing.Size(21, 13)
        Me.lblHargaTiketSatuan.TabIndex = 72
        Me.lblHargaTiketSatuan.Text = "Rp"
        '
        'cboMatch
        '
        Me.cboMatch.FormattingEnabled = True
        Me.cboMatch.Location = New System.Drawing.Point(109, 169)
        Me.cboMatch.Name = "cboMatch"
        Me.cboMatch.Size = New System.Drawing.Size(121, 21)
        Me.cboMatch.TabIndex = 73
        '
        'cboTribune
        '
        Me.cboTribune.FormattingEnabled = True
        Me.cboTribune.Location = New System.Drawing.Point(109, 314)
        Me.cboTribune.Name = "cboTribune"
        Me.cboTribune.Size = New System.Drawing.Size(121, 21)
        Me.cboTribune.TabIndex = 74
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(232, 395)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 75
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(419, 376)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(122, 61)
        Me.btnBuy.TabIndex = 76
        Me.btnBuy.Text = "Buy"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(416, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Seat Left"
        '
        'lblSeatLeft
        '
        Me.lblSeatLeft.AutoSize = True
        Me.lblSeatLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatLeft.Location = New System.Drawing.Point(472, 157)
        Me.lblSeatLeft.Name = "lblSeatLeft"
        Me.lblSeatLeft.Size = New System.Drawing.Size(69, 37)
        Me.lblSeatLeft.TabIndex = 78
        Me.lblSeatLeft.Text = "100"
        '
        'txtMatch
        '
        Me.txtMatch.Location = New System.Drawing.Point(109, 196)
        Me.txtMatch.Name = "txtMatch"
        Me.txtMatch.Size = New System.Drawing.Size(198, 20)
        Me.txtMatch.TabIndex = 79
        '
        'BuyTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 470)
        Me.Controls.Add(Me.txtMatch)
        Me.Controls.Add(Me.lblSeatLeft)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.cboTribune)
        Me.Controls.Add(Me.cboMatch)
        Me.Controls.Add(Me.lblHargaTiketSatuan)
        Me.Controls.Add(Me.txtTotPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtGate)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtDate)
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
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtGate As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtTotPrice As TextBox
    Friend WithEvents lblHargaTiketSatuan As Label
    Friend WithEvents cboMatch As ComboBox
    Friend WithEvents cboTribune As ComboBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnBuy As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSeatLeft As Label
    Friend WithEvents txtMatch As TextBox
End Class
