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
    public partial class PACIENTE : Form
    {
        metodos_paciente Metodopa = new metodos_paciente();
        Conexion conexion = new Conexion();
        private bool Editar = false;
        int cui_paciente;
        public PACIENTE()
        {
            InitializeComponent();
            DeshabilitarControles();
        }

        private void PACIENTE_Load(object sender, EventArgs e)
        {

        }
        public PACIENTE(int cuipaciente, string registro, string cama, string nombre, string direccion, string fecha, string sexo)
        {
            InitializeComponent();

            // Asignar valores a los controles del formulario

            cui_paciente = cuipaciente;
            txtregistro.Text = registro;
            txtcama.Text = cama;
            txtnombre.Text = nombre;
            txtdireccion.Text = direccion;
            txtfecha.Text = fecha;
            txtsexo.Text = sexo;
            Editar = true;
        }


        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtregistro.Text == "" || txtcama.Text == "" || txtnombre.Text == "" || txtdireccion.Text == "" || txtfecha.Text == "" || txtsexo.Text == "")
                {
                    MessageBox.Show("Complete todos los campos antes de guardar.", "Campos vacíos", MessageBoxButtons.OK);
                    return;
                }

                // Código para editar
                string registro = txtregistro.Text;
                string cama = txtcama.Text;
                string nombre = txtnombre.Text;
                string direccion = txtdireccion.Text;
                string fecha = txtfecha.Text;
                string sexo = txtsexo.Text;

                metodos_paciente Metodopa = new metodos_paciente();

                if (!Editar)
                {
                    Metodopa.Insertarpaciente( registro, cama, nombre, direccion, fecha, sexo);
                    MessageBox.Show("Se ha guardado con éxito el nuevo paciente");
                }
                else
                {
                    int cuipaciente = cui_paciente;
                    Metodopa.Editarpaciente(cuipaciente, registro, cama, nombre, direccion, fecha, sexo);
                    MessageBox.Show("Se editó correctamente");
                    Editar = false;
                }

                // Limpiar el formulario y cerrar el actual
                limpiarForm();
                Form consulta = new CONSULTA_PACIENTE();
                consulta.ShowDialog();
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar los datos por: " + ex.Message);
            }
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void limpiarForm()
        {
            txtregistro.Clear();
            txtcama.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txtfecha.Clear();
            txtsexo.Clear();

        }

        private void button1btnHabilitar_Click(object sender, EventArgs e)
        {
            HabilitarControles();
        }

        // Método para deshabilitar los controles de entrada
        private void DeshabilitarControles()
        {
            txtnombre.Enabled = false;
            txtregistro.Enabled = false;
            txtcama.Enabled = false;
            txtdireccion.Enabled = false;
            txtfecha.Enabled = false;
            txtsexo.Enabled = false;
            btnguardar.Enabled = false;
        }

        // Método para habilitar los controles de entrada
        private void HabilitarControles()
        {
            txtnombre.Enabled = true;
            txtregistro.Enabled = true;
            txtcama.Enabled = true;
            txtdireccion.Enabled = true;
            txtfecha.Enabled = true;
            txtsexo.Enabled = true;
            btnguardar.Enabled = true;
        }
    }
}
