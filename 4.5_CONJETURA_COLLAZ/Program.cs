Console.Clear();
long numero, maximo;
int pasos = 0;

Console.WriteLine("===========================");
Console.WriteLine("=== CONJETURA DE COLLATZ ===");
Console.WriteLine(" ");

do
{
    Console.Write("Porfavor, ngrese un numero entero positivo: ");
} while (!long.TryParse(Console.ReadLine(), out numero) || numero <= 0);

maximo = numero;

Console.WriteLine(" ");
Console.WriteLine("Secuencia: " + numero);

while (numero != 1)
{
    if (numero % 2 == 0)
    {
        numero = numero / 2;
    }
    else
    {
        numero = numero * 3 + 1;
    }

    pasos = pasos + 1;

    Console.WriteLine(numero);

    if (numero > maximo)
    {
        maximo = numero;
    }
}

Console.WriteLine(" ");
Console.WriteLine("Cantidad de pesos: " + pasos);
Console.WriteLine("Valor maximo alcanzado: " + maximo);
Console.WriteLine("===========================");
Console.ReadKey();
