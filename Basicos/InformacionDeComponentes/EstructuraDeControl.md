# Estructuras de Control

Hasta este momento, todos los programas que hemos desarrollado se ejecutan de manera secuencial: cada instrucción se realiza una después de la otra, siguiendo el orden en que fueron escritas.

Sin embargo, la mayoría de los problemas reales requieren que un programa pueda:

* Tomar decisiones.
* Repetir acciones.
* Ejecutar diferentes caminos según una condición.

Para lograrlo, C# proporciona las **estructuras de control**.

Las estructuras de control permiten modificar el flujo normal de ejecución de un programa.

---

# Tipos de Estructuras de Control

Existen tres grandes categorías:

| Tipo         | Propósito                        |
| ------------ | -------------------------------- |
| Secuenciales | Ejecutan instrucciones en orden. |
| Selectivas   | Permiten tomar decisiones.       |
| Repetitivas  | Permiten repetir instrucciones.  |

---

# Estructuras Secuenciales

Son las que hemos utilizado hasta ahora.

Las instrucciones se ejecutan una tras otra.

```csharp
Console.WriteLine("Inicio");
Console.WriteLine("Jugador");
Console.WriteLine("Fin");
```

Salida:

```text
Inicio
Jugador
Fin
```

El flujo avanza de arriba hacia abajo sin interrupciones.

---

# Estructuras Selectivas

Permiten que el programa tome decisiones.

La decisión se basa en una condición cuyo resultado puede ser:

* Verdadero (`true`)
* Falso (`false`)

La estructura selectiva más utilizada es `if`.

## Sintaxis

```csharp
if (condicion)
{
    // instrucciones
}
```

---

## Ejemplo

```csharp
int vidas = 3;

if (vidas > 0)
{
    Console.WriteLine("El jugador sigue vivo");
}
```

Salida:

```text
El jugador sigue vivo
```

La condición:

```csharp
vidas > 0
```

produce un valor booleano (`true` o `false`).

Como la condición es verdadera, el bloque se ejecuta.

---

## if - else

También podemos indicar qué hacer cuando la condición no se cumple.

```csharp
int vidas = 0;

if (vidas > 0)
{
    Console.WriteLine("El jugador sigue vivo");
}
else
{
    Console.WriteLine("Game Over");
}
```

Salida:

```text
Game Over
```

---

# Operadores Relacionales

Las estructuras de decisión suelen utilizar operadores relacionales para comparar valores.

| Operador | Significado       |
| -------- | ----------------- |
| `==`     | Igual que         |
| `!=`     | Distinto de       |
| `>`      | Mayor que         |
| `<`      | Menor que         |
| `>=`     | Mayor o igual que |
| `<=`     | Menor o igual que |

Ejemplo:

```csharp
int monedas = 50;

if (monedas >= 50)
{
    Console.WriteLine("Puedes comprar el objeto");
}
```

---

# Estructuras Repetitivas

En muchas ocasiones necesitamos ejecutar una misma acción varias veces.

Para ello utilizamos estructuras repetitivas o ciclos.

---

## Ciclo while

Ejecuta instrucciones mientras una condición sea verdadera.

### Sintaxis

```csharp
while (condicion)
{
    // instrucciones
}
```

### Ejemplo

```csharp
int vidas = 3;

while (vidas > 0)
{
    Console.WriteLine("Vida restante: " + vidas);
    vidas--;
}
```

Salida:

```text
Vida restante: 3
Vida restante: 2
Vida restante: 1
```

---

## Ciclo for

Se utiliza cuando conocemos de antemano cuántas veces debe repetirse una acción.

### Sintaxis

```csharp
for (inicializacion; condicion; actualizacion)
{
    // instrucciones
}
```

### Ejemplo

```csharp
for (int nivel = 1; nivel <= 5; nivel++)
{
    Console.WriteLine("Nivel " + nivel);
}
```

Salida:

```text
Nivel 1
Nivel 2
Nivel 3
Nivel 4
Nivel 5
```

---

# Comparación General

| Estructura | Uso principal                             |
| ---------- | ----------------------------------------- |
| Secuencial | Ejecutar instrucciones en orden.          |
| if         | Tomar decisiones.                         |
| if-else    | Elegir entre dos caminos.                 |
| while      | Repetir mientras se cumpla una condición. |
| for        | Repetir una cantidad conocida de veces.   |

---

# Idea Fundamental

Las estructuras de control permiten que un programa deje de ser una simple secuencia de instrucciones y comience a comportarse de manera dinámica.

Gracias a ellas podemos construir programas capaces de reaccionar a diferentes situaciones, tomar decisiones y ejecutar procesos repetitivos, características esenciales en cualquier aplicación moderna.
