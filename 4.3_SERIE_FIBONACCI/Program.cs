
Console.Clear();
int i, numero, termino1 = 0, termino2 = 1, siguiente, sumaTotal;

Console.WriteLine("===========================");
Console.WriteLine("=== SERIE DE FIBONACCI ===");
Console.WriteLine(" ");

do
{
    Console.Write("Por favor, ingrese un numero (1-40): ");
} while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 40);

Console.WriteLine(" ");
Console.Write("Serie: " + termino1);
sumaTotal = termino1;

if (numero >= 2)
{
    Console.Write(", " + termino2);
    sumaTotal = sumaTotal + termino2;
}

for (i = 3; i <= numero; i++)
{
    siguiente = termino1 + termino2;
    Console.Write(", " + siguiente);
    sumaTotal = sumaTotal + siguiente;

    termino1 = termino2;
    termino2 = siguiente;
}

Console.WriteLine(" ");
Console.WriteLine("La suma de todos los numeros de la serie es: " + sumaTotal);
Console.WriteLine("===========================");
Console.ReadKey();