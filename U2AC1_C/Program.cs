           using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;
            using System.Threading;

namespace ConsoleApp12
    {
        class Program
        {
            static void Main(string[] args)
            {

            // Manejo de estructuras selectivas 

            // Declaracion de variables
            string nombreDeAlumno, apellidoPaterno, apellidoMaterno, materiaCursada, semestre, gradoYseccion;
            byte   calificacion;


                

                // Asignacion de variables 
                Console.WriteLine("Ingresa el nombre del alumno: ");
                nombreDeAlumno = Console.ReadLine();

                Console.WriteLine("Ingresa su apellido paterno: ");
                apellidoPaterno = Console.ReadLine();

                Console.WriteLine("Ingresa su apellido materno: ");
                apellidoMaterno = Console.ReadLine();

                 Console.WriteLine("Ingresa la materia cursada o curso cursado: ");
                 materiaCursada = Console.ReadLine();

                Console.WriteLine("Ingresa el semestre que curso: ");
                semestre = Console.ReadLine();

                Console.WriteLine("Ingresa su grado y seccion: ");
                gradoYseccion = Console.ReadLine();

                Console.WriteLine("Ingrese su calificacion: ");
                calificacion = Convert.ToByte(Console.ReadLine());




            // Estructura selectiva if 

            if (calificacion >= 70)
            {

                // Cambiamos la personalizacion de la ventana
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();

                Console.WriteLine("\n");
                Console.WriteLine("El alumno: {0}", nombreDeAlumno);
                Console.WriteLine("Ah acreditado la materia cursada o curso: {0}", materiaCursada);
                Console.WriteLine("Con una calificacion de: {0}", calificacion);

            }
            
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("El alumno: {0}", nombreDeAlumno);
                Console.WriteLine("Ah reprobado la materia cursada o curso: {0}", materiaCursada);
                Console.WriteLine("Con una calificacion de: {0}", calificacion);




            }



                Console.WriteLine("Saliendo de system");
                Thread.Sleep(1000);
                Console.WriteLine("Saliendo de system");
                Thread.Sleep(1000);
                Console.WriteLine("Saliendo de system");
                Thread.Sleep(1000);
            }
        }
}

    

