using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Dictionnary
{
   
    public partial class Ajout_tr : Form
    {
        public Ajout_tr()
        {
            InitializeComponent();
        }

        private void Ajout_tr_Load(object sender, EventArgs e)
        {   
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {   try
            {
                if (comboBox1.Text == "")
                {
                    comboBox1.Focus();
                    label10.Visible = true;
                    label14.Visible = false;
                    label13.Visible = false;
                    label15.Visible = false;
                    label19.Visible = false;
                    label17.Visible = false;
                    label16.Visible = false;

                }
                else if (textBox1.Text == "")
                {
                    label14.Visible = true;
                    textBox1.Focus();
                    label10.Visible = false;
                    label13.Visible = false;
                    label15.Visible = false;
                    label19.Visible = false;
                    label17.Visible = false;
                    label16.Visible = false;
                }
                else if (comboBox2.Text == "")
                {
                    label13.Visible = true;
                    comboBox2.Focus();
                    label14.Visible = false;
                    label10.Visible = false;
                    label15.Visible = false;
                    label19.Visible = false;
                    label17.Visible = false;
                    label16.Visible = false;
                }
                else if (textBox2.Text == "" && textBox4.Text == "")
                {
                    label15.Visible = true;
                    textBox2.Focus();
                    label14.Visible = false;
                    label13.Visible = false;
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
                    label13.Visible = false;
                    label15.Visible = false;
                    label10.Visible = false;
                    label17.Visible = false;
                    label16.Visible = false;
                }
                else if (textBox6.Text == "")
                {
                    label17.Visible = true;
                    textBox6.Focus();
                    label14.Visible = false;
                    label13.Visible = false;
                    label15.Visible = false;
                    label19.Visible = false;
                    label10.Visible = false;
                    label16.Visible = false;
                }
                else if (textBox5.Text == "" && textBox3.Text == "")
                {
                    label16.Visible = true;
                    textBox5.Focus();
                    label14.Visible = false;
                    label13.Visible = false;
                    label15.Visible = false;
                    label19.Visible = false;
                    label17.Visible = false;
                    label10.Visible = false;
                }
                else
                {
                    Random random = new Random();
                    int id = random.Next(100, 1000000);
                    label14.Visible = false;
                    label13.Visible = false;
                    label15.Visible = false;
                    label19.Visible = false;
                    label17.Visible = false;
                    label10.Visible = false;
                    label16.Visible = false;


                    if (comboBox1.Text == "Anglais")
                    {
                        if (comboBox4.Text == "Arabe")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", textBox1.Text);
                                    command.Parameters.AddWithValue("@Tr_AR", textBox6.Text);
                                    command.Parameters.AddWithValue("@Tr_ES", "-");
                                    command.Parameters.AddWithValue("@Tr_FR", "-");
                                    command.Parameters.AddWithValue("@Ex1_AG", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex1_AR", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex1_ES", "-");
                                    command.Parameters.AddWithValue("@Ex1_FR", "-");
                                    command.Parameters.AddWithValue("@Ex2_AG", textBox4.Text);
                                    command.Parameters.AddWithValue("@Ex2_AR", textBox3.Text);
                                    command.Parameters.AddWithValue("@Ex2_ES", "-");
                                    command.Parameters.AddWithValue("@Ex2_FR", "-");
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Trauction est enregistré avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        if (comboBox4.Text == "Espagnol")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", textBox1.Text);
                                    command.Parameters.AddWithValue("@Tr_AR", "-");
                                    command.Parameters.AddWithValue("@Tr_ES", textBox6.Text);
                                    command.Parameters.AddWithValue("@Tr_FR", "-");
                                    command.Parameters.AddWithValue("@Ex1_AG", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex1_AR", "-");
                                    command.Parameters.AddWithValue("@Ex1_ES", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex1_FR", "-");
                                    command.Parameters.AddWithValue("@Ex2_AG", textBox4.Text);
                                    command.Parameters.AddWithValue("@Ex2_AR", "-");
                                    command.Parameters.AddWithValue("@Ex2_ES", textBox3.Text);
                                    command.Parameters.AddWithValue("@Ex2_FR", "-");
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Trauction est enregistré  avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        if (comboBox4.Text == "Français")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", textBox1.Text);
                                    command.Parameters.AddWithValue("@Tr_AR", "-");
                                    command.Parameters.AddWithValue("@Tr_ES", "-");
                                    command.Parameters.AddWithValue("@Tr_FR", textBox6.Text);
                                    command.Parameters.AddWithValue("@Ex1_AG", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex1_AR", "-");
                                    command.Parameters.AddWithValue("@Ex1_ES", "-");
                                    command.Parameters.AddWithValue("@Ex1_FR", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex2_AG", textBox4.Text);
                                    command.Parameters.AddWithValue("@Ex2_AR", "-");
                                    command.Parameters.AddWithValue("@Ex2_ES", "-");
                                    command.Parameters.AddWithValue("@Ex2_FR", textBox3.Text);
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Trauction est enregistré  avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                    }
                    else if (comboBox1.Text == "Arabe")
                    {
                        if (comboBox4.Text == "Anglais")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", textBox6.Text);
                                    command.Parameters.AddWithValue("@Tr_AR", textBox1.Text);
                                    command.Parameters.AddWithValue("@Tr_ES", "-");
                                    command.Parameters.AddWithValue("@Tr_FR", "-");
                                    command.Parameters.AddWithValue("@Ex1_AG", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex1_AR", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex1_ES", "-");
                                    command.Parameters.AddWithValue("@Ex1_FR", "-");
                                    command.Parameters.AddWithValue("@Ex2_AG", textBox3.Text);
                                    command.Parameters.AddWithValue("@Ex2_AR", textBox4.Text);
                                    command.Parameters.AddWithValue("@Ex2_ES", "-");
                                    command.Parameters.AddWithValue("@Ex2_FR", "-");
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Trauction est enregistré avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }

                        }
                        if (comboBox4.Text == "Espagnol")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", "-");
                                    command.Parameters.AddWithValue("@Tr_AR", textBox1.Text);
                                    command.Parameters.AddWithValue("@Tr_ES", textBox6.Text);
                                    command.Parameters.AddWithValue("@Tr_FR", "-");
                                    command.Parameters.AddWithValue("@Ex1_AG", "-");
                                    command.Parameters.AddWithValue("@Ex1_AR", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex1_ES", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex1_FR", "-");
                                    command.Parameters.AddWithValue("@Ex2_AG", "-");
                                    command.Parameters.AddWithValue("@Ex2_AR", textBox4.Text);
                                    command.Parameters.AddWithValue("@Ex2_ES", textBox3.Text);
                                    command.Parameters.AddWithValue("@Ex2_FR", "-");
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Trauction est enregistré avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        if (comboBox4.Text == "Français")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", "-");
                                    command.Parameters.AddWithValue("@Tr_AR", textBox1.Text);
                                    command.Parameters.AddWithValue("@Tr_ES", "-");
                                    command.Parameters.AddWithValue("@Tr_FR", textBox6.Text);
                                    command.Parameters.AddWithValue("@Ex1_AG", "-");
                                    command.Parameters.AddWithValue("@Ex1_AR", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex1_ES", "-");
                                    command.Parameters.AddWithValue("@Ex1_FR", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex2_AG", "-");
                                    command.Parameters.AddWithValue("@Ex2_AR", textBox4.Text);
                                    command.Parameters.AddWithValue("@Ex2_ES", "-");
                                    command.Parameters.AddWithValue("@Ex2_FR", textBox3.Text);
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                   
                                    MessageBox.Show("Trauction est enregistré avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                    }
                    else if (comboBox1.Text == "Espagnol")
                    {
                        if (comboBox4.Text == "Arabe")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", "-");
                                    command.Parameters.AddWithValue("@Tr_AR", textBox6.Text);
                                    command.Parameters.AddWithValue("@Tr_ES", textBox1.Text);
                                    command.Parameters.AddWithValue("@Tr_FR", "-");
                                    command.Parameters.AddWithValue("@Ex1_AG", "-");
                                    command.Parameters.AddWithValue("@Ex1_AR", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex1_ES", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex1_FR", "-");
                                    command.Parameters.AddWithValue("@Ex2_AG", "-");
                                    command.Parameters.AddWithValue("@Ex2_AR", textBox3.Text);
                                    command.Parameters.AddWithValue("@Ex2_ES", textBox4.Text);
                                    command.Parameters.AddWithValue("@Ex2_FR", "-");
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Trauction est enregistré avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        if (comboBox4.Text == "Anglais")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", textBox6.Text);
                                    command.Parameters.AddWithValue("@Tr_AR", "-");
                                    command.Parameters.AddWithValue("@Tr_ES", textBox1.Text);
                                    command.Parameters.AddWithValue("@Tr_FR", "-");
                                    command.Parameters.AddWithValue("@Ex1_AG", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex1_AR", "-");
                                    command.Parameters.AddWithValue("@Ex1_ES", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex1_FR", "-");
                                    command.Parameters.AddWithValue("@Ex2_AG", textBox3.Text);
                                    command.Parameters.AddWithValue("@Ex2_AR", "-");
                                    command.Parameters.AddWithValue("@Ex2_ES", textBox4.Text);
                                    command.Parameters.AddWithValue("@Ex2_FR", "-");
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Trauction est enregistré avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                        if (comboBox4.Text == "Français")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", "-");
                                    command.Parameters.AddWithValue("@Tr_AR", "-");
                                    command.Parameters.AddWithValue("@Tr_ES", textBox1.Text);
                                    command.Parameters.AddWithValue("@Tr_FR", textBox6.Text);
                                    command.Parameters.AddWithValue("@Ex1_AG", "-");
                                    command.Parameters.AddWithValue("@Ex1_AR", "-");
                                    command.Parameters.AddWithValue("@Ex1_ES", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex1_FR", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex2_AG", "-");
                                    command.Parameters.AddWithValue("@Ex2_AR", "-");
                                    command.Parameters.AddWithValue("@Ex2_ES", textBox4.Text);
                                    command.Parameters.AddWithValue("@Ex2_FR", textBox3.Text);
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                    
                                    MessageBox.Show("Trauction est enregistré avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                    }
                    else if (comboBox1.Text == "Français")
                    {
                        if (comboBox4.Text == "Arabe")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", "-");
                                    command.Parameters.AddWithValue("@Tr_AR", textBox6.Text);
                                    command.Parameters.AddWithValue("@Tr_ES", "-");
                                    command.Parameters.AddWithValue("@Tr_FR", textBox1.Text);
                                    command.Parameters.AddWithValue("@Ex1_AG", "-");
                                    command.Parameters.AddWithValue("@Ex1_AR", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex1_ES", "-");
                                    command.Parameters.AddWithValue("@Ex1_FR", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex2_AG", "-");
                                    command.Parameters.AddWithValue("@Ex2_AR", textBox3.Text);
                                    command.Parameters.AddWithValue("@Ex2_ES", "-");
                                    command.Parameters.AddWithValue("@Ex2_FR", textBox4.Text);
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                    
                                    MessageBox.Show("Trauction est enregistré avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        if (comboBox4.Text == "Espagnol")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", "-");
                                    command.Parameters.AddWithValue("@Tr_AR", "-");
                                    command.Parameters.AddWithValue("@Tr_ES", textBox6.Text);
                                    command.Parameters.AddWithValue("@Tr_FR", textBox1.Text);
                                    command.Parameters.AddWithValue("@Ex1_AG", "-");
                                    command.Parameters.AddWithValue("@Ex1_AR", "-");
                                    command.Parameters.AddWithValue("@Ex1_ES", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex1_FR", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex2_AG", "-");
                                    command.Parameters.AddWithValue("@Ex2_AR", "-");
                                    command.Parameters.AddWithValue("@Ex2_ES", textBox3.Text);
                                    command.Parameters.AddWithValue("@Ex2_FR", textBox4.Text);
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                    
                                    MessageBox.Show("Trauction est enregistré avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        if (comboBox4.Text == "Anglais")
                        {
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                            string insertQuery = "INSERT INTO Traduction VALUES (ID_mot, Type, Tr_AG, Tr_AR, Tr_ES, Tr_FR, Ex1_AG, Ex1_AR, Ex1_ES, Ex1_FR, Ex2_AG, Ex2_AR, Ex2_ES, Ex2_FR)";

                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_mot", id);
                                    command.Parameters.AddWithValue("@Type", comboBox2.Text);
                                    command.Parameters.AddWithValue("@Tr_AG", textBox6.Text);
                                    command.Parameters.AddWithValue("@Tr_AR", "-");
                                    command.Parameters.AddWithValue("@Tr_ES", "-");
                                    command.Parameters.AddWithValue("@Tr_FR", textBox1.Text);
                                    command.Parameters.AddWithValue("@Ex1_AG", textBox5.Text);
                                    command.Parameters.AddWithValue("@Ex1_AR", "-");
                                    command.Parameters.AddWithValue("@Ex1_ES", "-");
                                    command.Parameters.AddWithValue("@Ex1_FR", textBox2.Text);
                                    command.Parameters.AddWithValue("@Ex2_AG", textBox3.Text);
                                    command.Parameters.AddWithValue("@Ex2_AR", "-");
                                    command.Parameters.AddWithValue("@Ex2_ES", "-");
                                    command.Parameters.AddWithValue("@Ex2_FR", textBox4.Text);
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Trauction est enregistré  avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                    }
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de la base de données !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox4.Text)
            {
                comboBox4.Text = "";
                comboBox4.Focus();
                MessageBox.Show("La traduction ne peut pas étre effectué que entre deux langues differents.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox4_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox4.Text)
            {
                comboBox4.Text = "";
                comboBox4.Focus();
                MessageBox.Show("La traduction ne peut pas étre effectué que entre deux langues differents.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
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

        private void textBox6_Leave(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;");

                conn.Open();
                if (comboBox4.Text == "Anglais" && textBox6.Text != "")
                {
                    string sql = "SELECT * FROM Traduction WHERE Tr_AG LIKE '%" + textBox6.Text + "%'";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cette traduction déja existe dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox6.Text = "";
                        textBox6.Focus();
                    }
                    reader.Close();
                    conn.Close();
                }
                else if (comboBox4.Text == "Arabe" && textBox6.Text != "")
                {
                    string sql = "SELECT * FROM Traduction WHERE Tr_AR LIKE '%" + textBox6.Text + "%'";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cette traduction déja existe dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox6.Text = "";
                        textBox6.Focus();
                    }
                    reader.Close();
                    conn.Close();
                }
                else if (comboBox4.Text == "Espagnol" && textBox6.Text != "")
                {
                    string sql = "SELECT * FROM Traduction WHERE Tr_ES LIKE '%" + textBox6.Text + "%'";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cette traduction déja existe dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox6.Text = "";
                        textBox6.Focus();
                    }
                    reader.Close();
                    conn.Close();
                }
                else if (comboBox4.Text == "Français" && textBox6.Text != "")
                {
                    string sql = "SELECT * FROM Traduction WHERE Tr_FR LIKE '%" + textBox6.Text + "%'";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cette traduction déja existe dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox6.Text = "";
                        textBox6.Focus();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
