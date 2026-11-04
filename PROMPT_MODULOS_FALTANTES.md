# Prompt: completar módulos faltantes de XelaTech

> Uso: abre una sesión de OpenCode en `C:\Users\Crist\Downloads\XelaTech` y pega este archivo completo como instrucción.
> Trabaja por bloques, compila al final de cada uno y no imprimas archivos completos en la respuesta.

## CONTEXTO

WinForms en C# 7.3 / .NET Framework 4.8, namespace `XelaTech`, solución `XelaTech.slnx`, proyecto `XelaTech\XelaTech.csproj`.
Ya funcionan los módulos 1–5: clientes, técnicos, equipos, solicitudes y repuestos.
Faltan los módulos 6–10 del menú: **Gestión de Colas, Ordenamientos, Búsquedas, Reportes y Generar datos de prueba**.
Los 5 botones ya existen en `MenuPrincipal.Designer.cs` pero **no tienen evento `Click` ni formulario**.

## REGLAS

1. No reescribas los módulos existentes; solo agrega lo indicado.
2. Prohibido `Sort`, `OrderBy`, `ThenBy`, `BinarySearch` y equivalentes en los algoritmos evaluados: se implementan a mano.
3. Usa solo C# 7.3 (sin records, sin switch expressions, sin target-typed `new`).
4. Crea los formularios con controles en código dentro del constructor (**sin** `.Designer.cs` ni `.resx`) para ahorrar tokens.
5. Registra cada archivo nuevo en `XelaTech.csproj` con `<Compile Include="..." />`.
6. Valida toda entrada con `TryParse` / `Textos.TryNumero` y envuelve los handlers en `try/catch`; la app nunca debe cerrarse por un dato inválido.
7. No cambies la API pública existente; reutiliza los métodos de `Solicitud`, `Tecnico` y `Repuesto`.
8. Al terminar cada bloque ejecuta `dotnet build XelaTech.slnx -v q` y corrige hasta 0 errores.
9. No uses la consola: el proyecto es WinForms y así se queda.

## API EXISTENTE (referencia, no la modifiques)

- `Datos`: `clientes`, `tecnicos`, `equipos`, `repuestos`, `solicitudes` (`List<T>`); `colaUrgente`, `colaNormal` (`Queue<Solicitud>`); `cargaSemanal[10,6]`; `BuscarCliente/Tecnico/Equipo/EquipoPorSerie/Repuesto/Solicitud(string)`; `SolicitudActiva(Equipo)`; `QuitarDeColas(Solicitud)`.
- `Cliente`: `Codigo`, `NombreCompleto`, `NumeroTel`, `Correo`, `TipoCliente`, `CantSolis`, `RegistrarCliente`.
- `Tecnico`: `Codigo`, `NombreCompleto`, `Especialidad`, `Estado`, `CantTrabajosActivos`, `CantTrabajosFin`, `Calificaciones[5]`, `CalifPromedio`, `FilaMatriz`, `CargaCompleta`, `LimiteTrabajos=3`, `MaximoTecnicos=10`, `AtiendeTipo(tipoEquipo)`, `MotivoRechazo(tipoEquipo)`, `TomarTrabajo`, `LiberarTrabajo`, `RegistrarTecnico`.
- `Equipo`: `CodigoInterno`, `NumSerie`, `Marca`, `Modelo`, `TipoEquipo`, `EstadoFisico`, `Accesorios`, `Propietario`, `Historial`, `CostoRevision`, `HorasEstimadas`, `Descripcion`, `RegistrarEquipo`.
- `Solicitud`: `CodigoSolicitud`, `Cliente`, `Equipo`, `Prioridad`, `Estado`, `Tecnico`, `Diagnostico`, `Repuestos`, `HorasEstimadas`, `CostoManoObra`, `CostoRepuestos`, `Total`, `FechaHora`, `Calificacion`, `Historial` (`Stack<CambioEstado>`), `EsActiva`, `EnEspera`, `EsUrgente`, `EstadoTexto`, `AsignarTecnico`, `IniciarReparacion`, `RegistrarDiagnostico`, `AgregarRepuesto`, `Entregar(int)`, `Cancelar(out int)`, `DeshacerUltimoCambio(out string)`, `Resumen()`, `Ficha()`.
- `Repuesto`: `Codigo`, `Nombre`, `Categoria`, `Existencia`, `ExistenciaMin`, `CostoUnitario`, `PrecioVenta`, `CantUtilizada`, `Agotado`, `EnMinimo`, `EstadoStock`, `Consumir`, `Devolver`, `Reponer`.
- `Textos`: `De(Enum)`, `Q(double)`, `Horas(double)`, `Fecha(DateTime)`, `TryNumero(string, out double)`.
- Enums: `prioridad {MuyAlta, Alta, Normal}` (urgente = distinto de `Normal`); `estadoSolicitud {Asignada, EnProceso, Cancelada, Finalizada}`.
- Mapeo de estados (no refactorizar): recién creada/en cola = `EnEspera`; asignada = `Asignada`; diagnóstico + reparación = `EnProceso`; lista para entregar = `EnProceso` con diagnóstico; entregada = `Finalizada`; cancelada = `Cancelada`.

