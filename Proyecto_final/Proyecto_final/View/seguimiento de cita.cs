using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_final.Functions;

namespace Proyecto_final.View
{
    public partial class seguimiento_de_cita : Form
    {
        private Command comando = new Command(); 
        private Form1 ventana;
       
        public seguimiento_de_cita(Form1 ventana)
        {
            InitializeComponent();
            this.ventana = ventana;
        }
        
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            ventana.Show();
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string comparacion = txtDuiIngreso.Text;
            bool comp = comando.CStringComparer(comparacion, 0, "Select * From CIUDADANO");
            if ( comp )
            {
              MessageBox.Show("Se encontró coincidencia ", "covid app",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabSeguimiento.SelectedIndex = 1;
                DataSet var = comando.CShowTable("SELECT * FROM PRIMERA_CITA WHERE id_primera_cita ="+comando.CGetAppointmentFromDui(comparacion), "Primera Cita");
                DataSet var2 = comando.CShowTable("SELECT * FROM SEGUNDA_CITA WHERE id_primera_cita ="+comando.CGetAppointmentFromDui(comparacion), "Segunda Cita");
                dgvCita.DataSource = var.Tables[0];
                dgvcita2.DataSource = var2.Tables[0];
            }
            else
                MessageBox.Show("No se encontró coincidencia ", "covid app", 
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnEspera_Click(object sender, EventArgs e)
        {
            ProcesoDeVacunacion ventana = new ProcesoDeVacunacion(this);
            DateTime Entrada = DateTime.Now;
            comando.CUpdateWaitArea(txtDuiIngreso.Text,Entrada);
            ventana.recibirdui(txtDuiIngreso.Text);
            ventana.Show();
            this.Close();
            MessageBox.Show("El paciente paso a la sala de espera", "covid app",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("volviendo a seguimiento de citas ", "covid app",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabSeguimiento.SelectedIndex = 0;
        }

        private void seguimiento_de_cita_Load(object sender, EventArgs e)
        {
            tabSeguimiento.ItemSize = new Size(1,0 );
        }
    }
}