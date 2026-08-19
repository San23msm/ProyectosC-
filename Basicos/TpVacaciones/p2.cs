using System;

class Program
{
    static void Main()
    {
        int Vida = 12;
        int energia = 5;
        int enemigos_derrotados = 0;
        int pociones = 1;
        int turnos = 0;
        const int Max_turnos_permitidos = 10;
        bool habilidad_especial_disponible = true;
        bool victoria = false;

        while (turnos < Max_turnos_permitidos && Vida > 0 && energia >= 0 && victoria == false)
        {
            EstadoActual(Vida, energia, enemigos_derrotados, pociones, turnos, habilidad_especial_disponible, victoria);
            Menu();

            Console.Write("Elija una opcion (1-5): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4 && opcion != 5)
            {
                Console.WriteLine("Opción no válida. Por favor, elige 1, 2, 3, 4 o 5.");
                continue;
            }

            

            switch (opcion)
            {
                case 1:
                    enemigos_derrotados++;
                    energia--;
                    Vida--;
                    turnos++;
                    break;
                case 2:
                    if (habilidad_especial_disponible && energia >= 3)
                    {
                        enemigos_derrotados += 2;
                        energia -= 3;
                        habilidad_especial_disponible = false;
                    }
                    else
                    {
                        energia--;
                        Console.WriteLine("La habilidad especial ya fue utilizada.");
                    }
                    turnos++;
                    break;
                case 3:
                    if (pociones > 0)
                    {
                        if (Vida < 12)
                        {
                            Vida += 3;
                            if (Vida > 12)
                            {
                                Vida = 12; 
                            }
                        }
                        else
                        {
                            Console.WriteLine("La vida ya está al máximo.");
                        } 
                        pociones--;
                    }
                    else
                    {
                        Console.WriteLine("No tienes pociones disponibles.");
                    }
                    turnos++;
                    break;
                case 4:
                    if (energia < 5)
                    {
                        energia+=2;
                        if (energia > 5)
                        {
                            energia = 5; 
                        }
                    }
                    else
                    {
                        Console.WriteLine("La energía ya está al máximo.");
                    }
                    Vida--;
                    turnos++;
                    break;
                case 5:
                    if ((enemigos_derrotados >= 5 && energia >0 )|| (enemigos_derrotados >= 4 && habilidad_especial_disponible == false))
                    {
                        victoria = true;
                        Console.WriteLine("¡Has ganado la partida!");
                    }
                    else
                    {
                        Console.WriteLine("No se cumplen las condiciones para ganar. Sigue derrotando enemigos y gestionando tu energía.");
                        Vida-=2;
                    }
                    turnos++;
                    break;
            }
        }
        if ((turnos  > Max_turnos_permitidos || Vida <= 0) && victoria == false)
        {
            Console.WriteLine("El jugador a sido derrotado");
        }

    }

    static void EstadoActual(int Vida, int energia, int enemigos_derrotados, int pociones, int turnos, bool habilidad_especial_disponible, bool victoria)
    {
        Console.WriteLine("Estado actual del jugador:");
        Console.WriteLine($"Vida: {Vida}");
        Console.WriteLine($"Energía: {energia}");
        Console.WriteLine($"Enemigos derrotados: {enemigos_derrotados}");
        Console.WriteLine($"Pociones: {pociones}");
        Console.WriteLine($"Turnos usados: {turnos}");
        Console.WriteLine($"Habilidad especial disponible: {(habilidad_especial_disponible ? "Sí" : "No")}");
        Console.WriteLine($"Victoria: {(victoria ? "Sí" : "No")}");
    }

    static void Menu()
    {
        Console.WriteLine("Opciones disponibles:");
        Console.WriteLine("1. Atacar basico");
        Console.WriteLine("2. Habilidad especial");
        Console.WriteLine("3. Usar pocion");
        Console.WriteLine("4. Recuperar energia");
        Console.WriteLine("5. Intentar salir victorioso");
    }
}