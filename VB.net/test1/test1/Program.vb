Imports System
Imports Class1
Imports Class2
Module Program
    Dim x As Integer
    Dim q As New Class1()
    Dim s As New Class2()

    Sub Main(args As String())
        q.push(5)
        s.push(5)
        s.push(6)
        Console.WriteLine(q.sizeOfqueue())
        Console.WriteLine(s.peekOfstack())
    End Sub
End Module
