using System;

namespace EjemplosIterativos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine(" DEMOSTRACIÓN DE ESTRUCTURAS DE CONTROL ITERATIVO");
            Console.WriteLine("==================================================\n");

            // 1. Ciclo FOR
            Console.WriteLine("--- 1. CICLO FOR (Tabla de multiplicar) ---");
            Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
            }
            else
            {
                Console.WriteLine("Número no válido.");
            }

            Console.WriteLine("\n--------------------------------------------------\n");

            // 2. Ciclo WHILE
            Console.WriteLine("--- 2. CICLO WHILE (Contador regresivo) ---");
            int contador = 5;
            while (contador > 0)
            {
                Console.WriteLine($"Despegue en: {contador}...");
                contador--;
            }
            Console.WriteLine("¡Despegue! 🚀\n");

            Console.WriteLine("--------------------------------------------------\n");

            // 3. Ciclo DO-WHILE
            Console.WriteLine("--- 3. CICLO DO-WHILE (Validación de contraseña) ---");
            string? password = string.Empty;
            do
            {
                Console.Write("Ingrese la contraseña secreta (clave123): ");
                password = Console.ReadLine();
                if (password != "clave123")
                {
                    Console.WriteLine("Contraseña incorrecta. Intente nuevamente.");
                }
            } while (password != "clave123");
            Console.WriteLine("¡Acceso concedido!\n");

            Console.WriteLine("--------------------------------------------------\n");

            // 4. Ciclo FOREACH
            Console.WriteLine("--- 4. CICLO FOREACH (Recorrido de colección) ---");
            string[] modulosSENA = {
                "Análisis y Desarrollo de Software",
                "Programación Orientada a Objetos",
                "Estructuras de Control",
                "Bases de Datos",
                "Desarrollo Web y Móvil"
            };

            Console.WriteLine("Módulos del programa de formación:");
            foreach (var modulo in modulosSENA)
            {
                Console.WriteLine($"- {modulo}");
            }

            Console.WriteLine("\n==================================================");
            Console.WriteLine(" Fin de la demostración.");
            Console.WriteLine("==================================================");
        }
    }
}
