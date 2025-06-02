namespace Bibliotheek
{
    partial class OverzichtBeheerderBoeken
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
            lbBhBoek = new ListBox();
            btnBoekvoeg = new Button();
            SuspendLayout();
            // 
            // lbBhBoek
            // 
            lbBhBoek.AccessibleRole = AccessibleRole.PageTabList;
            lbBhBoek.FormattingEnabled = true;
            lbBhBoek.Location = new Point(12, 23);
            lbBhBoek.Name = "lbBhBoek";
            lbBhBoek.Size = new Size(437, 404);
            lbBhBoek.TabIndex = 0;
            // 
            // btnBoekvoeg
            // 
            btnBoekvoeg.Location = new Point(477, 23);
            btnBoekvoeg.Name = "btnBoekvoeg";
            btnBoekvoeg.Size = new Size(285, 99);
            btnBoekvoeg.TabIndex = 1;
            btnBoekvoeg.Text = "Boek Toevoegen";
            btnBoekvoeg.UseVisualStyleBackColor = true;
            btnBoekvoeg.Click += btnBoekvoeg_Click;
            // 
            // OverzichtBeheerderBoeken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBoekvoeg);
            Controls.Add(lbBhBoek);
            Name = "OverzichtBeheerderBoeken";
            Text = "OverzichtBeheerderBoeken";
            Load += OverzichtBeheerderBoeken_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbBhBoek;
        private Button btnBoekvoeg;
    }
}