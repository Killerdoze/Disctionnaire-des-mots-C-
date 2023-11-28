using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dictionnary
{
    public partial class Supp_tr : Form
    {
        string ID_mot;
        public Supp_tr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.Text == "Anglais")
                {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Anglais where Tr_AG ='" + comboBox3.Text + "' ", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                       
                        textBox1.Text = (reader["Type"].ToString());
                        textBox2.Text = (reader["Ex1_AG"].ToString());
                        textBox4.Text = (reader["EX2_AG"].ToString());
                        ID_mot = (reader["ID_mot"].ToString());


                    }
                    // Fermeture de la connexion
                    connection.Close();
                }
                else if (comboBox1.Text == "Espagnol")
                {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Espagnol where Tr_ES ='" + comboBox3.Text + "' ", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox1.Text = (reader["Type"].ToString());
                        textBox2.Text = (reader["Ex1_ES"].ToString());
                        textBox4.Text = (reader["EX2_ES"].ToString());
                        ID_mot = (reader["ID_mot"].ToString());

                    }
                    // Fermeture de la connexion
                    connection.Close();
                }
                else if (comboBox1.Text == "Français")
                {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Francais where Tr_FR ='" + comboBox3.Text + "' ", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox1.Text = (reader["Type"].ToString());
                        textBox2.Text = (reader["Ex1_FR"].ToString());
                        textBox4.Text = (reader["EX2_FR"].ToString());
                        ID_mot = (reader["ID_mot"].ToString());

                    }
                    // Fermeture de la connexion
                    connection.Close();
                }
                else if (comboBox1.Text == "Arabe")
                {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Arabe where Tr_AR ='" + comboBox3.Text + "' ", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox1.Text = (reader["Type"].ToString());
                        textBox2.Text = (reader["Ex1_AR"].ToString());
                        textBox4.Text = (reader["EX2_AR"].ToString());
                        ID_mot = (reader["ID_mot"].ToString());

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    comboBox1.Focus();
                    label10.Visible = true;
                    label14.Visible = false;



                }
                else if (comboBox3.Text == "")
                {
                    comboBox3.Focus();
                    label10.Visible = false;
                    label14.Visible = true;

                }


                else
                {
                   
                    DialogResult result = MessageBox.Show("Tu es sùr de supprimer cette traduction ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        OleDbCommand cmd;
                        OleDbConnection connection = new OleDbConnection();
                        connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                        string query = "DELETE FROM Traduction where ID_mot='" + ID_mot + "'";
                        cmd = new OleDbCommand(query, connection);
                        cmd.Parameters.AddWithValue("ID_mot", ID_mot);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur dans la base de données !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }

        private void Supp_tr_Load(object sender, EventArgs e)
        {

        }
    }
}
