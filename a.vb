Module Module1
    Sub Main()
        Dim Operation As String
        Dim num1 As String
        Dim num2 As String
        Dim numericCheck As Boolean
        Dim numericCheck2 As Boolean
        Dim num11 As Double
        Dim num22 As Double
        Dim result As Double
Main:
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Please Enter Your Operation! (add, substract, multiply, divide)")
        Console.ForegroundColor = ConsoleColor.Gray
        Operation = Console.ReadLine()

        If Operation.Contains("add") OrElse Operation.Contains("substract") OrElse Operation.Contains("multiply") OrElse Operation.Contains("divide") Then
            GoTo No1
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Invalid Operation Used! Try Again!")
            GoTo Main
        End If

No1:
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Please Enter Your First Number!")
        Console.ForegroundColor = ConsoleColor.Gray
        num1 = Console.ReadLine()

        numericCheck = IsNumeric(num1)
        If numericCheck = True Then
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Incorrect Number Written! Try Again!")
            GoTo No1
        End If

No2:
        num11 = CDbl(num1)
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Please Enter Your Second Number!")
        Console.ForegroundColor = ConsoleColor.Gray
        num2 = Console.ReadLine()

        numericCheck2 = IsNumeric(num2)
        If numericCheck2 = True Then
            GoTo Calculation
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Incorrect Number Written! Try Again!")
            GoTo No2
        End If

Calculation:
        num22 = CDbl(num2)
        Console.ForegroundColor = ConsoleColor.Cyan
        If Operation = "add" Then
            If num1 = "9" Then
                If num2 = "10" Then
                    Console.WriteLine("9+10 Add to: 21!")
                    GoTo Finish
                End If
            End If
        End If

        If Operation = "add" Then
            result = num11 + num22
            Console.WriteLine(num11 & "+" & num22 & " Add to: " & result)
        ElseIf Operation = "substract" Then
            result = num11 - num22
            Console.WriteLine(num11 & "-" & num22 & " Substract to: " & result)
        ElseIf Operation = "multiply" Then
            result = num11 * num22
            Console.WriteLine(num11 & "*" & num22 & " Multiply to: " & result)
        ElseIf Operation = "divide" Then
            result = num11 / num22
            Console.WriteLine(num11 & "/" & num22 & " Divide to: " & result)
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Invalid Operation Used!")
        End If

Finish:
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine()
        Console.WriteLine("Would you like to do another calculation?")
        Console.ForegroundColor = ConsoleColor.Gray
        Dim again As String = Console.ReadLine

        If again = "yes" Then
            GoTo Main
        Else
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Thanks for using my calculator!")
            Console.ReadLine()
        End If
    End Sub
End Module
