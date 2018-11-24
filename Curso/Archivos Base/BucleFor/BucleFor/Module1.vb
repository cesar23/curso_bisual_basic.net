Module Module1

    Sub Main()
        Dim contador As Integer

        For contador = 0 To 10 Step 1
            Console.WriteLine(contador)
            If contador = 7 Then Exit For

        Next
        Console.WriteLine("Ya he salido del bucle")

        Console.ReadLine()

    End Sub

End Module
