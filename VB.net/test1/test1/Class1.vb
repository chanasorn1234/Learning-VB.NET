Public Class Class1
    Dim queue As New List(Of String)()
    Dim count As Integer
    Dim peek As Integer

    Public Sub New()
        count = 0
        peek = 0
    End Sub

    Public Sub push(i)
        queue.Add(i)
        count += 1
    End Sub

    Public Function pop()
        If (count! = 0) Then
            count -= 1
            peek = queue(0)
            queue.RemoveAt(0)
            Return peek
        Else
            Return "Empty Queue"
        End If
    End Function

    Public Function sizeOfqueue()
        Return count
    End Function
End Class
