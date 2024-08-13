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
    public partial class CONSULTA_MEDICO : Form
    {
        MetodosdeMedico metodo = new MetodosdeMedico();
        private bool Editar = false;
        private Conexion conexion = new Conexion();
        public CONSULTA_MEDICO()
        {
            InitializeComponent();
        }

        private void CONSULTA_MEDICO_Load(object sender, EventArgs e)
        {
            ActualizarTABLAMEDICO();
        }

        private void btnEditarMedico_Click(object sender, EventArgs e)
        {
            if (TABLAMEDICO.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = TABLAMEDICO.SelectedRows[0];
                    Editar = true;
                    int cui_Medico = row.Cells["CUI_Medico"].Value != null ? Convert.ToInt32(row.Cells["CUI_Medico"].Value.ToString()) : 0;
                    string nombre = row.Cells["Nombre_Medico"].Value != null ? row.Cells["Nombre_Medico"].Value.ToString() : string.Empty;
                    string especialidad = row.Cells["Especialidad_Medico"].Value != null ? row.Cells["Especialidad_Medico"].Value.ToString() : string.Empty;
                    int codigo_Hospital = row.Cells["codigo_hospital"].Value != null ? Convert.ToInt32(row.Cells["codigo_hospital"].Value.ToString()) : 0;

                    Nuevo_Medic nuevoMedico = new Nuevo_Medic(cui_Medico, nombre, especialidad, codigo_Hospital);
                    nuevoMedico.Show();
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

        private void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (TABLAMEDICO.SelectedRows.Count > 0)
                {

                    int cui_Medico = Convert.ToInt32(TABLAMEDICO.CurrentRow.Cells["CUI_Medico"].Value.ToString());


                    metodo.EliminarMedico(cui_Medico);

                    MessageBox.Show("Eliminado correctamente");
                    ActualizarTABLAMEDICO();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila, por favor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el médico: " + ex.Message);
            }

        }

        private void ActualizarTABLAMEDICO()
        {
            try
            {
                SqlConnection AbrirConexion = conexion.AbrirConexion();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM MEDICO", AbrirConexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                TABLAMEDICO.DataSource = dataTable;
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
    }
}
