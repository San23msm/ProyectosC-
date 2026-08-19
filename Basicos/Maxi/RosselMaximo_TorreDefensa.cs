using System;

class Program{
    static void Main(){
        int Energia = 10;
        int Torres = 0;
        int Monedas = 0;
        int Oleadas_defendidas = 0;
        bool Defensa_activada = false;
        int Turnos =0;
        int Turnos_max = 10;

        while(Turnos<Turnos_max && Energia>0 && Defensa_activada == false)
        {
            Estado(Energia,Torres,Monedas,Oleadas_defendidas,Turnos,Defensa_activada);
            Console.write("Opciones disponibles(1.Defender oleada , 2.Costruir una torre , 3.Recargar la base , 4.Activar defensa final):");
            int Opcion = int.parse(Console.Readline());
            if (Opcion!=1 && 2 && 3 && 4){
                Console.Writeline("Opcion no valida >:[");
            }
            switch (Opcion)
            {
             case 1:
                Oleadas_defendidas++;
                Monedas+=3;
                Energia-=2;
                Turnos++;
                break;

             case 2:
                if (Monedas>= 4);
                Monedas-=4;
                if (Torres < 2)
                    {
                        Torres++;
                    }
                    else
                    {
                      Console.Writeline("Maximo de torres alcanzado");  
                    }
                Turnos++;
                break;

             case 3:
                Energia+=3;
                if(Energia> 10)
                    {
                        Energia=10;
                    }
                Turnos++;
                break;

             case 4:
                if(Oleadas_defendidas>=4 && Torres==2 && Energia >= 2)
                    {
                        Defensa_activada==true;
                    }
                    else
                    {
                        Console.Writeline("No cumple con los requisitos");
                        Energia--;
                    }
                Turnos++;
                break;


            }
        }
        if (Defensa_activada == true)
        {
            Console.Writeline("Gasnaste :D");
        }
        if (Energia == 0)
        {
            Console.Writeline("Perdiste");
            Console.Writeline("Te quedaste sin egergia :C");
        }
        if (Turnos == Turnos_max)
        {
            Console.Writeline("Persiste");
            Console.Writeline("Te quedaste sin turnos :c");
        }
    }
    static void Estado(int Energia , int Torres , int Monedas , int Oleadas_defendidas , int Turnos , bool Defensa_activada)
{
    Console.Writeline("Energia:"+Energia);
    Console.Writeline("Torres:"+Torres);
    Console.Writeline("Monedas:"+Monedas);
    Console.Writeline("Oledas defendidas:"+Oleadas_defendidas);
    Console.Writeline("Turnos:"+Turnos);
    if(Defensa_activada== true)
        {
            Console.Writeline("Defensa final activada");
            Console.Writeline("Yipiee");
        }
        else
        {
            Console.Writeline("Defensa final no activada");
            Console.Writeline("whomp whomp");
        }
}
}

