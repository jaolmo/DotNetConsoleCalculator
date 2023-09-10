using System;
public static class CalculadoraUI
{
    public static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("*******************************");
        Console.WriteLine("* Bienvenido a la calculadora *");
        Console.WriteLine("*******************************");
        Console.WriteLine("*      Escoge una opción      *");
        Console.WriteLine("*******************************");
        Console.WriteLine("*      1.- Sumar              *");
        Console.WriteLine("*      2.- Restar             *");
        Console.WriteLine("*      3.- Mutiplicar         *");
        Console.WriteLine("*      4.- Dividir            *");
        Console.WriteLine("*      0.- Salir              *");
        Console.WriteLine("*******************************");
    }

    public static string EscogerOperador(string operador)
    {
        return operador switch
        {
            "1" => "+",
            "2" => "-",
            "3" => "*",
            "4" => "/",
            "0" => "S",
            _ => "E"
        };
    }

    public static (int operando1, int operando2) SolicitarOperandos()
    {
        
        Console.Write("Introduce el primer Operando: ");
        var ope1 = Console.ReadLine();
        if (string.IsNullOrEmpty(ope1))
        {
            ope1 = "0";
        }
        int valor1;
        if (!int.TryParse(ope1, out valor1))
        {
            System.Console.WriteLine($"El valor {ope1} no es un numero entero y se asumira 0");
            valor1 = 0;
        }

        Console.Write("Introduce el segundo Operando: ");
        var ope2 = Console.ReadLine();
        if (string.IsNullOrEmpty(ope2))
        {
            ope2 = "0";
        }
        int valor2;
        if (!int.TryParse(ope2, out valor2))
        {
            System.Console.WriteLine($"El valor {ope2} no es un numero entero y se asumira 0");
            valor2 = 0;
        }
        
        return (valor1,valor2);
    }

    public static void MostrarResultado(Operacion operacion)
    {
        System.Console.WriteLine($"El resultado de {operacion.Operando1} {operacion.Operador} {operacion.Operando2} es: {operacion.HacerOperacion()}");
        System.Console.WriteLine("Pulse una tecla para continuar.");
        Console.ReadKey();
    }
}