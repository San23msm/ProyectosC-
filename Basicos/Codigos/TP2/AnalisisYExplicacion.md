# Análisis y Explicación del Código: Guardián del Portal

## Introducción

Este programa fue desarrollado en C# y simula un pequeño juego de aventura en consola. El jugador debe reunir recursos y cumplir ciertas condiciones para abrir un portal antes de quedarse sin energía o agotar el número máximo de turnos.

Durante la partida, el usuario puede realizar diferentes acciones, como buscar gemas, explorar cofres, descansar o intentar abrir el portal.

---

# 1. Inclusión de Bibliotecas

```csharp
using System;
```

## Explicación

La instrucción `using System` permite utilizar funcionalidades básicas del lenguaje C#, como:

* `Console.WriteLine()`
* `Console.ReadLine()`
* `Console.Clear()`
* Tipos de datos básicos

Sin esta biblioteca, el programa no podría interactuar con la consola.

---

# 2. Clase Principal

```csharp
class Program
```

## Explicación

Toda aplicación en C# debe estar contenida dentro de una clase.

La clase `Program` funciona como contenedor principal del programa y contiene todos los métodos utilizados durante la ejecución.

---

# 3. Método Main()

```csharp
static void Main()
```

## Explicación

El método `Main()` es el punto de entrada del programa.

Cuando se ejecuta la aplicación, el sistema operativo busca este método y comienza a ejecutar las instrucciones desde allí.

---

# 4. Declaración de Variables

## Energía

```csharp
int Energía_inicial = 8;
```

Representa la cantidad de energía disponible para el jugador.

* Cada acción consume energía.
* Si la energía llega a 0, el juego termina.

---

## Gemas

```csharp
int Gemas_iniciales = 0;
```

Almacena la cantidad de gemas obtenidas.

Las gemas son necesarias para abrir el portal.

---

## Llaves

```csharp
int Llaves_iniciales = 0;
```

Indica cuántas llaves posee el jugador.

Las llaves son uno de los requisitos para abrir el portal.

---

## Trampas Activadas

```csharp
int Trampas_activadas = 0;
```

Cuenta cuántas trampas fueron activadas durante la exploración.

Sirve como estadística del juego.

---

## Turnos Utilizados

```csharp
int Turnos_usados = 0;
```

Registra la cantidad de acciones realizadas por el jugador.

Cada vuelta del ciclo representa un turno.

---

## Posee Mapa

```csharp
bool Tiene_mapa = false;
```

Variable booleana.

Puede tener dos valores:

* `true`
* `false`

Permite saber si el jugador encontró el mapa.

Inicialmente comienza en `false`.

---

## Estado del Portal

```csharp
bool Portal_abierto = false;
```

Indica si el portal fue abierto.

Mientras sea `false`, el juego continúa.

---

## Máximo de Turnos

```csharp
int Max_turnos = 12;
```

Define el límite máximo permitido de turnos.

Si se alcanza este valor, el juego finaliza.

---

## Opción del Menú

```csharp
int opcion;
```

Almacena la opción elegida por el usuario en cada turno.

---

# 5. Estructura Repetitiva DO-WHILE

```csharp
do
{
   ...
}
while(...);
```

## ¿Por qué se utiliza?

El ciclo `do-while` garantiza que el menú se muestre al menos una vez.

Primero ejecuta el bloque y luego evalúa la condición.

Esto es ideal para menús interactivos.

---

# 6. Incremento de Turnos

```csharp
Turnos_usados++;
```

## Explicación

Cada vez que el jugador realiza una acción:

* Se incrementa el contador de turnos.
* Permite controlar el límite máximo de movimientos.

---

# 7. Mostrar Estado del Jugador

```csharp
EstadoActual(...);
```

## Función

Muestra información importante:

* Energía
* Gemas
* Llaves
* Trampas
* Turnos
* Estado del mapa
* Estado del portal

Esto ayuda al jugador a tomar decisiones.

---

# 8. Mostrar Menú

```csharp
Menu();
```

## Función

Presenta las acciones disponibles:

1. Buscar gema
2. Explorar cofre
3. Descansar
4. Abrir portal

---

# 9. Lectura de Datos

```csharp
int.TryParse(Console.ReadLine(), out opcion);
```

## ¿Por qué se usa TryParse?

Permite convertir texto a número.

Ventaja:

