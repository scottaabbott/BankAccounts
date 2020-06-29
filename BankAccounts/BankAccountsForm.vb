﻿Imports System.Text
Public Class BankAccountsForm
    ' Class variable declarations go here
    Private MaxAccounts As Integer = 4
    Private Accounts(MaxAccounts) As BankAccount
    Private NumAccounts As Integer


    ' Class method definitions go here (Constructors / Getters / Setters)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.NumAccounts = 0

    End Sub
    Public Function CreateAccount()

        ' Guard Clauses
        If txtAccountHolder.Text = "" Then Throw New Exception("AccountHolderRequiredException")
        If txtAccountNumber.Text = "" Then Throw New Exception("AccountNumberRequiredException")
        If txtInterestRate.Text = "" Then Throw New Exception("InterestRateRequiredException")
        If txtBalance.Text = "" Then Throw New Exception("BalanceRequiredException")
        If txtCountry.Text = "" Then Throw New Exception("CountryOfOriginRequiredException")
        If NumAccounts = MaxAccounts Then Throw New Exception("MaximumAccountsReachedException")

        ' get text from from each textbox on the form so can use to create new bank account object
        ' need to run after guard clauses - else get conversion errors on double type fields
        Dim AccountHolder As String = txtAccountHolder.Text
        Dim AccountNumber As String = txtAccountNumber.Text
        Dim Balance As Double = CDbl(txtBalance.Text)
        Dim InterestRate As Double = CDbl(txtInterestRate.Text)
        Dim Country As String = txtCountry.Text

        ' create a new bank account object using the values of the form fields
        Dim NewAccount = New BankAccount(AccountNumber, AccountHolder, Balance, InterestRate, Country)
        ' assign the new account to the next spot in the Accounts List (array)
        Me.Accounts(Me.NumAccounts) = NewAccount
        ' increment number counter
        Me.NumAccounts += 1

        ' clear textboxes after add account
        txtAccountHolder.Clear()
        txtAccountNumber.Clear()
        txtInterestRate.Clear()
        txtBalance.Clear()
        txtCountry.Clear()


        Return Nothing

    End Function

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        ' Housekeeping
        Dim Feedback As String = "Account added."
        Dim Title As String = "Success"

        Try
            Me.CreateAccount()

        Catch Ex As Exception
            Title = Ex.Message()

            Select Case Ex.Message

                Case "AccountHolderRequiredException"
                    Feedback = "Please enter an account holder name."
                    txtAccountHolder.Focus()

                Case "AccountNumberRequiredException"
                    Feedback = "Please enter an account number."
                    txtAccountNumber.Focus()

                Case "InterestRateRequiredException"
                    Feedback = "Please enter an interest rate."
                    txtInterestRate.Focus()

                Case "BalanceRequiredException"
                    Feedback = "Please enter a balance."
                    txtBalance.Focus()

                Case "CountryOfOriginRequiredException"
                    Feedback = "Please enter a country of origin."
                    txtCountry.Focus()

                Case "MaximumAccountsReachedException"
                    Feedback = "You have reached the maximum number of accounts."

                Case Else
                    Title = "An error occurred."
                    Feedback = Ex.Message

            End Select


        End Try

        MsgBox(Feedback, vbOKOnly, Title)

    End Sub

    Private Sub btnPrintAccounts_Click(sender As Object, e As EventArgs) Handles btnPrintAccounts.Click
        Dim AllAccounts As New StringBuilder()

        For Each BA As BankAccount In Me.Accounts

            ' exit if no accounts as if try & print, will crash
            If BA Is Nothing Then Exit For

            AllAccounts.Append(BA.ToString())
            AllAccounts.Append(vbCrLf)

        Next

        txtListAccount.Text = AllAccounts.ToString()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnAddInterest_Click(sender As Object, e As EventArgs) Handles btnAddInterest.Click
        SetTextForTesting("One", "Two", "Three", "Four", "Five")

    End Sub

    Public Function SetTextForTesting(AccountHolder As String, AccountNumber As String, Balance As String, InterestRate As String, CountryOfOrigin As String)
        txtAccountHolder.Text = AccountHolder
        txtAccountNumber.Text = AccountNumber
        txtBalance.Text = Balance
        txtInterestRate.Text = InterestRate
        txtCountry.Text = CountryOfOrigin

        Return Nothing

    End Function

    Public Function GetAccounts() As BankAccount()
        Return Me.Accounts
    End Function

End Class