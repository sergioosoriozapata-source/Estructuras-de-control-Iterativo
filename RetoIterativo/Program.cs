using System;

namespace RetoIterativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("  RETO: ESTRUCTURAS DE CONTROL ITERATIVO EN C#");
            Console.WriteLine("==================================================\n");

            int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

            // ==========================================
            // SECCIÓN 1 — For y Foreach: Registro y análisis
            // ==========================================
            Console.WriteLine("--- SECCIÓN 1 — For y Foreach: Registro y análisis de calificaciones ---");

            // 1. Bucle for ascendente
            Console.WriteLine("\n=== REGISTRO DE CALIFICACIONES ===");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
            }

            // 2. Bucle for descendente
            Console.WriteLine("\n=== ORDEN DESCENDENTE ===");
            for (int i = calificaciones.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
            }

            // 3. Bucle foreach para suma y promedio
            Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");
            int sumaTotal = 0;
            foreach (var cal in calificaciones)
            {
                sumaTotal += cal;
            }
            double promedio = (double)sumaTotal / calificaciones.Length;
            Console.WriteLine($"Suma total: {sumaTotal}");
            Console.WriteLine($"Promedio: {promedio:F1}");

            // 4. Bucle for con incremento de 2 (posiciones pares)
            Console.WriteLine("\n=== POSICIONES PARES ===");
            for (int i = 0; i < calificaciones.Length; i += 2)
            {
                Console.WriteLine($"Posición par: {calificaciones[i]}");
            }

            Console.WriteLine("\n--------------------------------------------------\n");

            // ==========================================
            // SECCIÓN 2 — While y Do-While: Validación y juego interactivo
            // ==========================================
            Console.WriteLine("--- SECCIÓN 2 — While y Do-While: Validación y juego interactivo ---");

            // 1. Bucle while: Control de acceso
            string clave = "sena2025";
            int intentos = 0;
            int maxIntentos = 3;
            bool accesoConcedido = false;

            Console.WriteLine("\n=== CONTROL DE ACCESO ===");
            while (intentos < maxIntentos)
            {
                Console.Write("Ingresa la clave: ");
                string? ingreso = Console.ReadLine();

                if (ingreso == clave)
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
                Console.WriteLine("\nAcceso bloqueado. Fin de la simulación de acceso.");
            }
            else
            {
                // 2. Bucle do-while con menú de opciones
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
            }

            Console.WriteLine("\n--------------------------------------------------\n");

            // ==========================================
            // SECCIÓN 3 — Break y Continue: Filtrado y búsqueda
            // ==========================================
            Console.WriteLine("--- SECCIÓN 3 — Break y Continue: Filtrado y búsqueda eficiente ---");

            // 1. Bucle for con break: Primera calificación reprobatoria
            Console.WriteLine("\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");
            int posicionReprobada = -1;
            int valorReprobado = -1;

            for (int i = 0; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] < 60)
                {
                    posicionReprobada = i + 1;
                    valorReprobado = calificaciones[i];
                    break;
                }
            }

            if (posicionReprobada != -1)
            {
                Console.WriteLine($"Encontrada en posición {posicionReprobada}: {valorReprobado}");
            }
            else
            {
                Console.WriteLine("No se encontraron calificaciones reprobatorias.");
            }

            // 2. Bucle foreach con continue: Estudiantes aprobados
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

            // 3. Bucle for con break y continue combinados
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
