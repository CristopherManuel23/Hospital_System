namespace Hospital_System
{
    partial class Nuevo_Diagnosticos
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
            cbcodigoPaciente = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            cbcodigoMedico = new ComboBox();
            btnHabilitar = new Button();
            cbcodigoLab = new ComboBox();
            label1 = new Label();
            txtTipoDiagnostico = new TextBox();
            btnCancelarMedico = new Button();
            btnGuardarMedico = new Button();
            txtComplicaciones = new TextBox();
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
            linkLabel1.Location = new Point(44, 29);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(627, 54);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ingrese un Nuevo Diagnostico";
            linkLabel1.VisitedLinkColor = Color.Purple;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(cbcodigoPaciente);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cbcodigoMedico);
            panel2.Controls.Add(btnHabilitar);
            panel2.Controls.Add(cbcodigoLab);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtTipoDiagnostico);
            panel2.Controls.Add(btnCancelarMedico);
            panel2.Controls.Add(btnGuardarMedico);
            panel2.Controls.Add(txtComplicaciones);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(54, 102);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1032, 470);
            panel2.TabIndex = 19;
            // 
            // cbcodigoPaciente
            // 
            cbcodigoPaciente.BackColor = Color.DimGray;
            cbcodigoPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcodigoPaciente.FlatStyle = FlatStyle.Popup;
            cbcodigoPaciente.ForeColor = SystemColors.Window;
            cbcodigoPaciente.FormattingEnabled = true;
            cbcodigoPaciente.Location = new Point(279, 389);
            cbcodigoPaciente.Name = "cbcodigoPaciente";
            cbcodigoPaciente.Size = new Size(402, 34);
            cbcodigoPaciente.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumAquamarine;
            label5.Location = new Point(48, 391);
            label5.Name = "label5";
            label5.Size = new Size(214, 32);
            label5.TabIndex = 17;
            label5.Text = "CUI_HOSPITAL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumAquamarine;
            label4.Location = new Point(47, 322);
            label4.Name = "label4";
            label4.Size = new Size(192, 32);
            label4.TabIndex = 16;
            label4.Text = "CUI_MEDICO";
            // 
            // cbcodigoMedico
            // 
            cbcodigoMedico.BackColor = Color.DimGray;
            cbcodigoMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcodigoMedico.FlatStyle = FlatStyle.Popup;
            cbcodigoMedico.ForeColor = SystemColors.Window;
            cbcodigoMedico.FormattingEnabled = true;
            cbcodigoMedico.Location = new Point(279, 320);
            cbcodigoMedico.Name = "cbcodigoMedico";
            cbcodigoMedico.Size = new Size(402, 34);
            cbcodigoMedico.TabIndex = 15;
            // 
            // btnHabilitar
            // 
            btnHabilitar.BackColor = Color.MediumAquamarine;
            btnHabilitar.ForeColor = Color.Black;
            btnHabilitar.Location = new Point(805, 253);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(173, 43);
            btnHabilitar.TabIndex = 14;
            btnHabilitar.Text = "HABILITAR";
            btnHabilitar.UseVisualStyleBackColor = false;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // cbcodigoLab
            // 
            cbcodigoLab.BackColor = Color.DimGray;
            cbcodigoLab.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcodigoLab.FlatStyle = FlatStyle.Popup;
            cbcodigoLab.ForeColor = SystemColors.Window;
            cbcodigoLab.FormattingEnabled = true;
            cbcodigoLab.Location = new Point(399, 251);
            cbcodigoLab.Name = "cbcodigoLab";
            cbcodigoLab.Size = new Size(282, 34);
            cbcodigoLab.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(48, 96);
            label1.Name = "label1";
            label1.Size = new Size(325, 32);
            label1.TabIndex = 5;
            label1.Text = "TIPO DE DIAGNOSTICO";
            // 
            // txtTipoDiagnostico
            // 
            txtTipoDiagnostico.BackColor = Color.DimGray;
            txtTipoDiagnostico.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTipoDiagnostico.ForeColor = Color.White;
            txtTipoDiagnostico.Location = new Point(399, 93);
            txtTipoDiagnostico.Name = "txtTipoDiagnostico";
            txtTipoDiagnostico.Size = new Size(282, 35);
            txtTipoDiagnostico.TabIndex = 0;
            // 
            // btnCancelarMedico
            // 
            btnCancelarMedico.BackColor = Color.Black;
            btnCancelarMedico.FlatAppearance.BorderColor = Color.Black;
            btnCancelarMedico.ForeColor = Color.MediumAquamarine;
            btnCancelarMedico.Location = new Point(805, 376);
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
            btnGuardarMedico.Location = new Point(805, 315);
            btnGuardarMedico.Name = "btnGuardarMedico";
            btnGuardarMedico.Size = new Size(173, 43);
            btnGuardarMedico.TabIndex = 9;
            btnGuardarMedico.Text = "GUARDAR";
            btnGuardarMedico.UseVisualStyleBackColor = false;
            btnGuardarMedico.Click += btnGuardarMedico_Click;
            // 
            // txtComplicaciones
            // 
            txtComplicaciones.BackColor = Color.DimGray;
            txtComplicaciones.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtComplicaciones.ForeColor = Color.White;
            txtComplicaciones.Location = new Point(337, 169);
            txtComplicaciones.Name = "txtComplicaciones";
            txtComplicaciones.Size = new Size(344, 35);
            txtComplicaciones.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(48, 253);
            label3.Name = "label3";
            label3.Size = new Size(335, 32);
            label3.TabIndex = 7;
            label3.Text = "CODIGO_LABORATORIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumAquamarine;
            label2.Location = new Point(47, 172);
            label2.Name = "label2";
            label2.Size = new Size(266, 32);
            label2.TabIndex = 6;
            label2.Text = "COMPLICACIONES";
            // 
            // Nuevo_Diagnosticos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1146, 616);
            Controls.Add(linkLabel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Nuevo_Diagnosticos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo_Diagnosticos";
            Load += Nuevo_Diagnosticos_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Panel panel2;
        private Button btnHabilitar;
        private ComboBox cbcodigoLab;
        private Label label1;
        private TextBox txtTipoDiagnostico;
        private Button btnCancelarMedico;
        private Button btnGuardarMedico;
        private TextBox txtComplicaciones;
        private Label label3;
        private Label label2;
        private ComboBox cbcodigoMedico;
        private ComboBox cbcodigoPaciente;
        private Label label5;
        private Label label4;
    }
}