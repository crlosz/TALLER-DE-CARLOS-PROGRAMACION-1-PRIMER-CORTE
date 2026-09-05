Console.Clear();
int opcion;
double radio, altura, ladoCuadrado;
double area, perimetro, volumen, areaCirculo, areaCuadrado;

do
{
    Console.WriteLine("===========================");
    Console.WriteLine("=== MENU DE FIGURAS GEOMETRICAS ===");
    Console.WriteLine(" ");
    Console.WriteLine("1. Area y perimetro de un circulo");
    Console.WriteLine("2. Volumen de un cilindro");
    Console.WriteLine("3. Volumen de una esfera");
    Console.WriteLine("4. Comparar area de circulo vs area de cuadrado");
    Console.WriteLine("5. Salir");
    Console.WriteLine(" ");

    do
    {
        Console.Write("Ingrese una opcion (1-5): ");
    } while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5);

    Console.WriteLine(" ");

    switch (opcion)
    {
        case 1:
            do
            {
                Console.Write("Ingrese el radio del circulo: ");
            } while (!double.TryParse(Console.ReadLine(), out radio) || radio <= 0);

            area = Math.PI * radio * radio;
            perimetro = 2 * Math.PI * radio;

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimetro: " + perimetro);
            break;

        case 2:
            do
            {
                Console.Write("Ingrese el radio del cilindro: ");
            } while (!double.TryParse(Console.ReadLine(), out radio) || radio <= 0);

            do
            {
                Console.Write("Ingrese la altura del cilindro: ");
            } while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0);

            volumen = Math.PI * radio * radio * altura;

            Console.WriteLine("Volumen del cilindro: " + volumen);
            break;

        case 3:
            do
            {
                Console.Write("Ingrese el radio de la esfera: ");
            } while (!double.TryParse(Console.ReadLine(), out radio) || radio <= 0);

            volumen = (4.0 / 3.0) * Math.PI * radio * radio * radio;

            Console.WriteLine("Volumen de la esfera: " + volumen);
            break;

        case 4:
            do
            {
                Console.Write("Ingrese el radio del circulo: ");
            } while (!double.TryParse(Console.ReadLine(), out radio) || radio <= 0);

            do
            {
                Console.Write("Ingrese el lado del cuadrado: ");
            } while (!double.TryParse(Console.ReadLine(), out ladoCuadrado) || ladoCuadrado <= 0);

            areaCirculo = Math.PI * radio * radio;
            areaCuadrado = ladoCuadrado * ladoCuadrado;

            Console.WriteLine("Area del circulo: " + areaCirculo);
            Console.WriteLine("Area del cuadrado: " + areaCuadrado);

            if (areaCirculo > areaCuadrado)
            {
                Console.WriteLine("El circulo tiene mayor area.");
            }
            else if (areaCuadrado > areaCirculo)
            {
                Console.WriteLine("El cuadrado tiene mayor area.");
            }
            else
            {
                Console.WriteLine("Ambas figuras tienen la misma area.");
            }
            break;

        case 5:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opcion invalida, intente de nuevo.");
            break;
    }

    Console.WriteLine(" ");
    Console.WriteLine("===========================");
    Console.WriteLine(" ");

} while (opcion != 5);

Console.ReadKey();
