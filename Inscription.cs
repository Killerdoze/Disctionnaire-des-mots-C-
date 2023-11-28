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

using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dictionnary
{ 
    public partial class Inscription : Form
    {   

        public bool VerifyString(string str)
        {
            // Check if the string is null or empty
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            // Check if the length of the string is 8 characters
            if (str.Length < 8)
            {
                return false;
            }

            // Check if the first letter of the string is uppercase
            if (!char.IsUpper(str[0]))
            {
                return false;
            }

            // If all conditions are met, return true
            return true;
        }
        //fonction qui permet de crypter le mdp
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
            public static bool ValiderMotDePasse(string motDePasse)
        {   
            bool estValide = true;
            char[] caracteresSpeciaux = { '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', '|', '\\', '/', ':', ';', '<', '>', '.', ',', '?', '!' };
            if (string.IsNullOrEmpty(motDePasse))
            {
                estValide = false;
            }
            else
            {
                // Vérifier que le mot de passe contient au moins 8 caractères.
                if (motDePasse.Length < 8)
                {
                    estValide = false;
                }

                // Vérifier que le mot de passe contient au moins une lettre majuscule.
                if (!motDePasse.Any(char.IsUpper))
                {
                    estValide = false;
                }

                // Vérifier que le mot de passe contient au moins une lettre minuscule.
                if (!motDePasse.Any(char.IsLower))
                {
                    estValide = false;
                }

                // Vérifier que le mot de passe contient au moins un chiffre.
                if (!motDePasse.Any(char.IsDigit))
                {
                    estValide = false;
                }
                // Vérifier que le mot de passe contien un caractére special.
                foreach (char c in motDePasse)
                {
                    if (caracteresSpeciaux.Contains(c))
                    {
                        estValide = true;
                    }
                    else { estValide = false; }
                }
            }

            return estValide;
        }
        public Inscription()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connexion Connexion = new Connexion();
            Connexion.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string myString = textBox3.Text;
                bool isVerified = VerifyString(myString);
                string motDePasse = textBox2.Text;
                bool estValide = ValiderMotDePasse(motDePasse);
                if (estValide && isVerified && textBox3.Text != "" && textBox3.Text != "Nom d'utilisateur" && textBox2.Text == textBox1.Text && textBox3.Text !="ADMIN")
                {
                    
                   
                    Random random = new Random();
                    int id = random.Next(100, 1000000);
                    string mdp = Encrypt(textBox2.Text);
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    string insertQuery = "INSERT INTO Utilisateurs (ID, Nom, Mdp) VALUES (id, textBox3, mdp)";

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ID", id);
                            command.Parameters.AddWithValue("@Nom", textBox3.Text);
                            command.Parameters.AddWithValue("@Mdp", mdp);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Inscription est effectué avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Hide();
                    Acceuil Acceuil = new Acceuil();
                    Acceuil.util = textBox3.Text;
                    Acceuil.ShowDialog();
                }
                else if (textBox3.Text == "ADMIN")
                {
                    MessageBox.Show("Tu n'a pas le droit d'avoir cette nom d'utilisateur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (estValide == true && textBox3.Text != "" && textBox3.Text == "Nom d'utilisateur")
                {
                    MessageBox.Show("Veuiller entrer un nom d'utilisateur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (isVerified == false)
                {
                    MessageBox.Show("Veuiller entrer un nom qui se compose au moins de 8 caractéres et la 1ére lettre doit étre en majiscule", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (estValide == true && textBox2.Text != textBox1.Text)
                {
                    MessageBox.Show("Mot de passe différents !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (estValide == false)
                {
                    MessageBox.Show("Le mot de passe est invalide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("Veuiller remplir les champs nécessaires !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de la base de données !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Nom d'utilisateur";
                textBox3.ForeColor = Color.Silver;
            }
            if ( textBox3.Text != "")
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;");
                conn.Open();
                string sql = "SELECT * FROM Utilisateurs WHERE Nom LIKE '%" + textBox3.Text + "%'";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Cette pseudo est déja utilisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Text = "";
                    textBox3.Focus();
                }
                reader.Close();
                conn.Close();
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Nom d'utilisateur")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.White;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Mot de passe")
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {   textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Mot de passe";
                textBox2.ForeColor = Color.Silver;
                button5.Visible = false;
                button8.Visible = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.UseSystemPasswordChar =false;
                textBox1.Text = "Confirmer le mot de passe";
                textBox1.ForeColor = Color.Silver;
                button6.Visible = false;
                button7.Visible = true;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Confirmer le mot de passe")
            {   textBox1.UseSystemPasswordChar = true;
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Confirmer le mot de passe")
            {
                textBox1.UseSystemPasswordChar = false;
                button6.Visible = true;
                button7.Visible = false;
                textBox1.Focus();
            }
         

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.UseSystemPasswordChar = false;
                textBox1.Text = "Confirmer le mot de passe";
                textBox1.Focus();

            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                button7.Visible = true;
                button6.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Mot de passe")
            {
                textBox2.UseSystemPasswordChar = false;
                button5.Visible = true;
                button8.Visible = false;
                textBox2.Focus();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
