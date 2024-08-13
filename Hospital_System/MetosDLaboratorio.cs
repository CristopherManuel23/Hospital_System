using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public class MetosDLaboratorio
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        // Método para mostrar todos los laboratorios
        public DataTable MostrarLaboratorios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarLaboratorios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        // Método para insertar un nuevo laboratorio
        public void InsertarLaboratorio(string nombre, string direccion, string telefono, int codigoHospital)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarLaboratorio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_laboratorio", nombre);
            comando.Parameters.AddWithValue("@direccion_laboratorio", direccion);
            comando.Parameters.AddWithValue("@telefono_laboratorio", telefono);
            comando.Parameters.AddWithValue("@codigo_hospital", codigoHospital);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Método para editar un laboratorio existente
        public void EditarLaboratorio(int codigoLaboratorio, string nombre, string direccion, string telefono, int codigoHospital)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarLaboratorio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo_laboratorio", codigoLaboratorio);
            comando.Parameters.AddWithValue("@nombre_laboratorio", nombre);
            comando.Parameters.AddWithValue("@codigo_hospital", codigoHospital);
            comando.Parameters.AddWithValue("@direccion_laboratorio", direccion);
            comando.Parameters.AddWithValue("@telefono_laboratorio", telefono);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Método para eliminar un laboratorio
        public void EliminarLaboratorio(int codigoLaboratorio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarLaboratorio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo_laboratorio", codigoLaboratorio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Métodos de soporte para acciones desde botones, ajustados a laboratorios
        public void Insertar(string nombre, string direccion, string telefono, int codigoHospital)
        {
            InsertarLaboratorio(nombre, direccion, telefono, Convert.ToInt32 (codigoHospital));
        }

        public void Eliminar(int codigoLaboratorio)
        {
            EliminarLaboratorio(Convert.ToInt32(codigoLaboratorio));
        }

        public void Editar(int codigoLaboratorio, string nombre, string direccion, string telefono, int codigoHospital)
        {
            EditarLaboratorio(Convert.ToInt32(codigoLaboratorio), nombre, direccion, telefono, Convert.ToInt32(codigoHospital));
        }
    }
}
