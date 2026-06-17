# Introducción a la Programación - Tecnicatura Superior en Diseño y Desarrollo de Videojuegos

# Actividad práctica: El guardián del portal

**Tema:** condiciones, operadores lógicos y ciclo `while` en C#

## Modalidad de trabajo

Trabajo individual. Resolver durante la clase.

No se entrega código guía: deben interpretar la consigna, diseñar la lógica y programarla en C#.

---

# 1. Situación

Un jugador debe atravesar un portal protegido por un guardián. Para lograrlo, debe reunir recursos durante varios turnos. En cada turno podrá elegir una acción.

El juego termina cuando el jugador logra abrir el portal, se queda sin energía o se agotan los turnos disponibles.

---

# 2. Estado inicial del jugador

- Energía inicial: 8
- Gemas iniciales: 0
- Llaves iniciales: 0
- Trampas activadas: 0
- Turnos usados: 0
- Tiene mapa: falso
- Portal abierto: falso
- Máximo de turnos permitidos: 12

---

# 3. Acciones disponibles

En cada turno, el programa debe mostrar el estado actual del jugador y luego permitir elegir una opción:

1. Buscar gema
2. Explorar cofre
3. Descansar
4. Intentar abrir el portal

---

# 4. Reglas de cada acción

## Opción 1: Buscar gema

- El jugador obtiene 1 gema.
- Pierde 1 punto de energía.
- Se cuenta como un turno usado.
- Si luego de buscar gema alcanza 5 gemas o más, debe mostrarse:

> "El jugador ya tiene suficientes gemas para una de las condiciones del portal."

---

## Opción 2: Explorar cofre

- El jugador pierde 2 puntos de energía.
- Se cuenta como un turno usado.
- Si no tiene ninguna llave, obtiene 1 llave.
- Si ya tiene 1 llave pero no tiene mapa, obtiene el mapa.
- Si ya tiene llave y mapa, activa una trampa.

### Cuando activa una trampa

- Aumenta en 1 la cantidad de trampas.
- Pierde 1 punto extra de energía.

---

## Opción 3: Descansar

- El jugador recupera 2 puntos de energía.
- La energía nunca puede superar 8.
- Se cuenta como un turno usado.

**Ejemplo:** si tiene 7 de energía y descansa, queda con 8, no con 9.

---

## Opción 4: Intentar abrir el portal

- Se cuenta como un turno usado.
- El portal se abre si se cumple al menos una de las condiciones indicadas en la sección 5.
- Si no cumple ninguna condición, el portal no se abre y debe mostrarse:

> "Todavía no puedes abrir el portal."

- Si el intento falla, el jugador pierde 1 punto de energía.

---

# 5. Condiciones para abrir el portal

El portal se abre si se cumple al menos una de estas dos condiciones:

### Condición A

- El jugador tiene 5 gemas o más **Y**
- Tiene al menos 1 llave.

### Condición B

- Tiene mapa **Y**
- Tiene 3 gemas o más **Y**
- Tiene energía mayor que 0.

## Atención

En C# deberán decidir dónde usar operadores lógicos:

- AND (`&&`)
- OR (`||`)

No alcanza con copiar reglas: deben traducirlas correctamente a una condición lógica.

---

# 6. Condiciones de finalización

El juego debe repetirse mientras se cumplan todas estas condiciones:

- El portal no está abierto.
- La energía es mayor que 0.
- Los turnos usados son menores que 12.

## El juego termina cuando ocurra cualquiera de estas situaciones

- El portal se abre.
- La energía llega a 0 o menos.
- Se llegan a usar los 12 turnos.

---

# 7. Validación de opción

Si el usuario ingresa una opción distinta de 1, 2, 3 o 4, debe mostrarse el mensaje:

> "Opción no válida. Debe elegir 1, 2, 3 o 4."

### Importante

- La opción inválida no debe contar como turno.
- La opción inválida no debe modificar energía, gemas, llaves, mapa ni trampas.

---

# 8. Resultado final

Al finalizar, el programa debe mostrar:

- Si ganó o perdió.
- Motivo de finalización.
- Energía final.
- Gemas finales.
- Llaves finales.
- Si obtuvo o no el mapa.
- Cantidad de trampas activadas.
- Turnos usados.

---

# 9. Antes de programar: responder brevemente

1. ¿Cuáles son las variables necesarias?
2. ¿Qué variable funciona como bandera para saber si el portal se abrió?
3. ¿Cuál es la condición completa del ciclo `while`?
4. ¿Qué acciones modifican la energía?
5. ¿Qué acciones modifican gemas, llaves, mapa o trampas?
6. ¿En qué casos se debe usar AND?
7. ¿En qué caso se debe usar OR?
8. ¿Por qué una opción inválida no debe contar como turno?
9. ¿Qué diferencia hay entre intentar abrir el portal y lograr abrirlo?

---

# 10. Pruebas obligatorias

| Caso | Secuencia aproximada de acciones | Resultado esperado |
|--------|--------------------------------|-------------------|
| 1 | Buscar gemas hasta tener 5, conseguir llave e intentar abrir portal | Victoria |
| 2 | Conseguir mapa, tener al menos 3 gemas e intentar abrir portal | Victoria |
| 3 | Intentar abrir portal sin cumplir condiciones | No abre y pierde energía |
| 4 | Ingresar una opción inválida | No cuenta turno y no modifica datos |
| 5 | Gastar toda la energía sin abrir el portal | Derrota |
| 6 | Llegar a 12 turnos sin abrir el portal | Derrota |

---

# 11. Entrega

- Archivo del programa en C#.
- Captura de una ejecución donde gane.
- Captura de una ejecución donde pierda.
- Breve explicación escrita de la condición del `while`.
- Breve explicación escrita de la condición que permite abrir el portal.

## Tiempo de trabajo sugerido en clase

Se recomienda resolver una versión funcional mínima durante la hora de trabajo.

Quienes finalicen antes pueden:

- Mejorar los mensajes.
- Ordenar la salida en pantalla.
- Agregar una dificultad inicial.

Sin cambiar las reglas principales.

---

# 12. Criterios de revisión

- Respeta las reglas del enunciado.
- Usa correctamente ciclo `while` y condiciones de corte.
- Usa condiciones compuestas con AND y OR cuando corresponda.
- Valida opciones incorrectas sin modificar el estado del juego.
- Muestra un resultado final claro y coherente.
- El estudiante puede explicar la lógica utilizada.