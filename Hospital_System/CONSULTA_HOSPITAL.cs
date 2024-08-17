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
using Hospital_System;

namespace Hospital_System
{
    public partial class CONSULTA_HOSPITAL : Form
    {

        Metodos Metodo = new Metodos();
        private bool Editar = false;
        

        private Conexion conexion = new Conexion();

        
        public CONSULTA_HOSPITAL()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CONSULTA_HOSPITAL_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {

            try
            {
                SqlConnection AbrirConexion = conexion.AbrirConexion();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM HOSPITAL", AbrirConexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
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

        private void btneliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtener el código del hospital seleccionado
                    int codigoHospital = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo_hospital"].Value.ToString());

                    // Llamar al método para eliminar el hospital
                    Metodo.Eliminar(codigoHospital);

                    // Método para actualizar la lista de hospitales
                    MessageBox.Show("Eliminado correctamente");
                    Metodo.MostrarHospitales();
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
       
        private void btneditar_Click(object sender, EventArgs e)
        {
           
            
                if(dataGridView1.SelectedRows.Count > 0)
                {


                    try
                    {
                        DataGridViewRow row = dataGridView1.SelectedRows[0];
                        Editar = true;
                        int codigohospital = Convert.ToInt32( row.Cells["codigo_hospital"].Value.ToString());
                        string nombre = row.Cells["Nombre_Hospital"].Value.ToString();
                        string direccion = row.Cells["Direccion_Hospital"].Value.ToString();
                        string telefono = row.Cells["Telefono_Hospital"].Value.ToString();
                        string cantidadCamas = row.Cells["Cantidad_camas_Hospital"].Value.ToString();

                    Nuevo_Hosp nuevoHosp = new Nuevo_Hosp(codigohospital, nombre, direccion, telefono, cantidadCamas);
                    nuevoHosp.ShowDialog();
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

    }
}
