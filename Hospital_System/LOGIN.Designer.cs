namespace Hospital_System
{
    partial class LOGIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtusuario = new TextBox();
            txtcontrasenia = new TextBox();
            btningrsar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            btncancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            SuspendLayout();
            // 
            // txtusuario
            // 
            txtusuario.BackColor = Color.Black;
            txtusuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtusuario.ForeColor = Color.DarkGray;
            txtusuario.Location = new Point(79, 561);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(430, 35);
            txtusuario.TabIndex = 1;
            txtusuario.Text = "USUARIO";
            txtusuario.Enter += txtusuario_Enter;
            txtusuario.Leave += txtusuario_Leave;
            // 
            // txtcontrasenia
            // 
            txtcontrasenia.BackColor = Color.Black;
            txtcontrasenia.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtcontrasenia.ForeColor = Color.DarkGray;
            txtcontrasenia.Location = new Point(79, 647);
            txtcontrasenia.Name = "txtcontrasenia";
            txtcontrasenia.Size = new Size(430, 35);
            txtcontrasenia.TabIndex = 2;
            txtcontrasenia.Text = "CONTRASEÑA";
            txtcontrasenia.Enter += txtcontrasenia_Enter;
            txtcontrasenia.Leave += txtcontrasenia_Leave;
            // 
            // btningrsar
            // 
            btningrsar.BackColor = Color.Black;
            btningrsar.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btningrsar.FlatAppearance.BorderSize = 0;
            btningrsar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btningrsar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btningrsar.FlatStyle = FlatStyle.Popup;
            btningrsar.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btningrsar.ForeColor = Color.MediumAquamarine;
            btningrsar.Location = new Point(79, 749);
            btningrsar.Name = "btningrsar";
            btningrsar.Size = new Size(182, 44);
            btningrsar.TabIndex = 0;
            btningrsar.Text = "INGRESAR";
            btningrsar.UseVisualStyleBackColor = false;
            btningrsar.Click += btningrsar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(79, 83);
            label1.Name = "label1";
            label1.Size = new Size(442, 46);
            label1.TabIndex = 7;
            label1.Text = "CONTROL DE ACCESO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo4_0;
            pictureBox1.Location = new Point(79, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 357);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btncerrar
            // 
            btncerrar.Image = Properties.Resources.x;
            btncerrar.Location = new Point(542, 15);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(31, 31);
            btncerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            btncerrar.TabIndex = 11;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Image = Properties.Resources._11;
            btnminimizar.Location = new Point(496, 19);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(39, 27);
            btnminimizar.TabIndex = 10;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // btncancelar
            // 
            btncancelar.FlatStyle = FlatStyle.Popup;
            btncancelar.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btncancelar.ForeColor = Color.MediumAquamarine;
            btncancelar.Location = new Point(312, 749);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(182, 44);
            btncancelar.TabIndex = 5;
            btncancelar.Text = "CANCELAR";
            btncancelar.Click += btncancelar_Click;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(583, 919);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btncancelar);
            Controls.Add(btningrsar);
            Controls.Add(txtcontrasenia);
            Controls.Add(txtusuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LOGIN";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtusuario;
        private TextBox txtcontrasenia;
        private Button btningrsar;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
        private Button btncancelar;
    }
}
