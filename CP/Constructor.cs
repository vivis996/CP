using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CP3
{
   class Constructor
   {
      public void constructor()
      {
         Recursos rec = new Recursos();
         Anuncios objAnuncios = new Anuncios();
         objAnuncios.primerPantalla();
         rec.Error();
         rec.Error_2();
         objAnuncios.Principal();
         ConsoleKeyInfo pres;
         bool opcion = false, op_usua = false, usuari = false, contraseñ = false;
         int opc_usa_fle = 0, opc_cre_anun = 0, cont = 1;
         string usuario = "", contraseña = "";
         Console.CursorVisible = false;
         Console.BackgroundColor = ConsoleColor.Black;
         Console.Clear();
         do
         {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            if (opcion == false)
               Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 5);
            Console.Write("Ver anuncios");
            Console.BackgroundColor = ConsoleColor.Black;
            if (opcion == true)
               Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(30, 5);
            Console.Write("Iniciar sesión");
            pres = Console.ReadKey();
            if (pres.Key == ConsoleKey.RightArrow)
            {

               if (opcion == true)
                  opcion = false;
               else
                  opcion = true;
            }
            if (pres.Key == ConsoleKey.LeftArrow)
            {
               if (opcion == false)
                  opcion = true;
               else
                  opcion = false;
            }
            if (pres.Key == ConsoleKey.Enter)
            {
               #region Ver anuncios
               if (opcion == false)
               {
               }
               #endregion
               string asteriscos = "";

               #region Iniciar sesión
               if (opcion == true)
               {
                  Console.BackgroundColor = ConsoleColor.Black;
                  Console.Clear();
                  do
                  {
                     Console.ForegroundColor = ConsoleColor.Black;
                     Console.BackgroundColor = ConsoleColor.White;
                     Console.SetCursorPosition(10, 5);
                     Console.Write("Usuario");
                     Console.SetCursorPosition(30, 5);
                     Console.Write("                 ");
                     Console.SetCursorPosition(10, 7);
                     Console.Write("Contraseña");
                     Console.SetCursorPosition(30, 7);
                     Console.Write("                 ");
                     Console.SetCursorPosition(30, 5);
                     Console.Write(usuario.ToLower());
                     Console.SetCursorPosition(30, 7);
                     Console.Write(contraseña.ToLower());
                     Console.SetCursorPosition(30, 15);
                     Console.BackgroundColor = ConsoleColor.Black;
                     Console.ForegroundColor = ConsoleColor.Black;
                     #region Determina cantidad de letras
                     if (usuari == false)
                     {
                        pres = Console.ReadKey();
                        if (pres.Key == ConsoleKey.Enter)
                        {
                           usuari = true;
                        }
                        if (pres.Key == ConsoleKey.Backspace)
                        {
                           if (usuario.Length > 0)
                              usuario = usuario.Remove(usuario.Length - 1);
                           Console.BackgroundColor = ConsoleColor.Black;
                           Console.Clear();
                        }
                        else
                        {
                           if (usuario.Length <= 6 && pres.Key != ConsoleKey.Enter)
                              usuario += pres.Key.ToString();
                           else
                           {
                              if (pres.Key != ConsoleKey.Enter)
                              {
                                 Console.BackgroundColor = ConsoleColor.White;
                                 Console.SetCursorPosition(30, 9);
                                 Console.ForegroundColor = ConsoleColor.Red;
                                 Console.Write("Ingrese menos de 6 caracteres");
                                 Console.ForegroundColor = ConsoleColor.Black;
                              }
                           }
                        }
                     }
                     if (contraseñ == false && usuari == true)
                     {
                        pres = Console.ReadKey();
                        if (pres.Key == ConsoleKey.Enter)
                        {
                           contraseñ = true;
                        }
                        if (pres.Key == ConsoleKey.Backspace)
                        {
                           if (contraseña.Length > 0)
                           {
                              contraseña = contraseña.Remove(contraseña.Length - 1);
                              asteriscos = asteriscos.Remove(asteriscos.Length - 1);
                           }
                           Console.BackgroundColor = ConsoleColor.Black;
                           Console.Clear();
                        }
                        else
                        {
                           if (contraseña.Length <= 9 && pres.Key != ConsoleKey.Enter)
                           {
                              contraseña += pres.Key.ToString();
                              asteriscos += "*";
                           }
                           else
                           {
                              Console.SetCursorPosition(30, 9);
                              Console.ForegroundColor = ConsoleColor.Red;
                              Console.BackgroundColor = ConsoleColor.White;
                              Console.Write("Ingrese menos de 9 caracteres");
                              Console.ForegroundColor = ConsoleColor.Black;
                           }
                        }
                     }
                     #endregion
                     if (contraseñ == true && usuari == true && (usuario != "USUARIO" || contraseña != "CONTRA"))
                     {
                        usuari = false;
                        contraseñ = false;
                        usuario = "";
                        contraseña = "";
                        Console.SetCursorPosition(30, 15);
                        Console.Write("El usuario y/o contraseña no corresponden");
                     }
                     Console.BackgroundColor = ConsoleColor.Black;
                  } while ((usuario != "USUARIO" || contraseña != "CONTRA") || pres.Key != ConsoleKey.Enter);
                  #region Acciones del usuario
                  do
                  {
                     Console.Clear();
                     Console.ForegroundColor = ConsoleColor.Black;
                     Console.BackgroundColor = ConsoleColor.DarkGray;
                     Console.SetCursorPosition(5, 3);
                     Console.Write(usuario);
                     Console.BackgroundColor = ConsoleColor.White;
                     if (opc_usa_fle == 0)
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                     Console.SetCursorPosition(20, 5);
                     Console.Write("Ver anuncios");
                     Console.BackgroundColor = ConsoleColor.White;
                     if (opc_usa_fle == 1)
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                     Console.SetCursorPosition(20, 7);
                     Console.Write("Crear anuncios");
                     Console.BackgroundColor = ConsoleColor.White;
                     if (opc_usa_fle == 2)
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                     Console.SetCursorPosition(20, 9);
                     Console.Write("Historial");
                     Console.BackgroundColor = ConsoleColor.White;
                     if (opc_usa_fle == 3)
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                     Console.SetCursorPosition(35, 17);
                     Console.Write("Cerrar sesión");
                     Console.ForegroundColor = ConsoleColor.Black;
                     Console.BackgroundColor = ConsoleColor.Black;
                     pres = Console.ReadKey();
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
                        #region Selecciona Anuncio
                        if (opc_usa_fle == 0)
                        {
                           Console.Clear();
                           do
                           {
                              Console.ForegroundColor = ConsoleColor.Black;
                              Console.BackgroundColor = ConsoleColor.DarkGray;
                              Console.SetCursorPosition(5, 3);
                              Console.Write(usuario);
                              Console.BackgroundColor = ConsoleColor.White;
                              Console.SetCursorPosition(5, 5);
                              Console.Write("Selecciona anuncio");
                              for (int i = 0; i < 8; i++)
                              {
                                 Console.SetCursorPosition(5, (7 + i));
                                 Console.Write("                         ");
                              }
                              Console.BackgroundColor = ConsoleColor.White;
                              if (opc_cre_anun == 0)
                                 Console.BackgroundColor = ConsoleColor.DarkGreen;
                              Console.SetCursorPosition(5, 17);
                              Console.Write("Regresar");
                              Console.BackgroundColor = ConsoleColor.White;
                              if (opc_cre_anun == 1)
                                 Console.BackgroundColor = ConsoleColor.DarkGreen;
                              Console.SetCursorPosition(35, 17);
                              Console.Write("Cerrar sesión");
                              Console.ForegroundColor = ConsoleColor.Black;
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
                        }
                        #endregion
                        #region Crea Anuncios
                        if (opc_usa_fle == 1)
                        {
                           Console.BackgroundColor = ConsoleColor.Black;
                           Console.Clear();
                           Console.ForegroundColor = ConsoleColor.Green;
                           Console.BackgroundColor = ConsoleColor.Black;
                           Console.SetCursorPosition(19, 2);
                           Console.Write(" Titulo ");
                           Console.SetCursorPosition(14, 6);
                           Console.Write(" Ingrese anuncio ");
                           Console.SetCursorPosition(56, 3);
                           Console.Write(" Fecha Limite");
                           Console.SetCursorPosition(55, 5);
                           Console.Write(" Dia");
                           Console.SetCursorPosition(60, 5);
                           Console.Write(" Mes");
                           Console.SetCursorPosition(65, 5);
                           Console.Write(" Año");
                           Console.BackgroundColor = ConsoleColor.White;
                           Console.SetCursorPosition(5, 4);
                           Console.ForegroundColor = ConsoleColor.Green;
                           Console.Write("                                     ");
                           for (int i = 0; i < 12; i++)
                           {
                              Console.SetCursorPosition(5, (8 + i));
                              Console.Write("                                     ");
                           }
                           Console.ReadKey();
                        }
                        #endregion
                        if (opc_usa_fle == 2)
                        {

                        }
                        if (opc_usa_fle == 3)
                        {
                           op_usua = true;
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                     }
                  } while (op_usua != true);
                  op_usua = false;
                  opc_usa_fle = 0;
               }
               #endregion
               opcion = false;
            }
            #endregion
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            usuari = false;
            contraseñ = false;
            usuario = "";
            contraseña = "";
         } while (pres.Key != ConsoleKey.Escape);
      }
   }
}