# Instalación del Entorno de Desarrollo

Antes de escribir nuestra primera línea de código en C#, necesitamos preparar el entorno de trabajo. Para ello utilizaremos dos herramientas fundamentales:

* **.NET SDK**, que contiene el compilador, las bibliotecas y las herramientas necesarias para crear aplicaciones en C#.
* **Visual Studio Code**, un editor de código ligero, moderno y multiplataforma.

Esta combinación es gratuita, funciona en Windows, Linux y macOS, y es ampliamente utilizada tanto en entornos educativos como profesionales.

---

## Requisitos Previos

Antes de comenzar, asegúrate de contar con:

* Conexión a Internet.
* Permisos para instalar software en tu equipo.
* Un sistema operativo compatible:

  * Windows 10 o superior.
  * macOS.
  * Distribuciones modernas de Linux.

---

## Paso 1: Instalar el .NET SDK

El **.NET SDK (Software Development Kit)** es el conjunto de herramientas que permite crear, compilar y ejecutar aplicaciones desarrolladas en C#.

### Instalación desde el sitio oficial

1. Accede al sitio oficial de descargas de .NET.
2. Descarga la versión más reciente del SDK disponible.
3. Ejecuta el instalador y sigue las instrucciones del asistente.

### Instalación mediante gestores de paquetes

Dependiendo del sistema operativo, también es posible realizar la instalación desde la terminal.

#### Windows

```bash
winget install Microsoft.DotNet.SDK.10
```

#### macOS

```bash
brew install dotnet
```

#### Linux

La instalación varía según la distribución utilizada. Consulta la documentación oficial de .NET para obtener los comandos específicos para tu sistema.

---

## Paso 2: Instalar Visual Studio Code

Visual Studio Code será nuestro entorno principal para escribir y organizar el código.

1. Descarga Visual Studio Code desde su sitio oficial.
2. Ejecuta el instalador.
3. Completa el proceso de instalación utilizando las opciones predeterminadas.

Una vez finalizada la instalación, abre Visual Studio Code para continuar con la configuración.

---

## Paso 3: Instalar la extensión C# Dev Kit

Para que Visual Studio Code reconozca correctamente los proyectos de C#, debemos instalar las herramientas de soporte oficiales.

1. Abre Visual Studio Code.
2. Selecciona la sección **Extensions** desde la barra lateral izquierda.
3. Busca:

```text
C# Dev Kit
```

4. Instala la extensión desarrollada por Microsoft.
5. Reinicia Visual Studio Code si se solicita.

Esta extensión proporciona:

* Resaltado de sintaxis.
* Autocompletado inteligente.
* Navegación por el código.
* Depuración integrada.
* Gestión de proyectos .NET.

---

## Paso 4: Verificar la instalación

Una vez instaladas todas las herramientas, es importante comprobar que el SDK fue configurado correctamente.

Abre una terminal y ejecuta:

```bash
dotnet --version
```

Si la instalación fue exitosa, obtendrás una salida similar a la siguiente:

```text
10.0.xxx
```

El número exacto puede variar según la versión instalada.

---

## Resultado Esperado

Al finalizar esta sección deberías disponer de:

| Herramienta          | Estado     |
| -------------------- | ---------- |
| .NET SDK             | Instalado  |
| Visual Studio Code   | Instalado  |
| C# Dev Kit           | Instalado  |
| Terminal configurada | Verificada |

Con el entorno listo, ya podremos crear y ejecutar nuestro primer proyecto en C#.
