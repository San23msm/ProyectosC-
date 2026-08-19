using System;

class Program{
    static void Main()
    {
        int energia =10;
        int torres=0;
        int turno=0;
        const int max_turnos=10;
        int monedas=0;
        int oleadasDef=0;
        bool defensaFinalAct= false;

        while(energia>=0 && turno<max_turnos && defensaFinalAct == false)
        {
            Estado(energia,torres, monedas,oleadasDef, defensaFinalAct);
            AccionesDisponibles();
            int opcion = ValidarOpcion();
            if (opcion == -1)
                continue;

            switch(opcion){
                case 1:
                    DefenderOleada(ref oleadasDef,ref monedas,ref energia);
                    turno++;
                    break;
                case 2:
                    ConstruirTorre(ref monedas,ref torres);
                    turno++;
                    break;
                case 3:
                    RecargarBase(ref energia);
                    turno++;
                    break;
                case 4:
                    ActivarDefensa(oleadasDef,torres,ref energia,ref defensaFinalAct);
                    turno++;
                    break;
            }
        }

    }

    static void AccionesDisponibles()
    {
        Console.WriteLine("========================");
        Console.WriteLine("  Acciones Disponibles  ");
        Console.WriteLine("========================");
        Console.WriteLine("Ingrese una opción (del 1 al 4)");
        Console.WriteLine("1. Defender una Oleada");
        Console.WriteLine("2. Construir una Torre");
        Console.WriteLine("3. Recargar Base");
        Console.WriteLine("4. Activar Defensa Final");

    }

    
    static int ValidarOpcion()
    {
        Console.Write("Elija una opcion (1-4): ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion < 1 || opcion > 4)
        {
            Console.WriteLine("Opción no válida. Por favor, elige 1, 2, 3 o 4.");
            return -1;
        }

        return opcion;
    }

    static void DefenderOleada (ref int oleadasDef, ref int monedas, ref int energia)
    {
        oleadasDef++;
        monedas+=3;
        energia+=2;
    }

    static void ConstruirTorre(ref int monedas, ref int torres)
    {
        if (monedas == 4)
        {
            monedas-=4;
            if (torres < 2)
            {
                torres++;
            }
        }
    }

    static void RecargarBase(ref int energia)
    {
        if (energia < 7)
        {
            energia+=3;
        }
        else if (energia == 7)
        {
            energia++;
        }
    }
    
    static void ActivarDefensa(int oleadas, int torres,ref int energia, ref bool activarDefensa)
    {
        if (oleadas>=4 && torres==2 && energia >= 2)
        {
            Console.WriteLine($"Se Activo Defensa");
            activarDefensa=true;
        }
        else
        {
            Console.WriteLine($"Fallo -  No cumple con los requisitos ");
            energia--;
        }
    }

    static void Estado(int energia, int torres, int monedas, int oleadas, bool defensa)
    {
        Console.WriteLine("=======ESTADO=======");
        Console.WriteLine($"Enegia: {energia}");
        Console.WriteLine($"Torres: {torres}");
        Console.WriteLine($"Monedas: {monedas}");
        Console.WriteLine($"Oleadas: {oleadas}");
        if (defensa)
        {
            Console.WriteLine($"Defensa Activada");
        }
        else
        {
            Console.WriteLine($"Defensa Desactivada");
        }
    }

}