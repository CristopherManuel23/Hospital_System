namespace Hospital_System
{
    partial class Nuevo_Medic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            cbcodigoHospital = new ComboBox();
            label1 = new Label();
            txtNombreMedico = new TextBox();
            btnCancelarMedico = new Button();
            btnGuardarMedico = new Button();
            txtEspecialidadMedico = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.MediumAquamarine;
            linkLabel1.Location = new Point(28, 28);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(536, 54);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ingrese un Nuevo Medico";
            linkLabel1.VisitedLinkColor = Color.Purple;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(cbcodigoHospital);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtNombreMedico);
            panel2.Controls.Add(btnCancelarMedico);
            panel2.Controls.Add(btnGuardarMedico);
            panel2.Controls.Add(txtEspecialidadMedico);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(28, 96);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(898, 358);
            panel2.TabIndex = 17;
            // 
            // cbcodigoHospital
            // 
            cbcodigoHospital.BackColor = Color.DimGray;
            cbcodigoHospital.FormattingEnabled = true;
            cbcodigoHospital.Location = new Point(327, 249);
            cbcodigoHospital.Name = "cbcodigoHospital";
            cbcodigoHospital.Size = new Size(229, 34);
            cbcodigoHospital.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(48, 96);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 5;
            label1.Text = "NOMBRE";
            // 
            // txtNombreMedico
            // 
            txtNombreMedico.BackColor = Color.DimGray;
            txtNombreMedico.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtNombreMedico.ForeColor = Color.White;
            txtNombreMedico.Location = new Point(242, 93);
            txtNombreMedico.Name = "txtNombreMedico";
            txtNombreMedico.Size = new Size(315, 35);
            txtNombreMedico.TabIndex = 0;
            // 
            // btnCancelarMedico
            // 
            btnCancelarMedico.BackColor = Color.Black;
            btnCancelarMedico.FlatAppearance.BorderColor = Color.Black;
            btnCancelarMedico.ForeColor = Color.MediumAquamarine;
            btnCancelarMedico.Location = new Point(632, 205);
            btnCancelarMedico.Name = "btnCancelarMedico";
            btnCancelarMedico.Size = new Size(173, 42);
            btnCancelarMedico.TabIndex = 10;
            btnCancelarMedico.Text = "CANCELAR";
            btnCancelarMedico.UseVisualStyleBackColor = false;
            btnCancelarMedico.Click += btnCancelarMedico_Click;
            // 
            // btnGuardarMedico
            // 
            btnGuardarMedico.BackColor = Color.Black;
            btnGuardarMedico.ForeColor = Color.MediumAquamarine;
            btnGuardarMedico.Location = new Point(632, 125);
            btnGuardarMedico.Name = "btnGuardarMedico";
            btnGuardarMedico.Size = new Size(173, 43);
            btnGuardarMedico.TabIndex = 9;
            btnGuardarMedico.Text = "GUARDAR";
            btnGuardarMedico.UseVisualStyleBackColor = false;
            btnGuardarMedico.Click += btnGuardarMedico_Click;
            // 
            // txtEspecialidadMedico
            // 
            txtEspecialidadMedico.BackColor = Color.DimGray;
            txtEspecialidadMedico.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtEspecialidadMedico.ForeColor = Color.White;
            txtEspecialidadMedico.Location = new Point(274, 169);
            txtEspecialidadMedico.Name = "txtEspecialidadMedico";
            txtEspecialidadMedico.Size = new Size(282, 35);
            txtEspecialidadMedico.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(47, 247);
            label3.Name = "label3";
            label3.Size = new Size(274, 32);
            label3.TabIndex = 7;
            label3.Text = "CODIGO_HOSPITAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumAquamarine;
            label2.Location = new Point(47, 172);
            label2.Name = "label2";
            label2.Size = new Size(221, 32);
            label2.TabIndex = 6;
            label2.Text = "ESPECIALIDAD";
            // 
            // Nuevo_Medic
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(975, 507);
            Controls.Add(linkLabel1);
            Controls.Add(panel2);
            Name = "Nuevo_Medic";
            Text = "Nuevo_Medic";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtNombreMedico;
        private Button btnCancelarMedico;
        private Button btnGuardarMedico;
        private TextBox txtEspecialidadMedico;
        private Label label3;
        private Label label2;
        private ComboBox cbcodigoHospital;
    }
}