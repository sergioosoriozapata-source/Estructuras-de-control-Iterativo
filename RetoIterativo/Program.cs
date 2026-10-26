using System;

namespace RetoIterativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine(" RETO: ESTRUCTURAS DE CONTROL ITERATIVO EN C#");
            Console.WriteLine("==================================================\n");

            // ==========================================
            // SECCIÓN 1 — For y Foreach: Registro y análisis
            // ==========================================
            Console.WriteLine("--- SECCIÓN 1: REGISTRO Y ANÁLISIS DE CALIFICACIONES ---");
            
            int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

            // 1. Recorrido con bucle for (ascendente)
            Console.WriteLine("\n=== REGISTRO DE CALIFICACIONES ===");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
            }

            // 2. Recorrido descendente con bucle for
            Console.WriteLine("\n=== ORDEN DESCENDENTE ===");
            for (int i = calificaciones.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
            }

            // 3. Suma total y promedio con foreach
            Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");
            int sumaTotal = 0;
            foreach (var cal in calificaciones)
            {
                sumaTotal += cal;
            }
            double promedio = (double)sumaTotal / calificaciones.Length;
            Console.WriteLine($"Suma total: {sumaTotal}");
            Console.WriteLine($"Promedio: {promedio:F1}");

            // 4. Recorrido de posiciones pares con for (incremento de 2)
            Console.WriteLine("\n=== POSICIONES PARES ===");
            for (int i = 0; i < calificaciones.Length; i += 2)
            {
                Console.WriteLine($"Posición par: {calificaciones[i]}");
            }

            Console.WriteLine("\n--------------------------------------------------");

            // ==========================================
            // SECCIÓN 2 — While y Do-While: Validación y menú
            // ==========================================
            Console.WriteLine("\n--- SECCIÓN 2: CONTROL DE ACCESO Y MENÚ INTERACTIVO ---");

            // 1. Sistema de acceso con while
            string claveCorrecta = "sena2025";
            int intentos = 0;
            int maxIntentos = 3;
            bool accesoConcedido = false;

            Console.WriteLine("\n=== CONTROL DE ACCESO ===");
            while (intentos < maxIntentos)
            {
                Console.Write("Ingresa la clave: ");
                string? ingreso = Console.ReadLine();

                if (ingreso == claveCorrecta)
                {
                    Console.WriteLine("Acceso concedido.");
                    accesoConcedido = true;
                    break;
                }
                else
                {
                    intentos++;
                    int intentosRestantes = maxIntentos - intentos;
                    if (intentosRestantes > 0)
                    {
                        Console.WriteLine($"Clave incorrecta. Intentos restantes: {intentosRestantes}");
                    }
                    else
                    {
                        Console.WriteLine("Acceso bloqueado.");
                    }
                }
            }

            if (!accesoConcedido)
            {
                Console.WriteLine("\nDemasiados intentos fallidos. Saliendo del sistema.");
                return;
            }

            // 2. Menú interactivo con do-while
            int opcion;
            do
            {
                Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Ver promedio del grupo");
                Console.WriteLine("2. Ver calificación más alta");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Promedio del grupo: {promedio:F1}");
                        break;
                    case 2:
                        int notaAlta = calificaciones[0];
                        foreach (var cal in calificaciones)
                        {
                            if (cal > notaAlta)
                            {
                                notaAlta = cal;
                            }
                        }
                        Console.WriteLine($"Calificación más alta: {notaAlta}");
                        break;
                    case 3:
                        Console.WriteLine("Hasta luego.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }
            } while (opcion != 3);

            Console.WriteLine("\n--------------------------------------------------");

            // ==========================================
            // SECCIÓN 3 — Break y Continue: Filtrado y búsqueda
            // ==========================================
            Console.WriteLine("\n--- SECCIÓN 3: FILTRADO Y BÚSQUEDA EFICIENTE ---");

            // 1. Primera calificación reprobatoria con for y break
            Console.WriteLine("\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");
            int posReprobatoria = -1;
            int valorReprobatorio = -1;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] < 60)
                {
                    posReprobatoria = i + 1; // Posición humana (1-based)
                    valorReprobatorio = calificaciones[i];
                    break;
                }
            }
            if (posReprobatoria != -1)
            {
                Console.WriteLine($"Encontrada en posición {posReprobatoria}: {valorReprobatorio}");
            }
            else
            {
                Console.WriteLine("No se encontraron calificaciones reprobatorias.");
            }

            // 2. Estudiantes aprobados con foreach y continue
            Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");
            int totalAprobados = 0;
            foreach (var cal in calificaciones)
            {
                if (cal < 60)
                {
                    continue;
                }
                Console.WriteLine($"Aprobado: {cal}");
                totalAprobados++;
            }
            Console.WriteLine($"Total aprobados: {totalAprobados}");

            // 3. Filtro combinado con break y continue
            Console.WriteLine("\n=== FILTRO COMBINADO ===");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                int cal = calificaciones[i];
                if (cal < 70)
                {
                    continue; // Salta las menores a 70
                }
                if (cal >= 95)
                {
                    Console.WriteLine($"Búsqueda detenida al encontrar: {cal}");
                    break; // Detiene al encontrar 95 o más
                }
                Console.WriteLine($"Calificación procesada: {cal}");
            }

            Console.WriteLine("\n==================================================");
            Console.WriteLine(" Fin del Reto.");
            Console.WriteLine("==================================================");
        }
    }
}
