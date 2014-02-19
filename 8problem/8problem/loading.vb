Imports System.IO
Public Class loading

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("mysound.wav", AudioPlayMode.BackgroundLoop)
        Timer1.Start()
        Do
            ProgressBar1.Increment(1)
        Loop Until ProgressBar1.Value = ProgressBar1.Maximum


        Timer1.Stop()
        Me.Hide()
    End Sub
End Class