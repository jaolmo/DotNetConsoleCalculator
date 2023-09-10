string opcion="";
do 
{
    var operador = CalculadoraUI.EscogerOperador(opcion!);
    if (!operador.Equals("E") && !operador.Equals("S"))
    {
        (int operando1,int operando2) = CalculadoraUI.SolicitarOperandos();
        Operacion operacion = new Operacion(operando1,operando2,operador);
        CalculadoraUI.MostrarResultado(operacion);
    }
    CalculadoraUI.MostrarMenu();
    opcion = Console.ReadLine()!;
}while (opcion != "0");
