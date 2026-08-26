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
    public partial class FrmDeleteWord : Form
    {
        public FrmDeleteWord()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string word = txtdeleteword.Text.Trim();

            if (word == "")
            {
                MessageBox.Show(
                    "Please enter a word to delete.",
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

                    // First check whether word exists
                    string checkQuery =
                        "SELECT COUNT(*) FROM words WHERE word = @word";

                    using (MySqlCommand checkCmd =
                           new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@word", word);

                        int count = Convert.ToInt32(
                            checkCmd.ExecuteScalar()
                        );

                        if (count == 0)
                        {
                            MessageBox.Show(
                                "Word not found.",
                                "Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            return;
                        }
                    }

                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete '" + word + "'?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        string deleteQuery =
                            "DELETE FROM words WHERE word = @word";

                        using (MySqlCommand cmd =
                               new MySqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@word", word);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show(
                            "Word deleted successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        txtdeleteword.Clear();
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
