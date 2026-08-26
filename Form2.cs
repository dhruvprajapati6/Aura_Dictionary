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
    public partial class CCCC : Form
    {
        public CCCC()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show(
                    "Please enter Username and Password.",
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

                    string query = @"SELECT id, name, email, username, password
                             FROM users
                             WHERE username = @username
                             AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", txtusername.Text);
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Save logged-in user's details
                                UserSession.UserId = Convert.ToInt32(reader["id"]);
                                UserSession.Name = reader["name"].ToString();
                                UserSession.Email = reader["email"].ToString();
                                UserSession.Username = reader["username"].ToString();

                                MessageBox.Show(
                                    "Login Successful!",
                                    "Welcome",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                FrmMain mainForm = new FrmMain();
                                mainForm.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid Username or Password.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
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

        private void btnregister_Click(object sender, EventArgs e)
        {
            Form1 registrationForm = new Form1();
            registrationForm.Show();

            this.Hide();
        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
