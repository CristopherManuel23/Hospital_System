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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            DeshabilitarControles();

        }

        public Nuevo_Medic(int cui_Medico, string nombre, string especialidad, int codigo_Hospital)
        {
            InitializeComponent();

            cuiMedico = cui_Medico;
            txtNombreMedico.Text = nombre;
            txtEspecialidadMedico.Text = especialidad;
            cbcodigoHospital.SelectedValue = codigo_Hospital;
            Editar = true;
        }

        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombreMedico.Text == "" || txtEspecialidadMedico.Text == "" || cbcodigoHospital.Text == "")
                {
                    MessageBox.Show("Complete todos los campos antes de guardar.", "Campos vacíos", MessageBoxButtons.OK);
                    return;
                }


                string nombre = txtNombreMedico.Text;
                string especialidad = txtEspecialidadMedico.Text;
                int codigo_Hospital = Convert.ToInt32(cbcodigoHospital.SelectedValue);

                MetodosdeMedico Metodos = new MetodosdeMedico();

                if (!Editar)
                {

                    Metodos.InsertarMedicoBoton(nombre, especialidad, codigo_Hospital);
                    MessageBox.Show("Se ha guardado con éxito el nuevo medico");
                }
                else
                {
                    MetodosdeMedico medico = new MetodosdeMedico();
                    int cui_Medico = cuiMedico;
                    Metodos.EditarMedicoBoton(cui_Medico, nombre, especialidad, codigo_Hospital);
                    MessageBox.Show("Se editó correctamente");
                    Editar = false;
                }

                LimpiarForm();
                Form consulta = new CONSULTA_MEDICO();
                consulta.ShowDialog();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
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

        }

        private void LlenarComboBox2()
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conexion = this.conexion.AbrirConexion();
                cmd = new SqlCommand("SELECT codigo_hospital, Nombre_Hospital FROM HOSPITAL", conexion);
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                cbcodigoHospital.DataSource = dataTable;
                cbcodigoHospital.DisplayMember = "Nombre_Hospital";
                cbcodigoHospital.ValueMember = "codigo_hospital";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conexion != null) this.conexion.CerrarConexion();
            }
        }

        private void Nuevo_Medic_Load(object sender, EventArgs e)
        {
            LlenarComboBox2();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            HabilitarControles();
        }

        // Método para deshabilitar los controles de entrada
        private void DeshabilitarControles()
        {
            txtNombreMedico.Enabled = false;
            txtEspecialidadMedico.Enabled = false;
            cbcodigoHospital.Enabled = false;
            btnGuardarMedico.Enabled = false;
        }

        // Método para habilitar los controles de entrada
        private void HabilitarControles()
        {
            txtNombreMedico.Enabled = true;
            txtEspecialidadMedico.Enabled = true;
            cbcodigoHospital.Enabled = true;
            btnGuardarMedico.Enabled = true;
        }
    }
}
