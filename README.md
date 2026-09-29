# Laboratorio #3 - Colecciones, Formularios MDI y Simulación de Juegos

**Fecha:** 14/09/2026

## Contenido del Repositorio

Este laboratorio reúne diversas aplicaciones desarrolladas en C# utilizando Windows Forms y aplicaciones de consola. Los ejercicios permiten reforzar conceptos relacionados con programación orientada a objetos, manejo de colecciones, validación de datos, interfaces gráficas y simulación de algoritmos.

Los programas desarrollados abarcan:

- Gestión de colaboradores mediante DataGridView.
- Uso de formularios MDI (Multiple Document Interface).
- Simulación del juego de dados Craps.

## Tecnologías Utilizadas

- Lenguaje: C#
- Framework: .NET Framework
- Windows Forms
- Aplicaciones de Consola
- Visual Studio
- Git
- GitHub

---

# Programa #1 - Gestión de Colaboradores con DataGridView

## Descripción

Esta aplicación permite registrar y administrar colaboradores mediante una interfaz gráfica desarrollada en Windows Forms. Los datos ingresados se almacenan en una colección dinámica y se muestran en un DataGridView.

Cada colaborador es representado mediante un objeto de la clase `Persona`.

## Conceptos Aplicados

- Programación Orientada a Objetos.
- Clases y Objetos.
- Propiedades automáticas.
- Colecciones (`ArrayList`).
- DataGridView.
- Expresiones regulares.
- Validación de formularios.
- ErrorProvider.

## Funcionalidades

### Registro de Colaboradores

El sistema permite ingresar:

- ID
- Nombres
- Apellidos
- Correo Electrónico
- Salario
- Fecha de Nacimiento

### Validación de Datos

Antes de almacenar la información se valida:

- Que el ID no esté vacío.
- Que los nombres estén completos.
- Que los apellidos estén completos.
- Que el correo tenga un formato válido.
- Que el salario sea un valor numérico válido.

### Validación de Correo Electrónico

Se utiliza una expresión regular para verificar el formato:

```text
usuario@correo.com
```

### Visualización de Datos

Los colaboradores registrados se muestran automáticamente en un DataGridView.

### Limpieza Automática

Una vez almacenado un colaborador, los controles se restablecen para permitir un nuevo registro.

## Captura de Pantalla

<img width="718" height="499" alt="image" src="https://github.com/user-attachments/assets/74b1dd81-c6a5-41d3-980c-4584532a24a8" />

---

# Programa #2 - Formularios MDI

## Descripción

Esta práctica introduce el uso del modelo MDI (Multiple Document Interface) en Windows Forms.

La aplicación cuenta con una ventana principal que funciona como contenedor de múltiples formularios hijos.

## Conceptos Aplicados

- Windows Forms.
- Formularios MDI.
- Ventanas padre e hijas.
- Manejo de eventos.

## Funcionamiento

Al presionar el botón correspondiente:

1. Se crea una nueva ventana hija.
2. Se establece el formulario principal como contenedor.
3. La nueva ventana se muestra dentro de la interfaz principal.

### Código Fundamental

```csharp
formVentanaText ventanaTexto = new formVentanaText();

ventanaTexto.MdiParent = this;

ventanaTexto.Show();
```

## Beneficios del Uso de MDI

- Organización de múltiples ventanas.
- Mejor gestión de la información.
- Interfaz más profesional.
- Navegación centralizada.

## Captura de Pantalla

<img width="942" height="580" alt="image" src="https://github.com/user-attachments/assets/8a8db06c-3024-4768-af05-a0d29a8d4271" />

<img width="928" height="570" alt="image" src="https://github.com/user-attachments/assets/bfcf0824-68a0-4eb9-8d52-b0068cb8ac55" />


---

# Programa #3 - Simulación del Juego Craps

## Descripción

Esta aplicación de consola simula el juego de dados Craps utilizando números aleatorios y estructuras de control.

El programa sigue las reglas básicas oficiales del juego y determina automáticamente si el jugador gana o pierde.

