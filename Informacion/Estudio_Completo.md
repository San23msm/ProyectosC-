# Pensamiento Computacional

Programar no es simplemente aprender la sintaxis de un lenguaje ni memorizar instucciones.

La programación es un disciplina de **resolución de problemas formales**, donde el código es solo el último eslabón de una cadena mucho más larga.

El concepto académico que respalda esto es el **Pensamiento Computacional**. No se traa de "pensar como una computadora"", sino de utilizar conceptos fundamentales de la ciencia de la computación para resolver problemas, diseñar sistemas y comprender el comportamiento humano.

# Cuatro habilidades fundamentales

**a. Descomposición**
    Dividir un problema complejo en subproblemas manejables **(conocida tambien como programación modular)**.

    Un problema complejo no debe abordarse como un bloque único, sino como un conjunto de subproblemas más simples.

                            ------                 Subdivisión 
                            |    |                del problema
                            |    |   --->  ------    ------    ------
                            |    |         |  1 |    |  2 |    |  3 |
                            ------         ------    ------    ------

**b. Reconocimiento de patrones**
    Identificar similitudes o regularidades entre problemas.

**c. Abstracción**
    Separar lo relevante de lo irrelevante. Una computadora no "entiende" contexto, solo lo procesa lo que le fue explicitado. Expresiones vagas como "hacer la cuenta" suelen indicar que la solución aún no está lo suficientemente especificada.

**d. Diseño de algoritmos**
    Construir una solución paso a paso, finita, ordenada y ejecutable. 


                                    ------    ------    ------
                                    |  1 | -->|  2 | -->|  3 | --> n --> Solución
                                    ------    ------    ------ 

# El marco Entrada - Proceso - Salida (EPS)

No es un mero fomalismo es una **abstracción del módulo de maquina de Turing**. Todo sistema computacional, por complejo que sea, puede describirse como una función que transforma entradas en salidas mediante un proceso.

    Entrada: Datos que el sistema recibe del exterior.
    Proceso: Transformaciones definidas sobre esos datos.
    Salida: Resultados visibles o internos del sistema.

# Fases de Resolución 

Presentamos seis fases, donde vamos a enfatizar proque el orden es **innegociable** en una formación.

**1. Definición**: Comprender exactamente que se pide.

**2. Ánalisis**: Identificar entradas, procesos, salidas, casos especiales.

**3. Diseño**: Construir la estrategia: algoritmos, módulos y estructuras.

**4. Codificación**: Traducir el diseño a un lenguaje formal.

**5: Prueba y depuración**: Verificar con datos de prueba, corregir errores lógixos.

**6. Documentación**: Registrar que hace, por qué y cómo modificarlo.

# Del Lenguaje Coloquial al Algoritmo formal

Problema -> Idea de solución -> Procedimiento informal -> Algoritmo

La distancia entre "sumar las notas y sacar promedio"; El primero es una **intención**, y el segundo, una **formalización ejecutable**.

# Propiedades que debe cumplir un algoritmo

**1. Orden lógico**: Las acciones no son intercambiables.

**2. Precisión**: Cada paso debe ser inequivoco. "Calcular puntaje total" es ambiguo si no definió la formula.

**3. Finitud**: Debe terminar. Un bucle sin condición de salida no es un algoritmo. 

**4. Ejecutabilidad**: Cada paso debe ser realizable. "Pensar en una solución" no es un paso ejecutable para una máquina.

**5. Coherencia EPS**: Las salidas deben derivar exclusivamente de las entradas mediante el proceso definido.

# La secuencia comom estructura madre

Antes de dominar la seleccion (if) y la repetición (while/for), hay que dominar la secuencia pura.

**Ejemplo de secuencia bien construida**

1. Leer nombre del jugador.
2. Leer cantidad de monedas recolectadas.
3. Leer cantidad de enemigos derrotados.
4. Calcular puntaje= (monedas*10)+(enemigos*50).
5. Mostrar nombre del jugador.
6. Mostrar puntaje calculado.

Nota que:

    -No hay decisiones todavia (no se pregunta si gano o perdió).

    -No hay repeticiones (no se procesan multiples jugadores).

    -El orden es físico: no podés mostrar el puntaje (paso 6) antes de calcularlo (paso 4).

-----------------------------------------------------------------------------------------------------------------------------------------------

# Paradigma de Programación 
Un paradigma de programación es un conjunto coherente de conceptos, principios y métodos que definen cómo se concibe, estructura y resuelve un problema computacional. No es una herramienta es una **forma de ver**.

