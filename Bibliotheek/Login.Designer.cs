namespace Bibliotheek
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            tbLogMail = new TextBox();
            tbLogW8 = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 31);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "E-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 70);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Wachtwoord:";
            // 
            // tbLogMail
            // 
            tbLogMail.Location = new Point(118, 28);
            tbLogMail.Name = "tbLogMail";
            tbLogMail.Size = new Size(311, 27);
            tbLogMail.TabIndex = 2;
            // 
            // tbLogW8
            // 
            tbLogW8.Location = new Point(118, 70);
            tbLogW8.Name = "tbLogW8";
            tbLogW8.Size = new Size(311, 27);
            tbLogW8.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(118, 112);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(311, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 170);
            Controls.Add(btnLogin);
            Controls.Add(tbLogW8);
            Controls.Add(tbLogMail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbLogMail;
        private TextBox tbLogW8;
        private Button btnLogin;
    }
}