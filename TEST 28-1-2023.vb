Module Module1

    Sub Main()
        Dim name(0 To 4, 0 To 1) As String
        name = {{"smith", "tom"},
                {"jhon", "jane"},
                {"peter", "jade"},
                {"alan", "jhon"},
                {"omer", "shehroz"}}
        Dim swapped As Boolean
        Dim Score(0 To 4) As String
        Score = {98, 97, 89, 75, 77}
        Dim count As Integer

        Dim YearSize As Integer
        Dim maxsize As Integer
        Dim temp1 As Integer
        Dim temp2, temp3 As String
        maxsize = 5
        YearSize = 4


        swapped = True

        While swapped <> False
            swapped = False
            For Student = 0 To YearSize - 1
                If Score(Student) > Score(Student + 1) Then
                    temp1 = Score(Student)
                    temp2 = name(Student, 0)
                    temp3 = name(Student, 1)
                    Score(Student) = Score(Student + 1)
                    name(Student, 0) = name(Student + 1, 0)
                    name(Student, 1) = name(Student + 1, 1)
                    Score(Student + 1) = temp1
                    name(Student + 1, 0) = temp2
                    name(Student + 1, 1) = temp3
                    swapped = True
                End If
                count = count + 1

            Next

        End While



        For student = 0 To 4
            Console.WriteLine(student & ": " & name(student, 0) & " " & name(student, 1))
        Next
        Console.WriteLine("the algo analysis : " & count)
        Console.ReadKey()
    End Sub





End Module
