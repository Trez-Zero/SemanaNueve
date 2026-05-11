using System;

  static void Main()
    {
        const int numEstudiantes = 8;
        double[] notas = new double[numEstudiantes];
        int contadorReprobados = 0;
        double sumaNotas = 0;


        for (int i = 0; i < numEstudiantes; i++)
        {
            Console.Write($"Ingrese la nota del estudiante {i + 1}: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
            sumaNotas += notas[i];

            if (notas[i] < 60)
            {
                contadorReprobados++;
            }
        }


        Console.WriteLine("\nNotas aprobadas:");
        for (int i = 0; i < numEstudiantes; i++)
        {
            if (notas[i] >= 60)
            {
                Console.WriteLine($"Estudiante {i + 1}: {notas[i]}");
            }
        }


        Console.WriteLine($"\nNúmero de estudiantes reprobados: {contadorReprobados}");


        double promedio = sumaNotas / numEstudiantes;
        Console.WriteLine($"Promedio general del grupo: {promedio:F2}");
    }