Si el usuario escribe letras o símbolos, el programa no se detiene con un error.

Ejemplo:

```text
Entrada: abc
Resultado: opcion = 0
```

---

# 10. Estructura SWITCH

```csharp
switch(opcion)
```

## Explicación

Permite ejecutar distintas acciones según la opción elegida.

Es una alternativa más organizada que múltiples `if`.

---

# Caso 1: Buscar Gema

```csharp
case 1:
```

## Acciones

```csharp
Gemas_iniciales++;
```

Obtiene una gema.

```csharp
Energía_inicial--;
```

Consume una unidad de energía.

---

## Verificación

```csharp
if (Gemas_iniciales >= 5)
```

Comprueba si el jugador ya posee suficientes gemas para cumplir uno de los requisitos del portal.

---

# Caso 2: Explorar Cofre

```csharp
case 2:
```

## Consumo de Energía

```csharp
Energía_inicial = Energía_inicial - 2;
```

Explorar es más costoso que buscar gemas.

---

## Primera Exploración

```csharp
if (Llaves_iniciales == 0)
```

Obtiene una llave.

---

## Segunda Exploración

```csharp
else if (Llaves_iniciales >= 1 && Tiene_mapa == false)
```

Obtiene un mapa.

---

## Exploraciones Posteriores

```csharp
else if (Llaves_iniciales >= 1 && Tiene_mapa == true)
```

Activa trampas.

```csharp
Trampas_activadas++;
```

---

# Caso 3: Descansar

```csharp
case 3:
```

## Recuperación de Energía

```csharp
if (Energía_inicial < 8)
```

Impide superar el valor máximo de energía.

Luego:

```csharp
Energía_inicial += 2;
```

Recupera energía.

---

# Caso 4: Abrir Portal

```csharp
case 4:
```

## Primera Condición

```csharp
Gemas_iniciales >= 5 && Llaves_iniciales >= 1
```

Se necesitan:

* 5 gemas
* 1 llave

---

## Segunda Condición

```csharp
Tiene_mapa &&
Gemas_iniciales >= 3 &&
Energía_inicial > 0
```

Se necesitan:

* Mapa
* 3 gemas
* Energía disponible

---

## Apertura

```csharp
Portal_abierto = true;
```

Cuando alguna condición se cumple.

---

# 11. Condición de Finalización

```csharp
while(
Portal_abierto == false &&
Energía_inicial > 0 &&
Turnos_usados < Max_turnos
);
```

## El juego continúa mientras:

* El portal permanezca cerrado.
* Exista energía.
* No se alcance el máximo de turnos.

---

## El juego termina cuando:

* El portal se abre.
* La energía llega a 0.
* Se usan los 12 turnos.

---

# 12. Método EstadoActual()

```csharp
static void EstadoActual(...)
```

## Objetivo

Mostrar toda la información relevante del jugador.

Utiliza múltiples instrucciones:

```csharp
Console.WriteLine();
```

para imprimir datos en pantalla.

---

## Uso de IF

Ejemplo:

```csharp
if (Tiene_mapa)
```

Permite mostrar mensajes diferentes según el estado del jugador.

---

# 13. Método Menu()

```csharp
static void Menu()
```

## Objetivo

Centralizar el menú en un único método.

Ventajas:

* Código más limpio.
* Fácil mantenimiento.
* Permite reutilización.

---

# Conceptos de Programación Aplicados

Durante el desarrollo de este programa se utilizan los siguientes conceptos fundamentales:

## Variables

Almacenan información del juego.

## Tipos de Datos

* `int`
* `bool`

## Operadores

* `+`
* `-`
* `>=`
* `==`
* `&&`
* `||`

## Estructuras Condicionales

* `if`
* `else if`
* `else`
* `switch`

## Estructuras Repetitivas

* `do-while`

## Métodos

* `Main()`
* `EstadoActual()`
* `Menu()`

## Entrada y Salida de Datos

* `Console.ReadLine()`
* `Console.WriteLine()`

---

# Conclusión

Este programa implementa un sistema simple de gestión de recursos mediante energía, gemas, llaves y mapas. A través del uso de estructuras condicionales, ciclos repetitivos y métodos, se crea una experiencia interactiva donde el jugador debe administrar sus recursos para cumplir las condiciones necesarias y abrir el portal antes de quedarse sin energía o agotar los turnos disponibles.
