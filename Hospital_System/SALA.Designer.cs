namespace Hospital_System
{
    partial class SALA
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
            btnHabilitar = new Button();
            cmbch = new ComboBox();
            txtcama = new MaskedTextBox();
            label6 = new Label();
            label1 = new Label();
            btncancelar = new Button();
            btnguardar = new Button();
            txtnombre = new TextBox();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.MediumAquamarine;
            linkLabel1.Location = new Point(74, 55);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(502, 54);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ingrese una Nueva Sala";
            linkLabel1.VisitedLinkColor = Color.Purple;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(btnHabilitar);
            panel2.Controls.Add(cmbch);
            panel2.Controls.Add(txtcama);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btncancelar);
            panel2.Controls.Add(btnguardar);
            panel2.Controls.Add(txtnombre);
            panel2.Controls.Add(label4);
            panel2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(74, 142);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(915, 361);
            panel2.TabIndex = 23;
            // 
            // btnHabilitar
            // 
            btnHabilitar.BackColor = Color.MediumAquamarine;
            btnHabilitar.ForeColor = Color.Black;
            btnHabilitar.Location = new Point(672, 113);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(173, 43);
            btnHabilitar.TabIndex = 18;
            btnHabilitar.Text = "HABILITAR";
            btnHabilitar.UseVisualStyleBackColor = false;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // cmbch
            // 
            cmbch.BackColor = SystemColors.ControlDarkDark;
            cmbch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbch.FlatStyle = FlatStyle.Popup;
            cmbch.ForeColor = Color.White;
            cmbch.FormattingEnabled = true;
            cmbch.Location = new Point(221, 244);
            cmbch.Margin = new Padding(4, 5, 4, 5);
            cmbch.Name = "cmbch";
            cmbch.Size = new Size(315, 34);
            cmbch.TabIndex = 17;
            cmbch.SelectedIndexChanged += cmbch_SelectedIndexChanged;
            // 
            // txtcama
            // 
            txtcama.BackColor = Color.DimGray;
            txtcama.ForeColor = Color.White;
            txtcama.Location = new Point(363, 168);
            txtcama.Mask = "0000";
            txtcama.Name = "txtcama";
            txtcama.Size = new Size(173, 35);
            txtcama.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.MediumAquamarine;
            label6.Location = new Point(37, 82);
            label6.Name = "label6";
            label6.Size = new Size(143, 32);
            label6.TabIndex = 16;
            label6.Text = "NOMBRE ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(37, 171);
            label1.Name = "label1";
            label1.Size = new Size(310, 32);
            label1.TabIndex = 5;
            label1.Text = "CANTIDAD DE CAMAS";
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Black;
            btncancelar.FlatAppearance.BorderColor = Color.Black;
            btncancelar.ForeColor = Color.MediumAquamarine;
            btncancelar.Location = new Point(672, 237);
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
            btnguardar.Location = new Point(672, 175);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(173, 43);
            btnguardar.TabIndex = 9;
            btnguardar.Text = "GUARDAR";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.DimGray;
            txtnombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtnombre.ForeColor = Color.White;
            txtnombre.Location = new Point(221, 79);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(315, 35);
            txtnombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumAquamarine;
            label4.Location = new Point(37, 246);
            label4.Name = "label4";
            label4.Size = new Size(150, 32);
            label4.TabIndex = 8;
            label4.Text = "HOSPITAL";
            // 
            // SALA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1068, 563);
            Controls.Add(linkLabel1);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SALA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SALA";
            Load += SALA_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Panel panel2;
        private MaskedTextBox txtcama;
        private Label label6;
        private Label label1;
        private Button btncancelar;
        private Button btnguardar;
        private TextBox txtnombre;
        private Label label4;
        private ComboBox cmbch;
        private Button btnHabilitar;
    }
}