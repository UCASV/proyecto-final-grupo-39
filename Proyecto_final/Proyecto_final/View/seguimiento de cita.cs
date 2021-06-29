using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
                dgvCita.Columns[0].HeaderText = "Cita #";
                dgvCita.Columns[1].HeaderText = "Fecha y hora cita";
                dgvCita.Columns[2].HeaderText = "Lugar de vacunacion #";
                dgvCita.Columns[3].HeaderText = "Segunda cita #";
                dgvcita2.DataSource = var2.Tables[0];
                dgvcita2.Columns[0].HeaderText = "Cita #";
                dgvcita2.Columns[1].HeaderText = "Fecha y hora cita";
                dgvcita2.Columns[2].HeaderText = "Lugar de vacunacion #";
                dgvcita2.Columns[3].HeaderText = "Segunda cita #";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string DUI = txtDuiIngreso.Text;
            PdfPTable pdfTable1 = new PdfPTable(dgvCita.ColumnCount);
            pdfTable1.DefaultCell.Padding = 3;
            pdfTable1.WidthPercentage = 30;
            pdfTable1.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable1.DefaultCell.BorderWidth = 1;
 
            //Adding Header row
            foreach (DataGridViewColumn column in dgvCita.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable1.AddCell(cell);
            }
 
            //Adding DataRow
            foreach (DataGridViewRow row in dgvCita.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable1.AddCell(cell.Value.ToString());
                }
            }


            PdfPTable pdfTable2 = new PdfPTable(dgvcita2.ColumnCount);
            pdfTable2.DefaultCell.Padding = 3;
            pdfTable2.WidthPercentage = 30;
            pdfTable2.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable2.DefaultCell.BorderWidth = 1;
 
            //Adding Header row
            foreach (DataGridViewColumn column in dgvcita2.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable2.AddCell(cell);
            }
 
            //Adding DataRow
            foreach (DataGridViewRow row in dgvcita2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable2.AddCell(cell.Value.ToString());
                }
            }
            
            //Exporting to PDF
            using (FileStream stream = new FileStream("./Seguimiento de cita "+DUI+".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable1);
                pdfDoc.Add(pdfTable2);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("Se ha creado el pdf", "covid app",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}