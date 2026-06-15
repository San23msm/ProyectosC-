using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        //Menu de opciones
        Console.WriteLine("______Menú de Dias______");
        Console.WriteLine("1.Lunes");
        Console.WriteLine("2.Martes");
        Console.WriteLine("3.Miercoles");
        Console.WriteLine("4.Jueves");
        Console.WriteLine("5.Viernes");
        Console.WriteLine("6.Sabado");
        Console.WriteLine("7.Domingo");
        Console.WriteLine("_______________________");
        //Ingreso de la opcion
        Console.Write("Ingrese una opcion: ");
        int opcion= int.Parse(Console.ReadLine());
        string nombreDia;
        //Seleccion de la opcion
        switch (opcion)
        {
            case 1:
                nombreDia="Lunes";
                break;
            case 2:
                nombreDia="Martes";
                break;
            case 3:
                nombreDia="Miercoles";
                break;
            case 4:
                nombreDia="Jueves";
                break;
            case 5:
                nombreDia="Viernes";
                break;
            case 6:
                nombreDia="Sabado";
                break;
            case 7:
                nombreDia="Domingo";
                break;
            default:
                nombreDia="Dia Ilegal";
                break;
                
        }
        Console.WriteLine("Opcion elegida: "+nombreDia);
    }
}