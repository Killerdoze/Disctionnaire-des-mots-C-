using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dictionnary
{

    public partial class Enrechissement : Form
    {
        List<string> elements = new List<string>();
        String ID_mot;
        public Enrechissement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            if (comboBox1.Text == "Anglais")
            {
                listBox1.Items.Remove("Anglais");
                listBox1.Items.Remove("Arabe");
                listBox1.Items.Remove("Espagnol");
                listBox1.Items.Remove("Français");

                listBox1.Items.Clear();
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_AG ='" + comboBox3.Text + "' ", connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    textBox1.Text = (reader["Type"].ToString());
                    textBox2.Text = (reader["Ex1_AG"].ToString());
                    textBox4.Text = (reader["EX2_AG"].ToString());
                    textBox3.Text = (reader["Tr_AG"].ToString());
                    textBox5.Text = (reader["Tr_FR"].ToString());
                    textBox7.Text = (reader["Tr_AR"].ToString());
                    textBox6.Text = (reader["Tr_ES"].ToString());
                    ID_mot= (reader["ID_mot"].ToString());
                    if (textBox3.Text != "-")
                    {
                        elements.Add("Anglais");
                    }
                    if (textBox5.Text != "-")
                    {
                        elements.Add("Français");
                    }
                    if (textBox7.Text != "-")
                    {
                        elements.Add("Arabe");
                    }
                    if (textBox6.Text != "-")
                    {
                        elements.Add("Espagnol");
                    }


                    // parcourir les éléments de la liste et les ajouter à la ListBox
                    foreach (string element in elements)
                    {
                        // ajouter un tiret "-" devant chaque élément et ajouter à la ListBox
                        listBox1.Items.Add(element);
                    }


                }
                // Fermeture de la connexion
                connection.Close();
            }
            else if (comboBox1.Text == "Espagnol")
            {
                listBox1.Items.Clear();
                listBox1.Text = "";
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_ES ='" + comboBox3.Text + "' ", connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    textBox1.Text = (reader["Type"].ToString());
                    textBox2.Text = (reader["Ex1_AG"].ToString());
                    textBox4.Text = (reader["EX2_AG"].ToString());
                    textBox3.Text = (reader["Tr_AG"].ToString());
                    textBox5.Text = (reader["Tr_FR"].ToString());
                    textBox7.Text = (reader["Tr_AR"].ToString());
                    textBox6.Text = (reader["Tr_ES"].ToString());
                    ID_mot = (reader["ID_mot"].ToString());
                    if (textBox3.Text != "-")
                    {
                        elements.Add("Anglais");
                    }
                    if (textBox5.Text != "-")
                    {
                        elements.Add("Français");
                    }
                    if (textBox7.Text != "-")
                    {
                        elements.Add("Arabe");
                    }
                    if (textBox6.Text != "-")
                    {
                        elements.Add("Espagnol");
                    }


                    // parcourir les éléments de la liste et les ajouter à la ListBox
                    foreach (string element in elements)
                    {
                        // ajouter un tiret "-" devant chaque élément et ajouter à la ListBox
                        listBox1.Items.Add(element);
                    }


                }
                // Fermeture de la connexion
                connection.Close();
            }
            else if (comboBox1.Text == "Français")
            {
                listBox1.Items.Clear();
                listBox1.Text = "";
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_FR ='" + comboBox3.Text + "' ", connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    textBox1.Text = (reader["Type"].ToString());
                    textBox2.Text = (reader["Ex1_AG"].ToString());
                    textBox4.Text = (reader["EX2_AG"].ToString());
                    textBox3.Text = (reader["Tr_AG"].ToString());
                    textBox5.Text = (reader["Tr_FR"].ToString());
                    textBox7.Text = (reader["Tr_AR"].ToString());
                    textBox6.Text = (reader["Tr_ES"].ToString());
                    ID_mot = (reader["ID_mot"].ToString());
                    if (textBox3.Text != "-")
                    {
                        elements.Add("Anglais");
                    }
                    if (textBox5.Text != "-")
                    {
                        elements.Add("Français");
                    }
                    if (textBox7.Text != "-")
                    {
                        elements.Add("Arabe");
                    }
                    if (textBox6.Text != "-")
                    {
                        elements.Add("Espagnol");
                    }


                    // parcourir les éléments de la liste et les ajouter à la ListBox
                    foreach (string element in elements)
                    {
                        // ajouter un tiret "-" devant chaque élément et ajouter à la ListBox
                        listBox1.Items.Add(element);
                    }



                }
                // Fermeture de la connexion
                connection.Close();
            }
            else if (comboBox1.Text == "Arabe")
            {
                listBox1.Items.Clear();
                listBox1.Text = "";
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_AR ='" + comboBox3.Text + "' ", connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = (reader["Type"].ToString());
                    textBox2.Text = (reader["Ex1_AG"].ToString());
                    textBox4.Text = (reader["EX2_AG"].ToString());
                    textBox3.Text = (reader["Tr_AG"].ToString());
                    textBox5.Text = (reader["Tr_FR"].ToString());
                    textBox7.Text = (reader["Tr_AR"].ToString());
                    textBox6.Text = (reader["Tr_ES"].ToString());
                    ID_mot = (reader["ID_mot"].ToString());
                    if (textBox3.Text != "-")
                    {
                        elements.Add("Anglais");
                    }
                    if (textBox5.Text != "-")
                    {
                        elements.Add("Français");
                    }
                    if (textBox7.Text != "-")
                    {
                        elements.Add("Arabe");
                    }
                    if (textBox6.Text != "-")
                    {
                        elements.Add("Espagnol");
                    }


                    // parcourir les éléments de la liste et les ajouter à la ListBox
                    foreach (string element in elements)
                    {
                        // ajouter un tiret "-" devant chaque élément et ajouter à la ListBox
                        listBox1.Items.Add(element);
                    }


                }
                // Fermeture de la connexion
                connection.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Text = "";
                comboBox3.Text = "";
               
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";

                if (comboBox1.Text == "Anglais")
                {
                    comboBox3.Items.Clear();
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Anglais ", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader["Tr_AG"].ToString());

                    }
                    // Fermeture de la connexion
                    connection.Close();

                }
                else if (comboBox1.Text == "Espagnol")
                {
                    comboBox3.Items.Clear();
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Espagnol ", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader["Tr_ES"].ToString());

                    }
                    // Fermeture de la connexion
                    connection.Close();
                }
                else if (comboBox1.Text == "Français")
                {
                    comboBox3.Items.Clear();
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Francais ", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader["Tr_FR"].ToString());

                    }
                    // Fermeture de la connexion
                    connection.Close();
                }
                else if (comboBox1.Text == "Arabe")
                {
                    comboBox3.Items.Clear();
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Arabe ", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader["Tr_AR"].ToString());

                    }
                    // Fermeture de la connexion
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans la base de données !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
            
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=listBox1.SelectedIndex;
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(index);
            }

         
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string element in elements)
            {
                // vérifier si la chaîne de caractères recherchée est égale à l'élément actuel de la ListBox
                if (comboBox4.Text == element)
                {
                    MessageBox.Show("Cette traduction déja existe !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBox4.Text = "";

                }
            }

        }

      
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Focus();
                label10.Visible = true;
                label14.Visible = false;
                label19.Visible = false;
                label17.Visible = false;
                label16.Visible = false;

            }
            else if (comboBox3.Text == "")
            {
                label14.Visible = true;
                comboBox3.Focus();
                label10.Visible = false;
                label19.Visible = false;
                label17.Visible = false;
                label16.Visible = false;
            }
            else if (comboBox4.Text == "")
            {
                label19.Visible = true;
                comboBox4.Focus();
                label14.Visible = false;
                label10.Visible = false;
                label17.Visible = false;
                label16.Visible = false;
            }
            else if (textBox10.Text == "")
            {
                label17.Visible = true;
                textBox10.Focus();
                label14.Visible = false;
                label10.Visible = false;
                label19.Visible = false;
            }
            else if (textBox9.Text == "" && textBox8.Text == "")
            {
                label16.Visible = true;
                textBox8.Focus();
                label14.Visible = false;
                label10.Visible = false;
                label19.Visible = false;
                label17.Visible = false;

            }
            else
            {
                label10.Visible = false;
                label14.Visible = false;
                label16.Visible = false;
                label19.Visible = false;
                OleDbCommand cmd;
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                OleDbCommand cmd2;
                OleDbConnection connection2 = new OleDbConnection();
                connection2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";

                if (comboBox4.Text == "Anglais")
                {

                    string query = "UPDATE Traduction SET Tr_AG ='" + textBox10.Text + "', Ex1_AG ='" + textBox9.Text + "', EX2_AG ='" + textBox8.Text + "' where ID_mot='" + ID_mot + "'";
                    cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("Tr_AG ", textBox10.Text);
                    cmd.Parameters.AddWithValue("Ex1_AG", textBox9.Text);
                    cmd.Parameters.AddWithValue("EX2_AG", textBox8.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    comboBox3.Text = "";
                    comboBox3.Items.Clear();
                    textBox1.Text = "";
                    textBox4.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Traduction est ajouté avec succées !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else if (comboBox4.Text == "Arabe")
                {
                    string query = "UPDATE Traduction SET  Tr_AR ='" + textBox10.Text + "', Ex1_AR ='" + textBox9.Text + "', EX2_AR ='" + textBox8.Text + "' where ID_mot='" + ID_mot + "'";
                    cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("Tr_AR", textBox10.Text);
                    cmd.Parameters.AddWithValue("Ex1_AR", textBox2.Text);
                    cmd.Parameters.AddWithValue("EX2_AR", textBox4.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    comboBox3.Text = "";
                    comboBox3.Items.Clear();
                    textBox1.Text = "";
                    textBox4.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Traduction est ajouté avec succées !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();



                }
                else if (comboBox4.Text == "Français")
                {
                    string query = "UPDATE Traduction SET  Tr_FR ='" + textBox10.Text + "', Ex1_FR ='" + textBox9.Text + "', EX2_FR ='" + textBox8.Text + "' where ID_mot='" + ID_mot + "'";
                    cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("Tr_FR", textBox10.Text);
                    cmd.Parameters.AddWithValue("Ex1_FR", textBox2.Text);
                    cmd.Parameters.AddWithValue("EX2_FR", textBox4.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    comboBox3.Text = "";
                    comboBox3.Items.Clear();
                    textBox1.Text = "";
                    MessageBox.Show("Traduction est ajouté avec succées !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else if (comboBox4.Text == "Espagnol")
                {
                    string query = "UPDATE Traduction SET Tr_ES ='" + textBox10.Text + "', Ex1_ES ='" + textBox9.Text + "', EX2_ES ='" + textBox8.Text + "' where ID_mot='" + ID_mot + "'";
                    cmd = new OleDbCommand(query, connection);
                    cmd.Parameters.AddWithValue("Tr_ES", textBox10.Text);
                    cmd.Parameters.AddWithValue("Ex1_ES", textBox9.Text);
                    cmd.Parameters.AddWithValue("EX2_ES", textBox8.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    comboBox3.Text = "";
                    comboBox3.Items.Clear();
                    textBox1.Text = "";
                    MessageBox.Show("Traduction est ajouté avec succées !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();


                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }
    }
    }

