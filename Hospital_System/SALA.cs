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
//655656
namespace Hospital_System
{
    public partial class SALA : Form
    {
        MetodoSala Metodosa = new MetodoSala();
        Conexion conexion = new Conexion();
        private bool Editar = false;
        int codigo_sala;
        public SALA()
        {
            InitializeComponent();
        }

        private void SALA_Load(object sender, EventArgs e)
        {
            Listahospital();
        }
        public SALA(int codigosala, string nombre, string cama, int ch)
        {
            InitializeComponent();

            // Asignar valores a los controles del formulario

            codigo_sala = codigosala;
            txtnombre.Text = nombre;
            txtcama.Text = cama;
            cmbch.SelectedValue = ch;
            Editar = true;
        }

        private void limpiarForm()
        {
            txtnombre.Clear();
            txtcama.Clear();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (txtnombre.Text == "" || txtcama.Text == ""  || cmbch.Text == "")
                {
                    MessageBox.Show("Complete todos los campos antes de guardar.", "Campos vacíos", MessageBoxButtons.OK);
                    return;
                }

                // Obtener valores de los campos
                string nombre = txtnombre.Text;
                string cama = txtcama.Text;
                int codigo_hospital = Convert.ToInt32(cmbch.SelectedValue);

                MetodoSala Metodosa = new MetodoSala();

                if (!Editar)
                {
                    // Código para insertar
                    Metodosa.Insertar(nombre, cama, codigo_hospital);
                    MessageBox.Show("Se ha guardado con éxito la nueva SALA");
                }
                else
                {
                    // Código para editar
                    int codigosala = codigo_sala;
                    Metodosa.Editar(codigosala, nombre, cama, codigo_hospital);
                    MessageBox.Show("Se editó correctamente");
                    Editar = false;
                }

                // Limpiar el formulario y cerrar el actual
                limpiarForm();
                Form consulta = new CONSULTA_SALA();
                consulta.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

        private void Listahospital()
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;


            conexion = this.conexion.AbrirConexion();
            cmd = new SqlCommand("SELECT codigo_hospital, Nombre_Hospital FROM HOSPITAL", conexion);
            reader = cmd.ExecuteReader();
            MetodoSala Metodosa = new MetodoSala();
            cmbch.DataSource = Metodosa.Listahospital();
            cmbch.DisplayMember = "Nombre_Hospital";
            cmbch.ValueMember = "Codigo_Hospital";

        }

        private void cmbch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
