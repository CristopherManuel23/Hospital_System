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

        private void limpiarForm()
        {
            txtregistro.Clear();
            txtcama.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txtfecha.Clear();
            txtsexo.Clear();

        }
      

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            if (txtregistro.Text == "" || txtcama.Text == "" || txtnombre.Text == "" || txtdireccion.Text == "" || txtfecha.Text == "" || txtsexo.Text == "")
            {
                MessageBox.Show("Complete todos los campos antes de guardar.", "Campos vacíos", MessageBoxButtons.OK);
                return;
            }

            if (Editar == false)
            {
                try
                {
                    // Código para guardar
                    conexion.AbrirConexion();
                    Metodopa.Insertarpaciente(txtregistro.Text, txtcama.Text, txtnombre.Text, txtdireccion.Text, txtfecha.Text, txtsexo.Text);
                    conexion.CerrarConexion();

                    MessageBox.Show("Se ha guardado con éxito el nuevo hospital");
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
                    // Código para editar
                    int cuipaciente = cui_paciente;
                    string registro = txtregistro.Text;
                    string cama = txtcama.Text;
                    string nombre = txtnombre.Text;
                    string direccion = txtdireccion.Text;
                    string fecha = txtfecha.Text;
                    string sexo = txtsexo.Text;


                    Metodopa.Editarpaciente(cuipaciente, registro, cama, nombre, direccion, fecha, sexo);
                    InitializeComponent();

                    MessageBox.Show("Se editó correctamente");
                    Metodopa.Mostrarpacientes();
                    limpiarForm();
                    Editar = false;
                    this.Dispose();
                    Form consulta = new CONSULTA_PACIENTE();
                    consulta.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex.Message);
                }
            }
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
