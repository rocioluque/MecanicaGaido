Imports System.Runtime.InteropServices

Public Module User32
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Public Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Public Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
End Module

