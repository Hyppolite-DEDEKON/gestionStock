namespace GestionsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnCon = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnInscription = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            PassITb = new Guna.UI2.WinForms.Guna2TextBox();
            EmailTb = new Guna.UI2.WinForms.Guna2TextBox();
            NomITb = new Guna.UI2.WinForms.Guna2TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 493);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 493);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(btnCon);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(btnInscription);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(PassITb);
            panel4.Controls.Add(EmailTb);
            panel4.Controls.Add(NomITb);
            panel4.Location = new Point(401, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(498, 493);
            panel4.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(433, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(461, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnCon
            // 
            btnCon.AutoSize = true;
            btnCon.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnCon.ForeColor = Color.CornflowerBlue;
            btnCon.Location = new Point(230, 426);
            btnCon.Name = "btnCon";
            btnCon.Size = new Size(108, 19);
            btnCon.TabIndex = 4;
            btnCon.Text = "Connectez-vous";
            btnCon.Click += btnCon_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 426);
            label2.Name = "label2";
            label2.Size = new Size(176, 19);
            label2.TabIndex = 4;
            label2.Text = "Avez vous deja un compte?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(57, 283);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 3;
            label4.Text = "Mot de passe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(57, 203);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(57, 125);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 3;
            label5.Text = "Nom d'utilisateur";
            // 
            // btnInscription
            // 
            btnInscription.BorderRadius = 5;
            btnInscription.CustomizableEdges = customizableEdges1;
            btnInscription.DisabledState.BorderColor = Color.DarkGray;
            btnInscription.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInscription.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInscription.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInscription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscription.ForeColor = Color.White;
            btnInscription.Location = new Point(57, 368);
            btnInscription.Name = "btnInscription";
            btnInscription.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnInscription.Size = new Size(407, 44);
            btnInscription.TabIndex = 2;
            btnInscription.Text = "S'inscrire";
            btnInscription.Click += btnInscription_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(54, 78);
            label1.Name = "label1";
            label1.Size = new Size(154, 37);
            label1.TabIndex = 1;
            label1.Text = "Inscription";
            // 
            // PassITb
            // 
            PassITb.BorderRadius = 5;
            PassITb.CustomizableEdges = customizableEdges3;
            PassITb.DefaultText = "";
            PassITb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PassITb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PassITb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PassITb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PassITb.FillColor = Color.LightGray;
            PassITb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PassITb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PassITb.ForeColor = Color.Black;
            PassITb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PassITb.Location = new Point(57, 311);
            PassITb.Name = "PassITb";
            PassITb.PasswordChar = '\0';
            PassITb.PlaceholderText = "";
            PassITb.SelectedText = "";
            PassITb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PassITb.Size = new Size(407, 38);
            PassITb.TabIndex = 0;
            PassITb.TextChanged += guna2TextBox3_TextChanged;
            // 
            // EmailTb
            // 
            EmailTb.BorderRadius = 5;
            EmailTb.CustomizableEdges = customizableEdges5;
            EmailTb.DefaultText = "";
            EmailTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            EmailTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            EmailTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            EmailTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            EmailTb.FillColor = Color.LightGray;
            EmailTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTb.ForeColor = Color.Black;
            EmailTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailTb.Location = new Point(57, 231);
            EmailTb.Name = "EmailTb";
            EmailTb.PasswordChar = '\0';
            EmailTb.PlaceholderText = "";
            EmailTb.SelectedText = "";
            EmailTb.ShadowDecoration.CustomizableEdges = customizableEdges6;
            EmailTb.Size = new Size(407, 38);
            EmailTb.TabIndex = 0;
            // 
            // NomITb
            // 
            NomITb.BorderRadius = 5;
            NomITb.CustomizableEdges = customizableEdges7;
            NomITb.DefaultText = "";
            NomITb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            NomITb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            NomITb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            NomITb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            NomITb.FillColor = Color.LightGray;
            NomITb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            NomITb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NomITb.ForeColor = Color.Black;
            NomITb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            NomITb.Location = new Point(57, 157);
            NomITb.Name = "NomITb";
            NomITb.PasswordChar = '\0';
            NomITb.PlaceholderText = "";
            NomITb.SelectedText = "";
            NomITb.ShadowDecoration.CustomizableEdges = customizableEdges8;
            NomITb.Size = new Size(407, 38);
            NomITb.TabIndex = 0;
            NomITb.TextChanged += guna2TextBox1_TextChanged;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(899, 493);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox PassITb;
        private Guna.UI2.WinForms.Guna2TextBox EmailTb;
        private Guna.UI2.WinForms.Guna2TextBox NomITb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button btnInscription;
        private Label label1;
        private PictureBox pictureBox1;
        private Label btnCon;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}