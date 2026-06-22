using System;

class Program
{
    static void Main()
    {
        int Energía_inicial = 8;
        int Gemas_iniciales = 0;
        int Llaves_iniciales = 0;
        int Trampas_activadas = 0;
        int Turnos_usados = 0;
        bool Tiene_mapa = false;
        bool Portal_abierto = false;
        int Max_turnos = 12;
        int opcion;

        do
        {
            Console.Clear();
            EstadoActual(Energía_inicial, Gemas_iniciales, Llaves_iniciales, Trampas_activadas, Turnos_usados, Tiene_mapa, Portal_abierto);
            Menu();

            Console.Write("Elija una opcion (1-4): ");
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
                Console.Write("Elija una opcion (1-4): ");
            }

            Turnos_usados++;

            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Gemas_iniciales++;
                    Energía_inicial--;
                    if (Gemas_iniciales >= 5)
                    {
                        Console.WriteLine("El jugador ya tiene suficientes gemas para una de las condiciones del portal.");
                    }
                    break;
                case 2:
                    Energía_inicial = Energía_inicial - 2;
                    if (Llaves_iniciales == 0)
                    {
                        Llaves_iniciales++;
                    }
                    else if (Llaves_iniciales >= 1 && Tiene_mapa == false)
                    {
                        Tiene_mapa = true;
                    }
                    else if (Llaves_iniciales >= 1 && Tiene_mapa == true)
                    {
                        Trampas_activadas++;
                    }
                    break;
                case 3:
                    if (Energía_inicial < 7)
                    {
                        Energía_inicial = Energía_inicial + 2;
                    }
                    else if (Energía_inicial == 7)
                    {
                        Energía_inicial++;
                    }
                    break;
                case 4:
                    if ((Gemas_iniciales >= 5 && Llaves_iniciales >= 1) || (Tiene_mapa && Gemas_iniciales >= 3 && Energía_inicial > 0))
                    {
                        Console.WriteLine("El Portal se ha Abierto");
                        Portal_abierto = true;
                    }
                    else
                    {
                        Console.WriteLine("Todavía no puedes abrir el portal.");
                    }
                    break;
            }
        } while (Portal_abierto == false && Energía_inicial > 0 && Turnos_usados < Max_turnos);

        EstadoActual(Energía_inicial, Gemas_iniciales, Llaves_iniciales, Trampas_activadas, Turnos_usados, Tiene_mapa, Portal_abierto);
    }

    static void EstadoActual(int Energía_inicial, int Gemas_iniciales, int Llaves_iniciales, int Trampas_activadas, int Turnos_usados, bool Tiene_mapa, bool Portal_abierto)
    {
        Console.WriteLine(" ");
        Console.WriteLine("----Estado Actual del Jugador----");
        Console.WriteLine("Energia: " + Energía_inicial);
        Console.WriteLine("Gemas: " + Gemas_iniciales);
        Console.WriteLine("Llaves: " + Llaves_iniciales);
        Console.WriteLine("Trampas Activadas: " + Trampas_activadas);
        Console.WriteLine("Turno: " + Turnos_usados);
        if (Tiene_mapa)
        {
            Console.WriteLine("El Jugador Tiene Mapa");
        }
        else
        {
            Console.WriteLine("El Jugador No Tiene Mapa");
        }
        if (Portal_abierto)
        {
            Console.WriteLine("Portal Abierto");
        }
        else
        {
            Console.WriteLine("Portal Cerrado");
        }
        Console.WriteLine(" ");
    }

    static void Menu()
    {
        Console.WriteLine(" ");
        Console.WriteLine("---------Menú de Opciones--------");
        Console.WriteLine("Elija una opcion (del 1 al 4)");
        Console.WriteLine("1. Buscar Gema");
        Console.WriteLine("2. Explorar Cofre");
        Console.WriteLine("3. Descansar");
        Console.WriteLine("4. Intentar abrir el portal");
        Console.WriteLine("----------------------------------");
    }
}