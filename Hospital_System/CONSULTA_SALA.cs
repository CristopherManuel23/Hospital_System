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
    public partial class CONSULTA_SALA : Form
    {
        MetodoSala Metodosa = new MetodoSala();
        Conexion conexion = new Conexion();
        private bool Editar = false;
        public CONSULTA_SALA()
        {
            InitializeComponent();
        }

        private void CONSULTA_SALA_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }
        private void ActualizarDataGridView()
        {
            try
            {
                SqlConnection AbrirConexion = conexion.AbrirConexion();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM SALA", AbrirConexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewsala.DataSource = dataTable;
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

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewsala.SelectedRows.Count > 0)
            {


                try
                {
                    DataGridViewRow row = dataGridViewsala.SelectedRows[0];
                    Editar = true;
                    int codigosala = Convert.ToInt32(row.Cells["Codigo_Sala"].Value.ToString());
                    string nombre = row.Cells["Nombre_Sala"].Value.ToString();
                    string cama = row.Cells["Cantidad_Camas"].Value.ToString();
                    int ch = Convert.ToInt32(row.Cells["Codigo_Hospital"].Value.ToString());

                    SALA nuevasala = new SALA(codigosala, nombre, cama, ch);
                    nuevasala.Show();
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewsala.SelectedRows.Count > 0)
                {
                    // Obtener el CUI del paciente seleccionado
                    int codigosala = Convert.ToInt32(dataGridViewsala.CurrentRow.Cells["Codigo_Sala"].Value.ToString());

                    // Llamar al método para eliminar el paciente
                    Metodosa.Eliminar(codigosala);

                    // Método para actualizar la lista de pacientes
                    MessageBox.Show("Eliminado correctamente");
                    Metodosa.Mostrar();
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

        private void dataGridViewsala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
