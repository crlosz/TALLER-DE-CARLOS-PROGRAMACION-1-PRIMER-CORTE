Console.Clear();
string nombre;
double horasTrabajadas, valorHora, valorTotal, ibc, retencionFuente, salud, pension, estampillaUpc, estampillaProcultura, estampillaBienestar, estampillaProDesarrollo, estampillaProFronterizo, totalDescuentos, porcentajeDescuento, salarioFinal;

Console.WriteLine("===========================");
Console.WriteLine("=== HONORARIOS CONTRATITA ===");
Console.WriteLine(" ");

Console.Write("Porfavor, ingrese el nombre del contratista: ");
nombre = Console.ReadLine();

do
{
    Console.Write("Porfavor, ingrese las horas trabajadas: ");
} while (!double.TryParse(Console.ReadLine(), out horasTrabajadas) || horasTrabajadas <= 0);

do
{
    Console.Write("Porfavo, ingrese el valor por hora: ");
} while (!double.TryParse(Console.ReadLine(), out valorHora) || valorHora <= 0);

valorTotal = horasTrabajadas * valorHora;
ibc = valorTotal * 0.40;

retencionFuente = valorTotal * 0.11;
salud = ibc * 0.125;
pension = ibc * 0.16;

estampillaUpc = valorTotal * 0.005;
estampillaProcultura = valorTotal * 0.02;
estampillaBienestar = valorTotal * 0.04;
estampillaProDesarrollo = valorTotal * 0.01;
estampillaProFronterizo = valorTotal * 0.015;

totalDescuentos = retencionFuente + salud + pension + estampillaUpc + estampillaProcultura + estampillaBienestar + estampillaProDesarrollo + estampillaProFronterizo;
porcentajeDescuento = (totalDescuentos / valorTotal) * 100;
salarioFinal = valorTotal - totalDescuentos;

Console.WriteLine(" ");
Console.WriteLine("===========================");
Console.WriteLine("=== RECIBO DE DE PAGO ===");
Console.WriteLine("Nombre: " + nombre);
Console.WriteLine(" ");
Console.WriteLine("Valor total: $" + valorTotal);
Console.WriteLine("Ingreso base de cotizacion (IBC): $" + ibc);
Console.WriteLine(" ");
Console.WriteLine("===Descuentos===");
Console.WriteLine("Retencion en la fuente (11% valor total): $" + retencionFuente);
Console.WriteLine("Salud (12.5% IBC): $" + salud);
Console.WriteLine("Pension (16% IBC): $" + pension);
Console.WriteLine("Estampilla UPC (0.5% valor total): $" + estampillaUpc);
Console.WriteLine("Estampilla Procultura (2.0% valor total): $" + estampillaProcultura);
Console.WriteLine("Estampilla Bienestar Adulto Mayor (4.0% valor total): $" + estampillaBienestar);
Console.WriteLine("Estampilla Pro Desarrollo Departamental (1.0% valor total): $" + estampillaProDesarrollo);
Console.WriteLine("Estampilla Pro Desarrollo Fronterizo (1.5% valor total): $" + estampillaProFronterizo);
Console.WriteLine(" ");
Console.WriteLine("Total descuentos: $" + totalDescuentos);
Console.WriteLine("Porcentaje sobre el valor total: " + porcentajeDescuento + "%");
Console.WriteLine(" ");
Console.WriteLine("Salario final: $" + salarioFinal);
Console.WriteLine("===========================");
Console.ReadKey();