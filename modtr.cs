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
    public partial class modtr : Form
    {
        string ID_mot;
        String Anc_Tr;
        String Anc_Type;
        String Anc_Ex1;
        String Anc_Ex2;
        public modtr()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void modtr_Load(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox3.Text = "";
                textBox1.Text = "";
                comboBox2.Text = "";
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
                else if (comboBox1.Text == "Espagnol") {
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
                else if (comboBox1.Text == "Français") {
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
                else if (comboBox1.Text == "Arabe") {
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        textBox1.Text = (reader["Tr_AG"].ToString());
                        comboBox2.Text = (reader["Type"].ToString());
                        textBox2.Text = (reader["Ex1_AG"].ToString());
                        textBox4.Text = (reader["EX2_AG"].ToString());
                        ID_mot= (reader["ID_mot"].ToString());
                        Anc_Tr = textBox1.Text;
                        Anc_Type = comboBox2.Text;
                        Anc_Ex1= textBox2.Text;
                        Anc_Ex2 = textBox4.Text;

                    }
                    // Fermeture de la connexion
                    connection.Close();
                }
                else if (comboBox1.Text == "Espagnol") {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Espagnol where Tr_ES ='" + comboBox3.Text + "' ", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox1.Text = (reader["Tr_ES"].ToString());
                        comboBox2.Text = (reader["Type"].ToString());
                        textBox2.Text = (reader["Ex1_ES"].ToString());
                        textBox4.Text = (reader["EX2_ES"].ToString());
                        ID_mot = (reader["ID_mot"].ToString());
                        Anc_Tr = textBox1.Text;
                        Anc_Type = comboBox2.Text;
                        Anc_Ex1 = textBox2.Text;
                        Anc_Ex2 = textBox4.Text;
                    }
                    // Fermeture de la connexion
                    connection.Close();
                }
                else if (comboBox1.Text == "Français") {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Francais where Tr_FR ='" + comboBox3.Text + "' ", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox1.Text = (reader["Tr_FR"].ToString());
                        comboBox2.Text = (reader["Type"].ToString());
                        textBox2.Text = (reader["Ex1_FR"].ToString());
                        textBox4.Text = (reader["EX2_FR"].ToString());
                        ID_mot = (reader["ID_mot"].ToString());
                        Anc_Tr = textBox1.Text;
                        Anc_Type = comboBox2.Text;
                        Anc_Ex1 = textBox2.Text;
                        Anc_Ex2 = textBox4.Text;
                    }
                    // Fermeture de la connexion
                    connection.Close();
                }
                else if (comboBox1.Text == "Arabe") {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Arabe where Tr_AR ='" + comboBox3.Text + "' ", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox1.Text = (reader["Tr_AR"].ToString());
                        comboBox2.Text = (reader["Type"].ToString());
                        textBox2.Text = (reader["Ex1_AR"].ToString());
                        textBox4.Text = (reader["EX2_AR"].ToString());
                        ID_mot = (reader["ID_mot"].ToString());
                        Anc_Tr = textBox1.Text;
                        Anc_Type = comboBox2.Text;
                        Anc_Ex1 = textBox2.Text;
                        Anc_Ex2 = textBox4.Text;
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.Text != "")
                {
                    DialogResult result = MessageBox.Show("Tu es sùr de réinstaller la dernier modification effectué ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        textBox1.Text = Anc_Tr;
                        comboBox3.Text = Anc_Tr;
                        comboBox2.Text = Anc_Type;
                        textBox2.Text = Anc_Ex1;
                        textBox4.Text = Anc_Ex2;
                        OleDbCommand cmd;
                        OleDbConnection connection = new OleDbConnection();
                        connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                        if (comboBox1.Text == "Anglais")
                        {

                            string query = "UPDATE Traduction SET Type ='" + comboBox2.Text + "', Tr_AG ='" + textBox1.Text + "', Ex1_AG ='" + textBox2.Text + "', EX2_AG ='" + textBox4.Text + "' where ID_mot='" + ID_mot + "'";
                            cmd = new OleDbCommand(query, connection);
                            cmd.Parameters.AddWithValue("Type", comboBox2.Text);
                            cmd.Parameters.AddWithValue("Tr_AG", textBox1.Text);
                            cmd.Parameters.AddWithValue("Ex1_AG", textBox2.Text);
                            cmd.Parameters.AddWithValue("EX2_AG", textBox4.Text);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        else if (comboBox1.Text == "Arabe")
                        {
                            string query = "UPDATE Traduction SET Type ='" + comboBox2.Text + "', Tr_AR ='" + textBox1.Text + "', Ex1_AR ='" + textBox2.Text + "', EX2_AR ='" + textBox4.Text + "' where ID_mot='" + ID_mot + "'";
                            cmd = new OleDbCommand(query, connection);
                            cmd.Parameters.AddWithValue("Type", comboBox2.Text);
                            cmd.Parameters.AddWithValue("Tr_AR", textBox1.Text);
                            cmd.Parameters.AddWithValue("Ex1_AR", textBox2.Text);
                            cmd.Parameters.AddWithValue("EX2_AR", textBox4.Text);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        else if (comboBox1.Text == "Français")
                        {
                            string query = "UPDATE Traduction SET Type ='" + comboBox2.Text + "', Tr_FR ='" + textBox1.Text + "', Ex1_FR ='" + textBox2.Text + "', EX2_FR ='" + textBox4.Text + "' where ID_mot='" + ID_mot + "'";
                            cmd = new OleDbCommand(query, connection);
                            cmd.Parameters.AddWithValue("Type", comboBox2.Text);
                            cmd.Parameters.AddWithValue("Tr_FR", textBox1.Text);
                            cmd.Parameters.AddWithValue("Ex1_FR", textBox2.Text);
                            cmd.Parameters.AddWithValue("EX2_FR", textBox4.Text);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        else if (comboBox1.Text == "Espagnol")
                        {
                            string query = "UPDATE Traduction SET Type ='" + comboBox2.Text + "', Tr_ES ='" + textBox1.Text + "', Ex1_ES ='" + textBox2.Text + "', EX2_ES ='" + textBox4.Text + "' where ID_mot='" + ID_mot + "'";
                            cmd = new OleDbCommand(query, connection);
                            cmd.Parameters.AddWithValue("Type", comboBox2.Text);
                            cmd.Parameters.AddWithValue("Tr_ES", textBox1.Text);
                            cmd.Parameters.AddWithValue("Ex1_ES", textBox2.Text);
                            cmd.Parameters.AddWithValue("EX2_ES", textBox4.Text);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans la base de données !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                    label13.Visible = false;
                    label15.Visible = false;
                    label8.Visible = false;


                }
                else if (comboBox3.Text == "")
                {
                    comboBox3.Focus();
                    label10.Visible = false;
                    label14.Visible = true;
                    label13.Visible = false;
                    label15.Visible = false;
                    label8.Visible = false;
                }
                else if (comboBox2.Text == "")
                {
                    comboBox2.Focus();
                    label10.Visible = false;
                    label14.Visible = false;
                    label13.Visible = true;
                    label15.Visible = false;
                    label8.Visible = false;
                }
                else if (textBox2.Text == "" && textBox4.Text == "")
                {
                    comboBox2.Focus();
                    label10.Visible = false;
                    label14.Visible = false;
                    label13.Visible = false;
                    label15.Visible = true;
                    label8.Visible = false;
                }
                else if (textBox1.Text == "")
                {
                    textBox1.Focus();
                    label10.Visible = false;
                    label14.Visible = false;
                    label13.Visible = false;
                    label15.Visible = false;
                    label8.Visible = true;
                }

                else
                {
                    label10.Visible = false;
                    label14.Visible = false;
                    label13.Visible = false;
                    label15.Visible = false;
                    label8.Visible = false;
                    DialogResult result = MessageBox.Show("Tu es sùr de modifier cette traduction", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        OleDbCommand cmd;
                        OleDbConnection connection = new OleDbConnection();
                        connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                        OleDbCommand cmd2;
                        OleDbConnection connection2 = new OleDbConnection();
                        connection2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";

                        if (comboBox1.Text == "Anglais")
                        {
                           
                            string query = "UPDATE Traduction SET Type ='" + comboBox2.Text + "', Tr_AG ='" + textBox1.Text + "', Ex1_AG ='" + textBox2.Text + "', EX2_AG ='" + textBox4.Text + "' where ID_mot='" + ID_mot + "'";
                            cmd = new OleDbCommand(query, connection);
                            cmd.Parameters.AddWithValue("Type", comboBox2.Text);
                            cmd.Parameters.AddWithValue("Tr_AG",textBox1.Text);
                            cmd.Parameters.AddWithValue("Ex1_AG", textBox2.Text);
                            cmd.Parameters.AddWithValue("EX2_AG", textBox4.Text);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            comboBox3.Text = "";
                            comboBox3.Items.Clear();
                            textBox1.Text = "";
                            comboBox2.Text = "";
                            textBox4.Text = "";
                            textBox2.Text = "";
                            connection2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection2.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Anglais ", connection2);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                comboBox3.Items.Add(reader["Tr_AG"].ToString());

                            }
                        }
                        else if (comboBox1.Text == "Arabe")
                        {
                            string query = "UPDATE Traduction SET Type ='" + comboBox2.Text + "', Tr_AR ='" + textBox1.Text + "', Ex1_AR ='" + textBox2.Text + "', EX2_AR ='" + textBox4.Text + "' where ID_mot='" + ID_mot + "'";
                            cmd = new OleDbCommand(query, connection);
                            cmd.Parameters.AddWithValue("Type", comboBox2.Text);
                            cmd.Parameters.AddWithValue("Tr_AR", textBox1.Text);
                            cmd.Parameters.AddWithValue("Ex1_AR", textBox2.Text);
                            cmd.Parameters.AddWithValue("EX2_AR", textBox4.Text);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            comboBox3.Text = "";
                            comboBox3.Items.Clear();
                            textBox1.Text = "";
                            comboBox2.Text = "";
                            textBox4.Text = "";
                            textBox2.Text = "";
                            connection2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection2.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Arabe ", connection2);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                comboBox3.Items.Add(reader["Tr_AR"].ToString());

                            }
                            // Fermeture de la connexion
                            connection.Close();


                        }
                        else if (comboBox1.Text == "Français")
                        {
                            string query = "UPDATE Traduction SET Type ='" + comboBox2.Text + "', Tr_FR ='" + textBox1.Text + "', Ex1_FR ='" + textBox2.Text + "', EX2_FR ='" + textBox4.Text + "' where ID_mot='" + ID_mot + "'";
                            cmd = new OleDbCommand(query, connection);
                            cmd.Parameters.AddWithValue("Type", comboBox2.Text);
                            cmd.Parameters.AddWithValue("Tr_FR", textBox1.Text);
                            cmd.Parameters.AddWithValue("Ex1_FR", textBox2.Text);
                            cmd.Parameters.AddWithValue("EX2_FR", textBox4.Text);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            comboBox3.Text = "";
                            comboBox3.Items.Clear();
                            textBox1.Text = "";
                            comboBox2.Text = "";
                            textBox4.Text = "";
                            textBox2.Text = "";
                            connection2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection2.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Francais ", connection2);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                comboBox3.Items.Add(reader["Tr_FR"].ToString());

                            }
                        }
                        else if (comboBox1.Text == "Espagnol")
                        {
                            string query = "UPDATE Traduction SET Type ='" + comboBox2.Text + "', Tr_ES ='" + textBox1.Text + "', Ex1_ES ='" + textBox2.Text + "', EX2_ES ='" + textBox4.Text + "' where ID_mot='" + ID_mot + "'";
                            cmd = new OleDbCommand(query, connection);
                            cmd.Parameters.AddWithValue("Type", comboBox2.Text);
                            cmd.Parameters.AddWithValue("Tr_ES", textBox1.Text);
                            cmd.Parameters.AddWithValue("Ex1_ES", textBox2.Text);
                            cmd.Parameters.AddWithValue("EX2_ES", textBox4.Text);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            comboBox3.Text = "";
                            comboBox3.Items.Clear();
                            textBox1.Text = "";
                            comboBox2.Text = "";
                            textBox4.Text = "";
                            textBox2.Text = "";
                            connection2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            connection2.Open();
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Espagnol ", connection2);
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                comboBox3.Items.Add(reader["Tr_ES"].ToString());

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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = Anc_Tr;
                textBox1.Focus();
                    }
            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;");

                conn.Open();
                if (comboBox1.Text == "Anglais" && textBox1.Text != "")
                {
                    string sql = "SELECT * FROM Traduction WHERE Tr_AG LIKE '%" + textBox1.Text + "%'";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cette traduction déja existe dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    reader.Close();
                    conn.Close();
                }
                else if (comboBox1.Text == "Arabe" && textBox1.Text != "")
                {
                    string sql = "SELECT * FROM Traduction WHERE Tr_AR LIKE '%" + textBox1.Text + "%'";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cette traduction déja existe dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    reader.Close();
                    conn.Close();
                }
                else if (comboBox1.Text == "Espagnol" && textBox1.Text != "")
                {
                    string sql = "SELECT * FROM Traduction WHERE Tr_ES LIKE '%" + textBox1.Text + "%'";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cette traduction déja existe dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    reader.Close();
                    conn.Close();
                }
                else if (comboBox1.Text == "Français" && textBox1.Text != "")
                {
                    string sql = "SELECT * FROM Traduction WHERE Tr_FR LIKE '%" + textBox1.Text + "%'";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cette traduction déja existe dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de la base de données !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = Anc_Ex1;
                textBox2.Focus();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = Anc_Ex2;
                textBox4.Focus();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    }

