using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Dictionnary
{
    
    public partial class Acceuil : Form
         
    {


        public string util;
        public Acceuil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tu es sùr de quitter ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
           
            label3.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timer1.Start();
            
            label4.Text = util;
            if(label4.Text!= "ADMIN")
            {
                ghToolStripMenuItem.Enabled = false;
                xToolStripMenuItem.Enabled = false;
               


            }
            else
            {
                try
                {

                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    OleDbConnection connection = new OleDbConnection(connectionString);
                    connection.Open();
                    string query = "SELECT Count(Niveau) FROM Avis where Niveau= '1';";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    int sous_somme = (int)command.ExecuteScalar();
                    string query22 = "SELECT Count(Niveau) FROM Avis where Niveau= '2';";
                    OleDbCommand command22 = new OleDbCommand(query22, connection);
                    int sous_somme22 = (int)command22.ExecuteScalar();
                    string query33 = "SELECT Count(Niveau) FROM Avis where Niveau= '3';";
                    OleDbCommand command33 = new OleDbCommand(query33, connection);
                    int sous_somme33 = (int)command33.ExecuteScalar();
                    string query44 = "SELECT Count(Niveau) FROM Avis where Niveau= '4';";
                    OleDbCommand command44 = new OleDbCommand(query44, connection);
                    int sous_somme44 = (int)command44.ExecuteScalar();
                    string query2 = "SELECT Count(Niveau) FROM Avis ";
                    OleDbCommand command2 = new OleDbCommand(query2, connection);
                    int somme = (int)command2.ExecuteScalar();
                    // Exécuter la commande et récupérer la moyenne
                    connection.Close();
                    double moyenne = (sous_somme * 100) / somme;
                    double moyenne22 = (sous_somme22 * 100) / somme;
                    double moyenne33 = (sous_somme33 * 100) / somme;
                    double moyenne44 = (sous_somme44 * 100) / somme;
                    MessageBox.Show("la pourcentage des utilisateurs qui ne sont pas satisfait du tout est =" + moyenne + "%\n" +
                        "la pourcentage des utilisateurs qui sont plus ou moins satisfait est =" + moyenne22 + "%\n" + "" +
                        "la pourcentage des utilisateurs qui sont satisfait=" + moyenne33 + "%\n"
                        + "la pourcentage des utilisateurs qui sont largement satisfait =" + moyenne44 + "%\n", "Statistiques", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if ((moyenne + moyenne22) > (moyenne33 + moyenne44))
                    {
                        MessageBox.Show("Il vaut mieux ameliorer la performance de l'application !", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("Application parfait !", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans la base de données !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
            }
           



        }

        private void ghToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
             
        }

        private void ghToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            ghToolStripMenuItem.Font = new Font(ghToolStripMenuItem.Font, FontStyle.Bold);
            toolStripMenuItem1.Font = new Font(toolStripMenuItem1.Font, FontStyle.Regular);
            toolStripMenuItem2.Font = new Font(toolStripMenuItem1.Font, FontStyle.Regular);
            toolStripMenuItem4.Font = new Font(toolStripMenuItem1.Font, FontStyle.Regular);
            modificationDesTraductionToolStripMenuItem.Font = new Font(modificationDesTraductionToolStripMenuItem.Font, FontStyle.Regular);
            suppressionDesTraductionsToolStripMenuItem.Font = new Font(suppressionDesTraductionsToolStripMenuItem.Font, FontStyle.Regular);




        }

        private void ghToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ghToolStripMenuItem.Font = new Font(ghToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void sqsToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            sqsToolStripMenuItem.Font = new Font(sqsToolStripMenuItem.Font, FontStyle.Bold);

        }

        private void sqsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            sqsToolStripMenuItem.Font = new Font(sqsToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void fgfgToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            fgfgToolStripMenuItem.Font = new Font(fgfgToolStripMenuItem.Font, FontStyle.Bold);
        }

        private void fgfgToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            fgfgToolStripMenuItem.Font = new Font(fgfgToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void xToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            xToolStripMenuItem.Font = new Font(xToolStripMenuItem.Font, FontStyle.Bold);
        }

        private void xToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            xToolStripMenuItem.Font = new Font(xToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            Ajout_tr Ajout_tr = new Ajout_tr();
            // Définir le parent de la forme comme étant le panneau (panel)
            Ajout_tr.TopLevel = false;
            Ajout_tr.AutoScroll = true;
            panelform.Controls.Add(Ajout_tr);
            Ajout_tr.Show();
        }

        private void modificationDesTraductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           modtr modtr = new modtr();

            // Définir le parent de la forme comme étant le panneau (panel)
            modtr.TopLevel = false;
            modtr.AutoScroll = true;
            panelform.Controls.Add(modtr);
            modtr.Show();
        }

        private void toolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
           
            toolStripMenuItem1.Font = new Font(toolStripMenuItem1.Font, FontStyle.Bold);
        }

        private void modificationDesTraductionToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            modificationDesTraductionToolStripMenuItem.Font = new Font(modificationDesTraductionToolStripMenuItem.Font, FontStyle.Bold);
        }

        private void suppressionDesTraductionsToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
          
            suppressionDesTraductionsToolStripMenuItem.Font = new Font(suppressionDesTraductionsToolStripMenuItem.Font, FontStyle.Bold);
        }

        private void toolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            ghToolStripMenuItem.Font = new Font(ghToolStripMenuItem.Font, FontStyle.Regular);
            toolStripMenuItem1.Font = new Font(toolStripMenuItem1.Font, FontStyle.Regular);
        }

        private void modificationDesTraductionToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ghToolStripMenuItem.Font = new Font(ghToolStripMenuItem.Font, FontStyle.Regular);
            modificationDesTraductionToolStripMenuItem.Font = new Font(modificationDesTraductionToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void suppressionDesTraductionsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ghToolStripMenuItem.Font = new Font(ghToolStripMenuItem.Font, FontStyle.Regular);
            suppressionDesTraductionsToolStripMenuItem.Font = new Font(suppressionDesTraductionsToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void panelform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sqsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Traduire Traduire = new Traduire();
          

            // Définir le parent de la forme comme étant le panneau (panel)
            Traduire.TopLevel = false;
            Traduire.AutoScroll = true;
            panelform.Controls.Add(Traduire);
            Traduire.Show();
        }

        private void suppressionDesTraductionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supp_tr Supp_tr = new Supp_tr();

            // Définir le parent de la forme comme étant le panneau (panel)
            Supp_tr.TopLevel = false;
            Supp_tr.AutoScroll = true;
            panelform.Controls.Add(Supp_tr);
            Supp_tr.Show();
        }

        private void fgfgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apropos Apropos = new Apropos();

            // Définir le parent de la forme comme étant le panneau (panel)
            Apropos.TopLevel = false;
            Apropos.AutoScroll = true;
            panelform.Controls.Add(Apropos);
            Apropos.Show();
        }

        private void toolStripMenuItem2_MouseMove(object sender, MouseEventArgs e)
        {
          
            toolStripMenuItem2.Font = new Font(toolStripMenuItem1.Font, FontStyle.Bold);
        }

        private void toolStripMenuItem2_MouseLeave(object sender, EventArgs e)
        {
            ghToolStripMenuItem.Font = new Font(ghToolStripMenuItem.Font, FontStyle.Regular);
            toolStripMenuItem2.Font = new Font(toolStripMenuItem1.Font, FontStyle.Regular);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plaintes Plaintes = new Plaintes();

            // Définir le parent de la forme comme étant le panneau (panel)
            Plaintes.TopLevel = false;
            Plaintes.AutoScroll = true;
            panelform.Controls.Add(Plaintes);
            Plaintes.Show();
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
            label5.ForeColor = Color.Gold;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string niveau = "4";
            Random random = new Random();
            int id = random.Next(100, 1000000);
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
            string insertQuery = "INSERT INTO Avis VALUES (ID,Niveau)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Niveau", niveau);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            MessageBox.Show("Merci de nos aider à ameliorer notre application ! \nSuper ! Nous Sommes trés heureux d'aittendre vos besoins correctement . ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string niveau = "3";
            Random random = new Random();
            int id = random.Next(100, 1000000);
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
            string insertQuery = "INSERT INTO Avis VALUES (ID,Niveau)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Niveau", niveau);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            MessageBox.Show("Merci de nos aider à ameliorer notre application ! \nNous Sommes Trés heureux d'avoir votre impression . ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merci de nos aider à ameliorer notre application ! \nNous Sommes Vraiment désolé nous allons faire nos meilleurs pour atteindre vos besoins . ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
            string niveau="1";
            Random random = new Random();
            int id = random.Next(100, 1000000);
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
            string insertQuery = "INSERT INTO Avis VALUES (ID,Niveau)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Niveau", niveau);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
        }

                private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
            label5.ForeColor = Color.Gold;
            label6.Font = new Font(label6.Font, FontStyle.Bold);
            label6.ForeColor = Color.Gold;
        }

        private void label7_Move(object sender, EventArgs e)
        {
            
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
            label5.ForeColor = Color.Gold;
            label6.Font = new Font(label6.Font, FontStyle.Bold);
            label6.ForeColor = Color.Gold;
            label7.Font = new Font(label7.Font, FontStyle.Bold);
            label7.ForeColor = Color.Gold;
            label8.Font = new Font(label8.Font, FontStyle.Bold);
            label8.ForeColor = Color.Gold;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
            label5.ForeColor = Color.Gold;
            label6.Font = new Font(label6.Font, FontStyle.Bold);
            label6.ForeColor = Color.Gold;
            label7.Font = new Font(label7.Font, FontStyle.Bold);
            label7.ForeColor = Color.Gold;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
        }

        private void label7_Leave(object sender, EventArgs e)
        {
            
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string niveau = "2";
            Random random = new Random();
            int id = random.Next(100, 1000000);
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
            string insertQuery = "INSERT INTO Avis VALUES (ID,Niveau)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Niveau", niveau);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            MessageBox.Show("Merci de nos aider à ameliorer notre application ! \nNous Sommes désolé nous allons ameliorer notre application . ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Enrechissement Enrechissement = new Enrechissement();
            // Définir le parent de la forme comme étant le panneau (panel)
            Enrechissement.TopLevel = false;
            Enrechissement.AutoScroll = true;
            panelform.Controls.Add(Enrechissement);
            Enrechissement.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si vou rencontrez un probleme vous pouvez se plaindre dans la form Acceuil et si c'est urgent vous pouvez également nous envoyer un mail.\nNotre mail: medchrifmastouri@gmail.com\n                    walidbechri0@gmail.com", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult result = MessageBox.Show("Cliquez oui si vous voulez nouv envoyer un mail", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Process.Start("https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox");
            }
        }

        private void toolStripMenuItem3_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripMenuItem3.Font = new Font(toolStripMenuItem3.Font, FontStyle.Bold);
        }

        private void toolStripMenuItem3_MouseLeave(object sender, EventArgs e)
        {
            toolStripMenuItem3.Font = new Font(toolStripMenuItem3.Font, FontStyle.Regular);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.BackColor = Color.Gray;
            pictureBox1.BackColor = Color.Gray;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.LightBlue;
            pictureBox1.BackColor = Color.LightBlue;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.Gray;
            label4.BackColor = Color.Gray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightBlue;
            label4.BackColor = Color.LightBlue;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Que voulez-vous faire ?\nSi exporter cliquer sur oui.\nSinon cliquer sur non.", "Export/Import", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                // Code pour l'export
                string fileName = "C:/Users/star store/Desktop/Les projets/Dictionnary/DEB2.export.txt";
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ID_mot, type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR FROM Traduction";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    writer.WriteLine($"{reader["ID_mot"]},{reader["type"]},{reader["Tr_AG"]},{reader["Tr_AR"]},{reader["Tr_ES"]},{reader["Tr_FR"]},{reader["Ex1_AG"]},{reader["Ex1_AR"]},{reader["Ex1_ES"]},{reader["Ex1_FR"]},{reader["Ex2_AR"]},{reader["Ex2_AG"]},{reader["Ex2_ES"]},{reader["Ex1_FR"]}");
                                }
                            }
                        }
                    }
                }
                 MessageBox.Show("Exportation est effectué avec succées.", "Export/Import", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (result == DialogResult.No)
            {
                // Code pour l'import
                {
                    try
                    {
                        string filePath = "C:/Users/star store/Desktop/Les projets/Dictionnary/DEB2.import.txt";
                        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\star store\Documents\DEB.accdb;Persist Security Info=False;";
                        using (OleDbConnection connection = new OleDbConnection(connectionString))
                        {
                            connection.Open();

                            using (StreamReader reader = new StreamReader(filePath))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    string[] data = line.Split(',');
                                    string query = @"INSERT INTO Traduction (ID_mot, type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR) VALUES (@ID_mot, @type, @Tr_AG, @Tr_AR, @Tr_ES, @Tr_FR, @Ex1_AG, @Ex1_AR, @Ex1_ES, @Ex1_FR, @Ex2_AG, @Ex2_AR, @Ex2_ES, @Ex2_FR) ;";
                                    using (OleDbCommand command = new OleDbCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@ID_mot", data[0]);
                                        command.Parameters.AddWithValue("@type", data[1]);
                                        command.Parameters.AddWithValue("@Tr_AG", data[2]);
                                        command.Parameters.AddWithValue("@Tr_AR", data[3]);
                                        command.Parameters.AddWithValue("@Tr_ES", data[4]);
                                        command.Parameters.AddWithValue("@Tr_FR", data[5]);
                                        command.Parameters.AddWithValue("@Ex1_AG", data[6]);
                                        command.Parameters.AddWithValue("@Ex1_AR", data[7]);
                                        command.Parameters.AddWithValue("@Ex1_ES", data[8]);
                                        command.Parameters.AddWithValue("@Ex1_FR", data[9]);
                                        command.Parameters.AddWithValue("@Ex2_AG", data[10]);
                                        command.Parameters.AddWithValue("@Ex2_AR", data[11]);
                                        command.Parameters.AddWithValue("@Ex2_ES", data[12]);
                                        command.Parameters.AddWithValue("@Ex2_FR", data[13]);
                                        command.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                      
                        File.WriteAllText(filePath, string.Empty);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Importation est effectué avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }


            }
            else
            {
                // Annuler l'opération
                MessageBox.Show("Transaction est annulée.", "Export/Import", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void toolStripMenuItem4_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripMenuItem4.Font = new Font(ghToolStripMenuItem.Font, FontStyle.Bold);
        }

        private void toolStripMenuItem4_MouseLeave(object sender, EventArgs e)
        {
            toolStripMenuItem4.Font = new Font(ghToolStripMenuItem.Font, FontStyle.Regular);
        }
    }
}
