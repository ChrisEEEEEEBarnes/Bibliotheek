using Domain_Bibliotheek.Business;

namespace Bibliotheek
{
    public partial class BoekenOverzicht : Form
    {
        public BoekenOverzicht()
        {
            InitializeComponent();
        }
        Controller con=new Controller();

        private void Form1_Load(object sender, EventArgs e)
        {
            lbUsers.DataSource = con.GetGebruikers;
        }
    }
}
