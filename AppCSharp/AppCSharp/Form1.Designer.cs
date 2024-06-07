namespace AppCSharp
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
            BtnClick = new Button();
            LblBouton = new Label();
            SuspendLayout();
            // 
            // BtnClick
            // 
            BtnClick.Location = new Point(252, 169);
            BtnClick.Name = "BtnClick";
            BtnClick.Size = new Size(201, 29);
            BtnClick.TabIndex = 0;
            BtnClick.Text = "Clique-moi !";
            BtnClick.UseVisualStyleBackColor = true;
            BtnClick.Click += BtnClick_Click;
            // 
            // LblBouton
            // 
            LblBouton.AutoSize = true;
            LblBouton.Location = new Point(274, 125);
            LblBouton.Name = "LblBouton";
            LblBouton.Size = new Size(166, 20);
            LblBouton.TabIndex = 1;
            LblBouton.Text = "Ne pas obéir au bouton";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblBouton);
            Controls.Add(BtnClick);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnClick;
        private Label LblBouton;
    }
}
