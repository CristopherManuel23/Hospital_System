using System.Data.SqlClient;

namespace Hospital_System
{
    public partial class LOGIN : Form
    {
        Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {

            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }

        }

       private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DimGray;
            }

        } 

        private void txtcontrasenia_Enter(object sender, EventArgs e)
        {
            if (txtcontrasenia.Text == "CONTRASEÑA")
            {
                txtcontrasenia.Text = "";
                txtcontrasenia.ForeColor = Color.LightGray;
                txtcontrasenia.UseSystemPasswordChar = true;
            }

        }

        private void txtcontrasenia_Leave(object sender, EventArgs e)
        {
            if (txtcontrasenia.Text == "")
            {
                txtcontrasenia.Text = "CONTRASEÑA";
                txtcontrasenia.ForeColor = Color.DimGray;
                txtcontrasenia.UseSystemPasswordChar = false;
            }

        }

        private void btningrsar_Click(object sender, EventArgs e)
        {

            try
            {
                conexion.AbrirConexion();

                string query = "SELECT COUNT(*) FROM ACCESO WHERE usuario = @usuario AND contraseña = @contrasenia";
                using (SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);
                    cmd.Parameters.AddWithValue("@contrasenia", txtcontrasenia.Text);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Bienvenido al sistema");
                        MENU_PRINCIPAL MP = new MENU_PRINCIPAL();
                        MP.ShowDialog();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos");
                    }
                }
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LOGIN_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
