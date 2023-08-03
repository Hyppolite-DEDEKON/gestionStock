using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionsApp
{
    public partial class Connexion : Form
    {
        Fonctions Con;

        public Connexion()
        {
            InitializeComponent();
            Con = new Fonctions();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = NomTb.Text;
            string motDePasse = PassITb.Text;

            // Vérifier si tous les champs sont remplis
            if (string.IsNullOrEmpty(nomUtilisateur) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            // Récupérer les informations d'utilisateur depuis la base de données
            try
            {
                string requete = "SELECT MotDePasse FROM Utilisateurs WHERE NomUtilisateur = '{0}'";
                requete = string.Format(requete, nomUtilisateur);
                DataTable resultat = Con.RecupererData(requete);

                // Vérifier si l'utilisateur existe dans la base de données
                if (resultat.Rows.Count > 0)
                {
                    string motDePasseHache = resultat.Rows[0]["MotDePasse"].ToString();

                    // Vérifier le mot de passe
                    bool motDePasseValide = BCrypt.Net.BCrypt.Verify(motDePasse, motDePasseHache);

                    if (motDePasseValide)
                    {
                        Articles Obj = new Articles();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect !");
                        PassITb.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur incorrect !");
                    NomTb.Text = "";
                    PassITb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la connexion : " + ex.Message);
            }
        }

        private void PassITb_TextChanged(object sender, EventArgs e)
        {
            PassITb.UseSystemPasswordChar = true;
        }

        private void btnInscr_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
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
