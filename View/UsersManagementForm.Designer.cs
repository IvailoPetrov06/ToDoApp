namespace ToDoApp.View
{
    partial class UsersManagementForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateUser = new System.Windows.Forms.Button();
            this.EditUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.Password,
            this.First_Name,
            this.Last_Name});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 125);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // First_Name
            // 
            this.First_Name.HeaderText = "First_Name";
            this.First_Name.Name = "First_Name";
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last_Name";
            this.Last_Name.Name = "Last_Name";
            // 
            // CreateUser
            // 
            this.CreateUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CreateUser.Location = new System.Drawing.Point(185, 151);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(99, 44);
            this.CreateUser.TabIndex = 1;
            this.CreateUser.Text = "CreateUser";
            this.CreateUser.UseVisualStyleBackColor = false;
            this.CreateUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditUser
            // 
            this.EditUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EditUser.Location = new System.Drawing.Point(333, 150);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(99, 44);
            this.EditUser.TabIndex = 2;
            this.EditUser.Text = "EditUser";
            this.EditUser.UseVisualStyleBackColor = false;
            this.EditUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DeleteUser.Location = new System.Drawing.Point(495, 152);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(99, 42);
            this.DeleteUser.TabIndex = 3;
            this.DeleteUser.Text = "DeleteUser";
            this.DeleteUser.UseVisualStyleBackColor = false;
            this.DeleteUser.Click += new System.EventHandler(this.button3_Click);
            // 
            // UsersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.CreateUser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsersManagementForm";
            this.Text = "UsersManagementForm";
            this.Load += new System.EventHandler(this.UsersManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CreateUser;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
    }
}