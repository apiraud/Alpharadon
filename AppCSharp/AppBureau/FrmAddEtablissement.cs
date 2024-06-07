using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;

namespace AppBureau
{
    public partial class FrmAddEtablissement : Form
    {


        public FrmAddEtablissement()
        {
            InitializeComponent();
        }

        // bouton enregistrer
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChampsValides())
                {
                    // le technicien sélectionné dans la combobox
                    Utilisateur technicien = (Utilisateur)CbTechnicien.SelectedItem;
                    using (RadonContext db = new RadonContext())
                    {
                        Etablissement newEtablissement = new Etablissement
                        {
                            RaisonSociale = TxtRaisonSociale.Text,
                            FormeJuridique = TxtFormeJuridique.Text,
                            Siret = TxtSiret.Text,
                            Adresse = TxtAdresse.Text,
                            Mail = TxtMail.Text,
                            Telephone = TxtTelephone.Text,
                            IdTechnicien = technicien.Id
                        };
                        db.Etablissements.Add(newEtablissement);
                        db.SaveChanges();
                    }
                    // fermer la fenêtre
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // bouton annuler
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        // au chargement de la page
        private void FrmAddEtablissement_Load(object sender, EventArgs e)
        {
            // ajouter la liste des techinciens dans la combobox
            using (RadonContext db = new RadonContext())
            {
                List<Utilisateur> techniciens = db.Utilisateurs.Where(u => u.EstTechnicien == true).ToList();
                CbTechnicien.DataSource = techniciens;
            }
        }

        private bool ChampsValides()
        {
            // Vérification de la raison sociale
            if (string.IsNullOrWhiteSpace(TxtRaisonSociale.Text))
            {
                MessageBox.Show("Veuillez renseigner la raison sociale.");
                return false;
            }

            // Vérification de la forme juridique
            if (string.IsNullOrWhiteSpace(TxtFormeJuridique.Text))
            {
                MessageBox.Show("Veuillez renseigner la forme juridique.");
                return false;
            }

            // Vérification du Siret
            if (TxtSiret.Text.Length != 14)
            {
                MessageBox.Show("Le Siret doit comporter 14 caractères.");
                return false;
            }

            // Vérification de l'adresse
            if (string.IsNullOrWhiteSpace(TxtAdresse.Text))
            {
                MessageBox.Show("Veuillez renseigner l'adresse.");
                return false;
            }

            // Vérification du format du mail
            if (string.IsNullOrWhiteSpace(TxtMail.Text) || !IsValidEmail(TxtMail.Text))
            {
                MessageBox.Show("Veuillez renseigner un e-mail valide.");
                return false;
            }

            // Vérification du téléphone
            if (string.IsNullOrWhiteSpace(TxtTelephone.Text) || TxtTelephone.Text.Length != 10 || !IsValidPhoneNumber(TxtTelephone.Text))
            {
                MessageBox.Show("Veuillez renseigner un numéro de téléphone valide.");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            // la chaine est null ou vide ?
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // vérification format mail
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {

            return phoneNumber.All(char.IsDigit);
        }
    }
}
