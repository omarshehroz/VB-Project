Module Module1
   
    Sub Main()
        Do
            Console.WriteLine("Enter a number to find its factorial:")
            Dim num As Integer = Console.ReadLine()
            Console.WriteLine("The factorial of " & num & " is " & factorial(num))
            Console.WriteLine("Do you want to calculate another factorial? (y/n)")
        Loop Until Console.ReadLine().ToLower() = "n"
    End Sub

    Function factorial(num As Integer) As Integer
        Dim index(0 To num)

        Dim x, y As Integer
        Console.WriteLine("At Index: " & num - 1 & " the Value is: " & num)

        If num <= 1 Then
            
            Return 1

        End If
        x = factorial(num - 1)
        y = x * num
        Return y

        Return factorial(x + 1)


       

    End Function

End Module





