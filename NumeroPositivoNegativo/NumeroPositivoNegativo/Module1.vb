Module Module1

    Sub Main()

        Console.WriteLine("ingrese el numero para comparar si es positivo o negativo")
        Dim numero As Integer
        numero = Console.ReadLine()



        If numero > 0 Then
            Console.WriteLine("el numero es positivo")

        ElseIf numero < 0 Then
            Console.WriteLine("el numero es negativo")

        Else
            Console.WriteLine("el numero es 0")



        End If





        Console.ReadKey()

    End Sub



End Module
