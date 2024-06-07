namespace AppTechnicien
{
    partial class FrmDetecteur
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
            LblListeDetecteurs = new Label();
            LsbListeDetecteurs = new ListBox();
            BtnAjouterDetecteur = new Button();
            BtnSupprimerDetecteur = new Button();
            TxtLocalisation = new TextBox();
            LblSalle = new Label();
            SuspendLayout();
            // 
            // LblListeDetecteurs
            // 
            LblListeDetecteurs.AutoSize = true;
            LblListeDetecteurs.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            LblListeDetecteurs.Location = new Point(33, 22);
            LblListeDetecteurs.Name = "LblListeDetecteurs";
            LblListeDetecteurs.Size = new Size(350, 46);
            LblListeDetecteurs.TabIndex = 0;
            LblListeDetecteurs.Text = "Liste des détecteurs :";
            // 
            // LsbListeDetecteurs
            // 
            LsbListeDetecteurs.Cursor = Cursors.No;
            LsbListeDetecteurs.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LsbListeDetecteurs.FormattingEnabled = true;
            LsbListeDetecteurs.ItemHeight = 37;
            LsbListeDetecteurs.Location = new Point(43, 71);
            LsbListeDetecteurs.Name = "LsbListeDetecteurs";
            LsbListeDetecteurs.Size = new Size(327, 411);
            LsbListeDetecteurs.TabIndex = 1;
            // 
            // BtnAjouterDetecteur
            // 
            BtnAjouterDetecteur.BackColor = Color.LightSkyBlue;
            BtnAjouterDetecteur.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAjouterDetecteur.Location = new Point(392, 380);
            BtnAjouterDetecteur.Name = "BtnAjouterDetecteur";
            BtnAjouterDetecteur.Size = new Size(274, 102);
            BtnAjouterDetecteur.TabIndex = 2;
            BtnAjouterDetecteur.Text = "Ajouter un détecteur";
            BtnAjouterDetecteur.UseVisualStyleBackColor = false;
            BtnAjouterDetecteur.Click += BtnAjouterDetecteur_Click;
            // 
            // BtnSupprimerDetecteur
            // 
            BtnSupprimerDetecteur.BackColor = Color.IndianRed;
            BtnSupprimerDetecteur.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSupprimerDetecteur.Location = new Point(720, 380);
            BtnSupprimerDetecteur.Name = "BtnSupprimerDetecteur";
            BtnSupprimerDetecteur.Size = new Size(274, 102);
            BtnSupprimerDetecteur.TabIndex = 3;
            BtnSupprimerDetecteur.Text = "Supprimer le détecteur";
            BtnSupprimerDetecteur.UseVisualStyleBackColor = false;
            BtnSupprimerDetecteur.Click += BtnSupprimerDetecteur_Click;
            // 
            // TxtLocalisation
            // 
            TxtLocalisation.Location = new Point(392, 248);
            TxtLocalisation.MinimumSize = new Size(274, 90);
            TxtLocalisation.Name = "TxtLocalisation";
            TxtLocalisation.Size = new Size(274, 90);
            TxtLocalisation.TabIndex = 4;
            // 
            // LblSalle
            // 
            LblSalle.AutoSize = true;
            LblSalle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LblSalle.Location = new Point(392, 193);
            LblSalle.Name = "LblSalle";
            LblSalle.Size = new Size(185, 37);
            LblSalle.TabIndex = 5;
            LblSalle.Text = "Localisation :";
            // 
            // FrmDetecteur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 526);
            Controls.Add(LblSalle);
            Controls.Add(TxtLocalisation);
            Controls.Add(BtnSupprimerDetecteur);
            Controls.Add(BtnAjouterDetecteur);
            Controls.Add(LsbListeDetecteurs);
            Controls.Add(LblListeDetecteurs);
            Name = "FrmDetecteur";
            Text = "Liste detecteurs";
            Load += FrmDetecteur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblListeDetecteurs;
        private ListBox LsbListeDetecteurs;
        private Button BtnAjouterDetecteur;
        private Button BtnSupprimerDetecteur;
        private TextBox TxtLocalisation;
        private Label LblSalle;
    }
}