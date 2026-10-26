using System;

namespace Seccion1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

            // 2. Bucle for ascendente
            Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");
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

            // 5. Bucle for con incremento de 2 (índices pares)
            Console.WriteLine("\n=== POSICIONES PARES ===");
            for (int i = 0; i < calificaciones.Length; i += 2)
            {
                Console.WriteLine($"Posición par: {calificaciones[i]}");
            }
        }
    }
}
