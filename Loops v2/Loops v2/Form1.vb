Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For i As Integer = 5 To 100
        '    If i Mod 5 = 0 Then
        '        Debug.Write(i.ToString + ", ")
        '    End If
        'Next
        'Dim g As Integer = 0
        'While g <= 100
        '    If g Mod 5 = 0 Then
        '        Debug.Write(g.ToString & " ")
        '    End If
        '    g += 1
        'End While
        'Debug.Write(1)
        'Dim LastNumber As Integer = 2
        'Dim SLastNumber As Integer = 1
        'Dim NextNumber As Integer
        'While LastNumber <= 4000000
        '    NextNumber = LastNumber + SLastNumber
        '    SLastNumber = LastNumber
        '    LastNumber = NextNumber
        '    Debug.Write(", " + LastNumber.ToString)
        'End While
        Dim c As Integer = cube(3)
        MsgBox(c)

    End Sub
    Private Function cube(num As Integer)
        Return num * num * num
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lastnumber As Integer = 2
        Dim slastnumber As Integer = 1
        Dim nextnumber As Integer
        Dim sum As Integer = 2
        While lastnumber <= 4000000
            nextnumber = lastnumber + slastnumber
            slastnumber = lastnumber
            lastnumber = nextnumber
            If lastnumber Mod 2 = 0 Then
                sum = sum + lastnumber
            End If
        End While
        MsgBox(sum)
    End Sub
End Class
