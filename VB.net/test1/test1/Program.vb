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
        If (x = 10) Then
            Console.WriteLine("equal 10")
        Else
            Console.WriteLine("No")
        End If
        While (x!= 0)
            x -= 1
        End While
        Console.WriteLine("x = 0 done")
    End Sub
End Module
