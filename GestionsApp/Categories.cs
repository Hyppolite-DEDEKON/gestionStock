using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionsApp
{
    public partial class Categories : Form
    {
        public Form pageOrigine;

        Fonctions Con;
        public Categories(Form pageOrigine)
        {
            InitializeComponent();
            Con = new Fonctions();
            AfficherVoiture();
            this.pageOrigine = pageOrigine;
        }

        private void AfficherVoiture()
        {
            string Requete = "select * from CategorieTbl";

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CategorieTb.Text == "")
            {
                MessageBox.Show("Information Incomplete!!!");
            }
            else
            {
                try
                {
                    string Categorie = CategorieTb.Text;

                    string Req = "Insert into CategorieTbl (CatNom) values (@categorie)";

                    using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(Req, connection))
                        {
                            // Ajout d'un paramètre pour la valeur de la catégorie
                            command.Parameters.AddWithValue("@categorie", Categorie);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Categorie Enregistré!!!");

                    CategorieTb.Text = "";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BtnRetour_Click_1(object sender, EventArgs e)
        {
            pageOrigine.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
