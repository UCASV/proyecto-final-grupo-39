using System;
using System.Windows.Forms;
using Part_A.Functions;

namespace Part_A.View
{
    public partial class Form1 : Form
    {
        private Form back;
        private Command comando = new Command();
        public Form1(Form backs)
        {
            InitializeComponent();
            back = backs;
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
                    bool validate2 = rtbCronica.MaxLength >= 3 ||
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
                        this.Close();

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
                        this.Close();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }
    }
}