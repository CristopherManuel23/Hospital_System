namespace Hospital_System
{
    partial class Laboratorio
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
            panel1 = new Panel();
            btnHabilitar = new Button();
            mtbTelefono = new MaskedTextBox();
            btncancelar = new Button();
            button1 = new Button();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnHabilitar);
            panel1.Controls.Add(mtbTelefono);
            panel1.Controls.Add(btncancelar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(46, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 382);
            panel1.TabIndex = 0;
            // 
            // btnHabilitar
            // 
            btnHabilitar.BackColor = Color.MediumAquamarine;
            btnHabilitar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHabilitar.ForeColor = Color.Black;
            btnHabilitar.Location = new Point(627, 148);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(173, 43);
            btnHabilitar.TabIndex = 15;
            btnHabilitar.Text = "HABILITAR";
            btnHabilitar.UseVisualStyleBackColor = false;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // mtbTelefono
            // 
            mtbTelefono.BackColor = Color.DimGray;
            mtbTelefono.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            mtbTelefono.ForeColor = Color.White;
            mtbTelefono.Location = new Point(243, 209);
            mtbTelefono.Mask = "000-000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(154, 35);
            mtbTelefono.TabIndex = 3;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Black;
            btncancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btncancelar.ForeColor = Color.MediumAquamarine;
            btncancelar.Location = new Point(627, 279);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(173, 51);
            btncancelar.TabIndex = 9;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MediumAquamarine;
            button1.Location = new Point(627, 212);
            button1.Name = "button1";
            button1.Size = new Size(173, 50);
            button1.TabIndex = 0;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.DimGray;
            txtDireccion.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.White;
            txtDireccion.Location = new Point(243, 134);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(278, 35);
            txtDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.DimGray;
            txtNombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(243, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(278, 35);
            txtNombre.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DimGray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(243, 294);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 36);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumAquamarine;
            label4.Location = new Point(44, 300);
            label4.Name = "label4";
            label4.Size = new Size(150, 32);
            label4.TabIndex = 3;
            label4.Text = "HOSPITAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(44, 212);
            label3.Name = "label3";
            label3.Size = new Size(164, 32);
            label3.TabIndex = 2;
            label3.Text = "TELEFONO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumAquamarine;
            label2.Location = new Point(44, 137);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 1;
            label2.Text = "DIRECCION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(44, 60);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.MediumAquamarine;
            linkLabel1.Location = new Point(46, 33);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(406, 51);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ingresar Laboratorio";
            // 
            // Laboratorio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(981, 536);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Laboratorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += Laboratorio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button btncancelar;
        private Button button1;
        private MaskedTextBox mtbTelefono;
        private Button btnHabilitar;
    }
}