using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public class MetodosdDiagnostico
    {

    
        public class MetodosdeDiagnostico
        {
            private Conexion conexion = new Conexion();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            // Mostrar todos los diagnósticos
            public DataTable MostrarDiagnosticos()
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "MostrarDiagnosticos";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;
            }

            // Insertar un nuevo diagnóstico
            public void InsertarDiagnostico(string tipoDiagnostico, string complicaciones, int codigoLaboratorio, int cuiMedico, int cuiPaciente)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarDiagnostico";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@tipo_diagnostico", tipoDiagnostico);
                comando.Parameters.AddWithValue("@complicaciones", complicaciones);
                comando.Parameters.AddWithValue("@codigo_laboratorio", codigoLaboratorio);
                comando.Parameters.AddWithValue("@cui_medico", cuiMedico);
                comando.Parameters.AddWithValue("@cui_paciente", cuiPaciente);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }

            // Editar un diagnóstico existente
            public void EditarDiagnostico(int codigoDiagnostico, string tipoDiagnostico, string complicaciones, int codigoLaboratorio, int cuiMedico, int cuiPaciente)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EditarDiagnostico";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codigo_diagnostico", codigoDiagnostico);
                comando.Parameters.AddWithValue("@tipo_diagnostico", tipoDiagnostico);
                comando.Parameters.AddWithValue("@complicaciones", complicaciones);
                comando.Parameters.AddWithValue("@codigo_laboratorio", codigoLaboratorio);
                comando.Parameters.AddWithValue("@cui_medico", cuiMedico);
                comando.Parameters.AddWithValue("@cui_paciente", cuiPaciente);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }

            // Eliminar un diagnóstico
            public void EliminarDiagnostico(int codigoDiagnostico)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarDiagnostico";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codigo_diagnostico", codigoDiagnostico);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }

            // Métodos para botones
            public void InsertarDiagnosticoBoton(string tipoDiagnostico, string complicaciones, int codigoLaboratorio, int cuiMedico, int cuiPaciente)
            {
                InsertarDiagnostico(tipoDiagnostico, complicaciones, Convert.ToInt32(codigoLaboratorio), Convert.ToInt32(cuiMedico), Convert.ToInt32(cuiPaciente));
            }

            public void EliminarDiagnosticoBoton(int codigoDiagnostico)
            {
                EliminarDiagnostico(codigoDiagnostico);
            }

            public void EditarDiagnosticoBoton(int codigoDiagnostico, string tipoDiagnostico, string complicaciones, int codigoLaboratorio, int cuiMedico, int cuiPaciente)
            {
                EditarDiagnostico(Convert.ToInt32(codigoDiagnostico), tipoDiagnostico, complicaciones, Convert.ToInt32(codigoLaboratorio), Convert.ToInt32(cuiMedico), Convert.ToInt32(cuiPaciente));
            }
        }
    }
}

