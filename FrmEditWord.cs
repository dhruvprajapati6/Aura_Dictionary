using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aura_dectionary
{
    public partial class FrmEditWord : Form
    {
        public FrmEditWord()
        {
            InitializeComponent();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string word = txtword.Text.Trim();

            if (word == "")
            {
                MessageBox.Show(
                    "Please enter a word.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
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
                        cmd.Parameters.AddWithValue("@word", word);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtmeaning.Text = reader["meaning"].ToString();
                                txtSynonym.Text = reader["synonym"].ToString();
                                txtantonym.Text = reader["antonym"].ToString();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Word not found.",
                                    "Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                txtmeaning.Clear();
                                txtSynonym.Clear();
                                txtantonym.Clear();
                            }
                        }
                    }
                }
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(txtword.Text.Trim() == "")
    {
                MessageBox.Show("Please enter a word.");
                return;
            }

            if (txtmeaning.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Meaning.");
                return;
            }

            try
            {
                using (MySqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = @"UPDATE words
                             SET meaning = @meaning,
                                 synonym = @synonym,
                                 antonym = @antonym
                             WHERE word = @word";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@word", txtword.Text.Trim());
                        cmd.Parameters.AddWithValue("@meaning", txtmeaning.Text.Trim());
                        cmd.Parameters.AddWithValue("@synonym", txtSynonym.Text.Trim());
                        cmd.Parameters.AddWithValue("@antonym", txtantonym.Text.Trim());

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Word updated successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Word not found.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
