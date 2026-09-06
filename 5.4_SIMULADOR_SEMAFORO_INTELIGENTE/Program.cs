Console.Clear();
string carroEnARespuesta, carroEnBRespuesta, botonPeatonRespuesta;
bool carroEnA, catroEnB, botonPeaton;
string estadoSemaforo, reglaAplicada;

Console.WriteLine("===========================");
Console.WriteLine("=== SEMAFORO INTELIGENTE ===");
Console.WriteLine(" ");

do
{
    Console.Write("¿Hay carro en la calle A? (si/no): ");
    carroEnARespuesta = Console.ReadLine().ToLower();
} while (carroEnARespuesta != "si" && carroEnARespuesta != "no");
carroEnA = carroEnARespuesta == "si";

do
{
    Console.Write("¿Hayy carro en la calle B? (si/no): ");
    carroEnBRespuesta = Console.ReadLine().ToLower();
} while (carroEnBRespuesta != "si" && carroEnBRespuesta != "no");
catroEnB = carroEnBRespuesta == "si";

do
{
    Console.Write("se presiono el boton de peatones? (si/no): ");
    botonPeatonRespuesta = Console.ReadLine().ToLower();
} while (botonPeatonRespuesta != "si" && botonPeatonRespuesta != "no");
botonPeaton = botonPeatonRespuesta == "si";

if (botonPeaton && catroEnB)
{
    estadoSemaforo = "ROJO";
    reglaAplicada = "Regla 1: boton de peatones presionado y hay carros en B";
}
else if (carroEnA)
{
    estadoSemaforo = "VERDE";
    reglaAplicada = "Regla 2: hay carros en A";
}
else if (!carroEnA && !catroEnB)
{
    estadoSemaforo = "VERDE";
    reglaAplicada = "Regla 3: no hay carros en ninguna calle (estado por defecto)";
}
else
{
    estadoSemaforo = "ROJO";
    reglaAplicada = "Regla 4: cualquier otro caso";
}

Console.WriteLine(" ");
Console.WriteLine("===========================");
Console.WriteLine("Estado del semaforo A: " + estadoSemaforo);
Console.WriteLine("Regla que lo determimno: " + reglaAplicada);
Console.WriteLine("===========================");
Console.ReadKey();