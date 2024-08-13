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
            linkLabel1.Location = new Point(52, 33);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(331, 36);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ingrese una Nueva Sala";
            linkLabel1.VisitedLinkColor = Color.Purple;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(cmbch);
            panel2.Controls.Add(txtcama);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btncancelar);
            panel2.Controls.Add(btnguardar);
            panel2.Controls.Add(txtnombre);
            panel2.Controls.Add(label4);
            panel2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(52, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(697, 333);
            panel2.TabIndex = 23;
            // 
            // cmbch
            // 
            cmbch.BackColor = SystemColors.ControlDarkDark;
            cmbch.ForeColor = SystemColors.Info;
            cmbch.FormattingEnabled = true;
            cmbch.Location = new Point(230, 144);
            cmbch.Name = "cmbch";
            cmbch.Size = new Size(222, 27);
            cmbch.TabIndex = 17;
            cmbch.SelectedIndexChanged += cmbch_SelectedIndexChanged;
            // 
            // txtcama
            // 
            txtcama.BackColor = Color.DimGray;
            txtcama.ForeColor = Color.White;
            txtcama.Location = new Point(230, 96);
            txtcama.Margin = new Padding(2);
            txtcama.Mask = "0000";
            txtcama.Name = "txtcama";
            txtcama.Size = new Size(222, 26);
            txtcama.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.MediumAquamarine;
            label6.Location = new Point(128, 47);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 22);
            label6.TabIndex = 16;
            label6.Text = "NOMBRE ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(16, 100);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 22);
            label1.TabIndex = 5;
            label1.Text = "CANTIDAD DE CAMAS";
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Black;
            btncancelar.FlatAppearance.BorderColor = Color.Black;
            btncancelar.ForeColor = Color.MediumAquamarine;
            btncancelar.Location = new Point(535, 100);
            btncancelar.Margin = new Padding(2);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(121, 25);
            btncancelar.TabIndex = 10;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Black;
            btnguardar.ForeColor = Color.MediumAquamarine;
            btnguardar.Location = new Point(535, 63);
            btnguardar.Margin = new Padding(2);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(121, 26);
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
            txtnombre.Location = new Point(230, 45);
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
            label4.Location = new Point(120, 144);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 22);
            label4.TabIndex = 8;
            label4.Text = "HOSPITAL";
            // 
            // SALA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(panel2);
            Name = "SALA";
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
    }
}