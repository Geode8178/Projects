using PapaJohnsGMTool.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapaJohnsGMTool.App_Forms
{
    public partial class AddRoles : App_Template
    {
        public AddRoles()
        {
            InitializeComponent();
        }

        private void addRoleBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                using (SqlConnection con = new SqlConnection(Connection.getConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_userRoles_InsertNewRole", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure; //Stored Procedure Command.

                        cmd.Parameters.AddWithValue("@roleTitle", roleTxtBx.Text.Trim());  //Role Title Insertion.
                        cmd.Parameters.AddWithValue("@roleDescription", roleDescriptionTxtBx.Text.Trim());  //Role Description Insertion.

                        if (con.State != ConnectionState.Open) //Check for connection status / Open.
                        {
                            con.Open(); //Opens connection if not already done so.
                        }
                        cmd.ExecuteNonQuery(); //Executes the insertion of the new role and description.
                        MessageBox.Show("Role has been successfuly saved.", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (con.State == ConnectionState.Open) //Check for connection status / Open.
                        {
                            con.Close(); //Closes the connection if open when insertion complete.
                        } 
                    }
                }
            }
        }

        private bool ValidateForm() //Add User Role Form Validation Arguments.
        {
            if(roleTxtBx.Text.Trim()  == string.Empty) //Checks for an empty role text box.
            {
                MessageBox.Show("A role title is requred.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roleTxtBx.Focus();
                return false;
            }
            if(roleTxtBx.Text.Length > 50) //Checks that the new role is 50 or less characters long.
            {
                MessageBox.Show("Role title needs to be less than 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roleTxtBx.Focus();
                return false;
            }
            if(roleDescriptionTxtBx.Text.Trim() == String.Empty) //Checks for an empty role description box.
            {
                MessageBox.Show("A role description is requred.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roleTxtBx.Focus();
                return false;
            }
            if (roleDescriptionTxtBx.Text.Length > 50) //Checks that the new role description is 50 characters or less.
            {
                MessageBox.Show("Role description needs to be less than 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roleTxtBx.Focus();
                return false;
            }
            return true;

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the form.
        }
    }
}
