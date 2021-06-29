using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Part_A.Functions;

namespace Part_A.View
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            string query = "SELECT * FROM GESTOR";
            if ((cmd.CStringComparer(txtUser.Text, 4, query) && cmd.CStringComparer(txtPassword.Text, 5, query)) == true)
            {
                tabLogin.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Contraseña o usuario incorrectos", "Sistema de vacunacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tabLogin.ItemSize = new Size(1, 1);
            tabLogin.SelectedIndex = 0;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            string query = "SELECT * FROM GESTOR";
            cmd.CStringComparer(txtUser.Text,4,query);
            cmd.CInserRegister(cmbCabin.SelectedItem.ToString());
            frmFunctions functions = new frmFunctions(this);
            functions.Show();
            this.Hide();
        }

        private void frmLogin_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                tabLogin.SelectedIndex = 0;
            }
        }
    }
}