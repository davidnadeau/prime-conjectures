Public Class TwinPrimes
    Shared currentPrime As Integer = 2
    Shared primeCount As Integer = 2

    Private Shared Function isTwinPrime(ByVal x, ByVal y) As Boolean
        Return y - x = 2
    End Function

    Private Shared Function nextPrime() As Integer
        primeCount += 1
        While Not Prime.isPrime(primeCount)
            primeCount += 1
        End While
        currentPrime = primeCount
        Return currentPrime
    End Function

    Public Shared Function getTwinPairs(ByVal limit) As ArrayList
        Dim twinPairs As ArrayList = New ArrayList
        Dim p1, p2 As Integer

        For i As Integer = 0 To limit - 1
            Do
                p1 = currentPrime
                p2 = nextPrime()
            Loop While (Not isTwinPrime(p1, p2))
            Dim pair As String = "(" & p1 & ", " & p2 & ")"
            twinPairs.Add(pair)
        Next

        currentPrime = 2
        primeCount = 2

        Return twinPairs
    End Function
End Class