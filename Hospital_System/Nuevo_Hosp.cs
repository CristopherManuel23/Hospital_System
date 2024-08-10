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
    public partial class Nuevo_Hosp : Form
    {
        Metodos Metodo = new Metodos();
        Conexion conexion = new Conexion();
        private bool Editar = false;
        int codigoHospital ;

        public Nuevo_Hosp()
        {
            InitializeComponent();
        }


        // Nuevo constructor que acepta parámetros
        public Nuevo_Hosp(int codigo_hospital, string nombre, string direccion, string telefono, string cantidadCamas)
        {
            InitializeComponent();

            // Asignar valores a los controles del formulario
            //this.codigo_hospital = codigo_hospital; // Almacena el código del hospital en la variable
            codigoHospital = codigo_hospital;
            txtnombre.Text = nombre;
            txtdireccion.Text = direccion;
            mtbTelefono.Text = telefono;
            mtbCama.Text = cantidadCamas;
            Editar = true;
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (txtnombre.Text == "" || txtdireccion.Text == "" || mtbTelefono.Text == "" || mtbCama.Text == "")
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
                    Metodo.InsertarHospital_boton(txtnombre.Text, txtdireccion.Text, mtbTelefono.Text, mtbCama.Text);
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
                    int codigo_hospital = codigoHospital;
                    string nombre = txtnombre.Text;
                    string direccion = txtdireccion.Text;
                    string telefono = mtbTelefono.Text;
                    string cantidadCamas = mtbCama.Text;
                   

                    Metodo.EditarHospital(nombre, direccion, telefono, cantidadCamas, codigo_hospital);
                    InitializeComponent();

                    MessageBox.Show("Se editó correctamente");
                    Metodo.MostrarHospitales();
                    limpiarForm();
                    Editar = false;
                    this.Dispose();
                    Form consulta = new CONSULTA_HOSPITAL();
                    consulta.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex.Message);
                }
            }


        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
         this.Dispose();  
        }

        private void limpiarForm()
        {
            txtnombre.Clear();
            txtdireccion.Clear();
            mtbTelefono.Clear();
            mtbCama.Clear();
        }
    }
}
