double peso, longitud, pesoMaximo;
string materialRespuesta, grietasRespuesta;
bool reforzado, tieneGrietas, pesoValido, longitudValida, piezaAprobada;

Console.WriteLine("===========================");
Console.WriteLine("=== APROBACION DE PIEZAS ===");
Console.WriteLine(" ");

do
{
    Console.Write("Ingrese el peso de la pieza en gramos (ejemplo: 155,5): ");
} while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0);

do
{
    Console.Write("Ingrese la longitud de la pieza en cm (ejemplo: 11,5): ");
} while (!double.TryParse(Console.ReadLine(), out longitud) || longitud <= 0);

do
{
    Console.Write("¿Material reforzado? (si/no): ");
    materialRespuesta = Console.ReadLine().ToLower();
} while (materialRespuesta != "si" && materialRespuesta != "no");
reforzado = materialRespuesta == "si";

do
{
    Console.Write("¿Presenta grietas? (si/no): ");
    grietasRespuesta = Console.ReadLine().ToLower();
} while (grietasRespuesta != "si" && grietasRespuesta != "no");
tieneGrietas = grietasRespuesta == "si";

if (reforzado)
{
    pesoMaximo = 180;
}
else
{
    pesoMaximo = 160;
}

pesoValido = peso >= 150 && peso <= pesoMaximo;
longitudValida = longitud < 12;

piezaAprobada = pesoValido && longitudValida && !tieneGrietas;

Console.WriteLine(" ");

if (piezaAprobada)
{
    Console.WriteLine("La pieza fue APROBADA.");
}
else
{
    Console.WriteLine("La pieza fue RECHAZADA.");

    if (tieneGrietas)
    {
        Console.WriteLine("Causa: presenta grietas.");
    }

    if (!pesoValido)
    {
        Console.WriteLine("Causa: peso fuera del rango permitido (maximo " + pesoMaximo + " g).");
    }

    if (!longitudValida)
    {
        Console.WriteLine("Causa: longitud mayor a 12 cm.");
    }
}

Console.WriteLine("===========================");
Console.ReadKey();