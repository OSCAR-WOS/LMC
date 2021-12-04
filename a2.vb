Module Module1
    Dim eyeColourGV As Boolean = False
    Dim furColourBlack As Boolean = False
    Dim furColourRed As Boolean = False
    Dim furColourBR As Boolean = False
    Dim legsNumberIs2 As Boolean = False
    Dim tail As Boolean = False

    Dim eyesColour, furColour, legsNumber, tailBool, tempLower As String

    Sub Main()
        'Main Questions
        green()
        Console.WriteLine("Please enter the Eye Colour!")
        'Function eyeCheck = Valid Eye Colour
        Do Until eyeCheck() = True
        Loop

        green()
        Console.WriteLine()
        Console.WriteLine("Please enter the Fur Colour!")
        'Function furCheck = Valid Fur Colour
        Do Until furCheck() = True
        Loop

        green()
        Console.WriteLine()
        Console.WriteLine("Please enter amount of legs!")
        'Looping legsNumCheck Until Input = Valid Integer
        Do Until legsNumCheck() = True
        Loop
        'Sub legsCheck
        legCheck()

        green()
        Console.WriteLine()
        Console.WriteLine("Does your 'thing' have a tail?")
        'Sub tailCheck
        tailCheck()

        'Re-summerize data
        yellow()
        Console.WriteLine()
        Console.WriteLine("You entered the following data;")

        white()
        Console.WriteLine("Eye Colour: {0}", eyesColour)
        Console.WriteLine("Fur Colour: {0}", furColour)
        Console.WriteLine("Amount of Legs: {0}", legsNumber)
        Console.WriteLine("Tail: {0}", tailBool)
        Console.WriteLine()

        cyan()
        'Bunch of If/ElseIf statements
        If eyeColourGV = True AndAlso furColourRed = True Then
            Console.WriteLine("You're going to: Planet Saturn")
        ElseIf eyeColourGV = True AndAlso furColourRed = False Then
            Console.WriteLine("You're going to: Planet Mars")
        ElseIf eyeColourGV = False AndAlso furColourBlack = False Then
            Console.WriteLine("You're going to: Planet Neptune")
        ElseIf eyeColourGV = False AndAlso furColourBlack = True AndAlso legsNumberIs2 = True
            Console.WriteLine("You're going to: Planet Jupiter")
        ElseIf eyeColourGV = False AndAlso furColourBlack = True AndAlso legsNumberIs2 = False AndAlso tail = True Then
            Console.WriteLine("You're going to: Planet Mercury")
        ElseIf eyeColourGV = False AndAlso furColourBlack = True AndAlso legsNumberIs2 = False AndAlso tail = False Then
            Console.WriteLine("You're going to: Planet Centauri")
        End If
        Console.ReadLine()
    End Sub

    Public Function eyeCheck() As Boolean
        gray()
        eyesColour = Console.ReadLine
        tempLower = eyesColour.ToLower 'Converts to Lowercase

        If tempLower = "amber" Or tempLower = "blue" Or tempLower = "brown" Or tempLower = "gray" Or tempLower = "green" Or tempLower = "hazel" Or tempLower = "red" Or tempLower = "violet" Then
            'Checks against all eye-colours
            'Checks against pre-sets
            If tempLower = "green" Or tempLower = "violet" Then
                eyeColourGV = True
                Return True
            Else
                eyeColourGV = False
                Return True
            End If
        Else
            red()
            Console.WriteLine("Invalid Eye Colour! (Amber, Blue, Brown, Gray, Green, Hazel, Red, Violet)")
            Return False
        End If
    End Function

    Private Function furCheck()
        gray()
        furColour = Console.ReadLine
        tempLower = furColour.ToLower 'Converts to Lowercase

        If tempLower = "blue" Or tempLower = "brown" Or tempLower = "gray" Or tempLower = "green" Or tempLower = "black" Or tempLower = "red" Then
            'Checks against pre-sets
            If tempLower = "black" Then
                furColourBlack = True
            ElseIf tempLower = "red" Then
                furColourRed = True
            Else
                furColourBR = False
            End If
            Return True
        Else
            'Display Error Message
            red()
            Console.WriteLine("Invalid Fur Colour! (Blue, Brown, Gray, Green, Black, Red)")
            Return False
        End If
    End Function

    Public Function legsNumCheck() As Boolean
        gray()
        legsNumber = Console.ReadLine
        Dim legsNumeric As Boolean = IsNumeric(legsNumber) 'Checks if input is Numeric via "IsNumeric(string)"
        If legsNumeric = True Then 'If = True, continue
            Return True
        Else
            'Error message, repeat the function until = true
            red()
            Console.WriteLine("Please enter a valid number!")
            Return False
        End If
    End Function

    Public Sub legCheck()
        tempLower = legsNumber.ToLower
        'If - 2, make the boolean legsNumberIs2 = true
        If tempLower = "2" Then
            legsNumberIs2 = True
        End If
    End Sub

    Public Sub tailCheck()
        gray()
        tailBool = Console.ReadLine
        tempLower = tailBool.ToLower
        'stringName.Contains("string") = checks if string contains any word in the ""'s
        If tempLower.Contains("ye") Or tempLower = "y" Then
            tail = True
        End If
    End Sub


    'Colour functions, instead of typing Console.Forgroundcolor = ConsoleColor.(color), I made these simple functions to write Red() as Console.Forgroundcolor = ConsoleColor.Red
    Public Sub red()
        Console.ForegroundColor = ConsoleColor.Red
    End Sub

    Public Sub green()
        Console.ForegroundColor = ConsoleColor.Green
    End Sub

    Public Sub gray()
        Console.ForegroundColor = ConsoleColor.Gray
    End Sub

    Public Sub white()
        Console.ForegroundColor = ConsoleColor.White
    End Sub

    Public Sub cyan()
        Console.ForegroundColor = ConsoleColor.Cyan
    End Sub

    Public Sub yellow()
        Console.ForegroundColor = ConsoleColor.Yellow
    End Sub
End Module
