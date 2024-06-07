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
    public partial class FrmDetecteur : Form
    {
        private readonly int idEtablissement;
        public FrmDetecteur()
        {
            InitializeComponent();
        }

        // surcharge du contrôleur : charger la fenêtre avec l'établissement sélectionné
        public FrmDetecteur(int idEtablissement)
        {
            InitializeComponent();
            this.idEtablissement = idEtablissement;
        }

        // Charge la liste des détecteur de l'établissement choisit précedemment au lancement de la fenêtre 

        private void FrmDetecteur_Load(object sender, EventArgs e)
        {
            ChargerDetecteurs();
        }

        // charger la liste des détecteurs de l'établissement
        private void ChargerDetecteurs()
        {
            try
            {
                // Connexion BDD 
                using (RadonContext db = new RadonContext())
                {
                    // Charger les détecteurs associés à l'établissement sélectionné
                    List<Detecteur> detecteurs = db.Detecteurs.Where(d => d.IdEtablissement == idEtablissement && d.DateRetrait == null).ToList();

                    // Afficher les détecteurs dans votre ListBox 
                    LsbListeDetecteurs.DataSource = detecteurs;
                }
            }
            catch (Exception ex)
            {
                // En cas d'erreur lors de la connexion, affichez un message d'erreur
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }

        //Bouton Ajouter Détecteur
        private void BtnAjouterDetecteur_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(TxtLocalisation.Text) || String.IsNullOrWhiteSpace(TxtLocalisation.Text))
                {
                    TxtLocalisation.Text = "";
                    throw new Exception("Renseignez la salle dans laquelle le détecteur est situé");
                }
                else
                {
                    string salle = TxtLocalisation.Text;
                    // Supposons que vous souhaitez créer une DateOnly avec la date actuelle
                    DateTime datePose = DateTime.Today;

                    // Insérer une nouvelle entrée dans la table Detecteurs
                    using (RadonContext db = new RadonContext())
                    {
                        // Créer une nouvelle instance de Detecteur et définir ses propriétés
                        Detecteur nouveauDetecteur = new Detecteur
                        {
                            NomPiece = TxtLocalisation.Text,
                            DatePose = datePose,
                            IdEtablissement = idEtablissement // Supposons que vous avez idEtablissement défini quelque part
                        };

                        // Ajouter le nouveau detecteur au contexte de la base de données
                        db.Detecteurs.Add(nouveauDetecteur);

                        // Enregistrer les modifications dans la base de données
                        db.SaveChanges();
                    }

                    MessageBox.Show($" Détecteur enregistré !\nSalle : {salle}, Date de pose : {datePose.Day}/{datePose.Month}/{datePose.Year}");
                    TxtLocalisation.Text = "";
                    ChargerDetecteurs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Bouton Supprimer Détecteur
        private void BtnSupprimerDetecteur_Click(object sender, EventArgs e)
        {
            try
            {
                Detecteur detecteur = (Detecteur)LsbListeDetecteurs.SelectedItem;

                // Comparaison entre la date de pose du détecteur et la date actuelle moins 80 jours
                DateTime datePose = detecteur.DatePose;
                DateTime dateActuelle = DateTime.Today;
                DateTime dateLimite = dateActuelle.AddDays(-80);

                if (datePose < dateLimite)
                {
                    using(RadonContext db = new RadonContext())
                    {
                        Detecteur detecteurUpdate = db.Detecteurs.Where(d => d.Id == detecteur.Id).FirstOrDefault();
                        detecteurUpdate.DateRetrait = dateActuelle;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Détecteur retiré.");
                    ChargerDetecteurs();
                }
                else
                {
                    MessageBox.Show("La date de pose est trop récente.\nImpossible de retirer le détecteur.");
                }
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
