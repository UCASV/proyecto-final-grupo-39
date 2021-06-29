using System.ComponentModel;

namespace Part_A.View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDui = new System.Windows.Forms.Label();
            this.txtDuiIngreso = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.tabSeguimiento = new System.Windows.Forms.TabControl();
            this.tabingreso = new System.Windows.Forms.TabPage();
            this.tabdatos = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
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
            this.lblDui.Location = new System.Drawing.Point(16, 128);
            this.lblDui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(99, 52);
            this.lblDui.TabIndex = 0;
            this.lblDui.Text = "Ingrese DUI:";
            this.lblDui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDuiIngreso
            // 
            this.txtDuiIngreso.Location = new System.Drawing.Point(151, 143);
            this.txtDuiIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuiIngreso.Name = "txtDuiIngreso";
            this.txtDuiIngreso.Size = new System.Drawing.Size(371, 22);
            this.txtDuiIngreso.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(101, 226);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(177, 78);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(345, 226);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(177, 78);
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
            this.tabSeguimiento.Location = new System.Drawing.Point(-5, 15);
            this.tabSeguimiento.Margin = new System.Windows.Forms.Padding(4);
            this.tabSeguimiento.Name = "tabSeguimiento";
            this.tabSeguimiento.SelectedIndex = 0;
            this.tabSeguimiento.Size = new System.Drawing.Size(1071, 545);
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
            this.tabingreso.Location = new System.Drawing.Point(4, 28);
            this.tabingreso.Margin = new System.Windows.Forms.Padding(4);
            this.tabingreso.Name = "tabingreso";
            this.tabingreso.Padding = new System.Windows.Forms.Padding(4);
            this.tabingreso.Size = new System.Drawing.Size(1063, 513);
            this.tabingreso.TabIndex = 0;
            this.tabingreso.Text = "ingreso";
            this.tabingreso.UseVisualStyleBackColor = true;
            // 
            // tabdatos
            // 
            this.tabdatos.Controls.Add(this.button1);
            this.tabdatos.Controls.Add(this.dgvcita2);
            this.tabdatos.Controls.Add(this.dgvCita);
            this.tabdatos.Controls.Add(this.btnEspera);
            this.tabdatos.Controls.Add(this.btnVolver);
            this.tabdatos.Location = new System.Drawing.Point(4, 28);
            this.tabdatos.Margin = new System.Windows.Forms.Padding(4);
            this.tabdatos.Name = "tabdatos";
            this.tabdatos.Padding = new System.Windows.Forms.Padding(4);
            this.tabdatos.Size = new System.Drawing.Size(1063, 513);
            this.tabdatos.TabIndex = 1;
            this.tabdatos.Text = "cita";
            this.tabdatos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exportar cita";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvcita2
            // 
            this.dgvcita2.AllowUserToAddRows = false;
            this.dgvcita2.AllowUserToDeleteRows = false;
            this.dgvcita2.AllowUserToResizeColumns = false;
            this.dgvcita2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcita2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcita2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcita2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcita2.Enabled = false;
            this.dgvcita2.Location = new System.Drawing.Point(64, 165);
            this.dgvcita2.Margin = new System.Windows.Forms.Padding(4);
            this.dgvcita2.Name = "dgvcita2";
            this.dgvcita2.RowHeadersVisible = false;
            this.dgvcita2.Size = new System.Drawing.Size(488, 79);
            this.dgvcita2.TabIndex = 3;
            // 
            // dgvCita
            // 
            this.dgvCita.AllowUserToAddRows = false;
            this.dgvCita.AllowUserToDeleteRows = false;
            this.dgvCita.AllowUserToResizeColumns = false;
            this.dgvCita.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCita.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCita.Enabled = false;
            this.dgvCita.Location = new System.Drawing.Point(64, 78);
            this.dgvCita.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCita.Name = "dgvCita";
            this.dgvCita.RowHeadersVisible = false;
            this.dgvCita.Size = new System.Drawing.Size(488, 79);
            this.dgvCita.TabIndex = 2;
            // 
            // btnEspera
            // 
            this.btnEspera.Location = new System.Drawing.Point(411, 305);
            this.btnEspera.Margin = new System.Windows.Forms.Padding(4);
            this.btnEspera.Name = "btnEspera";
            this.btnEspera.Size = new System.Drawing.Size(184, 64);
            this.btnEspera.TabIndex = 1;
            this.btnEspera.Text = "Continuar a sala de espera ";
            this.btnEspera.UseVisualStyleBackColor = true;
            this.btnEspera.Click += new System.EventHandler(this.btnEspera_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(16, 305);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(184, 64);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // seguimiento_de_cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 505);
            this.Controls.Add(this.tabSeguimiento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "seguimiento_de_cita";
            this.Text = "Sistema de vacunacion";
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