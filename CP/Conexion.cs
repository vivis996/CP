using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CP3
{
   /// Local
   /// Contraseña Root para MySQL - upqroo   
   /// DB Name : anuncios
   /// 
   /// DB4FREE.NET - BD Remota
   /// Usuario: proyectoanuncios
   /// PASS: anuncios
   /// LOGIN PHPMYADMIN: 
   public class Conexion : Variables
   {
      public Conexion()    // Metodo Constructor de la Clase
      {
         hostBD = "db4free.net";   // Es la dirección IP, predeterminada del servidor de BD Remoto.
         hostLocal = "127.0.0.1";  // Dirección para buscar si el servidor de BD esta instalado localmente.
                                   //comprobarEstadoConexiónBD();   // Con esto, verifico que la conexión a la BD sea correcta al ejecutar el programa.
                                   //conexión.Close();   // Con esto, cierro la conexión a la BD para que no exista error con las peticiones que realizemos a ella.
      }
      #region Conectar a la BD
      public MySqlConnection ConexionBD()
      {
         if (verificarConexionInternet())
         {
            cadenaConexion = "server=" + hostBD + "  ; database=anuncios; Uid=proyectoanuncios; pwd=anuncios; port=3306;";
            metodoUsado = "Remoto";
         }
         else
         {
            cadenaConexion = "server=" + hostLocal + "; database=anuncios; Uid=UsuarioProyecto; pwd=anuncios; port=3306;";
            metodoUsado = "Local";
         }
         conexión = new MySqlConnection(cadenaConexion);
         try
         {
            conexión.Open();
            estadoConexión = true;
         }
         catch (MySqlException ex)
         {
            //Console.WriteLine("No conectado a la BD {0}\n", ex); // Comenté este metodo, debido a que no es necesario conocer el error.
            estadoConexión = false;                                 // Ya que agregué esta variable, la cual, cumple este propósito.
         }
         return conexión;
      }
      #endregion
      #region Comprobar la Conexión a la BD.
      public void comprobarEstadoConexiónBD()
      {
         do
         {
            ConexionBD();
            if (estadoConexión)
            {
               Console.WriteLine("> Conexión Exitosa en Modo {0}", metodoUsado);
            }
            else
            {
               Console.WriteLine("> Ingresa la dirección IP del Host para conectarse.");
               Console.Write("      Utiliza el siguiente formato (192.168.0.0): ");
               hostBD = Console.ReadLine();
            }
         } while (estadoConexión != true);
      }
      #endregion
      #region Verificar Conexión a Internet.
      public bool verificarConexionInternet()
      {
         try
         {
            System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
            return true;
         }
         catch (Exception ex)
         {
            //Console.WriteLine("No hay conexión a Internet!");
            return false;
         }
      }
      #endregion
   }
}