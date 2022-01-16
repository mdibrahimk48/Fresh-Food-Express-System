Module Module1
    'Space Check
    Function Spacecheck(ByVal Start As String) As Boolean
        Dim x As String
        x = Start
        Dim Checkresult As Boolean = False
        For D = 0 To x.Length - 1
            Dim Charchek As String
            Charchek = x.Substring(D, 1)
            If Charchek = " " Then
                Checkresult = True
                Exit For
            End If
        Next
        Return Checkresult
    End Function
End Module
