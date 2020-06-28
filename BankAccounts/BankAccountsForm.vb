Public Class BankAccountsForm
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
End Class