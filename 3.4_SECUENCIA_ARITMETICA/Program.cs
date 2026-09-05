Console.Clear();
int numero, digito1, digito2, digito3;
bool esSecuencia;

Console.WriteLine("===========================");
Console.WriteLine("=== SECUENCIA ARITMETICA ===");
Console.WriteLine(" ");

do
{
    Console.Write("Ingrese un numero de 3 cifras (100-999): ");
} while (!int.TryParse(Console.ReadLine(), out numero) || numero < 100 || numero > 999);

digito1 = numero % 10;
numero = numero / 10;

digito2 = numero % 10;
numero = numero / 10;

digito3 = numero % 10;

esSecuencia = digito2 == digito3 + 1 && digito1 == digito2 + 1;

Console.WriteLine(" ");

if (esSecuencia)
{
    Console.WriteLine("Los digitos si forman una secuencia incremental.");
}
else
{
    Console.WriteLine("Los digitos no forman una secuencia incremental.");
}

Console.WriteLine("===========================");
Console.ReadKey();
