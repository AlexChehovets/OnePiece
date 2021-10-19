
namespace One_Piece
{
    partial class Form1
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
            this.userNameField = new System.Windows.Forms.TextBox();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(151, 45);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(100, 22);
            this.userNameField.TabIndex = 0;
            // 
            // loginfield
            // 
            this.loginfield.Location = new System.Drawing.Point(334, 98);
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(100, 22);
            this.loginfield.TabIndex = 1;
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(334, 45);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(100, 22);
            this.passField.TabIndex = 2;
            // 
            // userSurnameField
            // 
            this.userSurnameField.Location = new System.Drawing.Point(151, 98);
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(100, 22);
            this.userSurnameField.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userSurnameField);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginfield);
            this.Controls.Add(this.userNameField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.Button button1;
    }
}