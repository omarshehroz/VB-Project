Module Module1
    Class TreasureChest
        Private Question As String
        Private Answer As Integer
        Private Points As Integer
        Public Sub New(ByVal Q As String, ByVal A As Integer, ByVal P As Integer)
            Question = Q
            Answer = A
            Points = P
        End Sub

        Function GetQuestion()
            Dim Q As String
            Q = Question
            Return Q
        End Function

        Function CheckAnswer(ByVal Ans As Integer) As Boolean
            If Answer = Ans Then
                Return True
            End If
            Return False
        End Function
        Function GetPoints(NoOfAttempts As Integer) As Integer
            Select Case NoOfAttempts
                Case 1 : Return Points
                Case 2 : Return Int(Points / 2)
                Case 3 Or 4 : Return Int(Points / 4)
                Case Else
                    Return 0

            End Select
        End Function
    End Class
    Dim ArrayTreasure(0 To 4) As TreasureChest
    Sub Main()
        Dim QNO As Integer
        Dim Ans, Attempts, index As Integer
        Attempts = 1
        Call ReadData()
        Console.WriteLine("Enter Question Number between 1 and 5:")
        QNO = Console.ReadLine()
        For x = 0 To 4
            If x = QNO - 1 Then
                Console.WriteLine(ArrayTreasure(x).GetQuestion)
                Do
                    Console.WriteLine("Enter Answer:")
                    Ans = Console.ReadLine
                    If ArrayTreasure(x).CheckAnswer(Ans) = True Then
                        index = x
                        Exit For

                    End If
                    Attempts = Attempts + 1

                Loop Until Attempts = 5
                
                
            End If

        Next
        Console.WriteLine(ArrayTreasure(index).GetPoints(Attempts))
        Console.ReadLine()
    End Sub
    Sub ReadData()
        'error'Dim ArrayTreasure(0 To 4) As TreasureChest
        Dim index = 0
        Dim Question = ""
        Dim Answer, Points As Integer

        Try
            FileOpen(1, My.Application.Info.DirectoryPath & "\TreasureChestData.txt", OpenMode.Input)
            While Not EOF(1)
                Input(1, Question)
                Input(1, Answer)
                Input(1, Points)
                ArrayTreasure(index) = New TreasureChest(Question, Answer, Points)
                index = index + 1
            End While
        Catch
            Console.WriteLine("File Not Found")

        End Try
    End Sub
End Module
