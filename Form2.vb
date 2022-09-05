Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x1, y1, x2, y2 As Integer
        x1 = SystemInformation.PrimaryMonitorSize.Width
        y1 = SystemInformation.PrimaryMonitorSize.Height
        x2 = x1 / 5
        y2 = y1 / 3
        Me.Size = New System.Drawing.Size(x2, y2)
        Me.Location = New System.Drawing.Point(x1 / 10 * 3, y1 / 6)
        Button1.Location = New System.Drawing.Point(x2 / 3, (y2 / 8) * 5)
        Button1.Size = New System.Drawing.Size(x2 / 3, y2 / 8)
        Button2.Location = New System.Drawing.Point(x2 / 3, y2 / 8)
        Button2.Size = New System.Drawing.Size(x2 / 3, y2 / 8)
    End Sub
End Class