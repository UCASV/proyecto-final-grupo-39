using System;
using System.Data;
using System.Windows.Forms;
using Proyecto_final.Functions;

namespace Proyecto_final.View
{
    public partial class FechaCita : Form
    { 
        private RandomDateTime Rdate = new RandomDateTime();
        private Random gen = new Random();
        private Command comando = new Command();
        private string DUI;
        public FechaCita()
        {
            InitializeComponent();
        }

        public void recibirdui(string dui)
        {
            DUI = dui;
        }
        
        private void FechaCita_Load(object sender, EventArgs e)
        {
            dtpCita.Value = Rdate.Next();
            DataSet var = comando.CShowTable("SELECT * FROM LUGAR_VACUNACION ", "Lugares de vacunacion");
            cmbLugar.DataSource = var.Tables[0];
            cmbLugar.ValueMember = "id_lugar_vacunacion";
            cmbLugar.DisplayMember = "lugar_vacunacion";
            cmbLugar.SelectedIndex = gen.Next(0, 4);
            DataRowView row = (DataRowView)cmbLugar.SelectedItem;
            comando.CInsertApointment1(dtpCita.Value,(int)row["id_lugar_vacunacion"],DUI);
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Close();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            // pdf
        }
    }
    class RandomDateTime
    {
        
        DateTime start= DateTime.Today;
        Random gen = new Random();

        public DateTime Next()
        {
            return start.AddDays(gen.Next(14,30)).AddHours(gen.Next(8,16)).AddMinutes(gen.Next(0,59)).AddSeconds(gen.Next(0,59));
        }
    }
}