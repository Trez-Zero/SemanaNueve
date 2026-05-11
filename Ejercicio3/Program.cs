using System;

    {
        int[] puntajes = new int[6];


        Console.WriteLine("Ingrese 6 puntajes:");
        for (int i = 0; i < puntajes.Length; i++)
        {
            Console.Write($"Puntaje {i + 1}: ");
            puntajes[i] = int.Parse(Console.ReadLine());
        }


        int puntajeMaximo = puntajes[0];
        foreach (int puntaje in puntajes)
        {
            if (puntaje > puntajeMaximo)
            {
                puntajeMaximo = puntaje;
            }
        }
        Console.WriteLine($"\nEl puntaje más alto es: {puntajeMaximo}");


        Array.Sort(puntajes);
        Console.WriteLine("\nPuntajes ordenados de menor a mayor:");
        foreach (int puntaje in puntajes)
        {
            Console.WriteLine(puntaje);
        }


        int contadorMayoresA500 = 0;
        foreach (int puntaje in puntajes)
        {
            if (puntaje > 500)
            {
                contadorMayoresA500++;
            }
        }
        Console.WriteLine($"\nCantidad de puntajes mayores a 500: {contadorMayoresA500}");
    }
