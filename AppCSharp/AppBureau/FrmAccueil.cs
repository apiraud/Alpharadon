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

namespace AppBureau
{
    public partial class FrmAccueil : Form
    {

        
        public FrmAccueil()
        {
            InitializeComponent();
        }

        // Charge la liste des établissement au lancement de la fenêtre 
        private void FrmAccueil_Load(object sender, EventArgs e)
        {
            ChargerEtablissements();
            
        }

        // Déclarer idEtablissement en tant que champ de classe
        List<Etablissement> listEtablissements;
        private void ChargerEtablissements()
        {
            try
            {
                //récupération des établissements
                using (RadonContext db = new RadonContext())
                {
                    listEtablissements = db.Etablissements.ToList();
                    LsbEtablissement.DataSource = listEtablissements;
                }
            }
            catch (Exception ex)
            {
                // En cas d'erreur lors de la connexion, affichez un message d'erreur
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
            //si aucun élément n'est seléctionné dans la liste, impossible d'enregistrer un relevé
            LsbEtablissement.SelectedItem = null;
            BtnEnregisterReleve.Enabled = false;
        }


        // double click : voir conformité
        private void LsbEtablissement_DbClick(object sender, EventArgs e)
        {
            Etablissement etablissement = (Etablissement)LsbEtablissement.SelectedItem;
            MessageBox.Show("double click sur " + etablissement.RaisonSociale);
        }

        // ajouter un établissement
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            FrmAddEtablissement frmAddEtablissement = new FrmAddEtablissement();
            // Tant que le formulaire n'est pas fermé, le programme ne poursuit pas
            frmAddEtablissement.ShowDialog();
            ChargerEtablissements();

        }


        // classement des établissements
        private void BtnClassement_Click(object sender, EventArgs e)
        {
            try
            {
                // Créer un objet pour stocker les détails des établissements triés
                StringBuilder sb = new StringBuilder();

                // Récupérer les établissements avec une conformité définie, les trier par conformité
                var etablissementsTriee = listEtablissements
                    .Where(e => e.IdConformite.HasValue) // Filtrer ceux avec une conformité définie
                    .OrderByDescending(e => e.IdConformite) // Trier par conformité, de la pire (3) à la meilleure (1)
                    .ToList();

                // Utiliser le contexte de la base de données pour récupérer les détails de conformité
                using (RadonContext db = new RadonContext())
                {
                    // Parcourir chaque établissement trié
                    foreach (Etablissement etablissement in etablissementsTriee)
                    {
                        // Rechercher la conformité correspondant à l'établissement dans la base de données
                        Conformite conformite = db.Conformites.FirstOrDefault(c => c.Id == etablissement.IdConformite);

                        // Si une conformité est trouvée, ajouter les détails à StringBuilder
                        if (conformite != null)
                        {
                            sb.AppendLine($"Raison sociale : {etablissement.RaisonSociale}, Conformité : {conformite.Libelle}");
                        }
                    }
                }

                // Afficher les détails des établissements triés dans une boîte de message
                MessageBox.Show(sb.ToString(), "Liste des établissements", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Gérer les erreurs potentielles lors de l'exécution du code
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // enregistrer un relevé
        private void BtnEnregisterReleve_Click(object sender, EventArgs e)
        {
            Etablissement etablissement = (Etablissement)LsbEtablissement.SelectedItem;
            FrmReleve frmReleve = new FrmReleve(etablissement.Id);
            frmReleve.ShowDialog();
            ChargerEtablissements();
        }

        // sélection d'un établissement
        private void LsbEtablissement_Click(object sender, EventArgs e)
        {
            BtnEnregisterReleve.Enabled = true;
            //afficher sa conformité si il en a une, sinon vider et griser la textbox
            Etablissement etablissement = (Etablissement)LsbEtablissement.SelectedItem;
            using (RadonContext db = new RadonContext())
            {
                Conformite conformite = db.Conformites.FirstOrDefault(c => c.Id == etablissement.IdConformite);
                if(conformite != null)
                {
                    LblConformiteValeur.Text = conformite.Libelle;
                }
                else
                {
                    LblConformiteValeur.Text = "Aucune confirmité renseignée";
                }
            }

        }
    }
}
