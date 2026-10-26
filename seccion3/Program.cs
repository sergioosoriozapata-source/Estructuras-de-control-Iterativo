using System;

namespace Seccion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

            // 1. Bucle for con break: Primera calificación reprobatoria
            Console.WriteLine("=== PRIMERA CALIFICACIÓN REPROBATORIA ===");
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
