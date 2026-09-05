Console.Clear();
int numero,numeroInvertido=0, digito;
Console.WriteLine("===========================");
Console.WriteLine("=== INVERTIR NUMERO ===");
Console.WriteLine(" ");
do
{
    Console.WriteLine("Por favor, ingrese un numero (10-99): ");

}while(!int.TryParse(Console.ReadLine(), out numero ) || numero < 10 || numero > 99 );

while(numero > 0)
{
digito= numero % 10;
numeroInvertido= numeroInvertido * 10 + digito;
numero = numero / 10;

}
Console.WriteLine(" ");
Console.WriteLine("El numero invertido es: " + numeroInvertido);
Console.WriteLine("===========================");
Console.ReadKey();
