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
        BF.SetTextForTesting(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        ' Act - perform the test

        ' use the information on the Bank Form to create an account
        BF.CreateAccount()
        ' get a copy of the arrays of Bank Accounts on the Bank Account form
        ' ARRAY implementation
        Dim TempAccount() As BankAccount = BF.GetAccounts()
        ' LIST implementation 
        Dim TempAccountList As List(Of BankAccount) = BF.GetAccountsList()


        ' Assert - compare to expected results

        ' ARRAY implementation 
        'Assert.AreEqual(AccountHolder, TempAccount(0).GetAccountHolder())
        'Assert.AreEqual(AccountNumber, TempAccount(0).GetAccountNumber())
        'Assert.AreEqual(10343.82, TempAccount(0).GetBalance())
        'Assert.AreEqual(4.3, TempAccount(0).GetInterestRate())
        'Assert.AreEqual(CountryOfOrigin, TempAccount(0).GetCountryOfOrigin())

        ' LIST implementation

        For Each BA In TempAccountList
            Console.WriteLine(AccountHolder & " - " & BA.GetAccountHolder())
            Assert.AreEqual(AccountHolder, BA.GetAccountHolder())
            Console.WriteLine(AccountNumber & " - " & BA.GetAccountNumber())
            Assert.AreEqual(AccountNumber, BA.GetAccountNumber())
            Assert.AreEqual(10343.82, BA.GetBalance())
            Assert.AreEqual(4.3, BA.GetInterestRate())
            Assert.AreEqual(CountryOfOrigin, BA.GetCountryOfOrigin())
            ' only check the first record in the list
            Exit For
        Next


    End Sub

    <TestMethod()> Public Sub TestEmptyAccountHolder()

        ' Arrange - setup test case

        Dim AccountHolder As String = "" ' simulate user failing to enter account holder
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = "Isle Of Man"
        Dim BF As New BankAccountsForm()
        BF.SetTextForTesting(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        ' Act - perform the test

        Try
            ' use the information on the Bank Form to create an account
            BF.CreateAccount()
            Assert.Fail() ' If this line is executed, the test fails
        Catch Ex As Exception

            ' Assert - compare to expected results
            Assert.AreEqual("AccountHolderRequiredException", Ex.Message)
        End Try


    End Sub

    <TestMethod()> Public Sub TestEmptyAccountNumber()

        ' Arrange - setup test case

        Dim AccountHolder As String = "Ms I.N.Cognito"
        Dim AccountNumber As String = "" 'simulate user failing to enter account number
        Dim InterestRate As String = "4.3"
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = "Isle Of Man"
        Dim BF As New BankAccountsForm()
        BF.SetTextForTesting(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        ' Act - perform the test

        Try
            ' use the information on the Bank Form to create an account
            BF.CreateAccount()
            Assert.Fail() ' If this line is executed, the test fails
        Catch Ex As Exception

            ' Assert - compare to expected results
            Assert.AreEqual("AccountNumberRequiredException", Ex.Message)
        End Try

    End Sub

    <TestMethod()> Public Sub TestEmptyInterestRate()

        ' Arrange - setup test case

        Dim AccountHolder As String = "Ms I.N.Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "" ' simulate empty interest rate field
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = "Isle Of Man"
        Dim BF As New BankAccountsForm()
        BF.SetTextForTesting(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        ' Act - perform the test

        Try
            ' use the information on the Bank Form to create an account
            BF.CreateAccount()
            Assert.Fail() ' If this line is executed, the test fails
        Catch Ex As Exception

            ' Assert - compare to expected results
            Assert.AreEqual("InterestRateRequiredException", Ex.Message)
        End Try

    End Sub

    <TestMethod()> Public Sub TestEmptyBalance()

        ' Arrange - setup test case

        Dim AccountHolder As String = "Ms I.N.Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim Balance As String = "" ' simulate empty balance field
        Dim CountryOfOrigin As String = "Isle Of Man"
        Dim BF As New BankAccountsForm()
        BF.SetTextForTesting(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        ' Act - perform the test

        Try
            ' use the information on the Bank Form to create an account
            BF.CreateAccount()
            Assert.Fail() ' If this line is executed, the test fails
        Catch Ex As Exception

            ' Assert - compare to expected results
            Assert.AreEqual("BalanceRequiredException", Ex.Message)
        End Try

    End Sub


    <TestMethod()> Public Sub TestEmptyCountry()

        ' Arrange - setup test case

        Dim AccountHolder As String = "Ms I.N.Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = "" ' simulate empty country field
        Dim BF As New BankAccountsForm()
        BF.SetTextForTesting(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        ' Act - perform the test

        Try
            ' use the information on the Bank Form to create an account
            BF.CreateAccount()
            Assert.Fail() ' If this line is executed, the test fails
        Catch Ex As Exception

            ' Assert - compare to expected results
            Assert.AreEqual("CountryOfOriginRequiredException", Ex.Message)
        End Try

    End Sub

    <TestMethod()> Public Sub TestAddFiveAccounts()

        ' Arrange - setup test case

        Dim AccountHolder As String = "Ms I.N.Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = "Isle Of Man"

        Dim BF As New BankAccountsForm()

        ' Act - perform the test

        Try

            For counter As Integer = 0 To 4
                BF.SetTextForTesting(counter & "_" & AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)
                BF.CreateAccount()

            Next counter

        Catch Ex As Exception

            Console.WriteLine(Ex.Message)

            Assert.Fail() ' If this line is executed, the test fails
        End Try

        ' Assert - compare to expected results
        ' get all accounts from the form
        Dim TempAccounts() As BankAccount = BF.GetAccounts()

        For Each BA In TempAccounts
            If BA Is Nothing Then Assert.Fail()
        Next

    End Sub

    <TestMethod()> Public Sub TestAddSixAccounts()

        ' Arrange - setup test case

        Dim AccountHolder As String = "Ms I.N.Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = "Isle Of Man"

        Dim BF As New BankAccountsForm()

        ' Act - perform the test

        Try

            For counter As Integer = 0 To 5
                BF.SetTextForTesting(counter & "_" & AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)
                BF.CreateAccount()

            Next counter

            ' Assert
            Assert.Fail()

        Catch Ex As Exception
            ' Assert
            Assert.AreEqual("MaximumAccountsReachedException", Ex.Message)
        End Try

    End Sub
End Class