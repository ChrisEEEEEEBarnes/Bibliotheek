namespace Bibliotheek
{
    partial class UpdateBoek
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
            btnUpdate = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbBlz = new TextBox();
            tbGraad = new TextBox();
            tbISBN = new TextBox();
            cbGenre = new ComboBox();
            tbTitel = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tbOISBN = new TextBox();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(221, 206);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(287, 29);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Boek Updaten";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 175);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 20;
            label5.Text = "Genre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 146);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 19;
            label4.Text = "Bladzijden:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 113);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 18;
            label3.Text = "Graad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 80);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 17;
            label2.Text = "ISBNNummer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 47);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 16;
            label1.Text = "Titel:";
            // 
            // tbBlz
            // 
            tbBlz.Location = new Point(357, 139);
            tbBlz.Name = "tbBlz";
            tbBlz.Size = new Size(151, 27);
            tbBlz.TabIndex = 15;
            // 
            // tbGraad
            // 
            tbGraad.Location = new Point(357, 106);
            tbGraad.Name = "tbGraad";
            tbGraad.Size = new Size(151, 27);
            tbGraad.TabIndex = 14;
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(357, 73);
            tbISBN.Name = "tbISBN";
            tbISBN.Size = new Size(151, 27);
            tbISBN.TabIndex = 13;
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(357, 172);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(151, 28);
            cbGenre.TabIndex = 12;
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(357, 40);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(151, 27);
            tbTitel.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 18);
            label6.Name = "label6";
            label6.Size = new Size(245, 20);
            label6.TabIndex = 22;
            label6.Text = "ISBN van boek die je wil aanpassen:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(328, 18);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 23;
            // 
            // tbOISBN
            // 
            tbOISBN.Location = new Point(357, 7);
            tbOISBN.Name = "tbOISBN";
            tbOISBN.Size = new Size(152, 27);
            tbOISBN.TabIndex = 24;
            // 
            // UpdateBoek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 244);
            Controls.Add(tbOISBN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbBlz);
            Controls.Add(tbGraad);
            Controls.Add(tbISBN);
            Controls.Add(cbGenre);
            Controls.Add(tbTitel);
            Name = "UpdateBoek";
            Text = "UpdateBoek";
            Load += UpdateBoek_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbBlz;
        private TextBox tbGraad;
        private TextBox tbISBN;
        private ComboBox cbGenre;
        private TextBox tbTitel;
        private Label label6;
        private Label label7;
        private TextBox tbOISBN;
    }
}