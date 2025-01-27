﻿using System;
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
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
            nuevo_hospital.ShowDialog();
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
            nuevo_hospital.ShowDialog();
        }

        private void pACIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONSULTA_PACIENTE consulta_paciente = new CONSULTA_PACIENTE();
            consulta_paciente.ShowDialog();
        }

        private void lABORATORIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaLaboratorio nuevo_Laboratorio = new ConsultaLaboratorio();
            nuevo_Laboratorio.ShowDialog();
        }

        private void dIAGNOSTICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONSULTA_MEDICO consulta_medico = new CONSULTA_MEDICO();
            consulta_medico.ShowDialog();
        }

        private void mEDICOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nUEVOPACIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PACIENTE nuevo_paciente = new PACIENTE();
            nuevo_paciente.ShowDialog();
        }

        private void nUEVOMEDICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laboratorio nuevo_Laboratorio = new Laboratorio();
            nuevo_Laboratorio.ShowDialog();
        }

        private void nUEVODIAGNOSTICOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Nuevo_Medic nuevo_medic = new Nuevo_Medic();
            nuevo_medic.ShowDialog();
        }

        private void nUEVOLABORATORIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nUEVOSALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SALA nueva_sala = new SALA();
            nueva_sala.ShowDialog();
        }

        private void sALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONSULTA_SALA consultasala = new CONSULTA_SALA();
            consultasala.ShowDialog();
        }

        private void MENU_PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nuevo_Diagnosticos nuevo = new Nuevo_Diagnosticos();
            nuevo.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cunsulta_Diagnostico nuevo = new Cunsulta_Diagnostico();
            nuevo.ShowDialog();
        }

        private void mEIMBROSDELGRUPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformaciondelPrograma info = new InformaciondelPrograma();
            info.ShowDialog();
        }
    }
}
