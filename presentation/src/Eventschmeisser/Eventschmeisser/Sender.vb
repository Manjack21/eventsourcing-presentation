Public Class Sender
    Public Event MeinEvent(sender As Object, Args As EventArgs)

    Public Sub StartMeinEvent()
        RaiseEvent MeinEvent(Me, New EventArgs)
    End Sub
End Class
