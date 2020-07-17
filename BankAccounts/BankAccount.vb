Imports System.Text
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

    Public Function GetSeparator() As String

        'Dim AttributeSeparator As String = vbCrLf
        Dim AttributeSeparator As String = " - "

        Return AttributeSeparator

    End Function

    Public Overrides Function ToString() As String

        Dim AccountString As New StringBuilder()

        AccountString.Append(Me.CountryOfOrigin & Me.GetSeparator)
        AccountString.Append(Me.AccountHolder & Me.GetSeparator)
        AccountString.Append(Me.AccountNumber & Me.GetSeparator)
        AccountString.Append("Interest: " & Me.InterestRate.ToString() & "%" & Me.GetSeparator)
        AccountString.Append(Me.Balance.ToString() & Me.GetSeparator)

        'AccountString.Append("Isle of Man" & vbCrLf)
        'AccountString.Append("ABCD 890111 11167890" & vbCrLf) 
        'AccountString.Append("Ms I.N.Cognito" & vbCrLf)
        'AccountString.Append("Interest: 4.3%" & vbCrLf)
        'AccountString.Append("10343.82" & vbCrLf)

        Return AccountString.ToString()

    End Function

    Public Function Deposit(Amount As Double) As Double

        Me.Balance += Amount

        Return Me.Balance

    End Function

    Public Function Withdrawl(Amount As Double) As Double

        ' check if amount requested for withdrawl is > the account balance
        If Amount > Me.Balance Then
            Throw New Exception("Insufficient Funds")
        End If

        ' this line only runs if no exception thrown (sufficient funds)
        Me.Balance -= Amount

        Return Me.Balance

    End Function
End Class
