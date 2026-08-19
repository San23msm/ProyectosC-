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
            Console.WriteLine ("Opciones Disponibles (1. Defender oleada, 2. Construir una torre, 3. Recargar la base, 4. Activar defensa final)");
            int Opcion = int.parse (Console.ReadLine ());
            if (Opcion != 1 && 2 && 3 && 4) {
                Console.WirteLine("Opcion no valida :" (""));
            }
            switch (Opcion)
            {
                case 1 : 
                oleadasDefendidas ++; 
                monedas += 3;
                energia -= 2;
                turno ++
                Console.WriteLine("Oleada defendida.");
                break;

                case 2 :
                monedas -= 4;
                torres += 1;
                if (torres <= 2);
                {
                    torres = 2
                }
                turno ++
                Console.WriteLine ("Torre construida.");
                else Console.WirteLine ("Haz alcanzado el número maximo de torres.");
                break

                case 3 :
                energia += 3;
                if (energia > 10);
                {
                    energia = 10;
                }
                turno ++
                Console.WriteLine ("Base recargada");
                break

                case 4 : 
                if (oleadasDefendidas >= 4 && torres >= 2 && energia >= 2);
                {
                    defensaFinalActivada = true;
                    Console.WriteLine ("Defensa activada.")
                }
                else energia --
                Console.WriteLine ("Todavia no podes activar la defensa.")


    

            }


    

        
        
                
    

        }
    }
}