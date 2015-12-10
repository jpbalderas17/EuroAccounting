Module GeneralMethods
    Public Function StrToDate(str As String) As Date
        str = str.Substring(4, 2) & "/" & str.Substring(6, 2) & "/" & str.Substring(0, 4)
        Return Format(str, "Short date")
    End Function

    Public Function DateToStr(petsa As Date) As String
        Return Format(petsa, "yyyyMMdd")
    End Function
End Module
