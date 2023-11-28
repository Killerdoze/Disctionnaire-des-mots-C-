using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionnary
{
    public partial class Traduire : Form
    {
        String id_mot;
        public Traduire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String aux = comboBox1.Text;
            String aux2 = comboBox2.Text;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = aux2;
            comboBox2.Text = aux;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";



        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.Text == "")
                {
                    label2.Visible = true;
                }
                else
                {
                    if (comboBox1.Text == "Anglais")
                    {
                        if (comboBox2.Text == "Arabe")
                        {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_AG ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_AR"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_AG"].ToString());
                                textBox5.Text = (reader["EX2_AG"].ToString());
                                textBox2.Text = (reader["Ex1_AR"].ToString());
                                textBox3.Text = (reader["EX2_AR"].ToString());
                            }
                            // Fermeture de la connexion
                            connection.Close();
                        }
                        else if (comboBox2.Text == "Espagnol")
                        {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_AG ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_ES"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_AG"].ToString());
                                textBox5.Text = (reader["EX2_AG"].ToString());
                                textBox2.Text = (reader["Ex1_ES"].ToString());
                                textBox3.Text = (reader["EX2_ES"].ToString());
                            }
                            // Fermeture de la connexion
                            connection.Close();
                        }
                        else if (comboBox2.Text == "Français")
                        {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_AG ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_FR"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_AG"].ToString());
                                textBox5.Text = (reader["EX2_AG"].ToString());
                                textBox2.Text = (reader["Ex1_FR"].ToString());
                                textBox3.Text = (reader["EX2_FR"].ToString());
                            }
                            // Fermeture de la connexion
                            connection.Close();
                        }

                    }
                    else if (comboBox1.Text == "Espagnol")
                    {
                        if (comboBox2.Text == "Anglais") {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_ES ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_AG"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_ES"].ToString());
                                textBox5.Text = (reader["EX2_ES"].ToString());
                                textBox2.Text = (reader["Ex1_AG"].ToString());
                                textBox3.Text = (reader["EX2_AG"].ToString());
                            }
                            // Fermeture de la connexion
                            connection.Close();
                        }
                        else if (comboBox2.Text == "Arabe") {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_ES ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_AR"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_ES"].ToString());
                                textBox5.Text = (reader["EX2_ES"].ToString());
                                textBox2.Text = (reader["Ex1_AR"].ToString());
                                textBox3.Text = (reader["EX2_AR"].ToString());
                            }
                        }
                        else if (comboBox2.Text == "Français") {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_ES ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_FR"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_ES"].ToString());
                                textBox5.Text = (reader["EX2_ES"].ToString());
                                textBox2.Text = (reader["Ex1_FR"].ToString());
                                textBox3.Text = (reader["EX2_FR"].ToString());
                            }
                        }
                    }
                    else if (comboBox1.Text == "Français")
                    {
                        if (comboBox2.Text == "Anglais") {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_FR ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_AG"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_FR"].ToString());
                                textBox5.Text = (reader["EX2_FR"].ToString());
                                textBox2.Text = (reader["Ex1_AG"].ToString());
                                textBox3.Text = (reader["EX2_AG"].ToString());
                            }
                        }
                        else if (comboBox2.Text == "Arabe") {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_FR ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_AR"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_FR"].ToString());
                                textBox5.Text = (reader["EX2_FR"].ToString());
                                textBox2.Text = (reader["Ex1_AR"].ToString());
                                textBox3.Text = (reader["EX2_AR"].ToString());
                            }
                        }
                        else if (comboBox2.Text == "Espagnol") {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_FR ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_ES"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_FR"].ToString());
                                textBox5.Text = (reader["EX2_FR"].ToString());
                                textBox2.Text = (reader["Ex1_ES"].ToString());
                                textBox3.Text = (reader["EX2_ES"].ToString());
                            }
                        }

                    }
                    else if (comboBox1.Text == "Arabe")
                    {
                        if (comboBox2.Text == "Anglais") {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_AR ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_AG"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_AR"].ToString());
                                textBox5.Text = (reader["EX2_AR"].ToString());
                                textBox2.Text = (reader["Ex1_AG"].ToString());
                                textBox3.Text = (reader["EX2_AG"].ToString());
                            }
                        }
                        else if (comboBox2.Text == "Espagnol") {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_AR ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_ES"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_AR"].ToString());
                                textBox5.Text = (reader["EX2_AR"].ToString());
                                textBox2.Text = (reader["Ex1_ES"].ToString());
                                textBox3.Text = (reader["EX2_ES"].ToString());
                            }
                        }
                        else if (comboBox2.Text == "Français") {
                            OleDbConnection connection = new OleDbConnection();
                            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Traduction where Tr_AR ='" + comboBox3.Text + "' ", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox6.Text = (reader["Tr_FR"].ToString());
                                textBox1.Text = (reader["Type"].ToString());
                                textBox4.Text = (reader["Ex1_AR"].ToString());
                                textBox5.Text = (reader["EX2_AR"].ToString());
                                textBox2.Text = (reader["Ex1_FR"].ToString());
                                textBox3.Text = (reader["EX2_FR"].ToString());
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans la base de données !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox3.Text = "";
                if (comboBox1.Text == comboBox2.Text)
                {
                    MessageBox.Show("La traduction ne peut pas étre faire que entre deux langues différents !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBox1.Text = "";
                }

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
                        id_mot = (reader["ID_mot"].ToString());

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
                        id_mot = (reader["ID_mot"].ToString());

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
                        id_mot = (reader["ID_mot"].ToString());

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
                        id_mot = (reader["ID_mot"].ToString());

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("La traduction ne peut pas étre faire que entre deux langues différents !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox2.Text = "";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Traduire_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM Arabe ", connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox3.Items.Add(reader["Tr_AR"].ToString());
                id_mot = (reader["ID_mot"].ToString());

            }
            // Fermeture de la connexion
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            Complaindre Complaindre = new Complaindre();
        
            Complaindre.Show();
           

        }
    }
}
