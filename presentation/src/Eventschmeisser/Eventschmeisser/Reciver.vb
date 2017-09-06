Public Class Reciver
    Private WithEvents sender As Sender
    Public Sub New(sender As Sender)
        Me.sender = sender
    End Sub

    Private Sub sender_MeinEvent(sender As Object, Args As EventArgs) Handles sender.MeinEvent
        Console.WriteLine("Starting Eventhandler")
        System.Threading.Thread.Sleep(2500)
        Console.WriteLine("Stoping Eventhandler")
    End Sub
End Class
