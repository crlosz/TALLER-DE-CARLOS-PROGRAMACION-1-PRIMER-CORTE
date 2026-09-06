Console.Clear();
double montoUsd, tasa, montoConvertido, comision, montoNeto, montoEntregado, residuo;

Console.WriteLine("===========================");
Console.WriteLine("=== CONVERSION DE MONEDAS ===");
Console.WriteLine(" ");

do
{
    Console.Write("Porfavor, ingrese el monto en USD a convertir: ");
} while (!double.TryParse(Console.ReadLine(), out montoUsd) || montoUsd <= 0);

tasa = 3950;

montoConvertido = montoUsd * tasa;
comision = montoConvertido * 0.02;
montoNeto = montoConvertido - comision;

montoEntregado = (int)(montoNeto / 1000) * 1000;
residuo = montoNeto - montoEntregado;

Console.WriteLine(" ");
Console.WriteLine("===========================");
Console.WriteLine("=== RESULTADO DE LA CONVERSION ===");
Console.WriteLine("Monto convertido: $" + montoConvertido);
Console.WriteLine("Comision 2%: $" + comision);
Console.WriteLine("Monto neto exacto: $" + montoNeto);
Console.WriteLine("Monto entregado en billetes de 100 : $" + montoEntregado);
Console.WriteLine("Residuo a favor de la casa de cambio: $" + residuo);
Console.WriteLine("===========================");
Console.ReadKey();