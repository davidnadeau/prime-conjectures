Public Class Prime
    ' primality test from wikipedia
    ' https://en.wikipedia.org/wiki/Primality_test#Python_implementation
    Public Shared Function isPrime(ByVal n) As Boolean
        If n < 2 Then
            Return False
        End If
        If n = 2 Then
            Return True
        End If
        If n Mod 2 = 0 Or n Mod 3 = 0 Then
            Return False
        End If

        Dim largestDivisor As Integer = Math.Floor(Math.Sqrt(n))
        For i As Integer = 5 To largestDivisor Step 6
            If n Mod i = 0 Or n Mod (i + 2) = 0 Then
                Return False
            End If
        Next
        Return True
    End Function
End Class