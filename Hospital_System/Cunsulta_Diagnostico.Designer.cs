namespace Hospital_System
{
    partial class Cunsulta_Diagnostico
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
            btnEliminarDiag = new Button();
            btnEditarDiag = new Button();
            TABLADIAGNOSTICO = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TABLADIAGNOSTICO).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Black;
            linkLabel1.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.MediumAquamarine;
            linkLabel1.Location = new Point(52, 20);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(310, 46);
            linkLabel1.TabIndex = 23;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Datos Ingresados";
            // 
            // btnEliminarDiag
            // 
            btnEliminarDiag.BackColor = Color.Black;
            btnEliminarDiag.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarDiag.ForeColor = Color.MediumAquamarine;
            btnEliminarDiag.Location = new Point(269, 439);
            btnEliminarDiag.Name = "btnEliminarDiag";
            btnEliminarDiag.Size = new Size(173, 45);
            btnEliminarDiag.TabIndex = 22;
            btnEliminarDiag.Text = "ELIMINAR";
            btnEliminarDiag.UseVisualStyleBackColor = false;
            btnEliminarDiag.Click += btnEliminarDiag_Click;
            // 
            // btnEditarDiag
            // 
            btnEditarDiag.BackColor = Color.Black;
            btnEditarDiag.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarDiag.ForeColor = Color.MediumAquamarine;
            btnEditarDiag.Location = new Point(52, 439);
            btnEditarDiag.Name = "btnEditarDiag";
            btnEditarDiag.Size = new Size(173, 45);
            btnEditarDiag.TabIndex = 21;
            btnEditarDiag.Text = "EDITAR";
            btnEditarDiag.UseVisualStyleBackColor = false;
            btnEditarDiag.Click += btnEditarDiag_Click;
            // 
            // TABLADIAGNOSTICO
            // 
            TABLADIAGNOSTICO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TABLADIAGNOSTICO.BackgroundColor = Color.PowderBlue;
            TABLADIAGNOSTICO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TABLADIAGNOSTICO.Location = new Point(52, 85);
            TABLADIAGNOSTICO.Name = "TABLADIAGNOSTICO";
            TABLADIAGNOSTICO.ReadOnly = true;
            TABLADIAGNOSTICO.RowHeadersWidth = 62;
            TABLADIAGNOSTICO.Size = new Size(1223, 315);
            TABLADIAGNOSTICO.TabIndex = 20;
            // 
            // Cunsulta_Diagnostico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1326, 495);
            Controls.Add(linkLabel1);
            Controls.Add(btnEliminarDiag);
            Controls.Add(btnEditarDiag);
            Controls.Add(TABLADIAGNOSTICO);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cunsulta_Diagnostico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cunsulta_Diagnostico";
            Load += Cunsulta_Diagnostico_Load;
            ((System.ComponentModel.ISupportInitialize)TABLADIAGNOSTICO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button btnEliminarDiag;
        private Button btnEditarDiag;
        private DataGridView TABLADIAGNOSTICO;
    }
}