Console.Clear();
int tipo, totalVehiculos = 0, motos = 0, carros = 0, camiones = 0, emergencias = 0, vehiculosCobrados = 0;
string horaValleRespuesta, emergenciaRespuesta;
bool horaValle, emergencia;
double tarifa, recaudoTotal = 0, ticketPromedio;

Console.WriteLine("===========================");
Console.WriteLine("=== CAjsA DE PEAJE ===");
Console.WriteLine(" ");

do
{
    do
    {
        Console.Write("Porfavor, ingrese el tipo de vehiculo (1=moto, 2=carro, 3=camion, 0=cerrar turno): ");
    } while (!int.TryParse(Console.ReadLine(), out tipo) || tipo < 0 || tipo > 3);

    if (tipo != 0)
    {
        do
        {
            Console.Write("¿Es hora valle? (si/no): ");
            horaValleRespuesta = Console.ReadLine().ToLower();
        } while (horaValleRespuesta != "si" && horaValleRespuesta != "no");
        horaValle = horaValleRespuesta == "si";

        do
        {
            Console.Write("¿Es vehiculo de emergencia? (si/no): ");
            emergenciaRespuesta = Console.ReadLine().ToLower();
        } while (emergenciaRespuesta != "si" && emergenciaRespuesta != "no");
        emergencia = emergenciaRespuesta == "si";

        totalVehiculos = totalVehiculos + 1;

        if (tipo == 1)
        {
            tarifa = 5000;
            motos = motos + 1;
        }
        else if (tipo == 2)
        {
            tarifa = 10000;
            carros = carros + 1;
        }
        else
        {
            tarifa = 25000;
            camiones = camiones + 1;
        }

        if (emergencia)
        {
            tarifa = 0;
            emergencias = emergencias + 1;
            Console.WriteLine("Vehiculo de emergenscia. Cobro: $0. Puede pasar.");
        }
        else
        {
            if (horaValle)
            {
                tarifa = tarifa - tarifa * 0.20;
            }

            recaudoTotal = recaudoTotal + tarifa;
            vehiculosCobrados = vehiculosCobrados + 1;

            Console.WriteLine("Cobro: $" + tarifa + ". Puede pasar.");
        }

        Console.WriteLine(" ");
    }

} while (tipo != 0);

if (vehiculosCobrados > 0)
{
    ticketPromedio = recaudoTotal / vehiculosCobrados;
}
else
{
    ticketPromedio = 0;
}

Console.WriteLine("===========================");
Console.WriteLine("=== CIERRE DE TURNO ===");
Console.WriteLine("Total de vehiculos atendidos: " + totalVehiculos);
Console.WriteLine("Motos: " + motos);
Console.WriteLine("Carros: " + carros);
Console.WriteLine("Camiones: " + camiones);
Console.WriteLine("Vehiculos de emergencia: " + emergencias);
Console.WriteLine("Recaudo total: $" + recaudoTotal);
Console.WriteLine("Tickeet promedio por vehiculo cobrado: $" + ticketPromedio);
Console.WriteLine("===========================");
Console.ReadKey();