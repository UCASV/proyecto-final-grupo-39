using System.ComponentModel;

namespace Part_A.View
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(66, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de sesion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(139, 140);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(210, 22);
            this.txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(139, 205);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(101, 293);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(186, 44);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Iniciar sesion";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}