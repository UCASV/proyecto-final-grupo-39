using System.ComponentModel;

namespace Part_A.View
{
    partial class ProcesoDeVacunacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnPasar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblFechaI = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpVacunacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaV = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.lblSecundarios = new System.Windows.Forms.Label();
            this.tabpRegistro = new System.Windows.Forms.TabPage();
            this.cmblugar = new System.Windows.Forms.ComboBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnCancelarR = new System.Windows.Forms.Button();
            this.dtpCita2 = new System.Windows.Forms.DateTimePicker();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblCita2 = new System.Windows.Forms.Label();
            this.lbl2cita = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.nudTiempo = new System.Windows.Forms.NumericUpDown();
            this.btnReportar = new System.Windows.Forms.Button();
            this.rtbSintomas = new System.Windows.Forms.RichTextBox();
            this.lblSintoma = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSS = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabpRegistro.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudTiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabInicio);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabpRegistro);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1061, 535);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.dtpInicio);
            this.tabInicio.Controls.Add(this.btnPasar);
            this.tabInicio.Controls.Add(this.btnVolver);
            this.tabInicio.Controls.Add(this.lblFechaI);
            this.tabInicio.Location = new System.Drawing.Point(4, 28);
            this.tabInicio.Margin = new System.Windows.Forms.Padding(4);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(4);
            this.tabInicio.Size = new System.Drawing.Size(1053, 503);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "inicio ";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(459, 118);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowUpDown = true;
            this.dtpInicio.Size = new System.Drawing.Size(449, 22);
            this.dtpInicio.TabIndex = 6;
            // 
            // btnPasar
            // 
            this.btnPasar.Location = new System.Drawing.Point(557, 315);
            this.btnPasar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPasar.Name = "btnPasar";
            this.btnPasar.Size = new System.Drawing.Size(188, 79);
            this.btnPasar.TabIndex = 5;
            this.btnPasar.Text = "Pasar a vacunacion al paciente";
            this.btnPasar.UseVisualStyleBackColor = true;
            this.btnPasar.Click += new System.EventHandler(this.btnPasar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(232, 315);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(188, 79);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver a seguimiento de cita";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblFechaI
            // 
            this.lblFechaI.Location = new System.Drawing.Point(122, 115);
            this.lblFechaI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaI.Name = "lblFechaI";
            this.lblFechaI.Size = new System.Drawing.Size(263, 25);
            this.lblFechaI.TabIndex = 0;
            this.lblFechaI.Text = "Fecha y hora de ingreso del paciente:";
            this.lblFechaI.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpVacunacion);
            this.tabPage2.Controls.Add(this.lblFechaV);
            this.tabPage2.Controls.Add(this.btnNo);
            this.tabPage2.Controls.Add(this.btnSi);
            this.tabPage2.Controls.Add(this.lblSecundarios);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1053, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "vacunacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpVacunacion
            // 
            this.dtpVacunacion.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpVacunacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVacunacion.Location = new System.Drawing.Point(449, 92);
            this.dtpVacunacion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVacunacion.Name = "dtpVacunacion";
            this.dtpVacunacion.Size = new System.Drawing.Size(360, 22);
            this.dtpVacunacion.TabIndex = 5;
            // 
            // lblFechaV
            // 
            this.lblFechaV.Location = new System.Drawing.Point(241, 92);
            this.lblFechaV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaV.Name = "lblFechaV";
            this.lblFechaV.Size = new System.Drawing.Size(200, 28);
            this.lblFechaV.TabIndex = 4;
            this.lblFechaV.Text = "Fecha de vacunacion y hora:\r\n";
            this.lblFechaV.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(576, 278);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(199, 73);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(263, 278);
            this.btnSi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(200, 73);
            this.btnSi.TabIndex = 1;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // lblSecundarios
            // 
            this.lblSecundarios.Location = new System.Drawing.Point(372, 207);
            this.lblSecundarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecundarios.Name = "lblSecundarios";
            this.lblSecundarios.Size = new System.Drawing.Size(284, 49);
            this.lblSecundarios.TabIndex = 0;
            this.lblSecundarios.Text = "   ¿Se dieron efectos secundarios en \r\n     los 30 minutos de vacunacion?";
            // 
            // tabpRegistro
            // 
            this.tabpRegistro.Controls.Add(this.cmblugar);
            this.tabpRegistro.Controls.Add(this.btnPDF);
            this.tabpRegistro.Controls.Add(this.btnCancelarR);
            this.tabpRegistro.Controls.Add(this.dtpCita2);
            this.tabpRegistro.Controls.Add(this.lblHora2);
            this.tabpRegistro.Controls.Add(this.lblCita2);
            this.tabpRegistro.Controls.Add(this.lbl2cita);
            this.tabpRegistro.Location = new System.Drawing.Point(4, 28);
            this.tabpRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.tabpRegistro.Name = "tabpRegistro";
            this.tabpRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.tabpRegistro.Size = new System.Drawing.Size(1053, 503);
            this.tabpRegistro.TabIndex = 2;
            this.tabpRegistro.Text = "registro";
            this.tabpRegistro.UseVisualStyleBackColor = true;
            // 
            // cmblugar
            // 
            this.cmblugar.Enabled = false;
            this.cmblugar.FormattingEnabled = true;
            this.cmblugar.Location = new System.Drawing.Point(429, 254);
            this.cmblugar.Margin = new System.Windows.Forms.Padding(4);
            this.cmblugar.Name = "cmblugar";
            this.cmblugar.Size = new System.Drawing.Size(320, 24);
            this.cmblugar.TabIndex = 8;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(562, 370);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(184, 68);
            this.btnPDF.TabIndex = 7;
            this.btnPDF.Text = "Imprimir PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnCancelarR
            // 
            this.btnCancelarR.Location = new System.Drawing.Point(245, 370);
            this.btnCancelarR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarR.Name = "btnCancelarR";
            this.btnCancelarR.Size = new System.Drawing.Size(184, 68);
            this.btnCancelarR.TabIndex = 6;
            this.btnCancelarR.Text = "Volver";
            this.btnCancelarR.UseVisualStyleBackColor = true;
            this.btnCancelarR.Click += new System.EventHandler(this.btnCancelarR_Click);
            // 
            // dtpCita2
            // 
            this.dtpCita2.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpCita2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCita2.Location = new System.Drawing.Point(429, 122);
            this.dtpCita2.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCita2.Name = "dtpCita2";
            this.dtpCita2.Size = new System.Drawing.Size(283, 22);
            this.dtpCita2.TabIndex = 5;
            // 
            // lblHora2
            // 
            this.lblHora2.Location = new System.Drawing.Point(245, 105);
            this.lblHora2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(163, 60);
            this.lblHora2.TabIndex = 4;
            this.lblHora2.Text = "Fecha y hora segunda cita:";
            this.lblHora2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCita2
            // 
            this.lblCita2.Location = new System.Drawing.Point(245, 235);
            this.lblCita2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCita2.Name = "lblCita2";
            this.lblCita2.Size = new System.Drawing.Size(163, 60);
            this.lblCita2.TabIndex = 2;
            this.lblCita2.Text = "Lugar segunda cita:";
            this.lblCita2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2cita
            // 
            this.lbl2cita.Location = new System.Drawing.Point(299, 27);
            this.lbl2cita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2cita.Name = "lbl2cita";
            this.lbl2cita.Size = new System.Drawing.Size(348, 60);
            this.lbl2cita.TabIndex = 0;
            this.lbl2cita.Text = "Segunda cita generada ";
            this.lbl2cita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nudTiempo);
            this.tabPage3.Controls.Add(this.btnReportar);
            this.tabPage3.Controls.Add(this.rtbSintomas);
            this.tabPage3.Controls.Add(this.lblSintoma);
            this.tabPage3.Controls.Add(this.lblMinutos);
            this.tabPage3.Controls.Add(this.lblSS);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1053, 503);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "secundario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // nudTiempo
            // 
            this.nudTiempo.Location = new System.Drawing.Point(557, 100);
            this.nudTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.nudTiempo.Name = "nudTiempo";
            this.nudTiempo.Size = new System.Drawing.Size(147, 22);
            this.nudTiempo.TabIndex = 6;
            // 
            // btnReportar
            // 
            this.btnReportar.Location = new System.Drawing.Point(386, 339);
            this.btnReportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(211, 68);
            this.btnReportar.TabIndex = 5;
            this.btnReportar.Text = "Reportar efectos secundarios";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // rtbSintomas
            // 
            this.rtbSintomas.Location = new System.Drawing.Point(557, 194);
            this.rtbSintomas.Margin = new System.Windows.Forms.Padding(4);
            this.rtbSintomas.Name = "rtbSintomas";
            this.rtbSintomas.Size = new System.Drawing.Size(369, 80);
            this.rtbSintomas.TabIndex = 4;
            this.rtbSintomas.Text = "";
            // 
            // lblSintoma
            // 
            this.lblSintoma.Location = new System.Drawing.Point(247, 213);
            this.lblSintoma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSintoma.Name = "lblSintoma";
            this.lblSintoma.Size = new System.Drawing.Size(207, 43);
            this.lblSintoma.TabIndex = 2;
            this.lblSintoma.Text = "¿Que sintomas presento el paciente?";
            this.lblSintoma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutos
            // 
            this.lblMinutos.Location = new System.Drawing.Point(247, 100);
            this.lblMinutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(225, 43);
            this.lblMinutos.TabIndex = 1;
            this.lblMinutos.Text = "¿A los cuantos minutos se presento el efecto secundario?";
            this.lblMinutos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSS
            // 
            this.lblSS.Location = new System.Drawing.Point(309, 20);
            this.lblSS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(368, 53);
            this.lblSS.TabIndex = 0;
            this.lblSS.Text = "Sintomas secundarios ";
            this.lblSS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcesoDeVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProcesoDeVacunacion";
            this.Text = "Sistema de vacunacion";
            this.Load += new System.EventHandler(this.ProcesoDeVacunacion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabpRegistro.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.nudTiempo)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cmblugar;

        private System.Windows.Forms.NumericUpDown nudTiempo;

        private System.Windows.Forms.TabPage tabpRegistro;

        private System.Windows.Forms.Button btnCancelarR;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnReportar;

        private System.Windows.Forms.DateTimePicker dtpCita2;

        private System.Windows.Forms.DateTimePicker dtpVacunacion;

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnPasar;
        private System.Windows.Forms.DateTimePicker dtpInicio;

        private System.Windows.Forms.RichTextBox rtbSintomas;

        private System.Windows.Forms.Label lblFechaI;

        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSintoma;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TabPage tabPage3;

        private System.Windows.Forms.Label lblSecundarios;
        private System.Windows.Forms.Label lblFechaV;

        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblCita2;
        private System.Windows.Forms.Label lbl2cita;

        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;

        private System.Windows.Forms.TabPage tabInicio;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}
