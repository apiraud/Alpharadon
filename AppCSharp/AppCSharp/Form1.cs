namespace AppCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            BtnClick.Text = "Tu m'a cliqué !";
        }
    }
}
