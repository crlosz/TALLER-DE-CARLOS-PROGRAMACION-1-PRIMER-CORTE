Console.Clear();
double capitalInicial, tasa, saldo;
int anios = 0;

Console.WriteLine("===========================");
Console.WriteLine("=== CAPITAL QUE SE DUPLICA ===");
Console.WriteLine(" ");

do
{
    Console.Write("Porfavr, ingrese el capital inicial: ");
} while (!double.TryParse(Console.ReadLine(), out capitalInicial) || capitalInicial <= 0);

do
{
    Console.Write("Porfavor, ingrese la tasa de interes anual (ejemplo: 0.05 para 5%): ");
} while (!double.TryParse(Console.ReadLine(), out tasa));

saldo = capitalInicial;

Console.WriteLine(" ");
Console.WriteLine("Año 0: " + saldo);

while (saldo < capitalInicial * 2 && anios < 100)
{
    saldo = saldo + saldo * tasa;
    anios = anios + 1;

    Console.WriteLine("Año " + anios + ": " + saldo);
}

Console.WriteLine(" ");

if (saldo >= capitalInicial * 2)
{
    Console.WriteLine("El capital se duplico en " + anios + " años.");
}
else
{
    Console.WriteLine("El capital no se duplico en 100 años con esa tasa.");
}

Console.WriteLine("===========================");
Console.ReadKey();