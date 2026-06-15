using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        //Tipos de Datos - Asignacion
        List<string> diasElegidos= new List<string>();
        int opcion;

        //Ingreso de la opcion Implementando DO WHILE
        do
        {
            Console.Clear();
            //Menu de opciones
            Console.WriteLine("______Menú de Dias______");
            Console.WriteLine("1. Agregar Lunes");
            Console.WriteLine("2. Agregar Martes");
            Console.WriteLine("3. Agregar Miercoles");
            Console.WriteLine("4. Agregar Jueves");
            Console.WriteLine("5. Agregar Viernes");
            Console.WriteLine("6. Agregar Sabado");
            Console.WriteLine("7. Agregar Domingo");
            Console.WriteLine("8. Nostrar Lista");
            Console.WriteLine("0. Salir del Menú");
            Console.WriteLine("_______________________");
            Console.Write("Ingrese una opcion: ");
        while (!int.TryParse(Console.ReadLine(), out opcion)||(opcion<0)||(opcion>8))
            {
                Console.Write("Opcion Invalida. Ingresa del 0 al 8: ");
            }

                    //Seleccion de la opcion
        switch (opcion)
        {
            case 1:
                diasElegidos.Add("Lunes");
                Console.WriteLine("Agregado");
                break;
            case 2:
                diasElegidos.Add("Martes");
                Console.WriteLine("Agregado");
                break;
            case 3:
                diasElegidos.Add("Miercoles");
                Console.WriteLine("Agregado");
                break;
            case 4:
                diasElegidos.Add("Jueves");
                Console.WriteLine("Agregado");
                break;
            case 5:
                diasElegidos.Add("Viernes");
                Console.WriteLine("Agregado");
                break;
            case 6:
                diasElegidos.Add("Sabado");
                Console.WriteLine("Agregado");
                break;
            case 7:
                diasElegidos.Add("Domingo");
                Console.WriteLine("Agregado");
                break;
            case 8:
                MostrarDias(diasElegidos);
                break;
            case 0:
                Console.WriteLine("Saliendo.....");
                break;

                
        } 
        if (opcion != 0)
            {
                Console.WriteLine("Presione tecla para continuar.....");
                Console.ReadKey();
            }
        }while(opcion!=0);

    }

    static void MostrarDias(List<string> lista)
    {
        Console.WriteLine("---Tu Lista---");
        if (lista.Count == 0)
        {
            Console.WriteLine("Vacia");

        }
        else
        {
            foreach(string dia in lista)
            {
                Console.WriteLine(" - "+dia);
            }
        }
    }
}