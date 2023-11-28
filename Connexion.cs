using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dictionnary
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }
        public static string Encrypt(string password)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox2.Text = "";
            textBox2.ForeColor = Color.White;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Mot de passe";
                textBox2.ForeColor = Color.Silver;
                button5.Visible = false;
                button8.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Mot de passe")
            {
                textBox2.UseSystemPasswordChar = false;
                button5.Visible = true;
                button8.Visible = false;
              
            }
               
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Mot de passe";
                textBox2.Focus();

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                button8.Visible = true;
                button5.Visible = false;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.ForeColor = Color.White;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
               
                comboBox1.Text = "Nom d'utilisateur";
                comboBox1.ForeColor = Color.Silver;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscription inscription = new Inscription();
            inscription.ShowDialog();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM Utilisateurs ", connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Nom"].ToString());
               

            }
            // Fermeture de la connexion
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM Utilisateurs where Nom ='" + comboBox1.Text + "' ", connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = (reader["Mdp"].ToString());

            }
            // Fermeture de la connexion
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox1.Text == "Nom d'utilisateur")
            {
                MessageBox.Show("Veuiller entrer un nom d'utilisateur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (textBox2.Text == "" || textBox2.Text == "Mot de passe")
            {
                MessageBox.Show("Veuiller entrer un mot de passe !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (Encrypt(textBox2.Text) !=textBox1.Text )
            {
                MessageBox.Show("Mot de passe différent !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Bienvenue "+comboBox1.Text+"", "Connexion", MessageBoxButtons.OK);
                this.Hide();
                Acceuil acceuil = new Acceuil();
                acceuil.util = comboBox1.Text;
                acceuil.Show();
              

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }





    }
}
