namespace Bibliotheek
{
    partial class Registratie
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
            tbNaam = new TextBox();
            tbVNaam = new TextBox();
            tbMail = new TextBox();
            tbWachtwoord = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // tbNaam
            // 
            tbNaam.Location = new Point(119, 20);
            tbNaam.Name = "tbNaam";
            tbNaam.Size = new Size(510, 27);
            tbNaam.TabIndex = 0;
            // 
            // tbVNaam
            // 
            tbVNaam.Location = new Point(119, 58);
            tbVNaam.Name = "tbVNaam";
            tbVNaam.Size = new Size(510, 27);
            tbVNaam.TabIndex = 1;
            // 
            // tbMail
            // 
            tbMail.Location = new Point(119, 91);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(510, 27);
            tbMail.TabIndex = 2;
            // 
            // tbWachtwoord
            // 
            tbWachtwoord.Location = new Point(119, 127);
            tbWachtwoord.Name = "tbWachtwoord";
            tbWachtwoord.Size = new Size(510, 27);
            tbWachtwoord.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 27);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Naam:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 61);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 5;
            label2.Text = "Voornaam:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 94);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 124);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 7;
            label4.Text = "Wachtwoord:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(119, 160);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(510, 29);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Registreer";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Registratie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 200);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbWachtwoord);
            Controls.Add(tbMail);
            Controls.Add(tbVNaam);
            Controls.Add(tbNaam);
            Name = "Registratie";
            Text = "Registratie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNaam;
        private TextBox tbVNaam;
        private TextBox tbMail;
        private TextBox tbWachtwoord;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegister;
    }
}