Public Class Form3
    Dim yon = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If yon = 2 Then Button1.Left = Button1.Left - NumericUpDown1.Value
        If yon = 1 Then Button1.Top = Button1.Top - NumericUpDown1.Value
        If yon = 4 Then Button1.Left = Button1.Left + NumericUpDown1.Value
        If yon = 3 Then Button1.Top = Button1.Top + NumericUpDown1.Value


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        yon = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = True
        yon = 2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Enabled = True
        yon = 4
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Enabled = True
        yon = 3
    End Sub

    Private Sub Soru4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Soru4ToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Soru5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Soru5ToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Soru1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Soru1ToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Soru2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Soru2ToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub


    Private Sub KapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem.Click
        End
    End Sub
End Class