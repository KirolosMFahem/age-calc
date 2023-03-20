Public Class Form1

    Private Sub btnCalculateAge_Click(sender As Object, e As EventArgs) Handles btnCalculateAge.Click
        Dim birthDate As DateTime = birthDate.Value
        Dim currentDate As DateTime = currentDate.Value

        Dim age As TimeSpan = currentDate.Subtract(birthDate)

        Dim ageYears As Integer = age.Days \ 365
        age = age - TimeSpan.FromDays(ageYears * 365)

        Dim ageMonths As Integer = age.Days \ 30
        age = age - TimeSpan.FromDays(ageMonths * 30)

        Dim ageDays As Integer = age.Days

        MessageBox.Show($"Age: {ageYears} years, {ageMonths} months, {ageDays} days")
    End Sub


End Class
