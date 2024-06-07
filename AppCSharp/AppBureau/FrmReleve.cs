using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBureau
{
    public partial class FrmReleve : Form
    {
        // Déclarer idEtablissement en tant que champ de classe
        private readonly int idEtablissement;

        public FrmReleve()
        {
            InitializeComponent();
        }

        // surcharge du contrôleur pour passer l'id de l'établissement
        public FrmReleve(int idEtablissement)
        {
            InitializeComponent();
            this.idEtablissement = idEtablissement; // Affecter la valeur du paramètre au champ de classe
        }

        // Au chargement du formulaire
        private void FrmReleve_Load(object sender, EventArgs e)
        {
            SansModif();
            ChargerDetecteursSansReleves();
        }

        // méthode : charger les détecteurs sans valeur relevée
        private void ChargerDetecteursSansReleves()
        {
            try
            {
                // select des détecteurs de l'établissement qui n'ont pas de valeurs relevées
                using (RadonContext db = new RadonContext())
                {
                    //List<Detecteur> detecteursEnCours = db.Detecteurs.Where(d => d.DateRetrait != null && d.ValeurReleve == null && d.IdEtablissement == this.idEtablissement).ToList();
                    List<Detecteur> detecteursEnCours = db.Detecteurs.Where(d => d.DateRetrait != null && d.IdEtablissement == this.idEtablissement).ToList();
                    LsbDetecteur.DataSource = detecteursEnCours;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // modifier la valeur du relevé dans la textbox
        private void LsbReleves_DoubleClick(object sender, EventArgs e)
        {
            EnModif();

            Detecteur detecteur = (Detecteur)LsbDetecteur.SelectedItem;
            TxtValeur.Text = detecteur.ValeurReleve.ToString();
        }

        // enregistrer la valeur du relevé au détecteur
        private void BtnValider_Click(object sender, EventArgs e)
        {
            try
            {
                Detecteur detecteur = (Detecteur)LsbDetecteur.SelectedItem;
                decimal valeur;

                // Vérification si la valeur est vide ou non décimale
                if (string.IsNullOrWhiteSpace(TxtValeur.Text) || !decimal.TryParse(TxtValeur.Text, out valeur))
                {
                    throw new Exception("La valeur doit être un nombre décimal.");
                }

                // Vérification si la valeur est entre 2,5 et 3000
                if (valeur >= 2.5m && valeur <= 3000m)
                {
                    using (RadonContext db = new RadonContext())
                    {
                        detecteur.ValeurReleve = valeur;

                        Detecteur detecteurUpdate = db.Detecteurs.FirstOrDefault(d => d.Id == detecteur.Id);
                        if (detecteurUpdate != null)
                        {
                            detecteurUpdate.ValeurReleve = valeur;
                            db.SaveChanges();
                        }
                    }
                    SansModif();
                    ChargerDetecteursSansReleves();
                }
                else
                {
                    throw new Exception("La valeur doit être entre 2,5 et 3000.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // annuler la saisie
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            SansModif();
        }

        // activer les boutons pour la modification
        private void EnModif()
        {
            TxtValeur.Enabled = true;
            BtnValider.Enabled = true;
            BtnAnnuler.Enabled = true;

            LsbDetecteur.Enabled = false;
        }

        // désactiver les boutons tant qu'il n'y a pas de modification
        private void SansModif()
        {
            TxtValeur.Enabled = false;
            BtnValider.Enabled = false;
            BtnAnnuler.Enabled = false;

            LsbDetecteur.Enabled = true;
        }

        // afficher le relevé du détecteur dans la textbox
        private void LsbDetecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Detecteur detecteur = (Detecteur)LsbDetecteur.SelectedItem;
            TxtValeur.Text = detecteur.ValeurReleve.ToString();
        }

        // Calculer la conformité et quitter la fenêtre
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            try
            {
                //using (var context = new YourDbContext())
                using(RadonContext db = new RadonContext())
                {
                    try
                    {
                        var result = db.CalculConformite(idEtablissement);
                        // Traitez le résultat retourné selon vos besoins
                        MessageBox.Show(result.ToString());
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
