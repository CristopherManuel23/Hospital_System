﻿namespace Hospital_System
{
    partial class CONSULTA_PACIENTE
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
            dataGridViewpaciente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpaciente).BeginInit();
            SuspendLayout();
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Black;
            btneliminar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btneliminar.ForeColor = Color.MediumAquamarine;
            btneliminar.Location = new Point(267, 479);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(173, 52);
            btneliminar.TabIndex = 31;
            btneliminar.Text = "ELIMINAR";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click_1;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.Black;
            btneditar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btneditar.ForeColor = Color.MediumAquamarine;
            btneditar.Location = new Point(54, 479);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(173, 52);
            btneditar.TabIndex = 30;
            btneditar.Text = "EDITAR";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Black;
            linkLabel1.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.MediumAquamarine;
            linkLabel1.Location = new Point(54, 76);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(292, 46);
            linkLabel1.TabIndex = 29;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Datos Ingrsados";
            // 
            // dataGridViewpaciente
            // 
            dataGridViewpaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewpaciente.BackgroundColor = Color.PowderBlue;
            dataGridViewpaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewpaciente.Location = new Point(45, 135);
            dataGridViewpaciente.Name = "dataGridViewpaciente";
            dataGridViewpaciente.ReadOnly = true;
            dataGridViewpaciente.RowHeadersWidth = 62;
            dataGridViewpaciente.Size = new Size(1702, 315);
            dataGridViewpaciente.TabIndex = 28;
            // 
            // CONSULTA_PACIENTE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1788, 552);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridViewpaciente);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CONSULTA_PACIENTE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONSULTA_PACIENTE";
            Load += CONSULTA_PACIENTE_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewpaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btneliminar;
        private Button btneditar;
        private LinkLabel linkLabel1;
        private DataGridView dataGridViewpaciente;
    }
}