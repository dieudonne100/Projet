
namespace Projet
{
    partial class FormConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.blbNom = new Guna.UI.WinForms.GunaLabel();
            this.txtPasse = new Guna.UI.WinForms.GunaTextBox();
            this.lblpasse = new Guna.UI.WinForms.GunaLabel();
            this.btnConnexion = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnAnnuler = new Guna.UI.WinForms.GunaButton();
            this.txtNom = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // blbNom
            // 
            this.blbNom.AutoSize = true;
            this.blbNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.blbNom.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbNom.ForeColor = System.Drawing.Color.White;
            this.blbNom.Location = new System.Drawing.Point(38, 302);
            this.blbNom.Name = "blbNom";
            this.blbNom.Size = new System.Drawing.Size(189, 25);
            this.blbNom.TabIndex = 1;
            this.blbNom.Text = "Nom de l\'utilisation";
            // 
            // txtPasse
            // 
            this.txtPasse.BackColor = System.Drawing.Color.Transparent;
            this.txtPasse.BaseColor = System.Drawing.Color.White;
            this.txtPasse.BorderColor = System.Drawing.Color.Black;
            this.txtPasse.BorderSize = 1;
            this.txtPasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasse.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPasse.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPasse.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasse.Location = new System.Drawing.Point(34, 465);
            this.txtPasse.Name = "txtPasse";
            this.txtPasse.PasswordChar = '●';
            this.txtPasse.Radius = 5;
            this.txtPasse.SelectedText = "";
            this.txtPasse.Size = new System.Drawing.Size(341, 48);
            this.txtPasse.TabIndex = 1;
            this.txtPasse.UseSystemPasswordChar = true;
            // 
            // lblpasse
            // 
            this.lblpasse.AutoSize = true;
            this.lblpasse.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasse.ForeColor = System.Drawing.Color.White;
            this.lblpasse.Location = new System.Drawing.Point(36, 426);
            this.lblpasse.Name = "lblpasse";
            this.lblpasse.Size = new System.Drawing.Size(129, 25);
            this.lblpasse.TabIndex = 6;
            this.lblpasse.Text = "Mot de passe";
            // 
            // btnConnexion
            // 
            this.btnConnexion.AnimationHoverSpeed = 0.07F;
            this.btnConnexion.AnimationSpeed = 0.03F;
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConnexion.BaseColor = System.Drawing.Color.Empty;
            this.btnConnexion.BorderColor = System.Drawing.Color.White;
            this.btnConnexion.BorderSize = 2;
            this.btnConnexion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConnexion.FocusedColor = System.Drawing.Color.Empty;
            this.btnConnexion.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Image = null;
            this.btnConnexion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConnexion.Location = new System.Drawing.Point(29, 561);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.btnConnexion.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnConnexion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConnexion.OnHoverImage = null;
            this.btnConnexion.OnPressedColor = System.Drawing.Color.White;
            this.btnConnexion.Size = new System.Drawing.Size(141, 49);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(415, 271);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 9;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.AnimationHoverSpeed = 0.07F;
            this.btnAnnuler.AnimationSpeed = 0.03F;
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnnuler.BaseColor = System.Drawing.Color.Empty;
            this.btnAnnuler.BorderColor = System.Drawing.Color.White;
            this.btnAnnuler.BorderSize = 2;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Image = null;
            this.btnAnnuler.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnnuler.Location = new System.Drawing.Point(246, 561);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.btnAnnuler.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnAnnuler.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnnuler.OnHoverImage = null;
            this.btnAnnuler.OnPressedColor = System.Drawing.Color.White;
            this.btnAnnuler.Size = new System.Drawing.Size(141, 49);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.Transparent;
            this.txtNom.BaseColor = System.Drawing.Color.White;
            this.txtNom.BorderColor = System.Drawing.Color.Black;
            this.txtNom.BorderSize = 1;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNom.Location = new System.Drawing.Point(36, 348);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.Radius = 5;
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(341, 48);
            this.txtNom.TabIndex = 0;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BackColor = System.Drawing.Color.White;
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(326, 473);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(46, 34);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox3.TabIndex = 8;
            this.gunaPictureBox3.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.White;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(329, 355);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(46, 34);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 7;
            this.gunaPictureBox2.TabStop = false;
            // 
            // FormConnexion
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(415, 634);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaPictureBox3);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtPasse);
            this.Controls.Add(this.lblpasse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.blbNom);
            this.Name = "FormConnexion";
            this.Text = "FormConnexion";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel blbNom;
        private Guna.UI.WinForms.GunaTextBox txtPasse;
        private Guna.UI.WinForms.GunaLabel lblpasse;
        private Guna.UI.WinForms.GunaButton btnConnexion;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton btnAnnuler;
        private Guna.UI.WinForms.GunaTextBox txtNom;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
    }
}