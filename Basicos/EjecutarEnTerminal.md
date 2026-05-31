## Ejecutar un Proyecto desde la Terminal

Una vez creado nuestro proyecto, podemos compilarlo y ejecutarlo directamente desde la terminal mediante la herramienta **dotnet**.

La sintaxis general de los comandos de .NET sigue una estructura sencilla:

```bash
dotnet acción
```

Donde:

| Elemento | Descripción                                        |
| -------- | -------------------------------------------------- |
| `dotnet` | Herramienta principal de la plataforma .NET.       |
| `acción` | Operación que deseamos realizar sobre el proyecto. |

Por ejemplo, para ejecutar una aplicación utilizamos:

```bash
dotnet run
```

En este comando:

| Elemento | Función                                             |
| -------- | --------------------------------------------------- |
| `dotnet` | Invoca la herramienta de línea de comandos de .NET. |
| `run`    | Compila y ejecuta el proyecto actual.               |

Podemos interpretar esta instrucción de la siguiente manera:

> ".NET, compila y ejecuta el proyecto que se encuentra en el directorio actual."

---

### ¿Desde dónde debe ejecutarse?

Es importante ejecutar el comando desde la carpeta que contiene el proyecto.

Supongamos la siguiente estructura:

```text
MiPrimerApp/
│
├── Program.cs
├── MiPrimerApp.csproj
└── obj/
```

Si abrimos una terminal dentro de la carpeta `MiPrimerApp`, podremos ejecutar:

```bash
dotnet run
```

y la aplicación comenzará a ejecutarse.

---

### Otros comandos frecuentes

A lo largo del aprendizaje utilizaremos otros comandos de la herramienta `dotnet`:

```bash
dotnet new console
```

Crea un nuevo proyecto de consola.

```bash
dotnet build
```

Compila el proyecto sin ejecutarlo.

```bash
dotnet run
```

Compila y ejecuta el proyecto.

```bash
dotnet --version
```

Muestra la versión instalada del SDK de .NET.

Comprender la estructura de estos comandos desde el principio facilitará el trabajo con cualquier tipo de aplicación desarrollada en C#.
