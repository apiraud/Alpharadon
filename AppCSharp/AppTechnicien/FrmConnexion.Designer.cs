namespace AppTechnicien
{
    partial class FrmConnexion
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
            LblConnecter = new Label();
            TxtLogin = new TextBox();
            TxtPass = new TextBox();
            LblLogin = new Label();
            LblPass = new Label();
            BtnConnexion = new Button();
            SuspendLayout();
            // 
            // LblConnecter
            // 
            LblConnecter.AutoSize = true;
            LblConnecter.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblConnecter.Location = new Point(183, 9);
            LblConnecter.Margin = new Padding(2, 0, 2, 0);
            LblConnecter.Name = "LblConnecter";
            LblConnecter.Size = new Size(291, 50);
            LblConnecter.TabIndex = 1;
            LblConnecter.Text = "SE CONNECTER";
            // 
            // TxtLogin
            // 
            TxtLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtLogin.Location = new Point(248, 89);
            TxtLogin.Name = "TxtLogin";
            TxtLogin.Size = new Size(276, 43);
            TxtLogin.TabIndex = 2;
            TxtLogin.Text = "DC5D405";
            // 
            // TxtPass
            // 
            TxtPass.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPass.Location = new Point(248, 158);
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(276, 43);
            TxtPass.TabIndex = 3;
            TxtPass.Text = "toto";
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblLogin.Location = new Point(118, 89);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(111, 38);
            LblLogin.TabIndex = 4;
            LblLogin.Text = "LOGIN :";
            // 
            // LblPass
            // 
            LblPass.AutoSize = true;
            LblPass.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblPass.Location = new Point(12, 158);
            LblPass.Name = "LblPass";
            LblPass.Size = new Size(217, 38);
            LblPass.TabIndex = 5;
            LblPass.Text = "MOT DE PASSE :";
            // 
            // BtnConnexion
            // 
            BtnConnexion.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConnexion.Location = new Point(248, 230);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(169, 57);
            BtnConnexion.TabIndex = 6;
            BtnConnexion.Text = "Connexion";
            BtnConnexion.UseVisualStyleBackColor = true;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // FrmConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 318);
            Controls.Add(BtnConnexion);
            Controls.Add(LblPass);
            Controls.Add(LblLogin);
            Controls.Add(TxtPass);
            Controls.Add(TxtLogin);
            Controls.Add(LblConnecter);
            Margin = new Padding(2);
            Name = "FrmConnexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblConnecter;
        private TextBox TxtLogin;
        private TextBox TxtPass;
        private Label LblLogin;
        private Label LblPass;
        private Button BtnConnexion;
    }
}
