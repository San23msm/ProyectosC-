# Variables y Tipos de Datos

## ¿Qué es una variable?

Una variable es un espacio de memoria que permite almacenar información para que el programa pueda utilizarla durante su ejecución.

Podemos imaginar una variable como una caja etiquetada donde guardamos un valor. Gracias a esa etiqueta, podemos recuperar o modificar el contenido cuando sea necesario.

Por ejemplo:

* La cantidad de vidas de un jugador.
* El nombre de un personaje.
* La energía disponible.
* La cantidad de monedas obtenidas.
* El estado de una puerta (abierta o cerrada).

Toda esta información puede almacenarse mediante variables.

---

## Relación con la prueba de escritorio

En la Unidad I analizamos algoritmos mediante pruebas de escritorio, observando cómo cambiaban los valores a medida que se ejecutaban las instrucciones.

En C#, esas mismas variables existen dentro del programa y permiten almacenar los datos necesarios para resolver un problema.

Por ejemplo, si durante una prueba de escritorio una variable llamada `vidas` comenzaba con el valor `3` y luego disminuía a `2`, en C# ese comportamiento se representa mediante una variable real que puede modificarse durante la ejecución.

---

## Declaración de una variable

Para crear una variable debemos indicar dos elementos:

1. El tipo de dato que almacenará.
2. El nombre que identificará a la variable.

La estructura general es:

```csharp
tipo nombreVariable;
```

Por ejemplo:

```csharp
int vidas;
```

En este caso:

* `int` indica que la variable almacenará números enteros.
* `vidas` es el nombre de la variable.

---

## Asignación de valores

Una vez creada la variable, podemos almacenar un valor mediante el operador de asignación (`=`).

```csharp
int vidas = 3;
```

Esta instrucción puede leerse como:

> Crear una variable llamada `vidas` y guardar en ella el valor `3`.

El símbolo `=` no representa una igualdad matemática. Su función es indicar que el valor de la derecha será almacenado en la variable situada a la izquierda.

---

## Tipos de datos fundamentales

Cada variable debe indicar qué tipo de información almacenará.

| Tipo     | Descripción           | Ejemplo                    | Aplicación en videojuegos                     |
| -------- | --------------------- | -------------------------- | --------------------------------------------- |
| `int`    | Números enteros       | `int vidas = 3;`           | Vidas, monedas, niveles, enemigos, puntuación |
| `double` | Números con decimales | `double energia = 75.5;`   | Energía, velocidad, daño, precisión           |
| `string` | Texto                 | `string jugador = "Luna";` | Nombres, diálogos, mensajes                   |
| `bool`   | Verdadero o falso     | `bool tieneLlave = false;` | Llaves, puertas, estados, logros              |

---

## Ejemplo completo

```csharp
using System;

class Program
{
    static void Main()
    {
        string jugador = "Ana";
        int vidas = 3;
        int monedas = 10;
        double energia = 75.5;
        bool tieneLlave = false;

        Console.WriteLine("Jugador: " + jugador);
        Console.WriteLine("Vidas: " + vidas);
        Console.WriteLine("Monedas: " + monedas);
        Console.WriteLine("Energía: " + energia);
        Console.WriteLine("Tiene llave: " + tieneLlave);
    }
}
```

---

## Comprendiendo el ejemplo

Observemos algunas de las variables utilizadas:

```csharp
string jugador = "Ana";
```

Almacena el nombre del jugador.

```csharp
int vidas = 3;
```

Guarda la cantidad de vidas disponibles.

```csharp
double energia = 75.5;
```

Representa la energía actual del personaje utilizando un número decimal.

```csharp
bool tieneLlave = false;
```

Indica si el jugador posee una llave. Como solo existen dos posibilidades (sí o no), utilizamos el tipo `bool`.

---

## Resultado en pantalla

Al ejecutar el programa se obtiene:

```text
Jugador: Ana
Vidas: 3
Monedas: 10
Energía: 75.5
Tiene llave: False
```

Cada línea muestra el contenido de una variable. De esta manera podemos visualizar la información almacenada y comprobar que nuestro programa funciona correctamente.

---

## Idea fundamental

Las variables constituyen uno de los pilares de la programación. Permiten representar información del mundo real dentro del programa y sirven como base para realizar cálculos, tomar decisiones y controlar el comportamiento de una aplicación.

Antes de aprender estructuras de control o algoritmos más complejos, es fundamental comprender que un programa trabaja constantemente con datos almacenados en variables.
