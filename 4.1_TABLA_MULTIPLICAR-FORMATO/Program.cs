Console.Clear();
int numeroTabla, i, numeroMatriz;
Console.WriteLine("===========================");
Console.WriteLine("=== TABLA DE MULTIPLICAR  ===");
Console.WriteLine(" ");
do
{
    Console.Write("Por favor, ingrese un numero (1-12): ");

} while (!int.TryParse(Console.ReadLine(), out numeroTabla) || numeroTabla < 1 || numeroTabla > 12);

for (i = 1; i <= 12; i++)
{
    Console.WriteLine(numeroTabla + " x " + i + "  = " + numeroTabla * i);
}

Console.WriteLine(" ");
Console.WriteLine("============================");
Console.WriteLine(" TABLA COMPLETA 1-12");
Console.WriteLine(" ");
for (numeroMatriz = 1; numeroMatriz <= 12; numeroMatriz++)
{
    for (i = 1; i <= 12; i++)
    {
        Console.WriteLine(numeroMatriz + " x " + i + "  = " + numeroMatriz * i);
    }
    Console.WriteLine(" ");
}

Console.WriteLine(" ");
Console.WriteLine("===========================");
Console.ReadKey();