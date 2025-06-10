using Domain_Bibliotheek.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheek
{
    public partial class UpdateBoek : Form
    {
        public UpdateBoek()
        {
            InitializeComponent();
            tbOISBN.TabIndex = 0;
            tbTitel.TabIndex = 1;
            tbISBN.TabIndex = 2;
            tbGraad.TabIndex = 3;
            tbBlz.TabIndex = 4;
        }

        Controller con = new Controller();

        private void UpdateBoek_Load(object sender, EventArgs e)
        {
            cbGenre.DisplayMember = "Value"; // toont enkel de naam (bv. "komedie")
            cbGenre.ValueMember = "Key";     // slaat het cijfer op (bv. 1)

            cbGenre.Items.Add(new KeyValuePair<int, string>(1, "Horror"));
            cbGenre.Items.Add(new KeyValuePair<int, string>(2, "Avontuur"));
            cbGenre.Items.Add(new KeyValuePair<int, string>(3, "Roman"));
            cbGenre.Items.Add(new KeyValuePair<int, string>(4, "Fantasy"));
            cbGenre.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string oisbn=tbOISBN.Text;
            string titel = tbTitel.Text;
            string isbn = tbISBN.Text;
            int graad = Convert.ToInt32(tbGraad.Text);
            int blz = Convert.ToInt32(tbBlz.Text);
            int genreId = (int)((KeyValuePair<int, string>)cbGenre.SelectedItem).Key;
            MessageBox.Show(genreId.ToString());
            con.UpdateBoek(oisbn,titel, isbn, graad, blz, genreId);
        }
    }
}