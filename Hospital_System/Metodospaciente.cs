using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public class metodos_paciente

    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrarpacientes()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrarpacientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string registro, string cama, string nombre, string direccion, string fecha, string sexo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insertarpacientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@registro_paciente", registro);
            comando.Parameters.AddWithValue("@cama_paciente", cama);
            comando.Parameters.AddWithValue("@nombre_paciente", nombre);
            comando.Parameters.AddWithValue("@direccion_paciente", direccion);
            comando.Parameters.AddWithValue("@fechanacimiento_paciente", fecha);
            comando.Parameters.AddWithValue("@sexo_paciente", sexo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar(int cuipaciente, string registro, string cama, string nombre, string direccion, string fecha, string sexo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Editarpacientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CUI_Paciente_paciente", cuipaciente);
            comando.Parameters.AddWithValue("@registro_paciente", registro);
            comando.Parameters.AddWithValue("@cama_paciente", cama);
            comando.Parameters.AddWithValue("@nombre_paciente", nombre);
            comando.Parameters.AddWithValue("@direccion_paciente", direccion);
            comando.Parameters.AddWithValue("@fechanacimiento_paciente", fecha);
            comando.Parameters.AddWithValue("@sexo_paciente", sexo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int cuipaciente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Eliminarpacientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CUI_Paciente_paciente", cuipaciente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Insertarpaciente(string registro, string cama, string nombre, string direccion, string fecha, string sexo)
        {
            Insertar(registro, cama, nombre, direccion, fecha, sexo);
        }

        public void Eliminarpaciente(int cuipaciente)
        {
            Eliminar(cuipaciente);
        }

        public void Editarpaciente(int cuipaciente, string registro, string cama, string nombre, string direccion, string fecha, string sexo)
        {
            Editar(Convert.ToInt32(cuipaciente), registro, cama, nombre, direccion, fecha, sexo);

        }
    }
}