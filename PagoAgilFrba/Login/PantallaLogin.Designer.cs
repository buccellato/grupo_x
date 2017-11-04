namespace PagoAgilFrba.Login
{
    partial class PantallaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaLogin));
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.ingresarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(1406, 470);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(500, 38);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(1406, 618);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(500, 38);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ingresarButton
            // 
            this.ingresarButton.Location = new System.Drawing.Point(1406, 718);
            this.ingresarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(488, 81);
            this.ingresarButton.TabIndex = 2;
            this.ingresarButton.Text = "Ingresar";
            this.ingresarButton.UseVisualStyleBackColor = true;
            this.ingresarButton.Click += new System.EventHandler(this.ingresarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1580, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1401, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1401, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // adminBox
            // 
            this.adminBox.AutoSize = true;
            this.adminBox.Location = new System.Drawing.Point(2097, 467);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(134, 36);
            this.adminBox.TabIndex = 6;
            this.adminBox.Text = "Admin";
            this.adminBox.UseVisualStyleBackColor = true;
            // 
            // PantallaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(2343, 1408);
            this.Controls.Add(this.adminBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingresarButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaLogin";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox adminBox;
    }
}