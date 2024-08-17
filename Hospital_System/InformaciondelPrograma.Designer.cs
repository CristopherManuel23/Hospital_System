namespace Hospital_System
{
    partial class InformaciondelPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformaciondelPrograma));
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(81, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 179);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = resources.GetString("groupBox1.Text");
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Black;
            linkLabel1.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.MediumAquamarine;
            linkLabel1.Location = new Point(417, 56);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(246, 46);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "PROGRAMA";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Black;
            linkLabel2.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.MediumAquamarine;
            linkLabel2.Location = new Point(81, 333);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(262, 46);
            linkLabel2.TabIndex = 18;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "CREADORES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(81, 405);
            label1.Name = "label1";
            label1.Size = new Size(451, 26);
            label1.TabIndex = 19;
            label1.Text = "RAILYNG DAVID PEGUERO (2023-0665)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(81, 497);
            label2.Name = "label2";
            label2.Size = new Size(549, 26);
            label2.TabIndex = 20;
            label2.Text = "VLADIMIR ALEXANDER MEDRANO (2023-1394)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(81, 451);
            label3.Name = "label3";
            label3.Size = new Size(478, 26);
            label3.TabIndex = 21;
            label3.Text = "CRISTOPHER MANUEL LUNA (2023-0667)";
            // 
            // InformaciondelPrograma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1019, 595);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InformaciondelPrograma";
            Text = "InformaciondelPrograma";
            Load += InformaciondelPrograma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private LinkLabel linkLabel2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}