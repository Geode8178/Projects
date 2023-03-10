namespace InventoryControlSystem.Application_Forms
{
    partial class AppLogin
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
            this.brandLogin = new System.Windows.Forms.PictureBox();
            this.loginUserLbl = new System.Windows.Forms.Label();
            this.loginPassLbl = new System.Windows.Forms.Label();
            this.loginUserTxtBx = new System.Windows.Forms.TextBox();
            this.loginPassTxtBx = new System.Windows.Forms.TextBox();
            this.loginAccessBtn = new System.Windows.Forms.Button();
            this.loginExitBtn = new System.Windows.Forms.Button();
            this.loginVerLbl = new System.Windows.Forms.Label();
            this.loginFGotPassLbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.brandLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // brandLogin
            // 
            this.brandLogin.Image = global::InventoryControlSystem.Properties.Resources.Ryne;
            this.brandLogin.Location = new System.Drawing.Point(12, 12);
            this.brandLogin.Name = "brandLogin";
            this.brandLogin.Size = new System.Drawing.Size(363, 292);
            this.brandLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brandLogin.TabIndex = 0;
            this.brandLogin.TabStop = false;
            // 
            // loginUserLbl
            // 
            this.loginUserLbl.AutoSize = true;
            this.loginUserLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginUserLbl.Location = new System.Drawing.Point(381, 103);
            this.loginUserLbl.Name = "loginUserLbl";
            this.loginUserLbl.Size = new System.Drawing.Size(69, 15);
            this.loginUserLbl.TabIndex = 1;
            this.loginUserLbl.Text = "UserName:";
            // 
            // loginPassLbl
            // 
            this.loginPassLbl.AutoSize = true;
            this.loginPassLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginPassLbl.Location = new System.Drawing.Point(381, 139);
            this.loginPassLbl.Name = "loginPassLbl";
            this.loginPassLbl.Size = new System.Drawing.Size(63, 15);
            this.loginPassLbl.TabIndex = 2;
            this.loginPassLbl.Text = "Password:";
            // 
            // loginUserTxtBx
            // 
            this.loginUserTxtBx.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginUserTxtBx.Location = new System.Drawing.Point(447, 100);
            this.loginUserTxtBx.Name = "loginUserTxtBx";
            this.loginUserTxtBx.Size = new System.Drawing.Size(153, 23);
            this.loginUserTxtBx.TabIndex = 1;
            // 
            // loginPassTxtBx
            // 
            this.loginPassTxtBx.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginPassTxtBx.Location = new System.Drawing.Point(447, 136);
            this.loginPassTxtBx.Name = "loginPassTxtBx";
            this.loginPassTxtBx.Size = new System.Drawing.Size(153, 23);
            this.loginPassTxtBx.TabIndex = 2;
            this.loginPassTxtBx.UseSystemPasswordChar = true;
            // 
            // loginAccessBtn
            // 
            this.loginAccessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginAccessBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginAccessBtn.Location = new System.Drawing.Point(444, 192);
            this.loginAccessBtn.Name = "loginAccessBtn";
            this.loginAccessBtn.Size = new System.Drawing.Size(75, 23);
            this.loginAccessBtn.TabIndex = 3;
            this.loginAccessBtn.Text = "Access";
            this.loginAccessBtn.UseVisualStyleBackColor = true;
            this.loginAccessBtn.Click += new System.EventHandler(this.loginAccessBtn_Click);
            // 
            // loginExitBtn
            // 
            this.loginExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginExitBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginExitBtn.Location = new System.Drawing.Point(525, 192);
            this.loginExitBtn.Name = "loginExitBtn";
            this.loginExitBtn.Size = new System.Drawing.Size(75, 23);
            this.loginExitBtn.TabIndex = 4;
            this.loginExitBtn.Text = "Exit";
            this.loginExitBtn.UseVisualStyleBackColor = true;
            this.loginExitBtn.Click += new System.EventHandler(this.loginExitBtn_Click);
            // 
            // loginVerLbl
            // 
            this.loginVerLbl.AutoSize = true;
            this.loginVerLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginVerLbl.Location = new System.Drawing.Point(525, 299);
            this.loginVerLbl.Name = "loginVerLbl";
            this.loginVerLbl.Size = new System.Drawing.Size(90, 15);
            this.loginVerLbl.TabIndex = 5;
            this.loginVerLbl.Text = "2023.03.08-1.0";
            // 
            // loginFGotPassLbl
            // 
            this.loginFGotPassLbl.AutoSize = true;
            this.loginFGotPassLbl.Location = new System.Drawing.Point(445, 231);
            this.loginFGotPassLbl.Name = "loginFGotPassLbl";
            this.loginFGotPassLbl.Size = new System.Drawing.Size(100, 15);
            this.loginFGotPassLbl.TabIndex = 5;
            this.loginFGotPassLbl.TabStop = true;
            this.loginFGotPassLbl.Text = "Forgot Password?";
            this.loginFGotPassLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginFGotPassLbl_LinkClicked);
            // 
            // AppLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 314);
            this.Controls.Add(this.loginFGotPassLbl);
            this.Controls.Add(this.loginVerLbl);
            this.Controls.Add(this.loginExitBtn);
            this.Controls.Add(this.loginAccessBtn);
            this.Controls.Add(this.loginPassTxtBx);
            this.Controls.Add(this.loginUserTxtBx);
            this.Controls.Add(this.loginPassLbl);
            this.Controls.Add(this.loginUserLbl);
            this.Controls.Add(this.brandLogin);
            this.Name = "AppLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICS Login";
            ((System.ComponentModel.ISupportInitialize)(this.brandLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox brandLogin;
        private Label loginUserLbl;
        private Label loginPassLbl;
        private TextBox loginUserTxtBx;
        private TextBox loginPassTxtBx;
        private Button loginAccessBtn;
        private Button loginExitBtn;
        private Label loginVerLbl;
        private LinkLabel loginFGotPassLbl;
    }
}