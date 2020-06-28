﻿Imports System.Text
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

    <TestMethod()> Public Sub TestGetAccountNumber()

        ' Arrange - setup test case

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test

        Dim Number As String = Account1.GetAccountNumber()


        ' Assert - check if the test failed
        Assert.AreEqual(Number, "ABCD 890111 11167890")

    End Sub

    <TestMethod()> Public Sub TestGetBalance()

        ' Arrange - setup test case

        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act - perform the test

        Dim Balance As Double = Account1.GetBalance()

        ' Assert - check if the test failed
        Assert.AreEqual(Balance, 10343.82)

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