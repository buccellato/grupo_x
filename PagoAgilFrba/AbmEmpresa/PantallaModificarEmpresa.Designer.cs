namespace PagoAgilFrba.AbmEmpresa
{
    partial class PantallaModificarEmpresa
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
            this.SeleccionarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.rubro = new System.Windows.Forms.TextBox();
            this.cuit = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // atrasButton
            // 
            this.atrasButton.Location = new System.Drawing.Point(2176, 1089);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(155, 97);
            this.atrasButton.TabIndex = 67;
            this.atrasButton.Text = "Atras";
            this.atrasButton.UseVisualStyleBackColor = true;
            this.atrasButton.Click += new System.EventHandler(this.atrasButton_Click);
            // 
            // SeleccionarButton
            // 
            this.SeleccionarButton.Location = new System.Drawing.Point(2106, 923);
            this.SeleccionarButton.Name = "SeleccionarButton";
            this.SeleccionarButton.Size = new System.Drawing.Size(223, 106);
            this.SeleccionarButton.TabIndex = 76;
            this.SeleccionarButton.Text = "Seleccionar";
            this.SeleccionarButton.UseVisualStyleBackColor = true;
            this.SeleccionarButton.Click += new System.EventHandler(this.SeleccionarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1722, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 75;
            this.label3.Text = "Rubro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1094, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 74;
            this.label2.Text = "CUIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nombre:";
            // 
            // filtrarButton
            // 
            this.filtrarButton.Location = new System.Drawing.Point(452, 252);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(1878, 55);
            this.filtrarButton.TabIndex = 72;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            // 
            // rubro
            // 
            this.rubro.Location = new System.Drawing.Point(1728, 184);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(603, 38);
            this.rubro.TabIndex = 71;
            // 
            // cuit
            // 
            this.cuit.Location = new System.Drawing.Point(1100, 184);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(603, 38);
            this.cuit.TabIndex = 70;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(452, 184);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(603, 38);
            this.nombre.TabIndex = 69;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(452, 336);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1879, 562);
            this.listBox1.TabIndex = 68;
            // 
            // PantallaModificarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2409, 1198);
            this.Controls.Add(this.SeleccionarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.rubro);
            this.Controls.Add(this.cuit);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.atrasButton);
            this.Name = "PantallaModificarEmpresa";
            this.Text = "Seleccionar Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button atrasButton;
        private System.Windows.Forms.Button SeleccionarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.TextBox rubro;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.ListBox listBox1;
    }
}