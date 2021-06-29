using System;
using System.Windows.Forms;
using Part_A.Functions;

namespace Part_A.View
{
    public partial class frmShowEmployes : Form
    {
        private Form anterior;
        public frmShowEmployes(Form anteriores)
        {
            InitializeComponent();
            anterior = anteriores;
        }

        private void frmShowEmployes_Load(object sender, EventArgs e)
        {
            Command cmd = new Command();
            string query = "SELECT * FROM EMPLEADO";
            dgvEmployes.DataSource = cmd.CShowTable(query, "TABLA_EMPLEADO");
            dgvEmployes.DataMember = "TABLA_EMPLEADO";
            dgvEmployes.Columns[0].HeaderText = "ID del empleado";
            dgvEmployes.Columns[1].HeaderText = "Nombre";
            dgvEmployes.Columns[2].HeaderText = "Correo electronico";
            dgvEmployes.Columns[3].HeaderText = "Direccion";
            dgvEmployes.Columns[4].HeaderText = "Tipo de empleado(id)";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void frmShowEmployes_FormClosed(object sender, FormClosedEventArgs e)
        {
            anterior.Show();
        }
    }
}