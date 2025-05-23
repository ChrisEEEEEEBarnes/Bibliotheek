namespace Bibliotheek
{
    partial class ToevoegenBoek
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
            tbTitel = new TextBox();
            cbGenre = new ComboBox();
            tbISBN = new TextBox();
            tbGraad = new TextBox();
            tbBlz = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnVoegToe = new Button();
            SuspendLayout();
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(263, 36);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(151, 27);
            tbTitel.TabIndex = 0;
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(263, 168);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(151, 28);
            cbGenre.TabIndex = 1;
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(263, 69);
            tbISBN.Name = "tbISBN";
            tbISBN.Size = new Size(151, 27);
            tbISBN.TabIndex = 2;
            // 
            // tbGraad
            // 
            tbGraad.Location = new Point(263, 102);
            tbGraad.Name = "tbGraad";
            tbGraad.Size = new Size(151, 27);
            tbGraad.TabIndex = 3;
            // 
            // tbBlz
            // 
            tbBlz.Location = new Point(263, 135);
            tbBlz.Name = "tbBlz";
            tbBlz.Size = new Size(151, 27);
            tbBlz.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 43);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 5;
            label1.Text = "Titel:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 76);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 6;
            label2.Text = "ISBNNummer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 109);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 7;
            label3.Text = "Graad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 142);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 8;
            label4.Text = "Bladzijden:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 171);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 9;
            label5.Text = "Genre:";
            // 
            // btnVoegToe
            // 
            btnVoegToe.Location = new Point(127, 202);
            btnVoegToe.Name = "btnVoegToe";
            btnVoegToe.Size = new Size(287, 29);
            btnVoegToe.TabIndex = 10;
            btnVoegToe.Text = "Voeg boek toe";
            btnVoegToe.UseVisualStyleBackColor = true;
            btnVoegToe.Click += btnVoegToe_Click;
            // 
            // ToevoegenBoek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoegToe);
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
            Name = "ToevoegenBoek";
            Text = "ToevoegenBoek";
            Load += ToevoegenBoek_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitel;
        private ComboBox cbGenre;
        private TextBox tbISBN;
        private TextBox tbGraad;
        private TextBox tbBlz;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnVoegToe;
    }
}