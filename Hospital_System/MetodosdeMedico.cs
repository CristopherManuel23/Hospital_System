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


        public void InsertarMedico(string nombre, string especialidad, int codigo_Hospital)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarMedico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_medico", nombre);
            comando.Parameters.AddWithValue("@especialidad_medico", especialidad);
            comando.Parameters.AddWithValue("@codigo_hospital", codigo_Hospital);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EditarMedico(int cui_Medico, string nombre, string especialidad, int codigo_Hospital)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarMedico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cui_medico", cui_Medico);
            comando.Parameters.AddWithValue("@nombre_medico", nombre);
            comando.Parameters.AddWithValue("@especialidad_medico", especialidad);
            comando.Parameters.AddWithValue("@codigo_hospital", codigo_Hospital);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EliminarMedico(int cui_Medico)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarMedico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cui_medico", cui_Medico);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void InsertarMedicoBoton(string nombre, string especialidad, int codigo_Hospital)
        {
            InsertarMedico(nombre, especialidad, Convert.ToInt32(codigo_Hospital));
        }

        public void EliminarMedicoBoton(int cui_Medico)
        {
            EliminarMedico(cui_Medico);
        }

        public void EditarMedicoBoton(int cui_Medico, string nombre, string especialidad, int codigo_Hospital)
        {
            EditarMedico(Convert.ToInt32(cui_Medico), nombre, especialidad, Convert.ToInt32(codigo_Hospital));
        }

    }
}
