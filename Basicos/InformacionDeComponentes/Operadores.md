# Operadores

Hasta ahora hemos aprendido a almacenar información en variables. Sin embargo, guardar datos es solo una parte del trabajo de un programa. También necesitamos realizar cálculos, comparar valores y construir expresiones más complejas.

Para ello utilizamos los **operadores**.

Un operador es un símbolo que indica una operación que debe realizarse sobre uno o más valores.

Por ejemplo:

```csharp
int resultado = 5 + 3;
```

En este caso, el operador `+` indica que los valores deben sumarse.

---

# Operadores Aritméticos

Los operadores aritméticos permiten realizar operaciones matemáticas.

| Operador | Operación      | Ejemplo | Resultado |
| -------- | -------------- | ------- | --------- |
| `+`      | Suma           | `5 + 3` | `8`       |
| `-`      | Resta          | `5 - 3` | `2`       |
| `*`      | Multiplicación | `5 * 3` | `15`      |
| `/`      | División       | `6 / 2` | `3`       |
| `%`      | Módulo (resto) | `7 % 2` | `1`       |

## Ejemplo

```csharp
int vidas = 5;
int bonus = 2;

Console.WriteLine(vidas + bonus);
Console.WriteLine(vidas - bonus);
Console.WriteLine(vidas * bonus);
```

Salida:

```text
7
3
10
```

---

# Operador de Asignación

El operador de asignación (`=`) permite guardar un valor dentro de una variable.

```csharp
int vidas = 3;
```

Puede interpretarse como:

> Guardar el valor 3 en la variable vidas.

También puede utilizarse para actualizar valores.

```csharp
int monedas = 10;

monedas = 20;
```

Ahora la variable contiene el valor `20`.

---

# Operadores de Incremento y Decremento

Son muy utilizados cuando necesitamos aumentar o disminuir una variable en una unidad.

```csharp
int vidas = 3;

vidas++;
```

Equivale a:

```csharp
vidas = vidas + 1;
```

Resultado:

```text
4
```

De manera similar:

```csharp
vidas--;
```

Equivale a:

```csharp
vidas = vidas - 1;
```

Resultado:

```text
2
```

---

# Compatibilidad de Tipos

Los operadores trabajan con datos compatibles entre sí.

Por ejemplo:

```csharp
int vidas = 3;
int monedas = 5;

int total = vidas + monedas;
```

Esto es válido porque ambas variables son de tipo `int`.

---

## Operaciones con decimales

```csharp
double energia = 75.5;
double bonus = 10.0;

double total = energia + bonus;
```

Resultado:

```text
85.5
```

Ambas variables son de tipo `double`, por lo que la operación es válida.

---

## Operaciones con texto

Cuando se utiliza el operador `+` con cadenas de texto (`string`), se realiza una concatenación.

```csharp
string nombre = "Ana";
string apellido = "López";

string completo = nombre + " " + apellido;
```

Resultado:

```text
Ana López
```

En este contexto, el operador `+` no suma números, sino que une textos.

---

## Operaciones entre tipos diferentes

En algunos casos C# puede combinar distintos tipos numéricos.

```csharp
int vidas = 3;
double energia = 75.5;

double resultado = vidas + energia;
```

Resultado:

```text
78.5
```

El valor entero se convierte automáticamente a decimal para realizar la operación.

---

## Operaciones inválidas

No todos los tipos pueden combinarse.

Por ejemplo:

```csharp
bool tieneLlave = true;
int vidas = 3;

var resultado = tieneLlave + vidas;
```

Esto produce un error de compilación porque no tiene sentido sumar un valor lógico (`true` o `false`) con un número entero.

---

# Resumen

Los operadores permiten trabajar con los datos almacenados en las variables.

| Categoría   | Ejemplos                |
| ----------- | ----------------------- |
| Aritméticos | `+`, `-`, `*`, `/`, `%` |
| Asignación  | `=`                     |
| Incremento  | `++`                    |
| Decremento  | `--`                    |

Comprender los operadores es fundamental, ya que serán utilizados constantemente para realizar cálculos, modificar variables y construir expresiones más complejas en los programas que desarrollaremos a continuación.