# El paradigma imperativo/procedural
La **programación estructurada** (secuencia, selección, repetición) y la **programación modular** (división en módulos/procedimientos) son las dos grandes conquistas del paradigma procedural. 

# Caracterisiticas del pensamiento procedural
- El programa es un conjunto de **instrucciones** que modifican el estado de la memoria.
- Los **datos** (variables, estructuras) y los **procesos** (funciones, procedimientos) están separados.
- La unidad de organización es el **módulo/función**, una tarea bien definida que opera sobre datos externos.

-----------------------------------------------------------------------------------------------------------------------------------------------
# El problema que la P.O.O resolvió
La Programación Orientada a Objetos (POO) no surgió porque alguien quisiera complicarse la vida. Surgió porque en sistemas grandes (simulaciones, interfaces, gráficas, videojuego) el módelo procedural generaba:

**1. Datos globales incontrolables**: muchas funciones accediendo a variables compartidas.
**2. Acomplamiento excesivo**: cambiar una estructura de datos obligaba a revisar decenas de funciones.
**3. Dificultad para modelar el dominio**: un "enemigo" en un juego no es solo un grupo de variables; es una entidad con identidad, estado y comportamiento. El procedural lo fragmenta. 


# La unidad básica: el objeto
Un objeto, en términos conceptuales, tiene:
**Identidad**: es único, aunque tenga el mismo estado que otro.

**Ejemplo**: Dos enemigos "Esqueleto" son objetos distintos, cada uno con su propia existencia en el mapa.

**Estado**: conjunto de propiedades que definen su condición actual.

**Ejemplo**: Vida=80, Posicion=(x:45 , y:120), Estado= "patrullero"

**Comportamiento**: Acciones que puede realizar y que suelen modificar su estado. 

**Ejemplo**: Moverse(), Atacar(), RecibirDaño(cantidad).

**La Revolución**: En POO, los dato (estado) y las funciones (comportamiento) **viven juntos** dentro de la misma frontera. No hay "variables globales de enemigo" accediendo por funciones sueltas; hay Objetos enemigos que encapsulan su propia lógica.



# Cuatro Pilares Conceptuales
**a. Abstracción**
    Simplificar la realidad modelando solo los atributos y comportamientos relevantes para el problema.

    -En el mundo real: un enemigo tiene nombre, historia, color de ojos, hambre, sueño. 

    -En el juego:  abtraemos a "Enemigo" como entidad con Vida, Daño, Velocidad y Posición. El resto no importa para la lógica.

**b. Encampusulamiento** 
    Ocultar los detalles internos y exponer solo una interfaz controlada. Es la evolución directa de la **modularidad**

    Ejemplo: La vida de un personaje no debería se modificada directamente desde cualquier parte del programa. 
    Se expone un método RecibirDaño(int cantidad), que internamente resta vida, verifica si llegó a cero y dispara el evento de muerte.

    Ventaja: Si más adelante queremos que el daño dependa de la armadura, resistencia mágica o escudos, modificamos solo el interior de RecibirDaño. El resto del juego ni se se entera.

**c. Herencia**
    Organizar jerarquías de especialización. Permite reutilizar código y establecer relaciones "es-un".

    Ejemplo: Tenés una clase base/padre. Personaje con atributos comunes (vida, posicion, Moverse()). De ella heredan Jugador y Enemigo. A su vez, Enemigo tiene subclases EnemigoTerrestre y EnemigoVolador, cada una con comportamientos epecificos.

    Riesgo: La herencia es poderosa pero peligrosa. Una jerarquía muy profunda genera rigidez. En motores de juego se prefiere la composición (agregar componentes) sobre la herencia profunda.
    Pero conceptualmente, entender la herencia es indispensable.

**d. Polimorfismo**: 
    "Muchas formas". La capacidad de que diferentes objetos respondan al mismo mensaje de manera distinta.

    Ejemplo: Todos los objetos "atacables" entienden el mensaje RecibirDaño(). Un jugador reduce su escudo; un Enemigo reduce su vida; una PuertaDeMandera se destruye si el daño es de tipo fuego. El sistema que gestiona las colisiones no necesita saber "que" es cada objeto; solo le envia RecibirDaño() y cada uno responde según su naturaleza. 

    Conexión con Videojuegos: Esto es lo que permite tener su sistema de combate genérico que funcione con cualquier entidad sin necesidad de if infinitos.


