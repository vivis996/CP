using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;   // Permite trabajar con el gestor de BD MySQL

namespace CP3
{
   public class Variables
   {
      private ConsoleKeyInfo _Presionada;
      public ConsoleKeyInfo presionada
      {
         get { return _Presionada; }
         set { _Presionada = value; }
      }
      private ConsoleKeyInfo _Pres;
      public ConsoleKeyInfo pres
      {
         get { return _Pres; }
         set { _Pres = value; }
      }
      private String Nombre;
      public String nombre
      {
         get { return Nombre; }
         set { Nombre = value; }
      }
      private String Apellido;
      public String apellido
      {
         get { return Apellido; }
         set { Apellido = value; }
      }
      private String Fechaing;
      public String fechaing
      {
         get { return Fechaing; }
         set { Fechaing = value; }
      }
      private Int32 Activo;
      public Int32 activo
      {
         get { return Activo; }
         set { Activo = value; }
      }
      //private String Codigo;
      //public String codigo
      //{
      //    get { return Codigo; }
      //    set { Codigo = value; }
      //}
      // Variables para usar con la BD
      private String _CadenaConexion;
      public String cadenaConexion
      {
         get { return _CadenaConexion; }
         set { _CadenaConexion = value; }
      }
      private MySqlConnection _Conexión;
      public MySqlConnection conexión
      {
         get { return _Conexión; }
         set { _Conexión = value; }
      }
      private String _HostBD;
      public String hostBD
      {
         get { return _HostBD; }
         set { _HostBD = value; }
      }
      private String _HostLocal;
      public String hostLocal
      {
         get { return _HostLocal; }
         set { _HostLocal = value; }
      }
      private bool _EstadoConexión;
      public bool estadoConexión  // Con esta variable, manejare el estado de la conexión a la BD, debido a que el tipo MySqlConnection
      {                           // Del Método obtenerConexión(), no permite utilizarse como tipo bool.
         get { return _EstadoConexión; }
         set { _EstadoConexión = value; }
      }
      private string _MetodoUsado;
      public string metodoUsado
      {
         get { return _MetodoUsado; }
         set { _MetodoUsado = value; }
      }
      private bool _EstadoSesion;
      public bool estadoSesion
      {
         get { return _EstadoSesion; }
         set { _EstadoSesion = value; }
      }
   }
}