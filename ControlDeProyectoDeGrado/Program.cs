using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ControlDeProyectoDeGrado
{
    class Program
    {
        
        static string colorsubrayado = "  \u001b[30m\u001b[47m";        

        static void Main(string[] args)
        {
            int menuopcion;
            ArrayList AProyecto = new ArrayList();
            Proyectos proyectos = new Proyectos();
            ArrayList AEstudiantes = new ArrayList();
            Estudiantes estudiantes = new Estudiantes();

            do
            {
                Console.Clear();
                Cuadro(1, 80, 1, 25);
                Titulos();
                menuopcion = MenuChoice();
                DoChoice(menuopcion, AProyecto, proyectos);
            } while (menuopcion != 0);


        }
        public static void Cuadro(int x1, int x2, int y1, int y2)
        {


            //Lineas horizontales

            for (int x = x1; x <= x2; x++)
            {
                Console.SetCursorPosition(x, y1); Console.Write("═");
                Console.SetCursorPosition(x, y2); Console.Write("═");
            }

            //Lineas verticales

            for (int y = y1; y <= y2; y++)
            {
                Console.SetCursorPosition(x1, y); Console.Write("║");
                Console.SetCursorPosition(x2, y); Console.Write("║");
            }

            Console.SetCursorPosition(x1, y1); Console.Write("╔");
            Console.SetCursorPosition(x2, y1); Console.Write("╗");
            Console.SetCursorPosition(x1, y2); Console.Write("╚");
            Console.SetCursorPosition(x2, y2); Console.Write("╝");
            Console.SetCursorPosition(x1, y2 + 1); Console.Write("Wilber Alejo 2018-0304");
            Console.SetCursorPosition(x1, y2 + 2); Console.Write("Francisco Javier");


        }
        public static void Titulos()
        {
            string t1 = "Control de trabajo de grado",
                t2 = "-------------------",
                t3 = "Utilizado para estudios",
                t4 = "M e n u    P r i n c i p a l";
            Console.SetCursorPosition((80 - t1.Length) / 2, 2); Console.Write(t1);
            Console.SetCursorPosition((80 - t2.Length) / 2, 3); Console.Write(t2);
            Console.SetCursorPosition((80 - t3.Length) / 2, 4); Console.Write(t3);
            Console.SetCursorPosition((80 - t4.Length) / 2, 5); Console.Write(t4);


        }
        /*public static void Menu()
        {
            string color = "\u001b[30m";
            int opcolor = 1;
            Console.SetCursorPosition(29, 8); Console.Write("\u001b[4mSeleccione su opcion:\u001b[0m");
            Console.SetCursorPosition(15, 10); Console.Write($"{(opcolor==1 ? color:"  ")}1- Resgistrar proyecto de grado\u001b[0m"); 
            Console.SetCursorPosition(15, 11); Console.Write($"{(opcolor == 2 ? color : "  ")}2- Mostrar todos los proyectos\u001b[0m");
            Console.SetCursorPosition(15, 12); Console.Write($"{(opcolor == 3 ? color : "  ")}3- Calificar\u001b[0m");
            Console.SetCursorPosition(15, 13); Console.Write($"{(opcolor == 4 ? color : "  ")}4- Consultar datos de los proyectos y calificaciones\u001b[0m");
            Console.SetCursorPosition(15, 14); Console.Write($"{(opcolor == 5 ? color : "  ")}5- Salir\u001b[0m");
            //Console.SetCursorPosition(15, 13); Console.Write("6-");
            //Console.SetCursorPosition(15, 15); Console.Write("0-");   
        }*/


        public static int MenuChoice()
        {
            int op = 1;
            ConsoleKeyInfo seleccion = new ConsoleKeyInfo();
            do
            {
                Console.CursorVisible = false;                
                Console.SetCursorPosition(29, 8); Console.Write("\u001b[4mSeleccione su opcion:\u001b[0m");
                Console.SetCursorPosition(15, 10); Console.Write($"{(op == 1 ? colorsubrayado : "  ")}1- Resgistrar proyecto de grado\u001b[0m");
                Console.SetCursorPosition(15, 11); Console.Write($"{(op == 2 ? colorsubrayado : "  ")}2- Mostrar todos los proyectos\u001b[0m");
                Console.SetCursorPosition(15, 12); Console.Write($"{(op == 3 ? colorsubrayado : "  ")}3- Calificar  \u001b[0m");
                Console.SetCursorPosition(15, 13); Console.Write($"{(op == 4 ? colorsubrayado : "  ")}4- Consultar datos de los proyectos y calificaciones\u001b[0m");
                Console.SetCursorPosition(15, 14); Console.Write($"{(op == 5 ? colorsubrayado : "  ")}5- Salir\u001b[0m");
                //Console.SetCursorPosition(15, 13); Console.Write("6-");
                //Console.SetCursorPosition(15, 15); Console.Write("0-");   


                seleccion = Console.ReadKey(true);
                if (seleccion.Key == ConsoleKey.DownArrow)
                {
                    op++;
                }
                else if (seleccion.Key == ConsoleKey.UpArrow)
                {
                    op--;
                }
                else if (seleccion.Key == ConsoleKey.F1)
                {

                    op = 100;
                    return op;
                }

                if (op < 1)
                {
                    op = 5;
                }
                else if (op > 5)
                {
                    op = 1;
                }
               
            } while (seleccion.Key != ConsoleKey.Enter);
            Console.CursorVisible = true;
            return op;
            /* try
                {


                    Console.SetCursorPosition(15, 15); Console.Write("Su opcion es......:");
                    op = Convert.ToInt32(Console.ReadLine());
                    if (op < 0 || op > 5)
                    {
                         Console.SetCursorPosition(20, 24); Console.WriteLine("Ha elegido una opcion no valida");
                    }
                }
                catch (Exception e)
                {
                    Console.SetCursorPosition(20, 24); Console.WriteLine(e.Message);
                    Console.SetCursorPosition(20, 24); Console.WriteLine("                                          ");
                    Console.SetCursorPosition(20, 24); Console.WriteLine("Ha elegido una opcion no valida");
                }*/

        }

        public static void DoChoice(int opcion, ArrayList AProyecto, Proyectos proyectos)
        {

            switch (opcion)
            {
                case 1:
                    Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break;

                case 2:
                    Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break;

                case 3:
                    Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break; ;

                case 4:
                    Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break;

                case 5:
                    Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break;

                case 6:
                    //ConsultaCategria(ACategoria, categoria);
                    //Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break;

            }

        }

        public static void hola()
        {
            Console.WriteLine("Hola");
            Console.ReadKey();
        }


        public static void prueba()
        {

            Console.Write("Ingresa una fecha (formato dd/mm/yyyy): ");
            string input = Console.ReadLine();

            DateTime fecha;

            if (DateTime.TryParse(input, out fecha))
            {
                Console.WriteLine("La fecha ingresada es: " + fecha);
            }
            else
            {
                Console.WriteLine("El formato de fecha ingresado es incorrecto.");
               
            }

            Console.ReadLine();

        }

    }//
}//
