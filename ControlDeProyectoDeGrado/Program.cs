using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ControlDeProyectoDeGrado
{
    class Program
    {
        //Para probar github
        //\u001b[30m letras en negro
        static string colorsubrayado = "\u001b[30m\u001b[47m";
        static string logrado = "\u001b[30m\u001b[42m";
        static string alerta = "\u001b[30m\u001b[41m";
        static void Main(string[] args)
        {
            int menuopcion;
            ArrayList AProyecto = new ArrayList();
            Proyectos proyectos = new Proyectos();
            ArrayList AEstudiantes = new ArrayList();
            Estudiantes estudiantes = new Estudiantes();


            AEstudiantes.Add(new Estudiantes(20230000, "Wilber", "ISC", true));
            AEstudiantes.Add(new Estudiantes(20230001, "Wilsairy", "MED", false));

            string fecha1 = "12/12/2023";
            string fecha2 = "13/12/2025";
            DateTime fecha11;
            DateTime fecha22;
            DateTime.TryParse(fecha1, out fecha11);
            DateTime.TryParse(fecha2, out fecha22);
            AProyecto.Add(new Proyectos("Gestion Proyectos De Grado", fecha11, fecha22,0,20230000,0));



            do
            {
                Console.Clear();
                Cuadro(1, 80, 1, 25);
                Titulos();
                menuopcion = MenuChoice();
                DoChoice(menuopcion, AProyecto, proyectos, AEstudiantes, estudiantes);
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
                Console.SetCursorPosition(15, 10); Console.Write($"{(op == 1 ? colorsubrayado : "")}1- Resgistrar Estudiante\u001b[0m");
                Console.SetCursorPosition(15, 11); Console.Write($"{(op == 2 ? colorsubrayado : "")}2- Registrar Proyecto de grado\u001b[0m");
                Console.SetCursorPosition(15, 12); Console.Write($"{(op == 3 ? colorsubrayado : "")}3- Consulta\u001b[0m");
                Console.SetCursorPosition(15, 13); Console.Write($"{(op == 4 ? colorsubrayado : "")}4- Calificar\u001b[0m");
                Console.SetCursorPosition(15, 14); Console.Write($"{(op == 5 ? colorsubrayado : "")}5- Salir\u001b[0m");
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
                    prueba();
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

        public static void DoChoice(int opcion, ArrayList AProyecto, Proyectos proyectos, ArrayList AEstudiantes, Estudiantes estudiantes )
        {

            switch (opcion)
            {
                case 1:
                    RegistrarEstudiantes(AEstudiantes, estudiantes);
                    break;

                case 2:
                    Registrarproyectos(AProyecto, proyectos, AEstudiantes, estudiantes);
                    break;

                case 3:
                    ConsultarDatos(AProyecto, proyectos, AEstudiantes, estudiantes);
                    break; ;

                case 4:
                    ClasificarTrabajos(AProyecto, proyectos);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;

                case 6:
                    //ConsultaCategria(ACategoria, categoria);
                    //Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break;

            }

        }

        //⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇⬇️⬇️------------Registro de estudientes------------⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️//
        public static void RegistrarEstudiantes(ArrayList AEstudiantes, Estudiantes estudiantes)
        {

            int amatricula = 0;
            string anombreapellido = "", acarrera = "";
            bool activo = true;


            Console.Clear();
            Cuadro(1,80,1,25);
            EscSalirEnCuadro();
            Console.SetCursorPosition(28, 08); Console.Write(colorsubrayado+"Registro de Estudiante");
            Console.ResetColor();


            int anomatricula = DateTime.Now.Year;
            string numerofinal = "0000";
            int matriculacompleta = int.Parse(anomatricula + numerofinal);
            int matriculacompletairevision = 0;

            bool revisandomatricula = true;
            do
            {
                foreach (Estudiantes revisar in AEstudiantes)
                {
                    matriculacompletairevision = revisar.getMatricula();
                    if (matriculacompleta == matriculacompletairevision)
                    {
                        matriculacompleta++;
                    }
                    else if(matriculacompleta != matriculacompletairevision) 
                    { 
                        revisandomatricula = false;
                        amatricula = matriculacompleta;
                    }
                    
                }
            } while (revisandomatricula == true);

            Console.SetCursorPosition(28, 12); Console.Write("Matricula:");
            Console.SetCursorPosition(38, 12); Console.Write(amatricula);








            bool igualadonombreyapellido = true;
            string arraydenombreyapelido = "";
            string nombreyapellidoigual = "";
            bool nombrevacio = false;
            do
            {

                Console.SetCursorPosition(28, 13); Console.Write("Nombre y Apellido:");

                ConsoleKeyInfo InicialNombre = new ConsoleKeyInfo();



               // do
               // {
                    nombrevacio = true;


                while (nombrevacio == true)
                {
                    InicialNombre = Console.ReadKey();
                    if (InicialNombre.Key == ConsoleKey.Enter)
                    {
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(21, 23); Console.WriteLine(alerta + "Debe de dijitar el nombre del estudiante");
                        Console.SetCursorPosition(23, 24); Console.WriteLine(logrado + "Presione enter para volver a dijitar");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.SetCursorPosition(20, 23); Console.WriteLine("                                               ");
                        Console.SetCursorPosition(20, 24); Console.WriteLine("                                               ");
                        Console.SetCursorPosition(46, 13);
                        Console.CursorVisible = true;
                        nombrevacio = true;
                    }
                    else if (InicialNombre.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                    else { nombrevacio = false; }

                }
                    
                    char letra = InicialNombre.KeyChar;
                    anombreapellido = Convert.ToString(letra + Console.ReadLine());
                    nombrevacio = false;


                // } while (nombrevacio == true);


                //anombreapellido = Convert.ToString(Console.ReadLine());


                /*if (string.IsNullOrEmpty(anombreapellido))
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(21, 23); Console.WriteLine(alerta+"Debe de dijitar el nombre del estudiante"+reinicio);
                    Console.SetCursorPosition(23, 24); Console.WriteLine(logrado+"Presione enter para volver a dijitar" + reinicio);
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.SetCursorPosition(20, 23); Console.WriteLine("                                               ");
                    Console.SetCursorPosition(20, 24); Console.WriteLine("                                               ");
                    Console.CursorVisible = true;
                    nombrevacio = true;
                }*/
                //else
                // {
                foreach (Estudiantes revisar in AEstudiantes)
                {
                    arraydenombreyapelido = revisar.getNombreApellido();
                    if (arraydenombreyapelido == anombreapellido)
                    {
                        nombreyapellidoigual = arraydenombreyapelido;
                        nombrevacio = false;

                    }
                }
               // }

                if (nombreyapellidoigual == anombreapellido && nombrevacio == false)
                {
                    Console.CursorVisible = false;
                    Console.Clear();
                    Cuadro(1, 80, 1, 25);
                    Console.SetCursorPosition(16, 11); Console.Write(alerta+"Este estudiante ya esta registrado en un proyecto");
                    Console.SetCursorPosition(23, 12); Console.WriteLine(logrado+"Presione enter para volver al menu");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.CursorVisible = true;
                    return;

                }
                else if (nombreyapellidoigual != anombreapellido && nombrevacio == false)
                {
                    igualadonombreyapellido = false;
                }

                nombrevacio = false;


            } while (igualadonombreyapellido == true);


            bool selecciondecarrera = true;
            do
            {

                Console.SetCursorPosition(13, 15); Console.Write("\u001b[4mSeleccione la carrera correspondiente a la tecla asignada:\u001b[0m");
                Console.SetCursorPosition(23, 16); Console.Write("|  q: ING | w: IIN | e: ARG | r: MED  |");
                Console.CursorVisible = false;
                ConsoleKeyInfo BotonCarrera = new ConsoleKeyInfo();
                BotonCarrera = Console.ReadKey(true);
                Console.CursorVisible = true;


                switch (BotonCarrera.Key)
                {
                    case ConsoleKey.Q:
                        acarrera = "ISC";
                        Console.SetCursorPosition(36, 11); Console.Write("ISC");
                        selecciondecarrera = false;
                        break;

                    case ConsoleKey.W:
                        acarrera = "IIN";
                        Console.SetCursorPosition(36, 11); Console.Write("IIN");
                        selecciondecarrera = false;
                        break;

                    case ConsoleKey.E:
                        acarrera = "AGR";
                        Console.SetCursorPosition(36, 11); Console.Write("AGR");
                        selecciondecarrera = false;
                        break;

                    case ConsoleKey.R:
                        acarrera = "MED";
                        Console.SetCursorPosition(36, 11); Console.Write("MED");
                        selecciondecarrera = false;
                        break;

                    case ConsoleKey.Y:
                        acarrera = "MED";
                        Console.SetCursorPosition(36, 11); Console.Write("MED");
                        selecciondecarrera = false;
                        break;

                    case ConsoleKey.Escape:
                        return;

                }

                if (selecciondecarrera == true)
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(26, 23); Console.WriteLine(alerta + "Selecciona una opcion correcta");
                    Console.SetCursorPosition(23, 24); Console.WriteLine(logrado + "Presione enter para volver a dijitar");
                    Console.ReadKey(true);
                    Console.ResetColor();
                    Console.SetCursorPosition(20, 23); Console.WriteLine("                                               ");
                    Console.SetCursorPosition(20, 24); Console.WriteLine("                                               ");
                    Console.CursorVisible = false;
                }

            } while (selecciondecarrera == true);



            AEstudiantes.Add(new Estudiantes(amatricula, anombreapellido, acarrera, activo));

        }

        //⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️------------Registro de estudientes------------⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️//

        //⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇⬇️⬇️------------Consultar------------⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️//

        public static void ConsultarDatos(ArrayList AProyec, Proyectos proyecto, ArrayList AEstudiantes, Estudiantes estudiantes)
        {
            Console.Clear();
            bool BuscarInactivo = true;
            while (BuscarInactivo == true)
            {
                Console.Clear();
                int fila = 8;
                Console.SetCursorPosition(45, 1); Console.Write(colorsubrayado+"Consulta de Proyectos");
                Console.SetCursorPosition(0, 6); Console.Write(colorsubrayado + "C.U| Matricula |   Nombre y Apellido    |    Nombre Del Proyecto    |Fecha inicio|Fecha Entrega|  Calificacion  | A/I ");
                Console.ResetColor();
                for (int linea = 0; linea <= 117; linea++)
                {
                    Console.SetCursorPosition(linea, 7); Console.Write("-");
                }

                Console.ResetColor();

                foreach (Estudiantes mostrar in AEstudiantes)
                {
                    //bool acti = mostrar.getActivo();
                    int consultaestudiante = mostrar.getMatricula();


                    //if (acti == true)
                    //{
                        Console.SetCursorPosition(0, fila); Console.Write(mostrar.getCarrera());
                        Console.SetCursorPosition(5, fila); Console.Write(mostrar.getMatricula());
                        Console.SetCursorPosition(16, fila); Console.Write(mostrar.getNombreApellido());
                        bool activo = mostrar.getActivo();
                        if (activo == true)
                        {
                            Console.SetCursorPosition(115, fila); Console.Write("A");
                        }
                        else { Console.SetCursorPosition(115, fila); Console.Write("I"); }

                   // }
                    foreach (Proyectos mostrardo in AProyec)
                    {
                        int consultaproyecto = mostrardo.getMatricula();
                        if (consultaestudiante == consultaproyecto)
                        {
                            Console.SetCursorPosition(41, fila); Console.Write(mostrardo.getNombreDelProyecto());
                            string fechainicio = mostrardo.getFechaInicio().ToString("dd/MM/yyyy");
                            Console.SetCursorPosition(70, fila); Console.Write(fechainicio);
                            string fechafinal = mostrardo.getFechaEntrega().ToString("dd/MM/yyyy");
                            Console.SetCursorPosition(83, fila); Console.Write(fechafinal);
                            int nota = mostrardo.getCalificacion();
                            if (nota == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(97, fila); Console.Write("(Sin Calificar)");
                                Console.ResetColor();
                            }
                            else if (nota >= 90 && nota <= 100)
                            {
                                Console.SetCursorPosition(101, fila); Console.Write(mostrardo.getCalificacion() + "(A)");
                            }
                            else if (nota >= 80 && nota <= 89)
                            {
                                Console.SetCursorPosition(101, fila); Console.Write(mostrardo.getCalificacion() + "(B)");
                            }
                            else if (nota >= 70 && nota <= 79)
                            {
                                Console.SetCursorPosition(101, fila); Console.Write(mostrardo.getCalificacion() + "(C)");
                            }
                            else if (nota >= 60 && nota <= 69)
                            {
                                Console.SetCursorPosition(101, fila); Console.Write(mostrardo.getCalificacion() + "(D)");
                            }
                            else if (nota <= 59)
                            {
                                Console.SetCursorPosition(101, fila); Console.Write(alerta+mostrardo.getCalificacion() + "(F)");
                                Console.ResetColor();
                            }

                        }
                    }
                    fila++;
                    for (int linea = 0; linea <= 117; linea++)
                    {
                        Console.SetCursorPosition(linea, fila); Console.Write("-");
                    }
                    fila++;
                   
                    BuscarInactivo = false;
                }
                
                // Buscar todo////////////////////////////////////////////


                do
                {
                    int BuscarMatricula = 0;
                    int matriculaigual = 0;
                    string tutu = "";
                    bool numerovacio = true;
                    int todobien = new int();
                    bool numeromal = true;
                    bool control = true;

                    ConsoleKeyInfo inicialnumero = new ConsoleKeyInfo();

                    Console.SetCursorPosition(0, 0); Console.Write("Preciona Esc para volver al menu");
                    Console.SetCursorPosition(45, 3); Console.Write("Dijita la matricula.:");
                    Console.SetCursorPosition(51, 4); inicialnumero = Console.ReadKey();

                    if (inicialnumero.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                    else if (inicialnumero.Key == ConsoleKey.Enter) 
                    {
                        control = false;
                    }
                    else if (inicialnumero.Key != ConsoleKey.Enter && control == true)
                    {
                        do
                        {
                            try
                            {
                                char numerito = inicialnumero.KeyChar;
                                Console.SetCursorPosition(52, 4); tutu = Console.ReadLine();
                                numerovacio = false;
                                todobien = int.Parse(numerito + tutu);
                                matriculaigual = todobien;
                            }
                            catch (Exception e)

                            {
                                Console.CursorVisible = false;
                                Console.SetCursorPosition(20, 23); Console.WriteLine(e.Message);
                                Console.SetCursorPosition(20, 23); Console.WriteLine("                                                    ");
                                Console.SetCursorPosition(38, 3); Console.WriteLine(alerta + "Debe dijitar una matricula matricula");
                                Console.SetCursorPosition(38, 4); Console.WriteLine(logrado + "Presione enter para volver a dijitar");
                                Console.ReadKey(true);
                                Console.ResetColor();
                                Console.SetCursorPosition(38, 3); Console.WriteLine("                                                    ");
                                Console.SetCursorPosition(38, 4); Console.WriteLine("                                                    ");
                                numeromal = false;
                                Console.CursorVisible = true;

                            }
                        } while (numerovacio == true);
                        control = true;
                    }

                    foreach (Estudiantes Buscar in AEstudiantes)
                    {
                        
                        BuscarMatricula = Buscar.getMatricula();
                        if (matriculaigual == BuscarMatricula)
                        {

                            Console.Clear();
                            fila = 8;
                            Console.SetCursorPosition(50, 1); Console.Write(colorsubrayado+"Resultados");
                            Console.SetCursorPosition(0, 6); Console.Write(colorsubrayado+ "C.U| Matricula |   Nombre y Apellido    |    Nombre Del Proyecto    |Fecha inicio|Fecha Entrega|  Calificacion  | A/I ");
                            Console.ResetColor();
                            for (int linea = 0; linea <= 117; linea++)
                            {
                                Console.SetCursorPosition(linea, 7); Console.Write("-");
                            }
                            Console.ResetColor();
                            Console.SetCursorPosition(0, fila); Console.Write(Buscar.getCarrera());
                            Console.SetCursorPosition(5, fila); Console.Write(Buscar.getMatricula());
                            Console.SetCursorPosition(16, fila); Console.Write(Buscar.getNombreApellido());
                            foreach (Proyectos mostrardo in AProyec)
                            {
                                int consultaproyecto = mostrardo.getMatricula();
                                if (matriculaigual == consultaproyecto)
                                {
                                    Console.SetCursorPosition(41, fila); Console.Write(mostrardo.getNombreDelProyecto());
                                    string fechainicio = mostrardo.getFechaInicio().ToString("dd/MM/yyyy");
                                    Console.SetCursorPosition(70, fila); Console.Write(fechainicio);
                                    string fechafinal = mostrardo.getFechaEntrega().ToString("dd/MM/yyyy");
                                    Console.SetCursorPosition(83, fila); Console.Write(fechafinal);
                                    int nota = mostrardo.getCalificacion();
                                    if (nota == 0)
                                        if (nota == 0)
                                        {
                                            Console.BackgroundColor = ConsoleColor.Yellow;
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.SetCursorPosition(97, fila); Console.Write(colorsubrayado + "(Sin Calificar)");
                                            Console.ResetColor();
                                        }
                                        else if (nota >= 90 && nota <= 100)
                                        {
                                            Console.SetCursorPosition(101, fila); Console.Write(mostrardo.getCalificacion() + "(A)");
                                        }
                                        else if (nota >= 80 && nota <= 89)
                                        {
                                            Console.SetCursorPosition(101, fila); Console.Write(mostrardo.getCalificacion() + "(B)");
                                        }
                                        else if (nota >= 70 && nota <= 79)
                                        {
                                            Console.SetCursorPosition(101, fila); Console.Write(mostrardo.getCalificacion() + "(C)");
                                        }
                                        else if (nota >= 60 && nota <= 69)
                                        {
                                            Console.SetCursorPosition(101, fila); Console.Write(mostrardo.getCalificacion() + "(D)");
                                        }
                                        else if (nota <= 59)
                                        {
                                            Console.SetCursorPosition(101, fila); Console.Write(alerta + mostrardo.getCalificacion() + "(F)");
                                            Console.ResetColor();
                                        }

                                }
                            }
                            fila++;
                            for (int linea = 0; linea <= 117; linea++)
                            {
                                Console.SetCursorPosition(linea, fila); Console.Write("-");
                            }
                            numeromal = false;

                        }

                    }


                    if (BuscarMatricula != matriculaigual && numeromal==true)
                    {
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(20, 23); Console.WriteLine("                                                    ");
                        Console.SetCursorPosition(39, 3); Console.WriteLine(alerta+"Debe dijitar una matricula Valida.");
                        Console.SetCursorPosition(38, 4); Console.WriteLine(logrado+"Presione enter para volver a dijitar");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        Console.SetCursorPosition(38, 3); Console.WriteLine("                                                    ");
                        Console.SetCursorPosition(38, 4); Console.WriteLine("                                                    ");
                        numerovacio = true;
                        BuscarInactivo = false;
                        Console.CursorVisible = true;
                    }
                    else if(numeromal==true) //(BuscarMatricula == matriculaigual)
                    {
                        ConsoleKeyInfo salir = new ConsoleKeyInfo();
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(33, 3); Console.Write("Opciones | Scape: Menu - Enter: Seguir Busqueda |");
                        salir = Console.ReadKey(true);
                        if (salir.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                        else
                        {
                            Console.SetCursorPosition(33, 3); Console.Write("                                                        ");
                            BuscarInactivo = false;
                        }
                        Console.CursorVisible = true;
                    }
                    numeromal = true;
                    

                } while (BuscarInactivo == false);

            }
        }
        //⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️------------Consultar------------⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️//

        //⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇⬇️⬇️------------Registro de Proyectos------------⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️//


        public static void Registrarproyectos(ArrayList AProyec, Proyectos proyec, ArrayList AEstudiantes, Estudiantes estudiantes)
        {


            int aidproyecto = 0, amatricula = 0, acalificacion = 0;
            string anombredelproyecto = "";
            DateTime afechainicio, afechaentrega;

            Console.Clear();
            Cuadro(1, 80, 1, 25);
            EscSalirEnCuadro();
            Console.SetCursorPosition(28, 08); Console.Write(colorsubrayado+"Registro de Proyecto");
            Console.ResetColor();

            bool idproyectoigual = true;

            do
            {
                foreach (Proyectos id in AProyec)
                {
                    int idigual = id.getIDProyecto();
                    if (aidproyecto == idigual)
                    {
                        aidproyecto++;
                    }else if (aidproyecto != idigual)
                    {
                        idproyectoigual = false;
                    }
                }

            } while (idproyectoigual == true);



            int BuscarMatricula = 0;
            int matriculaigual = 0;
            string tutu = "";
            bool numerovacio = true;
            int todobien = new int();
            bool BuscarInactivo = false;
            string nombreestudiante = "";

            bool control = true;

            ConsoleKeyInfo inicialnumero = new ConsoleKeyInfo();

            Console.SetCursorPosition(28, 12); Console.Write("Matricula:");
            //Console.SetCursorPosition(51, 4); 
            do
            {
                Console.SetCursorPosition(38, 12);
                do
                {
                    Console.SetCursorPosition(38, 12); inicialnumero = Console.ReadKey();
                if (inicialnumero.Key == ConsoleKey.Escape)
                {
                    return;
                }
                else if (inicialnumero.Key == ConsoleKey.Enter)
                {
                    numerovacio = false;
                    control = false;
                }
                else if (inicialnumero.Key != ConsoleKey.Enter && control == true)
                {
                    
                        try
                        {
                            char numerito = inicialnumero.KeyChar;
                            tutu = Console.ReadLine();
                            numerovacio = false;
                            todobien = int.Parse(numerito + tutu);
                            matriculaigual = todobien;
                        }
                        catch (Exception e)

                        {
                            Console.CursorVisible = false;
                            Console.SetCursorPosition(20, 23); Console.WriteLine(e.Message);
                            Console.SetCursorPosition(20, 23); Console.WriteLine("                                                    ");
                            Console.SetCursorPosition(23, 23); Console.WriteLine(alerta + "Debe dijitar una matricula matricula");
                            Console.SetCursorPosition(23, 24); Console.WriteLine(logrado + "Presione enter para volver a dijitar");
                            Console.ReadKey(true);
                            Console.ResetColor();
                            numerovacio = true;
                            Console.SetCursorPosition(38, 12); Console.WriteLine("                                    ");
                            Console.SetCursorPosition(20, 23); Console.WriteLine("                                                    ");
                            Console.SetCursorPosition(20, 24); Console.WriteLine("                                                    ");
                            Console.CursorVisible = true;
                        }
                    } 
                    
                } while (numerovacio == true);
                control = true;
                bool noentrar = false;
                foreach (Estudiantes Buscar in AEstudiantes)
                {
                    BuscarMatricula = Buscar.getMatricula();
                    if (todobien == BuscarMatricula)
                    {

                        Console.ResetColor();
                        Console.SetCursorPosition(0, 0); Console.Write(Buscar.getMatricula());
                        amatricula = todobien;
                        BuscarInactivo = true;
                        noentrar = true;
                        nombreestudiante = Buscar.getNombreApellido();
                    }
                    
                    

                }
                control = false;
                if (BuscarMatricula != matriculaigual && control == false && noentrar == false)
                {

                    Console.CursorVisible = false;
                    
                    Console.SetCursorPosition(24, 23); Console.WriteLine(alerta + "Debe dijitar una matricula Valida.");
                    Console.SetCursorPosition(23, 24); Console.WriteLine(logrado + "Presione enter para volver a dijitar");
                    Console.ReadKey(true);
                    Console.ResetColor();
                    Console.SetCursorPosition(20, 23); Console.WriteLine("                                                    ");
                    Console.SetCursorPosition(20, 24); Console.WriteLine("                                                    ");
                    numerovacio = true;
                    BuscarInactivo = false;
                    Console.CursorVisible = true;
                    control = true;
                    Console.SetCursorPosition(38, 12); Console.WriteLine("                                    ");
                }
                /*if (BuscarMatricula == matriculaigual)
                {
                    ConsoleKeyInfo salir = new ConsoleKeyInfo();
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(33, 3); Console.Write("Opciones | Scape: Menu - Enter: Seguir Busqueda |");
                    salir = Console.ReadKey(true);
                    if (salir.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                    else
                    {
                        Console.SetCursorPosition(33, 3); Console.Write("                                                        ");
                        BuscarInactivo = false;
                    }
                    Console.CursorVisible = true;
                }*/

            } while (BuscarInactivo == false);

            foreach (Proyectos revisar in AProyec){
                int mismamatricula = revisar.getMatricula();
                if (mismamatricula == amatricula)
                {
                    {
                        Console.Clear();
                        Cuadro(1, 80, 1, 25);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(10, 11); Console.WriteLine("La matricula de este estudiante ya registrado en un proyecto");
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(23, 12); Console.WriteLine("Presione enter para volver al menu");
                        Console.ResetColor();
                        Console.ReadKey();
                        return;
                    }
                }
            }

            Console.SetCursorPosition(28, 13); Console.Write("Nombre y Apellido:");
            Console.WriteLine(nombreestudiante);


            bool proyectovaciovacio = false;
            bool nombredeproyectoigual = true;
            string arraynombredeproyecto = "";
            string igualnombredeproyecto = "";
            do
            {
                Console.SetCursorPosition(28, 14); Console.Write("Nombre del Proyecto:");
                anombredelproyecto = Console.ReadLine();

                if (string.IsNullOrEmpty(anombredelproyecto))
                {
                    Console.SetCursorPosition(21, 23); Console.WriteLine(alerta+"Debe de dijitar el proyecto seleccionado");
                    Console.SetCursorPosition(23, 24); Console.WriteLine(logrado+"Presione enter para volver a dijitar");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.SetCursorPosition(20, 23); Console.WriteLine("                                              ");
                    Console.SetCursorPosition(20, 24); Console.WriteLine("                                               ");
                    proyectovaciovacio = true;
                }
                else
                {

                    foreach (Proyectos revisar in AProyec)
                    {
                        arraynombredeproyecto = revisar.getNombreDelProyecto();

                        if (arraynombredeproyecto == anombredelproyecto)
                        {
                            igualnombredeproyecto = arraynombredeproyecto;
                            proyectovaciovacio = false;
                        }
                    }
                }


                if (igualnombredeproyecto == anombredelproyecto && proyectovaciovacio == false)
                {                   
                    Console.SetCursorPosition(23, 23); Console.WriteLine(alerta+"Este proyecto ya a sido registrado");
                    Console.SetCursorPosition(23, 24); Console.WriteLine(logrado+"Presione enter para volver a dijitar");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.SetCursorPosition(20, 23); Console.WriteLine("                                                      ");
                    Console.SetCursorPosition(20, 24); Console.WriteLine("                                                     ");
                    Console.SetCursorPosition(29, 14); Console.WriteLine("                                             ");
                }
                else if (igualnombredeproyecto != anombredelproyecto && proyectovaciovacio == false)
                {
                    nombredeproyectoigual = false;
                }

                proyectovaciovacio = false;
            } while (nombredeproyectoigual == true);


 
            
            bool fechainiciomal = true;

            do
            {
                Console.SetCursorPosition(20, 15); Console.Write("Ingresa una fecha de inicio (dd/mm/yyyy):");
                Console.SetCursorPosition(33, 16); string fechainicio = Console.ReadLine();

                if (DateTime.TryParse(fechainicio, out afechainicio))
                {
                    fechainiciomal = false;
                }
                else
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(19, 23); Console.WriteLine(alerta + "El formato de fecha ingresado es incorrecto.");
                    Console.SetCursorPosition(23, 24); Console.WriteLine(logrado + "Presione enter para volver a dijitar");
                    Console.ReadKey(true);
                    Console.ResetColor();
                    Console.SetCursorPosition(19, 23); Console.WriteLine("                                                      ");
                    Console.SetCursorPosition(20, 24); Console.WriteLine("                                                     ");
                    Console.SetCursorPosition(33, 16); Console.WriteLine("                                             ");
                    Console.CursorVisible = true;
                }
            } while (fechainiciomal == true);

           
            
            bool fechafinalomal = true;

            do
            {
                Console.SetCursorPosition(20, 17); Console.Write("Ingresa una fecha de entrega (dd/mm/yyyy):");
                Console.SetCursorPosition(33, 18); string fechafinal = Console.ReadLine();

                if (DateTime.TryParse(fechafinal, out afechaentrega))
                {
                    fechafinalomal = false;
                }
                else
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(19, 23); Console.WriteLine(alerta + "El formato de fecha ingresado es incorrecto.");
                    Console.SetCursorPosition(23, 24); Console.WriteLine(logrado + "Presione enter para volver a dijitar");
                    Console.ReadKey(true);
                    Console.ResetColor();
                    Console.SetCursorPosition(19, 23); Console.WriteLine("                                                      ");
                    Console.SetCursorPosition(20, 24); Console.WriteLine("                                                     ");
                    Console.SetCursorPosition(33, 18); Console.WriteLine("                                             ");
                    Console.CursorVisible = true;
                }
            } while (fechafinalomal == true);

            AProyec.Add(new Proyectos(anombredelproyecto,afechainicio, afechaentrega, aidproyecto, amatricula, acalificacion));
            Console.Clear();
            Cuadro(1,80,1,25);
            Console.CursorVisible = false;
            Console.SetCursorPosition(23, 11); Console.Write(logrado+"Proyecto registrado correctamente.");
            Console.SetCursorPosition(23, 12); Console.Write(logrado+"Presione enter para volver al menu");
            Console.ResetColor();
            Console.ReadKey(true);
            Console.CursorVisible = true;

        }





        //⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️------------Registro de Proyectos------------⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️//

        //⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇⬇️⬇️------------Calificacion------------⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️⬇️//

        public static void ClasificarTrabajos(ArrayList AProyec, Proyectos proyec)
        {


            int calificacion = 200;
            bool activo = true;
            bool matrivacia = true;
            string matricula = "";
            int matriculacompleta = 0;
            bool entrardijitos = true;
            bool control = true;

            while (activo == true)
            {

                ConsoleKeyInfo numeroinicio = new ConsoleKeyInfo();
                Console.Clear();
                Cuadro(1, 80, 1, 25);
                EscSalirEnCuadro();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(20, 08); Console.Write("Publicacion o modificacion de calificacion");
                Console.ResetColor();
                Console.SetCursorPosition(26, 11); Console.Write("Dijite la matricula:");
                numeroinicio = Console.ReadKey();

                if (numeroinicio.Key == ConsoleKey.Escape)
                {
                    return;

                }
                else if (numeroinicio.Key == ConsoleKey.Enter)
                {
                    matrivacia = false;

                }
                else if (numeroinicio.Key != ConsoleKey.Enter && entrardijitos == true)
                {
                    do
                    {

                        try
                        {
                            char numerito = numeroinicio.KeyChar;
                            matricula = Console.ReadLine();
                            matriculacompleta = int.Parse(numerito + matricula);
                            matrivacia = false;
                        }
                        catch (Exception e)
                        {
                            Console.SetCursorPosition(25, 11); Console.Write(e);
                            Console.Clear();
                            Cuadro(1, 80, 1, 25);
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(25, 11); Console.Write("Debe de dijitar la matricula");
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(25, 12); Console.Write("Presione enter para dijitar.");
                            Console.ResetColor();
                            Console.ReadKey();
                            matrivacia = false;
                            control = false;
                        }


                    } while (matrivacia == true);
                }
                entrardijitos = true;

                foreach (Proyectos modificar in AProyec)
                {
                    int matriculacomparar = modificar.getMatricula();

                    if (matriculacompleta == matriculacomparar)
                    {
                        do
                        {

                            Console.Clear();
                            Cuadro(1, 80, 1, 25);
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(20, 08); Console.Write("Publicacion o modificacion de calificacion");
                            Console.ResetColor();
                            Console.SetCursorPosition(26, 11); Console.Write("Dijite la calificacion:");
                            calificacion = Convert.ToInt32(Console.ReadLine());
                            if (calificacion < 0 || calificacion > 100)
                            {
                                Console.Clear();
                                Cuadro(1, 80, 1, 25);
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(25, 11); Console.Write("Dijite una calificacion valida");
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(25, 11); Console.Write("Dijite una calificacion valida");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                            modificar.setCalificacion(calificacion);

                        } while (calificacion < 0 || calificacion > 100);
                        activo = false;
                    }

                }

                if (activo == true && control == true)
                {
                    Console.Clear();
                    Cuadro(1, 80, 1, 25);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(27, 11); Console.Write("Dijite una matricula valida");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(27, 12); Console.Write("Presione enter para dijitar");
                    Console.ResetColor();
                    Console.ReadKey();
                    matrivacia = true;

                }

                control = true;
            }

        }

        //⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️------------Calificacion------------⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️⬆️//

        public static void EscSalirEnCuadro()
        {
            Console.SetCursorPosition(2, 2); Console.Write("Preciona Esc para volver al menu");
            Console.SetCursorPosition(1, 3); Console.Write("╠");
            Console.SetCursorPosition(34, 2); Console.Write("║");
            Console.SetCursorPosition(34, 1); Console.Write("╦");
            for (int x = 2; x <= 34; x++)
            {
                Console.SetCursorPosition(x, 3); Console.Write("═");
            }
            Console.SetCursorPosition(34, 3); Console.Write("═");
            Console.SetCursorPosition(34, 3); Console.Write("╝");
        }






        public static void prueba()
        {



           // int resultadoInt = int.Parse(resultadoString);


            Console.Clear();
            int anomatricula = DateTime.Now.Year;
            string numerofinal = "0000";
            int matriculacompleta = int.Parse(anomatricula + numerofinal);
            int matriculacompletaigual = new int();
            Console.WriteLine(matriculacompleta);
            
            Console.ReadLine();


        }



         public static void hola()
        {
            Console.WriteLine("Hola");
            Console.ReadKey();
        }






        public static void parafecha()
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
