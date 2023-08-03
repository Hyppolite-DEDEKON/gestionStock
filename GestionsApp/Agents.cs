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

namespace GestionsApp
{
    public partial class Agents : Form
    {
        Fonctions Con;
        public Agents()
        {
            InitializeComponent();
            Con = new Fonctions();
            AfficherAgent();
        }

        private void AfficherAgent()
        {
            string Requete = "select * from AgentTbl";
            AgentListe.DataSource = Con.RecupererData(Requete);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AgentTb.Text == "" || TelAgTb.Text == "" || AdresseAgTb.Text == "")
            {
                MessageBox.Show("Information Incomplete!!!");
            }
            else
            {
                try
                {
                    string Nom = AgentTb.Text;
                    string Telephone = TelAgTb.Text;
                    string Adresse = AdresseAgTb.Text;


                    string Req = "Insert into AgentTbl values('{0}','{1}','{2}')";
                    Req = string.Format(Req, Nom, Telephone, Adresse);
                    Con.EnvoyerData(Req);
                    AfficherAgent();
                    MessageBox.Show("Agent Enregistré!!!");
                    AgentTb.Text = "";
                    TelAgTb.Text = "";
                    AdresseAgTb.Text = "";


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (AgentTb.Text == "" || TelAgTb.Text == "" || AdresseAgTb.Text == "")
            {
                MessageBox.Show("Information Incomplete!!!");
            }
            else
            {
                try
                {
                    string Nom = AgentTb.Text;
                    string Telephone = TelAgTb.Text;
                    string Adresse = AdresseAgTb.Text;


                    string Req = "Update AgentTbl set AgNom='{0}', AgTelephone='{1}', AgAdresse='{2}' where Id='{3}'";
                    Req = string.Format(Req, Nom, Telephone, Adresse);
                    Con.EnvoyerData(Req);
                    AfficherAgent();
                    MessageBox.Show("Agent Modifié!!!");
                    AgentTb.Text = "";
                    TelAgTb.Text = "";
                    AdresseAgTb.Text = "";


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        string Cle = "";
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
                    DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer ce Agent?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        string Req = "delete from AgentTbl where Id = '{0}'";
                        Req = string.Format(Req, Cle);
                        Con.EnvoyerData(Req);

                        AfficherAgent();
                        MessageBox.Show("Agent Supprimé!!!");
                        AgentTb.Text = "";
                        TelAgTb.Text = "";
                        AdresseAgTb.Text = "";
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

        private void AgentListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AgentTb.Text = AgentListe.SelectedRows[0].Cells[1].Value.ToString();
            TelAgTb.Text = AgentListe.SelectedRows[0].Cells[2].Value.ToString();
            AdresseAgTb.Text = AgentListe.SelectedRows[0].Cells[3].Value.ToString();
            if (TelAgTb.Text == "")
            {
                Cle = "";
            }
            else
            {
                Cle = AgentListe.SelectedRows[0].Cells[0].Value.ToString();
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
