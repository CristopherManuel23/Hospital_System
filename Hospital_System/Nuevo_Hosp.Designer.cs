namespace Hospital_System
{
    partial class Nuevo_Hosp
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
            panel2 = new Panel();
            mtbCama = new MaskedTextBox();
            mtbTelefono = new MaskedTextBox();
            label1 = new Label();
            txtnombre = new TextBox();
            btncancelar = new Button();
            btnguardar = new Button();
            txtdireccion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(mtbCama);
            panel2.Controls.Add(mtbTelefono);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtnombre);
            panel2.Controls.Add(btncancelar);
            panel2.Controls.Add(btnguardar);
            panel2.Controls.Add(txtdireccion);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(51, 133);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 410);
            panel2.TabIndex = 14;
            // 
            // mtbCama
            // 
            mtbCama.BackColor = Color.DimGray;
            mtbCama.ForeColor = Color.White;
            mtbCama.Location = new Point(241, 320);
            mtbCama.Mask = "00000";
            mtbCama.Name = "mtbCama";
            mtbCama.Size = new Size(72, 35);
            mtbCama.TabIndex = 12;
            // 
            // mtbTelefono
            // 
            mtbTelefono.BackColor = Color.DimGray;
            mtbTelefono.ForeColor = Color.White;
            mtbTelefono.Location = new Point(241, 240);
            mtbTelefono.Mask = "000-000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(153, 35);
            mtbTelefono.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(47, 85);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 5;
            label1.Text = "NOMBRE";
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.DimGray;
            txtnombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtnombre.ForeColor = Color.White;
            txtnombre.Location = new Point(241, 77);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(315, 35);
            txtnombre.TabIndex = 0;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Black;
            btncancelar.FlatAppearance.BorderColor = Color.Black;
            btncancelar.ForeColor = Color.MediumAquamarine;
            btncancelar.Location = new Point(677, 320);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(173, 42);
            btncancelar.TabIndex = 10;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Black;
            btnguardar.ForeColor = Color.MediumAquamarine;
            btnguardar.Location = new Point(677, 240);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(173, 43);
            btnguardar.TabIndex = 9;
            btnguardar.Text = "GUARDAR";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtdireccion
            // 
            txtdireccion.BackColor = Color.DimGray;
            txtdireccion.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtdireccion.ForeColor = Color.White;
            txtdireccion.Location = new Point(241, 163);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(315, 35);
            txtdireccion.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumAquamarine;
            label4.Location = new Point(47, 323);
            label4.Name = "label4";
            label4.Size = new Size(157, 32);
            label4.TabIndex = 8;
            label4.Text = "N O. CAMA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(47, 247);
            label3.Name = "label3";
            label3.Size = new Size(164, 32);
            label3.TabIndex = 7;
            label3.Text = "TELEFONO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumAquamarine;
            label2.Location = new Point(47, 172);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 6;
            label2.Text = "DIRECCION ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.MediumAquamarine;
            linkLabel1.Location = new Point(51, 65);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(557, 54);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ingrese un Nuevo Hospital";
            linkLabel1.VisitedLinkColor = Color.Purple;
            // 
            // Nuevo_Hosp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1099, 604);
            Controls.Add(linkLabel1);
            Controls.Add(panel2);
            Name = "Nuevo_Hosp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo_Hosp";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private TextBox txtnombre;
        private Button btncancelar;
        private Button btnguardar;
        private TextBox txtdireccion;
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel1;
        private MaskedTextBox mtbCama;
        private MaskedTextBox mtbTelefono;
    }
}