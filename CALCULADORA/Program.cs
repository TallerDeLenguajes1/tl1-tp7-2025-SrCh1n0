using EspacioCalculadora;

Calculadora Calc = new Calculadora();
Console.WriteLine(Calc.Resultado.ToString());
Calc.Sumar(10);
Console.WriteLine(Calc.Resultado.ToString());

Console.WriteLine("Ingrese una opcion: \n" +
                    "0: Mostrar Resultado \n" +
                    "1: Sumar \n" +
                    "2: Restar \n" +
                    "3: Multiplicar \n" +
                    "4: Dividir \n" +
                    "5: Limpiar \n" +
                    "6: Salir");
int opcion = Console.Read();
int valor;
switch (opcion)
{
    case 0:
        Console.WriteLine(Calc.Resultado.ToString());
        break;
    case 1:
        Console.WriteLine("Ingrese un numero para sumar: ");
        valor = Console.Read();
        Calc.Sumar(valor);
        break;
    case 2:
        Console.WriteLine("Ingrese un numero para restar: ");
        valor = Console.Read();
        Calc.Restar(valor);
        break;
    case 3:
        Console.WriteLine("Ingrese un numero para multiplicar: ");
        valor = Console.Read();
        Calc.Multiplicar(valor);
        break;
    case 4:
        Console.WriteLine("Ingrese un numero para dividir: ");
        valor = Console.Read();
        Calc.Dividir(valor);
        break;
    case 5:
        Calc.Limpiar();
        break;
    default:
        break;
}