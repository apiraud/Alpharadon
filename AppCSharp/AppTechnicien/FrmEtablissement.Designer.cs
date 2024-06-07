namespace AppTechnicien
{
    partial class FrmEtablissement
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
            LblEtablissement = new Label();
            BtnVoirDetecteur = new Button();
            SuspendLayout();
            // 
            // LsbEtablissement
            // 
            LsbEtablissement.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LsbEtablissement.FormattingEnabled = true;
            LsbEtablissement.ItemHeight = 37;
            LsbEtablissement.Location = new Point(25, 50);
            LsbEtablissement.Name = "LsbEtablissement";
            LsbEtablissement.Size = new Size(329, 485);
            LsbEtablissement.TabIndex = 0;
            LsbEtablissement.Click += LsbEtablissement_Click;
            // 
            // LblEtablissement
            // 
            LblEtablissement.AutoSize = true;
            LblEtablissement.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblEtablissement.Location = new Point(25, 9);
            LblEtablissement.Name = "LblEtablissement";
            LblEtablissement.Size = new Size(273, 31);
            LblEtablissement.TabIndex = 1;
            LblEtablissement.Text = "Liste des établissements :";
            // 
            // BtnVoirDetecteur
            // 
            BtnVoirDetecteur.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVoirDetecteur.Location = new Point(392, 50);
            BtnVoirDetecteur.Name = "BtnVoirDetecteur";
            BtnVoirDetecteur.Size = new Size(270, 89);
            BtnVoirDetecteur.TabIndex = 2;
            BtnVoirDetecteur.Text = "Voir Détécteurs";
            BtnVoirDetecteur.UseVisualStyleBackColor = true;
            BtnVoirDetecteur.Click += BtnVoirDetecteur_Click;
            // 
            // FrmEtablissement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 555);
            Controls.Add(BtnVoirDetecteur);
            Controls.Add(LblEtablissement);
            Controls.Add(LsbEtablissement);
            Name = "FrmEtablissement";
            Text = "Etablissements";
            Load += FrmEtablissement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LsbEtablissement;
        private Label LblEtablissement;
        private Button BtnVoirDetecteur;
    }
}