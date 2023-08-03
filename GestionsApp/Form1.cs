using GestionsApp;
using Org.BouncyCastle.Crypto.Generators;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BCrypt.Net;
using System.Text.RegularExpressions;

namespace GestionsApp
{
    public partial class Form1 : Form
    {
        Fonctions Con;

        public Form1()
        {
            InitializeComponent();
            Con = new Fonctions();
        }
        private void EffacerChamps()
        {
            NomITb.Text = "";
            PassITb.Text = "";
            EmailTb.Text = "";
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = NomITb.Text;
            string motDePasse = PassITb.Text;
            string email = EmailTb.Text;

            // Vérifier si tous les champs sont remplis
            if (string.IsNullOrEmpty(nomUtilisateur) || string.IsNullOrEmpty(motDePasse) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            // Vérifier le format de l'adresse e-mail
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Veuillez entrer une adresse e-mail valide !");
                return;
            }


            // Hacher le mot de passe dans la base de donnée
            string MotDePasse = "";
            string motDePasseHache = BCrypt.Net.BCrypt.HashPassword(motDePasse);

            // Insérer les informations d'inscription dans la base de données
            try
            {
                string requete = "INSERT INTO Utilisateurs (NomUtilisateur, Email, MotDePasse) VALUES ('{0}', '{1}', '{2}')";
                requete = string.Format(requete, nomUtilisateur, email, motDePasseHache);

                Con.EnvoyerData(requete);
                MessageBox.Show("Inscription réussie !");
                EffacerChamps();

                // Naviguer vers la page de connexion
                Connexion connexionForm = new Connexion();
                connexionForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'inscription : " + ex.Message);
            }
        }

        private bool IsValidEmail(string email)
        {
            // Vérifier le format de l'e-mail

            if (email.Contains("@") && email.Contains("gmail") && email.Contains(".com"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            PassITb.UseSystemPasswordChar = true;
        }




        private void btnCon_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}