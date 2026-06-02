using System;
class Program
{
static void Main()
{
    string jugador = "Mateo";
    int vidas = 3;
    int monedas = 15;
    int enemigosDerrotados = 4;
    int puntosExtra = 50;
    int puntajeTotal = monedas + enemigosDerrotados + puntosExtra;
    Console.WriteLine("Resumen de partida");
    Console.WriteLine("Jugador: "  + jugador);
    Console.WriteLine("Vidas: " + vidas);
    Console.WriteLine("Monedas: " + monedas);
    Console.WriteLine("Enemigos derrotados: " + enemigosDerrotados);
    Console.WriteLine("Puntos extra: " + puntosExtra);
    Console.WriteLine("Puntaje total: " + puntajeTotal);
}
}