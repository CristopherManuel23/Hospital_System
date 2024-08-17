using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hospital_System.MetodosdDiagnostico;

namespace Hospital_System
{
    public partial class Cunsulta_Diagnostico : Form
    {
        MetodosdeDiagnostico metodo = new MetodosdeDiagnostico();
        private bool Editar = false;
        private Conexion conexion = new Conexion();

        public Cunsulta_Diagnostico()
        {
            InitializeComponent();
        }

        private void Cunsulta_Diagnostico_Load(object sender, EventArgs e)
        {
            ActualizarTABLADIAGNOSTICO();
        }

        private void ActualizarTABLADIAGNOSTICO()
        {
            try
            {
                DataTable dataTable = metodo.MostrarDiagnosticos();
                TABLADIAGNOSTICO.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnEditarDiag_Click(object sender, EventArgs e)
        {
            if (TABLADIAGNOSTICO.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = TABLADIAGNOSTICO.SelectedRows[0];
                    Editar = true;
                    int codigoDiagnostico = Convert.ToInt32(row.Cells["Codigo_Diagnostico"].Value.ToString());
                    string tipoDiagnostico = row.Cells["Tipo_Diagnostico"].Value.ToString();
                    string complicaciones = row.Cells["Complicaciones"].Value.ToString();
                    int codigoLaboratorio = Convert.ToInt32(row.Cells["Codigo_Laboratorio"].Value.ToString());
                    int cuiMedico = Convert.ToInt32(row.Cells["CUI_Medico"].Value.ToString());
                    int cuiPaciente = Convert.ToInt32(row.Cells["CUI_Paciente"].Value.ToString());

                    Nuevo_Diagnosticos nuevoDiagnostico = new Nuevo_Diagnosticos(codigoDiagnostico, tipoDiagnostico, complicaciones, codigoLaboratorio, cuiMedico, cuiPaciente);
                    nuevoDiagnostico.ShowDialog();
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

        private void btnEliminarDiag_Click(object sender, EventArgs e)
        {
            try
            {
                if (TABLADIAGNOSTICO.SelectedRows.Count > 0)
                {
                    int codigoDiagnostico = Convert.ToInt32(TABLADIAGNOSTICO.CurrentRow.Cells["Codigo_Diagnostico"].Value.ToString());
                    metodo.EliminarDiagnostico(codigoDiagnostico);

                    MessageBox.Show("Eliminado correctamente");
                    ActualizarTABLADIAGNOSTICO();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila, por favor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el diagnóstico: " + ex.Message);
            }

        }
    }
}
