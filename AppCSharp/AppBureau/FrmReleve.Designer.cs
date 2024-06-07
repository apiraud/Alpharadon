namespace AppBureau
{
    partial class FrmReleve
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
            LsbDetecteur = new ListBox();
            LblListeDetecteur = new Label();
            TxtValeur = new TextBox();
            LblValeur = new Label();
            BtnValider = new Button();
            BtnAnnuler = new Button();
            BtnQuitter = new Button();
            SuspendLayout();
            // 
            // LsbDetecteur
            // 
            LsbDetecteur.FormattingEnabled = true;
            LsbDetecteur.ItemHeight = 20;
            LsbDetecteur.Location = new Point(30, 58);
            LsbDetecteur.Name = "LsbDetecteur";
            LsbDetecteur.Size = new Size(213, 164);
            LsbDetecteur.TabIndex = 0;
            LsbDetecteur.SelectedIndexChanged += LsbDetecteur_SelectedIndexChanged;
            LsbDetecteur.DoubleClick += LsbReleves_DoubleClick;
            // 
            // LblListeDetecteur
            // 
            LblListeDetecteur.AutoSize = true;
            LblListeDetecteur.Location = new Point(59, 23);
            LblListeDetecteur.Name = "LblListeDetecteur";
            LblListeDetecteur.Size = new Size(146, 20);
            LblListeDetecteur.TabIndex = 1;
            LblListeDetecteur.Text = "Liste des détécteurs :";
            // 
            // TxtValeur
            // 
            TxtValeur.Location = new Point(462, 55);
            TxtValeur.Name = "TxtValeur";
            TxtValeur.Size = new Size(125, 27);
            TxtValeur.TabIndex = 2;
            // 
            // LblValeur
            // 
            LblValeur.AutoSize = true;
            LblValeur.Location = new Point(334, 58);
            LblValeur.Name = "LblValeur";
            LblValeur.Size = new Size(122, 20);
            LblValeur.TabIndex = 3;
            LblValeur.Text = "Valeur du relevé :";
            // 
            // BtnValider
            // 
            BtnValider.Location = new Point(524, 88);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(74, 28);
            BtnValider.TabIndex = 6;
            BtnValider.Text = "Valider";
            BtnValider.UseVisualStyleBackColor = true;
            BtnValider.Click += BtnValider_Click;
            // 
            // BtnAnnuler
            // 
            BtnAnnuler.Location = new Point(447, 88);
            BtnAnnuler.Name = "BtnAnnuler";
            BtnAnnuler.Size = new Size(71, 28);
            BtnAnnuler.TabIndex = 7;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            BtnAnnuler.Click += BtnAnnuler_Click;
            // 
            // BtnQuitter
            // 
            BtnQuitter.Location = new Point(372, 190);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(226, 29);
            BtnQuitter.TabIndex = 8;
            BtnQuitter.Text = "Calculer Conformité et quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // FrmReleve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 256);
            Controls.Add(BtnQuitter);
            Controls.Add(BtnAnnuler);
            Controls.Add(BtnValider);
            Controls.Add(LblValeur);
            Controls.Add(TxtValeur);
            Controls.Add(LblListeDetecteur);
            Controls.Add(LsbDetecteur);
            Name = "FrmReleve";
            Text = "Enregistrement d'un relevé";
            Load += FrmReleve_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LsbDetecteur;
        private Label LblListeDetecteur;
        private TextBox TxtValeur;
        private Label LblValeur;
        private Button BtnValider;
        private Button BtnAnnuler;
        private Button BtnQuitter;
    }
}