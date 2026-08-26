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
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }

        private void FrmDictionary_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (txtword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a word.");
                return;
            }

            try
            {
                using (MySqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = @"SELECT meaning, synonym, antonym
                             FROM words
                             WHERE word = @word
                             LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@word", txtword.Text.Trim());

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblMeaning.Text = "Meaning : " + reader["meaning"].ToString();
                                lblSynonym.Text = "Synonym : " + reader["synonym"].ToString();
                                lblAntonym.Text = "Antonym : " + reader["antonym"].ToString();
                            }
                            else
                            {
                                lblMeaning.Text = "Meaning : Not Found";
                                lblSynonym.Text = "Synonym : Not Found";
                                lblAntonym.Text = "Antonym : Not Found";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error:\n" + ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtword_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtword.Text.Trim();

            lstSuggestions.Items.Clear();

            if (searchText == "")
            {
                lstSuggestions.Visible = false;
                return;
            }

            try
            {
                using (MySqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = @"SELECT word 
                             FROM words 
                             WHERE word LIKE @search 
                             ORDER BY word 
                             LIMIT 10";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@search", searchText + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lstSuggestions.Items.Add(reader["word"].ToString());
                            }
                        }
                    }
                }

                lstSuggestions.Visible = lstSuggestions.Items.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database Error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lstSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSuggestions.SelectedItem != null)
            {
                txtword.Text = lstSuggestions.SelectedItem.ToString();

                lstSuggestions.Visible = false;

                txtword.Focus();
                txtword.SelectionStart = txtword.Text.Length;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtword.Clear();
           
        }
    }
}
