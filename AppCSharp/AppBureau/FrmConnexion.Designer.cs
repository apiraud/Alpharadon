namespace AppBureau
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
            LblConnexion = new Label();
            BtnConnexion = new Button();
            TxtLogin = new TextBox();
            TxtPass = new TextBox();
            LblLogin = new Label();
            LblPass = new Label();
            SuspendLayout();
            // 
            // LblConnexion
            // 
            LblConnexion.AutoSize = true;
            LblConnexion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblConnexion.Location = new Point(226, 36);
            LblConnexion.Name = "LblConnexion";
            LblConnexion.Size = new Size(219, 38);
            LblConnexion.TabIndex = 0;
            LblConnexion.Text = "SE CONNECTER";
            // 
            // BtnConnexion
            // 
            BtnConnexion.Location = new Point(482, 256);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(167, 29);
            BtnConnexion.TabIndex = 1;
            BtnConnexion.Text = "Connexion";
            BtnConnexion.UseVisualStyleBackColor = true;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // TxtLogin
            // 
            TxtLogin.Location = new Point(270, 105);
            TxtLogin.Name = "TxtLogin";
            TxtLogin.Size = new Size(242, 27);
            TxtLogin.TabIndex = 2;
            TxtLogin.Text = "D7FE0F4";
            // 
            // TxtPass
            // 
            TxtPass.Location = new Point(270, 162);
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(242, 27);
            TxtPass.TabIndex = 3;
            TxtPass.Text = "toto";
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Location = new Point(185, 108);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(58, 20);
            LblLogin.TabIndex = 4;
            LblLogin.Text = "LOGIN :";
            // 
            // LblPass
            // 
            LblPass.AutoSize = true;
            LblPass.Location = new Point(128, 165);
            LblPass.Name = "LblPass";
            LblPass.Size = new Size(115, 20);
            LblPass.TabIndex = 5;
            LblPass.Text = "MOT DE PASSE :";
            // 
            // FrmConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 312);
            Controls.Add(LblPass);
            Controls.Add(LblLogin);
            Controls.Add(TxtPass);
            Controls.Add(TxtLogin);
            Controls.Add(BtnConnexion);
            Controls.Add(LblConnexion);
            Name = "FrmConnexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblConnexion;
        private Button BtnConnexion;
        private TextBox TxtLogin;
        private TextBox TxtPass;
        private Label LblLogin;
        private Label LblPass;
    }
}
