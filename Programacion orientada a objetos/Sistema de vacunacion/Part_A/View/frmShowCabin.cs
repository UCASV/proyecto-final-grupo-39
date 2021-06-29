using System;
using System.Windows.Forms;
using Part_A.Functions;

namespace Part_A.View
{
    public partial class frmShowCabin : Form
    {
        private Form anterior;
        public frmShowCabin(Form anteriores)
        {
            InitializeComponent();
            anterior = anteriores;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void frmShowCabin_Load(object sender, EventArgs e)
        {
            Command cmd = new Command();
            string query = "SELECT * FROM CABINA";
            dgvCabin.DataSource = cmd.CShowTable(query, "TABLA_CABINA");
            dgvCabin.DataMember = "TABLA_CABINA";
            dgvCabin.Columns[0].HeaderText = "ID de la cabina";
            dgvCabin.Columns[1].HeaderText = "Direccion";
            dgvCabin.Columns[2].HeaderText = "Telefono";
            dgvCabin.Columns[3].HeaderText = "Nombre del encargado";
            dgvCabin.Columns[4].HeaderText = "Correo electronico";
        }


        private void frmShowCabin_FormClosed(object sender, FormClosedEventArgs e)
        {
            anterior.Show();
        }
    }
}