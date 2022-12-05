
namespace client_management
{
    partial class ClientUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clientDataGrid = new System.Windows.Forms.DataGridView();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clientDataGrid
            // 
            this.clientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGrid.Location = new System.Drawing.Point(-6, 311);
            this.clientDataGrid.Name = "clientDataGrid";
            this.clientDataGrid.RowHeadersWidth = 62;
            this.clientDataGrid.RowTemplate.Height = 33;
            this.clientDataGrid.Size = new System.Drawing.Size(722, 297);
            this.clientDataGrid.TabIndex = 0;
            this.clientDataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.clientDataGrid_CellBeginEdit);
            this.clientDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDataGrid_CellEndEdit);
            // 
            // fNameTxt
            // 
            this.fNameTxt.Location = new System.Drawing.Point(168, 52);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(249, 31);
            this.fNameTxt.TabIndex = 1;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(26, 58);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(97, 25);
            this.firstNameLbl.TabIndex = 2;
            this.firstNameLbl.Text = "First Name";
            // 
            // lNameTxt
            // 
            this.lNameTxt.Location = new System.Drawing.Point(168, 92);
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(249, 31);
            this.lNameTxt.TabIndex = 1;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(26, 95);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(95, 25);
            this.lastNameLbl.TabIndex = 2;
            this.lastNameLbl.Text = "Last Name";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(168, 129);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(249, 31);
            this.phoneTxt.TabIndex = 1;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(26, 132);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(132, 25);
            this.phoneLbl.TabIndex = 2;
            this.phoneLbl.Text = "Phone Number";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(168, 166);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(249, 31);
            this.emailTxt.TabIndex = 1;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(26, 169);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(124, 25);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email Address";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(26, 223);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 34);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add Client";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(466, 262);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(230, 34);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Remove Selected Client";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ClientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 594);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.lNameTxt);
            this.Controls.Add(this.fNameTxt);
            this.Controls.Add(this.clientDataGrid);
            this.Name = "ClientUI";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientDataGrid;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox lNameTxt;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

