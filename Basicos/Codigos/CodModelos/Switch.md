# SWITCH

## Objetivo

Aprender a utilizar la estructura de selección múltiple **SWITCH** para ejecutar diferentes acciones según el valor de una variable.

En este ejercicio, el usuario ingresa un número del 1 al 7 y el programa muestra el día de la semana correspondiente.

---

# ¿Qué es SWITCH?

La estructura `switch` permite comparar una variable contra varios valores posibles.

Cuando encuentra una coincidencia, ejecuta las instrucciones asociadas a ese caso.

Es una alternativa más organizada que utilizar múltiples sentencias `if - else if`.

### Sintaxis General

```csharp
switch(variable)
{
    case valor1:
        // Instrucciones
        break;

    case valor2:
        // Instrucciones
        break;

    default:
        // Instrucciones si no coincide ningún caso
        break;
}
```

---

# ¿Por qué usar SWITCH?

Supongamos que un usuario ingresa un número:

* Si ingresa **1**, queremos mostrar "Lunes".
* Si ingresa **2**, queremos mostrar "Martes".
* Si ingresa **3**, queremos mostrar "Miércoles".
* Y así sucesivamente.

Como existen varias opciones posibles, `switch` permite organizar mejor la toma de decisiones.

---

# Funcionamiento del Programa

1. Se muestra un menú con los días de la semana.
2. El usuario ingresa un número.
3. La variable `opcion` almacena el valor ingresado.
4. El `switch` analiza el contenido de la variable.
5. Si encuentra una coincidencia, asigna el nombre del día a la variable `nombreDia`.
6. Finalmente, se muestra el resultado en pantalla.

---

# Código Fuente

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        // Menú de opciones
        Console.WriteLine("______Menú de Días______");
        Console.WriteLine("1. Lunes");
        Console.WriteLine("2. Martes");
        Console.WriteLine("3. Miércoles");
        Console.WriteLine("4. Jueves");
        Console.WriteLine("5. Viernes");
        Console.WriteLine("6. Sábado");
        Console.WriteLine("7. Domingo");
        Console.WriteLine("________________________");

        // Ingreso de la opción
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        string nombreDia;

        // Selección mediante SWITCH
        switch (opcion)
        {
            case 1:
                nombreDia = "Lunes";
                break;

            case 2:
                nombreDia = "Martes";
                break;

            case 3:
                nombreDia = "Miércoles";
                break;

            case 4:
                nombreDia = "Jueves";
                break;

            case 5:
                nombreDia = "Viernes";
                break;

            case 6:
                nombreDia = "Sábado";
                break;

            case 7:
                nombreDia = "Domingo";
                break;

            default:
                nombreDia = "Día no válido";
                break;
        }

        Console.WriteLine("Opción elegida: " + nombreDia);
    }
}
```

---

# Explicación de los Casos

```csharp
case 1:
    nombreDia = "Lunes";
    break;
```

Si la variable `opcion` vale **1**, se asigna el texto `"Lunes"` a la variable `nombreDia`.

La instrucción `break` finaliza la ejecución del `switch` para evitar que continúe evaluando otros casos.

---

# ¿Qué hace DEFAULT?

```csharp
default:
    nombreDia = "Día no válido";
    break;
```

El bloque `default` se ejecuta cuando el valor ingresado no coincide con ninguno de los casos definidos.

Por ejemplo:

```text
Ingrese una opción: 10

Opción elegida: Día no válido
```

---

# Ejemplo de Ejecución

```text
______Menú de Días______

1. Lunes
2. Martes
3. Miércoles
4. Jueves
5. Viernes
6. Sábado
7. Domingo

Ingrese una opción: 5

Opción elegida: Viernes
```

---

# Conceptos Aprendidos

* Variables.
* Entrada de datos por consola.
* Conversión de datos con `int.Parse()`.
* Estructuras de selección.
* Uso de `switch`.
* Uso de `case`.
* Uso de `break`.
* Uso de `default`.

## Conclusión

La estructura `switch` es una herramienta muy útil cuando una variable puede tomar varios valores posibles. Su uso permite escribir código más limpio, legible y fácil de mantener que una larga cadena de condiciones `if-else`.
