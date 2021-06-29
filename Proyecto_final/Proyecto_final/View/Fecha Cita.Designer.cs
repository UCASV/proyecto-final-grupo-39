using System.ComponentModel;

namespace Proyecto_final.View
{
    partial class FechaCita
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
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblVacunacion = new System.Windows.Forms.Label();
            this.lblCitaRealizada = new System.Windows.Forms.Label();
            this.dtpCita = new System.Windows.Forms.DateTimePicker();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblfecha
            // 
            this.lblfecha.Location = new System.Drawing.Point(63, 88);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(117, 38);
            this.lblfecha.TabIndex = 0;
            this.lblfecha.Text = "Fecha y hora:";
            this.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVacunacion
            // 
            this.lblVacunacion.Location = new System.Drawing.Point(63, 176);
            this.lblVacunacion.Name = "lblVacunacion";
            this.lblVacunacion.Size = new System.Drawing.Size(165, 38);
            this.lblVacunacion.TabIndex = 2;
            this.lblVacunacion.Text = " Lugar de vacunacion:";
            // 
            // lblCitaRealizada
            // 
            this.lblCitaRealizada.Location = new System.Drawing.Point(232, 23);
            this.lblCitaRealizada.Name = "lblCitaRealizada";
            this.lblCitaRealizada.Size = new System.Drawing.Size(165, 38);
            this.lblCitaRealizada.TabIndex = 5;
            this.lblCitaRealizada.Text = "cita realizada";
            // 
            // dtpCita
            // 
            this.dtpCita.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpCita.Enabled = false;
            this.dtpCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCita.Location = new System.Drawing.Point(186, 95);
            this.dtpCita.Name = "dtpCita";
            this.dtpCita.Size = new System.Drawing.Size(227, 20);
            this.dtpCita.TabIndex = 6;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(294, 286);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(159, 60);
            this.btnPDF.TabIndex = 7;
            this.btnPDF.Text = "exportar a PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(63, 286);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(159, 60);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbLugar
            // 
            this.cmbLugar.Enabled = false;
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(187, 173);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(226, 21);
            this.cmbLugar.TabIndex = 9;
            // 
            // FechaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.cmbLugar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dtpCita);
            this.Controls.Add(this.lblCitaRealizada);
            this.Controls.Add(this.lblVacunacion);
            this.Controls.Add(this.lblfecha);
            this.Name = "FechaCita";
            this.Text = "Sistema de vacunacion";
            this.Load += new System.EventHandler(this.FechaCita_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cmbLugar;

        

        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnVolver;

        private System.Windows.Forms.DateTimePicker dtpCita;

        

        private System.Windows.Forms.Label lblfecha;

        private System.Windows.Forms.Label lblVacunacion;
        private System.Windows.Forms.Label lblCitaRealizada;

        #endregion
    }
}
