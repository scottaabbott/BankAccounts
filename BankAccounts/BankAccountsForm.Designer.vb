<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAccountsForm
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAccountHolder = New System.Windows.Forms.TextBox()
        Me.lblAccountHolder = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.hdrAccountNumber = New System.Windows.Forms.Label()
        Me.hdrBalance = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.hdrInterestRate = New System.Windows.Forms.Label()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.hdrCountryOfOrigin = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.btnPrintAccounts = New System.Windows.Forms.Button()
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.btnAddInterest = New System.Windows.Forms.Button()
        Me.txtListAccount = New System.Windows.Forms.TextBox()
        Me.hdrAccountList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(406, 355)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 61)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAccountHolder
        '
        Me.txtAccountHolder.Location = New System.Drawing.Point(25, 39)
        Me.txtAccountHolder.Name = "txtAccountHolder"
        Me.txtAccountHolder.Size = New System.Drawing.Size(219, 20)
        Me.txtAccountHolder.TabIndex = 1
        '
        'lblAccountHolder
        '
        Me.lblAccountHolder.AutoSize = True
        Me.lblAccountHolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountHolder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAccountHolder.Location = New System.Drawing.Point(23, 19)
        Me.lblAccountHolder.Name = "lblAccountHolder"
        Me.lblAccountHolder.Size = New System.Drawing.Size(115, 13)
        Me.lblAccountHolder.TabIndex = 2
        Me.lblAccountHolder.Text = "Account Holder Name:"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(25, 97)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(219, 20)
        Me.txtAccountNumber.TabIndex = 3
        '
        'hdrAccountNumber
        '
        Me.hdrAccountNumber.AutoSize = True
        Me.hdrAccountNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrAccountNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.hdrAccountNumber.Location = New System.Drawing.Point(26, 81)
        Me.hdrAccountNumber.Name = "hdrAccountNumber"
        Me.hdrAccountNumber.Size = New System.Drawing.Size(90, 13)
        Me.hdrAccountNumber.TabIndex = 4
        Me.hdrAccountNumber.Text = "Account Number:"
        '
        'hdrBalance
        '
        Me.hdrBalance.AutoSize = True
        Me.hdrBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.hdrBalance.Location = New System.Drawing.Point(26, 190)
        Me.hdrBalance.Name = "hdrBalance"
        Me.hdrBalance.Size = New System.Drawing.Size(49, 13)
        Me.hdrBalance.TabIndex = 5
        Me.hdrBalance.Text = "Balance:"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(25, 206)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(219, 20)
        Me.txtBalance.TabIndex = 6
        '
        'hdrInterestRate
        '
        Me.hdrInterestRate.AutoSize = True
        Me.hdrInterestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrInterestRate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.hdrInterestRate.Location = New System.Drawing.Point(26, 132)
        Me.hdrInterestRate.Name = "hdrInterestRate"
        Me.hdrInterestRate.Size = New System.Drawing.Size(71, 13)
        Me.hdrInterestRate.TabIndex = 7
        Me.hdrInterestRate.Text = "Interest Rate:"
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(25, 148)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(219, 20)
        Me.txtInterestRate.TabIndex = 8
        '
        'hdrCountryOfOrigin
        '
        Me.hdrCountryOfOrigin.AutoSize = True
        Me.hdrCountryOfOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrCountryOfOrigin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.hdrCountryOfOrigin.Location = New System.Drawing.Point(23, 252)
        Me.hdrCountryOfOrigin.Name = "hdrCountryOfOrigin"
        Me.hdrCountryOfOrigin.Size = New System.Drawing.Size(90, 13)
        Me.hdrCountryOfOrigin.TabIndex = 9
        Me.hdrCountryOfOrigin.Text = "Country Of Origin:"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(25, 268)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(219, 20)
        Me.txtCountry.TabIndex = 10
        '
        'btnPrintAccounts
        '
        Me.btnPrintAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintAccounts.Location = New System.Drawing.Point(25, 355)
        Me.btnPrintAccounts.Name = "btnPrintAccounts"
        Me.btnPrintAccounts.Size = New System.Drawing.Size(100, 61)
        Me.btnPrintAccounts.TabIndex = 11
        Me.btnPrintAccounts.Text = "Print Accounts"
        Me.btnPrintAccounts.UseVisualStyleBackColor = True
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAccount.Location = New System.Drawing.Point(289, 355)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(89, 61)
        Me.btnAddAccount.TabIndex = 12
        Me.btnAddAccount.Text = "Add Account"
        Me.btnAddAccount.UseVisualStyleBackColor = True
        '
        'btnAddInterest
        '
        Me.btnAddInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddInterest.Location = New System.Drawing.Point(161, 355)
        Me.btnAddInterest.Name = "btnAddInterest"
        Me.btnAddInterest.Size = New System.Drawing.Size(93, 61)
        Me.btnAddInterest.TabIndex = 13
        Me.btnAddInterest.Text = "Add Interest"
        Me.btnAddInterest.UseVisualStyleBackColor = True
        '
        'txtListAccount
        '
        Me.txtListAccount.Location = New System.Drawing.Point(273, 29)
        Me.txtListAccount.Multiline = True
        Me.txtListAccount.Name = "txtListAccount"
        Me.txtListAccount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtListAccount.Size = New System.Drawing.Size(217, 287)
        Me.txtListAccount.TabIndex = 14
        '
        'hdrAccountList
        '
        Me.hdrAccountList.AutoSize = True
        Me.hdrAccountList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrAccountList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.hdrAccountList.Location = New System.Drawing.Point(270, 9)
        Me.hdrAccountList.Name = "hdrAccountList"
        Me.hdrAccountList.Size = New System.Drawing.Size(69, 13)
        Me.hdrAccountList.TabIndex = 15
        Me.hdrAccountList.Text = "Account List:"
        '
        'BankAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 450)
        Me.Controls.Add(Me.hdrAccountList)
        Me.Controls.Add(Me.txtListAccount)
        Me.Controls.Add(Me.btnAddInterest)
        Me.Controls.Add(Me.btnAddAccount)
        Me.Controls.Add(Me.btnPrintAccounts)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.hdrCountryOfOrigin)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.hdrInterestRate)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.hdrBalance)
        Me.Controls.Add(Me.hdrAccountNumber)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.lblAccountHolder)
        Me.Controls.Add(Me.txtAccountHolder)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "BankAccountsForm"
        Me.Text = "Bank Accounts Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents txtAccountHolder As TextBox
    Friend WithEvents lblAccountHolder As Label
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents hdrAccountNumber As Label
    Friend WithEvents hdrBalance As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents hdrInterestRate As Label
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents hdrCountryOfOrigin As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents btnPrintAccounts As Button
    Friend WithEvents btnAddAccount As Button
    Friend WithEvents btnAddInterest As Button
    Friend WithEvents txtListAccount As TextBox
    Friend WithEvents hdrAccountList As Label
End Class
