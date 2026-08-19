// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

class Program
{
    static void Main()
    {
        //int opciones;
        int energia = 8;
        int gemas = 0;
        int trampas=0;
        int llaves = 0;
        int turnos=0;
        const int Max_turnos_permitidos = 12;
        bool Portal_abierto=false;
        bool Tiene_mapa=false;


        while (turnos < Max_turnos_permitidos && energia > 0 && Portal_abierto==false)
        {
            Estado(energia, gemas, llaves, trampas, turnos, Tiene_mapa, Portal_abierto);
            Console.WriteLine("Elegir Opcion (1: Buscar gema, 2: Explorar Cofre, 3: Descansar, 4: Intentar abrir el portal)");
           int opcion = Convert.ToInt32(Console.ReadLine());
          
            if (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4)
            {
                Console.WriteLine("Opción no válida. Por favor, elige 1, 2, 3 o 4.");
                continue;
            }
          
            switch (opcion)
            {
            case 1:
              gemas+=1;
              energia-=1;
              turnos+=1;
              if(gemas>=5)
              
              {
                  Console.WriteLine("El jugador tiene suficientes gemas para una de las condiciones del portal");
              }
              break;
            case 2:
              turnos+=1;
              energia-=2;
               if(llaves >= 1 && Tiene_mapa == true)
              {
                  trampas+=1;
                  energia-=1;
              }
               if (llaves == 0)
               {
                   llaves += 1;
               }
              else if (llaves >= 1 && Tiene_mapa == false)
              {
              Tiene_mapa=true;
              }
              
              break;
            case 3:
              turnos+=1;
              energia+=2;
              if(energia>8)
              {
                  energia=8;
              }
              break;
            case 4:
              turnos+=1;
              if((gemas>=5 && llaves>=1) || (Tiene_mapa==true && gemas>=3 && energia>0))
              {
                  Console.WriteLine("El portal se abrio");
                  Portal_abierto=true;
              }
              else 
              {
                  Console.WriteLine("Todavia no puedes abrir el portal");
                  energia-=1;
              }
              break;
            }
             
             
        }
        if(Portal_abierto)
        {
            Console.WriteLine(" GANASTE!!");
        }
        if(energia <= 0)
        {
            Console.WriteLine("Te quedaste sin energia. PERDISTE");
        }
        if(turnos >= Max_turnos_permitidos)
        {
            Console.WriteLine("No quedan turnos. PERDISTE");
        }
        Estado(energia, gemas, llaves, trampas, turnos, Tiene_mapa, Portal_abierto);
    }
    static void Estado(int energia, int gemas, int llaves, int trampas, int turnos, bool Tiene_mapa, bool Portal_abierto)
    {
        Console.WriteLine("Estado Actual del jugador");
        Console.WriteLine("Energia: "+ energia);
        Console.WriteLine("Gemas: "+ gemas);
        Console.WriteLine("Llaves: "+ llaves);
        Console.WriteLine("Trampas activadas: "+ trampas);
        Console.WriteLine("Turnos jugados: "+ turnos);
        if(Tiene_mapa)
         {
             Console.WriteLine("Tiene Mapa");
         }
        else{
            Console.WriteLine("No Tiene Mapa");
        }
        if (Portal_abierto)
        {
            Console.WriteLine("El portal esta abierto");
        }
        else {
            Console.WriteLine("El portal esta cerrado");
        }
    }
}
