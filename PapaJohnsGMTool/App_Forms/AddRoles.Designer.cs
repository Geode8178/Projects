namespace PapaJohnsGMTool.App_Forms
{
    partial class AddRoles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roleLbl = new System.Windows.Forms.Label();
            this.roleDescLbl = new System.Windows.Forms.Label();
            this.addRoleBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.roleTxtBx = new System.Windows.Forms.TextBox();
            this.roleDescriptionTxtBx = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchRoleTxtBx = new System.Windows.Forms.TextBox();
            this.searchRoleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.ForeColor = System.Drawing.Color.White;
            this.roleLbl.Location = new System.Drawing.Point(12, 29);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(35, 15);
            this.roleLbl.TabIndex = 0;
            this.roleLbl.Text = "Role:";
            // 
            // roleDescLbl
            // 
            this.roleDescLbl.AutoSize = true;
            this.roleDescLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleDescLbl.ForeColor = System.Drawing.Color.White;
            this.roleDescLbl.Location = new System.Drawing.Point(12, 79);
            this.roleDescLbl.Name = "roleDescLbl";
            this.roleDescLbl.Size = new System.Drawing.Size(99, 15);
            this.roleDescLbl.TabIndex = 1;
            this.roleDescLbl.Text = "Role Description:";
            // 
            // addRoleBtn
            // 
            this.addRoleBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoleBtn.Location = new System.Drawing.Point(12, 250);
            this.addRoleBtn.Name = "addRoleBtn";
            this.addRoleBtn.Size = new System.Drawing.Size(75, 23);
            this.addRoleBtn.TabIndex = 3;
            this.addRoleBtn.Text = "Add Role";
            this.addRoleBtn.UseVisualStyleBackColor = true;
            this.addRoleBtn.Click += new System.EventHandler(this.addRoleBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(171, 250);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // roleTxtBx
            // 
            this.roleTxtBx.Location = new System.Drawing.Point(53, 26);
            this.roleTxtBx.Name = "roleTxtBx";
            this.roleTxtBx.Size = new System.Drawing.Size(193, 20);
            this.roleTxtBx.TabIndex = 1;
            // 
            // roleDescriptionTxtBx
            // 
            this.roleDescriptionTxtBx.Location = new System.Drawing.Point(12, 104);
            this.roleDescriptionTxtBx.Multiline = true;
            this.roleDescriptionTxtBx.Name = "roleDescriptionTxtBx";
            this.roleDescriptionTxtBx.Size = new System.Drawing.Size(234, 100);
            this.roleDescriptionTxtBx.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 200);
            this.dataGridView1.TabIndex = 6;
            // 
            // searchRoleTxtBx
            // 
            this.searchRoleTxtBx.Location = new System.Drawing.Point(283, 250);
            this.searchRoleTxtBx.Name = "searchRoleTxtBx";
            this.searchRoleTxtBx.Size = new System.Drawing.Size(373, 20);
            this.searchRoleTxtBx.TabIndex = 5;
            // 
            // searchRoleBtn
            // 
            this.searchRoleBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRoleBtn.Location = new System.Drawing.Point(671, 248);
            this.searchRoleBtn.Name = "searchRoleBtn";
            this.searchRoleBtn.Size = new System.Drawing.Size(75, 23);
            this.searchRoleBtn.TabIndex = 6;
            this.searchRoleBtn.Text = "Search";
            this.searchRoleBtn.UseVisualStyleBackColor = true;
            // 
            // AddRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 318);
            this.Controls.Add(this.searchRoleBtn);
            this.Controls.Add(this.searchRoleTxtBx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.roleDescriptionTxtBx);
            this.Controls.Add(this.roleTxtBx);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addRoleBtn);
            this.Controls.Add(this.roleDescLbl);
            this.Controls.Add(this.roleLbl);
            this.Name = "AddRoles";
            this.Text = "Add and View User Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label roleDescLbl;
        private System.Windows.Forms.Button addRoleBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox roleTxtBx;
        private System.Windows.Forms.TextBox roleDescriptionTxtBx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchRoleTxtBx;
        private System.Windows.Forms.Button searchRoleBtn;
    }
}