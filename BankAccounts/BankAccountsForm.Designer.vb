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
        Me.btnDeleteAccount = New System.Windows.Forms.Button()
        Me.hdrAccountList = New System.Windows.Forms.Label()
        Me.lsvAccountList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbxAccountList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(406, 355)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 61)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAccountHolder
        '
        Me.txtAccountHolder.Location = New System.Drawing.Point(25, 39)
        Me.txtAccountHolder.Name = "txtAccountHolder"
        Me.txtAccountHolder.Size = New System.Drawing.Size(219, 20)
        Me.txtAccountHolder.TabIndex = 0
        '
        'lblAccountHolder
        '
        Me.lblAccountHolder.AutoSize = True
        Me.lblAccountHolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountHolder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAccountHolder.Location = New System.Drawing.Point(23, 19)
        Me.lblAccountHolder.Name = "lblAccountHolder"
        Me.lblAccountHolder.Size = New System.Drawing.Size(115, 13)
        Me.lblAccountHolder.TabIndex = 0
        Me.lblAccountHolder.Text = "Account Holder Name:"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(25, 97)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(219, 20)
        Me.txtAccountNumber.TabIndex = 1
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
        Me.txtBalance.TabIndex = 3
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
        Me.txtInterestRate.TabIndex = 2
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
        Me.txtCountry.TabIndex = 4
        '
        'btnPrintAccounts
        '
        Me.btnPrintAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintAccounts.Location = New System.Drawing.Point(25, 355)
        Me.btnPrintAccounts.Name = "btnPrintAccounts"
        Me.btnPrintAccounts.Size = New System.Drawing.Size(100, 61)
        Me.btnPrintAccounts.TabIndex = 5
        Me.btnPrintAccounts.Text = "Print Accounts"
        Me.btnPrintAccounts.UseVisualStyleBackColor = True
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAccount.Location = New System.Drawing.Point(155, 355)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(89, 61)
        Me.btnAddAccount.TabIndex = 7
        Me.btnAddAccount.Text = "Add Account"
        Me.btnAddAccount.UseVisualStyleBackColor = True
        '
        'btnDeleteAccount
        '
        Me.btnDeleteAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAccount.Location = New System.Drawing.Point(283, 355)
        Me.btnDeleteAccount.Name = "btnDeleteAccount"
        Me.btnDeleteAccount.Size = New System.Drawing.Size(93, 61)
        Me.btnDeleteAccount.TabIndex = 6
        Me.btnDeleteAccount.Text = "Delete Account"
        Me.btnDeleteAccount.UseVisualStyleBackColor = True
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
        'lsvAccountList
        '
        Me.lsvAccountList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvAccountList.GridLines = True
        Me.lsvAccountList.HideSelection = False
        Me.lsvAccountList.Location = New System.Drawing.Point(537, 29)
        Me.lsvAccountList.Name = "lsvAccountList"
        Me.lsvAccountList.Size = New System.Drawing.Size(305, 273)
        Me.lsvAccountList.TabIndex = 16
        Me.lsvAccountList.UseCompatibleStateImageBehavior = False
        Me.lsvAccountList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Holder"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Number"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Interest Rate"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Balance"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Country of Origin"
        '
        'lbxAccountList
        '
        Me.lbxAccountList.FormattingEnabled = True
        Me.lbxAccountList.Items.AddRange(New Object() {"AH1  AC1  1.1  111  NZ", "AH2  AC2  2.2 222  GB", "AH3  AC3  3.3 333  UK", "AH4  AC4  4.4 444  SA", "AH5  AC5  5.5 555  AU"})
        Me.lbxAccountList.Location = New System.Drawing.Point(273, 29)
        Me.lbxAccountList.Name = "lbxAccountList"
        Me.lbxAccountList.Size = New System.Drawing.Size(228, 277)
        Me.lbxAccountList.TabIndex = 17
        '
        'BankAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 450)
        Me.Controls.Add(Me.lbxAccountList)
        Me.Controls.Add(Me.lsvAccountList)
        Me.Controls.Add(Me.hdrAccountList)
        Me.Controls.Add(Me.btnDeleteAccount)
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
    Friend WithEvents btnDeleteAccount As Button
    Friend WithEvents hdrAccountList As Label
    Friend WithEvents lsvAccountList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents lbxAccountList As ListBox
End Class
