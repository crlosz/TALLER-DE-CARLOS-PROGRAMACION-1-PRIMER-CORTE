double nota1, nota2, nota3, promedio;
Console.WriteLine("===========================");
Console.WriteLine("=== APROBACION DEL SEMESTRE ===");
do
{
    Console.Write("Ingrese la nota del primer corte (0.0 a 5.0): ");
} while (!double.TryParse(Console.ReadLine(), out nota1) || nota1 < 0.0 || nota1 > 5.0);

do
{
    Console.Write("Ingrese la nota del segundo corte (0.0 a 5.0): ");
} while (!double.TryParse(Console.ReadLine(), out nota2) || nota2 < 0.0 || nota2 > 5.0);

do
{
    Console.Write("Ingrese la nota del tercer corte (0.0 a 5.0): ");
} while (!double.TryParse(Console.ReadLine(), out nota3) || nota3 < 0.0 || nota3 > 5.0);
promedio = (nota1 * 0.30) + (nota2 * 0.30) + (nota3 * 0.40);
promedio = (int)(promedio * 100) / 100.0;
Console.WriteLine(" ");
Console.WriteLine("PROMEDIO PONDERADO: " + promedio);
if (promedio > 3.5 && nota1 >= 3.0 && nota2 >= 3.0 && nota3 >= 3.0)
{
    Console.WriteLine("EL ESTUDIANTE HA APROBADO EL SEMESTRE.");
}
else
{
    Console.WriteLine("EL ESTUDIANTE NO HA APROBADO EL SEMESTRE.");
}

Console.WriteLine("===========================");
Console.ReadKey();