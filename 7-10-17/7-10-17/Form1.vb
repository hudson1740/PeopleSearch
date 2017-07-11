Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        MsgBox("Brett Hudson
Brett Tech Networking 
Powerd By Pipl.Com (People Search Engine)")
    End Sub

    Private Sub FacebookButton1_Click(sender As Object, e As EventArgs) Handles FacebookButton1.Click
        WebBrowser1.Visible = True
        WebBrowser1.Navigate("https://pipl.com/search/?q=" & TextBox1.Text & "+" & TextBox2.Text)
        Label5.Text = "Results For: " & TextBox1.Text & " " & TextBox2.Text
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = FacebookButton1
    End Sub
End Class
