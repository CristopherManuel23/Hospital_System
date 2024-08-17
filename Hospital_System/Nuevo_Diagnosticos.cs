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
using static Hospital_System.MetodosdDiagnostico;

namespace Hospital_System
{
    public partial class Nuevo_Diagnosticos : Form
    {
        MetodosdeDiagnostico metodo = new MetodosdeDiagnostico();
        Conexion conexion = new Conexion();
        private bool Editar = false;
        int codigoDiagnostico;

        public Nuevo_Diagnosticos()
        {
            InitializeComponent();
            DeshabilitarControles();
        }

        public Nuevo_Diagnosticos(int codigo_Diagnostico, string tipoDiagnostico, string complicaciones, int codigoLaboratorio, int cuiMedico, int cuiPaciente)
        {
            InitializeComponent();
            this.codigoDiagnostico = codigo_Diagnostico;
            txtTipoDiagnostico.Text = tipoDiagnostico;
            txtComplicaciones.Text = complicaciones;
            cbcodigoLab.SelectedValue = codigoLaboratorio;
            cbcodigoMedico.SelectedValue = cuiMedico;
            cbcodigoPaciente.SelectedValue = cuiPaciente;
            Editar = true;
        }

        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTipoDiagnostico.Text == "" || txtComplicaciones.Text == "" || cbcodigoLab.Text == "" || cbcodigoMedico.Text == "" || cbcodigoPaciente.Text == "")
                {
                    MessageBox.Show("Complete todos los campos antes de guardar.", "Campos vacíos", MessageBoxButtons.OK);
                    return;
                }

                string tipoDiagnostico = txtTipoDiagnostico.Text;
                string complicaciones = txtComplicaciones.Text;
                int codigoLaboratorio = Convert.ToInt32(cbcodigoLab.SelectedValue);
                int cuiMedico = Convert.ToInt32(cbcodigoMedico.SelectedValue);
                int cuiPaciente = Convert.ToInt32(cbcodigoPaciente.SelectedValue);

                if (!Editar)
                {
                    metodo.InsertarDiagnosticoBoton(tipoDiagnostico, complicaciones, codigoLaboratorio, cuiMedico, cuiPaciente);
                    MessageBox.Show("Se ha guardado con éxito el nuevo diagnóstico.");
                }
                else
                {
                    int codigo_Diagnostico = codigoDiagnostico;
                    metodo.EditarDiagnosticoBoton(codigo_Diagnostico, tipoDiagnostico, complicaciones, codigoLaboratorio, cuiMedico, cuiPaciente);
                    MessageBox.Show("Se editó correctamente.");
                    Editar = false;
                }

                LimpiarForm();
                Form consulta = new Cunsulta_Diagnostico(); // Cambia esto si tu formulario de consulta tiene otro nombre
                consulta.ShowDialog();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

        private void LimpiarForm()
        {
            txtTipoDiagnostico.Clear();
            txtComplicaciones.Clear();
        }

        private void btnCancelarMedico_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            HabilitarControles();
        }

        // Método para deshabilitar los controles de entrada
        private void DeshabilitarControles()
        {
            txtTipoDiagnostico.Enabled = false;
            txtComplicaciones.Enabled = false;
            cbcodigoLab.Enabled = false;
            cbcodigoMedico.Enabled = false;
            cbcodigoPaciente.Enabled = false;
            btnGuardarMedico.Enabled = false;
        }

        // Método para habilitar los controles de entrada
        private void HabilitarControles()
        {
            txtTipoDiagnostico.Enabled = true;
            txtComplicaciones.Enabled = true;
            cbcodigoLab.Enabled = true;
            cbcodigoMedico.Enabled = true;
            cbcodigoPaciente.Enabled = true;
            btnGuardarMedico.Enabled = true;
        }

        private void LlenarComboBoxLaboratorio()
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conexion = this.conexion.AbrirConexion();
                cmd = new SqlCommand("SELECT Codigo_Laboratorio, Nombre_Laboratorio FROM LABORATORIO", conexion); // Ajusta según tu tabla
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                cbcodigoLab.DataSource = dataTable;
                cbcodigoLab.DisplayMember = "Nombre_Laboratorio"; // Cambia esto según tu tabla
                cbcodigoLab.ValueMember = "Codigo_Laboratorio"; // Cambia esto según tu tabla
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

        private void LlenarComboBoxMedico()
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conexion = this.conexion.AbrirConexion();
                cmd = new SqlCommand("SELECT CUI_Medico, Nombre_Medico FROM MEDICO", conexion);
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                cbcodigoMedico.DataSource = dataTable;
                cbcodigoMedico.DisplayMember = "Nombre_Medico";
                cbcodigoMedico.ValueMember = "CUI_Medico";
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

        private void LlenarComboBoxPaciente()
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conexion = this.conexion.AbrirConexion();
                cmd = new SqlCommand("SELECT CUI_Paciente, Nombre_Paciente FROM PACIENTE", conexion);
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                cbcodigoPaciente.DataSource = dataTable;
                cbcodigoPaciente.DisplayMember = "Nombre_Paciente";
                cbcodigoPaciente.ValueMember = "CUI_Paciente";
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

        private void Nuevo_Diagnosticos_Load(object sender, EventArgs e)
        {
            LlenarComboBoxLaboratorio();
            LlenarComboBoxMedico();
            LlenarComboBoxPaciente();
        }
    }
}
