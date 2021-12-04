Module Module1
    Dim newPass As String

    Sub Main()
        Console.WriteLine("Write a new password! Between 8-16, Cannot start with number, Atleast 1 number, Doesn't have a space and has atleast 1 capital letter!")
        newPass = Console.ReadLine()

        Do Until CheckPassword()
        Loop

        Console.WriteLine("You got a good Password! {0}", newPass)
        Console.ReadLine()

    End Sub

    Function CheckPassword() As Boolean
        If newPass.Length <= 16 AndAlso newPass.Length >= 8 Then

            Dim subString As String = newPass.Substring(0, 1)
            If IsNumeric(subString) <> True Then
                Dim position As Integer
                Dim hasInteger As Boolean
                Dim hasNoSpace As Boolean = True
                Dim hasCapital As Boolean

                For position = 0 To newPass.Length - 1
                    Dim subNum As String = newPass.Substring(position, 1)
                    If IsNumeric(subNum) Then
                        hasInteger = True
                    End If

                    If Char.IsUpper(subNum) Then
                        hasCapital = True
                    End If

                    If subNum.Contains(" ") Then
                        hasNoSpace = False
                    End If
                Next

                If hasInteger Then
                    If hasNoSpace Then
                        If hasCapital Then
                            Return True
                        Else
                            Console.WriteLine("Password needs to have a Capital!")
                            newPass = Console.ReadLine

                            Return False
                        End If
                    Else
                        Console.WriteLine("Password has a Space")
                        newPass = Console.ReadLine

                        Return False
                    End If
                Else
                    Console.WriteLine("Password does not contain a number!")
                    newPass = Console.ReadLine

                    Return False
                End If
            Else
                Console.WriteLine("First Character cannot be a number!")

                newPass = Console.ReadLine()
                Return False
            End If
        Else
            If newPass.Length > 16 Then
                Console.WriteLine("Too many Characters! 16 Max")
            Else
                Console.WriteLine("Too little Characters! 8 Minimum")
            End If

            newPass = Console.ReadLine()
            Return False
        End If

    End Function
End Module
 
