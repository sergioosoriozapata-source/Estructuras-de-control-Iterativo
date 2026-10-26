using System;

namespace Seccion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

            // 1. Bucle while: Control de acceso
            string clave = "sena2025";
            int intentos = 0;
            int maxIntentos = 3;
            bool accesoConcedido = false;

            Console.WriteLine("=== CONTROL DE ACCESO ===");
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
                Console.WriteLine("\nSaliendo del sistema por bloqueo de acceso.");
                return;
            }

            // 2. Bucle do-while: Menú interactivo
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
            } while (opcion != 3);
        }
    }
}
