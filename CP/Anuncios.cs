using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;

namespace CP3
{
   public class Anuncios : Conexion
   {
      #region Varibles Globales
      private bool op_usua = false, usuari = false, contraseñ = false, titul = false, text = false, paso = false, usuar_nuevo = false,
          contra_nueva = false, repet_contra = false;
      private int opc_usa_fle = 0, opc_cre_anun = 0, cont = 1, i, año = 0, mes = 0, dia = 0, checador = 0;
      private string Asteriscos = "", Titulo = "", Texto = " ";
      string usuario = "", contraseña = "";
      string fecha = DateTime.Now.ToString("dd/MM/yyyy  hh:mm");
      MetodosConsulta consultas = new MetodosConsulta(); // Objeto encargado de manejar las consultas a la BD.
      #endregion
      #region constructor
      public Anuncios() // Constructor
      {
         //primerPantalla();
         //segundaPantalla();
      }
      #endregion
      #region cabecera
      public void cabecera()
      {
         byte psx = 6;
         byte psy = 2;
         Console.SetCursorPosition(psx, psy);
         Console.WriteLine("       █████╗ ███╗   ██╗██╗   ██╗███╗   ██╗ ██████╗██╗ ██████╗ ███████╗              ██╗   ██╗██████╗  ██████╗ ██████╗  ██████╗  ██████╗");
         Console.SetCursorPosition(psx, psy + 1);
         Console.WriteLine("      ██╔══██╗████╗  ██║██║   ██║████╗  ██║██╔════╝██║██╔═══██╗██╔════╝              ██║   ██║██╔══██╗██╔═══██╗██╔══██╗██╔═══██╗██╔═══██╗");
         Console.SetCursorPosition(psx, psy + 2);
         Console.WriteLine("      ███████║██╔██╗ ██║██║   ██║██╔██╗ ██║██║     ██║██║   ██║███████╗    █████╗    ██║   ██║██████╔╝██║   ██║██████╔╝██║   ██║██║   ██║");
         Console.SetCursorPosition(psx, psy + 3);
         Console.WriteLine("      ██╔══██║██║╚██╗██║██║   ██║██║╚██╗██║██║     ██║██║   ██║╚════██║    ╚════╝    ██║   ██║██╔═══╝ ██║▄▄ ██║██╔══██╗██║   ██║██║   ██║");
         Console.SetCursorPosition(psx, psy + 4);
         Console.WriteLine("      ██║  ██║██║ ╚████║╚██████╔╝██║ ╚████║╚██████╗██║╚██████╔╝███████║              ╚██████╔╝██║     ╚██████╔╝██║  ██║╚██████╔╝╚██████╔╝");
         Console.SetCursorPosition(psx, psy + 5);
         Console.WriteLine("      ╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝╚═╝ ╚═════╝ ╚══════╝               ╚═════╝ ╚═╝      ╚══▀▀═╝ ╚═╝  ╚═╝ ╚═════╝  ╚═════╝");
         Console.SetCursorPosition(psx, psy + 6);
         Console.WriteLine("      █████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗");
         Console.SetCursorPosition(psx, psy + 7);
         Console.WriteLine("      ╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝");
      }
      #endregion
      #region introduccion
      public void introduccion()
      {
         Console.SetCursorPosition(6, 12);
         Console.WriteLine("> OBJETIVO DEL PROGRAMA:");
         Console.SetCursorPosition(6, 14);
         Console.WriteLine("Este programa fue diseñado con el fin de");
         Console.SetCursorPosition(6, 15);
         Console.WriteLine("sustituir el \"pizarrón de anuncios\" de la");
         Console.SetCursorPosition(6, 16);
         Console.WriteLine("escuela.");
         Console.SetCursorPosition(6, 17);
         Console.WriteLine("Dándole así un uso mas practico y fácil");
         Console.SetCursorPosition(6, 18);
         Console.WriteLine("para los alumnos, en el caso de lo ambiental");
         Console.SetCursorPosition(6, 19);
         Console.WriteLine("estaríamos evitando el uso de papel y demás");
         Console.SetCursorPosition(6, 20);
         Console.WriteLine("materiales.");
         Console.SetCursorPosition(6, 21);
         Console.WriteLine("Con el concepto de \"anuncios digitales\"");
         Console.SetCursorPosition(6, 22);
         Console.WriteLine("podríamos conectarnos mejor toda la comunidad");
         Console.SetCursorPosition(6, 23);
         Console.WriteLine("universitaria, dándole la oportunidad a quien");
         Console.SetCursorPosition(6, 24);
         Console.WriteLine("sea, con diferentes categorías, desde social");
         Console.SetCursorPosition(6, 25);
         Console.WriteLine("hasta la cafetería, con el compromiso de");
         Console.SetCursorPosition(6, 26);
         Console.WriteLine("unir mas a la comunidad tanto a los alumnos,");
         Console.SetCursorPosition(6, 27);
         Console.WriteLine("maestros y personal.");
         Console.SetCursorPosition(6, 40);
         Console.WriteLine("> DESARROLLADO POR:");
         Console.SetCursorPosition(6, 42);
         Console.WriteLine("* GABRIEL CUETO BAEZ");
         Console.SetCursorPosition(6, 43);
         Console.WriteLine("* MAURICIO HERNANDEZ REYES");
         Console.SetCursorPosition(6, 44);
         Console.WriteLine("* JOSUE ESCUDERO (JINXY)");
         Console.SetCursorPosition(6, 45);
         Console.WriteLine("* DANIEL ALFONSO VIVEROS MENA");
         Console.SetCursorPosition(6, 46);
         //Console.WriteLine("* EDUARDO HERNANDEZ CHAY");
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.SetCursorPosition(95, 13);
         Console.WriteLine(":`+++++++++++++++++++++++++++++++++++++++++;");
         Console.SetCursorPosition(95, 14);
         Console.WriteLine("+++++++++++++++++++::::+++++++++++++++++++':");
         Console.SetCursorPosition(95, 15);
         Console.WriteLine("+++++++++++++++++++    ++++++++++++++++++++.");
         Console.SetCursorPosition(95, 16);
         Console.WriteLine("+++++++++++++++++++    ++++++++++++++++++++`");
         Console.SetCursorPosition(95, 17);
         Console.WriteLine("+++++++++++++++++++    '+++++++++++++++++++`");
         Console.SetCursorPosition(95, 18);
         Console.WriteLine("+++++++++++++++++++    `+++++++++++++++++++`");
         Console.SetCursorPosition(95, 19);
         Console.WriteLine("+++++++++++++++++++     +++++++++++++++++++`");
         Console.SetCursorPosition(95, 20);
         Console.WriteLine("+++++++++++++++++++     +++++++++++++++++++`");
         Console.SetCursorPosition(95, 21);
         Console.WriteLine("+++++++++++++++++++     :++++++++++++++++++`");
         Console.SetCursorPosition(95, 22);
         Console.WriteLine("+++++++++++++++++++      ++++++++++++++++++`");
         Console.SetCursorPosition(95, 23);
         Console.WriteLine("+++++++++++++++++++      ++++++++++++++++++`");
         Console.SetCursorPosition(95, 24);
         Console.WriteLine("  . :++++++++++++++       +++++++++++++++++`");
         Console.SetCursorPosition(95, 25);
         Console.WriteLine("  .     +++++++++++     ` +++++++++++++++++`");
         Console.SetCursorPosition(95, 26);
         Console.WriteLine("  .       :++++++++     +  ++++++++++++++++`");
         Console.SetCursorPosition(95, 27);
         Console.WriteLine("  .          ++++++     +. :+++++++++++++++`");
         Console.SetCursorPosition(95, 28);
         Console.WriteLine("  .            ,+++     ++  +++++++++++++++`");
         Console.SetCursorPosition(95, 29);
         Console.WriteLine("  .               +     ++   ++++++++++++++`");
         Console.SetCursorPosition(95, 30);
         Console.WriteLine("  .                     ++    +++++++++++++`");
         Console.SetCursorPosition(95, 31);
         Console.WriteLine("  .  +++                ++  `  '+++++++++++`");
         Console.SetCursorPosition(95, 32);
         Console.WriteLine("  .  +++ ++;            ++  :'  `++++++++++`");
         Console.SetCursorPosition(95, 33);
         Console.WriteLine("  .  +++ ++++++`        ++  :++   '++++++++`");
         Console.SetCursorPosition(95, 34);
         Console.WriteLine("  .  +++ +++++++ +,     ++  :++.    '++++++`");
         Console.SetCursorPosition(95, 35);
         Console.WriteLine("  .  +++ +++++++ ++      +  :++.  :   .++++`");
         Console.SetCursorPosition(95, 36);
         Console.WriteLine("  .  +++ +++++++ ++         :++.  ++     `+`");
         Console.SetCursorPosition(95, 37);
         Console.WriteLine("  .  +++ +++++++ ++         :++.  ++   +.  `");
         Console.SetCursorPosition(95, 38);
         Console.WriteLine("  .  +++ +++++++ ++     +    ++.  ++   +++ `");
         Console.SetCursorPosition(95, 39);
         Console.WriteLine("  .        .;+++ ++     ++        ++   +++ `");
         Console.SetCursorPosition(95, 40);
         Console.WriteLine("  .                     ++  :`    ++   +++ `");
         Console.SetCursorPosition(95, 41);
         Console.WriteLine("  .  +++ ;:.            ++  :++.  ++    `: `");
         Console.SetCursorPosition(95, 42);
         Console.WriteLine("  .  +++ +++++++ ++     ++  :++.  ++   +;, `");
         Console.SetCursorPosition(95, 43);
         Console.WriteLine("  .  +++ +++++++ ++     ++  :++.  ++   +++ `");
         Console.SetCursorPosition(95, 44);
         Console.WriteLine("  .  +++ +++++++ ++     ++  :++.  ++   +++ `");
         Console.SetCursorPosition(95, 45);
         Console.WriteLine("  .                     ++  :++.  ++   +++ ,");
      }
      #endregion
      #region primerPantalla
      public void primerPantalla()
      {
         //Variables objVar = new Variables();
         //CadConexion conexion = new CadConexion();
         do
         {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            cabecera();
            introduccion();
            Console.SetCursorPosition(6, 47);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            //conexion.obtenerConexion();
            Console.SetCursorPosition(6, 48);
            Console.WriteLine("> Verificando si existe conexión a internet...");
            Console.SetCursorPosition(6, 49);
            Thread.Sleep(3000);
            if (!verificarConexionInternet())
            {
               Console.WriteLine("> No hay conexión a internet...");
            }
            Console.SetCursorPosition(6, 50);
            comprobarEstadoConexiónBD();
            Console.SetCursorPosition(97, 50);
            Console.WriteLine("Presiona [ENTER] para Continuar...");
            presionada = Console.ReadKey();
         } while (presionada.Key != ConsoleKey.Enter);
      }
      #endregion
      #region segundaPantalla
      public void Principal() // Pantalla Principal
      {
         SoundPlayer player = new SoundPlayer();
         player.SoundLocation = "matrix.mp3";
         player.Stop();
         Recursos rec = new Recursos();
         //Variables objVar = new Variables();
         Console.CursorVisible = false;
         int opcion = 0;
         byte psx = 14;
         byte psy = 30;
         Console.Clear();
         Console.Title = "Anuncios";
         Console.Clear();
         do
         {
            //fecha = DateTime.Now.ToString("dd/MM/yyyy  hh:mm");
            Console.ForegroundColor = ConsoleColor.Green;
            cabecera();
            rec.Anonimo();
            rec.UFO();
            rec.tv();
            Console.SetCursorPosition(14, 10);
            Console.Write(fecha);
            if (opcion == 0)
               Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx, psy);
            Console.Write("╦  ╦┌─┐┬─┐  ╔═╗┌┐┌┬ ┬┌┐┌┌─┐┬┌─┐┌─┐");
            Console.SetCursorPosition(psx, psy + 1);
            Console.Write("╚╗╔╝├┤ ├┬┘  ╠═╣││││ │││││  ││ │└─┐");
            Console.SetCursorPosition(psx, psy + 2);
            Console.Write(" ╚╝ └─┘┴└─  ╩ ╩┘└┘└─┘┘└┘└─┘┴└─┘└─┘");
            Console.BackgroundColor = ConsoleColor.Black;
            if (opcion == 1)
               Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx + 50, psy);
            Console.Write("╦┌┐┌┬┌─┐┬┌─┐┬─┐  ╔═╗┌─┐┌─┐┬┌─┐┌┐┌");
            Console.SetCursorPosition(psx + 50, psy + 1);
            Console.Write("║│││││  │├─┤├┬┘  ╚═╗├┤ └─┐││ ││││");
            Console.SetCursorPosition(psx + 50, psy + 2);
            Console.Write("╩┘└┘┴└─┘┴┴ ┴┴└─  ╚═╝└─┘└─┘┴└─┘┘└┘");
            Console.BackgroundColor = ConsoleColor.Black;
            if (opcion == 2)
               Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx + 100, psy);
            Console.Write("╦═╗┌─┐┌─┐┬┌─┐┌┬┐┬─┐┌─┐┬─┐┌─┐┌─┐");
            Console.SetCursorPosition(psx + 100, psy + 1);
            Console.Write("╠╦╝├┤ │ ┬│└─┐ │ ├┬┘├─┤├┬┘└─┐├┤ ");
            Console.SetCursorPosition(psx + 100, psy + 2);
            Console.Write("╩╚═└─┘└─┘┴└─┘ ┴ ┴└─┴ ┴┴└─└─┘└─┘");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            presionada = Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            #region Controladores
            if (presionada.Key == ConsoleKey.RightArrow)
            {
               if (opcion == 2)
                  opcion = 0;
               else
                  opcion++;
            }
            if (presionada.Key == ConsoleKey.LeftArrow)
            {
               if (opcion == 0)
                  opcion = 2;
               else
                  opcion--;
            }
            if (presionada.Key == ConsoleKey.DownArrow)
            {
               if (opcion == 2)
                  opcion = 0;
               else
                  opcion++;
            }
            if (presionada.Key == ConsoleKey.UpArrow)
            {
               if (opcion == 0)
                  opcion = 2;
               else
                  opcion--;
            }
            if (presionada.Key == ConsoleKey.Enter)
            {
               if (opcion == 0)
               {
                  Console.Clear();
                  Console.SetCursorPosition(6, 2);
                  Console.BackgroundColor = ConsoleColor.Black;
                  Console.ForegroundColor = ConsoleColor.Green;
                  // fecha = DateTime.Now.ToString("dd/MM/yyyy  hh:mm");
                  Console.ForegroundColor = ConsoleColor.Green;
                  cabecera();
                  Console.SetCursorPosition(130, 58);
                  Console.WriteLine("Presiona [ENTER] para Continuar...");
                  Console.SetCursorPosition(14, 10);
                  Console.Write(fecha);
                  consultas.consultar_todosAnuncios();
                  Console.ReadLine();
                  Console.Clear();
               }
               if (opcion == 1)
               {
                  //consultas.iniciarSesion(usuario, contraseña);
                  Iniciar_Sesion();
                  Acciones_del_Usuario();
                  Console.Clear();
               }
               if (opcion == 2)
               {
                  Registrar_Usuario();
                  //consultas.registrarUsuario(usuario,contraseña, fecha);
                  Console.Clear();
               }
               opcion = 0;
            }
            #endregion
            usuari = false;
            contraseñ = false;
            usuario = "";
            Asteriscos = "";
            contraseña = "";
         } while (presionada.Key != ConsoleKey.Escape);
      }
      #endregion
      private void Iniciar_Sesion()
      {
         #region Iniciar sesión
         byte psx = 60;
         byte psy = 15;
         Recursos rec = new Recursos();
         usuario = "";
         contraseña = "";
         Console.BackgroundColor = ConsoleColor.Black;
         Console.Clear();
         Console.ForegroundColor = ConsoleColor.Green;
         Console.BackgroundColor = ConsoleColor.Black;
         rec.Marco();
         estadoConexión = false;
         Console.SetCursorPosition(psx + 4, psy - 7);
         Console.Write("╦┌┐┌┬┌─┐┬┌─┐┬─┐  ╔═╗┌─┐┌─┐┬┌─┐┌┐┌");
         Console.SetCursorPosition(psx + 4, psy - 6);
         Console.Write("║│││││  │├─┤├┬┘  ╚═╗├┤ └─┐││ ││││");
         Console.SetCursorPosition(psx + 4, psy - 5);
         Console.Write("╩┘└┘┴└─┘┴┴ ┴┴└─  ╚═╝└─┘└─┘┴└─┘┘└┘");
         Console.SetCursorPosition(psx, psy + 4);
         Console.Write("Usuario           :");
         Console.SetCursorPosition(psx, psy + 6);
         Console.Write("Contraseña        :");
         Console.SetCursorPosition(psx + 20, psy + 4);
         Console.Write("                 ");
         Console.SetCursorPosition(psx + 20, psy + 6);
         Console.Write("                 ");
         do
         {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(psx + 20, psy + 4);
            Console.Write(usuario);
            Console.SetCursorPosition(psx + 20, psy + 6);
            Console.Write(Asteriscos);
            Console.SetCursorPosition(psx + 20, 1);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            #region Determina cantidad de letras
            #region Usuario
            if (usuari == false)
            {
               pres = Console.ReadKey();
               Console.BackgroundColor = ConsoleColor.Black;
               Console.SetCursorPosition(psx, psy + 16);
               Console.Write("                                          ");
               if (pres.Key == ConsoleKey.Enter)
               {
                  usuari = true;
               }
               if (pres.Key == ConsoleKey.Escape)
               {
                  op_usua = true;
                  break;
               }
               if (pres.Key == ConsoleKey.Backspace)
               {
                  if (usuario.Length > 0)
                     usuario = usuario.Remove(usuario.Length - 1);
                  Console.SetCursorPosition(psx + 20, psy + 4);
                  Console.BackgroundColor = ConsoleColor.Black;
                  Console.ForegroundColor = ConsoleColor.Black;
                  Console.Write("                   ");
               }
               else
               {
                  if (usuario.Length <= 6 && pres.Key != ConsoleKey.Enter)
                  {
                     usuario += pres.KeyChar;
                     Console.SetCursorPosition(psx + 20, psy + 4);
                     Console.BackgroundColor = ConsoleColor.Black;
                     Console.ForegroundColor = ConsoleColor.Black;
                     Console.Write("                  ");
                     Console.SetCursorPosition(psx + 20, psy + 4);
                     Console.Write("                  ");
                  }
                  else
                  {
                     if (pres.Key != ConsoleKey.Enter)
                     {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(psx, psy + 16);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Ingrese menos de 6 caracteres");
                        Console.ForegroundColor = ConsoleColor.Black;
                     }
                  }
               }
            }
            #endregion
            #region Contraseña
            if (contraseñ == false && usuari == true)
            {
               pres = Console.ReadKey();
               if (pres.Key == ConsoleKey.Enter)
               {
                  contraseñ = true;
               }
               if (pres.Key == ConsoleKey.Escape)
               {
                  op_usua = true;
                  break;
               }
               if (pres.Key == ConsoleKey.Backspace)
               {
                  Console.BackgroundColor = ConsoleColor.Black;
                  Console.SetCursorPosition(psx, psy + 16);
                  Console.Write("                                          ");
                  if (contraseña.Length > 0 && Asteriscos.Length > 0)
                  {
                     Asteriscos = Asteriscos.Remove(Asteriscos.Length - 1);
                     contraseña = contraseña.Remove(contraseña.Length - 1);
                  }
                  Console.BackgroundColor = ConsoleColor.Black;
                  Console.SetCursorPosition(psx + 20, psy + 6);
                  Console.Write("                 ");
               }
               else
               {
                  if (contraseña.Length <= 9 && pres.Key != ConsoleKey.Enter)
                  {
                     Asteriscos += "*";
                     contraseña += pres.KeyChar;
                     Console.SetCursorPosition(psx + 20, psy + 6);
                     Console.BackgroundColor = ConsoleColor.Black;
                     Console.ForegroundColor = ConsoleColor.Black;
                     Console.Write("                                    ");
                  }
                  else
                  {
                     if (pres.Key != ConsoleKey.Enter)
                     {
                        Console.SetCursorPosition(psx, psy + 16);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("Ingrese menos de 9 caracteres");
                        Console.SetCursorPosition(psx + 30, psy + 16);
                        Console.Write("                ");
                        Console.ForegroundColor = ConsoleColor.Black;
                     }
                  }
               }
            }
            #endregion
            #endregion
            if (contraseñ == true && usuari == true)
            {
               //usuari = false;
               //contraseñ = false;
               //usuario = "";
               //Asteriscos = "";
               //contraseña = "";
               Console.ForegroundColor = ConsoleColor.Red;
               Console.BackgroundColor = ConsoleColor.Black;
               Console.SetCursorPosition(psx + 20, psy + 4);
               Console.Write("                 ");
               Console.SetCursorPosition(psx + 20, psy + 6);
               Console.Write("                 ");
               Console.SetCursorPosition(psx, psy + 16);
               //consultas.iniciarSesion(usuario, contraseña);
               if (consultas.iniciarSesion(usuario, contraseña))
               {
                  estadoConexión = true;
               }
               else
               {
                  Console.Write("El usuario y/o contraseña no corresponden");
                  estadoConexión = false;
                  usuario = "";
                  contraseña = "";
                  Asteriscos = "";
                  usuari = false;
                  contraseñ = false;
               }
            }
         } while (estadoConexión != true || pres.Key != ConsoleKey.Enter);
         #endregion
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx + 7, psy + 16);
         if (op_usua == false)
            Console.Write("Acaba de ingresar");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx + 7, psy + 18);
         Console.Write("Presione una tecla...");
         Console.SetCursorPosition(1, 1);
         pres = Console.ReadKey();
      }
      private void Acciones_del_Usuario()
      {
         byte psx = 5;
         byte psy = 10;
         Console.BackgroundColor = ConsoleColor.Black;
         Console.Clear();
         Recursos rec = new Recursos();
         while (op_usua != true)
         {
            #region Acciones del usuario                
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            rec.Marco_Acciones();
            rec.SATMM();
            Console.SetCursorPosition(5, 3);
            Console.Write("Usuario Logueado: {0}", usuario);
            Console.BackgroundColor = ConsoleColor.Black;
            if (opc_usa_fle == 0)
               Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx, psy);
            Console.Write("╦  ╦┌─┐┬─┐  ╔═╗┌┐┌┬ ┬┌┐┌┌─┐┬┌─┐┌─┐");
            Console.SetCursorPosition(psx, psy + 1);
            Console.Write("╚╗╔╝├┤ ├┬┘  ╠═╣││││ │││││  ││ │└─┐");
            Console.SetCursorPosition(psx, psy + 2);
            Console.Write(" ╚╝ └─┘┴└─  ╩ ╩┘└┘└─┘┘└┘└─┘┴└─┘└─┘");
            Console.ForegroundColor = ConsoleColor.Red;
            if (opc_usa_fle == 1)
               Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx, psy + 4);
            Console.Write("╔═╗┬─┐┌─┐┌─┐┬─┐  ╔═╗┌┐┌┬ ┬┌┐┌┌─┐┬┌─┐");
            Console.SetCursorPosition(psx, psy + 5);
            Console.Write("║  ├┬┘├┤ ├─┤├┬┘  ╠═╣││││ │││││  ││ │");
            Console.SetCursorPosition(psx, psy + 6);
            Console.Write("╚═╝┴└─└─┘┴ ┴┴└─  ╩ ╩┘└┘└─┘┘└┘└─┘┴└─┘");
            Console.ForegroundColor = ConsoleColor.Red;
            if (opc_usa_fle == 2)
               Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx, psy + 8);
            Console.Write("╦ ╦┬┌─┐┌┬┐┌─┐┬─┐┬┌─┐┬  ");
            Console.SetCursorPosition(psx, psy + 9);
            Console.Write("╠═╣│└─┐ │ │ │├┬┘│├─┤│  ");
            Console.SetCursorPosition(psx, psy + 10);
            Console.Write("╩ ╩┴└─┘ ┴ └─┘┴└─┴┴ ┴┴─┘");
            Console.ForegroundColor = ConsoleColor.Red;
            if (opc_usa_fle == 3)
               Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx, psy + 12);
            Console.Write("╔═╗┌─┐┬─┐┬─┐┌─┐┬─┐  ╔═╗┌─┐┌─┐┬┌─┐┌┐┌");
            Console.SetCursorPosition(psx, psy + 13);
            Console.Write("║  ├┤ ├┬┘├┬┘├─┤├┬┘  ╚═╗├┤ └─┐││ ││││");
            Console.SetCursorPosition(psx, psy + 14);
            Console.Write("╚═╝└─┘┴└─┴└─┴ ┴┴└─  ╚═╝└─┘└─┘┴└─┘┘└┘");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Black;
            pres = Console.ReadKey();
            #region Controladores
            if (pres.Key == ConsoleKey.DownArrow)
            {
               if (opc_usa_fle == 3)
                  opc_usa_fle = 0;
               else
                  opc_usa_fle++;
            }
            if (pres.Key == ConsoleKey.UpArrow)
            {
               if (opc_usa_fle == 0)
                  opc_usa_fle = 3;
               else
                  opc_usa_fle--;
            }
            if (pres.Key == ConsoleKey.Enter)
            {
               #endregion
               if (opc_usa_fle == 0)
               {
                  Selecciona_Anuncio();
               }
               if (opc_usa_fle == 1)
               {
                  bool numeros = false;
                  Crea_Anuncio(numeros);
               }
               if (opc_usa_fle == 2)
               {
                  #region Historial
                  #endregion
               }
               if (opc_usa_fle == 3)
               {
                  #region Salir
                  op_usua = true;
                  #endregion
               }
               Console.BackgroundColor = ConsoleColor.Black;
            }
            #endregion
         }
         usuario = "";
         contraseña = "";
         op_usua = false;
         opc_usa_fle = 0;
      }
      private void Registrar_Usuario()
      {
         #region Registrar Usuario
         string contr_temp = "", repe_contra = "", nombre = "", apellido = "";
         bool esc = false, nomb = false, apell = false;
         byte psx = 60;
         byte psy = 15;
         Console.BackgroundColor = ConsoleColor.Black;
         Console.Clear();
         Console.BackgroundColor = ConsoleColor.White;
         contr_temp = "";
         Console.ForegroundColor = ConsoleColor.Green;
         Console.BackgroundColor = ConsoleColor.Black;
         Recursos rec = new Recursos();
         rec.Marco();
         Console.SetCursorPosition(psx + 4, psy - 7);
         Console.Write("╦═╗┌─┐┌─┐┬┌─┐┌┬┐┬─┐┌─┐┬─┐┌─┐┌─┐");
         Console.SetCursorPosition(psx + 4, psy - 6);
         Console.Write("╠╦╝├┤ │ ┬│└─┐ │ ├┬┘├─┤├┬┘└─┐├┤ ");
         Console.SetCursorPosition(psx + 4, psy - 5);
         Console.Write("╩╚═└─┘└─┘┴└─┘ ┴ ┴└─┴ ┴┴└─└─┘└─┘");
         Console.SetCursorPosition(psx, psy + 4);
         Console.Write("Usuario           :");
         Console.SetCursorPosition(psx, psy + 6);
         Console.Write("Contraseña        :");
         Console.SetCursorPosition(psx, psy + 8);
         Console.Write("Repetir contraseña:");
         Console.SetCursorPosition(psx, psy + 10);
         Console.Write("Nombre            :");
         Console.SetCursorPosition(psx, psy + 12);
         Console.Write("Apellido          :");
         do
         {
            Console.SetCursorPosition(6, 50);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            //conexion.obtenerConexion();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(psx + 20, psy + 4);
            Console.Write(usuario); // Variable Usuario
            Console.SetCursorPosition(psx + 20, psy + 6);
            Console.Write(contr_temp); // Variable Contraseña 
            Console.SetCursorPosition(psx + 20, psy + 8);
            Console.Write(repe_contra); // Variable Repetir Contraseña
            Console.SetCursorPosition(psx + 20, psy + 10);
            Console.Write(nombre); // Variable del Nombre
            Console.SetCursorPosition(psx + 20, psy + 12);
            Console.Write(apellido); // Variable del Apellido
            Console.SetCursorPosition(1, 1);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            #region Nuevo Usuario
            if (usuar_nuevo == false)
            {
               pres = Console.ReadKey();
               Console.SetCursorPosition(psx, psy + 16);
               Console.Write("                              ");
               if (pres.Key == ConsoleKey.Enter)
               {
                  usuar_nuevo = true;
                  //for (i = 0; i < Todos_Los_Usuarios.Length; i++)
                  //{
                  //    if (usuario == Todos_Los_Usuarios[i])
                  //    {
                  //        Console.BackgroundColor = ConsoleColor.White;
                  //        Console.SetCursorPosition(30, 5);
                  //        Console.Write("                 ");
                  //        Console.SetCursorPosition(30, 11);
                  //        Console.ForegroundColor = ConsoleColor.Red;
                  //        Console.Write("Usuario repetido, ingrese otro");
                  //        usuario = "";
                  //        usuar_nuevo = false;
                  //        break;
                  //    }

                  //}
                  if (usuario == "" || usuario == " " || usuario == "  " || usuario == "   "
                      || usuario == "    " || usuario == "     " || usuario == "      ")
                  {
                     usuar_nuevo = false;
                  }
               }
               if (pres.Key == ConsoleKey.Escape)
               {
                  apell = true;
                  esc = true;
                  break;
               }
               if (pres.Key == ConsoleKey.Backspace)
               {
                  if (usuario.Length > 0)
                  {
                     usuario = usuario.Remove(usuario.Length - 1);
                     Console.SetCursorPosition(psx + 20, psy + 4);
                     Console.BackgroundColor = ConsoleColor.Black;
                     Console.ForegroundColor = ConsoleColor.Black;
                     Console.Write("                   ");
                  }
                  Console.BackgroundColor = ConsoleColor.Black;
                  Console.SetCursorPosition(psx + 20, psy + 4);
                  Console.Write("                 ");
               }
               else
               {
                  if (usuario.Length <= 6 && pres.Key != ConsoleKey.Enter)
                     usuario += pres.KeyChar;
                  else
                  {
                     if (pres.Key != ConsoleKey.Enter)
                     {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(psx, psy + 16);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Ingrese menos de 6 caracteres");
                        Console.ForegroundColor = ConsoleColor.Black;
                     }
                  }
               }
            }
            #endregion

            #region Contraseña
            if (usuar_nuevo == true && contra_nueva == false)
            {
               pres = Console.ReadKey();
               Console.SetCursorPosition(psx, psy + 16);
               Console.Write("                              ");
               if (pres.Key == ConsoleKey.Enter)
               {
                  contra_nueva = true;
               }
               if (pres.Key == ConsoleKey.Backspace)
               {
                  if (contr_temp.Length > 0)
                  {
                     contr_temp = contr_temp.Remove(contr_temp.Length - 1);
                     Console.SetCursorPosition(psx + 20, psy + 6);
                     Console.BackgroundColor = ConsoleColor.Black;
                     Console.ForegroundColor = ConsoleColor.Black;
                     Console.Write("                       ");
                  }
                  Console.BackgroundColor = ConsoleColor.Black;
                  Console.SetCursorPosition(psx + 20, psy + 6);
                  Console.Write("                     ");
               }
               if (pres.Key == ConsoleKey.Escape)
               {
                  apell = true;
                  esc = true;
                  break;
               }
               else
               {
                  if (contr_temp.Length <= 9 && pres.Key != ConsoleKey.Enter && pres.Key != ConsoleKey.Backspace)
                     contr_temp += pres.KeyChar;
                  else
                  {
                     if (pres.Key != ConsoleKey.Enter && pres.Key != ConsoleKey.Backspace)
                     {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(psx, psy + 16);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Ingrese menos de 9 caracteres");
                        Console.ForegroundColor = ConsoleColor.Black;
                     }
                  }
               }
            }
            #endregion

            #region Contraseña Repetida
            if (repet_contra == false && contra_nueva == true)
            {
               pres = Console.ReadKey();
               Console.SetCursorPosition(psx, psy + 16);
               Console.Write("                              ");
               if (pres.Key == ConsoleKey.Enter)
               {
                  if (contr_temp == repe_contra)
                     repet_contra = true;
                  else
                  {
                     contr_temp = "";
                     repe_contra = "";
                     contra_nueva = false;
                     Console.SetCursorPosition(psx, psy + 16);
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.Write("Contraseñas no corresponden");
                     Console.SetCursorPosition(psx + 20, psy + 6);
                     Console.Write("                      ");
                     Console.SetCursorPosition(psx + 20, psy + 8);
                     Console.Write("                      ");
                  }
               }
               if (pres.Key == ConsoleKey.Escape)
               {
                  apell = true;
                  esc = true;
                  break;
               }
               if (pres.Key == ConsoleKey.Backspace)
               {
                  if (repe_contra.Length > 0)
                  {
                     repe_contra = repe_contra.Remove(repe_contra.Length - 1);
                     Console.SetCursorPosition(psx + 20, psy + 8);
                     Console.BackgroundColor = ConsoleColor.Black;
                     Console.ForegroundColor = ConsoleColor.Black;
                     Console.Write("                    ");
                  }
                  Console.BackgroundColor = ConsoleColor.Black;
                  Console.SetCursorPosition(psx + 20, psy + 8);
                  Console.Write("                 ");
               }
               else
               {
                  if (repe_contra.Length <= 9 && pres.Key != ConsoleKey.Enter)
                     repe_contra += pres.KeyChar;
                  else
                  {
                     if (pres.Key != ConsoleKey.Enter)
                     {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(psx, psy + 16);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Ingrese menos de 9 caracteres");
                        Console.ForegroundColor = ConsoleColor.Black;
                     }
                  }
               }
            }
            #endregion

            #region Nombre
            if (nomb == false && repet_contra == true)
            {
               pres = Console.ReadKey();
               Console.SetCursorPosition(psx, psy + 16);
               Console.Write("                              ");
               if (pres.Key == ConsoleKey.Enter)
               {
                  nomb = true;
                  if (nombre == "" || nombre == " " || nombre == "  " || nombre == "   "
                      || nombre == "    " || nombre == "     " || nombre == "      ")
                  {
                     nomb = false;
                  }
               }

               if (pres.Key == ConsoleKey.Escape)
               {
                  apell = true;
                  break;
               }
               if (pres.Key == ConsoleKey.Backspace)
               {
                  if (nombre.Length > 0)
                     nombre = nombre.Remove(nombre.Length - 1);
                  Console.BackgroundColor = ConsoleColor.Black;
                  Console.ForegroundColor = ConsoleColor.Black;
                  Console.SetCursorPosition(psx + 20, psy + 10);
                  Console.Write("                      ");
               }
               else
               {
                  if (nombre.Length <= 20 && pres.Key != ConsoleKey.Enter)
                  {
                     nombre += pres.KeyChar;
                  }
                  else
                  {
                     if (pres.Key != ConsoleKey.Enter)
                     {
                        Console.SetCursorPosition(psx, psy + 16);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Ingrese menos de 20 caracteres");
                     }
                  }
               }
            }
            #endregion

            #region Apellido
            if (nomb == true && apell == false)
            {
               pres = Console.ReadKey();
               Console.SetCursorPosition(psx, psy + 16);
               Console.Write("                              ");
               if (pres.Key == ConsoleKey.Enter)
               {
                  apell = true;
                  if (apellido == "" || apellido == " " || apellido == "  " || apellido == "   "
                      || apellido == "    " || apellido == "     " || apellido == "      ")
                  {
                     apell = false;
                  }
               }
               if (pres.Key == ConsoleKey.Escape)
               {
                  apell = true;
                  break;
               }
               if (pres.Key == ConsoleKey.Backspace)
               {
                  if (apellido.Length > 0)
                     apellido = apellido.Remove(apellido.Length - 1);
                  Console.BackgroundColor = ConsoleColor.Black;
                  Console.ForegroundColor = ConsoleColor.Black;
                  Console.SetCursorPosition(psx + 20, psy + 12);
                  Console.Write("                      ");
               }
               else
               {
                  if (apellido.Length <= 20 && pres.Key != ConsoleKey.Enter)
                  {
                     apellido += pres.KeyChar;
                  }
                  else
                  {
                     if (pres.Key != ConsoleKey.Enter)
                     {
                        Console.SetCursorPosition(psx, psy + 16);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Ingrese menos de 20 caracteres");
                     }
                  }
               }
            }
            #endregion
         } while (apell != true);
         // fecha = DateTime.Now.ToString("dd/MM/yyyy");
         //registrarUsuario(usuario, repe_contra, fecha);
         Console.BackgroundColor = ConsoleColor.Black;
         Console.ForegroundColor = ConsoleColor.Green;
         if (esc != true)
         {
            consultas.registrarUsuario(usuario, repe_contra, nombre, apellido, fecha);
            Console.SetCursorPosition(psx, psy + 16);
            Console.Write("Ingreso usuario :D");
            Console.ReadKey();
            Acciones_del_Usuario();
         }
         Console.Clear();
         usuar_nuevo = false;
         repet_contra = false;
         contra_nueva = false;
         #endregion
      }

      private void Selecciona_Anuncio()
      {
         Recursos rec = new Recursos();
         #region Selecciona Anuncio
         Console.Clear();
         do
         {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            rec.Marco_Seleccion();
            Console.SetCursorPosition(2, 2);
            Console.Write("Usuario Logueado: {0}", usuario);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(2, 5);
            Console.Write("╔═╗┌─┐┬  ┌─┐┌─┐┌─┐┬┌─┐┌┐┌┌─┐  ╔═╗┌┐┌┬ ┬┌┐┌┌─┐┬┌─┐");
            Console.SetCursorPosition(2, 6);
            Console.Write("╚═╗├┤ │  ├┤ │  │  ││ ││││├─┤  ╠═╣││││ │││││  ││ │");
            Console.SetCursorPosition(2, 7);
            Console.Write("╚═╝└─┘┴─┘└─┘└─┘└─┘┴└─┘┘└┘┴ ┴  ╩ ╩┘└┘└─┘┘└┘└─┘┴└─┘");
            //consultas.consultar_todosAnunciosUsuario(usuario);
            if (opc_cre_anun == 0)
               Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(113, 17);
            Console.Write("╦═╗┌─┐┌─┐┬─┐┌─┐┌─┐┌─┐┬─┐");
            Console.SetCursorPosition(113, 18);
            Console.Write("╠╦╝├┤ │ ┬├┬┘├┤ └─┐├─┤├┬┘");
            Console.SetCursorPosition(113, 19);
            Console.Write("╩╚═└─┘└─┘┴└─└─┘└─┘┴ ┴┴└─");
            Console.BackgroundColor = ConsoleColor.Black;

            if (opc_cre_anun == 1)
               Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(113, 21);
            Console.Write("╔═╗┌─┐┬─┐┬─┐┌─┐┬─┐  ╔═╗┌─┐┌─┐┬┌─┐┌┐┌");
            Console.SetCursorPosition(113, 22);
            Console.Write("║  ├┤ ├┬┘├┬┘├─┤├┬┘  ╚═╗├┤ └─┐││ ││││");
            Console.SetCursorPosition(113, 23);
            Console.Write("╚═╝└─┘┴└─┴└─┴ ┴┴└─  ╚═╝└─┘└─┘┴└─┘┘└┘");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            pres = Console.ReadKey();
            if (pres.Key == ConsoleKey.DownArrow && opc_cre_anun != cont)
               opc_cre_anun++;
            if (pres.Key == ConsoleKey.UpArrow && opc_cre_anun != 0)
               opc_cre_anun--;
            if (pres.Key == ConsoleKey.Enter)
            {
               if (opc_cre_anun == 1)
               {
                  op_usua = true;
               }
            }
         } while ((pres.Key != ConsoleKey.Enter && opc_cre_anun != 0)
             || (pres.Key != ConsoleKey.Enter && op_usua != true));
         Console.Clear();
         #endregion
      }

      private void Crea_Anuncio(bool numeros)
      {
         #region Crea Anuncios
         int linea = 0;
         Recursos rec = new Recursos();
         Console.Clear();
         Console.ForegroundColor = ConsoleColor.Red;
         rec.Marco_de_Texto(15, 17, 24, 84);
         rec.Marco_de_Texto(21, 40, 15, 90);
         rec.Marco_de_Texto(15, 17, 118, 126);
         rec.Marco_de_Texto(15, 17, 128, 136);
         rec.Marco_de_Texto(15, 17, 138, 146);
         Console.SetCursorPosition(3, 2);
         Console.Write(usuario);
         Console.ForegroundColor = ConsoleColor.Green;
         rec.Marco_Seleccion();
         Console.SetCursorPosition(2, 5);
         Console.Write("╔═╗┬─┐┌─┐┌─┐┬─┐  ╔═╗┌┐┌┬ ┬┌┐┌┌─┐┬┌─┐");
         Console.SetCursorPosition(2, 6);
         Console.Write("║  ├┬┘├┤ ├─┤├┬┘  ╠═╣││││ │││││  ││ │");
         Console.SetCursorPosition(2, 7);
         Console.Write("╚═╝┴└─└─┘┴ ┴┴└─  ╩ ╩┘└┘└─┘┘└┘└─┘┴└─┘");
         Console.SetCursorPosition(48, 14);
         Console.Write("Titulo");
         Console.SetCursorPosition(43, 20);
         Console.Write(" Ingrese anuncio ");
         Console.SetCursorPosition(125, 12);
         Console.Write(" Fecha Limite ");
         Console.SetCursorPosition(120, 14);
         Console.Write(" Dia ");
         Console.SetCursorPosition(130, 14);
         Console.Write(" Mes ");
         Console.SetCursorPosition(140, 14);
         Console.Write(" Año ");
         bool salto = false, esc = false;
         do
         {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(26, 16);
            Console.Write(Titulo); // Titulo del Anuncio
            Console.SetCursorPosition(17, 22);
            Console.Write(Texto); // Contenido
            Console.SetCursorPosition(120, 16);
            Console.Write(dia);
            Console.SetCursorPosition(130, 16);
            Console.Write(mes);
            Console.SetCursorPosition(140, 16);
            Console.Write(año);
            Console.SetCursorPosition(2, 23);
            Console.Write("║");
            Console.SetCursorPosition(2, 24);
            Console.Write("║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(15, 23);
            Console.Write("║");
            Console.SetCursorPosition(15, 24);
            Console.Write("║");
            Console.ForegroundColor = ConsoleColor.Black;
            #region Titulo
            if (titul == false)
            {
               Console.SetCursorPosition(1, 1);
               pres = Console.ReadKey();
               if (pres.Key == ConsoleKey.Enter)
               {
                  titul = true;
               }
               if (pres.Key == ConsoleKey.Escape)
               {
                  esc = true;
                  break;
               }
               if (pres.Key == ConsoleKey.Backspace)
               {
                  if (Titulo.Length > 0)
                     Titulo = Titulo.Remove(Titulo.Length - 1);
                  Console.SetCursorPosition(25, 16);
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.Write("                                                          ");
               }
               else
               {
                  if (Titulo.Length <= 56 && pres.Key != ConsoleKey.Enter)
                     Titulo += pres.KeyChar;
               }
            }
            #endregion
            #region Texto
            if (text == false && titul == true)
            {
               Console.SetCursorPosition(1, 1);
               pres = Console.ReadKey();
               if (pres.Key == ConsoleKey.Enter)
               {
                  text = true;
               }
               if (pres.Key == ConsoleKey.Escape)
               {
                  esc = true;
                  break;
               }
               if (pres.Key == ConsoleKey.Backspace)
               {
                  Console.SetCursorPosition(40, 42);
                  Console.Write("                                   ");
                  if (Texto.Length > 0)
                  {
                     #region Borrar texto
                     if (linea > 0 && (checador > 0 && checador != 71))
                     {
                        checador--;
                        Texto = Texto.Remove(Texto.Length - 1);
                        salto = false;
                     }

                     if ((salto == true || checador == 71) && linea > 0)
                     {
                        checador--;
                        Texto = Texto.Remove(Texto.Length - 1);
                        salto = false;
                     }
                     if (linea > 0 && checador == 0)
                     {
                        Texto = Texto.Remove(Texto.Length - 18);
                        checador = 72;
                        linea--;
                        salto = true;
                     }
                     if (linea == 0 && checador > 0)
                     {
                        checador--;
                        Texto = Texto.Remove(Texto.Length - 1);
                        salto = false;
                     }
                     #endregion
                  }
                  for (i = 22; i < 26; i++)
                  {
                     Console.SetCursorPosition(16, i);
                     Console.Write("                                                                          ");
                  }
               }
               else
               {
                  if (checador == 72)
                  {
                     checador = 1;
                     linea++;
                     Texto += "\n                 ";
                     Texto += pres.KeyChar;
                  }
                  else
                  {
                     if (Texto.Length <= 200 && pres.Key != ConsoleKey.Enter && pres.Key != ConsoleKey.Backspace)
                     {
                        Texto += pres.KeyChar;
                        checador++;
                        salto = false;
                        if (checador == 72 && checador == 71 && linea > 0)
                           salto = true;
                     }
                     else
                     {
                        Console.SetCursorPosition(40, 42);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Ingrese menos de 200 caracteres");
                     }
                  }
               }
            }
            #endregion
            #region Números
            if (text == true)
            {
               Console.SetCursorPosition(40, 42);
               Console.Write("                                   ");
               do
               {
                  Numeros(rec, numeros, 0);
                  if (dia >= 32)
                  {
                     Console.SetCursorPosition(120, 19);
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.Write("Ingrese un día menor");
                     Console.SetCursorPosition(120, 16);
                     Console.Write("     ");
                  }
                  if (dia <= 0)
                  {
                     Console.SetCursorPosition(120, 19);
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.Write("Ingrese un día mayor");
                     Console.SetCursorPosition(120, 16);
                     Console.Write("     ");
                  }
               } while (dia >= 32 || dia <= 0);
               Console.ForegroundColor = ConsoleColor.Black;
               Console.SetCursorPosition(120, 19);
               Console.Write("                               ");
               do
               {
                  Numeros(rec, numeros, 10);
                  if (mes >= 13)
                  {
                     Console.SetCursorPosition(120, 19);
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.Write("Ingrese un mes menor");
                     Console.SetCursorPosition(130, 16);
                     Console.Write("     ");
                  }
                  if (mes <= 0)
                  {
                     Console.SetCursorPosition(120, 19);
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.Write("Ingrese un mes mayor");
                     Console.SetCursorPosition(130, 16);
                     Console.Write("     ");
                  }
               } while (mes >= 13 || mes <= 0);
               Console.ForegroundColor = ConsoleColor.Black;
               Console.SetCursorPosition(120, 19);
               Console.Write("                               ");
               do
               {
                  Numeros(rec, numeros, 20);
                  if (año <= 2014)
                  {
                     Console.SetCursorPosition(120, 19);
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.Write("Ingrese un año mayor");
                     Console.SetCursorPosition(130, 16);
                     Console.Write("     ");
                  }
                  if (año >= 2020)
                  {
                     Console.SetCursorPosition(120, 19);
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.Write("Ingrese un año menor");
                  }
               } while (año <= 2014 || año >= 2020);
            }
            #endregion
         } while (text == false);
         Texto = Texto.Replace("\n                 ", "");
         if (esc != true)
         {
            //Seccion para agregar metodo
            consultas.registrarAnuncio(Titulo, Texto, fecha, "Informativo", usuario);
            // Fin
         }
         Titulo = "";
         Texto = "";
         dia = 0;
         mes = 0;
         año = 0;
         titul = false;
         text = false;
         Console.Clear();
         #endregion
      }
      private void Numeros(Recursos rec, bool numeros, int sumativa)
      {
         int valor = 0;
         do
         {
            try
            {
               Console.SetCursorPosition(120, 16);
               Console.Write("                                  ");
               Console.ForegroundColor = ConsoleColor.Red;
               rec.Marco_de_Texto(15, 17, 118, 126);
               rec.Marco_de_Texto(15, 17, 128, 136);
               rec.Marco_de_Texto(15, 17, 138, 146);
               Console.SetCursorPosition(120, 16);
               Console.Write(dia);
               Console.SetCursorPosition(130, 16);
               Console.Write(mes);
               Console.SetCursorPosition(140, 16);
               Console.Write(año);
               Console.SetCursorPosition(120 + sumativa, 16);
               Console.Write("      ");
               Console.ForegroundColor = ConsoleColor.Green;
               Console.SetCursorPosition(120 + sumativa, 16);
               valor = int.Parse(Console.ReadLine());
               numeros = true;
            }
            catch
            {
               Console.SetCursorPosition(120 + sumativa, 16);
               Console.Write("      ");
               Console.SetCursorPosition(120, 19);
               Console.Write("                               ");
               Console.SetCursorPosition(120, 19);
               Console.ForegroundColor = ConsoleColor.Red;
               Console.Write("Solo ingrese números");
            }
         } while (numeros != true);
         Console.SetCursorPosition(120, 19);
         Console.Write("                               ");
         if (sumativa == 0)
            dia = valor;
         if (sumativa == 10)
            mes = valor;
         if (sumativa == 20)
            año = valor;
      }
   }
}