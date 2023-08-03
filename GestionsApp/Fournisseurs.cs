using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Jenga.Theme;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace GestionsApp
{
    public partial class Fournisseurs : Form
    {
        Fonctions Con;
        public Fournisseurs()
        {
            InitializeComponent();
            Con = new Fonctions();
            AfficherFournisseur();
        }

        private void AfficherFournisseur()
        {
            string Requete = "select * from FournisseurTbl";
            guna2DataGridView1.DataSource = Con.RecupererData(Requete);
            //.DataSource = Con.RecupererData(Requete);
        }

        private void label7Btn_Click(object sender, EventArgs e)
        {
            Articles Obj = new Articles();
            Obj.Show();
            this.Hide();
        }

        private void label8Btn_Click_1(object sender, EventArgs e)
        {
            Fournisseurs Obj = new Fournisseurs();
            Obj.Show();
            this.Hide();
        }

        private void label9Btn_Click_1(object sender, EventArgs e)
        {
            Categories Obj = new Categories(this);
            Obj.Show();
            this.Hide();
        }

        private void label10Btn_Click_1(object sender, EventArgs e)
        {
            Agents Obj = new Agents();
            Obj.Show();
            this.Hide();
        }

        private void btnLiv_Click(object sender, EventArgs e)
        {
            Livraisons Obj = new Livraisons();
            Obj.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (FName.Text == "" || FAdresse.Text == "" || FEmail.Text == "" || FTel.Text == "")
            {
                MessageBox.Show("Information Incomplete!!!");
            }
            else
            {
                try
                {
                    string Nom = FName.Text;
                    string Adresse = FAdresse.Text;
                    string Email = FEmail.Text;
                    string Telephone = FTel.Text;


                    string Req = "Insert into FournisseurTbl values('{0}','{1}','{2}','{3}')";
                    Req = string.Format(Req, Nom, Adresse, Email, Telephone);
                    Con.EnvoyerData(Req);
                    AfficherFournisseur();
                    MessageBox.Show("Fournisseur Enregistré!!!");
                    FName.Text = "";
                    FAdresse.Text = "";
                    FEmail.Text = "";
                    FTel.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        string Cle = "";
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FName.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            FAdresse.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            FEmail.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            FTel.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            if (FTel.Text == "")
            {
                Cle = "";
            }
            else
            {
                Cle = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (FName.Text == "" || FAdresse.Text == "" || FEmail.Text == "" || FTel.Text == "")
            {
                MessageBox.Show("Information Incomplete!!!");
            }
            else
            {
                try
                {
                    string Nom = FName.Text;
                    string Adresse = FAdresse.Text;
                    string Email = FEmail.Text;
                    string Telephone = FTel.Text;


                    string Req = "Update FournisseurTbl set F_Nom='{0}', F_Adresse='{1}', F_Email='{2}', F_Telephone='{3}' where Id='{4}'";
                    Req = string.Format(Req, Nom, Adresse, Email, Telephone, Cle);
                    Con.EnvoyerData(Req);
                    AfficherFournisseur();
                    MessageBox.Show("Fournisseur Modifié!!!");
                    FName.Text = "";
                    FAdresse.Text = "";
                    FEmail.Text = "";
                    FTel.Text = "";
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
                    DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer ce Fournisseur?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        string Req = "delete from FournisseurTbl where Id = '{0}'";
                        Req = string.Format(Req, Cle);
                        Con.EnvoyerData(Req);

                        AfficherFournisseur();
                        MessageBox.Show("Fournisseur Supprimé!!!");
                        FName.Text = "";
                        FAdresse.Text = "";
                        FEmail.Text = "";
                        FTel.Text = "";
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
