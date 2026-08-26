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
using System.Xml.Linq;


namespace Aura_dectionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            // 1. Check empty fields
            if (txtname.Text == "" ||
                txtemail.Text == "" ||
                txtusername.Text == "" ||
                txtpassword.Text == "" ||
                txtconformpassword.Text == "")
            {
                MessageBox.Show(
                    "Please fill all fields.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // 2. Check password
            if (txtpassword.Text != txtconformpassword.Text)
            {
                MessageBox.Show(
                    "Password and Confirm Password do not match.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                // 3. Get database connection
                using (MySqlConnection con = DBConnection.GetConnection())
                {
                    // 4. Open connection
                    con.Open();

                    // 5. Insert query
                    string query = @"INSERT INTO users
                            (name, email, username, password)
                            VALUES
                            (@name, @email, @username, @password)";

                    // 6. Create command
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // 7. Add values
                        cmd.Parameters.AddWithValue("@name", txtname.Text);
                        cmd.Parameters.AddWithValue("@email", txtemail.Text);
                        cmd.Parameters.AddWithValue("@username", txtusername.Text);
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                        // 8. Execute query
                        cmd.ExecuteNonQuery();

                        // 9. Success message
                        MessageBox.Show(
                            "Registration Successful!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // 10. Clear fields
                        txtname.Clear();
                        txtemail.Clear();
                        txtusername.Clear();
                        txtpassword.Clear();
                        txtconformpassword.Clear();
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Duplicate username/email
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "Username or Email already exists.",
                        "Registration Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Database Error: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void backtologin_Click(object sender, EventArgs e)
        {
            CCCC loginForm = new CCCC();
            loginForm.Show();

            this.Hide();
        }
    }
}
