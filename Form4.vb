Public Class Form4
    Dim secenekler As List(Of Integer) = New List(Of Integer)()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()

        For index = 1 To 9
tryAgain:
            Dim Secenek As Integer = CInt(Int((9 * Rnd()) + 1))
            If (secenekler.Contains(Secenek)) Then
                GoTo tryAgain
            Else
                secenekler.Add(Secenek)
            End If
        Next
        lblSayi1.Text = secenekler(0)
        lblSayi2.Text = secenekler(1)
        lblSayi3.Text = secenekler(2)
        lblSayi4.Text = secenekler(3)
        lblSayi5.Text = secenekler(4)
        lblSayi6.Text = secenekler(5)
        lblSayi7.Text = secenekler(6)
        lblSayi8.Text = secenekler(7)
        lblSayi9.Text = secenekler(8)

        secenekler.Clear()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblSayi9_Click(sender As Object, e As EventArgs) Handles lblSayi9.Click

    End Sub

    Private Sub lblSayi6_Click(sender As Object, e As EventArgs) Handles lblSayi6.Click

    End Sub

    Private Sub lblSayi8_Click(sender As Object, e As EventArgs) Handles lblSayi8.Click

    End Sub

    Private Sub lblSayi7_Click(sender As Object, e As EventArgs) Handles lblSayi7.Click

    End Sub

    Private Sub lblSayi5_Click(sender As Object, e As EventArgs) Handles lblSayi5.Click

    End Sub

    Private Sub lblSayi4_Click(sender As Object, e As EventArgs) Handles lblSayi4.Click

    End Sub

    Private Sub lblSayi3_Click(sender As Object, e As EventArgs) Handles lblSayi3.Click

    End Sub

    Private Sub lblSayi2_Click(sender As Object, e As EventArgs) Handles lblSayi2.Click

    End Sub

    Private Sub lblSayi1_Click(sender As Object, e As EventArgs) Handles lblSayi1.Click

    End Sub

    Private Sub Soru1ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Soru1ToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub Soru2ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Soru2ToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Soru3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Soru3ToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Soru5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Soru5ToolStripMenuItem.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub KapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem.Click
        End
    End Sub
End Class
