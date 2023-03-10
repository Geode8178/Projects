using InventoryControlSystem.General_Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryControlSystem.Application_Forms
{
    
    public partial class AppLogin : FormTemplate
    {
        public AppLogin()
        {
            InitializeComponent();
        }

        private void loginAccessBtn_Click(object sender, EventArgs e)
        {
            isLoginValid(); //Calls for login form validation.

            using (SqlConnection connect = new SqlConnection("IcsConnect")) 
            {
                using (SqlCommand cmd = new SqlCommand("", connect))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Username", loginUserTxtBx.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", loginPassTxtBx.Text.Trim());

                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                      
                    }
                }
            }
        }
            
        /* Validates the usernamae and password textboxes. This is for demonstration purposes only. Customer requirements will dictate
         * future validation scripting for any login screens. Username and password styles are subject to change per client.*/
        private bool isLoginValid() 
        {
            if (loginUserTxtBx.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please enter your username to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginUserTxtBx.Focus();
                return false;
            }
            if (loginPassTxtBx.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please enter your password to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginPassTxtBx.Focus();
                return false;
            }
            return true;
        }
           
        private void loginExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Exit the application?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void loginFGotPassLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
            
        }
    }
}
