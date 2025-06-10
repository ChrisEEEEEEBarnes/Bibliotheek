namespace Bibliotheek
{
    partial class Beheerders
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
            btnGetGebruikers = new Button();
            btnGetBoeken = new Button();
            SuspendLayout();
            // 
            // btnGetGebruikers
            // 
            btnGetGebruikers.Location = new Point(40, 32);
            btnGetGebruikers.Name = "btnGetGebruikers";
            btnGetGebruikers.Size = new Size(472, 84);
            btnGetGebruikers.TabIndex = 0;
            btnGetGebruikers.Text = "Overzicht van gebruikers";
            btnGetGebruikers.UseVisualStyleBackColor = true;
            btnGetGebruikers.Click += btnGetGebruikers_Click;
            // 
            // btnGetBoeken
            // 
            btnGetBoeken.Location = new Point(40, 134);
            btnGetBoeken.Name = "btnGetBoeken";
            btnGetBoeken.Size = new Size(472, 83);
            btnGetBoeken.TabIndex = 1;
            btnGetBoeken.Text = "Overzicht van boeken";
            btnGetBoeken.UseVisualStyleBackColor = true;
            btnGetBoeken.Click += btnGetBoeken_Click;
            // 
            // Beheerders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 235);
            Controls.Add(btnGetBoeken);
            Controls.Add(btnGetGebruikers);
            Name = "Beheerders";
            Text = "Beheerders";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetGebruikers;
        private Button btnGetBoeken;
    }
}