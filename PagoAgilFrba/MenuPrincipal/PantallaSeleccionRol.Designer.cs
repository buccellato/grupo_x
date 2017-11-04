namespace PagoAgilFrba.MenuPrincipal
{
    partial class PantallaSeleccionRol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.atrasButton = new System.Windows.Forms.Button();
            this.adminCheck = new System.Windows.Forms.CheckBox();
            this.cobradorCheck = new System.Windows.Forms.CheckBox();
            this.ingresarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // atrasButton
            // 
            this.atrasButton.Location = new System.Drawing.Point(2107, 1023);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(174, 86);
            this.atrasButton.TabIndex = 0;
            this.atrasButton.Text = "Atras";
            this.atrasButton.UseVisualStyleBackColor = true;
            this.atrasButton.Click += new System.EventHandler(this.atrasButton_Click);
            // 
            // adminCheck
            // 
            this.adminCheck.AutoSize = true;
            this.adminCheck.Location = new System.Drawing.Point(1130, 384);
            this.adminCheck.Name = "adminCheck";
            this.adminCheck.Size = new System.Drawing.Size(229, 36);
            this.adminCheck.TabIndex = 1;
            this.adminCheck.Text = "Administrador";
            this.adminCheck.UseVisualStyleBackColor = true;
            // 
            // cobradorCheck
            // 
            this.cobradorCheck.AutoSize = true;
            this.cobradorCheck.Location = new System.Drawing.Point(1441, 384);
            this.cobradorCheck.Name = "cobradorCheck";
            this.cobradorCheck.Size = new System.Drawing.Size(171, 36);
            this.cobradorCheck.TabIndex = 2;
            this.cobradorCheck.Text = "Cobrador";
            this.cobradorCheck.UseVisualStyleBackColor = true;
            // 
            // ingresarButton
            // 
            this.ingresarButton.Location = new System.Drawing.Point(1130, 454);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(482, 74);
            this.ingresarButton.TabIndex = 3;
            this.ingresarButton.Text = "Ingresar";
            this.ingresarButton.UseVisualStyleBackColor = true;
            // 
            // PantallaSeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2406, 1401);
            this.Controls.Add(this.ingresarButton);
            this.Controls.Add(this.cobradorCheck);
            this.Controls.Add(this.adminCheck);
            this.Controls.Add(this.atrasButton);
            this.Name = "PantallaSeleccionRol";
            this.Text = "Seleccion de Rol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atrasButton;
        private System.Windows.Forms.CheckBox adminCheck;
        private System.Windows.Forms.CheckBox cobradorCheck;
        private System.Windows.Forms.Button ingresarButton;
    }
}