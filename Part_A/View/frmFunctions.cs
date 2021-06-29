using System;
using System.Windows.Forms;

namespace Part_A.View
{
    public partial class frmFunctions : Form
    {
        private Form anterior;
        public frmFunctions(Form anteriores)
        {
            InitializeComponent();
            anterior = anteriores;
        }

        private void btnEmployes_Click(object sender, EventArgs e)
        {
            frmShowEmployes employes = new frmShowEmployes(this);
            employes.Show();
            this.Hide();
        }

        private void btnSetAppoiment_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnVaccinate_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void frmFunctions_FormClosed(object sender, FormClosedEventArgs e)
        {
            anterior.Show();
        }

        private void btnCabin_Click(object sender, EventArgs e)
        {
            frmShowCabin cabin = new frmShowCabin(this);
            cabin.Show();
            this.Hide();
        }
    }
}