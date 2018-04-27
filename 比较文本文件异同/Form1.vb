Imports System.IO
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sr1 As New StreamReader("C:\Users\Eryu\Desktop\rb2DMIG\rb2DMIG_AX1.pch")
        Dim sr2 As New StreamReader("C:\Users\Eryu\Desktop\rb2DMIG\rb2DMIG_AX.pch")

        Dim ins1 As String = ""
        Dim ins2 As String = ""
        Dim i As Integer = 1
        Do
            ins1 = sr1.ReadLine()
            ins2 = sr2.ReadLine()
            If ins1 <> ins2 Then
                MsgBox(i)
            End If
            i = i + 1
        Loop Until sr1.EndOfStream

        MsgBox("sr2 End: " & sr2.EndOfStream)

        sr1.Close()
        sr2.Close()
    End Sub
End Class
