Module Module1

    Sub Main()
        Dim contador As Integer
        contador = 0

        Do
            Console.WriteLine(contador)
            contador += 1
            ' If contador > 100 Then Exit Do
        Loop While contador > 10
        Console.WriteLine("Ya he salido del bucle")

        Console.ReadLine()


    End Sub

End Module
