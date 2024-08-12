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
    public partial class Nuevo_Medic : Form
    {
        MetodosdeMedico metodo = new MetodosdeMedico();
        Conexion conexion = new Conexion();
        private bool Editar = false;
        int cuiMedico;
        public Nuevo_Medic()
        {
            InitializeComponent();
        }

        public Nuevo_Medic(int cui_medico, string nombre, string especialidad, int codigoHospital)
        {
            this.cuiMedico = cui_medico;
            txtNombreMedico.Text = nombre;
            txtEspecialidadMedico.Text = especialidad;
            cbcodigoHospital.Text = codigoHospital.ToString();
            Editar = true;
        }

        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            if (txtNombreMedico.Text == "" || txtEspecialidadMedico.Text == "" || cbcodigoHospital.Text == "")
            {
                MessageBox.Show("Complete todos los campos antes de guardar.", "Campos vacíos", MessageBoxButtons.OK);
                return;
            }

            if (Editar == false)
            {
                try
                {
                    
                    conexion.AbrirConexion();
                    metodo.InsertarMedico(txtNombreMedico.Text, txtEspecialidadMedico.Text, Convert.ToInt32(cbcodigoHospital.Text)); // Ajustado
                    conexion.CerrarConexion();

                    MessageBox.Show("Se ha guardado con éxito el nuevo médico.");
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
            else
            {
                try
                {

                    int cui_medico = cuiMedico;
                    string nombre = txtNombreMedico.Text;
                    string especialidad = txtEspecialidadMedico.Text;
                    int codigoHospital = Convert.ToInt32(cbcodigoHospital.Text);

                    metodo.EditarMedico(cui_medico, nombre, especialidad, codigoHospital);
                    InitializeComponent();

                    MessageBox.Show("Se editó correctamente.");
                    metodo.MostrarMedicos();
                    LimpiarForm();
                    Editar = false;
                    this.Dispose();
                    Form consulta = new CONSULTA_MEDICO();
                    consulta.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex.Message);
                }
            }
        }

        private void btnCancelarMedico_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LimpiarForm()
        {
            txtNombreMedico.Clear();
            txtEspecialidadMedico.Clear();
            cbcodigoHospital.Clear();
        }
    }
}
