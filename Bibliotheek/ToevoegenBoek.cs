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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bibliotheek
{
    public partial class ToevoegenBoek : Form
    {
        public ToevoegenBoek()
        {
            InitializeComponent();
        
            tbTitel.TabIndex = 0;
            tbISBN.TabIndex = 1;
            tbGraad.TabIndex = 2;
            tbBlz.TabIndex = 3;
        }
        Controller con = new Controller();

        private void ToevoegenBoek_Load(object sender, EventArgs e)
        {
            cbGenre.DisplayMember = "Value"; // toont enkel de naam (bv. "komedie")
            cbGenre.ValueMember = "Key";     // slaat het cijfer op (bv. 1)

            cbGenre.Items.Add(new KeyValuePair<int, string>(1, "Horror"));
            cbGenre.Items.Add(new KeyValuePair<int, string>(2, "Avontuur"));
            cbGenre.Items.Add(new KeyValuePair<int, string>(3, "Roman"));
            cbGenre.Items.Add(new KeyValuePair<int, string>(4, "Fantasy"));
            cbGenre.SelectedIndex = 0;
        }
        
        /*private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGenre.SelectedItem is KeyValuePair<int, string> geselecteerd)
            {
                genreId = geselecteerd.Key;
                string genreNaam = geselecteerd.Value;

                MessageBox.Show($"Je koos genre {genreNaam} met ID {genreId}");
            }
         }*/

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
                string titel = tbTitel.Text;
                string isbn = tbISBN.Text;
                int graad= Convert.ToInt32(tbGraad.Text);
                int blz= Convert.ToInt32(tbBlz.Text);
                int genreId= (int)((KeyValuePair<int,string>)cbGenre.SelectedItem).Key;
                MessageBox.Show(genreId.ToString());

                con.AddBoek(titel, isbn, graad, blz,genreId);   
        }
    }
}
