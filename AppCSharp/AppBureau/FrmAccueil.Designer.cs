namespace AppBureau
{
    partial class FrmAccueil
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
            LsbEtablissement = new ListBox();
            BtnAjouter = new Button();
            BtnClassement = new Button();
            BtnEnregisterReleve = new Button();
            LblEtablissement = new Label();
            LblConformite = new Label();
            LblConformiteValeur = new Label();
            SuspendLayout();
            // 
            // LsbEtablissement
            // 
            LsbEtablissement.FormattingEnabled = true;
            LsbEtablissement.ItemHeight = 20;
            LsbEtablissement.Location = new Point(66, 72);
            LsbEtablissement.Name = "LsbEtablissement";
            LsbEtablissement.Size = new Size(278, 264);
            LsbEtablissement.TabIndex = 0;
            LsbEtablissement.Click += LsbEtablissement_Click;
            LsbEtablissement.DoubleClick += LsbEtablissement_DbClick;
            // 
            // BtnAjouter
            // 
            BtnAjouter.Location = new Point(367, 260);
            BtnAjouter.Name = "BtnAjouter";
            BtnAjouter.Size = new Size(189, 35);
            BtnAjouter.TabIndex = 1;
            BtnAjouter.Text = "Ajouter";
            BtnAjouter.UseVisualStyleBackColor = true;
            BtnAjouter.Click += BtnAjouter_Click;
            // 
            // BtnClassement
            // 
            BtnClassement.Location = new Point(367, 301);
            BtnClassement.Name = "BtnClassement";
            BtnClassement.Size = new Size(189, 35);
            BtnClassement.TabIndex = 3;
            BtnClassement.Text = "Classement";
            BtnClassement.UseVisualStyleBackColor = true;
            BtnClassement.Click += BtnClassement_Click;
            // 
            // BtnEnregisterReleve
            // 
            BtnEnregisterReleve.Location = new Point(376, 104);
            BtnEnregisterReleve.Name = "BtnEnregisterReleve";
            BtnEnregisterReleve.Size = new Size(189, 33);
            BtnEnregisterReleve.TabIndex = 4;
            BtnEnregisterReleve.Text = "Enregistrer un relevé";
            BtnEnregisterReleve.UseVisualStyleBackColor = true;
            BtnEnregisterReleve.Click += BtnEnregisterReleve_Click;
            // 
            // LblEtablissement
            // 
            LblEtablissement.AllowDrop = true;
            LblEtablissement.AutoSize = true;
            LblEtablissement.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblEtablissement.Location = new Point(76, 29);
            LblEtablissement.Name = "LblEtablissement";
            LblEtablissement.Size = new Size(241, 28);
            LblEtablissement.TabIndex = 5;
            LblEtablissement.Text = "Liste des établissements";
            // 
            // LblConformite
            // 
            LblConformite.AutoSize = true;
            LblConformite.Location = new Point(376, 72);
            LblConformite.Name = "LblConformite";
            LblConformite.Size = new Size(95, 20);
            LblConformite.TabIndex = 7;
            LblConformite.Text = "Conformité : ";
            // 
            // LblConformiteValeur
            // 
            LblConformiteValeur.AutoSize = true;
            LblConformiteValeur.Location = new Point(471, 72);
            LblConformiteValeur.Name = "LblConformiteValeur";
            LblConformiteValeur.Size = new Size(0, 20);
            LblConformiteValeur.TabIndex = 8;
            // 
            // FrmAccueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 355);
            Controls.Add(LblConformiteValeur);
            Controls.Add(LblConformite);
            Controls.Add(LblEtablissement);
            Controls.Add(BtnEnregisterReleve);
            Controls.Add(BtnClassement);
            Controls.Add(BtnAjouter);
            Controls.Add(LsbEtablissement);
            Name = "FrmAccueil";
            Text = "Accueil";
            Load += FrmAccueil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LsbEtablissement;
        private Button BtnAjouter;
        private Button BtnClassement;
        private Button BtnEnregisterReleve;
        private Label LblEtablissement;
        private Label LblConformite;
        private Label LblConformiteValeur;
    }
}