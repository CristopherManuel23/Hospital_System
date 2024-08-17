using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class CONSULTA_PACIENTE : Form
    {
        metodos_paciente Metodopa = new metodos_paciente();
        private bool Editar = false;
        private Conexion conexion = new Conexion();

        public CONSULTA_PACIENTE()
        {
            InitializeComponent();
        }

        private void CONSULTA_PACIENTE_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }
        private void ActualizarDataGridView()
        {
            try
            {
                SqlConnection AbrirConexion = conexion.AbrirConexion();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM PACIENTE", AbrirConexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewpaciente.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btneditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewpaciente.SelectedRows.Count > 0)
            {


                try
                {
                    DataGridViewRow row = dataGridViewpaciente.SelectedRows[0];
                    Editar = true;
                    int cuipaciente = Convert.ToInt32(row.Cells["CUI_Paciente"].Value.ToString());
                    string registro = row.Cells["No_Registro_Paciente"].Value.ToString();
                    string cama = row.Cells["No_cama_Paciente"].Value.ToString();
                    string nombre = row.Cells["Nombre_Paciente"].Value.ToString();
                    string direccion = row.Cells["Direccion_Paciente"].Value.ToString();
                    string fecha = row.Cells["Fecha_Nacimiento_Paciente"].Value.ToString();
                    string sexo = row.Cells["Sexo_Paciente"].Value.ToString();

                    PACIENTE nuevopaciente = new PACIENTE(cuipaciente, registro, cama, nombre, direccion, fecha, sexo);
                    nuevopaciente.ShowDialog();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor.");
            }
        }


        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewpaciente.SelectedRows.Count > 0)
                {
                    // Obtener el CUI del paciente seleccionado
                    int cuipaciente = Convert.ToInt32(dataGridViewpaciente.CurrentRow.Cells["CUI_Paciente"].Value.ToString());

                    // Llamar al método para eliminar el paciente
                    Metodopa.Eliminar(cuipaciente);

                    // Método para actualizar la lista de pacientes
                    MessageBox.Show("Eliminado correctamente");
                    Metodopa.Mostrarpacientes();
                    ActualizarDataGridView();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila, por favor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
