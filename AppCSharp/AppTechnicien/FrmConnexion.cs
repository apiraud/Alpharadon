using BLL.Models;

namespace AppTechnicien
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        // Bouton de connexion
        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            //Récupérer les valeurs des textBox

            string nomUtilisateur = TxtLogin.Text;
            string motDePasse = TxtPass.Text;

            //Hasher le mot de passe avec l'algorithme SHA 512

            string motDePasseHash = BLL.fonctions.GetSHA512Hash(motDePasse);

            // Vérifier les informations de connexion

            try
            {
                using (RadonContext db = new RadonContext())
                {
                    Utilisateur? utilisateur = db.Utilisateurs.SingleOrDefault(o => o.Login == nomUtilisateur && o.Password == motDePasseHash);

                    if (utilisateur != null && utilisateur.EstTechnicien == true)
                    {
                        FrmEtablissement frmEtablissement = new FrmEtablissement();
                        frmEtablissement.ShowDialog();
                    }

                    else if (nomUtilisateur == null)
                    {
                        MessageBox.Show("Veuillez renseigner un login et mot de passe correct");
                    }

                    else if (utilisateur.EstTechnicien == false)
                    {
                        MessageBox.Show("Seuls les techniciens peuvent se connecter à se logiciel");
                    }


                }
            }
            catch (Exception ex)
            {
                // En cas d'erreur lors de la connexion, affichez un message d'erreur
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }
    }
}
