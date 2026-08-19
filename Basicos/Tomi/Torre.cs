using System;
class Program
{
    static void Main ()
    {
        int energia = 10
        int torres = 0
        int turnosUsados = 0 
        int monedas = 0
        int oleadasDefendidas = 0 

        bool defensaFinalActivada = false

        while (!victoria energia >= 0 || turnosUsados >= 10 || Defensa_final == false)
        {
            Console.WriteLine ("\n============================");
            Console.WriteLine ( "     TORRE DE DEFENSA        ");
            Console.WriteLine ("\n============================");

            Console.WriteLine ("Energia: " + energia);
            Console.WriteLine ("Torres: " + torres);
            Console.WriteLine ("Monedas: " + monedas);
            Console.writeLine ("Oledas Defendidas: " + oleadasDefendidas);
            Console.WirteLine ("Defensa Final Activada: " + defensaFinalActivada);

            Console.WriteLine ("Turnos Usados: " + turnosUsados);

            Console.WriteLine ("\n ¿Que desea hacer el jugador?");
            Console.WirteLine ("1. Defender una oleada");
            Console.WriteLine ("2. Construir una torre");
            Console.WriteLine ("3. Recargar la base");
            Console.WriteLine ("4. Activar defensa final");

            int opcion = Convert.ToInt32 (Console.ReadLine{});
            


            string opcion = Console.ReadLine () ?? "";

            // VALIDACION DE LAS OPCIONES
            if (opcion != 1 &&
                opcion != 2 &&
                opcion != 3 &&
                opcion != 4)
                {
                    Console.WriteLine(
                        "Opcion no válida. Debe elegir 1,2,3 o 4"
                    );
                }
    

        }
    }
}