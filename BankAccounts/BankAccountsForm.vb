Public Class BankAccountsForm
    ' Class variable declarations go here
    Private Accounts(4) As BankAccount
    Private NumAccounts As Integer

    ' Class method definitions go here (Constructors / Getters / Setters)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.NumAccounts = 0

    End Sub
    Public Function CreateAccount()

        ' get text from from each textbox on the form so can use to create new bank account object
        Dim AccountHolder As String = txtAccountHolder.Text
        Dim AccountNumber As String = txtAccountNumber.Text
        Dim Balance As Double = CDbl(txtBalance.Text)
        Dim InterestRate As Double = CDbl(txtInterestRate.Text)
        Dim Country As String = txtCountry.Text

        ' create a new bank account object using the values of the form fields
        Dim NewAccount = New BankAccount(AccountNumber, AccountHolder, Balance, InterestRate, Country)
        ' assign the new account to the next spot in the Accounts List (array)
        Me.Accounts(Me.NumAccounts) = NewAccount

        ' should increment NumAccounts?
        Return Nothing

    End Function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Public Function SetTextForTesting(AccountNumber As String, AccountHolder As String, Balance As String, InterestRate As String, CountryOfOrigin As String)
        txtAccountHolder.Text = AccountHolder
        txtAccountNumber.Text = AccountNumber
        txtBalance.Text = Balance
        txtInterestRate.Text = InterestRate
        txtCountry.Text = CountryOfOrigin

        Return Nothing

    End Function

    Private Sub btnAddInterest_Click(sender As Object, e As EventArgs) Handles btnAddInterest.Click
        SetTextForTesting("One", "Two", "Three", "Four", "Five")

    End Sub

    Public Function GetAccounts() As BankAccount()
        Return Me.Accounts
    End Function

End Class