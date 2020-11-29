
namespace Projet
{
    partial class FormArticle
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
            this.lblARICLE = new Guna.UI.WinForms.GunaLabel();
            this.txtIdenifiant = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblPrix = new Guna.UI.WinForms.GunaLabel();
            this.txtPrix = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnMedia = new Guna.UI.WinForms.GunaButton();
            this.btnAnnuler = new Guna.UI.WinForms.GunaButton();
            this.txtDescription = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblQuantiter = new Guna.UI.WinForms.GunaLabel();
            this.txtQuantiter = new Guna.UI.WinForms.GunaLineTextBox();
            this.SuspendLayout();
            // 
            // lblARICLE
            // 
            this.lblARICLE.AutoSize = true;
            this.lblARICLE.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARICLE.ForeColor = System.Drawing.Color.White;
            this.lblARICLE.Location = new System.Drawing.Point(122, 18);
            this.lblARICLE.Name = "lblARICLE";
            this.lblARICLE.Size = new System.Drawing.Size(467, 29);
            this.lblARICLE.TabIndex = 0;
            this.lblARICLE.Text = "ENREGISTREMENT DES ARTICLE";
            // 
            // txtIdenifiant
            // 
            this.txtIdenifiant.BackColor = System.Drawing.Color.White;
            this.txtIdenifiant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdenifiant.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdenifiant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdenifiant.LineColor = System.Drawing.Color.Gainsboro;
            this.txtIdenifiant.Location = new System.Drawing.Point(226, 117);
            this.txtIdenifiant.Name = "txtIdenifiant";
            this.txtIdenifiant.PasswordChar = '\0';
            this.txtIdenifiant.SelectedText = "";
            this.txtIdenifiant.Size = new System.Drawing.Size(399, 37);
            this.txtIdenifiant.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(42, 128);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(177, 26);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Identifiant Article";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(42, 197);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(127, 26);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Nom article";
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(226, 186);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(399, 37);
            this.gunaLineTextBox1.TabIndex = 3;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.ForeColor = System.Drawing.Color.White;
            this.lblPrix.Location = new System.Drawing.Point(42, 328);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(131, 26);
            this.lblPrix.TabIndex = 6;
            this.lblPrix.Text = "Prix unitaire";
            // 
            // txtPrix
            // 
            this.txtPrix.BackColor = System.Drawing.Color.White;
            this.txtPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrix.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrix.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPrix.Location = new System.Drawing.Point(226, 317);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.PasswordChar = '\0';
            this.txtPrix.SelectedText = "";
            this.txtPrix.Size = new System.Drawing.Size(399, 37);
            this.txtPrix.TabIndex = 5;
            // 
            // btnMedia
            // 
            this.btnMedia.AnimationHoverSpeed = 0.07F;
            this.btnMedia.AnimationSpeed = 0.03F;
            this.btnMedia.BaseColor = System.Drawing.Color.White;
            this.btnMedia.BorderColor = System.Drawing.Color.Black;
            this.btnMedia.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMedia.FocusedColor = System.Drawing.Color.Empty;
            this.btnMedia.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.ForeColor = System.Drawing.Color.Green;
            this.btnMedia.Image = null;
            this.btnMedia.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMedia.Location = new System.Drawing.Point(226, 466);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMedia.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMedia.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMedia.OnHoverImage = null;
            this.btnMedia.OnPressedColor = System.Drawing.Color.Black;
            this.btnMedia.Size = new System.Drawing.Size(152, 47);
            this.btnMedia.TabIndex = 9;
            this.btnMedia.Text = "Enregistrer";
            this.btnMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.AnimationHoverSpeed = 0.07F;
            this.btnAnnuler.AnimationSpeed = 0.03F;
            this.btnAnnuler.BackColor = System.Drawing.Color.White;
            this.btnAnnuler.BaseColor = System.Drawing.Color.White;
            this.btnAnnuler.BorderColor = System.Drawing.Color.Black;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnnuler.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Red;
            this.btnAnnuler.Image = null;
            this.btnAnnuler.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnnuler.Location = new System.Drawing.Point(473, 466);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAnnuler.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAnnuler.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnnuler.OnHoverImage = null;
            this.btnAnnuler.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnnuler.Size = new System.Drawing.Size(152, 47);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.LineColor = System.Drawing.Color.Gainsboro;
            this.txtDescription.Location = new System.Drawing.Point(226, 250);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(399, 37);
            this.txtDescription.TabIndex = 13;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(42, 261);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(127, 26);
            this.gunaLabel4.TabIndex = 12;
            this.gunaLabel4.Text = "Description";
            // 
            // lblQuantiter
            // 
            this.lblQuantiter.AutoSize = true;
            this.lblQuantiter.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantiter.ForeColor = System.Drawing.Color.White;
            this.lblQuantiter.Location = new System.Drawing.Point(42, 400);
            this.lblQuantiter.Name = "lblQuantiter";
            this.lblQuantiter.Size = new System.Drawing.Size(105, 26);
            this.lblQuantiter.TabIndex = 15;
            this.lblQuantiter.Text = "Quantiter";
            // 
            // txtQuantiter
            // 
            this.txtQuantiter.BackColor = System.Drawing.Color.White;
            this.txtQuantiter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantiter.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQuantiter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantiter.LineColor = System.Drawing.Color.Gainsboro;
            this.txtQuantiter.Location = new System.Drawing.Point(226, 389);
            this.txtQuantiter.Name = "txtQuantiter";
            this.txtQuantiter.PasswordChar = '\0';
            this.txtQuantiter.SelectedText = "";
            this.txtQuantiter.Size = new System.Drawing.Size(399, 37);
            this.txtQuantiter.TabIndex = 14;
            // 
            // FormArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(688, 536);
            this.Controls.Add(this.lblQuantiter);
            this.Controls.Add(this.txtQuantiter);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLineTextBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtIdenifiant);
            this.Controls.Add(this.lblARICLE);
            this.Name = "FormArticle";
            this.Text = "FormArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblARICLE;
        private Guna.UI.WinForms.GunaLineTextBox txtIdenifiant;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaLabel lblPrix;
        private Guna.UI.WinForms.GunaLineTextBox txtPrix;
        private Guna.UI.WinForms.GunaButton btnMedia;
        private Guna.UI.WinForms.GunaButton btnAnnuler;
        private Guna.UI.WinForms.GunaLineTextBox txtDescription;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblQuantiter;
        private Guna.UI.WinForms.GunaLineTextBox txtQuantiter;
    }
}