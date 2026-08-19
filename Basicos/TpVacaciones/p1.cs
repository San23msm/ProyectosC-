using System;

class Program
{
    static void Main()
    {
        int oxigeno=10;
        int energia=6;
        int modulos_reparados=0;
        int tarjetas_acceso=0;
        int turnos=0;
        bool tiene_traje=false;
        bool evacuacion_completada=false;
        int max_turnos=12;

        while (turnos < max_turnos && oxigeno >0 && energia >= 0 && evacuacion_completada == false)
        {
            EstadoActual(oxigeno, energia, modulos_reparados, tarjetas_acceso, turnos, tiene_traje, evacuacion_completada);
            Menu();

            Console.Write("Elija una opcion (1-4): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4)
            {
                Console.WriteLine("Opción no válida. Por favor, elige 1, 2, 3 o 4.");
                continue;
            }


            switch (opcion)
            {
                case 1:
                    modulos_reparados++;
                    energia--;
                    oxigeno--;
                    turnos++;
                    break;
                case 2:
                    energia--;
                    oxigeno--;
                    turnos++;
                    if (tarjetas_acceso == 0)
                    {
                        tarjetas_acceso++;
                    }
                    else if (tarjetas_acceso >= 1 && tiene_traje == false)
                    {
                        tiene_traje = true;
                    }
                    else if (tarjetas_acceso >= 1 && tiene_traje == true)
                    {
                        continue;
                    }
                    break;
                case 3:
                    if (energia < 4)
                    {
                        energia+=2;
                    }
                    else if (energia >= 4 && energia < 6)
                    {
                        energia++;
                    }
                    else if (energia == 6)
                    {
                        Console.WriteLine("La energía ya está al máximo.");
                    }
                    oxigeno--;
                    turnos++;
                    break;
                case 4:
                    if ((modulos_reparados >= 3 && tarjetas_acceso >= 1) || (tiene_traje == true && oxigeno >=3))
                    {
                        evacuacion_completada = true;
                        Console.WriteLine("¡Evacuación completada con éxito!");
                    }
                    else
                    {
                        oxigeno--;
                        Console.WriteLine("No se cumplen las condiciones para evacuar. Siga reparando módulos y obteniendo tarjetas de acceso.");
                    }
                    turnos++;
                    break;
            } 
            if ((turnos>=max_turnos|| oxigeno<0|| energia<0) && evacuacion_completada==false)
            {
                Console.WriteLine(" ");
                Console.WriteLine("¡Has perdido! No lograste evacuar a tiempo.");
                break;
            }
            else if (evacuacion_completada==true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("¡Felicidades! Has completado la evacuación con éxito.");
                break;
            }
        }


    }

    static void Menu()
    {
        Console.WriteLine(" ");
        Console.WriteLine("---------Menú de Opciones--------");
        Console.WriteLine("Elija una opcion (del 1 al 4)");
        Console.WriteLine("1. Reparar módulo");
        Console.WriteLine("2. Buscar tarjeta");
        Console.WriteLine("3. Recargar energía");
        Console.WriteLine("4. Intentar evacuar");
        Console.WriteLine("----------------------------------");
    }

    static void EstadoActual(int oxigeno, int energia, int modulos_reparados, int tarjetas_acceso, int turnos, bool tiene_traje, bool evacuacion_completada)
    {
        Console.WriteLine("Estado actual del jugador:");
        Console.WriteLine($"Oxígeno: {oxigeno}");
        Console.WriteLine($"Energía: {energia}");
        Console.WriteLine($"Módulos reparados: {modulos_reparados}");
        Console.WriteLine($"Tarjetas de acceso: {tarjetas_acceso}");
        Console.WriteLine($"Turnos usados: {turnos}");
        Console.WriteLine($"Tiene traje espacial: {(tiene_traje ? "Sí" : "No")}");
        Console.WriteLine($"Evacuación completada: {(evacuacion_completada ? "Sí" : "No")}");
        Console.WriteLine("----------------------------------");
    }
}