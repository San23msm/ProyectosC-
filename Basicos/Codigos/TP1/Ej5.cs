using System;

class Program
{
    static void Main()
    {
        string jugador = "Luna";
        int monedas = 20;
        int enemigosDerrotados = 15;
        int puntosExtra = 50;

        int puntajeTotal = monedas + enemigosDerrotados + puntosExtra;

        Console.WriteLine("Resumen de partida");
        Console.WriteLine("Jugador: " + jugador);
        Console.WriteLine("Monedas: " + monedas);
        Console.WriteLine("Enemigos derrotados: " + enemigosDerrotados);
        Console.WriteLine("Puntos extra: " + puntosExtra);
        Console.WriteLine("Puntaje total: " + puntajeTotal);
    }
}

// Entradas o datos conocidos:
// Nombre del jugador.
// Cantidad de monedas.
// Cantidad de enemigos derrotados.
// Puntos extra.

// Variables necesarias:
// jugador (string)
// monedas (int)
// enemigosDerrotados (int)
// puntosExtra (int)
// puntajeTotal (int)

// Proceso principal:
// Guardar los datos de la partida.
// Calcular el puntaje total.
// Mostrar el resumen de la partida.

// Salida esperada:
// Jugador: Luna
// Monedas: 20
// Enemigos derrotados: 15
// Puntos extra: 50
// Puntaje total: 85