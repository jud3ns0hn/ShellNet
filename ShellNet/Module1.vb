Module Module1
    <Runtime.InteropServices.DllImport("urlmon.dll", CharSet:=Runtime.InteropServices.CharSet.Ansi)>
    Private Function UrlMkSetSessionOption(
        ByVal dwOption As Integer,
        ByVal pBuffer As String,
        ByVal dwBufferLength As Integer,
        ByVal dwReserved As Integer) As Integer
    End Function
    Const URLMON_OPTION_USERAGENT As Integer = &H10000001
    Public Sub ChangeUserAgent(ByVal Agent As String)
        UrlMkSetSessionOption(URLMON_OPTION_USERAGENT, Agent, Agent.Length, 0)
    End Sub
End Module