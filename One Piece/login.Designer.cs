
namespace One_Piece
{
    partial class login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.butlog = new System.Windows.Forms.Button();
            this.passfield = new System.Windows.Forms.TextBox();
            this.logfield = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butlog
            // 
            this.butlog.Location = new System.Drawing.Point(85, 290);
            this.butlog.Name = "butlog";
            this.butlog.Size = new System.Drawing.Size(130, 44);
            this.butlog.TabIndex = 0;
            this.butlog.Text = "Ввійти";
            this.butlog.UseVisualStyleBackColor = true;
            this.butlog.Click += new System.EventHandler(this.butlog_Click);
            // 
            // passfield
            // 
            this.passfield.Location = new System.Drawing.Point(115, 214);
            this.passfield.Name = "passfield";
            this.passfield.Size = new System.Drawing.Size(100, 20);
            this.passfield.TabIndex = 1;
            // 
            // logfield
            // 
            this.logfield.Location = new System.Drawing.Point(115, 178);
            this.logfield.Name = "logfield";
            this.logfield.Size = new System.Drawing.Size(100, 20);
            this.logfield.TabIndex = 2;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 369);
            this.Controls.Add(this.logfield);
            this.Controls.Add(this.passfield);
            this.Controls.Add(this.butlog);
            this.Name = "login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butlog;
        private System.Windows.Forms.TextBox passfield;
        private System.Windows.Forms.TextBox logfield;
    }
}

