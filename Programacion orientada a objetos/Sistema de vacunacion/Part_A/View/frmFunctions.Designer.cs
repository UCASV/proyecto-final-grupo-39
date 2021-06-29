using System.ComponentModel;

namespace Part_A.View
{
    partial class frmFunctions
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
            this.btnEmployes = new System.Windows.Forms.Button();
            this.btnSetAppoiment = new System.Windows.Forms.Button();
            this.btnVaccinate = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCabin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployes
            // 
            this.btnEmployes.Location = new System.Drawing.Point(12, 12);
            this.btnEmployes.Name = "btnEmployes";
            this.btnEmployes.Size = new System.Drawing.Size(267, 78);
            this.btnEmployes.TabIndex = 0;
            this.btnEmployes.Text = "Mostrar empleados";
            this.btnEmployes.UseVisualStyleBackColor = true;
            this.btnEmployes.Click += new System.EventHandler(this.btnEmployes_Click);
            // 
            // btnSetAppoiment
            // 
            this.btnSetAppoiment.Location = new System.Drawing.Point(12, 180);
            this.btnSetAppoiment.Name = "btnSetAppoiment";
            this.btnSetAppoiment.Size = new System.Drawing.Size(267, 78);
            this.btnSetAppoiment.TabIndex = 1;
            this.btnSetAppoiment.Text = "Agendar una cita";
            this.btnSetAppoiment.UseVisualStyleBackColor = true;
            this.btnSetAppoiment.Click += new System.EventHandler(this.btnSetAppoiment_Click);
            // 
            // btnVaccinate
            // 
            this.btnVaccinate.Location = new System.Drawing.Point(12, 264);
            this.btnVaccinate.Name = "btnVaccinate";
            this.btnVaccinate.Size = new System.Drawing.Size(267, 78);
            this.btnVaccinate.TabIndex = 2;
            this.btnVaccinate.Text = "Vacunar";
            this.btnVaccinate.UseVisualStyleBackColor = true;
            this.btnVaccinate.Click += new System.EventHandler(this.btnVaccinate_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 348);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(267, 78);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Cerrar sesion";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCabin
            // 
            this.btnCabin.Location = new System.Drawing.Point(12, 96);
            this.btnCabin.Name = "btnCabin";
            this.btnCabin.Size = new System.Drawing.Size(267, 78);
            this.btnCabin.TabIndex = 4;
            this.btnCabin.Text = "Mostrar cabinas";
            this.btnCabin.UseVisualStyleBackColor = true;
            this.btnCabin.Click += new System.EventHandler(this.btnCabin_Click);
            // 
            // frmFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 437);
            this.Controls.Add(this.btnCabin);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnVaccinate);
            this.Controls.Add(this.btnSetAppoiment);
            this.Controls.Add(this.btnEmployes);
            this.Name = "frmFunctions";
            this.Text = "Sistema de vacunacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFunctions_FormClosed);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCabin;

        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Button btnSetAppoiment;

        private System.Windows.Forms.Button btnEmployes;
        private System.Windows.Forms.Button btnStartAppoiment;

        private System.Windows.Forms.Button btnVaccinate;

        #endregion
    }
}