Console.Clear();

double promedio,ingresoFamiliar; 
bool esApto;

Console.WriteLine("===========================");
Console.WriteLine(" ");
Console.WriteLine("=BIENVENIDO AL PROGRAMA BECAS SOCIOECONIMICAS=");
Console.WriteLine(" ");
do
{
    Console.Write("Ingrese el promedio obtenido (0.0, 5.0): ");
} while(!double.TryParse(Console.ReadLine(),out promedio) || promedio < 0 || promedio > 5);

Console.WriteLine(" ");
do
{
    Console.Write("Ingrese el ingreso familiar: ");
}while(!double.TryParse(Console.ReadLine(),out ingresoFamiliar)||ingresoFamiliar < 0);


esApto= promedio>=4.5 ||(promedio>4.0 && ingresoFamiliar<2000000);
Console.WriteLine(" ");
if (esApto)
{
    Console.WriteLine("El estudiantes es apto para la beca.");
}
else
{
    Console.WriteLine("El estudiante no es apto para la beca.");

}
Console.WriteLine("===========================");
Console.ReadKey();