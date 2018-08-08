using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Librairie MySQL ajoutée dans les références.
using MySql.Data.MySqlClient;

public partial class user : System.Web.UI.Page
{


    private MySqlConnection connection;
// Méthode pour initialiser la connexion
private void InitConnexion()
{
    string connectionString = "SERVER=127.0.0.1; DATABASE=not; UID=root; PASSWORD=";
this.connection = new MySqlConnection(connectionString);
}


    protected void Page_Load(object sender, EventArgs e)
    {
      Label2.Text = "";

        this.InitConnexion();

    }
    protected void Souscrir(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {
            Label2.Text = "";



            //licence1
            if (licence1.Checked)
            {

                //try
                //{
                string email = TextBox1.Text;
                // Ouverture de la connexion SQL

                this.connection.Open();
                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();


                // Requête SQL
                cmd.CommandText = "INSERT INTO licence_1(email_l1) VALUES (@email)";
                cmd.Parameters.AddWithValue("@email", email);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Requête SQL
                cmd.CommandText = "SELECT * FROM licence_1 ORDER BY id_l1 DESC LIMIT 1";

                // Exécution de la commande SQL
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string id = reader.GetString("id_l1");
                // Fermeture de la connexion
                this.connection.Close();


                if (CheckBox1.Checked)
                {
                    // Ouverture de la connexion SQL
                    this.connection.Open();
                    cmd.CommandText = "UPDATE licence_1 SET algebre_l1 = @1 WHERE id_l1 = @id";
                    cmd.Parameters.AddWithValue("@1", 1);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    this.connection.Close();

                }
                if (CheckBox3.Checked)
                {


                    this.connection.Open();
                    cmd.CommandText = "UPDATE licence_1 SET logique_l1 = @3 WHERE id_l1 = @id3";
                    cmd.Parameters.AddWithValue("@3", 1);
                    cmd.Parameters.AddWithValue("@id3", id);
                    cmd.ExecuteNonQuery();
                    this.connection.Close();

                }

            if (CheckBox4.Checked)
            {
                this.connection.Open();
                cmd.CommandText = "UPDATE licence_1 SET architecture_l1 = @4 WHERE id_l1 = @id4";
                cmd.Parameters.AddWithValue("@4", 1);
                cmd.Parameters.AddWithValue("@id4", id);
                cmd.ExecuteNonQuery();
                this.connection.Close();
            }
            if (CheckBox5.Checked)
            {

                this.connection.Open();
                //UPDATE licence_1 SET logique_l1 = 1 WHERE id_l1 = 18
                cmd.CommandText = "UPDATE licence_1 SET analyse_l1 = @5 WHERE id_l1 = @id5";
                cmd.Parameters.AddWithValue("@5", 1);
                cmd.Parameters.AddWithValue("@id5", id);
                cmd.ExecuteNonQuery();
                this.connection.Close();
            }
            if (CheckBox6.Checked)
            {

              this.connection.Open();
              //UPDATE licence_1 SET logique_l1 = 1 WHERE id_l1 = 18
              cmd.CommandText = "UPDATE licence_1 SET projet_perso_l1 = @6 WHERE id_l1 = @id6";
              cmd.Parameters.AddWithValue("@6", 1);
              cmd.Parameters.AddWithValue("@id6", id);
              cmd.ExecuteNonQuery();
              this.connection.Close();

            }

            }


        //licence2
        if (licence2.Checked)
            {

                //try
                //{
                string email = TextBox1.Text;
                // Ouverture de la connexion SQL

                this.connection.Open();
                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();


                // Requête SQL
                cmd.CommandText = "INSERT INTO licence_2 (email_l2) VALUES (@email)";
                cmd.Parameters.AddWithValue("@email", email);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Requête SQL
                cmd.CommandText = "SELECT * FROM licence_2 ORDER BY id_l2 DESC LIMIT 1";

                // Exécution de la commande SQL
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string id = reader.GetString("id_l2");
                // Fermeture de la connexion
                this.connection.Close();


                if (CheckBox7.Checked)
                {
                    // Ouverture de la connexion SQL
                    this.connection.Open();
                    //Label1.Text = id;
                    cmd.CommandText = "UPDATE licence_2 SET php_l2 = @7 WHERE id_l2 = @id7";
                    cmd.Parameters.AddWithValue("@7", 1);
                    cmd.Parameters.AddWithValue("@id7", id);
                    cmd.ExecuteNonQuery();
                    this.connection.Close();

                }
                if (CheckBox8.Checked)
                {


                    this.connection.Open();
                    cmd.CommandText = "UPDATE licence_2 SET algebre_l2 = @8 WHERE id_l2 = @id8";
                    cmd.Parameters.AddWithValue("@8", 1);
                    cmd.Parameters.AddWithValue("@id8", id);
                    cmd.ExecuteNonQuery();
                    this.connection.Close();

                }

            if (CheckBox9.Checked)
            {
                this.connection.Open();
                cmd.CommandText = "UPDATE licence_2 SET analyses_l2 = @9 WHERE id_l2 = @id9";
                cmd.Parameters.AddWithValue("@9", 1);
                cmd.Parameters.AddWithValue("@id9", id);
                cmd.ExecuteNonQuery();
                this.connection.Close();
            }
            if (CheckBox10.Checked)
            {

                this.connection.Open();
                //UPDATE licence_1 SET logique_l1 = 1 WHERE id_l1 = 18
                cmd.CommandText = "UPDATE licence_2 SET comptabilite_l2 = @10 WHERE id_l2 = @id10";
                cmd.Parameters.AddWithValue("@10", 1);
                cmd.Parameters.AddWithValue("@id10", id);
                cmd.ExecuteNonQuery();
                this.connection.Close();
            }
            if (CheckBox11.Checked)
            {

              this.connection.Open();
              cmd.CommandText = "UPDATE licence_2 SET c_l2 = @17 WHERE id_l2 = @id17";
              cmd.Parameters.AddWithValue("@17", 1);
              cmd.Parameters.AddWithValue("@id17", id);
              cmd.ExecuteNonQuery();
              this.connection.Close();

            }

            }





    //licence3
        if (licence3.Checked)
            {

                //try
                //{
                string email = TextBox1.Text;
                // Ouverture de la connexion SQL

                this.connection.Open();
                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();


                // Requête SQL
                cmd.CommandText = "INSERT INTO licence_3 (email_l3) VALUES (@email)";
                cmd.Parameters.AddWithValue("@email", email);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Requête SQL
                cmd.CommandText = "SELECT * FROM licence_3 ORDER BY id_l3 DESC LIMIT 1";

                // Exécution de la commande SQL
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string id = reader.GetString("id_l3");
                // Fermeture de la connexion
                this.connection.Close();


                if (CheckBox12.Checked)
                {


                    this.connection.Open();
                    cmd.CommandText = "UPDATE licence_3 SET grh_l3 = @12 WHERE id_l3 = @id12";
                    cmd.Parameters.AddWithValue("@12", 1);
                    cmd.Parameters.AddWithValue("@id12", id);
                    cmd.ExecuteNonQuery();
                    this.connection.Close();

                }

            if (CheckBox13.Checked)

            {
                this.connection.Open();
                cmd.CommandText = "UPDATE licence_3 SET isi_l3 = @13 WHERE id_l3 = @id13";
                cmd.Parameters.AddWithValue("@13", 1);
                cmd.Parameters.AddWithValue("@id13", id);
                cmd.ExecuteNonQuery();
                this.connection.Close();
            }
            if (CheckBox14.Checked)
            {

                this.connection.Open();
                //UPDATE licence_1 SET logique_l1 = 1 WHERE id_l1 = 18
                cmd.CommandText = "UPDATE licence_3 SET php_l3 = @14 WHERE id_l3 = @id14";
                cmd.Parameters.AddWithValue("@14", 1);
                cmd.Parameters.AddWithValue("@id14", id);
                cmd.ExecuteNonQuery();
                this.connection.Close();
            }
            if (CheckBox15.Checked)
            {

              this.connection.Open();
              //UPDATE licence_1 SET logique_l1 = 1 WHERE id_l1 = 18
              cmd.CommandText = "UPDATE licence_3 SET asp_l3 = @15 WHERE id_l3 = @id15";
              cmd.Parameters.AddWithValue("@15", 1);
              cmd.Parameters.AddWithValue("@id15", id);
              cmd.ExecuteNonQuery();
              this.connection.Close();

            }
            if (CheckBox16.Checked)
            {

              this.connection.Open();
              //UPDATE licence_1 SET logique_l1 = 1 WHERE id_l1 = 18
              cmd.CommandText = "UPDATE licence_3 SET optimisation_l3	 = @16 WHERE id_l3 = @id16";
              cmd.Parameters.AddWithValue("@16", 1);
              cmd.Parameters.AddWithValue("@id16", id);
              cmd.ExecuteNonQuery();
              this.connection.Close();

            }
}
} else {
  Label2.Text = "Ce champ ne doit pas être vide !";
}


}
        }
