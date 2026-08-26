using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aura_dectionary
{
    public partial class FrmAddWord : Form
    {
        public FrmAddWord()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string word = txtword.Text.Trim();
            string meaning = txtmeaning.Text.Trim();
            string synonym = txtSynonym.Text.Trim();
            string antonym = txtantonym.Text.Trim();

            if (word == "" || meaning == "")
            {
                MessageBox.Show("Please enter Word and Meaning!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = @"INSERT INTO words
                            (word, meaning, synonym, antonym)
                            VALUES
                            (@word, @meaning, @synonym, @antonym)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@word", word);
                        cmd.Parameters.AddWithValue("@meaning", meaning);
                        cmd.Parameters.AddWithValue("@synonym", synonym);
                        cmd.Parameters.AddWithValue("@antonym", antonym);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Word Added Successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtword.Clear();
                txtmeaning.Clear();
                txtSynonym.Clear();
                txtantonym.Clear();
                txtword.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtword.Clear();
            txtmeaning.Clear();
            txtSynonym.Clear();
            txtantonym.Clear();

            txtword.Focus();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
