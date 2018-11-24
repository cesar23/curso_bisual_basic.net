Module Module1

    Sub Main()

        Dim edad As Integer

        edad = 25

        If edad < 20 Then
            If edad < 10 Then
                Console.WriteLine("Tienes menos de diez años")

            Else
                Console.WriteLine("Tienes entre 10 y 20 años")
            End If

        Else
            If edad < 30 Then
                Console.WriteLine("Eres un veinteañero")

            Else
                Console.WriteLine("Tienes muchos años")
            End If
        End If


        Console.ReadLine()


    End Sub

End Module
