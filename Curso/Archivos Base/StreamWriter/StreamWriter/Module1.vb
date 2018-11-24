Imports System.IO
Module Module1

    Sub Main()

        Dim escritor As StreamWriter

        escritor = New StreamWriter("C:/archivos/prueba.txt", False)

        escritor.Write("Hola ")
        escritor.Write("me llamo ")
        escritor.Write("Jose Vicente ")

        escritor.Close()

    End Sub

End Module
