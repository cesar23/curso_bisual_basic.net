Module Module1

    Sub Main()
        Dim contador As Integer
        contador = 0

        While contador < 10
            Console.WriteLine(contador)
            contador += 1
        End While
        Console.WriteLine("Ya he salido del bucle While")

        Console.ReadLine()
    End Sub

End Module
