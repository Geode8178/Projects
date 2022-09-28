namespace PapaJohnsGMTool.App_Forms
{
    partial class HustleTimeMainPage
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
            this.storeNumLbl = new System.Windows.Forms.Label();
            this.storeNumberComBox = new System.Windows.Forms.ComboBox();
            this.locationLbl = new System.Windows.Forms.Label();
            this.locationTxtBox = new System.Windows.Forms.TextBox();
            this.hustleTimeMainView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hustleTimeMainView)).BeginInit();
            this.SuspendLayout();
            // 
            // storeNumLbl
            // 
            this.storeNumLbl.AutoSize = true;
            this.storeNumLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeNumLbl.ForeColor = System.Drawing.Color.White;
            this.storeNumLbl.Location = new System.Drawing.Point(13, 13);
            this.storeNumLbl.Name = "storeNumLbl";
            this.storeNumLbl.Size = new System.Drawing.Size(82, 15);
            this.storeNumLbl.TabIndex = 0;
            this.storeNumLbl.Text = "Store Number";
            // 
            // storeNumberComBox
            // 
            this.storeNumberComBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeNumberComBox.FormattingEnabled = true;
            this.storeNumberComBox.Location = new System.Drawing.Point(102, 13);
            this.storeNumberComBox.Name = "storeNumberComBox";
            this.storeNumberComBox.Size = new System.Drawing.Size(121, 23);
            this.storeNumberComBox.TabIndex = 1;
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.ForeColor = System.Drawing.Color.White;
            this.locationLbl.Location = new System.Drawing.Point(252, 16);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(52, 15);
            this.locationLbl.TabIndex = 2;
            this.locationLbl.Text = "Location";
            // 
            // locationTxtBox
            // 
            this.locationTxtBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTxtBox.Location = new System.Drawing.Point(320, 13);
            this.locationTxtBox.Name = "locationTxtBox";
            this.locationTxtBox.Size = new System.Drawing.Size(155, 21);
            this.locationTxtBox.TabIndex = 3;
            // 
            // hustleTimeMainView
            // 
            this.hustleTimeMainView.AllowUserToAddRows = false;
            this.hustleTimeMainView.AllowUserToDeleteRows = false;
            this.hustleTimeMainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hustleTimeMainView.Location = new System.Drawing.Point(13, 64);
            this.hustleTimeMainView.Name = "hustleTimeMainView";
            this.hustleTimeMainView.ReadOnly = true;
            this.hustleTimeMainView.Size = new System.Drawing.Size(775, 374);
            this.hustleTimeMainView.TabIndex = 4;
            // 
            // HustleTimeMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hustleTimeMainView);
            this.Controls.Add(this.locationTxtBox);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.storeNumberComBox);
            this.Controls.Add(this.storeNumLbl);
            this.Name = "HustleTimeMainPage";
            this.Text = "Hustle Time";
            ((System.ComponentModel.ISupportInitialize)(this.hustleTimeMainView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storeNumLbl;
        private System.Windows.Forms.ComboBox storeNumberComBox;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.TextBox locationTxtBox;
        private System.Windows.Forms.DataGridView hustleTimeMainView;
    }
}