---

## BLOQUE 1 — `Algoritmos.cs` (nuevo, sin UI)

Clase `public static class Algoritmos` con implementaciones manuales:

```csharp
void BubbleSortSolicitudesPorTotal(List<Solicitud> l, bool asc)      // intercambio directo
void SelectionSortTecnicosPorServicios(List<Tecnico> l)              // descendente por CantTrabajosFin
void ShellSortRepuestosPorExistencia(List<Repuesto> l, bool asc)     // brecha n/2
void QuickSortSolicitudesPorFecha(List<Solicitud> l, int ini, int fin)
void QuickSortSolicitudesPorCodigo(List<Solicitud> l, int ini, int fin)  // string.Compare OrdinalIgnoreCase

List<Cliente>  BusquedaSecuencialClientesPorNombre(string parcial)   // Contains, sin distinguir mayúsculas
List<Solicitud> BusquedaSecuencialSolicitudesPorEstado(estadoSolicitud e)
List<Equipo>   BusquedaSecuencialEquiposPorMarca(string parcial)
bool EstaOrdenadoPorCodigo(List<Solicitud> l)
int  BusquedaBinariaSolicitudPorCodigo(List<Solicitud> l, string codigo) // -1 si no existe
```

Reglas: todas reciben listas **copias** (`new List<T>(Datos.x)`), nunca ordenan las listas originales; si la lista tiene menos de 2 elementos, no se ordena; la búsqueda binaria devuelve -1 si `EstaOrdenadoPorCodigo` es falso.

---

## BLOQUE 2 — `Colas.cs` (nuevo formulario)

Título "Atención de colas". Controles: `ListBox lstUrgente`, `ListBox lstNormal`, etiquetas de conteo, y botones `Atender siguiente`, `Iniciar reparación`, `Diagnóstico`, `Repuesto`, `Entregar`, `Cancelar`, `Historial (pila)`, `Deshacer`, `Volver`. Más los campos de texto necesarios (diagnóstico multilínea, mano de obra, código/cantidad de repuesto, calificación).

- `Refrescar()`: limpia y llena ambos ListBox recorriendo `colaUrgente` y `colaNormal` **sin desencolar**, mostrando `codigo | cliente | tipoEquipo | espera`.
- `Atender siguiente`: si `colaUrgente.Count > 0` usa esa cola; si no, la normal. Si ambas están vacías: aviso y return. Toma `Peek`, busca el mejor técnico, asigna y solo entonces `Dequeue`.
- `MejorTecnico(tipoEquipo tipo)`: recorre `Datos.tecnicos`, descarta con `MotivoRechazo(tipo) != null` y elige el de **menor `CantTrabajosActivos`**; empate por mayor `CalifPromedio`; empate final por código. Sin LINQ.
- Si ningún técnico sirve: mensaje "No hay técnico disponible con la especialidad requerida" y la solicitud permanece en su cola (desencolar y reencolar al final o no desencolar).
- `Iniciar/Diagnóstico/Repuesto/Entregar/Cancelar/Deshacer` operan sobre la solicitud seleccionada en cualquiera de los dos ListBox y **delegan** en los métodos ya existentes de `Solicitud`; solo muestran el error o el éxito y llaman `Refrescar()`.
- `Historial`: muestra `solicitud.Ficha()` en un `MessageBox`.
- Validaciones: no operar sin selección, no atender si la cola está vacía, no reasignar una solicitud ya asignada, avisar si el repuesto no existe o la cantidad no es entera o `<= 0`.

---

## BLOQUE 3 — `Ordenamientos.cs` (nuevo formulario)

Título "Ordenamientos". `ComboBox` con 4 opciones, `DataGridView dgv` y botones `Ordenar`, `Volver`.

1. **Bubble Sort** — solicitudes por costo total, descendente.
2. **Selection Sort** — técnicos por servicios finalizados, descendente.
3. **Shell Sort** — repuestos por existencia, ascendente.
4. **Quick Sort** — solicitudes por fecha de recepción, ascendente.

Cada ejecución: valida que existan al menos 2 registros ("No hay datos suficientes para ordenar"), ordena una copia con `Algoritmos`, llena el `DataGridView` y muestra un encabezado literal con **algoritmo, criterio y orden**, por ejemplo: `Bubble Sort | criterio: costo total | orden: descendente`.

---

## BLOQUE 4 — `Busquedas.cs` (nuevo formulario)

Título "Búsquedas". `ComboBox` con 4 opciones, `TextBox` de criterio, `DataGridView` de resultados, botones `Buscar`, `Volver`.

1. Secuencial de clientes por **nombre parcial** (muestra todas las coincidencias).
2. Secuencial de solicitudes por **estado** (el criterio se elige con un segundo `ComboBox` de `estadoSolicitud`).
3. Secuencial de equipos por **marca** (parcial).
4. **Binaria** de solicitud por **código**: primero `QuickSortSolicitudesPorCodigo` sobre una copia, verifica `EstaOrdenadoPorCodigo`, luego `BusquedaBinariaSolicitudPorCodigo`. Muestra el encabezado `Ordenado por código (Quick Sort, ascendente) antes de la búsqueda binaria`.

