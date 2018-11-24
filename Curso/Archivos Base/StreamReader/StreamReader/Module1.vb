Imports System.IO
Module Module1

    Sub Main()

        Dim archivo As String
        archivo = "C:/archivos/prueba.txt"
        Dim informacion As FileInfo
        informacion = New FileInfo(archivo)

        Console.WriteLine("El nombre del archivo es: " & informacion.Name)
        Console.WriteLine("La extension del archivo es: " & informacion.Extension)
        Console.WriteLine("La ultima vez que accedi al archivo fue: " & informacion.LastWriteTime)
        Console.ReadLine()


    End Sub

End Module
