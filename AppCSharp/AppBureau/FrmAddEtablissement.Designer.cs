namespace AppBureau
{
    partial class FrmAddEtablissement
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
            LblRaisonSociale = new Label();
            LblFormeJuridique = new Label();
            LblSiret = new Label();
            LblAdresse = new Label();
            LblMail = new Label();
            LblTelephone = new Label();
            LblTechnicien = new Label();
            TxtRaisonSociale = new TextBox();
            TxtFormeJuridique = new TextBox();
            TxtSiret = new TextBox();
            TxtAdresse = new TextBox();
            TxtMail = new TextBox();
            TxtTelephone = new TextBox();
            CbTechnicien = new ComboBox();
            BtnAnnuler = new Button();
            BtnEnregistrer = new Button();
            SuspendLayout();
            // 
            // LblRaisonSociale
            // 
            LblRaisonSociale.AutoSize = true;
            LblRaisonSociale.Location = new Point(68, 16);
            LblRaisonSociale.Name = "LblRaisonSociale";
            LblRaisonSociale.Size = new Size(110, 20);
            LblRaisonSociale.TabIndex = 0;
            LblRaisonSociale.Text = "Raison sociale :";
            // 
            // LblFormeJuridique
            // 
            LblFormeJuridique.AutoSize = true;
            LblFormeJuridique.Location = new Point(56, 74);
            LblFormeJuridique.Name = "LblFormeJuridique";
            LblFormeJuridique.Size = new Size(122, 20);
            LblFormeJuridique.TabIndex = 1;
            LblFormeJuridique.Text = "Forme Juridique :";
            // 
            // LblSiret
            // 
            LblSiret.AutoSize = true;
            LblSiret.Location = new Point(46, 131);
            LblSiret.Name = "LblSiret";
            LblSiret.Size = new Size(130, 20);
            LblSiret.TabIndex = 2;
            LblSiret.Text = "SIRET (14 caract.) :";
            // 
            // LblAdresse
            // 
            LblAdresse.AutoSize = true;
            LblAdresse.Location = new Point(52, 181);
            LblAdresse.Name = "LblAdresse";
            LblAdresse.Size = new Size(121, 20);
            LblAdresse.TabIndex = 3;
            LblAdresse.Text = "Adresse postale :";
            // 
            // LblMail
            // 
            LblMail.AutoSize = true;
            LblMail.Location = new Point(124, 246);
            LblMail.Name = "LblMail";
            LblMail.Size = new Size(49, 20);
            LblMail.TabIndex = 4;
            LblMail.Text = "Mail : ";
            // 
            // LblTelephone
            // 
            LblTelephone.AutoSize = true;
            LblTelephone.Location = new Point(46, 306);
            LblTelephone.Name = "LblTelephone";
            LblTelephone.Size = new Size(125, 20);
            LblTelephone.TabIndex = 5;
            LblTelephone.Text = "N° de téléphone :";
            // 
            // LblTechnicien
            // 
            LblTechnicien.AutoSize = true;
            LblTechnicien.Location = new Point(46, 353);
            LblTechnicien.Name = "LblTechnicien";
            LblTechnicien.Size = new Size(127, 20);
            LblTechnicien.TabIndex = 6;
            LblTechnicien.Text = "Technicien affilié :";
            // 
            // TxtRaisonSociale
            // 
            TxtRaisonSociale.Location = new Point(184, 16);
            TxtRaisonSociale.Name = "TxtRaisonSociale";
            TxtRaisonSociale.Size = new Size(248, 27);
            TxtRaisonSociale.TabIndex = 7;
            // 
            // TxtFormeJuridique
            // 
            TxtFormeJuridique.Location = new Point(184, 71);
            TxtFormeJuridique.Name = "TxtFormeJuridique";
            TxtFormeJuridique.Size = new Size(248, 27);
            TxtFormeJuridique.TabIndex = 8;
            // 
            // TxtSiret
            // 
            TxtSiret.Location = new Point(184, 128);
            TxtSiret.Name = "TxtSiret";
            TxtSiret.Size = new Size(248, 27);
            TxtSiret.TabIndex = 9;
            // 
            // TxtAdresse
            // 
            TxtAdresse.Location = new Point(184, 181);
            TxtAdresse.Name = "TxtAdresse";
            TxtAdresse.Size = new Size(248, 27);
            TxtAdresse.TabIndex = 10;
            // 
            // TxtMail
            // 
            TxtMail.Location = new Point(184, 243);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(248, 27);
            TxtMail.TabIndex = 11;
            // 
            // TxtTelephone
            // 
            TxtTelephone.Location = new Point(184, 299);
            TxtTelephone.Name = "TxtTelephone";
            TxtTelephone.Size = new Size(248, 27);
            TxtTelephone.TabIndex = 12;
            // 
            // CbTechnicien
            // 
            CbTechnicien.FormattingEnabled = true;
            CbTechnicien.Location = new Point(184, 353);
            CbTechnicien.Name = "CbTechnicien";
            CbTechnicien.Size = new Size(248, 28);
            CbTechnicien.TabIndex = 13;
            // 
            // BtnAnnuler
            // 
            BtnAnnuler.Location = new Point(612, 392);
            BtnAnnuler.Name = "BtnAnnuler";
            BtnAnnuler.Size = new Size(128, 29);
            BtnAnnuler.TabIndex = 14;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            BtnAnnuler.Click += BtnAnnuler_Click;
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(612, 344);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(128, 29);
            BtnEnregistrer.TabIndex = 15;
            BtnEnregistrer.Text = "ENREGISTRER";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // FrmAddEtablissement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEnregistrer);
            Controls.Add(BtnAnnuler);
            Controls.Add(CbTechnicien);
            Controls.Add(TxtTelephone);
            Controls.Add(TxtMail);
            Controls.Add(TxtAdresse);
            Controls.Add(TxtSiret);
            Controls.Add(TxtFormeJuridique);
            Controls.Add(TxtRaisonSociale);
            Controls.Add(LblTechnicien);
            Controls.Add(LblTelephone);
            Controls.Add(LblMail);
            Controls.Add(LblAdresse);
            Controls.Add(LblSiret);
            Controls.Add(LblFormeJuridique);
            Controls.Add(LblRaisonSociale);
            Name = "FrmAddEtablissement";
            Text = "Ajouter un établissement";
            Load += FrmAddEtablissement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblRaisonSociale;
        private Label LblFormeJuridique;
        private Label LblSiret;
        private Label LblAdresse;
        private Label LblMail;
        private Label LblTelephone;
        private Label LblTechnicien;
        private TextBox TxtRaisonSociale;
        private TextBox TxtFormeJuridique;
        private TextBox TxtSiret;
        private TextBox TxtAdresse;
        private TextBox TxtMail;
        private TextBox TxtTelephone;
        private ComboBox CbTechnicien;
        private Button BtnAnnuler;
        private Button BtnEnregistrer;
    }
}