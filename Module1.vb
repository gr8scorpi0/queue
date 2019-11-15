Module Module1

    Sub Main()
        Dim Q(20) As String
        Dim Front, Rear, Size As Integer
        Front = 0
        Rear = 0
        Size = 0
        While 1 = 1

            Console.WriteLine("To ADD press A")
            Console.WriteLine("To REMOVE press R")
            Dim ans As String = Console.ReadLine
            If ans = "A" Then
                add(Front, Rear, Size, Q)
            ElseIf ans = "R" Then
                remove(Front, Rear, Size, Q)
            End If
        End While
    End Sub

    Sub add(ByRef F As Integer, ByRef R As Integer, ByRef S As Integer, ByRef Q() As String)

        If S < Q.Length Then
            Console.WriteLine("Input Data to ADD")
            Dim data As String = Console.ReadLine
            Q(R) = data
            R += 1
            S += 1
        Else
            Console.WriteLine("Cannot ADD Queue is FULL!")
        End If

    End Sub
    Sub remove(ByRef F As Integer, ByRef R As Integer, ByRef S As Integer, ByRef Q() As String)
        If R <> 0 Then
            Console.WriteLine(Q(F))
            F += 1
            S -= 1
        Else
            Console.WriteLine("Cannot ADD Queue is FULL!")
        End If

    End Sub
End Module
