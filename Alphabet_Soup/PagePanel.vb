Public Class PagePanel

    Public myPage As Page
    Public myForm As BookPanel

    Public Overridable Sub loadPage(page As Page, form As BookPanel)
    End Sub

    Public Function isComplete()
        Return myPage.GetIsCompleted
    End Function

    Public Sub RemoveLetter(letter As Letter)
        Controls.Remove(letter)
    End Sub

    Public Sub SetComplete()
        myPage.SetComplete()
        myForm.BookButtonBox1.CheckButtons()
    End Sub

    Public Sub SetInComplete()
        myPage.SetInComplete()
        myForm.BookButtonBox1.CheckButtons()
    End Sub

End Class
