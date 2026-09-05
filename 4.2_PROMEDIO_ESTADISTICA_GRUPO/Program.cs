Console.Clear();
int n, i, aprobados = 0, reprobados = 0;
double nota, notaMayor, notaMenor;

Console.WriteLine("===========================");
Console.WriteLine("=== NOTAS DE ESTUDIANTES ===");
Console.WriteLine(" ");

do
{
    Console.Write("Porfavor, ingrese el numero de estudiantes: ");
} while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

do
{
    Console.Write("Porfavor, ingrese la nota del estudiante 1: ");
} while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0);

notaMayor = nota;
notaMenor = nota;

if (nota >= 3.0)
{
    aprobados = aprobados + 1;
}
else
{
    reprobados = reprobados + 1;
}

for (i = 2; i <= n; i++)
{
    do
    {
        Console.Write("Porfavor, ingrese la nota del estudiante " + i + ": ");
    } while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0);

    if (nota > notaMayor)
    {
        notaMayor = nota;
    }

    if (nota < notaMenor)
    {
        notaMenor = nota;
    }

    if (nota >= 3.0)
    {
        aprobados = aprobados + 1;
    }
    else
    {
        reprobados = reprobados + 1;
    }
}

Console.WriteLine(" ");
Console.WriteLine("Nota mayor: " + notaMayor);
Console.WriteLine("Nota menor: " + notaMenor);
Console.WriteLine("Aprobados: " + aprobados);
Console.WriteLine("Reprobados: " + reprobados);
Console.WriteLine("===========================");
Console.ReadKey();