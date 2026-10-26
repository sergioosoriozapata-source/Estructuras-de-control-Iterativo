using System;
using System.Collections.Generic;

namespace RetoIterativo
{
    class Estudiante
    {
        public string Nombre { get; set; } = string.Empty;
        public double Nota { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("  SISTEMA DE GESTIÓN DE CALIFICACIONES - SENA");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Registrar calificaciones de estudiantes");
                Console.WriteLine("2. Mostrar lista de estudiantes y notas");
                Console.WriteLine("3. Calcular estadísticas (Promedio, Nota Máxima y Mínima)");
                Console.WriteLine("4. Buscar estudiante por nombre");
                Console.WriteLine("5. Salir");
                Console.WriteLine("==================================================");
                Console.Write("Seleccione una opción (1-5): ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("\n[Error] Por favor ingrese un número válido.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("--- REGISTRO DE CALIFICACIONES ---");
                        Console.Write("¿Cuántos estudiantes desea registrar?: ");
                        
                        if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
                        {
                            for (int i = 1; i <= cantidad; i++)
                            {
                                Console.WriteLine($"\nEstudiante #{i}:");
                                Console.Write("  Nombre: ");
                                string? nombre = Console.ReadLine();

                                double nota;
                                while (true)
                                {
                                    Console.Write("  Nota (0.0 a 5.0): ");
                                    if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0.0 && nota <= 5.0)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("  [Error] Nota inválida. Ingrese un valor entre 0.0 y 5.0.");
                                }

                                listaEstudiantes.Add(new Estudiante { Nombre = nombre ?? "Sin nombre", Nota = nota });
                            }
                            Console.WriteLine("\n¡Registro completado exitosamente!");
                        }
                        else
                        {
                            Console.WriteLine("\n[Error] Cantidad no válida.");
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("--- LISTADO DE ESTUDIANTES ---");
                        if (listaEstudiantes.Count == 0)
                        {
                            Console.WriteLine("No hay estudiantes registrados en el sistema.");
                        }
                        else
                        {
                            Console.WriteLine($"{"No.",-5} {"Nombre",-25} {"Nota",-10} {"Estado",-15}");
                            Console.WriteLine(new string('-', 55));
                            
                            int index = 1;
                            foreach (var est in listaEstudiantes)
                            {
                                string estado = est.Nota >= 3.0 ? "Aprobado ✅" : "Reprobado ❌";
                                Console.WriteLine($"{index,-5} {est.Nombre,-25} {est.Nota,-10:F1} {estado,-15}");
                                index++;
                            }
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("--- ESTADÍSTICAS DEL GRUPO ---");
                        if (listaEstudiantes.Count == 0)
                        {
                            Console.WriteLine("No hay datos suficientes para calcular estadísticas.");
                        }
                        else
                        {
                            double suma = 0;
                            double notaAlta = listaEstudiantes[0].Nota;
                            double notaBaja = listaEstudiantes[0].Nota;
                            string estudianteAlto = listaEstudiantes[0].Nombre;
                            string estudianteBajo = listaEstudiantes[0].Nombre;

                            foreach (var est in listaEstudiantes)
                            {
                                suma += est.Nota;
                                if (est.Nota > notaAlta)
                                {
                                    notaAlta = est.Nota;
                                    estudianteAlto = est.Nombre;
                                }
                                if (est.Nota < notaBaja)
                                {
                                    notaBaja = est.Nota;
                                    estudianteBajo = est.Nombre;
                                }
                            }

                            double promedio = suma / listaEstudiantes.Count;

                            Console.WriteLine($"Total de estudiantes evaluados : {listaEstudiantes.Count}");
                            Console.WriteLine($"Promedio general del grupo     : {promedio:F2}");
                            Console.WriteLine($"Nota más alta                  : {notaAlta:F1} ({estudianteAlto})");
                            Console.WriteLine($"Nota más baja                  : {notaBaja:F1} ({estudianteBajo})");
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("--- BÚSQUEDA DE ESTUDIANTE ---");
                        Console.Write("Ingrese el nombre (o parte del nombre) a buscar: ");
                        string busqueda = Console.ReadLine()?.ToLower() ?? "";

                        bool encontrado = false;
                        Console.WriteLine($"\nResultados para \"{busqueda}\":");
                        foreach (var est in listaEstudiantes)
                        {
                            if (est.Nombre.ToLower().Contains(busqueda))
                            {
                                string estado = est.Nota >= 3.0 ? "Aprobado" : "Reprobado";
                                Console.WriteLine($"- Nombre: {est.Nombre} | Nota: {est.Nota:F1} | Estado: {estado}");
                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No se encontraron estudiantes con ese criterio.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("\nSaliendo del sistema. ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("\n[Error] Opción no válida. Seleccione entre 1 y 5.");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }
    }
}
