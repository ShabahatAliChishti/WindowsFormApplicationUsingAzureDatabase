
namespace SuperVoters
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.RoleList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MiddleInitial = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.SaveRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoleList
            // 
            this.RoleList.FormattingEnabled = true;
            this.RoleList.Location = new System.Drawing.Point(359, 90);
            this.RoleList.Name = "RoleList";
            this.RoleList.Size = new System.Drawing.Size(121, 21);
            this.RoleList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(359, 132);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(121, 20);
            this.FirstName.TabIndex = 3;
            // 
            // MiddleInitial
            // 
            this.MiddleInitial.Location = new System.Drawing.Point(359, 173);
            this.MiddleInitial.Name = "MiddleInitial";
            this.MiddleInitial.Size = new System.Drawing.Size(121, 20);
            this.MiddleInitial.TabIndex = 4;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(359, 213);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(121, 20);
            this.LastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Middle Initial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "First Name";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(287, 260);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(32, 13);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(359, 253);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(121, 20);
            this.Email.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(359, 296);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(121, 20);
            this.Address.TabIndex = 11;
            // 
            // SaveRegistration
            // 
            this.SaveRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveRegistration.Location = new System.Drawing.Point(377, 365);
            this.SaveRegistration.Name = "SaveRegistration";
            this.SaveRegistration.Size = new System.Drawing.Size(86, 25);
            this.SaveRegistration.TabIndex = 13;
            this.SaveRegistration.Text = "Save";
            this.SaveRegistration.UseVisualStyleBackColor = true;
            this.SaveRegistration.Click += new System.EventHandler(this.SaveRegistration_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveRegistration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MiddleInitial);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoleList);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RoleList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MiddleInitial;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Button SaveRegistration;
    }
}