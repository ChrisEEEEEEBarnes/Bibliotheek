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
    public partial class Registratie : Form
    {
        public Registratie()
        {
            InitializeComponent();
        }
        Controller con=new Controller();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string Naam = tbNaam.Text;
                string VNaam = tbVNaam.Text;
                string Mail = tbMail.Text;
                string Wachtwoord = tbWachtwoord.Text;
                con.AddGebruiker(Naam, VNaam, Mail, Wachtwoord);
            }
            catch
            {
                MessageBox.Show("Oeps er ging iets mis", "foutmelding", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
