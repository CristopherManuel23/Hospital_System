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
    public partial class ConsultaLaboratorio : Form
    {
        MetosDLaboratorio Metodos = new MetosDLaboratorio();
        private Conexion conexion = new Conexion();
        private bool Editar = false;
        public ConsultaLaboratorio()
        {
            InitializeComponent();
        }

        private void ActualizarDataGridView()
        {

            try
            {
                SqlConnection AbrirConexion = conexion.AbrirConexion();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM LABORATORIO", AbrirConexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewLaboratorio.DataSource = dataTable;
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

        private void ConsultaLaboratorio_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewLaboratorio.SelectedRows.Count > 0)
            {

                try
                {
                    DataGridViewRow row = dataGridViewLaboratorio.SelectedRows[0];
                    Editar = true;

                    int codigo_Laboratorio = Convert.ToInt32(row.Cells["codigo_Laboratorio"].Value.ToString());
                    string nombre = row.Cells["Nombre_Laboratorio"].Value.ToString();
                    string direccion = row.Cells["Direccion_Laboratorio"].Value.ToString();
                    string telefono = row.Cells["Telefono_Laboratorio"].Value.ToString();
                    int codigohospital = Convert.ToInt32(row.Cells["codigo_Laboratorio"].Value.ToString());

                    Laboratorio nuevo = new Laboratorio(codigo_Laboratorio, nombre, direccion, telefono, codigohospital);
                    nuevo.ShowDialog();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewLaboratorio.SelectedRows.Count > 0)
                {
                    // Obtener el código del hospital seleccionado
                    int codigoHospital = Convert.ToInt32(dataGridViewLaboratorio.CurrentRow.Cells["codigo_Laboratorio"].Value.ToString());

                    // Llamar al método para eliminar el hospital
                    Metodos.Eliminar(codigoHospital);

                    // Método para actualizar la lista de hospitales
                    MessageBox.Show("Eliminado correctamente");
                    Metodos.MostrarLaboratorios();
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
            //60
        }
    }
}
