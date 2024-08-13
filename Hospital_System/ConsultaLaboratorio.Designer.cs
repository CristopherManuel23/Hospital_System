namespace Hospital_System
{
    partial class ConsultaLaboratorio
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
            btnEditar = new Button();
            btnEliminar = new Button();
            dataGridViewLaboratorio = new DataGridView();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLaboratorio).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.MediumAquamarine;
            btnEditar.Location = new Point(28, 226);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(138, 30);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.MediumAquamarine;
            btnEliminar.Location = new Point(176, 226);
            btnEliminar.Margin = new Padding(2, 2, 2, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 30);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridViewLaboratorio
            // 
            dataGridViewLaboratorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLaboratorio.BackgroundColor = Color.PowderBlue;
            dataGridViewLaboratorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLaboratorio.Location = new Point(28, 52);
            dataGridViewLaboratorio.Margin = new Padding(2, 2, 2, 2);
            dataGridViewLaboratorio.Name = "dataGridViewLaboratorio";
            dataGridViewLaboratorio.RowHeadersWidth = 62;
            dataGridViewLaboratorio.RowTemplate.Height = 33;
            dataGridViewLaboratorio.Size = new Size(882, 154);
            dataGridViewLaboratorio.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.MediumAquamarine;
            linkLabel1.Location = new Point(28, 13);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(232, 34);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Datos Ingresados";
            // 
            // ConsultaLaboratorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(937, 270);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridViewLaboratorio);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ConsultaLaboratorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaLaboratorio";
            Load += ConsultaLaboratorio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLaboratorio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dataGridViewLaboratorio;
        private LinkLabel linkLabel1;
    }
}