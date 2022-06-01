Imports System
Imports Class1
Module Program
    Dim x As Integer
    Dim obj As New Class1()
    Sub Main(args As String())
        x = Console.ReadLine()
        For i As Integer = 0 To x
            For j As Integer = 0 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        obj.display()

    End Sub
End Module
