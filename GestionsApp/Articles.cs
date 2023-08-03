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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Globalization;

namespace GestionsApp
{
    public partial class Articles : Form
    {
        Fonctions Con;
        public Articles()
        {
            InitializeComponent();
            Con = new Fonctions();
            AfficherArticle();
            RecupererCategorie();
            RecupererFournisseur();
        }

        private void RecupererCategorie()
        {
            string Req = "Select * from CategorieTbl";
            CatCb.ValueMember = Con.RecupererData(Req).Columns["Id"].ToString();
            CatCb.DisplayMember = Con.RecupererData(Req).Columns["CatNom"].ToString();
            CatCb.DataSource = Con.RecupererData(Req);
        }

        private void RecupererFournisseur()
        {
            string Req = "Select * from FournisseurTbl";
            FournCb.ValueMember = Con.RecupererData(Req).Columns["Id"].ToString();
            FournCb.DisplayMember = Con.RecupererData(Req).Columns["F_Nom"].ToString();
            FournCb.DataSource = Con.RecupererData(Req);
        }

        private void AfficherArticle()
        {
            string Requete = "select * from ArticleTbl";
            ArticlesListe.DataSource = Con.RecupererData(Requete);
            //.DataSource = Con.RecupererData(Requete);
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Articles Obj = new Articles();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Fournisseurs Obj = new Fournisseurs();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories(this);
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Livraisons Obj = new Livraisons();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            Agents Obj = new Agents();
            Obj.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (PrTb.Text == "" || FournCb.SelectedIndex == -1 || QuantTb.Text == "" || dateAdd.Text == "" || SeuilTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Information Incomplete!!!");
            }
            else
            {
                try
                {
                    string Produit = PrTb.Text;
                    string Fournisseur = FournCb.Text;
                    string Quantite = QuantTb.Text;
                    DateTime Date = DateTime.ParseExact(dateAdd.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string Seuil = SeuilTb.Text;
                    string Categorie = CatCb.Text;


                    string Req = "Insert into ArticleTbl values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Req = string.Format(Req, Produit, Fournisseur, Quantite, Date.ToString("yyyy-MM-dd"), Seuil, Categorie);
                    Con.EnvoyerData(Req);
                    AfficherArticle();
                    MessageBox.Show("Article Enregistré!!!");


                    PrTb.Text = "";
                    FournCb.SelectedIndex = -1;
                    QuantTb.Text = "";
                    dateAdd.Text = "";
                    SeuilTb.Text = "";
                    CatCb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        string Cle = "";
        private void ArticlesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrTb.Text = ArticlesListe.SelectedRows[0].Cells[1].Value.ToString();
            FournCb.Text = ArticlesListe.SelectedRows[0].Cells[2].Value.ToString();
            QuantTb.Text = ArticlesListe.SelectedRows[0].Cells[3].Value.ToString();
            dateAdd.Text = ArticlesListe.SelectedRows[0].Cells[4].Value.ToString();
            SeuilTb.Text = ArticlesListe.SelectedRows[0].Cells[5].Value.ToString();
            CatCb.Text = ArticlesListe.SelectedRows[0].Cells[6].Value.ToString();

            if (QuantTb.Text == "")
            {
                Cle = "";
            }
            else
            {
                Cle = ArticlesListe.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (PrTb.Text == "" || FournCb.SelectedIndex == -1 || QuantTb.Text == "" || dateAdd.Text == "" || SeuilTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Information Incomplete!!!");
            }
            else
            {
                try
                {
                    string Produit = PrTb.Text;
                    string Fournisseur = FournCb.Text;
                    string Quantite = QuantTb.Text;
                    DateTime Date = DateTime.ParseExact(dateAdd.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string Seuil = SeuilTb.Text;
                    string Categorie = CatCb.Text;


                    string Req = "Update ArticleTbl set ArtNom='{0}', ArtFournisseur='{1}', Quantite='{2}', ArtDate='{3}', ArtSeuil='{4}', ArtCategorie='{5}' where Id='{6}'";
                    Req = string.Format(Req, Produit, Fournisseur, Quantite, Date.ToString("yyyy-MM-dd"), Seuil, Categorie, Cle);
                    Con.EnvoyerData(Req);
                    AfficherArticle();
                    MessageBox.Show("Article Modifié!!!");

                    PrTb.Text = "";
                    FournCb.SelectedIndex = -1;
                    QuantTb.Text = "";
                    dateAdd.Text = "";
                    SeuilTb.Text = "";
                    CatCb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

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
                    DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer cet Article?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        string Req = "delete from ArticleTbl where Id = '{0}'";
                        Req = string.Format(Req, Cle);
                        Con.EnvoyerData(Req);

                        AfficherArticle();
                        MessageBox.Show("Article Supprimé!!!");

                        PrTb.Text = "";
                        FournCb.SelectedIndex = -1;
                        QuantTb.Text = "";
                        dateAdd.Text = "";
                        SeuilTb.Text = "";
                        CatCb.Text = "";
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
