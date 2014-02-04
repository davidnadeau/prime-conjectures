Public Class Form1

    Private Sub generatePairs_Click(sender As Object, e As EventArgs) Handles generatePairs.Click
        Dim input As Integer = pairLimit.Text
        twinPrimeList.Text = String.Join(",", TwinPrimes.getTwinPairs(input).ToArray)
    End Sub


    Private Sub generateExceptions_Click(sender As Object, e As EventArgs) Handles generateExceptions.Click
        Dim input As Integer = rangeLimit.Text
        redmondSunExceptions.Text = String.Join(",", RedmondSun.getExceptions(input).ToArray)
    End Sub
End Class
