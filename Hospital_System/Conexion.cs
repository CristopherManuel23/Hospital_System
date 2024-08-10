using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public class Conexion
    {
        // Cadena de conexión, se puede ajustar según sea necesario.
        private readonly SqlConnection _conexion = new SqlConnection("Data Source=.;Initial Catalog=Hospital_System;Integrated Security=true");

        // Método para abrir la conexión.
        public SqlConnection AbrirConexion()
        {
            if (_conexion.State == ConnectionState.Closed)
                _conexion.Open();
            return _conexion;
        }

        // Método para cerrar la conexión.
        public SqlConnection CerrarConexion()
        {
            if (_conexion.State == ConnectionState.Open)
                _conexion.Close();
            return _conexion;

        }

    }
 }
