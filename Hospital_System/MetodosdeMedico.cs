using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public class MetodosdeMedico
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarMedicos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMedicos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public void InsertarMedico(string nombre, string especialidad, int codigoHospital)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarMedico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_medico", nombre);
            comando.Parameters.AddWithValue("@especialidad_medico", especialidad);
            comando.Parameters.AddWithValue("@codigo_hospital", codigoHospital);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EditarMedico(int cuiMedico, string nombre, string especialidad, int codigoHospital)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarMedico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cui_medico", cuiMedico);
            comando.Parameters.AddWithValue("@nombre_medico", nombre);
            comando.Parameters.AddWithValue("@especialidad_medico", especialidad);
            comando.Parameters.AddWithValue("@codigo_hospital", codigoHospital);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EliminarMedico(int cuiMedico)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarMedico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cui_medico", cuiMedico);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void InsertarMedicoBoton(string nombre, string especialidad, int codigoHospital)
        {
            InsertarMedico(nombre, especialidad, codigoHospital);
        }

        public void EliminarMedicoBoton(int cuiMedico)
        {
            EliminarMedico(cuiMedico);
        }

        public void EditarMedicoBoton(string nombre, string especialidad, int codigoHospital, int cuiMedico)
        {
            EditarMedico(cuiMedico, nombre, especialidad, codigoHospital);
        }

    }
}
