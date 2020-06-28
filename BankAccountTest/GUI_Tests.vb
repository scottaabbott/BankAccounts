Imports System.Text
Imports BankAccounts
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class GUI_Tests

    <TestMethod()> Public Sub TestCreateAccount()

        ' Arrange - setup test case

        Dim AccountHolder As String = "Ms I.N.Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = "Isle Of Man"
        Dim BF As New BankAccountsForm()
        BF.SetTextForTesting(AccountNumber, AccountHolder, Balance, InterestRate, CountryOfOrigin)

        ' Act - perform the test

        ' use the information on the Bank Form to create an account
        BF.CreateAccount()
        ' get a copy of the arrays of Bank Accounts on the Bank Account form
        Dim TempAccount() As BankAccount = BF.GetAccounts()

        ' Assert - compare to expected results
        Assert.AreEqual(AccountHolder, TempAccount(0).GetAccountHolder())
        Assert.AreEqual(AccountNumber, TempAccount(0).GetAccountNumber())
        Assert.AreEqual(10343.82, TempAccount(0).GetBalance())
        Assert.AreEqual(4.3, TempAccount(0).GetInterestRate())
        Assert.AreEqual(CountryOfOrigin, TempAccount(0).GetCountryOfOrigin())

    End Sub

End Class