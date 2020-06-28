Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestConstructors()

        ' Arrange - setup variables for testing
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle Of Man"

        ' Act - perform the test

        Dim Account1 As New BankAccounts.BankAccount(AccountNumber, AccountHolder, Balance, InterestRate, CountryOfOrigin)
        Dim Account2 As New BankAccounts.BankAccount(AccountNumber, AccountHolder, Balance, InterestRate)
        Dim Account3 As New BankAccounts.BankAccount(AccountNumber, AccountHolder, Balance)

        ' Assert - check if the test failed
        Assert.IsNotNull(Account1)
        Assert.IsNotNull(Account2)
        Assert.IsNotNull(Account3)

    End Sub
    <TestMethod()> Public Sub TestGetAccountHolder()

        ' Arrange - setup test case

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test

        Dim Name As String = Account1.GetAccountHolder()

        ' Assert - check if the test failed
        Assert.AreEqual(Name, "Ms I. N. Cognito")

    End Sub

    <TestMethod()> Public Sub TestSetAccountHolder()

        ' Arrange - setup test case

        Dim NewAcctHolder = "Mr C. U. Later"
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test
        Account1.SetAccountHolder(NewAcctHolder)

        ' Assert - check if the test failed
        Assert.AreEqual(NewAcctHolder, Account1.GetAccountHolder())

    End Sub

    <TestMethod()> Public Sub TestGetAccountNumber()

        ' Arrange - setup test case

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test

        Dim Number As String = Account1.GetAccountNumber()


        ' Assert - check if the test failed
        Assert.AreEqual(Number, "ABCD 890111 11167890")

    End Sub

    <TestMethod()> Public Sub TestSetAccountNumber()

        ' Arrange - setup test case

        Dim NewAcctNumber = "WXYZ 890222 0987654321"
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test
        Account1.SetAccountNumber(NewAcctNumber)

        ' Assert - check if the test failed
        Assert.AreEqual(NewAcctNumber, Account1.GetAccountNumber())

    End Sub

    <TestMethod()> Public Sub TestGetBalance()

        ' Arrange - setup test case

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test

        Dim Balance As Double = Account1.GetBalance()

        ' Assert - check if the test failed
        Assert.AreEqual(Balance, 10343.82)

    End Sub

    <TestMethod()> Public Sub TestSetBalance()

        ' Arrange - setup test case

        Dim NewBalance As Double = 9745.23
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test
        Account1.SetBalance(NewBalance)

        ' Assert - check if the test failed
        Assert.AreEqual(NewBalance, Account1.GetBalance())

    End Sub

    <TestMethod()> Public Sub TestGetInterestRate()

        ' Arrange - setup test case

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test

        Dim InterestRate As Double = Account1.GetInterestRate()

        ' Assert - check if the test failed
        Assert.AreEqual(InterestRate, 4.3)

    End Sub

    <TestMethod()> Public Sub TestSetInterestRate()

        ' Arrange - setup test case

        Dim NewRate As Double = 5.1
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test
        Account1.SetInterestRate(NewRate)

        ' Assert - check if the test failed
        Assert.AreEqual(NewRate, Account1.GetInterestRate())

    End Sub

    <TestMethod()> Public Sub TestGetCountryOfOrigin()

        ' Arrange - setup test case

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test

        Dim CountryOfOrigin As String = Account1.GetCountryOfOrigin()

        ' Assert - check if the test failed
        Assert.AreEqual(CountryOfOrigin, "Isle Of Man")

    End Sub

    <TestMethod()> Public Sub TestSetCountryOfOrigin()

        ' Arrange - setup test case

        Dim NewCountryOfOrigin = "West Namibia"
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test
        Account1.SetCountryOfOrigin(NewCountryOfOrigin)

        ' Assert - check if the test failed
        Assert.AreEqual(NewCountryOfOrigin, Account1.GetCountryOfOrigin())

    End Sub

    Private Function NewAccount() As BankAccounts.BankAccount
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle Of Man"
        Return New BankAccounts.BankAccount(AccountNumber, AccountHolder, Balance, InterestRate, CountryOfOrigin)
    End Function

End Class