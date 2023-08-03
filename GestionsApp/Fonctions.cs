using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionsApp
{
    internal class Fonctions
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private string ConStr;
        private SqlDataAdapter sda;
        public string ConnectionString => ConStr;
        public Fonctions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\GestionDeStock.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }


        public DataTable RecupererData(string Req) 
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Req, Con);
            sda.Fill(dt);
            return dt;
        }

        public int EnvoyerData(string Req) 
        {
            int cnt = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            cmd.CommandText = Req;
            cnt = cmd.ExecuteNonQuery();
            Con.Close ();
            return cnt;
        }

        public string RecupererDonnee(string requete)
        {
            string resultat = null;
            using (SqlCommand commande = new SqlCommand(requete, Con))
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                object valeur = commande.ExecuteScalar();
                if (valeur != null)
                {
                    resultat = valeur.ToString();
                }
            }
            return resultat;
        }


        private DataTable ObtenirData(string requete)
        {
            DataTable dataTable = new DataTable();

            return dataTable;
        }


    }
}
