using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;

namespace AppTechnicien
{
    public partial class FrmEtablissement : Form
    {
        private readonly int idEtablissement;

        // constructeur
        public FrmEtablissement()
        {
            InitializeComponent();
            BtnVoirDetecteur.Enabled = false;
        }

        // Charge la liste des établissement au lancement de la fenêtre 
        private void FrmEtablissement_Load(object sender, EventArgs e)
        {
            try
            {
                using (RadonContext db = new RadonContext())
                {
                    List<Etablissement> etablissements = db.Etablissements.ToList();
                    LsbEtablissement.DataSource = etablissements;
                }
            }

            catch (Exception ex)
            {
                // En cas d'erreur lors de la connexion, affichez un message d'erreur
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }


        // voir détecteur
        private void BtnVoirDetecteur_Click(object sender, EventArgs e)
        {
            Etablissement etablissementSelected = (Etablissement)LsbEtablissement.SelectedItem;
            FrmDetecteur frmDetecteur = new FrmDetecteur(etablissementSelected.Id);
            frmDetecteur.ShowDialog();
        }

        // activer le bouton permettant d'ouvrir la fenêtre suivante : FrmDetecteur
        private void LsbEtablissement_Click(object sender, EventArgs e)
        {
            BtnVoirDetecteur.Enabled = true;
        }
    }
}
