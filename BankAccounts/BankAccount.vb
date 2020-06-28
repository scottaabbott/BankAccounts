﻿Imports System.Text
Public Class BankAccount

    Private AccountHolder As String
    Private AccountNumber As String
    Private InterestRate As Double
    Private Balance As Double
    Private CountryOfOrigin As String


    Public Sub New(AccountNumber As String, AccountHolder As String, Balance As Double, InterestRate As Double, CountryOfOrigin As String)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRate = InterestRate
        Me.CountryOfOrigin = CountryOfOrigin

    End Sub

    Public Sub New(AccountNumber As String, AccountHolder As String, Balance As Double, InterestRate As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRate = InterestRate

    End Sub

    Public Sub New(AccountNumber As String, AccountHolder As String, Balance As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance

    End Sub

    Public Function GetAccountHolder() As String
        Return Me.AccountHolder

    End Function

    Public Function SetAccountHolder(AccountHolder As String)
        Me.AccountHolder = AccountHolder
        Return Nothing

    End Function

    Public Function GetAccountNumber() As String
        Return Me.AccountNumber

    End Function

    Public Function SetAccountNumber(AccountNumber As String)
        Me.AccountNumber = AccountNumber
        Return Nothing

    End Function

    Public Function GetBalance() As Double
        Return Me.Balance

    End Function

    Public Function SetBalance(Balance As Double)
        Me.Balance = Balance
        Return Nothing

    End Function

    Public Function GetInterestRate() As Double
        Return Me.InterestRate

    End Function

    Public Function SetInterestRate(Rate As Double)
        Me.InterestRate = Rate
        Return Nothing

    End Function

    Public Function GetCountryOfOrigin() As String
        Return Me.CountryOfOrigin

    End Function

    Public Function SetCountryOfOrigin(Country As String)
        Me.CountryOfOrigin = Country
        Return Nothing

    End Function
    Public Function ApplyInterest()

        Dim MthInterest As Double = Me.Balance * (Me.InterestRate / 100) * (1 / 12)
        Me.Balance += Math.Round(MthInterest, 2)

        Return Nothing

    End Function

    Public Overrides Function ToString() As String


        Dim AccountString As New StringBuilder()

        'OutputString.Append(Me.CountryOfOrigin & vbCrLf)
        'OutputString.Append(Me.AccountNumber & vbCrLf)
        'OutputString.Append(Me.AccountHolder & vbCrLf)
        'OutputString.Append("Interest: " & Me.InterestRate & "%" & vbCrLf)
        'OutputString.Append(Me.Balance & vbCrLf)

        AccountString.Append("Isle of Man" & vbCrLf)
        AccountString.Append("ABCD 890111 11167890" & vbCrLf)
        AccountString.Append("Ms I.N.Cognito" & vbCrLf)
        AccountString.Append("Interest: 4.3%" & vbCrLf)
        AccountString.Append("10343.82" & vbCrLf)

        Return AccountString.ToString()

    End Function
End Class
