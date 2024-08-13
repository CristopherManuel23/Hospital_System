namespace Hospital_System
{
    partial class PACIENTE
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
            txtcama = new MaskedTextBox();
            txtregistro = new MaskedTextBox();
            txtsexo = new TextBox();
            label6 = new Label();
            txtdireccion = new TextBox();
            label5 = new Label();
            txtfecha = new MaskedTextBox();
            label1 = new Label();
            btncancelar = new Button();
            btnguardar = new Button();
            txtnombre = new TextBox();
            label4 = new Label();
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
            linkLabel1.Location = new Point(52, 33);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(369, 36);
            linkLabel1.TabIndex = 22;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ingrese un Nuevo Paciente";
            linkLabel1.VisitedLinkColor = Color.Purple;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(txtcama);
            panel2.Controls.Add(txtregistro);
            panel2.Controls.Add(txtsexo);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtdireccion);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtfecha);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btncancelar);
            panel2.Controls.Add(btnguardar);
            panel2.Controls.Add(txtnombre);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(52, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(697, 333);
            panel2.TabIndex = 21;
            // 
            // txtcama
            // 
            txtcama.BackColor = Color.DimGray;
            txtcama.ForeColor = Color.White;
            txtcama.Location = new Point(178, 75);
            txtcama.Margin = new Padding(2);
            txtcama.Mask = "0000";
            txtcama.Name = "txtcama";
            txtcama.Size = new Size(222, 26);
            txtcama.TabIndex = 2;
            // 
            // txtregistro
            // 
            txtregistro.BackColor = Color.DimGray;
            txtregistro.ForeColor = Color.White;
            txtregistro.Location = new Point(178, 31);
            txtregistro.Margin = new Padding(2);
            txtregistro.Mask = "0000";
            txtregistro.Name = "txtregistro";
            txtregistro.Size = new Size(222, 26);
            txtregistro.TabIndex = 1;
            // 
            // txtsexo
            // 
            txtsexo.BackColor = Color.DimGray;
            txtsexo.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtsexo.ForeColor = Color.White;
            txtsexo.Location = new Point(178, 270);
            txtsexo.Margin = new Padding(2);
            txtsexo.Name = "txtsexo";
            txtsexo.Size = new Size(222, 26);
            txtsexo.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.MediumAquamarine;
            label6.Location = new Point(57, 130);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 22);
            label6.TabIndex = 16;
            label6.Text = "NOMBRE ";
            // 
            // txtdireccion
            // 
            txtdireccion.BackColor = Color.DimGray;
            txtdireccion.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtdireccion.ForeColor = Color.White;
            txtdireccion.Location = new Point(178, 175);
            txtdireccion.Margin = new Padding(2);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(222, 26);
            txtdireccion.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumAquamarine;
            label5.Location = new Point(11, 35);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 22);
            label5.TabIndex = 14;
            label5.Text = "NO. REGISTRO";
            // 
            // txtfecha
            // 
            txtfecha.BackColor = Color.DimGray;
            txtfecha.ForeColor = Color.White;
            txtfecha.Location = new Point(249, 224);
            txtfecha.Margin = new Padding(2);
            txtfecha.Mask = "00/00/0000";
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(151, 26);
            txtfecha.TabIndex = 5;
            txtfecha.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(51, 79);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 5;
            label1.Text = "NO. CAMA";
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Black;
            btncancelar.FlatAppearance.BorderColor = Color.Black;
            btncancelar.ForeColor = Color.MediumAquamarine;
            btncancelar.Location = new Point(474, 192);
            btncancelar.Margin = new Padding(2);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(121, 25);
            btncancelar.TabIndex = 10;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click_1;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Black;
            btnguardar.ForeColor = Color.MediumAquamarine;
            btnguardar.Location = new Point(474, 144);
            btnguardar.Margin = new Padding(2);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(121, 26);
            btnguardar.TabIndex = 9;
            btnguardar.Text = "GUARDAR";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click_1;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.DimGray;
            txtnombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtnombre.ForeColor = Color.White;
            txtnombre.Location = new Point(178, 128);
            txtnombre.Margin = new Padding(2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(222, 26);
            txtnombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumAquamarine;
            label4.Location = new Point(93, 274);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 22);
            label4.TabIndex = 8;
            label4.Text = "SEXO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(11, 228);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(234, 22);
            label3.TabIndex = 7;
            label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumAquamarine;
            label2.Location = new Point(34, 179);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 6;
            label2.Text = "DIRECCION ";
            // 
            // PACIENTE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(panel2);
            Name = "PACIENTE";
            Text = "PACIENTE";
            Load += PACIENTE_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Panel panel2;
        private MaskedTextBox txtcama;
        private MaskedTextBox txtregistro;
        private TextBox txtsexo;
        private Label label6;
        private TextBox txtdireccion;
        private Label label5;
        private MaskedTextBox txtfecha;
        private Label label1;
        private Button btncancelar;
        private Button btnguardar;
        private TextBox txtnombre;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}