Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = " "
        If RadioButton1.Checked Then Label1.Text = Label1.Text + " Maske=> "
        If RadioButton2.Checked Then Label1.Text = Label1.Text + " Sosyal Mesafe=> "
        If RadioButton3.Checked Then Label1.Text = Label1.Text + " Hijyen=> "

        If RadioButton1.Checked Then
            Label1.Text = RadioButton1.Text + ComboBox1.Text

        End If
        If RadioButton2.Checked Then
            Label1.Text = RadioButton2.Text + ComboBox2.Text


        End If
        If RadioButton3.Checked Then
            Label1.Text = RadioButton3.Text + ComboBox3.Text

        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ComboBox1.Visible = True
            ComboBox2.Visible = False
            ComboBox3.Visible = False


        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox2.Visible = True
            ComboBox1.Visible = False
            ComboBox3.Visible = False

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            ComboBox3.Visible = True
            ComboBox1.Visible = False
            ComboBox2.Visible = False


        End If
    End Sub


    Private Sub Soru2ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Soru2ToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Soru3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Soru3ToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Soru4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Soru4ToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Soru5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Soru5ToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub KapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem.Click
        End
    End Sub
End Class
