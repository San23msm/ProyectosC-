using System;
class Program
{
static void Main()
{
    string jugador = "Luna";
    int vidas = 3;
    int monedas = 12;
    double energia = 75.5;
    bool tieneLlave = false;
    Console.WriteLine("Resumen de partida");
    Console.WriteLine("Jugador: "  + jugador);
    Console.WriteLine("Vidas: " + vidas);
    Console.WriteLine("Monedas: " + monedas);
    Console.WriteLine("Energia: " + energia);
    Console.WriteLine("Tiene Llave: " + tieneLlave);
}
}

// 8. ¿Qué variables aparecen?
// Las variables que aparecen son:
// jugador
// vidas
// monedas
// energia
// tieneLlave

// 9. ¿Qué tipo tiene cada variable?
// jugador -> string
// vidas -> int
// monedas -> int
// energia -> double
// tieneLlave -> bool

// 10. ¿Qué valores se muestran en pantalla?
// Jugador: Luna
// Vidas: 3
// Monedas: 12
// Energía: 75.5
// Tiene llave: False

// 11. ¿Qué variable cambiarías para indicar que el jugador encontró la llave?
// Cambiaría la variable tieneLlave.
//
// Antes:
// bool tieneLlave = false;
//
// Después:
// bool tieneLlave = true;
//
// Así se mostrará:
// Tiene llave: True