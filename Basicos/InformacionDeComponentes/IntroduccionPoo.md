# Introducción a la Programación Orientada a Objetos

Hasta este momento hemos utilizado variables para almacenar datos y estructuras de control para tomar decisiones o repetir acciones. Sin embargo, a medida que los programas crecen, necesitamos una forma más organizada de representar la información y el comportamiento de los elementos con los que trabajamos.

La **Programación Orientada a Objetos (POO)** es un paradigma de programación que permite modelar entidades del mundo real mediante objetos que poseen características y comportamientos.

Por ejemplo, en un videojuego podemos encontrar:

* Jugadores.
* Enemigos.
* Armas.
* Inventarios.
* Misiones.

Cada uno de estos elementos tiene información propia y acciones que puede realizar.

La Programación Orientada a Objetos nos permite representar estas entidades de manera natural dentro del código.

---

# ¿Qué es un Objeto?

Un objeto es una representación de una entidad dentro del programa.

Podemos imaginarlo como una ficha que contiene:

* Datos (atributos).
* Acciones (métodos).

Por ejemplo, un jugador puede poseer:

| Atributo | Valor |
| -------- | ----- |
| Nombre   | Ana   |
| Vida     | 100   |
| Nivel    | 5     |

Y puede realizar acciones como:

* Atacar.
* Saltar.
* Moverse.
* Curarse.

---

# ¿Qué es una Clase?

Una clase es una plantilla o modelo utilizado para crear objetos.

Podemos pensar en ella como el plano de una casa.

El plano define cómo será la casa, pero la casa no existe hasta que es construida.

De forma similar:

* La clase define la estructura.
* El objeto es una instancia creada a partir de esa estructura.

---

# Primer Ejemplo

```csharp
class Jugador
{
    public string Nombre;
    public int Vida;
}
```

La clase `Jugador` define dos características:

* Nombre.
* Vida.

Sin embargo, todavía no existe ningún jugador.

Para crear uno debemos instanciar un objeto.

```csharp
Jugador jugador1 = new Jugador();
```

Ahora sí existe un objeto dentro de la memoria.

---

# Asignando Valores

Una vez creado el objeto, podemos modificar sus atributos.

```csharp
Jugador jugador1 = new Jugador();

jugador1.Nombre = "Ana";
jugador1.Vida = 100;
```

---

# Accediendo a la Información

Los atributos pueden utilizarse como cualquier otra variable.

```csharp
Console.WriteLine(jugador1.Nombre);
Console.WriteLine(jugador1.Vida);
```

Salida:

```text
Ana
100
```

---

# Atributos y Métodos

Los objetos no solo almacenan información.

También pueden ejecutar acciones.

```csharp
class Jugador
{
    public string Nombre;
    public int Vida;

    public void MostrarEstado()
    {
        Console.WriteLine("Jugador: " + Nombre);
        Console.WriteLine("Vida: " + Vida);
    }
}
```

Ahora el objeto posee un método llamado `MostrarEstado`.

```csharp
Jugador jugador1 = new Jugador();

jugador1.Nombre = "Ana";
jugador1.Vida = 100;

jugador1.MostrarEstado();
```

Salida:

```text
Jugador: Ana
Vida: 100
```

---

# Conceptos Fundamentales de la POO

La Programación Orientada a Objetos se apoya en cuatro pilares principales:

| Concepto        | Descripción                                                                     |
| --------------- | ------------------------------------------------------------------------------- |
| Encapsulamiento | Protege y organiza la información de un objeto.                                 |
| Abstracción     | Permite representar únicamente los aspectos importantes de una entidad.         |
| Herencia        | Permite reutilizar características de otras clases.                             |
| Polimorfismo    | Permite que distintos objetos respondan de manera diferente a una misma acción. |

Durante las próximas secciones estudiaremos cada uno de estos conceptos en profundidad.

---

# Idea Fundamental

La Programación Orientada a Objetos busca organizar el software mediante entidades que combinan datos y comportamientos.

En lugar de pensar únicamente en variables y funciones aisladas, comenzamos a modelar objetos capaces de representar elementos del mundo real, facilitando la construcción de programas más claros, reutilizables y fáciles de mantener.
