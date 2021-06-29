using System;
using System.Windows.Forms;
using Part_A.View;

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
            Form1 frm = new Form1(this);
            frm.Show();
            this.Hide();
        }

        private void btnVaccinate_Click(object sender, EventArgs e)
        {
            seguimiento_de_cita vacunacion = new seguimiento_de_cita(this);
            vacunacion.Show();
            this.Hide();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
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