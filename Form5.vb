Public Class Form5
    Dim secenekler As List(Of Integer) = New List(Of Integer)()

    Dim Sayi1 As Integer
    Dim Sayi2 As Integer
    Dim Sonuc As Integer

    Dim Secenek As Integer


    Dim Yerlesim As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Randomize()


        For Each rb As RadioButton In GroupBox1.Controls.OfType(Of RadioButton)()
            rb.Checked = False
        Next


        Sayi1 = CInt(Int((9 * Rnd()) + 1))
        lblSayi1.Text = Sayi1

        Sayi2 = CInt(Int((9 * Rnd()) + 1))
        lblSayi2.Text = Sayi2

        Sonuc = Sayi1 + Sayi2



        For index = 1 To 3
tryAgain:
            Secenek = CInt(Int((18 * Rnd()) + 1))
            If (secenekler.Contains(Secenek)) Then
                GoTo tryAgain
            Else
                secenekler.Add(Secenek)
            End If
        Next


        rbSecim.Text = secenekler(0).ToString()
        rbSecim2.Text = secenekler(1).ToString()
        rbSecim3.Text = secenekler(2).ToString()


        secenekler.Clear()


        Yerlesim = CInt(Int((3 * Rnd()) + 1))


        If Yerlesim = 1 Then
            rbSecim.Text = Sonuc
        ElseIf Yerlesim = 2 Then
            rbSecim2.Text = Sonuc
        ElseIf Yerlesim = 3 Then
            rbSecim3.Text = Sonuc
        End If


    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each rb As RadioButton In GroupBox1.Controls.OfType(Of RadioButton)()
            rb.Checked = False
        Next
    End Sub


    Private Sub rbSecim_Click(sender As Object, e As EventArgs) Handles rbSecim.Click, rbSecim3.Click, rbSecim2.Click
        Dim rb As RadioButton = CType(sender, RadioButton)


        If rb.Text = Sonuc.ToString() Then
            MessageBox.Show("Bildiniz!")
        Else
            MessageBox.Show("Yanlış seçim!")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

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

    Private Sub Soru4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Soru4ToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub KapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem.Click
        End
    End Sub
End Class