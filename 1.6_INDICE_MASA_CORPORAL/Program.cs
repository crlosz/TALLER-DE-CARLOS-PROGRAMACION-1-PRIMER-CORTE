double peso, altura, imc;
bool esNormal;

Console.WriteLine("===========================");
Console.WriteLine("=== CALCULADORA DE IMC ===");
Console.WriteLine(" ");

do
{
    Console.Write("Ingrese su peso en kg (ejemplo: 70,5): ");
} while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0);

do
{
    Console.Write("Ingrese su altura en metros (ejemplo: 1,75): ");
} while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0);

imc = peso / (altura * altura);

imc = (int)(imc * 100) / 100.0;


esNormal = imc >= 18.5 && imc < 25.0;

Console.WriteLine(" ");
Console.WriteLine("Tu IMC es: " + imc);

if (esNormal)
{
    Console.WriteLine("Tu peso se encuentra en el rango NORMAL.");
}
else
{
    Console.WriteLine("Tu peso no se encuentra en el rango normaal");
}

Console.WriteLine("===========================");
Console.ReadKey();
