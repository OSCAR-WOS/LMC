Module Module1
    Dim g_Memory(20, 1) As String
    Dim g_CurrentMemory As Integer = 0
    Dim g_Buffer As String = ""

    Sub Main()
        readInfo()
        doInfo()

        printInfo()
        Console.ReadLine()


    End Sub

    Sub readInfo()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Enter your Function! <function> <integer>", g_CurrentMemory)

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Supported: LDA (Load), ADD (Add), SUB (Substract), MUL (Multiply), STA (Store), HLT (Halt)")

        Do Until IsValidSub()
            Console.ForegroundColor = ConsoleColor.Gray
            g_Buffer = Console.ReadLine
        Loop

    End Sub

    Sub printInfo()
        Console.WriteLine("Memory      Data")
        Dim x As Integer

        For x = 0 To 20
            Console.WriteLine("{0}: {1}      {2}", x, g_Memory(x, 0), g_Memory(x, 1))
        Next
    End Sub

    Sub doInfo()
        Dim loadedInfo As Integer

        Dim x As Integer
        For x = 0 To 20
            Dim temp As String = g_Memory(x, 0)
            Select Case temp
                Case "LDA"
                    loadedInfo = g_Memory(g_Memory(x, 1), 1)
                Case "ADD"
                    loadedInfo = loadedInfo + g_Memory(x, 1)
                Case "STA"
                    g_Memory(g_Memory(x, 1), 1) = loadedInfo
                    loadedInfo = 0
                Case "SUB"
                    loadedInfo = loadedInfo - g_Memory(x, 1)
                Case "MUL"
                    loadedInfo = loadedInfo * g_Memory(x, 1)
            End Select


        Next
    End Sub

    Function IsValidSub() As Boolean
        If g_Buffer.Equals("") Then
            Return False
        End If

        If g_Buffer.Equals("HLT") Then
            Dim g_Memory(g_CurrentMemory, 1)
            Console.WriteLine("Halt Wrote to: {0}", g_CurrentMemory)
            Return True
        End If

        If g_Buffer.Length > 3 Then
            Dim tempSub As String = g_Buffer.Substring(0, 3)
            If tempSub.Equals("LDA") Or tempSub.Equals("ADD") Or tempSub.Equals("STA") Or tempSub.Equals("SUB") Or tempSub.Equals("MUL") Then
                Dim g_SecondParam As String = g_Buffer.Substring(4)

                If g_SecondParam.Equals("") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Data Not Specified")
                    Return False
                Else
                    Dim g_SecondParamInt As Integer

                    Try
                        g_SecondParamInt = CInt(g_SecondParam)
                    Catch
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Second Parameter is Invalid!")
                        Return False
                    End Try

                    If tempSub.Equals("LDA") AndAlso g_SecondParamInt > 20 Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("You cannot load data higher then 20!")
                        Return False
                    End If

                    g_Memory(g_CurrentMemory, 0) = tempSub
                    g_Memory(g_CurrentMemory, 1) = g_SecondParamInt

                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine("Saved To: {0} Data: {1} {2}", g_CurrentMemory, tempSub, g_SecondParamInt)

                    g_CurrentMemory += 1

                    Return False
                End If
            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Invalid Function Written!")

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Supported: LDA (Load), ADD (Add), SUB (Substract), MUL (Multiply), STA (Store), HLT (Halt)")

                Return False
            End If

        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Too Short!")

            Return False
        End If

    End Function

End Module
