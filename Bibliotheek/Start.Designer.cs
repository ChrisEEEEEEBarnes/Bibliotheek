namespace Bibliotheek
{
    partial class Start
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
            btnRegister = new Button();
            btnLoginStart = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(159, 107);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(438, 80);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Registreren";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLoginStart
            // 
            btnLoginStart.Location = new Point(159, 221);
            btnLoginStart.Name = "btnLoginStart";
            btnLoginStart.Size = new Size(438, 79);
            btnLoginStart.TabIndex = 1;
            btnLoginStart.Text = "Inloggen";
            btnLoginStart.UseVisualStyleBackColor = true;
            btnLoginStart.Click += btnLoginStart_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoginStart);
            Controls.Add(btnRegister);
            Name = "Start";
            Text = "Start";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Button btnLoginStart;
    }
}