using System.ComponentModel;

namespace Proyecto_final.View
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
            this.lblHoraI = new System.Windows.Forms.Label();
            this.lblFechaI = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpVacunacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaV = new System.Windows.Forms.Label();
            this.lblHorav = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 435);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.dtpInicio);
            this.tabInicio.Controls.Add(this.btnPasar);
            this.tabInicio.Controls.Add(this.btnVolver);
            this.tabInicio.Controls.Add(this.lblHoraI);
            this.tabInicio.Controls.Add(this.lblFechaI);
            this.tabInicio.Location = new System.Drawing.Point(4, 25);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(788, 406);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "inicio ";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(292, 100);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowUpDown = true;
            this.dtpInicio.Size = new System.Drawing.Size(338, 20);
            this.dtpInicio.TabIndex = 6;
            // 
            // btnPasar
            // 
            this.btnPasar.Location = new System.Drawing.Point(418, 256);
            this.btnPasar.Name = "btnPasar";
            this.btnPasar.Size = new System.Drawing.Size(141, 64);
            this.btnPasar.TabIndex = 5;
            this.btnPasar.Text = "Pasar a vacunacion al paciente";
            this.btnPasar.UseVisualStyleBackColor = true;
            this.btnPasar.Click += new System.EventHandler(this.btnPasar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(174, 256);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(141, 64);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver a seguimiento de cita";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblHoraI
            // 
            this.lblHoraI.Location = new System.Drawing.Point(112, 126);
            this.lblHoraI.Name = "lblHoraI";
            this.lblHoraI.Size = new System.Drawing.Size(156, 16);
            this.lblHoraI.TabIndex = 1;
            this.lblHoraI.Text = "Hora de ingreso del paciente";
            // 
            // lblFechaI
            // 
            this.lblFechaI.Location = new System.Drawing.Point(112, 106);
            this.lblFechaI.Name = "lblFechaI";
            this.lblFechaI.Size = new System.Drawing.Size(156, 20);
            this.lblFechaI.TabIndex = 0;
            this.lblFechaI.Text = "Fecha de ingreso del paciente";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpVacunacion);
            this.tabPage2.Controls.Add(this.lblFechaV);
            this.tabPage2.Controls.Add(this.lblHorav);
            this.tabPage2.Controls.Add(this.btnNo);
            this.tabPage2.Controls.Add(this.btnSi);
            this.tabPage2.Controls.Add(this.lblSecundarios);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "vacunacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpVacunacion
            // 
            this.dtpVacunacion.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpVacunacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVacunacion.Location = new System.Drawing.Point(310, 29);
            this.dtpVacunacion.Name = "dtpVacunacion";
            this.dtpVacunacion.Size = new System.Drawing.Size(271, 20);
            this.dtpVacunacion.TabIndex = 5;
            // 
            // lblFechaV
            // 
            this.lblFechaV.Location = new System.Drawing.Point(171, 26);
            this.lblFechaV.Name = "lblFechaV";
            this.lblFechaV.Size = new System.Drawing.Size(120, 23);
            this.lblFechaV.TabIndex = 4;
            this.lblFechaV.Text = "Fecha de vacunacion y ";
            // 
            // lblHorav
            // 
            this.lblHorav.Location = new System.Drawing.Point(171, 49);
            this.lblHorav.Name = "lblHorav";
            this.lblHorav.Size = new System.Drawing.Size(120, 21);
            this.lblHorav.TabIndex = 3;
            this.lblHorav.Text = "hora de vacunacion";
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(432, 226);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(149, 59);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(197, 226);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(150, 59);
            this.btnSi.TabIndex = 1;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // lblSecundarios
            // 
            this.lblSecundarios.Location = new System.Drawing.Point(279, 168);
            this.lblSecundarios.Name = "lblSecundarios";
            this.lblSecundarios.Size = new System.Drawing.Size(213, 40);
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
            this.tabpRegistro.Location = new System.Drawing.Point(4, 25);
            this.tabpRegistro.Name = "tabpRegistro";
            this.tabpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabpRegistro.Size = new System.Drawing.Size(788, 406);
            this.tabpRegistro.TabIndex = 2;
            this.tabpRegistro.Text = "registro";
            this.tabpRegistro.UseVisualStyleBackColor = true;
            // 
            // cmblugar
            // 
            this.cmblugar.Enabled = false;
            this.cmblugar.FormattingEnabled = true;
            this.cmblugar.Location = new System.Drawing.Point(232, 213);
            this.cmblugar.Name = "cmblugar";
            this.cmblugar.Size = new System.Drawing.Size(241, 21);
            this.cmblugar.TabIndex = 8;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(349, 309);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(138, 55);
            this.btnPDF.TabIndex = 7;
            this.btnPDF.Text = "Imprimir PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnCancelarR
            // 
            this.btnCancelarR.Location = new System.Drawing.Point(111, 309);
            this.btnCancelarR.Name = "btnCancelarR";
            this.btnCancelarR.Size = new System.Drawing.Size(138, 55);
            this.btnCancelarR.TabIndex = 6;
            this.btnCancelarR.Text = "Volver";
            this.btnCancelarR.UseVisualStyleBackColor = true;
            this.btnCancelarR.Click += new System.EventHandler(this.btnCancelarR_Click);
            // 
            // dtpCita2
            // 
            this.dtpCita2.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpCita2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCita2.Location = new System.Drawing.Point(260, 100);
            this.dtpCita2.Name = "dtpCita2";
            this.dtpCita2.Size = new System.Drawing.Size(213, 20);
            this.dtpCita2.TabIndex = 5;
            // 
            // lblHora2
            // 
            this.lblHora2.Location = new System.Drawing.Point(111, 92);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(122, 49);
            this.lblHora2.TabIndex = 4;
            this.lblHora2.Text = "Fecha y Hora segunda cita";
            this.lblHora2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCita2
            // 
            this.lblCita2.Location = new System.Drawing.Point(122, 198);
            this.lblCita2.Name = "lblCita2";
            this.lblCita2.Size = new System.Drawing.Size(111, 49);
            this.lblCita2.TabIndex = 2;
            this.lblCita2.Text = "Lugar 2da cita";
            this.lblCita2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2cita
            // 
            this.lbl2cita.Location = new System.Drawing.Point(226, 22);
            this.lbl2cita.Name = "lbl2cita";
            this.lbl2cita.Size = new System.Drawing.Size(261, 49);
            this.lbl2cita.TabIndex = 0;
            this.lbl2cita.Text = "2da cita generada ";
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
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(788, 406);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "secundario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // nudTiempo
            // 
            this.nudTiempo.Location = new System.Drawing.Point(327, 87);
            this.nudTiempo.Name = "nudTiempo";
            this.nudTiempo.Size = new System.Drawing.Size(110, 20);
            this.nudTiempo.TabIndex = 6;
            // 
            // btnReportar
            // 
            this.btnReportar.Location = new System.Drawing.Point(307, 268);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(158, 55);
            this.btnReportar.TabIndex = 5;
            this.btnReportar.Text = "Reportar efectos secundarios";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // rtbSintomas
            // 
            this.rtbSintomas.Location = new System.Drawing.Point(252, 157);
            this.rtbSintomas.Name = "rtbSintomas";
            this.rtbSintomas.Size = new System.Drawing.Size(278, 66);
            this.rtbSintomas.TabIndex = 4;
            this.rtbSintomas.Text = "";
            // 
            // lblSintoma
            // 
            this.lblSintoma.Location = new System.Drawing.Point(72, 160);
            this.lblSintoma.Name = "lblSintoma";
            this.lblSintoma.Size = new System.Drawing.Size(155, 35);
            this.lblSintoma.TabIndex = 2;
            this.lblSintoma.Text = "¿Que Sintomas Presento el paciente?";
            // 
            // lblMinutos
            // 
            this.lblMinutos.Location = new System.Drawing.Point(72, 89);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(169, 35);
            this.lblMinutos.TabIndex = 1;
            this.lblMinutos.Text = "¿A los cuantos minutos se presento el efecto secundario?";
            // 
            // lblSS
            // 
            this.lblSS.Location = new System.Drawing.Point(252, 20);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(276, 43);
            this.lblSS.TabIndex = 0;
            this.lblSS.Text = "Sintomas secundarios ";
            this.lblSS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcesoDeVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProcesoDeVacunacion";
            this.Text = "proceso_de_vacunacion";
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
        private System.Windows.Forms.Label lblHoraI;

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

        private System.Windows.Forms.Label lblHorav;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;

        private System.Windows.Forms.TabPage tabInicio;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}
