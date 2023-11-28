using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Dictionnary
{
    public partial class Plaintes : Form
    {
        public Plaintes()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimePicker1.Enabled = true;

            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void Plaintes_Load(object sender, EventArgs e)
        {
           string AA = DateTime.Now.Year.ToString();
           String mm = DateTime.Now.Month.ToString();
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
           
            string requete = "SELECT * FROM Complements2 WHERE Année='" + AA+ "' and Mois ='" + mm + "'";
            OleDbCommand commande = new OleDbCommand(requete, connection);

           

            // Création du DataTable et du DataAdapter
            DataTable table = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(commande);

            // Remplissage du DataTable
            adapter.Fill(table);

            // Affichage des résultats dans la DataGridView
            dataGridView1.DataSource = table;

            // Fermeture de la connexion
            connection.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    OleDbConnection connection = new OleDbConnection(ConnectionString);
                    connection.Open();
                    string requete = "SELECT * FROM Complements2 WHERE Année='" + dateTimePicker1.Value.Year + "' and Mois ='" + dateTimePicker1.Value.Month + "' and Jour='" + dateTimePicker1.Value.Day + "'";
                    OleDbCommand commande = new OleDbCommand(requete, connection);
                    DataTable table = new DataTable();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(commande);
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    connection.Close();
                    checkBox1.Checked = false;
                    label3.Visible = false;
                    if (dataGridView1.CurrentCell == null)
                    {
                        MessageBox.Show("Aucune donnée existe dans cette date !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    OleDbConnection connection = new OleDbConnection(ConnectionString);
                    connection.Open();
                    string requete = "SELECT * FROM Complements2 WHERE Année='" + textBox2.Text + "' and Mois ='" + textBox1.Text + "'";
                    OleDbCommand commande = new OleDbCommand(requete, connection);
                    DataTable table = new DataTable();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(commande);
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    connection.Close();
                    label3.Visible = false;
                    if (dataGridView1.CurrentCell == null )
                    {
                        MessageBox.Show("Aucune donnée existe dans cette date !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
            

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string valeur = row.Cells["ID"].Value.ToString();
                dataGridView1.Rows.Remove(row);
                OleDbCommand cmd;
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                string query = "DELETE FROM Complements where ID='" + valeur + "'";
                cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("ID", valeur);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Suppression est effectué avec succées !", "Succées", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("Veuiller selectionner le plainte que vous souhaitez supprimer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Mois";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Année";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }
    }
    }

