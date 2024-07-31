namespace Hospital_System
{
    public partial class Form1 : Form
    {
        public Form1()
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
            if (txtusuario.Text == "rzorrilla" && txtcontrasenia.Text == "12345" || txtusuario.Text == "Creadores" && txtcontrasenia.Text == "656794")
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
