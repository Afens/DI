﻿Imports System.Threading

Module Module1
    Sub Canta()
        Console.Beep(659, 125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(523, 125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(784, 125)
        Thread.Sleep(375)
        Console.Beep(392, 125)
        Thread.Sleep(375)
        Console.Beep(523, 125)
        Thread.Sleep(250)
        Console.Beep(392, 125)
        Thread.Sleep(250)
        Console.Beep(330, 125)
        Thread.Sleep(250)
        Console.Beep(440, 125)
        Thread.Sleep(125)
        Console.Beep(494, 125)
        Thread.Sleep(125)
        Console.Beep(466, 125)
        Thread.Sleep(42)
        Console.Beep(440, 125)
        Thread.Sleep(125)
        Console.Beep(392, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(784, 125)
        Thread.Sleep(125)
        Console.Beep(880, 125)
        Thread.Sleep(125)
        Console.Beep(698, 125)
        Console.Beep(784, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(587, 125)
        Console.Beep(494, 125)
        Thread.Sleep(125)
        Console.Beep(523, 125)
        Thread.Sleep(250)
        Console.Beep(392, 125)
        Thread.Sleep(250)
        Console.Beep(330, 125)
        Thread.Sleep(250)
        Console.Beep(440, 125)
        Thread.Sleep(125)
        Console.Beep(494, 125)
        Thread.Sleep(125)
        Console.Beep(466, 125)
        Thread.Sleep(42)
        Console.Beep(440, 125)
        Thread.Sleep(125)
        Console.Beep(392, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(784, 125)
        Thread.Sleep(125)
        Console.Beep(880, 125)
        Thread.Sleep(125)
        Console.Beep(698, 125)
        Console.Beep(784, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(587, 125)
        Console.Beep(494, 125)
        Thread.Sleep(375)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(415, 125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(698, 125)
        Thread.Sleep(125)
        Console.Beep(698, 125)
        Console.Beep(698, 125)
        Thread.Sleep(625)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(415, 125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(622, 125)
        Thread.Sleep(250)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(523, 125)
        Thread.Sleep(1125)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(415, 125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(698, 125)
        Thread.Sleep(125)
        Console.Beep(698, 125)
        Console.Beep(698, 125)
        Thread.Sleep(625)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(415, 125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(622, 125)
        Thread.Sleep(250)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(523, 125)
        Thread.Sleep(625)
    End Sub
    Sub Main()
        Dim salida As String
        Do
            Try
                Console.WriteLine("Introduce un color")
                Console.ForegroundColor = Console.ReadLine()
            Catch ex As Exception
            End Try
            For index = 1 To 10
                Console.WriteLine("Hola Mundo")
            Next
            Thread.Sleep(2000)
            Console.Beep()
            Console.WriteLine("Salir? SI/NO")
            salida = Console.ReadLine()

        Loop Until salida.ToLower() = "si"
        Canta()

    End Sub

End Module
