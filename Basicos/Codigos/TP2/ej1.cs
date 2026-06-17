using System;

class program
{
    static void Main()
    {
        Console Clear();

        int Energia = 8;
        int Gemas = 0;
        int Llaves = 0;
        int Trampas = 0;
        int Turnos = 12;
        bool mapa = false;
        bool portal = false;
        int TurnosPermitidos = 12;
        int Evento;

        while (portal==false && Engergia<0 && Turnos < 0)
        {
            Console.WriteLine("(Evento Buscar gema = 1)");
            Console.WriteLine("(Evento Explorar cofre = 2)");
            Console.WriteLine("(Evento Descansar = 3)");
            Console.WriteLine("(Evento Intentar abrir el portal = 4)");
            Console.WriteLine("Ingrese un numero de evento: ");
            int.TryParse(Console.ReadLine(), out Evento);

            if (Evento == 1)
            {
                
            }
            
        }

    }
}