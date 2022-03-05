
namespace SuperVoters.Forms
{
    partial class VoteResults
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
            this.ElectionDates = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Messages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voting Results";
            // 
            // ElectionDates
            // 
            this.ElectionDates.FormattingEnabled = true;
            this.ElectionDates.Location = new System.Drawing.Point(154, 87);
            this.ElectionDates.Name = "ElectionDates";
            this.ElectionDates.Size = new System.Drawing.Size(121, 21);
            this.ElectionDates.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Election Date";
            // 
            // Messages
            // 
            this.Messages.Location = new System.Drawing.Point(21, 401);
            this.Messages.MinimumSize = new System.Drawing.Size(20, 20);
            this.Messages.Multiline = true;
            this.Messages.Name = "Messages";
            this.Messages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Messages.Size = new System.Drawing.Size(207, 37);
            this.Messages.TabIndex = 19;
            // 
            // VoteResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ElectionDates);
            this.Controls.Add(this.label1);
            this.Name = "VoteResults";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VoteResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ElectionDates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Messages;
    }
}