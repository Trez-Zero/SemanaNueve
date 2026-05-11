using System;

const int NUM_DIAS = 7;
double[] temperaturas = new double[NUM_DIAS];


for (int i = 0; i < NUM_DIAS; i++)
{
    Console.Write($"Ingrese la temperatura máxima del día {i + 1}: ");
    temperaturas[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("\nTemperaturas registradas:");
for (int i = 0; i < NUM_DIAS; i++)
{
    Console.WriteLine($"Día {i + 1}: {temperaturas[i]} °C");
}

double suma = 0;
for (int i = 0; i < NUM_DIAS; i++)
{
    suma += temperaturas[i];
}
double promedio = suma / NUM_DIAS;
Console.WriteLine($"\nPromedio semanal: {promedio} °C");

double tempMax = temperaturas[0];
double tempMin = temperaturas[0];
for (int i = 1; i < NUM_DIAS; i++)
{
    if (temperaturas[i] > tempMax)
    {
        tempMax = temperaturas[i];
    }
    if (temperaturas[i] < tempMin)
    {
        tempMin = temperaturas[i];
    }
}
Console.WriteLine($"Temperatura más alta: {tempMax} °C");
Console.WriteLine($"Temperatura más baja: {tempMin} °C");

    