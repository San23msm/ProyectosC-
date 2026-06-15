# DO WHILE + SWITCH

## Objetivo

Desarrollar una aplicación de consola que permita al usuario seleccionar un día de la semana mediante un menú numérico.

El programa valida que la opción ingresada sea correcta utilizando la estructura **DO WHILE** y, posteriormente, determina el día correspondiente mediante la estructura **SWITCH**.

---

# Enunciado

Crear un menú que muestre los días de la semana numerados del 1 al 7 y una opción adicional para salir del programa.

El sistema deberá:

1. Solicitar una opción al usuario.
2. Verificar que el dato ingresado sea numérico.
3. Comprobar que el número se encuentre dentro del rango permitido.
4. Mostrar el día seleccionado.
5. Finalizar la ejecución si el usuario elige la opción **8**.

---

# Estructuras Utilizadas

## DO WHILE

La estructura `do while` pertenece a las estructuras repetitivas.

Su principal característica es que el bloque de código se ejecuta al menos una vez antes de evaluar la condición.

### ¿Por qué se utiliza en este programa?

Porque permite seguir solicitando una opción hasta que el usuario ingrese un valor válido.

### Sintaxis General

```csharp
do
{
    // Instrucciones
}
while(condicion);
```

---

## SWITCH

La estructura `switch` pertenece a las estructuras de selección múltiple.

Permite ejecutar diferentes bloques de código según el valor que contenga una variable.

### ¿Por qué se utiliza en este programa?

Porque cada número del menú representa un día diferente de la semana.

En lugar de utilizar múltiples estructuras `if-else`, el uso de `switch` hace que el código sea más organizado, legible y fácil de mantener.

### Sintaxis General

```csharp
switch(variable)
{
    case valor:
        // Instrucciones
        break;

    default:
        // Instrucciones por defecto
        break;
}
```

---

# Lógica del Programa

```text
Inicio
   │
   ▼
Mostrar menú
   │
   ▼
Ingresar opción
   │
   ▼
¿La opción es válida?
   │
 ┌─┴─┐
 │No │────► Volver a solicitar
 └─┬─┘
   │Sí
   ▼
¿Opción = 8?
   │
 ┌─┴─┐
 │Sí │────► Finalizar programa
 └─┬─┘
   │No
   ▼
Determinar día con SWITCH
   │
   ▼
Mostrar resultado
   │
   ▼
Fin
```

---

# Código Fuente

```csharp
using System;

class Program
{
    static void Main()
    {
        // Variables
        int opcion;
        string nombreDia;

        // Validación de entrada mediante DO WHILE
        do
        {
            Console.Clear();

            Console.WriteLine("====== MENÚ DE DÍAS ======");
            Console.WriteLine("1. Lunes");
            Console.WriteLine("2. Martes");
            Console.WriteLine("3. Miércoles");
            Console.WriteLine("4. Jueves");
            Console.WriteLine("5. Viernes");
            Console.WriteLine("6. Sábado");
            Console.WriteLine("7. Domingo");
            Console.WriteLine("8. Salir");
            Console.WriteLine("==========================");

            Console.Write("Ingrese una opción: ");

        } while (!int.TryParse(Console.ReadLine(), out opcion)
                 || opcion < 1
                 || opcion > 8);

        // Opción de salida
        if (opcion == 8)
        {
            Console.WriteLine("Saliendo del programa...");
            return;
        }

        // Selección del día mediante SWITCH
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
                nombreDia = "Opción no válida";
                break;
        }

        Console.WriteLine($"\nDía seleccionado: {nombreDia}");
    }
}
```

---

# Ejemplo de Ejecución

```text
====== MENÚ DE DÍAS ======

1. Lunes
2. Martes
3. Miércoles
4. Jueves
5. Viernes
6. Sábado
7. Domingo
8. Salir

Ingrese una opción: 3

Día seleccionado: Miércoles
```

---

# Conceptos Aplicados

* Variables.
* Entrada y salida de datos.
* Validación de datos con `TryParse()`.
* Operadores lógicos (`||`).
* Estructuras repetitivas (`DO WHILE`).
* Estructuras de selección (`SWITCH`).
* Uso de `break`.
* Finalización de métodos mediante `return`.

---

# Aprendizajes Obtenidos

Al desarrollar este ejercicio se comprende cómo:

* Validar entradas ingresadas por el usuario.
* Evitar errores producidos por datos incorrectos.
* Crear menús interactivos.
* Relacionar valores numéricos con información textual.
* Combinar estructuras repetitivas y estructuras de selección dentro de un mismo programa.

## Conclusión

La combinación de **DO WHILE** y **SWITCH** permite construir programas más robustos e interactivos. Mientras que `DO WHILE` garantiza que el usuario ingrese una opción válida, `SWITCH` facilita la toma de decisiones cuando existen múltiples alternativas posibles.
