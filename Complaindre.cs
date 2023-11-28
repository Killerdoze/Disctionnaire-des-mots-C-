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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dictionnary
{
    public partial class Complaindre : Form
    {
        
        public Complaindre()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                if (textBox1.Text == "") {
                    label2.Visible = true;
                    label1.Visible = false;
                }
                else if (textBox2.Text == "") {
                    label2.Visible = false;
                    label1.Visible = true;
                }
                else {
                    label2.Visible = false;
                    label1.Visible = false;
                    Random random = new Random();
                    int id = random.Next(100, 1000000);
                    String dd = DateTime.Now.ToString("dd/MM/yyyy");
                    string hh = DateTime.Now.ToString("HH:mm:ss");

                  


                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\star store\Documents\DEB.accdb"";Persist Security Info=False;";
                    string insertQuery = "INSERT INTO Complements  VALUES (id, dd, hh, textBox1.Text, textBox2.Text )";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ID", id);
                           
                            command.Parameters.AddWithValue("@Date", dd);
                            command.Parameters.AddWithValue("@Heure", hh);
                            command.Parameters.AddWithValue("@Raison", textBox1.Text);
                            command.Parameters.AddWithValue("@Description", textBox2.Text);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Nous sommes désolé si vous avez rencontré un mal dans notre programme , complement est enregistré avec succées.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans la base de données !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Complaindre_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
