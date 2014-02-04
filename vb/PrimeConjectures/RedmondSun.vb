Public Class RedmondSun

    Private Shared Function primeInRange(ByVal x, ByVal y, ByVal m, ByVal n) As Boolean
        Dim startRange As Long = Math.Pow(x, m)
        Dim endRange As Long = Math.Pow(y, n)

        'only positive ranges are significant
        If startRange >= endRange Then
            Return True
        End If

        'check each value in range, if there is a prime return true
        For i As Long = startRange To endRange
            If Prime.isPrime(i) Then
                Return True
            End If
        Next

        'no prime found in positive range, therefore is range is an exceptional interval
        Return False
    End Function

    Public Shared Function getExceptions(ByVal limit) As ArrayList
        Dim exceptions As ArrayList = New ArrayList
        For x As Integer = 2 To limit
            For y As Integer = 2 To limit
                For m As Integer = 2 To limit
                    For n As Integer = 2 To limit
                        If Not primeInRange(x, y, m, n) Then
                            Dim range As String
                            range = "[" & x & "^" & m & ", " & y & "^" & n & "]"
                            exceptions.Add(range)
                        End If
                    Next
                Next
            Next
        Next
        Return exceptions
    End Function
End Class