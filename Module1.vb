Module Module1

    Sub Main()
        'KilometrosRecorridos()
        'Infracciones()
        'NumerosEnteros()
        NumeroMayorMedioMenor()


    End Sub

    Sub KilometrosRecorridos()
        ' Distancia recorrida en kilómetros
        Dim distanciaKm As Double = 42.195

        ' Solicita al usuario que ingrese el tiempo en formato Horas:Minutos (horas y minutos)
        Dim tiempo As String = InputBox("Ingresa el tiempo en formato HH:MM, EJEMPLO: 17:45: ")

        ' Divide el tiempo en horas y minutos
        Dim partesTiempo() As String = tiempo.Split(":"c)
        Dim horas As Integer = Integer.Parse(partesTiempo(0))
        Dim minutos As Integer = Integer.Parse(partesTiempo(1))

        ' Calcula la velocidad media en diferentes unidades
        Dim tiempoTotalEnHoras As Double = horas + (minutos / 60.0)
        Dim velocidadKmPorHora As Double = distanciaKm / tiempoTotalEnHoras
        Dim velocidadKmPorMinuto As Double = distanciaKm / (horas * 60.0 + minutos)
        Dim velocidadKmPorSegundo As Double = distanciaKm / (horas * 3600.0 + minutos * 60.0)
        Dim velocidadMetrosPorMinuto As Double = (distanciaKm * 1000.0) / (horas * 60.0 + minutos)
        Dim velocidadMetrosPorSegundo As Double = (distanciaKm * 1000.0) / (horas * 3600.0 + minutos * 60.0)

        ' Muestra los resultados
        Console.WriteLine("Velocidad media en Km/h: " & velocidadKmPorHora)
        Console.WriteLine("Velocidad media en Km/min: " & velocidadKmPorMinuto)
        Console.WriteLine("Velocidad media en Km/s: " & velocidadKmPorSegundo)
        Console.WriteLine("Velocidad media en m/min: " & velocidadMetrosPorMinuto)
        Console.WriteLine("Velocidad media en m/s: " & velocidadMetrosPorSegundo)

        Console.WriteLine("Desarrollado por: Luis Mario Cordova Soriano")
        Console.ReadLine()

        'Este se ejecutara cuando ya se halla finlazido el programa.
        Console.WriteLine("Desarrollado por: Luis Mario Cordova Soriano")
    End Sub

    Sub Infracciones()
        ' Pedir al usuario la cantidad total de infracciones en el mes
        Dim totalInfracciones As Integer
        Dim input As String = InputBox("Ingrese la cantidad total de infracciones en el mes:")

        ' Verificar si el usuario ingresó un número válido
        If Integer.TryParse(input, totalInfracciones) Then
            ' Calcular los promedios
            'Utilice Math.Round para Redondear al positivo o negativo mas cercano y entregara solo numeros enteros.
            Dim promedioMatutino As Integer = CInt(Math.Round(totalInfracciones * 0.2 / 30))
            Dim promedioVespertino As Integer = CInt(Math.Round(totalInfracciones * 0.35 / 30))
            Dim promedioNocturno As Integer = CInt(Math.Round(totalInfracciones * 0.45 / 30))

            ' Imprimir los resultados
            Console.WriteLine("Promedio diario matutino de infracciones: " & promedioMatutino)
            Console.WriteLine("Promedio diario en la tarde de infracciones: " & promedioVespertino)
            Console.WriteLine("Promedio diario nocturno de infracciones: " & promedioNocturno)
        Else
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.")
        End If

        Console.WriteLine("Desarrollado por: Luis Mario Cordova Soriano")
        Console.ReadLine()

        'Este se ejecutara cuando ya se halla finlazido el programa.
        Console.WriteLine("Desarrollado por: Luis Mario Cordova Soriano")
    End Sub

    Sub NumerosEnteros()
        ' Solicitar al usuario que ingrese dos números enteros
        Dim NI As Integer
        Dim N2 As Integer

        ' Utilizamos InputBox para obtener los valores como cadenas de texto
        Dim input1 As String = InputBox("Ingrese el primer número entero (NI):")
        Dim input2 As String = InputBox("Ingrese el segundo número entero (N2):")

        ' Convertir las cadenas de texto en números enteros
        If Integer.TryParse(input1, NI) AndAlso Integer.TryParse(input2, N2) Then
            ' Comprobar si N2 es divisor de NI
            If NI Mod N2 = 0 Then
                Console.WriteLine($"{N2} es divisor de {NI}.")
            Else
                Console.WriteLine($"{N2} no es divisor de {NI}.")
            End If
        Else
            Console.WriteLine("Por favor, ingrese números enteros válidos.")
        End If

        Console.WriteLine("Desarrollado por: Luis Mario Cordova Soriano")
        Console.ReadLine()

        'Este se ejecutara cuando ya se halla finlazido el programa.
        Console.WriteLine("Desarrollado por: Luis Mario Cordova Soriano")

    End Sub

    Sub NumeroMayorMedioMenor()
        ' Declaración de variables para almacenar los valores
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim valor3 As Integer

        ' Pedir al usuario que ingrese los valores y utilizando InputBox
        valor1 = CInt(InputBox("Ingrese el primer valor entero:"))
        valor2 = CInt(InputBox("Ingrese el segundo valor entero:"))
        valor3 = CInt(InputBox("Ingrese el tercer valor entero:"))

        ' Determinar cual es el mayor, el medio y el menor
        Dim mayor, medio, menor As Integer

        ' Encontrar el mayor valor
        If valor1 >= valor2 AndAlso valor1 >= valor3 Then
            mayor = valor1
            If valor2 >= valor3 Then
                medio = valor2
                menor = valor3
            Else
                medio = valor3
                menor = valor2
            End If
        ElseIf valor2 >= valor1 AndAlso valor2 >= valor3 Then
            mayor = valor2
            If valor1 >= valor3 Then
                medio = valor1
                menor = valor3
            Else
                medio = valor3
                menor = valor1
            End If
        Else
            mayor = valor3
            If valor1 >= valor2 Then
                medio = valor1
                menor = valor2
            Else
                medio = valor2
                menor = valor1
            End If
        End If


        Console.WriteLine("El mayor valor es: " & mayor)
        Console.WriteLine("El valor medio es: " & medio)
        Console.WriteLine("El menor valor es: " & menor)

        Console.WriteLine("Desarrollado por: Luis Mario Cordova Soriano")
        Console.ReadKey()

        'Este se ejecutara cuando ya se halla finlazido el programa.
        Console.WriteLine("Desarrollado por: Luis Mario Cordova Soriano")
    End Sub


End Module
