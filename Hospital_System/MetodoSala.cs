using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    internal class MetodoSala
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarSalas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string cama,  int ch)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarSala";
            comando.CommandType = CommandType.StoredProcedure; 
            comando.Parameters.AddWithValue("@nombre_sala", nombre);
            comando.Parameters.AddWithValue("@cantidad_camas_sala", cama);
            comando.Parameters.AddWithValue("@codigo_hospital", ch);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar(int codigosala, string nombre, string cama, int ch)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarSala";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo_sala", codigosala);
            comando.Parameters.AddWithValue("@nombre_sala", nombre);
            comando.Parameters.AddWithValue("@cantidad_camas_sala", cama);
            comando.Parameters.AddWithValue("@codigo_hospital", ch);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int codigosala)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarSala";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo_sala", codigosala);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable Listahospital() 
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Listahospital";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarSala(string nombre, string cama, int ch)
        {
            Insertar( nombre, cama, Convert.ToInt32(ch));
        }

        public void EliminarSala(int codigosala)
        {
            Eliminar(codigosala);
        }

        public void EditarSala(int codigosala, string nombre, string cama, int ch)
        {
            Editar(Convert.ToInt32(codigosala),  nombre, cama, Convert.ToInt32(ch));

        }
        
    }
}
