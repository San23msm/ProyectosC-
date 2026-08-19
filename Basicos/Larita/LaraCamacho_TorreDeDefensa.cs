using System;

class Program
{
    static void main()
    {
        int energia = 10;
        int torres = 0 ;
        int turnos = 0;
        int monedas = 0;
        int oleadas_defendidas = 0;
        bool Defensa_final = false;

        while(turnos < 10 && energia >= 0 && Defensa_final == false){
            Estado(energia, torres, turnos, monedas, oleadas_defendidas, Defensa_final);
            Console.WriteLine( "Elegir Opcion (1: Defender una Oleada, 2: Construir una Torre, 3: Recargar la Base, 4: Activar Defensa Final)");
            int opcion = Convert.ToInt32(Console.RedLine());
            if (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4){
                Console.WriteLine("Opcion no Valida. Elige 1, 2, 3 o 4");
            }
            switch (opcion)
            {
                case 1:
                 oleadas_defendidas ++;
                 monedas += 3;
                 energia -= 2;
                 turnos ++;
                break;
                
                case 2:
                 turnos ++;
                 if(monedas >= 4)
                    {
                        monedas -= 4;
                        torres ++;
                        if(torres > 2)
                        {
                            torres = 2;
                        }
                    }
                break;

                case 3:
                 turnos ++;
                 energia += 3;
                 if(energia > 10)
                    {
                        energia = 10;
                    }
                break;

                case 4:
                 turnos ++;
                 if(oleadas_defendidas >= 4 && torres == 2 && energia >= 2)
                    {
                        Defensa_final = true;
                    }
                    else
                    {
                        energia --;
                    }
                break;
            }

        }
        if (Defensa_final)
        {
            Console.WriteLine("GANASTE!!");
        }
        if(energia < 0)
        {
            Console.WriteLine("Te quedaste sin energia. PERDISTE!!");
        }
        if(turnos > 10)
        {
            Console.WriteLine("Superaste los turnos permitidos. PERDISTE!!");
        }
        Estado(energia, torres, turnos, monedas, oleadas_defendidas, Defensa_final);
}
static void Estado (int energia, int torres, int turnos, int monedas, int oleadas_defendidas, bool Defensa_final)
    {
        Console.WriteLine("Estado Actual del jugador");
        Console.WriteLine("Energia: " + energia);
        Console.WriteLine("Torres Construidas: " + torres);
        Console.WriteLine("Turnos Usados: " + turnos);
        Console.WriteLine("Monedas: " + monedas);
        Console.WriteLine("Oleadas Defendidas: " + oleadas_defendidas);
        if (Defensa_final)
        {
            Console.WriteLine("Defensa Final Activada");
        }
        else
        {
            Console.WriteLine("NO se activo la defensa final");
        }
     }
}