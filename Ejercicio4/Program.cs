using System;

    static void Main()
    {
        int[] ventas = new int[5];
        string[] categorias = { "Ficción", "No Ficción", "Ciencia", "Historia", "Infantil" };
        int totalVentas = 0;
        int categoriaMasVendida = 0;


for (int i = 0; i < ventas.Length; i++)
{
    Console.Write($"Ingrese la cantidad de libros vendidos en la categoría {categorias[i]}: ");
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int value))
    {
        ventas[i] = value;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Asumiendo 0.");
        ventas[i] = 0;
    }
    totalVentas += ventas[i];

           
            if (ventas[i] > ventas[categoriaMasVendida])
            {
                categoriaMasVendida = i;
            }
        }

   
        Console.WriteLine($"\nTotal de libros vendidos: {totalVentas}");

    
        Console.WriteLine($"La categoría con más ventas es: {categorias[categoriaMasVendida]} con {ventas[categoriaMasVendida]} ventas.");

   
        double promedioVentas = (double)totalVentas / ventas.Length;
        Console.WriteLine($"El promedio de ventas por categoría es: {promedioVentas:F2}");
    }
