Module Module1

    Dim Queue(0 To 20) As Integer
    Dim HP = -1
    Dim TP = 0


    Sub Main()

        Dim Status As Boolean
        Status = True

        For x = 1 To 20
            Status = Enqueue(x)
            If Status = False Then
                Console.WriteLine("Unsuccessful")
            End If
        Next
        If Status = True Then
            Console.WriteLine("Successful")
        End If
        Console.WriteLine("Iterative Output is:" & IterativeOutput(20))
        Console.ReadLine()
    End Sub



    Function Enqueue(num As Integer) As Boolean

        If TP = 101 Then
            Console.WriteLine("The Queue is Full")
            Return False
        Else
            Queue(TP) = num
            If HP = -1 Then
                HP = TP
            End If
            TP = TP + 1
            Return True
        End If
    End Function

    Function IterativeOutput(ByVal Start As Integer) As Integer

        Dim Total As Integer
        Dim x As Integer
        Total = 0
        x = 1

        If Start < 1 Then
            Return queue(Start)
        Else
            x = IterativeOutput(Start - 1)
            Total = queue(Start) + x
            Return Total
        End If

    End Function


End Module
