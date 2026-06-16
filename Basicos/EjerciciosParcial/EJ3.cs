using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        int energia = 5;
        int cristales = 0;
        int trampasActivadas = 0;
        int evento;

        while (cristales < 6 && energia > 0)
        {
            Console.Write("Ingresa el numero de un evento (1. cristal , 2. descanso, 3.trampa): ");
            int.TryParse(Console.ReadLine(), out evento);

            if (evento == 1)
            {
                cristales++;

                Console.WriteLine("Cristales Totales: "+cristales);
                Console.WriteLine("Energia Total: "+energia);
                Console.WriteLine("trampas activadas: "+trampasActivadas);
                Console.WriteLine("----------------------------");
            }
            else if (evento == 2&& energia < 5)
            {
                energia++;

                Console.WriteLine("Cristales Totales: "+cristales);
                Console.WriteLine("Energia Total: "+energia);
                Console.WriteLine("trampas activadas: "+trampasActivadas);
                Console.WriteLine("----------------------------");
            }
            else if (evento == 3)
            {
                trampasActivadas++;
                energia--;

                Console.WriteLine("Cristales Totales: "+cristales);
                Console.WriteLine("Energia Total: "+energia);
                Console.WriteLine("trampas activadas: "+trampasActivadas);
                Console.WriteLine("----------------------------");
            }
            if (energia == 5)
            {
                Console.WriteLine("¡tu energia esta al maximo!");

                Console.WriteLine("Cristales Totales: "+cristales);
                Console.WriteLine("Energia Total: "+energia);
                Console.WriteLine("trampas activadas: "+trampasActivadas);
                Console.WriteLine("----------------------------");
            }
        }

        if (cristales == 6 && energia > 0)
        {
            Console.WriteLine("-----------PUNTAJE----------");
            Console.WriteLine("Misión Completada");
            Console.WriteLine("Cristales Totales: "+cristales);
            Console.WriteLine("Energia Total: "+energia);
            Console.WriteLine("trampas activadas: "+trampasActivadas);
            Console.WriteLine("----------------------------");
        }
        else
        {
            Console.WriteLine("-----------PUNTAJE----------");
            Console.WriteLine("Misión Fallida - Perdiste Papu");
            Console.WriteLine("Cristales Totales: "+cristales);
            Console.WriteLine("Energia Total: "+energia);
            Console.WriteLine("trampas activadas: "+trampasActivadas);
            Console.WriteLine("----------------------------");
        }
    }
}