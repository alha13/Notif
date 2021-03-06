﻿using System; 
using System.Collections.Generic;
using System.Linq;
using System.Web; 
using System.Web.UI; 
using System.Web.UI.WebControls;  
// Librairie MySQL ajoutée dans les références. 
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;
public partial class index : System.Web.UI.Page
{
   
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

        MySqlCommand cmd = this.connection.CreateCommand();
        //On recupere les variables dans le formulaires    
        string f_name1 = this.TextBox1.Text;
        string f_name2 = this.TextBox2.Text;
        string f_name4 = this.TextBox4.Text;
       // string f_name5 = this.TextBox1.Text;
       // string f_name5 = "a";
        string f_name6 = DropDownList1.SelectedItem.Text;

        string strname = FileUpload1.FileName.ToString();
        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/upload/") + strname);
        string strnamefull = "upload/" + strname;

        if (f_name1 != "" && f_name2 != "" && f_name4 != "")
        {


            //        LICENCE 1 ------------------------- debut dropcategori DropDownList1.Items.FindByValue 
            if (DropDownList2.SelectedItem.Value == "1")
            {


                //try
                //{
                // Ouverture de la connexion SQL         
                this.connection.Open();
                // Création d'une commande SQL en fonction de l'objet connection     
                //MySqlCommand cmd = this.connection.CreateCommand();
                // Requête SQL;
                cmd.CommandText = "INSERT INTO notification_1 (sujet_notification_1, description_notification_1, message_notification_1, image_notification_1, categorie_notification_1) VALUES (@name1, @name2, @name4, @name5, @name6)";
                // utilisation de l'objet contact passé en paramètre   
                cmd.Parameters.AddWithValue("@name1", f_name1);
                cmd.Parameters.AddWithValue("@name2", f_name2);
                //  cmd.Parameters.AddWithValue("@name3", f_name3); 
                cmd.Parameters.AddWithValue("@name4", f_name4);
                cmd.Parameters.AddWithValue("@name5", strnamefull);
                cmd.Parameters.AddWithValue("@name6", f_name6);

                // Exécution de la commande SQL   
                cmd.ExecuteNonQuery();
 
                this.connection.Close();
             

                //1
                //envoi email
                if (DropDownList1.SelectedItem.Text == "Algebre")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_1 WHERE algebre_l1 = @1 GROUP by email_l1 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l1");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));
                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 1 ALGEBRE : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //2
                           if (DropDownList1.SelectedItem.Text == "Logique")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_1 WHERE logique_l1 = @1 GROUP by email_l1 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l1");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 1 Logique : " +f_name1;
                        mail.Body = "<h2>" + f_name2+ "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

               //3
                           if (DropDownList1.SelectedItem.Text == "Architecture")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_1 WHERE architecture_l1 = @1 GROUP by email_l1 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l1");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 1 Architecture : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //4
                           if (DropDownList1.SelectedItem.Text == "Analyse")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_1 WHERE analyse_l1 = @1 GROUP by email_l1 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l1");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 1 Analyse : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //5
                           if (DropDownList1.SelectedItem.Text == "Projet perso")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_1 WHERE projet_perso_l1 = @1 GROUP by email_l1 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l1");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 1 Projet perso : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " +f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //Envoi d'un message     
                lbl_msg.Text = "Enregistrement effectue";
                this.TextBox1.Text = "";
                this.FileUpload1.PostedFile.FileName.Remove(1);
                this.TextBox2.Text = "";
                this.TextBox4.Text = "";
        
                // Fermeture de la connexion
                this.connection.Close();


            }
            else
            {
                /*Gestion des erreurs*/

                lbl_msg.Text = "Tous les champs doivent être remplir Obligatoirement !";
                this.TextBox1.Text = "";
                this.TextBox2.Text = "";
                this.TextBox4.Text = "";
            }


            //        LICENCE 2 ----------------------------- debut dropcategori DropDownList1.Items.FindByValue 
            if (DropDownList2.SelectedItem.Value == "2")
            {

                //try
                //{
                // Ouverture de la connexion SQL         
                this.connection.Open();
                // Création d'une commande SQL en fonction de l'objet connection     
                //MySqlCommand cmd = this.connection.CreateCommand();
                // Requête SQL;
                cmd.CommandText = "INSERT INTO notification_2 (sujet_notification_2, description_notification_2, message_notification_2, image_notification_2, categorie_notification_2) VALUES (@name1, @name2, @name4, @name5, @name6)";
                // utilisation de l'objet contact passé en paramètre   
                cmd.Parameters.AddWithValue("@name1", f_name1);
                cmd.Parameters.AddWithValue("@name2", f_name2);
                //  cmd.Parameters.AddWithValue("@name3", f_name3); 
                cmd.Parameters.AddWithValue("@name4", f_name4);
                cmd.Parameters.AddWithValue("@name5", strnamefull);
                cmd.Parameters.AddWithValue("@name6", f_name6);

                // Exécution de la commande SQL   
                cmd.ExecuteNonQuery();

                this.connection.Close();


                //1
                //envoi email
                if (DropDownList1.SelectedItem.Text == "PHP")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_2 WHERE php_l2	 = @1 GROUP by email_l2 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l2");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));
                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 2 PHP : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //2
                if (DropDownList1.SelectedItem.Text == "Algebre")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_2 WHERE algebre_l2 = @1 GROUP by email_l2 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l2");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 2 Algebre : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //3
                if (DropDownList1.SelectedItem.Text == "Analyses")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_2 WHERE analyses_l2 = @1 GROUP by email_l2	 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l2");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 2 Analyses : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //4
                if (DropDownList1.SelectedItem.Text == "Comptabilite")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_2 WHERE comptabilite_l2 = @1 GROUP by email_l2 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l2");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 2 Comptabilite : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //5
                if (DropDownList1.SelectedItem.Text == "C#")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_2 WHERE c_l2 = @1 GROUP by email_l2 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l2");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 2 C# : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //Envoi d'un message     
                lbl_msg.Text = "Enregistrement effectue";
                this.TextBox1.Text = "";
                this.FileUpload1.PostedFile.FileName.Remove(1);
                this.TextBox2.Text = "";
                this.TextBox4.Text = "";
               
                // Fermeture de la connexion
                this.connection.Close();


            }
            else
            {
                /*Gestion des erreurs*/

                lbl_msg.Text = "Tous les champs doivent être remplir Obligatoirement !";
                this.TextBox1.Text = "";
                this.TextBox2.Text = "";
                this.TextBox4.Text = "";
            }




            //        LICENCE 3 ------------------------------- debut dropcategori DropDownList1.Items.FindByValue 
            if (DropDownList2.SelectedItem.Value == "3")
            {


                //try
                //{
                // Ouverture de la connexion SQL         
                this.connection.Open();
                // Création d'une commande SQL en fonction de l'objet connection     
                //MySqlCommand cmd = this.connection.CreateCommand();
                // Requête SQL;
                cmd.CommandText = "INSERT INTO notification_3 (sujet_notification_3, description_notification_3, message_notification_3, image_notification_3, categorie_notification_3) VALUES (@name1, @name2, @name4, @name5, @name6)";
                // utilisation de l'objet contact passé en paramètre   
                cmd.Parameters.AddWithValue("@name1", f_name1);
                cmd.Parameters.AddWithValue("@name2", f_name2);
                //  cmd.Parameters.AddWithValue("@name3", f_name3); 
                cmd.Parameters.AddWithValue("@name4", f_name4);
                cmd.Parameters.AddWithValue("@name5", strnamefull);
                cmd.Parameters.AddWithValue("@name6", f_name6);

                // Exécution de la commande SQL   
                cmd.ExecuteNonQuery();

                this.connection.Close();


                //1
                //envoi email
                if (DropDownList1.SelectedItem.Text == "GRH")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_3 WHERE grh_l3 = @1 GROUP by email_l3 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l3");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));
                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 3 GRH : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //2
                if (DropDownList1.SelectedItem.Text == "ISI")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_3 WHERE isi_l3 = @1 GROUP by email_l3 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l3");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                      //  string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 3 ISI : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //3
                if (DropDownList1.SelectedItem.Text == "PHP")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_3 WHERE php_l3 = @1 GROUP by email_l3 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l3");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 3 PHP : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //4
                if (DropDownList1.SelectedItem.Text == "ASP")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_3 WHERE asp_l3 = @1 GROUP by email_l3 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l3");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 3 ASP : " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //5
                if (DropDownList1.SelectedItem.Text == "Optimisation")
                {
                    this.connection.Open();
                    cmd.CommandText = "SELECT * FROM licence_3 WHERE optimisation_l3 = @1 GROUP by email_l3 ";
                    cmd.Parameters.AddWithValue("@1", 1);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string email1 = reader.GetString("email_l3");

                        Random o = new Random();

                        this.lbl_msg.Text += "<tr><td>" + email1 + "</td></tr>";
                        SmtpClient smtpClient = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        string msg = TextBox4.Text;

                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Credentials = new System.Net.NetworkCredential("orangecrack01@gmail.com", "phoenixphoenix01");

                        //Setting From , To and CC
                        mail.From = new MailAddress("orangecrack01@gmail.com");
                        mail.To.Add(email1);

                        mail.Attachments.Add(new System.Net.Mail.Attachment("C:\\inetpub\\wwwroot\\TD\\Notif\\" + strnamefull));

                        mail.IsBodyHtml = true;
                        mail.Subject = "Licence 3 Optimisation: " + f_name1;
                        mail.Body = "<h2>" + f_name2 + "</h2>" + "<BR/> " + f_name4 ;

                        smtpClient.Send(mail);

                        email1 = email1 + o.Next(999);

                    }
                    reader.Close();
                }

                //Envoi d'un message     
                lbl_msg.Text = "Enregistrement effectue";
                this.TextBox1.Text = "";
                this.FileUpload1.PostedFile.FileName.Remove(1);
                this.TextBox2.Text = "";
                this.TextBox4.Text = "";
               
                // Fermeture de la connexion
                this.connection.Close();


            }
            else
            {
                /*Gestion des erreurs*/

                lbl_msg.Text = "Tous les champs doivent être remplir Obligatoirement !";
                this.TextBox1.Text = "";
                this.TextBox2.Text = "";
                this.TextBox4.Text = "";
            }

        }

    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedItem.Text == "Licence 1")
        {
            this.DropDownList1.Items.Clear();
            this.DropDownList1.Items.Add(new ListItem { Text = "Algebre", Value = "0" });
            this.DropDownList1.Items.Add(new ListItem { Text = "Logique", Value = "1" });
            this.DropDownList1.Items.Add(new ListItem { Text = "Architecture", Value = "2" });
            this.DropDownList1.Items.Add(new ListItem { Text = "Analyse", Value = "3" });
            this.DropDownList1.Items.Add(new ListItem { Text = "Projet perso", Value = "4" });
        }
        if (DropDownList2.SelectedItem.Value == "2")
        {
            this.DropDownList1.Items.Clear();
            this.DropDownList1.Items.Add(new ListItem { Text = "PHP", Value = "0" });
            this.DropDownList1.Items.Add(new ListItem { Text = "Algebre", Value = "1" });
            this.DropDownList1.Items.Add(new ListItem { Text = "Analyses", Value = "2" });
            this.DropDownList1.Items.Add(new ListItem { Text = "Comptabilite", Value = "3" });
            this.DropDownList1.Items.Add(new ListItem { Text = "C#", Value = "4" });
        }
        if (DropDownList2.SelectedItem.Value == "3")
        {
            this.DropDownList1.Items.Clear();
            this.DropDownList1.Items.Add(new ListItem { Text = "GRH", Value = "0" });
            this.DropDownList1.Items.Add(new ListItem { Text = "ISI", Value = "1" });
            this.DropDownList1.Items.Add(new ListItem { Text = "PHP", Value = "2" });
            this.DropDownList1.Items.Add(new ListItem { Text = "ASP", Value = "3" });
            this.DropDownList1.Items.Add(new ListItem { Text = "Optimisation", Value = "4" });
        }
    
    }
}

   