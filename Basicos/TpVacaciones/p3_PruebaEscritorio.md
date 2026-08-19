# Prueba de Escritorio — Laboratorio de Cristales

**Estado inicial:**
- Cristales rojos: 0
- Cristales azules: 0
- Cristales combinados: 0
- Inestabilidad: 0
- Turnos: 0
- Tiene catalizador: No
- Experimento cerrado: No
- Máximo de turnos: 14
- Límite de inestabilidad: 8

---

## Prueba A — Victoria por condición B (catalizador + 2 combinados + inestabilidad ≤ 5)

| Iteración | Acción elegida | Rojos | Azules | Combinados | Inestabilidad | Catalizador | Turnos | Cerrado | Observación |
|:---------:|:---------------|:-----:|:------:|:----------:|:-------------:|:-----------:|:------:|:-------:|:------------|
| Inicio | — | 0 | 0 | 0 | 0 | No | 0 | No | Estado inicial |
| 1 | 5. Buscar catalizador | 0 | 0 | 0 | 1 | **Sí** | 1 | No | Obtiene catalizador, +1 inestabilidad |
| 2 | 1. Recolectar rojo | 1 | 0 | 0 | 2 | Sí | 2 | No | +1 rojo, +1 inestabilidad |
| 3 | 2. Recolectar azul | 1 | 1 | 0 | 3 | Sí | 3 | No | +1 azul, +1 inestabilidad |
| 4 | 3. Combinar cristales | 0 | 0 | 1 | 5 | Sí | 4 | No | Consume 1 rojo y 1 azul, +1 combinado, +2 inestabilidad |
| 5 | 4. Estabilizar | 0 | 0 | 1 | 4 | Sí | 5 | No | -1 inestabilidad |
| 6 | 4. Estabilizar | 0 | 0 | 1 | 3 | Sí | 6 | No | -1 inestabilidad |
| 7 | 1. Recolectar rojo | 1 | 0 | 1 | 4 | Sí | 7 | No | +1 rojo, +1 inestabilidad |
| 8 | 2. Recolectar azul | 1 | 1 | 1 | 5 | Sí | 8 | No | +1 azul, +1 inestabilidad |
| 9 | 4. Estabilizar | 1 | 1 | 1 | 4 | Sí | 9 | No | -1 inestabilidad |
| 10 | 4. Estabilizar | 1 | 1 | 1 | 3 | Sí | 10 | No | -1 inestabilidad |
| 11 | 3. Combinar cristales | 0 | 0 | 2 | 5 | Sí | 11 | No | Segunda combinación, +2 inestabilidad |
| 12 | 6. Cerrar experimento | 0 | 0 | 2 | 5 | Sí | 12 | **Sí** | Cumple condición B: `tiene_catalizador && combinados &gt;= 2 && inestabilidad &lt;= 5` |

**Resultado:** El programa imprime:
&gt; *"¡Experimento cerrado con éxito!"*

La variable `experimento_cerrado` pasa a `true`, el ciclo `while` finaliza en la siguiente evaluación y no entra al bloque de derrota.

---

## Prueba B — Derrota por inestabilidad crítica

| Iteración | Acción elegida | Rojos | Azules | Combinados | Inestabilidad | Catalizador | Turnos | Cerrado | Observación |
|:---------:|:---------------|:-----:|:------:|:----------:|:-------------:|:-----------:|:------:|:-------:|:------------|
| Inicio | — | 0 | 0 | 0 | 0 | No | 0 | No | Estado inicial |
| 1 | 1. Recolectar rojo | 1 | 0 | 0 | 1 | No | 1 | No | +1 rojo, +1 inestabilidad |
| 2 | 1. Recolectar rojo | 2 | 0 | 0 | 2 | No | 2 | No | +1 rojo, +1 inestabilidad |
| 3 | 1. Recolectar rojo | 3 | 0 | 0 | 3 | No | 3 | No | +1 rojo, +1 inestabilidad |
| 4 | 2. Recolectar azul | 3 | 1 | 0 | 4 | No | 4 | No | +1 azul, +1 inestabilidad |
| 5 | 2. Recolectar azul | 3 | 2 | 0 | 5 | No | 5 | No | +1 azul, +1 inestabilidad |
| 6 | 2. Recolectar azul | 3 | 3 | 0 | 6 | No | 6 | No | +1 azul, +1 inestabilidad |
| 7 | 3. Combinar cristales | 2 | 2 | 1 | **8** | No | 7 | No | Consume 1 rojo y 1 azul, +1 combinado, +2 inestabilidad |

