Module Module1

    Sub Main()
        Dim guau As Object
        guau = New digoHola()
        guau.hola()
        guau.adios()
        Console.ReadLine()

    End Sub

End Module

Public Class digoHola
    Dim texto As String
    Public Sub hola()
        Console.WriteLine("Yo digo Hola")
        Console.WriteLine("Yo vuelvo a decir Hola")
    End Sub
    Public Sub adios()
        Console.WriteLine("Yo digo Adios")
    End Sub

End Class