## Conceptos Aplicados

- Enumeraciones (`enum`).
- Switch.
- Ciclos `while`.
- Generación de números aleatorios.
- Programación Orientada a Objetos.
- Simulación de algoritmos.

## Reglas del Juego

### Ganar en el Primer Lanzamiento

El jugador gana inmediatamente si obtiene:

```text
7
11
```

### Perder en el Primer Lanzamiento

El jugador pierde inmediatamente si obtiene:

```text
2
3
12
```

### Establecimiento del Punto

Si el resultado es cualquier otro valor:

```text
4, 5, 6, 8, 9 o 10
```

Ese valor se convierte en el "Punto".

Ejemplo:

```text
El punto es 8
```

### Continuación del Juego

Posteriormente:

- El jugador gana si vuelve a obtener el mismo punto.
- El jugador pierde si obtiene un 7 antes de repetir el punto.

## Enumeraciones Utilizadas

### Estado del Juego

```csharp
private enum Estado
{
    CONTINUA,
    GANO,
    PERDIO
}
```

### Nombres Especiales de Dados

```csharp
private enum NombresDados
{
    DOS_UNOS = 2,
    TRES = 3,
    SIETE = 7,
    ONCE = 11,
    DOCE = 12
}
```

## Ejemplo de Ejecución

```text
El jugador tiró 4 + 4 = 8

El punto es 8

El jugador tiró 3 + 5 = 8

El jugador gana
```

## Captura de Pantalla

<img width="1457" height="245" alt="image" src="https://github.com/user-attachments/assets/e12cbbe4-e90b-4b36-a464-d0244d67d87d" />

<img width="1463" height="254" alt="image" src="https://github.com/user-attachments/assets/7bdb8d3b-999c-4ef1-a8f3-1879c83e9eb6" />


---

## Comparación de los Programas

| Programa | Tema Principal |
|-----------|---------------|
| Programa 1 | Colecciones y DataGridView |
| Programa 2 | Formularios MDI |
| Programa 3 | Simulación del juego Craps |

---

## Estructura de Carpetas o Directorios

```plaintext
Laboratorio3/
│
├── Programa1_EjemploGrid/
│   ├── Form1.cs
│   ├── Persona.cs
│   ├── Utilidades.cs
│   └── Program.cs
│
├── Programa2_FormularioMDI/
│   ├── Form1.cs
│   ├── formVentanaText.cs
│   └── Program.cs
│
├── Programa3_Craps/
│   ├── Craps.cs
│   └── PruebaCraps.cs
│
├── images/
│   ├── programa1-grid.png
│   ├── programa2-mdi.png
│   └── programa3-craps.png
│
└── README.md
```

## Instrucciones de Ejecución / Uso

### 1. Clonar el repositorio

```bash
git clone [URL_DEL_REPOSITORIO]
```

### 2. Abrir la solución en Visual Studio

Abrir el proyecto correspondiente al programa que se desea ejecutar.

### 3. Compilar el proyecto

```text
Build > Build Solution
```

### 4. Ejecutar

```text
F5
```

o

```text
Ctrl + F5
```

### 5. Probar las funcionalidades

- Programa 1: Registro y visualización de colaboradores.
- Programa 2: Creación de ventanas hijas dentro del formulario principal.
- Programa 3: Simulación del juego Craps.

---

## Aprendizajes Obtenidos

Durante este laboratorio se reforzaron los siguientes conocimientos:

- Programación Orientada a Objetos.
- Colecciones dinámicas.
- DataGridView.
- Validación de formularios.
- Expresiones regulares.
- Formularios MDI.
- Enumeraciones.
- Generación de números aleatorios.
- Algoritmos de simulación.
- Manejo de eventos en Windows Forms.

---

## Autor y Contexto

- Nombre: Johandry González
- Institución: Universidad Tecnológica de Panamá (UTP)
- Asignatura: Herramientas de programación 3
- Laboratorio #3
- Fecha de Realización: 14/09/2026

---

## Referencias

- Material proporcionado por el docente
