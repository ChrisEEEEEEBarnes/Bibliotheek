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
    public partial class Beheerders : Form
    {
        public Beheerders()
        {
            InitializeComponent();
        }

        private void btnGetGebruikers_Click(object sender, EventArgs e)
        {
            BoekenOverzicht gebruiker = new BoekenOverzicht();
            gebruiker.Show();
            this.Close();
        }

        private void btnGetBoeken_Click(object sender, EventArgs e)
        {
            OverzichtBeheerderBoeken boek=new OverzichtBeheerderBoeken();
            boek.Show();
            this.Close();
        }
    }
}
