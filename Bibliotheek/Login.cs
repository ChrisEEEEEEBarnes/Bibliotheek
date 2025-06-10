using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain_Bibliotheek.Business;

namespace Bibliotheek
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Controller con = new Controller();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string mail= tbLogMail.Text;
            string w8=tbLogW8.Text;
            con.Login(mail, w8);
            if(con.Login(mail, w8) == 1)
            {
                if (con.Recht(mail) == 1)
                {
                    OverzichtBeheerderBoeken beheerboek = new OverzichtBeheerderBoeken();
                    beheerboek.Show();
                    this.Hide();
                }
                else
                {
                    OverzichtAlleBoeken boek = new OverzichtAlleBoeken();
                    boek.Show();
                    this.Hide();
                }

            }
        }
    }
}
