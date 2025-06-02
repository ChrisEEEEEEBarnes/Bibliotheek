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
    public partial class OverzichtBeheerderBoeken : Form
    {
        public OverzichtBeheerderBoeken()
        {
            InitializeComponent();
        }
        Controller con = new Controller();
        private void OverzichtBeheerderBoeken_Load(object sender, EventArgs e)
        {
            lbBhBoek.DataSource = con.GetBoeken;
        }

        private void btnBoekvoeg_Click(object sender, EventArgs e)
        {
            ToevoegenBoek boek = new ToevoegenBoek();
            boek.Show();
        }
    }
}
