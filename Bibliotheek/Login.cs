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

namespace Bibliotheek
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conn = new MySqlConnection("server = localhost; userid = root; database = bibliotheek");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from gebruiker where Mail = '" + tbLogMail.Text + "' and Wachtwoord = '" + tbLogW8.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("username and password are matched", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OverzichtAlleBoeken boek = new OverzichtAlleBoeken();
                boek.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Incorrect Username and Password", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
