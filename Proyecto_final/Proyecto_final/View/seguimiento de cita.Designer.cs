using System.ComponentModel;

namespace Proyecto_final.View
{
    partial class seguimiento_de_cita
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
            this.lblDui = new System.Windows.Forms.Label();
            this.txtDuiIngreso = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.tabSeguimiento = new System.Windows.Forms.TabControl();
            this.tabingreso = new System.Windows.Forms.TabPage();
            this.tabdatos = new System.Windows.Forms.TabPage();
            this.dgvcita2 = new System.Windows.Forms.DataGridView();
            this.dgvCita = new System.Windows.Forms.DataGridView();
            this.btnEspera = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabSeguimiento.SuspendLayout();
            this.tabingreso.SuspendLayout();
            this.tabdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvcita2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvCita)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDui
            // 
            this.lblDui.Location = new System.Drawing.Point(153, 104);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(64, 42);
            this.lblDui.TabIndex = 0;
            this.lblDui.Text = "ingrese Dui";
            this.lblDui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDuiIngreso
            // 
            this.txtDuiIngreso.Location = new System.Drawing.Point(257, 116);
            this.txtDuiIngreso.Name = "txtDuiIngreso";
            this.txtDuiIngreso.Size = new System.Drawing.Size(279, 20);
            this.txtDuiIngreso.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(153, 200);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(133, 63);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(403, 200);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(133, 63);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // tabSeguimiento
            // 
            this.tabSeguimiento.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabSeguimiento.Controls.Add(this.tabingreso);
            this.tabSeguimiento.Controls.Add(this.tabdatos);
            this.tabSeguimiento.Location = new System.Drawing.Point(-4, 12);
            this.tabSeguimiento.Name = "tabSeguimiento";
            this.tabSeguimiento.SelectedIndex = 0;
            this.tabSeguimiento.Size = new System.Drawing.Size(803, 443);
            this.tabSeguimiento.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSeguimiento.TabIndex = 0;
            this.tabSeguimiento.TabStop = false;
            // 
            // tabingreso
            // 
            this.tabingreso.Controls.Add(this.lblDui);
            this.tabingreso.Controls.Add(this.btnIngresar);
            this.tabingreso.Controls.Add(this.txtDuiIngreso);
            this.tabingreso.Controls.Add(this.btnRegresar);
            this.tabingreso.Location = new System.Drawing.Point(4, 25);
            this.tabingreso.Name = "tabingreso";
            this.tabingreso.Padding = new System.Windows.Forms.Padding(3);
            this.tabingreso.Size = new System.Drawing.Size(795, 414);
            this.tabingreso.TabIndex = 0;
            this.tabingreso.Text = "ingreso";
            this.tabingreso.UseVisualStyleBackColor = true;
            // 
            // tabdatos
            // 
            this.tabdatos.Controls.Add(this.dgvcita2);
            this.tabdatos.Controls.Add(this.dgvCita);
            this.tabdatos.Controls.Add(this.btnEspera);
            this.tabdatos.Controls.Add(this.btnVolver);
            this.tabdatos.Location = new System.Drawing.Point(4, 25);
            this.tabdatos.Name = "tabdatos";
            this.tabdatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabdatos.Size = new System.Drawing.Size(795, 414);
            this.tabdatos.TabIndex = 1;
            this.tabdatos.Text = "cita";
            this.tabdatos.UseVisualStyleBackColor = true;
            // 
            // dgvcita2
            // 
            this.dgvcita2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcita2.Enabled = false;
            this.dgvcita2.Location = new System.Drawing.Point(162, 126);
            this.dgvcita2.Name = "dgvcita2";
            this.dgvcita2.Size = new System.Drawing.Size(413, 48);
            this.dgvcita2.TabIndex = 3;
            // 
            // dgvCita
            // 
            this.dgvCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCita.Enabled = false;
            this.dgvCita.Location = new System.Drawing.Point(162, 59);
            this.dgvCita.Name = "dgvCita";
            this.dgvCita.Size = new System.Drawing.Size(413, 46);
            this.dgvCita.TabIndex = 2;
            // 
            // btnEspera
            // 
            this.btnEspera.Location = new System.Drawing.Point(451, 265);
            this.btnEspera.Name = "btnEspera";
            this.btnEspera.Size = new System.Drawing.Size(202, 65);
            this.btnEspera.TabIndex = 1;
            this.btnEspera.Text = "continuar a sala de espera ";
            this.btnEspera.UseVisualStyleBackColor = true;
            this.btnEspera.Click += new System.EventHandler(this.btnEspera_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(108, 265);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(202, 65);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // seguimiento_de_cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabSeguimiento);
            this.Name = "seguimiento_de_cita";
            this.Text = "seguimiento_de_cita";
            this.Load += new System.EventHandler(this.seguimiento_de_cita_Load);
            this.tabSeguimiento.ResumeLayout(false);
            this.tabingreso.ResumeLayout(false);
            this.tabingreso.PerformLayout();
            this.tabdatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvcita2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvCita)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvcita2;

        private System.Windows.Forms.DataGridView dgvCita;

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEspera;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button btnIngresar;

        private System.Windows.Forms.TabControl tabSeguimiento;
        private System.Windows.Forms.TabPage tabingreso;
        private System.Windows.Forms.TabPage tabdatos;

        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.TextBox txtDuiIngreso;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}