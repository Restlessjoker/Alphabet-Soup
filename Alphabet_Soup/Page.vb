Public MustInherit Class Page
    Protected isCompleted As Boolean

    Sub New()
        isCompleted = False
    End Sub

    Public Sub SetComplete()
        isCompleted = True
    End Sub

    Public Sub SetInComplete()
        isCompleted = False
    End Sub

    Public Function GetIsCompleted()
        Return isCompleted
    End Function

End Class
