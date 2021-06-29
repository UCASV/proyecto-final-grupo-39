using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Part_A.Functions;

namespace Part_A.View
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
            frmFunctions ventana = new frmFunctions(this);
            ventana.Show();
            this.Close();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PdfPTable pdftable = new PdfPTable(2); 
            PdfPCell header1 = new PdfPCell(new Phrase("Fecha"));
            header1.BackgroundColor = new BaseColor(240, 240, 240);
            pdftable.AddCell(header1);

            PdfPCell header2 = new PdfPCell(new Phrase("Lugar"));
            header2.BackgroundColor = new BaseColor(240, 240, 240);
            pdftable.AddCell(header2);
            DataRowView row = (DataRowView)cmbLugar.SelectedItem;
            pdftable.AddCell(dtpCita.Value.ToString(CultureInfo.CurrentCulture));
            pdftable.AddCell((string)row["lugar_vacunacion"]);
            
            using (FileStream stream = new FileStream("./Cita "+DUI+".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdftable);
                pdfDoc.Close();
                stream.Close();
                
            }
            MessageBox.Show("Se ha creado el pdf", "covid app",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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