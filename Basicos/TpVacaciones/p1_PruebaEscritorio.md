# Prueba de Escritorio — Estación Espacial en Peligro

**Estado inicial:**
- Oxígeno: 10
- Energía: 6
- Módulos reparados: 0
- Tarjetas de acceso: 0
- Turnos usados: 0
- Traje espacial: No
- Evacuación completada: No
- Máximo de turnos: 12

---

## Prueba A — Victoria por evacuación (Condición A: módulos + tarjeta)

| Iteración | Acción elegida | Oxígeno | Energía | Módulos | Tarjetas | Traje | Turnos | Evacuación | Observación |
|:---------:|:---------------|:-------:|:-------:|:-------:|:--------:|:-----:|:------:|:----------:|:------------|
| Inicio | — | 10 | 6 | 0 | 0 | No | 0 | No | Estado inicial |
| 1 | 1. Reparar módulo | 9 | 5 | 1 | 0 | No | 1 | No | Gasta 1 oxígeno, 1 energía. Cuenta turno. |
| 2 | 1. Reparar módulo | 8 | 4 | 2 | 0 | No | 2 | No | Gasta 1 oxígeno, 1 energía. Cuenta turno. |
| 3 | 1. Reparar módulo | 7 | 3 | 3 | 0 | No | 3 | No | Gasta 1 oxígeno, 1 energía. Cuenta turno. |
| 4 | 2. Buscar tarjeta | 6 | 2 | 3 | 1 | No | 4 | No | Primera búsqueda: obtiene tarjeta. Gasta oxígeno y energía. |
| 5 | 4. Intentar evacuar | 6 | 2 | 3 | 1 | No | 5 | **Sí** | Cumple condición A: `módulos &gt;= 3 && tarjetas &gt;= 1`. Evacuación exitosa. |

**Resultado:** En el turno 5 el jugador cumple la condición de victoria. El programa imprime:
&gt; *"¡Evacuación completada con éxito!"*
&gt; *"¡Felicidades! Has completado la evacuación con éxito."*

El `break` del post-switch finaliza el ciclo `while` inmediatamente.

---

## Prueba B — Derrota por energía agotada

| Iteración | Acción elegida | Oxígeno | Energía | Módulos | Tarjetas | Traje | Turnos | Evacuación | Observación |
|:---------:|:---------------|:-------:|:-------:|:-------:|:--------:|:-----:|:------:|:----------:|:------------|
| Inicio | — | 10 | 6 | 0 | 0 | No | 0 | No | Estado inicial |
| 1 | 1. Reparar módulo | 9 | 5 | 1 | 0 | No | 1 | No | Gasta 1 oxígeno, 1 energía. |
| 2 | 1. Reparar módulo | 8 | 4 | 2 | 0 | No | 2 | No | Gasta 1 oxígeno, 1 energía. |
| 3 | 1. Reparar módulo | 7 | 3 | 3 | 0 | No | 3 | No | Gasta 1 oxígeno, 1 energía. |
| 4 | 1. Reparar módulo | 6 | 2 | 4 | 0 | No | 4 | No | Gasta 1 oxígeno, 1 energía. |
| 5 | 1. Reparar módulo | 5 | 1 | 5 | 0 | No | 5 | No | Gasta 1 oxígeno, 1 energía. |
| 6 | 1. Reparar módulo | 4 | 0 | 6 | 0 | No | 6 | No | Gasta 1 oxígeno, 1 energía. Energía llega a 0. |
| 7 | 1. Reparar módulo | 3 | **-1** | 7 | 0 | No | 7 | No | Gasta 1 oxígeno, 1 energía. Energía queda en -1. |