# POO y Videojuegos
Los videojuegos son, en esencia, **simulaciones de mundos** y **poblados por entidades autónomas**. Esa descripción casi exige un paradigma orientado a objetos. 

**Jugador**: Objeto con estado (vida, invetario, posición) y comportamientos (moverse, saltar, atacar).

**Enemigo**: Objeto que hereda de una clase base o compone ccomportamientos con IA.

**Item/ Power-Up**: Objeto con propiedades (tipo, valor) y método AplicarEfecto(Jugador)

**Nivel/Escena**: Objeto contenedor que gestiona una colección de otros objetos.

**Interfaz de usuario**: Objeto que responden a eventos (clics, teclas) y modifican su estado visual.

-----------------------------------------------------------------------------------------------------------------------------------------------

# C# de los conceptos a la sintaxis
**La anatomía mínima de un programa**
Todo programa C# necesita al menos esto:

using System; // importar herramientas del sistema

class Program  //Una clase contenedora
{
    static void Main()  //Punto de entrada
    {
        Console.WriteLine("Hola Mundo") //Mostrar un mensaje por pantalla
    }
}

**Desglose**
- using System; Trae al programa el espacio de nombres donde vive Console.

- class Program; Define un contenedor. En C#, todo el código debe vivir dentro de una clase.

- static void Main(); Es el método que el sistema operativo ejecuta primero.

# Variables y tipos de datos
En C# todo dato tiene un tipo explicito. La computadora necesita de saber cuánta memoria reservar y qué operaciones son válidas.

string nombre_Jugador= "Alex"; //texto

int puntaje= 1200; //número entero

float velocidad= 5.5f;  //número con decimales (precisión simple)

double precisión= 3.1415926535;  // número con decimales (precisión doble)

bool tieneEscudo= true;  //verdadero o falso

char inicial= 'A';  //un solo carácter 


# Entrada y Salida
Todo problema tiene Entrada, Proceso y Salida.

Por consola:

using System;

class Program
{
    static void Main()
    {
        //Entrada
        Console.WriteLine("Ingrese el nombre del jugador: ");
        string nombre= Console.ReadLine();  //Lee texto del usuario


        Console.Write("Ingrese el puntaje obtenido: ");
        string entrada_Puntaje= Console.ReadLine();  //Lee como texto
        int puntaje= int.Parse(entrada_Puntaje);  //Convierte texto a número entero.


        //Proceso
        int bonificacion= 100;
        int puntajeFinal= puntaje + bonificacion;
        
        //Salida
        Console.WriteLine("Jugador: "+nombre);
        Console.WriteLine("Puntaje final: "+ puntajeFinal);
    }
}

**Puntos criticos**
-Console.ReadLine() siempre devuelve string. Si se necesita un número, se debe de convertir con int.Parse();

-Si el usuario escribe "hola" en lugar de un número, int.Parse() falla (lanza una excepción).

- El operador + entre los string los concatena (une).

**Operadores aritméticos y de comparación**
-Suma: + 

-Resta: -

-Multiplicación: *

-División entera (si ambos son int): /

-Módulo(resto de la división): %

-¿Es igual?: ==

-¿Es distinto?: !=

-Comparaciones: >,<, >=, <=

**Trampa común**: = es asignación (guardar un valor), == es comparación (preguntar si son iguales).

-----------------------------------------------------------------------------------------------------------------------------------------------

# Estructuras de Control

**Secuencia**
Las instrucciones se ejecutan de arriba hacia abajo.

**Decisión: if, else if, else**
Una decisión aparece cuando el algoritmo no puede continuar siempre del mismo modo.

Console.WriteLine("Ingrese un puntaje: ");
int puntaje= int.Parse(Console.ReadLine());

//Decisión Simple
if (puntaje >= 1000)
{
    Console.WriteLine("¡Pasa al siguiente nivel!);
}

//Decisión con Alternativa
if (puntaje >= 1000)
{
    Console.WriteLine("¡Pasa al siguiente nivel!);
}
else
{
    Console.WriteLine("Debe seguir jugador");
}

//Decisión multiple (else if)
if (puntaje >= 1000)
{
    Console.WriteLine("¡Pasa al siguiente nivel!);
}
else if(puntaje >= 500)
{
    Console.WriteLine("Casi lo logra. Intente de nuevo");
}
else
{
    Console.WriteLine("Debe seguir jugador"); 
}