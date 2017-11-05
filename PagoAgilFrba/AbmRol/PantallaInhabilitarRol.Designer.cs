namespace PagoAgilFrba.AbmRol
{
    partial class PantallaInhabilitarRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.seleccionarButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // atrasButton
            // 
            this.atrasButton.Font = new System.Drawing.Font("Verdana", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atrasButton.Location = new System.Drawing.Point(2388, 982);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(140, 100);
            this.atrasButton.TabIndex = 0;
            this.atrasButton.Text = "Atras";
            this.atrasButton.UseVisualStyleBackColor = true;
            this.atrasButton.Click += new System.EventHandler(this.atrasButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(934, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Lista de Roles:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // seleccionarButton
            // 
            this.seleccionarButton.Font = new System.Drawing.Font("Verdana", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionarButton.Location = new System.Drawing.Point(1522, 868);
            this.seleccionarButton.Name = "seleccionarButton";
            this.seleccionarButton.Size = new System.Drawing.Size(425, 65);
            this.seleccionarButton.TabIndex = 25;
            this.seleccionarButton.Text = "Inhabilitar Rol";
            this.seleccionarButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Verdana", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(941, 394);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1587, 388);
            this.listBox1.TabIndex = 24;
            // 
            // PantallaInhabilitarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2742, 1658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seleccionarButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.atrasButton);
            this.Name = "PantallaInhabilitarRol";
            this.Text = "Dar de Baja Rol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atrasButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button seleccionarButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}