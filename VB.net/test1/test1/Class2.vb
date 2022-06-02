Public Class Class2
    Dim stack As New List(Of String)()
    Dim count As Integer
    Dim peek As Integer
    Public Sub New()
        count = 0
        peek = 0
    End Sub
    Public Sub push(i)
        stack.Add(i)
        count += 1
    End Sub
    Public Function pop()
        If (count <> 0) Then
            peek = stack(count - 1)
            stack.RemoveAt(count - 1)
            count -= 1
            Return peek
        Else
            Return "Empty Stack"
        End If
    End Function
    Public Function sizeOfstack()
        Return count
    End Function
    Public Function peekOfstack()
        If (count <> 0) Then
            Return stack(count - 1)
        Else
            Return "Empty Stack"
        End If
    End Function

End Class
