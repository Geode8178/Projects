namespace PapaJohnsGMTool.App_Forms
{
    partial class Administrator
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userAndRoleDataView = new System.Windows.Forms.DataGridView();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.updateUserBtn = new System.Windows.Forms.Button();
            this.userFunctionLbl = new System.Windows.Forms.Label();
            this.roleFunctionLbl = new System.Windows.Forms.Label();
            this.addRoleBtn = new System.Windows.Forms.Button();
            this.deleteRoleBtn = new System.Windows.Forms.Button();
            this.updateRoleBtn = new System.Windows.Forms.Button();
            this.pjLogoLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.AppExitLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userAndRoleDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // userAndRoleDataView
            // 
            this.userAndRoleDataView.AllowUserToAddRows = false;
            this.userAndRoleDataView.AllowUserToDeleteRows = false;
            this.userAndRoleDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userAndRoleDataView.Location = new System.Drawing.Point(262, 12);
            this.userAndRoleDataView.Name = "userAndRoleDataView";
            this.userAndRoleDataView.ReadOnly = true;
            this.userAndRoleDataView.Size = new System.Drawing.Size(414, 415);
            this.userAndRoleDataView.TabIndex = 1;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.Color.Black;
            this.addUserBtn.Location = new System.Drawing.Point(12, 79);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(75, 23);
            this.addUserBtn.TabIndex = 1;
            this.addUserBtn.Text = "Add ";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteUserBtn.Location = new System.Drawing.Point(12, 162);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteUserBtn.TabIndex = 2;
            this.deleteUserBtn.Text = "Delete";
            this.deleteUserBtn.UseVisualStyleBackColor = true;
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUSerBtn_Click);
            // 
            // updateUserBtn
            // 
            this.updateUserBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUserBtn.ForeColor = System.Drawing.Color.Black;
            this.updateUserBtn.Location = new System.Drawing.Point(12, 119);
            this.updateUserBtn.Name = "updateUserBtn";
            this.updateUserBtn.Size = new System.Drawing.Size(75, 23);
            this.updateUserBtn.TabIndex = 3;
            this.updateUserBtn.Text = "Update";
            this.updateUserBtn.UseVisualStyleBackColor = true;
            this.updateUserBtn.Click += new System.EventHandler(this.updateUserBtn_Click);
            // 
            // userFunctionLbl
            // 
            this.userFunctionLbl.AutoSize = true;
            this.userFunctionLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFunctionLbl.ForeColor = System.Drawing.Color.White;
            this.userFunctionLbl.Location = new System.Drawing.Point(12, 51);
            this.userFunctionLbl.Name = "userFunctionLbl";
            this.userFunctionLbl.Size = new System.Drawing.Size(142, 15);
            this.userFunctionLbl.TabIndex = 5;
            this.userFunctionLbl.Text = "Add, Update, Delete Users";
            // 
            // roleFunctionLbl
            // 
            this.roleFunctionLbl.AutoSize = true;
            this.roleFunctionLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleFunctionLbl.ForeColor = System.Drawing.Color.White;
            this.roleFunctionLbl.Location = new System.Drawing.Point(13, 199);
            this.roleFunctionLbl.Name = "roleFunctionLbl";
            this.roleFunctionLbl.Size = new System.Drawing.Size(142, 15);
            this.roleFunctionLbl.TabIndex = 7;
            this.roleFunctionLbl.Text = "Add, Update, Delete Roles";
            // 
            // addRoleBtn
            // 
            this.addRoleBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoleBtn.ForeColor = System.Drawing.Color.Black;
            this.addRoleBtn.Location = new System.Drawing.Point(10, 230);
            this.addRoleBtn.Name = "addRoleBtn";
            this.addRoleBtn.Size = new System.Drawing.Size(75, 23);
            this.addRoleBtn.TabIndex = 8;
            this.addRoleBtn.Text = "Add";
            this.addRoleBtn.UseVisualStyleBackColor = true;
            this.addRoleBtn.Click += new System.EventHandler(this.addRoleBtn_Click);
            // 
            // deleteRoleBtn
            // 
            this.deleteRoleBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRoleBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteRoleBtn.Location = new System.Drawing.Point(10, 276);
            this.deleteRoleBtn.Name = "deleteRoleBtn";
            this.deleteRoleBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteRoleBtn.TabIndex = 9;
            this.deleteRoleBtn.Text = "Delete";
            this.deleteRoleBtn.UseVisualStyleBackColor = true;
            this.deleteRoleBtn.Click += new System.EventHandler(this.deleteRoleBtn_Click);
            // 
            // updateRoleBtn
            // 
            this.updateRoleBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRoleBtn.ForeColor = System.Drawing.Color.Black;
            this.updateRoleBtn.Location = new System.Drawing.Point(10, 322);
            this.updateRoleBtn.Name = "updateRoleBtn";
            this.updateRoleBtn.Size = new System.Drawing.Size(75, 23);
            this.updateRoleBtn.TabIndex = 10;
            this.updateRoleBtn.Text = "Update";
            this.updateRoleBtn.UseVisualStyleBackColor = true;
            this.updateRoleBtn.Click += new System.EventHandler(this.updateRoleBtn_Click);
            // 
            // pjLogoLbl
            // 
            this.pjLogoLbl.AutoSize = true;
            this.pjLogoLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pjLogoLbl.ForeColor = System.Drawing.Color.Red;
            this.pjLogoLbl.Location = new System.Drawing.Point(12, 12);
            this.pjLogoLbl.Name = "pjLogoLbl";
            this.pjLogoLbl.Size = new System.Drawing.Size(240, 24);
            this.pjLogoLbl.TabIndex = 11;
            this.pjLogoLbl.Text = "Papa John\'s International";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(12, 404);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // AppExitLbl
            // 
            this.AppExitLbl.AutoSize = true;
            this.AppExitLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppExitLbl.ForeColor = System.Drawing.Color.Red;
            this.AppExitLbl.Location = new System.Drawing.Point(15, 368);
            this.AppExitLbl.Name = "AppExitLbl";
            this.AppExitLbl.Size = new System.Drawing.Size(141, 22);
            this.AppExitLbl.TabIndex = 13;
            this.AppExitLbl.Text = "Application Exit";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 439);
            this.Controls.Add(this.AppExitLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pjLogoLbl);
            this.Controls.Add(this.updateRoleBtn);
            this.Controls.Add(this.deleteRoleBtn);
            this.Controls.Add(this.addRoleBtn);
            this.Controls.Add(this.roleFunctionLbl);
            this.Controls.Add(this.userFunctionLbl);
            this.Controls.Add(this.updateUserBtn);
            this.Controls.Add(this.deleteUserBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.userAndRoleDataView);
            this.Name = "Administrator";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.userAndRoleDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView userAndRoleDataView;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button deleteUserBtn;
        private System.Windows.Forms.Button updateUserBtn;
        private System.Windows.Forms.Label userFunctionLbl;
        private System.Windows.Forms.Label roleFunctionLbl;
        private System.Windows.Forms.Button addRoleBtn;
        private System.Windows.Forms.Button deleteRoleBtn;
        private System.Windows.Forms.Button updateRoleBtn;
        private System.Windows.Forms.Label pjLogoLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label AppExitLbl;
    }
}