using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace GestionsApp
{
    public partial class Livraisons : Form
    {
        Fonctions Con;
        public Livraisons()
        {
            InitializeComponent();
            Con = new Fonctions();
            AfficherLivraison();
            RecupererArticle();
            RecupererAgent();
        }

        private void RecupererArticle()
        {
            string Req = "Select Id, ArtNom, Quantite from ArticleTbl"; // Sélectionnez également la colonne "Quantite"
            DataTable dt = Con.RecupererData(Req);


            ArtCb.ValueMember = Con.RecupererData(Req).Columns["Id"].ToString();
            ArtCb.DisplayMember = Con.RecupererData(Req).Columns["ArtNom"].ToString();
            ArtCb.DataSource = Con.RecupererData(Req);
        }


        private void RecupererAgent()
        {
            string Req = "Select * from AgentTbl";
            AgentCb.ValueMember = Con.RecupererData(Req).Columns["Id"].ToString();
            AgentCb.DisplayMember = Con.RecupererData(Req).Columns["AgNom"].ToString();
            AgentCb.DataSource = Con.RecupererData(Req);
        }

        private void AfficherLivraison()
        {
            string Requete = "select * from livraisonTbl";
            LivraisonListe.DataSource = Con.RecupererData(Requete);
            //.DataSource = Con.RecupererData(Requete);
        }

        private void label11Btn_Click(object sender, EventArgs e)
        {
            Livraisons Obj = new Livraisons();
            Obj.Show();
            this.Hide();
        }

        private void label10Btn_Click(object sender, EventArgs e)
        {
            Agents Obj = new Agents();
            Obj.Show();
            this.Hide();
        }

        private void label9Btn_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories(this);
            Obj.Show();
            this.Hide();
        }

        private void label8Btn_Click(object sender, EventArgs e)
        {
            Fournisseurs Obj = new Fournisseurs();
            Obj.Show();
            this.Hide();
        }

        private void label7Btn_Click(object sender, EventArgs e)
        {
            Articles Obj = new Articles();
            Obj.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (QtTb.Text == "" || ArtCb.SelectedIndex == -1 || dateLiv.Text == "" || AgentCb.Text == "")
            {
                MessageBox.Show("Information Incomplete!!!");
            }
            else
            {
                try
                {

                    string Article = ArtCb.Text;
                    string QuantiteLivre = QtTb.Text;
                    DateTime Date = DateTime.ParseExact(dateLiv.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dateLivraison = dateLiv.Text;
                    string Agent = AgentCb.Text;



                    // ... Code pour mettre à jour la quantité dans la table ArticleTbl ...
                    if (int.TryParse(QtTb.Text, out int quantiteLivreInt))
                    {
                        DataRowView selectedRow = (DataRowView)ArtCb.SelectedItem;
                        string quantiteActuelleStr = selectedRow["Quantite"].ToString();

                        if (int.TryParse(quantiteActuelleStr, out int quantiteActuelleInt))
                        {
                            // Vérifier si la quantité actuelle est suffisante pour effectuer la livraison
                            if (quantiteActuelleInt >= quantiteLivreInt)
                            {
                                int nouvelleQuantite = quantiteActuelleInt - quantiteLivreInt;

                                string updateReq = "Update ArticleTbl set Quantite = {0} where Id = '{1}'";
                                updateReq = string.Format(updateReq, nouvelleQuantite, selectedRow["Id"]);
                                Con.EnvoyerData(updateReq);

                                string Req = "Insert into LivraisonTbl (Article, Quantite, Date, Agent) values('{0}','{1}','{2}','{3}')";
                                Req = string.Format(Req, Article, QuantiteLivre, Date.ToString("yyyy-MM-dd"), Agent);
                                Con.EnvoyerData(Req);
                                AfficherLivraison();
                                MessageBox.Show("Livraison Enregistrée!!!");


                                QtTb.Text = "";
                                ArtCb.SelectedIndex = -1;
                                dateLiv.Text = "";
                                AgentCb.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Quantité insuffisante pour effectuer la livraison.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur de conversion de la quantité actuelle de l'article.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur de conversion de la quantité livrée.");
                    }
                    ArtCb.Refresh();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
           ;
        }


        private void stockCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ArtCb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ArtCb.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)ArtCb.SelectedItem;
                string quantite = selectedRow["Quantite"].ToString();

                stockCb.Text = quantite;
            }
        }

        string Cle;
        private void LivraisonListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ArtCb.Text = LivraisonListe.SelectedRows[0].Cells[1].Value.ToString();
            QtTb.Text = LivraisonListe.SelectedRows[0].Cells[2].Value.ToString();

            string dateLivraisonStr = LivraisonListe.SelectedRows[0].Cells[3].Value.ToString();
            if (DateTime.TryParseExact(dateLivraisonStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateLivraison))
            {
                dateLiv.Text = dateLivraison.ToString("dd/MM/yyyy");
            }

            if (QtTb.Text == "")
            {
                Cle = "";
            }
            else
            {
                Cle = LivraisonListe.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void LivraisonListe_SelectionChanged(object sender, EventArgs e)
        {
            // Mise à jour du combobox AgentCb lorsque la sélection change dans le tableau LivraisonListe
            if (LivraisonListe.SelectedRows.Count > 0)
            {
                AgentCb.Text = LivraisonListe.SelectedRows[0].Cells[4].Value.ToString();
            }
        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            if (Cle == "")
            {
                MessageBox.Show("Information Incomplete!!");
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette Livraison?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Récupérer la quantité livrée de la livraison à supprimer
                        string selectReq = "SELECT Quantite FROM LivraisonTbl WHERE Id = '{0}'";
                        selectReq = string.Format(selectReq, Cle);
                        DataTable dt = Con.RecupererData(selectReq);

                        if (dt.Rows.Count > 0)
                        {
                            // Convertir la quantité livrée en entier
                            if (int.TryParse(dt.Rows[0]["Quantite"].ToString(), out int quantiteLivreInt))
                            {
                                DataRowView selectedRow = (DataRowView)ArtCb.SelectedItem;
                                string quantiteActuelleStr = selectedRow["Quantite"].ToString();

                                if (int.TryParse(quantiteActuelleStr, out int quantiteActuelleInt))
                                {
                                    // Ajouter la quantité livrée à la quantité actuelle
                                    int nouvelleQuantite = quantiteActuelleInt + quantiteLivreInt;

                                    // Mettre à jour la quantité dans la table ArticleTbl
                                    string updateReq = "UPDATE ArticleTbl SET Quantite = {0} WHERE Id = '{1}'";
                                    updateReq = string.Format(updateReq, nouvelleQuantite, selectedRow["Id"]);
                                    Con.EnvoyerData(updateReq);

                                    // Supprimer la livraison de la table LivraisonTbl
                                    string deleteReq = "DELETE FROM LivraisonTbl WHERE Id = '{0}'";
                                    deleteReq = string.Format(deleteReq, Cle);
                                    Con.EnvoyerData(deleteReq);

                                    // Actualiser la liste des livraisons
                                    AfficherLivraison();

                                    MessageBox.Show("Livraison Supprimée");
                                }
                                else
                                {
                                    MessageBox.Show("Erreur de conversion de la quantité actuelle de l'article.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erreur de conversion de la quantité livrée.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La livraison avec l'identifiant spécifié n'a pas été trouvée.");
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Suppression annulée!!");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
            this.Close();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (QtTb.Text == "" || ArtCb.SelectedIndex == -1 || dateLiv.Text == "" || AgentCb.Text == "")
            {
                MessageBox.Show("Information Incomplete!!!");
            }
            else
            {
                try
                {
                    string Article = ArtCb.Text;
                    string QuantiteLivre = QtTb.Text;
                    DateTime Date = DateTime.ParseExact(dateLiv.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dateLivraison = dateLiv.Text;
                    string Agent = AgentCb.Text;

                    // Récupérer l'identifiant de la livraison sélectionnée
                    int selectedArticle = GetSelectedLivraisonId();

                    // Vérifier si une ligne est sélectionnée dans le DataGridView
                    if (selectedArticle == -1)
                    {
                        MessageBox.Show("Veuillez sélectionner une livraison.");
                        return;
                    }

                    // Récupérer l'ancienne quantité livrée
                    int oldQuantity = GetOldQuantity(selectedArticle);

                    // Calculer la différence entre l'ancienne et la nouvelle quantité livrée
                    int newQuantity = int.Parse(QuantiteLivre);
                    int quantityChange = newQuantity - oldQuantity;

                    // Mettre à jour la quantité dans la table LivraisonTbl
                    string updateReq = "UPDATE LivraisonTbl SET Quantite = {0} WHERE Id = '{1}'";
                    updateReq = string.Format(updateReq, newQuantity, selectedArticle);
                    Con.EnvoyerData(updateReq);

                    // Mettre à jour la quantité dans la table ArticleTbl de manière inversement proportionnelle
                    UpdateArticleQuantity(Article, quantityChange);

                    AfficherLivraison();
                    MessageBox.Show("Livraison Modifiée!!!");

                    QtTb.Text = "";
                    ArtCb.SelectedIndex = -1;
                    dateLiv.Text = "";
                    AgentCb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        void UpdateArticleQuantity(string article, int quantityChange)
        {
            string query = "UPDATE ArticleTbl SET Quantite = Quantite - @quantityChange WHERE ArtNom = @article";
            using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@quantityChange", quantityChange);
                    command.Parameters.AddWithValue("@article", article);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private int GetOldQuantity(int livraisonId)
        {
            int oldQuantity = 0;
            string query = "SELECT Quantite FROM LivraisonTbl WHERE Id=@livraisonId";
            using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@livraisonId", livraisonId);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            oldQuantity = reader.GetInt32(0);
                        }
                    }
                }
            }
            return oldQuantity;
        }

        private int GetSelectedLivraisonId()
        {
            if (LivraisonListe.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(LivraisonListe.SelectedRows[0].Cells["Id"].Value);
            }
            return -1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
