namespace Bibliotheek
{
    partial class OverzichtAlleBoeken
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
            lbOverzicht = new ListBox();
            SuspendLayout();
            // 
            // lbOverzicht
            // 
            lbOverzicht.FormattingEnabled = true;
            lbOverzicht.Location = new Point(77, 42);
            lbOverzicht.Name = "lbOverzicht";
            lbOverzicht.Size = new Size(658, 304);
            lbOverzicht.TabIndex = 0;
            // 
            // OverzichtAlleBoeken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbOverzicht);
            Name = "OverzichtAlleBoeken";
            Text = "OverzichtAlleBoeken";
            Load += OverzichtAlleBoeken_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbOverzicht;
    }
}