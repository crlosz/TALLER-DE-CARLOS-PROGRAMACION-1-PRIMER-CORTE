Console.Clear;
char caracterEntrada;
Console.WriteLine("===========================");
Console.WriteLine("=== CLASIFICADOR DE CARACTERES ===");

do
{
    Console.Write("Ingrese un caracter para determinar si es VOCAL o CONSONANTE : ");
} while (!char.TryParse(Console.ReadLine(), out caracterEntrada));

caracterEntrada = char.ToLower(caracterEntrada);
Console.WriteLine("  ");
if (caracterEntrada == 'a'||caracterEntrada == 'e'||caracterEntrada == 'i'||caracterEntrada == 'o' || caracterEntrada == 'u')
{
    Console.WriteLine("El caracter " + caracterEntrada + " es una VOCAL.");
}
else
{
    Console.WriteLine("El caracter " + caracterEntrada + " es una CONSONANTE.");
}
Console.WriteLine("===========================");
Console.ReadKey();
