Console.Clear();
long numero, numeroOriginal, invertido = 0, digito;
int cantidadDigitos = 0, sumaDigitos = 0, pares = 0, impares = 0;
bool tieneCero = false, esPalindromo;

Console.WriteLine("===========================");
Console.WriteLine("=== ANALISIS DE NUMERO ===");
Console.WriteLine(" ");

do
{
    Console.Write("Porfavor, ingrese un numero entero positivo: ");
} while (!long.TryParse(Console.ReadLine(), out numero) || numero <= 0);

numeroOriginal = numero;

while (numero > 0)
{
    digito = numero % 10;

    cantidadDigitos = cantidadDigitos + 1;
    sumaDigitos = sumaDigitos + (int)digito;

    if (digito == 0)
    {
        tieneCero = true;
    }

    if (digito % 2 == 0)
    {
        pares = pares + 1;
    }
    else
    {
        impares = impares + 1;
    }

    invertido = invertido * 10 + digito;

    numero = numero / 10;
}

esPalindromo = numeroOriginal == invertido;

Console.WriteLine(" ");
Console.WriteLine("Cantidad de digitos: " + cantidadDigitos);
Console.WriteLine("Suma de los digitos: " + sumaDigitos);
Console.WriteLine("Digitos pares: " + pares);
Console.WriteLine("Digitos impares: " + impares);
Console.WriteLine("Contiene algun cero: " + tieneCero);
Console.WriteLine("Es palindromo: " + esPalindromo);
Console.WriteLine("===========================");
Console.ReadKey();