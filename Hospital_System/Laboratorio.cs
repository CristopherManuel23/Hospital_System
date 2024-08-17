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
    public partial class Laboratorio : Form
    {
        Conexion conexion = new Conexion();
        private bool Editar = false;
        int codigoLaboratorio;

        public Laboratorio()
        {
            InitializeComponent();
            DeshabilitarControles();
        }

        /*Metodo para Llenar el Combobox*/
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
                comboBox1.DataSource = dataTable;
                comboBox1.DisplayMember = "Nombre_Hospital";
                comboBox1.ValueMember = "codigo_hospital";
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

        public Laboratorio(int codigo_Laboratorio, string nombre, string direccion, string telefono, int codigoHospital)
        {
            InitializeComponent();
            codigoLaboratorio = codigo_Laboratorio;
            txtNombre.Text = nombre;
            txtDireccion.Text = direccion;
            mtbTelefono.Text = telefono;
            comboBox1.SelectedValue = codigoHospital;
            Editar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                // Validar campos vacíos
                if (txtNombre.Text == "" || txtDireccion.Text == "" || mtbTelefono.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Complete todos los campos antes de guardar.", "Campos vacíos", MessageBoxButtons.OK);
                    return;
                }

                // Obtener valores de los campos
                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                string telefono = mtbTelefono.Text;
                int codigo_hospital = Convert.ToInt32(comboBox1.SelectedValue);

                MetosDLaboratorio Metodos = new MetosDLaboratorio();

                if (!Editar)
                {
                    // Código para insertar
                    Metodos.Insertar(nombre, direccion, telefono, codigo_hospital);
                    MessageBox.Show("Se ha guardado con éxito el nuevo Laboratorio");
                }
                else
                {
                    // Código para editar
                    int codigo_Laboratorio = codigoLaboratorio;
                    Metodos.Editar(codigo_Laboratorio, nombre, direccion, telefono, codigo_hospital);
                    MessageBox.Show("Se editó correctamente");
                    Editar = false;
                }

                // Limpiar el formulario y cerrar el actual
                limpiarForm();
                Form consulta = new ConsultaLaboratorio();
                consulta.ShowDialog();
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void limpiarForm()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            mtbTelefono.Clear();
        }

        private void Laboratorio_Load(object sender, EventArgs e)
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
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            mtbTelefono.Enabled = false;
            comboBox1.Enabled = false;
            button1.Enabled = false;
        }

        // Método para habilitar los controles de entrada
        private void HabilitarControles()
        {
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            mtbTelefono.Enabled = true;
            comboBox1.Enabled = true;
            button1.Enabled = true;
        }
    }
}
