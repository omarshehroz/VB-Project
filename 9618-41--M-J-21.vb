Module Module1

    Sub Main()
        Dim linkedlist(9) As Node

        linkedlist(0).Data = 1
        linkedlist(0).nextNode = 1
        linkedlist(1).Data = 5
        linkedlist(1).nextNode = 4
        linkedlist(2).Data = 6
        linkedlist(2).nextNode = 7
        linkedlist(3).Data = 7
        linkedlist(3).nextNode = -1
        linkedlist(4).Data = 2
        linkedlist(4).nextNode = 2
        linkedlist(5).Data = 0
        linkedlist(5).nextNode = 6
        linkedlist(6).Data = 0
        linkedlist(6).nextNode = 8
        linkedlist(7).Data = 56
        linkedlist(7).nextNode = 3
        linkedlist(8).Data = 0
        linkedlist(8).nextNode = 9
        linkedlist(9).Data = 0
        linkedlist(9).nextNode = -1

        Dim startPointer As Integer
        Dim emptyList As Integer
        startPointer = 0
        emptyList = 5
        outputNodes(linkedlist, startPointer)

        Dim returnValue As Boolean
        returnValue = addNode(linkedlist, startPointer,emptyList)
        If returnValue = True Then
            Console.WriteLine("Item successfully added")
        Else
            Console.WriteLine("Item not added, list full")
        End If
        outputNodes(linkedlist, startPointer)
        Console.ReadLine()

    End Sub

    Sub outputNodes(ByVal linkedlist, currentpointer)
        While (currentpointer <> -1)
            Console.WriteLine(linkedlist(currentpointer).data)
            currentpointer = linkedlist(currentpointer).nextNode
        End While

    End Sub
    Structure Node

        Dim Data As Integer
        Dim nextNode As Integer
    End Structure

    Function addNode(ByRef linkedList() As Node, ByVal currentPointer As Integer, ByRef emptyList As Integer)
        Console.WriteLine("Enter the data to add")
        Dim dataToAdd As Integer = Console.ReadLine()
        Dim previousPointer As Integer = 0
        Dim newNode As Node
        If emptyList < 0 Or emptyList > 9 Then
            Return False
        Else
            newNode.Data = dataToAdd
            newNode.nextNode = -1
            linkedList(emptyList) = newNode
            previousPointer = 0
            While (currentPointer <> -1)
                previousPointer = currentPointer
                currentPointer = linkedList(currentPointer).nextNode
            End While
            Dim valueToWrite As Integer = emptyList
            linkedList(previousPointer).nextNode = valueToWrite
            emptyList = linkedList(emptyList).nextNode
            Return True
        End If
    End Function
End Module
