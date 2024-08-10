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
    public partial class MENU_PRINCIPAL : Form
    {

        public MENU_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void aTRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show();
            this.Hide();
        }

        private void nUEVOHOSPITALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Hosp nuevo_hospital = new Nuevo_Hosp();
            nuevo_hospital.Show();
        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MINIMIZAR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MAXIMIZAR_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            
                else this.WindowState = FormWindowState.Normal;
            
        }

        private void hOSPITALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONSULTA_HOSPITAL nuevo_hospital = new CONSULTA_HOSPITAL();
            nuevo_hospital.Show();
        }
    }
}
