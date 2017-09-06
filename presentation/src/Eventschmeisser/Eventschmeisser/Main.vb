Module Main

    Sub Main()
        Dim s As New Sender
        Dim r1 As New Reciver(s)
        Dim r2 As New Reciver(s)

        s.StartMeinEvent()
        s.StartMeinEvent()
        Console.ReadKey()
    End Sub

End Module
