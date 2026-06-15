# MENÚ INTERACTIVO CON LISTAS, DO WHILE Y SWITCH

## Objetivo

Desarrollar una aplicación de consola que permita al usuario crear una lista personalizada de días de la semana mediante un menú interactivo.

El programa utiliza una estructura repetitiva para mantener el menú activo, una estructura de selección para procesar las opciones elegidas y una lista para almacenar los días seleccionados.

---

# Problema a Resolver

Crear un sistema que permita:

* Agregar días de la semana a una lista.
* Mostrar todos los días agregados.
* Validar que las opciones ingresadas sean correctas.
* Mantener el menú activo hasta que el usuario decida salir.

---

# Conceptos Aplicados

Este ejercicio integra varios conceptos fundamentales de programación:

| Concepto            | Aplicación                                   |
| ------------------- | -------------------------------------------- |
| Variables           | Almacenan opciones y datos temporales        |
| Listas (`List<T>`)  | Guardan los días seleccionados               |
| `do while`          | Mantiene el menú en ejecución                |
| `switch`            | Procesa cada opción del menú                 |
| Métodos             | Organizan el código en bloques reutilizables |
| `foreach`           | Recorre los elementos de la lista            |
| Validación de datos | Evita entradas incorrectas                   |

---

# Estructura General del Programa

```text
Inicio
   │
   ▼
Crear lista vacía
   │
   ▼
Mostrar menú
   │
   ▼
Ingresar opción
   │
   ▼
Validar opción
   │
   ▼
Procesar opción con SWITCH
   │
   ├── Agregar día
   │
   ├── Mostrar lista
   │
   └── Salir
   │
   ▼
¿Desea continuar?
   │
 ┌─┴─┐
 │Sí │────► Volver al menú
 └─┬─┘
   │No
   ▼
Fin
```

---

# Uso de la Lista

La siguiente línea crea una lista vacía capaz de almacenar cadenas de texto:

```csharp
List<string> diasElegidos = new List<string>();
```

### ¿Qué significa?

* `List` es una colección dinámica.
* `string` indica que almacenará texto.
* Cada día seleccionado se guardará dentro de esta lista.

Ejemplo:

```text
[Lunes]
[Lunes, Miércoles]
[Lunes, Miércoles, Viernes]
```

---

# Uso del DO WHILE

La estructura `do while` permite repetir el menú hasta que el usuario seleccione la opción de salida.

```csharp
do
{
    // Menú
}
while(opcion != 0);
```

### Ventaja

Garantiza que el menú se muestre al menos una vez y continúe ejecutándose mientras el usuario no elija salir.

---

# Uso del SWITCH

La estructura `switch` permite ejecutar una acción diferente según la opción ingresada.

Ejemplo:

```csharp
case 1:
    diasElegidos.Add("Lunes");
    break;
```

Si el usuario selecciona la opción **1**, el programa agrega el texto `"Lunes"` a la lista.

---

# Método MostrarDias()

Para evitar repetir código, se crea un método independiente encargado de mostrar el contenido de la lista.

```csharp
static void MostrarDias(List<string> lista)
```

### Ventajas de utilizar métodos

* Mejor organización.
* Mayor legibilidad.
* Facilita el mantenimiento del programa.
* Permite reutilizar código.

---

# Uso de FOREACH

Cuando el usuario solicita visualizar la lista, el programa utiliza un recorrido mediante `foreach`.

```csharp
foreach(string dia in lista)
{
    Console.WriteLine(" - " + dia);
}
```

### Funcionamiento

Si la lista contiene:

```text
Lunes
Miércoles
Viernes
```

El ciclo recorrerá cada elemento y lo mostrará en pantalla.

---

# Ejemplo de Ejecución

```text
______Menú de Días______

1. Agregar Lunes
2. Agregar Martes
3. Agregar Miércoles
4. Agregar Jueves
5. Agregar Viernes
6. Agregar Sábado
7. Agregar Domingo
8. Mostrar Lista
0. Salir

Ingrese una opción: 1

Agregado
```

Posteriormente:

```text
Ingrese una opción: 3

Agregado
```

Y al seleccionar:

```text
Ingrese una opción: 8
```

Resultado:

```text
---Tu Lista---

- Lunes
- Miércoles
```

---

# Aprendizajes Obtenidos

Al completar este ejercicio se aprende a:

* Crear y utilizar listas dinámicas.
* Agregar elementos mediante `Add()`.
* Recorrer colecciones con `foreach`.
* Implementar menús interactivos.
* Utilizar estructuras repetitivas (`do while`).
* Aplicar estructuras de selección (`switch`).
* Dividir un programa en métodos.
* Validar entradas del usuario.

---

# Conclusión

Este ejercicio representa una aplicación práctica de varios conceptos fundamentales de C#. A diferencia de ejemplos simples de `switch`, aquí se combinan listas, métodos, ciclos y validaciones para construir un programa más cercano a una aplicación real. Este tipo de ejercicios ayuda a desarrollar la lógica necesaria para crear sistemas interactivos y organizar mejor el código.
