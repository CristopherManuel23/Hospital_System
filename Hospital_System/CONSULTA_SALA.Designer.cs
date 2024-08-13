namespace Hospital_System
{
    partial class CONSULTA_SALA
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
            btneliminar = new Button();
            btneditar = new Button();
            linkLabel1 = new LinkLabel();
            dataGridViewsala = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsala).BeginInit();
            SuspendLayout();
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Black;
            btneliminar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btneliminar.ForeColor = Color.MediumAquamarine;
            btneliminar.Location = new Point(199, 306);
            btneliminar.Margin = new Padding(2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(121, 39);
            btneliminar.TabIndex = 35;
            btneliminar.Text = "ELIMINAR";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.Black;
            btneditar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btneditar.ForeColor = Color.MediumAquamarine;
            btneditar.Location = new Point(36, 306);
            btneditar.Margin = new Padding(2);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(121, 39);
            btneditar.TabIndex = 34;
            btneditar.Text = "EDITAR";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Black;
            linkLabel1.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.MediumAquamarine;
            linkLabel1.Location = new Point(36, 34);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(214, 31);
            linkLabel1.TabIndex = 33;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Datos Ingresados";
            // 
            // dataGridViewsala
            // 
            dataGridViewsala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewsala.BackgroundColor = Color.PowderBlue;
            dataGridViewsala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewsala.Location = new Point(36, 90);
            dataGridViewsala.Margin = new Padding(2);
            dataGridViewsala.Name = "dataGridViewsala";
            dataGridViewsala.ReadOnly = true;
            dataGridViewsala.RowHeadersWidth = 62;
            dataGridViewsala.Size = new Size(856, 189);
            dataGridViewsala.TabIndex = 32;
            dataGridViewsala.CellContentClick += dataGridViewsala_CellContentClick;
            // 
            // CONSULTA_SALA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(932, 450);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridViewsala);
            Name = "CONSULTA_SALA";
            Text = "CONSULTA_SALA";
            Load += CONSULTA_SALA_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewsala).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btneliminar;
        private Button btneditar;
        private LinkLabel linkLabel1;
        private DataGridView dataGridViewsala;
    }
}