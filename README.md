# Laboratorio 5.6 — Clase `Producto`

**CodeArt Academy · Fundamentos de Programación con C#**
Semana 5 · Día 1 — Clases y Objetos · Proyecto: *Sistema de Inventario*

## Descripción

Aplicación de consola en C# que representa los productos de una empresa comercial mediante objetos. Es la primera etapa de un sistema de inventario: se define la clase `Producto`, que guarda los datos básicos de cada artículo, muestra su información y calcula el valor monetario de las unidades disponibles.

## Objetivo

Diseñar e implementar la clase `Producto` en C# para:

- Almacenar las características de un producto.
- Mostrar su información en consola.
- Calcular el valor total del inventario del producto (`Precio × Cantidad`).

## Estructura del proyecto

```
├── Producto.cs     # Definición de la clase Producto (propiedades y métodos)
├── Program.cs      # Punto de entrada: crea los objetos e invoca sus métodos
└── README.md
```

## Modelo de la clase

```
Producto
───────────────────────────────
+ Codigo: string
+ Nombre: string
+ Precio: decimal
+ Cantidad: int
───────────────────────────────
+ MostrarInformacion(): void
+ CalcularValorTotal(): decimal
```

| Miembro | Tipo | Descripción |
|---|---|---|
| `Codigo` | `string` | Identificador del producto (ej. `P001`). |
| `Nombre` | `string` | Nombre descriptivo del producto. |
| `Precio` | `decimal` | Precio unitario en RD$. Se usa `decimal` por ser un monto monetario. |
| `Cantidad` | `int` | Unidades disponibles. |
| `MostrarInformacion()` | `void` | Imprime en consola las cuatro propiedades del producto. |
| `CalcularValorTotal()` | `decimal` | Devuelve `Precio × Cantidad`. |

## Reglas de negocio

| ID | Regla |
|---|---|
| RN-01 | Cada producto debe tener código y nombre. |
| RN-02 | El precio debe ser mayor o igual a cero. |
| RN-03 | La cantidad disponible debe ser mayor o igual a cero. |
| RN-04 | El valor total es `Precio × Cantidad`. |
| RN-05 | Cada objeto mantiene información independiente. |
| RN-06 | Las pruebas usan datos que cumplen las reglas anteriores. |

> En esta etapa las reglas se comprueban con los datos de prueba. La protección del estado mediante encapsulamiento se implementa en el Día 2.

## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) 6.0 o superior
- Git (opcional, para clonar el repositorio)

## Instalación y ejecución

```bash
# Clonar el repositorio
git clone https://github.com/<usuario>/<repositorio>.git
cd <repositorio>

# Compilar
dotnet build

# Ejecutar
dotnet run
```

También se puede abrir el proyecto en Visual Studio o VS Code y ejecutarlo con **F5**.

## Uso

`Program.cs` crea al menos tres objetos `Producto` con `new`, asigna sus propiedades, llama a `MostrarInformacion()` y muestra el resultado de `CalcularValorTotal()` para cada uno.

Ejemplo:

```csharp
Producto producto1 = new Producto();
producto1.Codigo = "P001";
producto1.Nombre = "Laptop";
producto1.Precio = 100m;
producto1.Cantidad = 5;

producto1.MostrarInformacion();
Console.WriteLine($"Valor total: RD${producto1.CalcularValorTotal()}");
```

Salida esperada:

```
Código: P001
Nombre: Laptop
Precio: RD$100
Cantidad: 5
Valor total: RD$500
```

## Casos de prueba

| ID | Escenario | Resultado esperado |
|---|---|---|
| CP-01 | Crear un objeto `Producto` | Instancia creada correctamente. |
| CP-02 | Asignar `P001` y `Laptop` | Se muestran ambos valores. |
| CP-03 | Precio RD$100 y cantidad 5 | Valor total RD$500. |
| CP-04 | Precio RD$250 y cantidad 0 | Valor total RD$0. |
| CP-05 | Crear tres productos distintos | Cada objeto conserva sus datos. |
| CP-06 | Ejecutar `MostrarInformacion()` | Se muestran las cuatro propiedades. |
| CP-07 | Ejecutar `CalcularValorTotal()` | Devuelve el cálculo correcto. |
| CP-08 | Modificar el precio de un producto | Los demás objetos no se ven afectados. |

Las capturas de la ejecución se encuentran en la carpeta [`evidencias/`](evidencias/).

## Matriz de trazabilidad

| Requerimientos | Casos de uso | Pruebas |
|---|---|---|
| RF-01, RF-06 | CU-01 Crear producto | CP-01 |
| RF-02 a RF-05, RF-07 | CU-02 Asignar información | CP-02, CP-05 |
| RF-08, RF-12 | CU-03 Consultar información | CP-06 |
| RF-09, RF-10 | CU-04 Calcular valor total | CP-03, CP-04, CP-07 |
| RF-11 | CU-01, CU-02 | CP-05, CP-08 |

## Alcance

**Incluye:** aplicación de consola, clase `Producto`, propiedades automáticas, métodos, tres objetos y pruebas básicas.

**Excluye:** bases de datos, interfaces gráficas, herencia, constructores personalizados, validaciones avanzadas y gestión integral del inventario.

## Conceptos aplicados

- Clases y objetos
- Instanciación con `new`
- Propiedades automáticas (`{ get; set; }`)
- Métodos con y sin valor de retorno
- Independencia del estado entre objetos
- Uso de `decimal` para valores monetarios

## Autor

**Danaurys Hiraldo** — [GitHub](https://github.com/DHDanaurysHiraldo)