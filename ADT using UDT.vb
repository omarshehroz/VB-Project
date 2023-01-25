Module Module1
    Structure Node
        Dim Pointer As Integer
        Dim Data As String
    End Structure
    'Global Declarations
    Dim Stack(0 To 9) As Node
    Dim FreePointer As Integer
    Dim TopofStackPointer As Integer
    Dim TempPointer As Integer

    Sub Main()
        For x = 0 To 9
            Stack(x).Data = ""
            Stack(x).Pointer = x + 1
        Next
        Stack(9).Pointer = -1
        FreePointer = 0
        TopofStackPointer = -1
        Push("Omar")
        Push("Ahmed")
        Push("Bandashah")
    End Sub

    Sub Push(Name As String)
        If FreePointer = -1 Then
            Console.WriteLine("Stack is Full")
        Else
            Stack(FreePointer).Data = Name
            TempPointer = FreePointer
            FreePointer = Stack(TempPointer).Pointer
            Stack(TempPointer).Pointer = TopofStackPointer
            TopofStackPointer = TempPointer

        End If
    End Sub
End Module
