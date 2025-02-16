
Imports System

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub


    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static newMessage1() = {"Hello",
                          "Good bye",
                          "Jimmy likes pizza!!",
                          "too many bananas",
                          "more",
                          "aardvark",
                          "must be a number",
                          "I need one more message"
                          }
        clear = True
        If clear = True Then
            newMessage = ""
            clear = True
        End If

        If clear = False Then
            Console.WriteLine(newMessage1)
        End If
        Return newMessage
        clear = False
    End Function


End Module
