using System;

class Program
{
    static void Main()
    {
        int cristales_rojos = 0;
        int cristales_azules = 0;
        int cristales_combinados = 0;
        int inestabilidad = 0;
        int turnos = 0;
        bool tiene_catalizador = false;
        bool experimento_cerrado = false;
        const int max_turnos = 14;
        const int limite_inestabilidad = 8;

        while (turnos < max_turnos && inestabilidad < limite_inestabilidad && experimento_cerrado == false)
        {
            MostrarEstado(cristales_rojos, cristales_azules, cristales_combinados, inestabilidad, turnos, tiene_catalizador, experimento_cerrado);
            Menu();

            int opcion = ValidarOpcion();
            if (opcion == -1)
                continue;

            ProcesarAccion(opcion, ref cristales_rojos, ref cristales_azules, ref cristales_combinados, ref inestabilidad, ref turnos, ref tiene_catalizador, ref experimento_cerrado);
        }

        MostrarResultadoFinal(turnos, max_turnos, inestabilidad, limite_inestabilidad, experimento_cerrado);
    }

    static void MostrarEstado(int cristales_rojos, int cristales_azules, int cristales_combinados, int inestabilidad, int turnos, bool tiene_catalizador, bool experimento_cerrado)
    {
        Console.WriteLine("Estado actual del experimento:");
        Console.WriteLine($"Cristales rojos: {cristales_rojos}");
        Console.WriteLine($"Cristales azules: {cristales_azules}");
        Console.WriteLine($"Cristales combinados: {cristales_combinados}");
        Console.WriteLine($"Inestabilidad: {inestabilidad}");
        Console.WriteLine($"Turnos transcurridos: {turnos}");
        Console.WriteLine($"Tiene catalizador: {(tiene_catalizador ? "Sí" : "No")}");
        Console.WriteLine($"Experimento cerrado: {(experimento_cerrado ? "Sí" : "No")}");
    }

    static void Menu()
    {
        Console.WriteLine("\nOpciones disponibles:");
        Console.WriteLine("1. Recolectar cristal rojo");
        Console.WriteLine("2. Recolectar cristal azul");
        Console.WriteLine("3. Combinar cristales");
        Console.WriteLine("4. Estabilizar laboratorio");
        Console.WriteLine("5. Buscar catalizador");
        Console.WriteLine("6. Cerrar experimento");
    }

    static int ValidarOpcion()
    {
        Console.Write("Elija una opcion (1-6): ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion < 1 || opcion > 6)
        {
            Console.WriteLine("Opción no válida. Por favor, elige 1, 2, 3, 4, 5 o 6.");
            return -1;
        }

        return opcion;
    }

    static void ProcesarAccion(int opcion, ref int cristales_rojos, ref int cristales_azules, ref int cristales_combinados, ref int inestabilidad, ref int turnos, ref bool tiene_catalizador, ref bool experimento_cerrado)
    {
        switch (opcion)
        {
            case 1:
                cristales_rojos++;
                inestabilidad++;
                turnos++;
                break;
            case 2:
                cristales_azules++;
                inestabilidad++;
                turnos++;
                break;
            case 3:
                if (cristales_rojos >= 1 && cristales_azules >= 1)
                {
                    cristales_combinados++;
                    cristales_rojos--;
                    cristales_azules--;
                    inestabilidad += 2;
                }
                else
                {
                    Console.WriteLine("No tienes suficientes cristales para combinar.");
                }
                turnos++;
                break;
            case 4:
                if (inestabilidad > 0)
                {
                    inestabilidad--;
                    Console.WriteLine("Has estabilizado el laboratorio. La inestabilidad ha disminuido en 1.");
                }
                else
                {
                    Console.WriteLine("La inestabilidad ya está al mínimo.");
                }
                turnos++;
                break;
            case 5:
                if (!tiene_catalizador)
                {
                    tiene_catalizador = true;
                    inestabilidad++;
                }
                else
                {
                    Console.WriteLine("Ya tienes un catalizador.");
                }
                turnos++;
                break;
            case 6:
                if ((cristales_combinados >= 3 && inestabilidad < 8) || (tiene_catalizador && cristales_combinados >= 2 && inestabilidad <= 5))
                {
                    experimento_cerrado = true;
                    Console.WriteLine("¡Experimento cerrado con éxito!");
                }
                else
                {
                    Console.WriteLine("No puedes cerrar el experimento aún.");
                }
                turnos++;
                break;
        }
    }

    static void MostrarResultadoFinal(int turnos, int max_turnos, int inestabilidad, int limite_inestabilidad, bool experimento_cerrado)
    {
        if ((turnos >= max_turnos || inestabilidad >= limite_inestabilidad) && experimento_cerrado == false)
        {
            Console.WriteLine(" ");
            Console.WriteLine("¡Has perdido! No lograste cerrar el experimento a tiempo o la inestabilidad fue demasiado alta.");
        }
    }
}