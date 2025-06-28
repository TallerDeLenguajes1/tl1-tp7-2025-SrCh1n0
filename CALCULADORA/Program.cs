using EspacioCalculadora;

Calculadora Calc = new Calculadora();
Console.WriteLine(Calc.Resultado.ToString());
Calc.Sumar(10);
Console.WriteLine(Calc.Resultado.ToString());

int opcion;
int valor;
do
{
    Console.WriteLine("\nIngrese una opcion: \n" +
                    "0: Mostrar Resultado \n" +
                    "1: Sumar \n" +
                    "2: Restar \n" +
                    "3: Multiplicar \n" +
                    "4: Dividir \n" +
                    "5: Limpiar \n" +
                    "6: Salir");
    opcion = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine(opcion);
    switch (opcion)
    {
        case 0:
            Console.WriteLine("\n" + Calc.Resultado.ToString());
            break;
        case 1:
            Console.WriteLine("Ingrese un numero para sumar: ");
            valor = Convert.ToInt32(Console.ReadLine());
            Calc.Sumar(valor);
            break;
        case 2:
            Console.WriteLine("Ingrese un numero para restar: ");
            valor = Convert.ToInt32(Console.ReadLine());
            Calc.Restar(valor);
            break;
        case 3:
            Console.WriteLine("Ingrese un numero para multiplicar: ");
            valor = Convert.ToInt32(Console.ReadLine());
            Calc.Multiplicar(valor);
            break;
        case 4:
            Console.WriteLine("Ingrese un numero para dividir: ");
            valor = Convert.ToInt32(Console.ReadLine());
            Calc.Dividir(valor);
            break;
        case 5:
            Calc.Limpiar();
            break;
        default:
            break;
    }
} while (opcion != 6);