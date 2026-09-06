Console.Clear();
double cantidadDinero,montoBilletes;
int billeteCienMil, billeteCincuentaMil, billeteVeinteMil, billeteDiezMil, billeteCincoMil, billiteDosMil;

Console.WriteLine("===========================");
Console.WriteLine("=== CAJERO AUTOMATICO ===");
do
{
    Console.Write("Porfavor, ingrese una cantidad de dinero: ");
}while(!double.TryParse(Console.ReadLine(), out cantidadDinero)|| cantidadDinero <= 0 );
Console.WriteLine(" ");
montoBilletes=cantidadDinero;
billeteCienMil = (int)(cantidadDinero / 100000);
cantidadDinero %= 100000;

billeteCincuentaMil = (int)(cantidadDinero / 50000);
cantidadDinero %= 50000;

billeteVeinteMil = (int)(cantidadDinero / 20000);
cantidadDinero %= 20000;

billeteDiezMil = (int)(cantidadDinero / 10000);
cantidadDinero %= 10000;

billeteCincoMil = (int)(cantidadDinero / 5000);
cantidadDinero %= 5000;

billiteDosMil = (int)(cantidadDinero / 2000);
cantidadDinero %= 2000;

Console.WriteLine(" ");
Console.WriteLine("==================== ");
Console.WriteLine("=====ENTREGA DE BILLETES=====");
Console.WriteLine("Cuantos biiletes caben de "+ montoBilletes+ " pesos:");
Console.WriteLine();
Console.WriteLine("Billetes de cien mil:                        "+billeteCienMil);
Console.WriteLine("Billetes de cincuenta mil:                   "+billeteCincuentaMil);
Console.WriteLine("Billetes de veinte mil:                      "+billeteVeinteMil);
Console.WriteLine("Billetes de diex mil:                        "+billeteDiezMil);
Console.WriteLine("Billetes de cinco mil:                       "+billeteCincoMil);
Console.WriteLine("Billetes de dos mil:                         "+billiteDosMil);
Console.WriteLine("Residuo quie no se puede pagar en billetes:  "+cantidadDinero);
Console.WriteLine(" ");
Console.WriteLine("===========================");
Console.ReadKey();
