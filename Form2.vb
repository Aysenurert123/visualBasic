Public Class Form2
    Dim ivme
    Dim yuk
    Dim karekok


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

    Private Sub Soru3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Soru3ToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ivme = 9.8
        yuk = 2 * TrackBar1.Value
        karekok = Math.Sqrt(yuk / ivme)
        Label1.Text = karekok


    End Sub
    Private Sub KapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem.Click
        End
    End Sub


End Class