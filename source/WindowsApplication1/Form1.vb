Imports System.Net
Public Structure MoveForm
    Dim X As Integer
    Dim y As Integer
End Structure
Public Class Form1
    Dim move As MoveForm
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        move.X = Me.Left - MousePosition.X
        move.y = Me.Top - MousePosition.Y
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = move.X + MousePosition.X
        Me.Top = move.y + MousePosition.Y
    End Sub
    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label8.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        move.X = Me.Left - MousePosition.X
        move.y = Me.Top - MousePosition.Y
    End Sub
    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label8.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = move.X + MousePosition.X
        Me.Top = move.y + MousePosition.Y
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = Me.TextBox1.Text.Replace("http://", "").Replace("https://", "").Replace("ftp://", "").Replace("/", "")
        Try
            Label6.ForeColor = Color.Gray
            Dim hostname As IPHostEntry = Dns.GetHostByName(TextBox1.Text)
            Dim ip As IPAddress() = hostname.AddressList
            Label6.Text = ip(0).ToString()

            If My.Computer.Network.Ping(TextBox1.Text) Then
                Console.Beep()
                MsgBox("Online!", MsgBoxStyle.OkOnly, "Status")

            Else
                MsgBox("Offline!", MsgBoxStyle.OkOnly, "Status")
            End If

        Catch ex As Exception
            Label6.ForeColor = Color.Maroon
            Label6.Text = "ERRO!"

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Copiado :D", vbInformation, "Sucesso!")
        Clipboard.SetText(Label6.Text)
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Exemplo.net" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Exemplo.net"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        If TextBox1.TextLength = 0 Then
            Button1.Enabled = False
            Button2.Enabled = False
        Else
            Button1.Enabled = True
            Button2.Enabled = True
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        PictureBox4.Image = My.Resources.Fechar2
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.Fechar
    End Sub

    Private Sub PictureBox4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseMove
        PictureBox4.Image = My.Resources.Fechar2
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label8.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://supreme.tipotuff.com/")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = Clipboard.GetText

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As Object, ByVal e As EventArgs)
        Process.Start("http://www.tipotuff.com/")
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://supreme.tipotuff.com/p/contato.html")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim alcance As String = -100
        Dim voltar As String = 450
        Dim correr As String = 1

        TextBox2.Top -= correr
        If TextBox2.Top <= alcance Then
            TextBox2.Top = voltar
        End If
        TextBox3.Top -= correr
        If TextBox3.Top <= alcance Then
            TextBox3.Top = voltar
        End If
        TextBox7.Top -= correr
        If TextBox7.Top <= alcance Then
            TextBox7.Top = voltar
        End If
        LinkLabel1.Top -= correr
        If LinkLabel1.Top <= alcance Then
            LinkLabel1.Top = voltar
        End If
        TextBox5.Top -= correr
        If TextBox5.Top <= alcance Then
            TextBox5.Top = voltar
        End If
        TextBox4.Top -= correr
        If TextBox4.Top <= alcance Then
            TextBox4.Top = voltar
        End If
        TextBox6.Top -= correr
        If TextBox6.Top <= alcance Then
            TextBox6.Top = voltar
        End If
        TextBox9.Top -= correr
        If TextBox9.Top <= alcance Then
            TextBox9.Top = voltar
        End If
        TextBox11.Top -= correr
        If TextBox11.Top <= alcance Then
            TextBox11.Top = voltar
        End If

    End Sub


    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.Control And e.Shift And e.KeyCode.C Then
            Try
                System.IO.File.WriteAllBytes("NAudio.dll", My.Resources.NAudio)
            Catch

            End Try
            Egg.Show()
        End If
    End Sub
End Class