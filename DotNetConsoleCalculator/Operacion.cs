public class Operacion
{
    public int Operando1 {get; set;}
    public int Operando2 { get; set; }
    public string Operador { get; set; }
    private int Resultado {get; set;}

    public Operacion() 
    {
        Operando1 = 0;
        Operando2 = 0;
        Operador  ="+";
    }

    public Operacion(int operando1, int operando2)
    {
        Operando1 = operando1;
        Operando2 = operando2;
        Operador ="+";
    }

    public Operacion(int operando1, int operando2, string operador)
    {
        Operando1 = operando1;
        Operando2 = operando2;
        Operador = operador;
    }

    public int HacerOperacion() 
    {
        return Resultado = Operador switch
        {
            "+" => Operando1 + Operando2,
            "-" => Operando1 - Operando2,
            "*" => Operando1 * Operando2,
            "/" => Operando1 / Operando2,
            _ => Operando1 + Operando2
        };
    }
}