Valida lista vacía ("No hay registros para buscar") y criterio vacío. La búsqueda binaria debe rechazar datos no ordenados en lugar de ejecutarse igual.

---

## BLOQUE 5 — `Reportes.cs` (nuevo formulario)

Título "Reportes". `ComboBox` con los 12 reportes, `RichTextBox` de salida, botones `Generar`, `Volver`. Todo se construye con `StringBuilder` desde `Datos`; **nada de resultados escritos a mano**.

1. Solicitudes en espera separadas por prioridad (urgentes / normales).
2. Solicitudes activas, finalizadas y canceladas (conteo y listado).
3. Técnicos disponibles y técnicos con carga completa.
4. Técnico con más servicios finalizados (recorrido manual de máximo).
5. Equipos atendidos por tipo (contar el historial de cada equipo o las solicitudes).
6. Solicitudes por costo total — **Bubble Sort, descendente**.
7. Solicitudes por fecha o tiempo estimado — **Quick Sort, ascendente**.
8. Repuestos por existencia — **Shell Sort, ascendente**.
9. Repuestos en existencia mínima o agotados.
10. Ingresos totales por servicios finalizados (suma de `Total`).
11. Resultados de las tres búsquedas secuenciales (resumen de coincidencias).
12. Matriz semanal de carga: imprime la matriz `Datos.cargaSemanal` con encabezados Lun–Sáb y técnicos por `FilaMatriz`, y señala el técnico y el día con mayor carga (recorrido manual).

Los reportes 6, 7 y 8 llevan encabezado con algoritmo, criterio y orden. Si no hay datos, el reporte lo indica sin lanzar excepción.

---

## BLOQUE 6 — `DatosPrueba.cs` (nuevo formulario)

Título "Generar datos de prueba". `NumericUpDown` (5–20), botón `Generar`, etiqueta de resumen, botón `Volver`.

- Un solo `Random rnd = new Random();` y códigos únicos con contador (`cli01`, `tec01`, `equ01`, `rep01`, `sol01`), verificando con `Datos.BuscarX` que no existan.
- Genera: clientes (teléfono de 8 dígitos, correo `codigo@correo.com`, tipo aleatorio), técnicos (especialidad rotando entre las 4 para garantizar cobertura, estado `Disponible`, sin pasar de `MaximoTecnicos`), equipos (tipo aleatorio, serie única `SN-####`, propietario existente, accesorios), repuestos (existencia 5–50, mínima 5–10, costo 20–500, precio = costo × 1.3) y solicitudes (cliente y equipo existentes, descripción de al menos 10 caracteres, prioridad aleatoria entre las 3).
- Todas las altas pasan por los constructores y `RegistrarX` existentes, respetando validaciones; las solicitudes quedan en la cola correspondiente.
- Al final muestra cuántos registros de cada tipo se crearon y cuántos quedaron en cada cola. Si se vuelve a pulsar, no debe duplicar códigos.

---

## BLOQUE 7 — Conectar el menú y el proyecto

1. En `MenuPrincipal.Designer.cs` agrega el `Click` de los 5 botones que ya existen, junto a su bloque actual:
   `this.btnGesColas.Click += new System.EventHandler(this.btnGesColas_Click);` y equivalentes para `btnOrdenamientos`, `btnBusquedas`, `btnReportes`, `btnGenerarDatos`.
2. En `MenuPrincipal.cs` agrega los 5 handlers con el patrón existente: `new Colas().Show(); this.Hide();` (cada formulario nuevo, al cerrarse, hace `new MenuPrincipal().Show();` en `FormClosed`, igual que los demás).
3. Agrega las 5 entradas `<Compile Include="..."/>` en `XelaTech.csproj` dentro del `ItemGroup` de compilación.

---

## CRITERIOS DE ACEPTACIÓN

- `dotnet build XelaTech.slnx -v q` termina con **0 errores**.
- `Select-String -Path XelaTech\*.cs -Pattern "\.Sort\(|OrderBy|ThenBy|BinarySearch"` no devuelve coincidencias en los algoritmos.
- Los 5 botones del menú abren su formulario y al cerrarlo se regresa al menú.
- La cola urgente siempre se atiende antes que la normal y respeta FIFO dentro de cada una.
- La asignación automática respeta especialidad, disponibilidad y límite de 3 trabajos.
- No se puede usar la búsqueda binaria sin ordenar antes por código.
- Los reportes se arman con datos reales y muestran algoritmo, criterio y orden cuando aplica.
- Los datos de prueba respetan validaciones y no duplican códigos.

## ORDEN DE TRABAJO

`Algoritmos.cs` → `Colas` → `Ordenamientos` → `Busquedas` → `Reportes` → `DatosPrueba` → menú + csproj → build.

> Fuera de alcance (no tocar en esta tarea): migrar a consola, refactorizar el enum de estados, agregar herencia de equipos o sobrecarga de métodos. Eso se resuelve en una tarea aparte.
