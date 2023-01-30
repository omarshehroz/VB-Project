Module Module1
    Dim CardData() = {11, 12, 25, 33, 52, 56, 57, 59, 85, 91}

    Sub Main()
        Dim valtosrch As Integer
        Console.Write(" Enter value to search ")
        valtosrch = Console.ReadLine()
        BinaryS(valtosrch)
        Console.ReadKey()
    End Sub
    

    Sub BinaryS(ByVal value As Integer)
        Dim middle, curpos, LB, UB As Integer
        Dim isFound As Boolean = False
        LB = 0
        UB = 8
        While UB >= LB And isFound = False
            middle = (LB + UB) \ 2
            If CardData(middle) = value Then
                isFound = True
                curpos = middle

            ElseIf value < CardData(middle) Then
                UB = middle - 1

            Else
                LB = middle + 1

            End If

        End While
        If isFound = True Then
            Console.WriteLine("The Position is " & middle)
        Else
            Console.WriteLine("The Value NOT found")
        End If
    End Sub

End Module
