using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace CP3
{
   public class MetodosConsulta : Conexion
   {
      public MetodosConsulta()
      {
         //ConexionBD(); // Llamamos al metodo para verificar si existe conexión con la BD.
      }
      //public Boolean buscar_codigo(datosAnuncio empleados)
      //{
      //    Boolean estado = true;
      //    obtenerConexion();
      //    String query = "SELECT * FROM usuarios WHERE codigo=@codigo";
      //    MySqlCommand cmd = new MySqlCommand(query, conexion);
      //    cmd.Parameters.Add("@codigo", MySqlDbType.VarChar, 20).Value = empleados.usuario;
      //    try
      //    {
      //        MySqlDataReader reader = cmd.ExecuteReader();
      //        while (reader.Read())
      //        {
      //            Console.WriteLine("Codigo:               " + reader.GetString(0));
      //            Console.WriteLine("Nombre:           " + reader.GetString(1));
      //            Console.WriteLine("Apellido:         " + reader.GetString(2));
      //            Console.WriteLine("Fecha de ingreso: " + reader.GetString(3));
      //            Console.WriteLine("Activo:           " + reader.GetString(4));
      //        }
      //    }
      //    catch (NullReferenceException ex) { Console.WriteLine(ex); estado = false; }
      //    finally { cerrar(); }
      //    return estado;
      //}
      public bool iniciarSesion(string usuario, string contraseña)
      {
         ConexionBD();
         string query = "SELECT * FROM usuarios WHERE usuario=@usuario AND contraseña=@contraseña";
         MySqlCommand cmd = new MySqlCommand(query, conexión);
         cmd.Parameters.Add("@usuario", MySqlDbType.VarChar, 45).Value = usuario;
         cmd.Parameters.Add("@contraseña", MySqlDbType.VarChar, 45).Value = contraseña;
         MySqlDataReader reader = cmd.ExecuteReader();
         if (reader.HasRows == true)
         {
            cerrarConexión();
            estadoSesion = true;
            return true;
         }
         else
         {
            cerrarConexión();
            estadoSesion = false;
            return false;
         }
      }
      public Boolean consultar_todosAnuncios()
      {
         Boolean estado = true;
         ConexionBD();
         String query = "SELECT * FROM anuncios";
         MySqlCommand cmd = new MySqlCommand(query, conexión);
         try
         {
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine("\n");
               Console.WriteLine("\t\tTitulo:                  {0}", reader.GetString(0));
               Console.WriteLine("\t\tContenido:               {0}", reader.GetString(1));
               Console.WriteLine("\t\tFecha de Publicación:    {0}", reader.GetString(2));
               Console.WriteLine("\t\tAutor:                   {0}", reader.GetString(4));
               Console.WriteLine("\t\tIndice del anuncio:      {0}", reader.GetString(5));
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("\n█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗");
               Console.WriteLine("╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝");
            }
         }
         catch (NullReferenceException ex) { Console.WriteLine(ex); estado = false; }
         finally { cerrarConexión(); }
         return estado;
      }
      public Boolean consultar_todosAnunciosUsuario(string usuario)
      {
         Boolean estado = true;
         ConexionBD();
         String query = "SELECT titulo FROM anuncios WHERE usuario=@usuario";
         MySqlCommand cmd = new MySqlCommand(query, conexión);
         try
         {
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine("\n");
               Console.WriteLine("\t\tTitulo:                  {0}", reader.GetString(0));
               Console.WriteLine("\t\tContenido:               {0}", reader.GetString(1));
               Console.WriteLine("\t\tFecha de Publicación:    {0}", reader.GetString(2));
               Console.WriteLine("\t\tAutor:                   {0}", reader.GetString(4));
               Console.WriteLine("\t\tIndice del anuncio:      {0}", reader.GetString(5));
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("\n█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗");
               Console.WriteLine("╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝");
            }
         }
         catch (NullReferenceException ex) { Console.WriteLine(ex); estado = false; }
         finally { cerrarConexión(); }
         return estado;
      }
      //public Boolean consultar_todosUsuarios()
      //{
      //    Boolean estado = true;
      //    ConexionBD();
      //    String query = "SELECT * FROM usuarios";
      //    MySqlCommand cmd = new MySqlCommand(query, conexión);
      //    try
      //    {
      //        MySqlDataReader reader = cmd.ExecuteReader();
      //        while (reader.Read())
      //        {
      //            Console.WriteLine("Usuario:           {0}", reader.GetString(0));
      //            Console.WriteLine("Contraseña:        {0}", reader.GetString(1));
      //            Console.WriteLine("Fecha Registro:    {0}", reader.GetString(4));
      //        }
      //    }
      //    catch (NullReferenceException ex) { Console.WriteLine(ex); estado = false; }
      //    finally { cerrarConexión(); }
      //    return estado;
      //}
      public Boolean registrarUsuario(string usuario, string contraseña, string nombre, string apellido, string fecha)
      {
         ConexionBD();
         Boolean estado = true;
         try
         {
            String query = "INSERT INTO usuarios(usuario, contraseña, nombre, apellido, fechaRegistro) VALUES(@usuario, @contraseña, @nombre, @apellido, @fecha)";
            MySqlCommand cmd = new MySqlCommand(query, conexión);
            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar, 45).Value = usuario;
            cmd.Parameters.Add("@contraseña", MySqlDbType.VarChar, 20).Value = contraseña;
            cmd.Parameters.Add("@nombre", MySqlDbType.VarChar, 20).Value = nombre;
            cmd.Parameters.Add("@apellido", MySqlDbType.VarChar, 20).Value = apellido;
            cmd.Parameters.Add("@fecha", MySqlDbType.VarChar, 20).Value = fecha;
            cmd.ExecuteNonQuery();
         }
         catch (MySqlException ex) { estado = false; }
         finally { cerrarConexión(); }
         return estado;
      }
      public Boolean registrarAnuncio(string titulo, string contenido, string fecha, string categoria, string autor)
      {
         ConexionBD();
         Boolean estado = true;
         try
         {
            String query = "INSERT INTO anuncios(titulo, contenido, fechaPublic, categoria, autor) VALUES(@titulo, @contenido, @fecha, @categoria, @autor)";
            MySqlCommand cmd = new MySqlCommand(query, conexión);
            cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = titulo;
            cmd.Parameters.Add("@contenido", MySqlDbType.VarChar, 20).Value = contenido;
            cmd.Parameters.Add("@fecha", MySqlDbType.VarChar, 20).Value = fecha;
            cmd.Parameters.Add("@categoria", MySqlDbType.VarChar, 20).Value = categoria;
            cmd.Parameters.Add("@autor", MySqlDbType.VarChar, 20).Value = autor;
            cmd.ExecuteNonQuery();
         }
         catch (MySqlException ex) { estado = false; }
         finally { cerrarConexión(); }
         return estado;
      }
      //public Boolean registrarAnuncio(string titulo, string contenido, string fechaPublic, string categoria, string autor)
      //{
      //    Boolean estado = true;
      //    try
      //    {
      //        String query = "INSERT INTO anuncios(titulo, contenido, fechaPublic, categoria, autor) VALUES(@titulo, @contenido, @fechaPublic, @categoria, @autor)";
      //        MySqlCommand cmd = new MySqlCommand(query, conexión);
      //        cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = titulo;
      //        cmd.Parameters.Add("@contenido", MySqlDbType.VarChar, 45).Value = datos.titulo;
      //        cmd.Parameters.Add("@contraseña", MySqlDbType.VarChar, 20).Value = datos.contraseña;
      //        cmd.ExecuteNonQuery();
      //    }
      //    catch (MySqlException ex) { estado = false; }
      //    finally { cerrarConexión(); }
      //    return estado;
      //}
      //        public Boolean actualizar_datos(Variables empleados)
      //        {
      //            Boolean estado = true;
      //            try
      //            {
      //                obtenerConexion();
      //                conexion.Open();
      //                String query = "UPDATE usuarios SET nombre=@nombre, apellido=@apellido, fechaing=@fechaing, activo=@activo WHERE codigo=@codigo";
      //                MySqlCommand cmd = new MySqlCommand(query, conexion);
      //                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = empleados.nombre;
      //                cmd.Parameters.Add("@apellido", MySqlDbType.VarChar, 45).Value = empleados.apellido;
      //                cmd.Parameters.Add("@fechaing", MySqlDbType.VarChar, 45).Value = empleados.fechaing;
      //                cmd.Parameters.Add("@activo", MySqlDbType.Int32, 10).Value = empleados.activo;
      //                cmd.Parameters.Add("@codigo", MySqlDbType.VarChar, 20).Value = empleados.codigo;
      //                cmd.ExecuteNonQuery();
      //            }
      //            catch (MySqlException ex) { Console.WriteLine(ex); estado = false; }
      //            finally { cerrar(); }
      //            return estado;
      //        }
      //        public Boolean borrar_datos(Variables empleados)
      //        {
      //            Boolean estado = true;
      //            try
      //            {
      //                obtenerConexion();
      //                conexion.Open();
      //                MySqlCommand cmd = new MySqlCommand("DELETE FROM usuarios WHERE codigo=@codigo", conexion);
      //                cmd.Parameters.Add("@codigo", MySqlDbType.VarChar, 20).Value = empleados.codigo;
      //                cmd.ExecuteNonQuery();
      //            }
      //            catch (NullReferenceException ex) { Console.WriteLine(ex); estado = false; }
      //            finally { cerrar(); }
      //            return estado;
      //        }
      private void cerrarConexión()
      {
         conexión.Close();
      }
   }
}