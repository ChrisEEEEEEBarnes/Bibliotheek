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
    public partial class OverzichtAlleBoeken : Form
    {
        public OverzichtAlleBoeken()
        {
            InitializeComponent();
        }
        Controller con = new Controller();
        private void OverzichtAlleBoeken_Load(object sender, EventArgs e)
        {
            lbOverzicht.DataSource = con.GetBoeken;
        }
    }
}
