Module Module1

    Sub Main()

        Dim colores(2) As String
        Dim contador As Integer

        colores(0) = "Rojo"
        colores(1) = "Verde"
        colores(2) = "Azul"

        ReDim Preserve colores(5)

        colores(3) = "Magenta"
        colores(4) = "Cian"
        colores(5) = "Amarillo"

        Console.Write("Los colores almacenados son: ")

        For contador = 0 To UBound(colores)
            Console.Write(colores(contador) & ", ")

        Next

        Console.ReadLine()

    End Sub

End Module
