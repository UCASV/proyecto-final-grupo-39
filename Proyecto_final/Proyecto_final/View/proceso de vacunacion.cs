using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_final.Functions;

namespace Proyecto_final.View
{
    public partial class ProcesoDeVacunacion : Form
    {
        private Command comando = new Command();
        Random gen = new Random();
        private string DUI;
        private seguimiento_de_cita _ventana;
        public ProcesoDeVacunacion(seguimiento_de_cita ventana)
        {
            InitializeComponent();
            this._ventana = ventana;
        }
        public void recibirdui(string dui)
        {
            DUI = dui;
        }
        
        private void btnSi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("reporte efectos secundarios ", "covid app",
                
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet var = comando.CShowTable("SELECT * FROM LUGAR_VACUNACION_2 ", "Lugares de vacunacion");
            cmblugar.DataSource = var.Tables[0];
            cmblugar.ValueMember = "id_lugar_vacunacion_2";
            cmblugar.DisplayMember = "lugar_vacunacion_2";
            cmblugar.SelectedIndex = gen.Next(0, 4);
            DateTime CitaNuevo = dtpVacunacion.Value;
            DataRowView row = (DataRowView)cmblugar.SelectedItem;
            comando.CInsertApointment2(CitaNuevo,(int)row["id_lugar_vacunacion_2"], DUI);
            tabControl1.SelectedIndex = 3;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _ventana.Show();
            this.Close();
        }

        private void btnPasar_Click(object sender, EventArgs e)
        {
             MessageBox.Show("el Paciente pasara a periodo de observacion", "covid app",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
             tabControl1.SelectedIndex = 1;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("siguiente cita generada", "covid app",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet var = comando.CShowTable("SELECT * FROM LUGAR_VACUNACION_2 ", "Lugares de vacunacion");
            cmblugar.DataSource = var.Tables[0];
            cmblugar.ValueMember = "id_lugar_vacunacion_2";
            cmblugar.DisplayMember = "lugar_vacunacion_2";
            cmblugar.SelectedIndex = gen.Next(0, 4);
            DateTime CitaNuevo = dtpVacunacion.Value;
            DataRowView row = (DataRowView)cmblugar.SelectedItem;
            comando.CInsertApointment2(CitaNuevo,(int)row["id_lugar_vacunacion_2"], DUI);
            tabControl1.SelectedIndex = 2;
        }

        private void ProcesoDeVacunacion_Load(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size (1, 0);
            
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            string efecto = rtbSintomas.Text;
            int tiempo = (int) nudTiempo.Value;
            
            comando.CInsertSecondaryEffect(tiempo, efecto, DUI);
            Form1 ventana = new Form1();
            ventana.Show();
            this.Close();
        }

        private void btnCancelarR_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Close();
        }
        
    }
   
}
