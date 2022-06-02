Imports System
Imports Class1
Module Program
    Dim x As Integer
    Dim q As New Class1()

    Sub Main(args As String())
        q.push(5)
        Console.WriteLine(q.sizeOfqueue())
    End Sub
End Module
