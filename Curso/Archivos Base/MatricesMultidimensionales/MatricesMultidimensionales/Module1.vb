Module Module1

    Sub Main()

        Dim agenda(3, 100) As String

        agenda(0, 0) = "Jose Vicente"
        agenda(1, 0) = "5312452345"
        agenda(2, 0) = "Direccion de la calle"
        agenda(3, 0) = "info@jocarsa.com"

        agenda(0, 1) = "Javier"
        agenda(1, 1) = "53455"
        agenda(2, 1) = "Calle 2, 43"
        agenda(3, 1) = "fqsdrf@tfsdsdf.com"

        agenda(0, 2) = "Juan"
        agenda(1, 2) = "75676574"
        agenda(2, 2) = "Calle 3, 65"
        agenda(3, 2) = "gsdfgsd@fdsafsd.com"

        Console.WriteLine("Nombre: " & agenda(0, 1))
        Console.WriteLine("Telefono: " & agenda(1, 1))
        Console.WriteLine("TDireccion: " & agenda(2, 1))
        Console.WriteLine("Email: " & agenda(3, 1))
        Console.ReadLine()


    End Sub

End Module
