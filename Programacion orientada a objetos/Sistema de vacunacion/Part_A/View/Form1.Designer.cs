namespace Part_A.View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.lblProcesoC = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblTele = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCronico = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.rtbCronica = new System.Windows.Forms.RichTextBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnSeguimiento = new System.Windows.Forms.Button();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDui = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProcesoC
            // 
            this.lblProcesoC.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcesoC.Location = new System.Drawing.Point(185, 11);
            this.lblProcesoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcesoC.Name = "lblProcesoC";
            this.lblProcesoC.Size = new System.Drawing.Size(404, 70);
            this.lblProcesoC.TabIndex = 0;
            this.lblProcesoC.Text = "Proceso de inicio de cita ";
            this.lblProcesoC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDui
            // 
            this.lblDui.Location = new System.Drawing.Point(180, 119);
            this.lblDui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(52, 44);
            this.lblDui.TabIndex = 1;
            this.lblDui.Text = "DUI:";
            this.lblDui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(165, 177);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 31);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Location = new System.Drawing.Point(36, 229);
            this.lblDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(196, 27);
            this.lblDomicilio.TabIndex = 3;
            this.lblDomicilio.Text = "Direccion de domicilio:";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTele
            // 
            this.lblTele.Location = new System.Drawing.Point(101, 284);
            this.lblTele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(131, 25);
            this.lblTele.TabIndex = 4;
            this.lblTele.Text = "Telefono contacto:";
            this.lblTele.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(36, 331);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(201, 27);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "Correo Electronico (opcional):";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCronico
            // 
            this.lblCronico.Location = new System.Drawing.Point(36, 366);
            this.lblCronico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCronico.Name = "lblCronico";
            this.lblCronico.Size = new System.Drawing.Size(305, 55);
            this.lblCronico.TabIndex = 6;
            this.lblCronico.Text = "Mencione que enfermedades cronicas padece\r\n(si se llegara a poseer alguna ): ";
            this.lblCronico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.Location = new System.Drawing.Point(36, 449);
            this.lblIdentificador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(305, 42);
            this.lblIdentificador.TabIndex = 7;
            this.lblIdentificador.Text = "Numero identificador (si pertenece a una intitucion esencial):";
            this.lblIdentificador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(259, 181);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(384, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(259, 328);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(384, 22);
            this.txtCorreo.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(259, 226);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(384, 22);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(259, 284);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(384, 22);
            this.txtTelefono.TabIndex = 10;
            // 
            // rtbCronica
            // 
            this.rtbCronica.Location = new System.Drawing.Point(362, 366);
            this.rtbCronica.Margin = new System.Windows.Forms.Padding(4);
            this.rtbCronica.Name = "rtbCronica";
            this.rtbCronica.Size = new System.Drawing.Size(355, 63);
            this.rtbCronica.TabIndex = 11;
            this.rtbCronica.Text = "";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(362, 459);
            this.txtIdentificador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(355, 22);
            this.txtIdentificador.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(36, 530);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(196, 76);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(279, 530);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(196, 76);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(129, 64);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(103, 44);
            this.lblYear.TabIndex = 15;
            this.lblYear.Text = "Años de edad:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSeguimiento
            // 
            this.btnSeguimiento.Location = new System.Drawing.Point(521, 530);
            this.btnSeguimiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeguimiento.Name = "btnSeguimiento";
            this.btnSeguimiento.Size = new System.Drawing.Size(196, 76);
            this.btnSeguimiento.TabIndex = 17;
            this.btnSeguimiento.Text = "Seguimiento de cita ";
            this.btnSeguimiento.UseVisualStyleBackColor = true;
            this.btnSeguimiento.Click += new System.EventHandler(this.btnSeguimiento_Click);
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(259, 76);
            this.nudEdad.Margin = new System.Windows.Forms.Padding(4);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(197, 22);
            this.nudEdad.TabIndex = 18;
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(259, 130);
            this.txtDui.Margin = new System.Windows.Forms.Padding(4);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(384, 22);
            this.txtDui.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(777, 670);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.btnSeguimiento);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.rtbCronica);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.lblCronico);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTele);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDui);
            this.Controls.Add(this.lblProcesoC);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sistema de vacunacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDui;

        private System.Windows.Forms.NumericUpDown nudDui;

        private System.Windows.Forms.NumericUpDown nudEdad;

        private System.Windows.Forms.Button btnSeguimiento;

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;

        private System.Windows.Forms.Label lblIdentificador;

        private System.Windows.Forms.Label lblCronico;
        private System.Windows.Forms.RichTextBox rtbCronica;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtIdentificador;

        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.Label lblMail;
        
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblYear;

        private System.Windows.Forms.Label lblNombre;

        private System.Windows.Forms.Label lblDui;

        private System.Windows.Forms.Label lblProcesoC;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}