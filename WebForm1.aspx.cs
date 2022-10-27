using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Etudiant
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static SQLiteConnection connection;
        // Initialisation d'un list Array de type Personne
        List<Personne> personnes = new List<Personne>();
        // Formater la date sous forme de dd/mm/yyyy  puis declaration et initialisation d'un variable date de type DateTime
        DateTime date = DateTime.Today;
        // upload des infos dans un fichier et afficher dans un listBox sur l'ecran 
        protected void Page_Load(object sender, EventArgs e)
        {
            String Time = date.ToString("dd/MM/yyyy");
            TextBoxDateCreer.Text = Time;
            CreateTable(connection);
            connection = CreateConnection();
            FILLDGV();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        public void Cancel()
        {
            TextBoxNom.Text = String.Empty;
            TextBoxPrenom_1.Text = String.Empty;
            TextBoxPrenom_2.Text = String.Empty;
            TextBoxAge.Text = String.Empty;
            TextBoxNationalite.Text = String.Empty;
            TextBoxAdresse.Text = String.Empty;
            TextBoxVille.Text = String.Empty;
            TextBoxPays.Text = String.Empty;
            TextBoxTelephone.Text = String.Empty;
            TextBoxDateCreer.Text = String.Empty;
        }
        // Create Database
        static void CreateTable(SQLiteConnection conn)
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            ////This will strip just the working path name:
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string dataP = System.IO.Path.Combine(strWorkPath, "Personne.db");
            string conne = $"Data Source={dataP}";
            conn = new SQLiteConnection(conne);
            string Createsql = "CREATE TABLE IF NOT EXISTS Personne( id INT, Nom VARCHAR(20), Prenom1 VARCHAR(20), Prenom2 VARCHAR(20)," +
                " Age INTEGER , Nationalite VARCHAR(20), Adresse VARCHAR(20), Ville VARCHAR(20),Pays VARCHAR(20), Telephone VARCHAR(20) )";
           // CreateConnection();
            conn.Open();
            SQLiteCommand sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();


        }

       public void FILLDGV()
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            ////This will strip just the working path name:
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string dataP = System.IO.Path.Combine(strWorkPath, "Personne.db");

            string conne = $"Data Source={dataP}";

            SQLiteConnection con = new SQLiteConnection(conne);
            con.Open();
            string query = "Select Nom,Prenom1,Prenom2,Age,Telephone From Personne";
            SQLiteDataAdapter da = new SQLiteDataAdapter(query,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;
            GridView.DataBind();
            con.Close();
        }

        // INSERT IN DATABASE
        static void InsertData(SQLiteConnection conn,  Personne personne)
        {
            
            string txtSqlQuery = "INSERT INTO Personne ( Nom , Prenom1 , Prenom2 ," +
                " Age  , Nationalite, Adresse, Ville,Pays , Telephone) " +
                "VALUES ( @Nom, @Prenom1, @Prenom2," +
                "@Age, @Nationalite, @Adresse, @Ville, @Pays, @Telephone)";

            SQLiteCommand command = new SQLiteCommand(txtSqlQuery, conn);
            command.Parameters.AddWithValue("@Nom", personne.Nom);
            command.Parameters.AddWithValue("@Prenom1", personne.Prenom1);
            command.Parameters.AddWithValue("@Prenom2", personne.Prenom2);
            command.Parameters.AddWithValue("@Age", personne.Age);
            command.Parameters.AddWithValue("@Nationalite", personne.Nationalite);
            command.Parameters.AddWithValue("@Adresse", personne.AdresseRue);
            command.Parameters.AddWithValue("@Ville", personne.ville);
            command.Parameters.AddWithValue("@Pays", personne.Pays);
            command.Parameters.AddWithValue("@Telephone", personne.Telephone);        
            command.ExecuteNonQuery();

        }

        // Read Data in Database
        public static List<Personne> GetData()
        {
            List<Personne> p = new List<Personne>();
            SQLiteCommand cmd = new SQLiteCommand("Select * From Personne", connection);

            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string Nom = rd.GetString(0);
                string Prenom1 = rd.GetString(1);
                string Prenom2 = rd.GetString(2);
                int Age = rd.GetInt16(3);
                string Nationalite = rd.GetString(4);
                string AdresseRue = rd.GetString(5);
                string Ville = rd.GetString(6);
                string Pays = rd.GetString(7);
                string Telephone = rd.GetString(8);
                Personne P = new Personne(Nom, Prenom1, Prenom2, Age, AdresseRue, Nationalite, Ville, Pays, Telephone);
                p.Add(P);

            }


            return p;
        }

        // Create Connection
        public static SQLiteConnection CreateConnection()
        {

            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            ////This will strip just the working path name:
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string dataP = System.IO.Path.Combine(strWorkPath, "Personne.db");

            string conne = $"Data Source={dataP}";

            // Create a new database connection:
            SQLiteConnection con = new SQLiteConnection(conne);
            // Open the connection:
            con.Open();

            return con;

        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string Nom = TextBoxNom.Text;
            string Prenom = TextBoxPrenom_1.Text;
            string Prenom2 = TextBoxPrenom_2.Text;
            var Age = int.Parse(TextBoxAge.Text);
            string AdresseRue = TextBoxAdresse.Text;
            string Nationalite = TextBoxNationalite.Text;
            string Ville = TextBoxVille.Text;
            string Pays = TextBoxPays.Text;
            string Telephone = TextBoxTelephone.Text;
            string DateCreer = TextBoxDateCreer.Text;


            // Declaration et initialisation d'u variable personne de Type Personne qui est une classe
            Personne personne = new Personne(Nom, Prenom, Prenom2, Age, AdresseRue, Nationalite, Ville, Pays, Telephone, DateCreer) ;
            personne.Nom = Nom;
            personne.Prenom1 = Prenom;
            personne.Prenom2 = Prenom2;
            personne.Age = Age;
            personne.AdresseRue = AdresseRue;
            personne.Nationalite = Nationalite;
            personne.ville = Ville;
            personne.Pays = Pays;
            personne.Telephone = Telephone;
            personne.Date = DateCreer;
            personnes.Add(personne);
            InsertData(connection,personne);
            Cancel();
        }
    }
}