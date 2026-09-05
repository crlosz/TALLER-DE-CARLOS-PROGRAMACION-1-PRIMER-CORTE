Console.Clear();
int codigo, digito1, digito2, digito3, digito4, suma, producto;
bool esValido;

Console.WriteLine("===========================");
Console.WriteLine("=== VALIDADOR DE CODIiGO ===");
Console.WriteLine(" ");

do
{
    Console.Write("Ingrese un codigo de 4 cifras (1000-9999): ");
} while (!int.TryParse(Console.ReadLine(), out codigo) || codigo < 1000 || codigo > 9999);

digito1 = codigo % 10;
codigo = codigo / 10;

digito2 = codigo % 10;
codigo = codigo / 10;

digito3 = codigo % 10;
codigo = codigo / 10;

digito4 = codigo % 10;

suma = digito3 + digito2;
producto = digito4 * digito1;

esValido = suma == producto;

Console.WriteLine(" ");

if (esValido)
{
    Console.WriteLine("El codigo es valido.");
}
else
{
    Console.WriteLine("El codigosi es validop");
}

Console.WriteLine("===========================");
Console.ReadKey();