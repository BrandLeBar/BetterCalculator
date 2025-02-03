'Brandon Barrera
'Spring 2025
'RCET2265
'Better Calculator
'https://github.com/BrandLeBar/BetterCalc_BB.git

Option Compare Text
Option Strict On
Option Explicit On

Module BetterCalc_BB

    Sub Main()
        Dim userInput As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim leave As Boolean = False

        Do
            Try
                Do
                    Try
                        Console.WriteLine("Please enter two numbers. Enter ""Q"" at any time to quit.")
                        Console.Write("Choose a Number:")
                        userInput = (Console.ReadLine)
                        firstNumber = CInt(userInput)
                        Console.WriteLine($"You entered {firstNumber}")
                        Console.WriteLine()

                        leave = True

                    Catch ex As Exception

                        If userInput <> "Q" Then
                            Console.WriteLine($"You entered ""{userInput}"", please enter a whole number.")
                        Else
                            Console.WriteLine($"You entered ""{userInput}"".")
                            Console.WriteLine("Have a nice day!")
                            leave = True
                            userInput = "Q"
                        End If
                    End Try
                Loop Until userInput = "Q" Or leave = True

                leave = False

                Do Until userInput = "Q" Or leave = True
                    Try
                        Console.Write("Choose a Number:")
                        userInput = (Console.ReadLine)
                        secondNumber = CInt(userInput)
                        Console.WriteLine($"You entered {secondNumber}")
                        Console.WriteLine()

                        leave = True

                    Catch ex As Exception

                        If userInput <> "Q" Then
                            Console.WriteLine($"You entered ""{userInput}"", please enter a whole number.")
                        Else
                            Console.WriteLine($"You entered ""{userInput}"".")
                            Console.WriteLine("Have a nice day!")
                            leave = True
                            userInput = "Q"
                        End If
                    End Try
                Loop

                leave = False

                Do Until userInput = "Q" Or leave = True
                    Try
                        Console.WriteLine("Choose one of the following options:" _
                                  & vbNewLine & "1. Addition" _
                                  & vbNewLine & "2. Subtration" _
                                  & vbNewLine & "3. Multiplication" _
                                  & vbNewLine & "4. Division")
                        userInput = Console.ReadLine
                        Console.WriteLine($"You entered ""{userInput}""")

                        Select Case userInput
                            Case "1"
                                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
                                leave = True
                            Case "2"
                                Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
                                leave = True
                            Case "3"
                                Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
                                leave = True
                            Case "4"
                                Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}")
                                leave = True
                            Case Else
                                Console.WriteLine($"You entered {userInput}, please enter a number 1-4")
                        End Select

                    Catch ex As Exception
                        If userInput <> "Q" Then
                            Console.WriteLine($"You entered ""{userInput}"", please enter a number between 1 and 4.")
                        Else
                            Console.WriteLine($"You entered ""{userInput}"".")
                            Console.WriteLine("Have a nice day!")
                            leave = True
                            userInput = "Q"
                        End If
                    End Try
                Loop

                leave = False

            Catch ex As Exception

                If userInput <> "Q" Then
                    Console.WriteLine($"You entered ""{userInput}"", please enter a whole number.")
                Else
                    Console.WriteLine($"You entered ""{userInput}"".")
                    Console.WriteLine("Have a nice day!")
                    userInput = "Q"
                End If
            End Try
        Loop Until leave = True Or userInput = "Q"

        Console.WriteLine("Press enter to leave this window.")

    End Sub

End Module
