
Imports System

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub


    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        'Builds an array of strings which is used to write our sequential messages to.
        Static Messages As New Text.StringBuilder()
        If clear Then
            ' When we write a true to the clear it gets rid of all strings writen
            Messages.Clear()
        ElseIf newMessage = "" Then
            ' If there is nothing written to the message the we will just write nothing
            Messages.Append(newMessage)
        ElseIf newMessage = newMessage Then
            'If we are writting a list it writes each
            'word and then write the nest word to a new line
            Messages.AppendLine(newMessage)
        End If
        'Returns the messages wrote to the stringbuilder
        Return Messages.ToString()
    End Function


End Module
