using System;

namespace RetoIterativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("  RETO: ESTRUCTURAS DE CONTROL ITERATIVO EN C#");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Sección 1 — For y Foreach (Registro y análisis)");
                Console.WriteLine("2. Sección 2 — While y Do-While (Acceso y Menú)");
                Console.WriteLine("3. Sección 3 — Break y Continue (Filtrado y búsqueda)");
                Console.WriteLine("4. Ejecutar todas las secciones secuencialmente");
                Console.WriteLine("5. Salir");
                Console.WriteLine("==================================================");
                Console.Write("Elige una opción (1-5): ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("\n[Error] Opción no válida. Intenta de nuevo.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        EjecutarSeccion1(calificaciones);
                        break;

                    case 2:
                        Console.Clear();
                        EjecutarSeccion2(calificaciones);
                        break;

                    case 3:
                        Console.Clear();
                        EjecutarSeccion3(calificaciones);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("=== EJECUTANDO TODAS LAS SECCIONES ===\n");
                        EjecutarSeccion1(calificaciones);
                        Console.WriteLine("\n--------------------------------------------------");
                        EjecutarSeccion2(calificaciones);
                        Console.WriteLine("\n--------------------------------------------------");
                        EjecutarSeccion3(calificaciones);
                        break;

                    case 5:
                        Console.WriteLine("\nHasta luego.");
                        break;

                    default:
                        Console.WriteLine("\n[Error] Opción no válida. Intenta de nuevo.");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }

        static void EjecutarSeccion1(int[] calificaciones)
        {
            Console.WriteLine("--- SECCIÓN 1 — For y Foreach: Registro y análisis de calificaciones ---");

            // 2. Bucle for ascendente
            Console.WriteLine("\n=== REGISTRO DE CALIFICACIONES ===");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
            }

            // 3. Bucle for descendente
            Console.WriteLine("\n=== ORDEN DESCENDENTE ===");
            for (int i = calificaciones.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
            }

            // 4. Bucle foreach para suma y promedio
            Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");
            int sumaTotal = 0;
            foreach (var cal in calificaciones)
            {
                sumaTotal += cal;
            }
            double promedio = (double)sumaTotal / calificaciones.Length;
            Console.WriteLine($"Suma total: {sumaTotal}");
            Console.WriteLine($"Promedio: {promedio:F1}");

            // 5. Bucle for con incremento de 2 (posiciones pares)
            Console.WriteLine("\n=== POSICIONES PARES ===");
            for (int i = 0; i < calificaciones.Length; i += 2)
            {
                Console.WriteLine($"Posición par: {calificaciones[i]}");
            }
        }

        static void EjecutarSeccion2(int[] calificaciones)
        {
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
                Console.WriteLine("\nAcceso bloqueado. Regresando al menú principal.");
                return;
            }

            // 2. Bucle do-while con switch interno: Menú de opciones
            int opcionMenu;
            do
            {
                Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Ver promedio del grupo");
                Console.WriteLine("2. Ver calificación más alta");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcionMenu))
                {
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    continue;
                }

                switch (opcionMenu)
                {
                    case 1:
                        int sumaTotal = 0;
                        foreach (var cal in calificaciones)
                        {
                            sumaTotal += cal;
                        }
                        double promedio = (double)sumaTotal / calificaciones.Length;
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
            } while (opcionMenu != 3);
        }

        static void EjecutarSeccion3(int[] calificaciones)
        {
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
        }
    }
}
