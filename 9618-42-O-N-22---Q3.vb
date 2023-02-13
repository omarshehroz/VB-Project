Module Module1

    Dim Queue(0 To 9) As Integer
    Dim HP = -1
    Dim FP = -1
    Dim TP = 0

    Sub Main()
        Dim QueueRep As Boolean
        QueueRep = enqueue(45)
        QueueRep = enqueue(25)
        Console.ReadLine()
    End Sub



    Function enqueue(ByVal num As Integer) As Boolean

        If FP = -1 Then
            Console.WriteLine("The Queue is Full")
            Return False
        Else
            If HP = -1 Then
                HP = FP
            End If
            TP = FP
            Queue(FP) = num
            FP = FP + 1
            Return True
        End If
    End Function



End Module
