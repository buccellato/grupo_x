namespace PagoAgilFrba
{
    partial class rolVentana
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
            this.AdministradorButton = new System.Windows.Forms.RadioButton();
            this.cobradorButton = new System.Windows.Forms.RadioButton();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdministradorButton
            // 
            this.AdministradorButton.AutoSize = true;
            this.AdministradorButton.Location = new System.Drawing.Point(519, 356);
            this.AdministradorButton.Name = "AdministradorButton";
            this.AdministradorButton.Size = new System.Drawing.Size(228, 36);
            this.AdministradorButton.TabIndex = 0;
            this.AdministradorButton.TabStop = true;
            this.AdministradorButton.Text = "Administrador";
            this.AdministradorButton.UseVisualStyleBackColor = true;
            this.AdministradorButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cobradorButton
            // 
            this.cobradorButton.AutoSize = true;
            this.cobradorButton.Location = new System.Drawing.Point(877, 356);
            this.cobradorButton.Name = "cobradorButton";
            this.cobradorButton.Size = new System.Drawing.Size(170, 36);
            this.cobradorButton.TabIndex = 1;
            this.cobradorButton.TabStop = true;
            this.cobradorButton.Text = "Cobrador";
            this.cobradorButton.UseVisualStyleBackColor = true;
            this.cobradorButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(519, 444);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(528, 53);
            this.aceptarButton.TabIndex = 2;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            // 
            // rolVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 1171);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.cobradorButton);
            this.Controls.Add(this.AdministradorButton);
            this.Name = "rolVentana";
            this.Text = "Selección de Rol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton AdministradorButton;
        private System.Windows.Forms.RadioButton cobradorButton;
        private System.Windows.Forms.Button aceptarButton;
    }
}