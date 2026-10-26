# Reto: Aplicación de Estructuras de Control Iterativo en C# (EV05)

**Programa de Formación:** Tecnólogo en Análisis y Desarrollo de Software (ADSO) - SENA  
**Competencia:** Implementar la solución de software de acuerdo con los requisitos de operación y modelos de referencia  
**Resultado de Aprendizaje:** Implantar el software de acuerdo con los niveles de servicio establecidos con el cliente.

---

## 1. Breve Explicación del Programa

Este programa en C# implementa la solución al reto de **Estructuras de Control Iterativo**, estructurado de forma secuencial en tres secciones principales:

1. **Sección 1 (For y Foreach):** Realiza el registro y análisis de un conjunto de calificaciones (`72, 85, 91, 60, 43, 78, 95, 55, 88, 67`). Utiliza un bucle `for` ascendente y descendente, un bucle `foreach` para calcular la suma total y el promedio del grupo, y un bucle `for` con incremento de `2` para recorrer los índices pares.
2. **Sección 2 (While y Do-While):** Simula un sistema de control de acceso mediante un bucle `while` que valida una clave secreta (`"sena2025"`) con un límite de 3 intentos. Una vez concedido el acceso, presenta un menú interactivo basado en un bucle `do-while` para consultar estadísticas de las calificaciones.
3. **Sección 3 (Break y Continue):** Aplica técnicas de búsqueda y filtrado eficiente. Emplea un bucle `for` con `break` para hallar la primera calificación reprobatoria (<60), un bucle `foreach` con `continue` para listar únicamente los estudiantes aprobados, y un bucle `for` combinado que salta notas menores a 70 y detiene la búsqueda al alcanzar o superar 95.

---

## 2. Salidas del Programa (Ejemplo de Ejecución en Consola)

```text
==================================================
  RETO: ESTRUCTURAS DE CONTROL ITERATIVO EN C#
==================================================

--- SECCIÓN 1 — For y Foreach: Registro y análisis de calificaciones ---

=== REGISTRO DE CALIFICACIONES ===
Estudiante 1: 72
Estudiante 2: 85
Estudiante 3: 91
Estudiante 4: 60
Estudiante 5: 43
Estudiante 6: 78
Estudiante 7: 95
Estudiante 8: 55
Estudiante 9: 88
Estudiante 10: 67

=== ORDEN DESCENDENTE ===
Estudiante 10: 67
Estudiante 9: 88
Estudiante 8: 55
Estudiante 7: 95
Estudiante 6: 78
Estudiante 5: 43
Estudiante 4: 60
Estudiante 3: 91
Estudiante 2: 85
Estudiante 1: 72

=== PROMEDIO DEL GRUPO ===
Suma total: 734
Promedio: 73.4

=== POSICIONES PARES ===
Posición par: 72
Posición par: 91
Posición par: 43
Posición par: 95
Posición par: 88

--------------------------------------------------

--- SECCIÓN 2 — While y Do-While: Validación y juego interactivo ---

=== CONTROL DE ACCESO ===
Ingresa la clave: sena2025
Acceso concedido.

=== MENÚ PRINCIPAL ===
1. Ver promedio del grupo
2. Ver calificación más alta
3. Salir
Elige una opción: 1
Promedio del grupo: 73.4

=== MENÚ PRINCIPAL ===
1. Ver promedio del grupo
2. Ver calificación más alta
3. Salir
Elige una opción: 2
Calificación más alta: 95

=== MENÚ PRINCIPAL ===
1. Ver promedio del grupo
2. Ver calificación más alta
3. Salir
Elige una opción: 3
Hasta luego.

--------------------------------------------------

--- SECCIÓN 3 — Break y Continue: Filtrado y búsqueda eficiente ---

=== PRIMERA CALIFICACIÓN REPROBATORIA ===
Encontrada en posición 5: 43

=== ESTUDIANTES APROBADOS ===
Aprobado: 72
Aprobado: 85
Aprobado: 91
Aprobado: 60
Aprobado: 78
Aprobado: 95
Aprobado: 88
Aprobado: 67
Total aprobados: 8

=== FILTRO COMBINADO ===
Calificación procesada: 72
Calificación procesada: 85
Calificación procesada: 91
Búsqueda detenida al encontrar: 95

==================================================
 Fin del Reto.
==================================================
```

---

## 3. Conclusiones

* **Selección del bucle adecuado:** El uso de bucles `for` es ideal para recorrer arreglos con un número conocido de elementos y controlar posiciones específicas (como índices pares o conteos descendentes). Por otro lado, `foreach` simplifica enormemente la lectura y acumulación de valores en colecciones sin necesidad de gestionar índices manualmente.
* **Control de flujo y validación:** Las estructuras `while` y `do-while` resultan indispensables para manejar interacciones con usuarios, validar credenciales con límites de intentos y mantener un menú activo hasta que se cumpla una condición de salida.
* **Optimización con `break` y `continue`:** Las sentencias de control de flujo otorgan gran eficiencia a los algoritmos de búsqueda y filtrado. `continue` permite omitir iteraciones que no cumplen con criterios específicos sin interrumpir el ciclo, mientras que `break` detiene inmediatamente la ejecución al encontrar el objetivo buscado, ahorrando ciclos de procesamiento innecesarios.

---

## 4. Instrucciones de Ejecución

Para compilar y ejecutar el proyecto desde la terminal con el SDK de .NET instalado:

```bash
dotnet run --project RetoIterativo/RetoIterativo.csproj
```
