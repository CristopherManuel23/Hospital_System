using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public class Metodos
        
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarHospitales()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarHospitales";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string direccion, string telefono, string cantidadCamas)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarHospital";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_hospital", nombre);
            comando.Parameters.AddWithValue("@direccion_hospital", direccion);
            comando.Parameters.AddWithValue("@telefono_hospital", telefono);
            comando.Parameters.AddWithValue("@cantidad_camas_hospital", cantidadCamas);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar(int codigoHospital, string nombre, string direccion, string telefono, string cantidadCamas)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarHospital";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo_hospital", codigoHospital);
            comando.Parameters.AddWithValue("@nombre_hospital", nombre);
            comando.Parameters.AddWithValue("@direccion_hospital", direccion);
            comando.Parameters.AddWithValue("@telefono_hospital", telefono);
            comando.Parameters.AddWithValue("@cantidad_camas_hospital", cantidadCamas);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int codigoHospital)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarHospital";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo_hospital", codigoHospital);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
   
        public void InsertarHospital_boton(string nombre, string direccion, string telefono, string cantidadCamas)
        {
            Insertar(nombre, direccion, telefono, cantidadCamas);
        }

        public void EliminarHospital(int codigoHospital)
        {
            Eliminar(codigoHospital);
        }

        public void EditarHospital(string nombre, string direccion , string telefono , string cantidadCamas , int codigoHospital)
        {
            Editar(Convert.ToInt32(codigoHospital), nombre, direccion, telefono, cantidadCamas);
          
        }

    }
}
