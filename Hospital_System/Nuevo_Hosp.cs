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
        int codigoHospital;

        public Nuevo_Hosp()
        {
            InitializeComponent();
            DeshabilitarControles();
        }


        // Nuevo constructor que acepta parámetros
        public Nuevo_Hosp(int codigo_hospital, string nombre, string direccion, string telefono, string cantidadCamas)
        {
            InitializeComponent();

            // Asignar valores a los controles del formulario
            codigoHospital = codigo_hospital;
            txtnombre.Text = nombre;
            txtdireccion.Text = direccion;
            mtbTelefono.Text = telefono;
            mtbCama.Text = cantidadCamas;
            Editar = true;
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text == "" || txtdireccion.Text == "" || mtbTelefono.Text == "" || mtbCama.Text == "")
                {
                    MessageBox.Show("Complete todos los campos antes de guardar.", "Campos vacíos", MessageBoxButtons.OK);
                    return;
                }

                // Código para editar
                string nombre = txtnombre.Text;
                string direccion = txtdireccion.Text;
                string telefono = mtbTelefono.Text;
                string cantidadCamas = mtbCama.Text;

                Metodos Metodo = new Metodos();

                if (!Editar)
                {
                    // Código para insertar
                    Metodo.Insertar(nombre, direccion, telefono, cantidadCamas);
                    MessageBox.Show("Se ha guardado con éxito el nuevo Laboratorio");
                }
                else
                {
                    // Código para editar
                    int codigohospital = codigoHospital;
                    Metodo.Editar(codigohospital, nombre, direccion, telefono, cantidadCamas);
                    MessageBox.Show("Se editó correctamente");
                    Editar = false;
                }

                // Limpiar el formulario y cerrar el actual
                limpiarForm();
                Form consulta = new     CONSULTA_HOSPITAL();
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
            txtnombre.Clear();
            txtdireccion.Clear();
            mtbTelefono.Clear();
            mtbCama.Clear();
        }

        private void button1btnHabilitar_Click(object sender, EventArgs e)
        {
            HabilitarControles();
        }
        // Método para deshabilitar los controles de entrada
        private void DeshabilitarControles()
        {
            txtnombre.Enabled = false;
            txtdireccion.Enabled = false;
            mtbTelefono.Enabled = false;
            mtbCama.Enabled = false;
            btnguardar.Enabled = false;
        }

        // Método para habilitar los controles de entrada
        private void HabilitarControles()
        {
            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            mtbTelefono.Enabled = true;
            mtbCama.Enabled = true;
            btnguardar.Enabled = true;
        }
    }
}
