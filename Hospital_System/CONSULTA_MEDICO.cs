using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    int cuiMedico = Convert.ToInt32(row.Cells["CUI_Medico"].Value.ToString());
                    string nombre = row.Cells["Nombre_Medico"].Value.ToString();
                    string especialidad = row.Cells["Especialidad_Medico"].Value.ToString();
                    int codigoHospital = Convert.ToInt32(row.Cells["Codigo_Hospital"].Value.ToString());

                    Nuevo_Medic nuevoMedico = new Nuevo_Medic(cuiMedico, nombre, especialidad, codigoHospital);
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

                    int cuiMedico = Convert.ToInt32(TABLAMEDICO.CurrentRow.Cells["CUI_Medico"].Value.ToString());


                    metodo.EliminarMedico(cuiMedico);

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
                DataTable dataTable = metodo.MostrarMedicos();
                TABLAMEDICO.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}
