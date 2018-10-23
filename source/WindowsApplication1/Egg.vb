Imports NAudio.Wave
Public Class Egg

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.1
    End Sub
    Dim waveOutDevice = New WaveOut()
    Private Sub Egg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            waveOutDevice.Stop()
        End If
    End Sub

    Private Sub Egg_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


        Try
            System.IO.File.WriteAllBytes("x.mp3", My.Resources.x)
        Catch

        End Try

        Dim musica As AudioFileReader = New AudioFileReader("x.mp3")
        waveOutDevice.Init(musica)
        waveOutDevice.Play()
    End Sub
End Class