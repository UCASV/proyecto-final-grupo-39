using System;
using System.Windows.Forms;
using Proyecto_final.Functions;
using Proyecto_final.Model;

namespace Proyecto_final.View
{
    public partial class Form1 : Form
    {
        private Command comando = new Command();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            string DUI = txtDui.Text;
            bool comprobacion = comando.CStringComparer(DUI, 0, "Select * From CIUDADANO");
            if (comprobacion)
            {
                MessageBox.Show("El Usuario ya esta almacenado", "Covid App",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool validate =
                    nudEdad.Value >= 18 &&
                    txtDui.MaxLength > 9 &&
                    txtDireccion.Text.Length > 15 &&
                    txtNombre.Text.Length > 10 &&
                    txtTelefono.Text.Length > 7;
                if (validate)
                {
                    bool validate2 = rtbCronica.MaxLength > 3 ||
                                     txtIdentificador.MaxLength > 3 ||
                                     nudEdad.Value > 59;
                    if (validate2)
                    {
                        string prioridad = "si";
                        comando.CInsertCitizenI(txtDui.Text, txtDireccion.Text, txtNombre.Text, txtCorreo.Text,
                            txtTelefono.Text, rtbCronica.Text, prioridad);
                        MessageBox.Show("Usuario Almacenado", "Covid App",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FechaCita ventana = new FechaCita();
                        ventana.recibirdui(DUI);
                        ventana.Show();
                        this.Hide();

                    }
                    else
                    {
                        string prioridad = "no";
                        comando.CInsertCitizenI(txtDui.Text, txtDireccion.Text, txtNombre.Text, txtCorreo.Text,
                            txtTelefono.Text, rtbCronica.Text, prioridad);

                        MessageBox.Show("Usuario Almacenado", "Covid App",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FechaCita ventana = new FechaCita();
                        ventana.recibirdui(DUI);
                        ventana.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("Datos Invalidos", "Covid App",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            String DUI = txtDui.Text;
            seguimiento_de_cita ventana = new seguimiento_de_cita(this);
            
            ventana.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudEdad.Controls[0].Hide();
        }
    }
}