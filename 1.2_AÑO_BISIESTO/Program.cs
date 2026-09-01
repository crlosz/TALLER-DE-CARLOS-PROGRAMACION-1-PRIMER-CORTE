int anio;

Console.WriteLine("===========================");
Console.WriteLine("=== DETERMINADOR AÑO BISIESTO ===");

do
{
    Console.WriteLine("Ingrese un año para derteminar si es bisiesto: ");
    
}while(!int.TryParse(Console.ReadLine(),out anio)||anio <1583||anio>3000);
if(anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
{
    Console.WriteLine("EL AÑO "+anio+" ES BISIESTO");

}
else
{
    Console.WriteLine("EL AÑO "+anio+" NO ES BISIESTO");

}
Console.ReadKey();




Console.WriteLine("===========================");
