double ladoA, ladoB, ladoC;
bool esTriangulo;

Console.WriteLine("===========================");
Console.WriteLine("=== CLASIFICADOR DE TRIANGULOS ===");
Console.WriteLine("===========================");
Console.WriteLine(" ");

do
{
    Console.Write("Ingrese el lado A: ");
} while (!double.TryParse(Console.ReadLine(), out ladoA) || ladoA <= 0);

do
{
    Console.Write("Ingrese el lado B: ");
} while (!double.TryParse(Console.ReadLine(), out ladoB) || ladoB <= 0);

do
{
    Console.Write("Ingrese el lado C: ");
} while (!double.TryParse(Console.ReadLine(), out ladoC) || ladoC <= 0);

Console.WriteLine(" ");

esTriangulo = (ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA);

if (esTriangulo)
{
    if (ladoA == ladoB && ladoB == ladoC)
    {
        Console.WriteLine(" El triangulo es EQUILATERO (todos sus lados son iguales).");
    }
    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
    {
        Console.WriteLine(" El triangulo es ISOSCELES (tiene dos lados iguales).");
    }
    else
    {
        Console.WriteLine(" El triangulo es ESCALENO (todos sus lados son diferentes).");
    }
}
else
{
    Console.WriteLine("Los lados ingresados NO forman un triangulo valido.");
    Console.WriteLine("La suma de cualesquiera dos lados debe ser siempre mayor que el tercer lado.");
}

Console.WriteLine("===========================");
Console.ReadKey();