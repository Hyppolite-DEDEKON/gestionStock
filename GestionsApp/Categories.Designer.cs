namespace GestionsApp
{
    partial class Categories
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            label2 = new Label();
            label7 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            CategorieTb = new TextBox();
            label1 = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            label = new PictureBox();
            BtnRetour = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)label).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 48);
            panel1.TabIndex = 35;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(546, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(24, 23);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 41;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(576, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 41;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Thin SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(118, 9);
            label2.Name = "label2";
            label2.Size = new Size(386, 33);
            label2.TabIndex = 0;
            label2.Text = "Systeme de Gestion de Stocks";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("Montserrat Thin SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(170, 78);
            label7.Name = "label7";
            label7.Size = new Size(285, 33);
            label7.TabIndex = 34;
            label7.Text = "Ajouter une categorie";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = this;
            // 
            // CategorieTb
            // 
            CategorieTb.Location = new Point(184, 169);
            CategorieTb.Name = "CategorieTb";
            CategorieTb.Size = new Size(271, 31);
            CategorieTb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 141);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 36;
            label1.Text = "Nom de la categorie";
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 5;
            btnAdd.CustomizableEdges = customizableEdges1;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(260, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(121, 46);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Ajouter";
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 335);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 41);
            panel2.TabIndex = 38;
            // 
            // label
            // 
            label.Image = (Image)resources.GetObject("label.Image");
            label.Location = new Point(12, 54);
            label.Name = "label";
            label.Size = new Size(21, 22);
            label.SizeMode = PictureBoxSizeMode.StretchImage;
            label.TabIndex = 39;
            label.TabStop = false;
            // 
            // BtnRetour
            // 
            BtnRetour.AutoSize = true;
            BtnRetour.Location = new Point(33, 52);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(64, 25);
            BtnRetour.TabIndex = 40;
            BtnRetour.Text = "Retour";
            BtnRetour.TextAlign = ContentAlignment.TopCenter;
            BtnRetour.Click += BtnRetour_Click_1;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(612, 376);
            Controls.Add(BtnRetour);
            Controls.Add(label);
            Controls.Add(panel2);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(CategorieTb);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)label).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnMod;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label BtnRetour;
        private Panel panel1;
        private Label label2;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label8Btn;
        private Label label9Btn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label11Btn;
        private Label label10Btn;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private TextBox CategorieTb;
        private Label label1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private PictureBox label;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
    }
}