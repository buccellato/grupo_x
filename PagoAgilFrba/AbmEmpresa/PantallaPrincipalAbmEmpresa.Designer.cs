namespace PagoAgilFrba.AbmEmpresa
{
    partial class PantallaPrincipalAbmEmpresa
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
            this.eliminarButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.crearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // atrasButton
            // 
            this.atrasButton.Location = new System.Drawing.Point(2241, 1021);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(140, 100);
            this.atrasButton.TabIndex = 0;
            this.atrasButton.Text = "Atras";
            this.atrasButton.UseVisualStyleBackColor = true;
            this.atrasButton.Click += new System.EventHandler(this.atrasButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Font = new System.Drawing.Font("Verdana", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.Location = new System.Drawing.Point(1206, 824);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(1175, 150);
            this.eliminarButton.TabIndex = 6;
            this.eliminarButton.Text = "Dar de Baja Empresa";
            this.eliminarButton.UseCompatibleTextRendering = true;
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.Font = new System.Drawing.Font("Verdana", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarButton.Location = new System.Drawing.Point(1206, 628);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(1175, 150);
            this.modificarButton.TabIndex = 5;
            this.modificarButton.Text = "Modificar Empresa";
            this.modificarButton.UseCompatibleTextRendering = true;
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // crearButton
            // 
            this.crearButton.Font = new System.Drawing.Font("Verdana", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearButton.Location = new System.Drawing.Point(1206, 415);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(1175, 150);
            this.crearButton.TabIndex = 4;
            this.crearButton.Text = "Crear Empresa";
            this.crearButton.UseCompatibleTextRendering = true;
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.crearButton_Click);
            // 
            // PantallaPrincipalAbmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2896, 1580);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.crearButton);
            this.Controls.Add(this.atrasButton);
            this.Name = "PantallaPrincipalAbmEmpresa";
            this.Text = "Abm Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaAbmEmpresa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button atrasButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button crearButton;
    }
}