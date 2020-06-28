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