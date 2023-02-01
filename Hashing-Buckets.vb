Module Module1
    Dim studArr(3) As Integer

    Sub Main()
        Dim StudentName, x As Integer
        StudentName = 79776582
        Call InsertHash(StudentName)
        StudentName = 83726572
        Call InsertHash(StudentName)
        StudentName = 79776579
        Call InsertHash(StudentName)
        StudentName = 79776583
        Call InsertHash(StudentName)
        StudentName = 79776582
        Call InsertHash(StudentName)
        StudentName = 79776589



        
        Console.Write("Enter Search Record Key :") : StudentName = Console.ReadLine
        x = SearchHash(StudentName)
        If x = 0 Then
            Console.WriteLine("Not Found")
        Else
            Console.WriteLine("Found")
        End If
        Console.ReadKey()
        For x = 0 To 3
            Console.WriteLine(studArr(x))
        Next
        Console.ReadKey()
    End Sub

    Sub InsertHash(ByVal Name As Integer)
        Dim hashKey As Integer
        hashKey = Hash(Name, 3)
        While studArr(hashKey) <> 0
            hashKey = hashKey + 1
            If hashKey > 3 Then hashKey = 0
        End While
        studArr(hashKey) = Name
    End Sub

    Function SearchHash(ByVal Name As Integer) As Integer
        Dim hashKey, totSearches As Integer
        hashKey = Hash(Name, 3)
        While studArr(hashKey) <> Name
            totSearches = totSearches + 1
            hashKey = hashKey + 1
            If hashKey > 3 Then hashKey = 0
            If totSearches > 3 Then
                Return 0
                Exit Function
            End If
        End While
        Return Name
    End Function

    Function Hash(ByVal KeyVal As Integer, ByVal MaxPos As Integer) As Integer
        Dim indexPos As Integer
        indexPos = KeyVal Mod (MaxPos + 1)
        Return indexPos
    End Function
End Module
