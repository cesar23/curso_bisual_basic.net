Module Module1

    Sub Main()
        Dim edad As Integer

        edad = 15

        Select Case edad
            Case 0
                Console.WriteLine("¡Acabas de nacer!")
            Case 1 To 10
                Console.WriteLine("Tienes de 1 a 10 años")
            Case 10 To 20
                Console.WriteLine("Tienes de 10 a 20 años")
            Case 20 To 30
                Console.WriteLine("Tienes de 20 a 30 años")
            Case Else
                Console.WriteLine("No se que edad tienes")
        End Select

        Console.ReadLine()


    End Sub

End Module
