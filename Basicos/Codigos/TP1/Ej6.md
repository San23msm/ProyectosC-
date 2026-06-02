# Actividad 6. Detectar errores

Leé el siguiente fragmento. El programa se ejecuta, pero no resuelve correctamente la consigna porque tiene un error lógico.

```csharp
int monedas = 10;
int enemigosDerrotados = 4;
int puntosExtra = 50;

int puntajeTotal = monedas + enemigosDerrotados;
```

## 12. ¿Cuál es el error lógico?

El error lógico es que no se está sumando la variable `puntosExtra` al calcular el `puntajeTotal`.

## 13. ¿Por qué el programa podría ejecutarse igual?

Porque no tiene errores de sintaxis. El código está escrito correctamente y puede ejecutarse, pero el resultado obtenido no es el correcto.

## 14. ¿Cómo debería corregirse la línea del puntaje total?

La línea debería corregirse de la siguiente manera:

```csharp
int puntajeTotal = monedas + enemigosDerrotados + puntosExtra;
```
