int edad;
string embarazoRespuesta, deudaRespuesta, urgenciaRespuesta;
bool embarazada, deudaPendiente, urgenciaVital, citaPrioritaria;

Console.WriteLine("===========================");
Console.WriteLine("=== CITAS MEDICAS ===");
Console.WriteLine(" ");

do
{
    Console.Write("Ingrese su edad: ");
} while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0);

do
{
    Console.Write("¿Está en embarazo? (si/no): ");
    embarazoRespuesta = Console.ReadLine().ToLower();
} while (embarazoRespuesta != "si" && embarazoRespuesta != "no");
embarazada = embarazoRespuesta == "si";

do
{
    Console.Write("¿Tiene deuda pendiente? (si/no): ");
    deudaRespuesta = Console.ReadLine().ToLower();
} while (deudaRespuesta != "si" && deudaRespuesta != "no");
deudaPendiente = deudaRespuesta == "si";

do
{
    Console.Write("¿Es urgencia vital? (si/no): ");
    urgenciaRespuesta = Console.ReadLine().ToLower();
} while (urgenciaRespuesta != "si" && urgenciaRespuesta != "no");
urgenciaVital = urgenciaRespuesta == "si";

citaPrioritaria = (edad > 65 || embarazada || edad < 5) && (!deudaPendiente || urgenciaVital);

Console.WriteLine(" ");

if (citaPrioritaria)
{
    Console.WriteLine("El paciente SI accede a cita prioritaria.");
}
else
{
    Console.WriteLine("El paciente NO accede a cita prioritaria.");
}

Console.WriteLine("===========================");
Console.ReadKey();