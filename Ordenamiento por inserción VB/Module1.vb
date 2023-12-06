Module Module1

    Sub Main()
        Dim array As Integer() = {12, 11, 13, 5, 6}

        Dim stopwatch As New Stopwatch()
        stopwatch.Start()
        InsertionSort(array)
        stopwatch.Stop()

        For Each item In array
            Console.WriteLine(item)
        Next
        Console.WriteLine("El tiempo de ejecucion  fue de = " & stopwatch.Elapsed.ToString())
        Console.ReadKey()
    End Sub

    Sub InsertionSort(array As Integer())
        Dim n As Integer = array.Length
        For i As Integer = 1 To n - 1
            Dim key As Integer = array(i)
            Dim j As Integer = i - 1

            ' Mover los elementos del array(0..i-1) que son mayores que key
            ' a una posición adelante de su posición actual
            While j >= 0 AndAlso array(j) < key
                array(j + 1) = array(j)
                j = j - 1
            End While
            array(j + 1) = key
        Next
    End Sub


End Module
