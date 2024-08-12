namespace Hospital_System
{
    partial class CONSULTA_MEDICO
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
            btnEliminarMedico = new Button();
            btnEditarMedico = new Button();
            TABLAMEDICO = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TABLAMEDICO).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Black;
            linkLabel1.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.MediumAquamarine;
            linkLabel1.Location = new Point(70, 45);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(310, 46);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Datos Ingresados";
            // 
            // btnEliminarMedico
            // 
            btnEliminarMedico.BackColor = Color.Black;
            btnEliminarMedico.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarMedico.ForeColor = Color.MediumAquamarine;
            btnEliminarMedico.Location = new Point(287, 464);
            btnEliminarMedico.Name = "btnEliminarMedico";
            btnEliminarMedico.Size = new Size(173, 65);
            btnEliminarMedico.TabIndex = 18;
            btnEliminarMedico.Text = "ELIMINAR";
            btnEliminarMedico.UseVisualStyleBackColor = false;
            btnEliminarMedico.Click += btnEliminarMedico_Click;
            // 
            // btnEditarMedico
            // 
            btnEditarMedico.BackColor = Color.Black;
            btnEditarMedico.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarMedico.ForeColor = Color.MediumAquamarine;
            btnEditarMedico.Location = new Point(70, 464);
            btnEditarMedico.Name = "btnEditarMedico";
            btnEditarMedico.Size = new Size(173, 65);
            btnEditarMedico.TabIndex = 17;
            btnEditarMedico.Text = "EDITAR";
            btnEditarMedico.UseVisualStyleBackColor = false;
            btnEditarMedico.Click += btnEditarMedico_Click;
            // 
            // TABLAMEDICO
            // 
            TABLAMEDICO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TABLAMEDICO.BackgroundColor = Color.PowderBlue;
            TABLAMEDICO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TABLAMEDICO.Location = new Point(70, 110);
            TABLAMEDICO.Name = "TABLAMEDICO";
            TABLAMEDICO.ReadOnly = true;
            TABLAMEDICO.RowHeadersWidth = 62;
            TABLAMEDICO.Size = new Size(1223, 315);
            TABLAMEDICO.TabIndex = 16;
            // 
            // CONSULTA_MEDICO
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1363, 574);
            Controls.Add(linkLabel1);
            Controls.Add(btnEliminarMedico);
            Controls.Add(btnEditarMedico);
            Controls.Add(TABLAMEDICO);
            Name = "CONSULTA_MEDICO";
            Text = "CONSULTA_MEDICO";
            Load += CONSULTA_MEDICO_Load;
            ((System.ComponentModel.ISupportInitialize)TABLAMEDICO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button btnEliminarMedico;
        private Button btnEditarMedico;
        private DataGridView TABLAMEDICO;
    }
}