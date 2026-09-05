Console.Clear();
int numero, digito1, digito2, digito3, digito4, digito5;
bool esPalindromo;

Console.WriteLine("===========================");
Console.WriteLine("=== PALINDROMO DE 5 DIGITOS ===");
Console.WriteLine(" ");

do
{
    Console.Write("Porfavor , ingrese un numero de 5 cifras (10000-99999): ");
} while (!int.TryParse(Console.ReadLine(), out numero) || numero < 10000 || numero > 99999);

digito1 = numero % 10;
numero = numero / 10;

digito2 = numero % 10;
numero = numero / 10;

digito3 = numero % 10;
numero = numero / 10;

digito4 = numero % 10;
numero = numero / 10;

digito5 = numero % 10;   12345

esPalindromo = digito1 == digito5 && digito2 == digito4;

Console.WriteLine(" ");

if (esPalindromo)
{
    Console.WriteLine("El numero si es palindromo.");
}
else
{
    Console.WriteLine("El numero no es palindromo.");
}

Console.WriteLine("===========================");
Console.ReadKey();