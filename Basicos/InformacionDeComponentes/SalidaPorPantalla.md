## La salida por pantalla: `Console.WriteLine`

Una de las primeras tareas que realiza un programa es comunicar información al usuario. En las aplicaciones de consola, esto se logra mostrando texto directamente en la ventana de ejecución.

Para ello, C# proporciona el método `Console.WriteLine`, cuya función es escribir un mensaje en la consola y posicionar el cursor en la línea siguiente.

Gracias a esta instrucción podemos:

* Mostrar mensajes informativos.
* Visualizar el contenido de variables.
* Comprobar el comportamiento del programa durante su ejecución.
* Presentar resultados al usuario.

### Ejemplo

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inicio del programa");
        Console.WriteLine("Jugador: Ana");
        Console.WriteLine("Vidas: 3");
        Console.WriteLine("Fin del programa");
    }
}
```

### Salida obtenida

```text
Inicio del programa
Jugador: Ana
Vidas: 3
Fin del programa
```

### ¿Cómo funciona?

Cada vez que se ejecuta una instrucción `Console.WriteLine`, el texto indicado entre comillas se muestra en pantalla.

Por ejemplo:

```csharp
Console.WriteLine("Jugador: Ana");
```

produce la siguiente salida:

```text
Jugador: Ana
```

El texto entre comillas recibe el nombre de **cadena de caracteres** (*string*) y representa información textual que el programa mostrará exactamente como fue escrita.

### Ejecución secuencial

Observa que las instrucciones se ejecutan en el mismo orden en que aparecen dentro del método `Main`.

Primero se muestra:

```text
Inicio del programa
```

Luego:

```text
Jugador: Ana
```

Después:

```text
Vidas: 3
```

Y finalmente:

```text
Fin del programa
```

Este comportamiento responde al principio de **ejecución secuencial**, estudiado anteriormente: las instrucciones se ejecutan una tras otra, de arriba hacia abajo.

Más adelante incorporaremos estructuras que permitirán alterar este flujo, como las decisiones (`if`) y los ciclos (`while`, `for`). Sin embargo, por el momento, todos nuestros programas seguirán una secuencia lineal de ejecución.
