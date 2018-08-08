using System; 
using System.Collections.Generic;
using System.Linq;
using System.Web; 
using System.Web.UI; 
using System.Web.UI.WebControls;  
// Librairie MySQL ajoutée dans les références. 
using MySql.Data.MySqlClient;
public partial class index : System.Web.UI.Page
{
   
        //  lbl_msg.Text = "OOOK";
        //DropDownList1.Items.Add(new ListItem { Text = "A", Value = "1" });
        //DropDownList1.Items.Add(new ListItem { Text = "AX", Value = "2" });



    private MySqlConnection connection;
    // Méthode pour initialiser la connexion    
    private void InitConnexion()
    {
        string connectionString = "SERVER=127.0.0.1; DATABASE=not; UID=root; PASSWORD=";
        this.connection = new MySqlConnection(connectionString);
    }
    //Méthode appellé au chargement de la page     
    protected void Page_Load(object sender, EventArgs e)
    {


        this.InitConnexion();
    }

    //Méthode appellé lors du clique    
    protected void btn_save_Click(object sender, EventArgs e)
    {

 
        //On recupere les variables dans le formulaires    
        string f_name1 = this.TextBox1.Text;
        string f_name2 = this.TextBox2.Text;
        //string f_name3 = this.TextBox3.Text; 
        string f_name4 = this.TextBox4.Text;

        if (f_name1 != "" && f_name2 != "" && f_name4 != "")
        {
           //debut dropcategori DropDownList1.Items.FindByValue

     
            if (DropDownList2.SelectedItem.Value == "1" )
            {
                  
              
                try
                {
                    // Ouverture de la connexion SQL         
                    this.connection.Open();
                    // Création d'une commande SQL en fonction de l'objet connection     
                    MySqlCommand cmd = this.connection.CreateCommand();
                    // Requête SQL;
                    cmd.CommandText = "INSERT INTO notification_1 (sujet_notification_1, description_notification_1, message_notification_1, image_notification_1, categorie_notification_1) VALUES (@name1, @name2, @name4, @name5, @name6)";
                    // utilisation de l'objet contact passé en paramètre   
                    cmd.Parameters.AddWithValue("@name1", f_name1);
                    cmd.Parameters.AddWithValue("@name2", f_name2);
                    //  cmd.Parameters.AddWithValue("@name3", f_name3); 
                    cmd.Parameters.AddWithValue("@name4", f_name4);
                    cmd.Parameters.AddWithValue("@name5", f_name4);
                    cmd.Parameters.AddWithValue("@name6", f_name4);

                    // Exécution de la commande SQL   
                    cmd.ExecuteNonQuery();

                    //Envoi d'un message     
                    lbl_msg.Text = "Enregistrement effectue";
                    this.TextBox1.Text = "";
                    this.TextBox2.Text = "";
                    this.TextBox4.Text = "";

                    // Fermeture de la connexion   
                    this.connection.Close();
                }
                catch
                {
                    /*Gestion des erreurs*/
                    lbl_msg.Text = "Erreur lors de l'enregistrement try";
                    this.TextBox1.Text = "";
                    this.TextBox2.Text = "";
                    this.TextBox4.Text = "";
                }


            }
            //end if catego
        }
        else
        {
            /*Gestion des erreurs*/
        
            lbl_msg.Text = "Tous les champs doivent être remplir Obligatoirement !";
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox4.Text = "";
        }




        //envoi de email
        //recuperation


    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        lbl_msg.Text = "OK";
        DropDownList1.Items.Add(new ListItem { Text = "algebre", Value = "1" });
        DropDownList1.Items.Add(new ListItem { Text = "analyse", Value = "2" });
    }
    protected void DropDownList_TextChange(object sender, EventArgs e)
    {

        lbl_msg.Text = "OOOK";
        this.DropDownList1.Items.Add(new ListItem { Text = "A", Value = "1" });
        DropDownList1.Items.Add(new ListItem { Text = "AX", Value = "2" });

    }

  
}
   