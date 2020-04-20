namespace Veterinario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Mascotas = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.Vacunas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BuscadorCliente = new System.Windows.Forms.Button();
            this.BuscadorMascota = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(496, 541);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.Vacunas);
            this.tabPage1.Controls.Add(this.Clientes);
            this.tabPage1.Controls.Add(this.Mascotas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.BuscadorMascota);
            this.tabPage2.Controls.Add(this.BuscadorCliente);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(488, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // Mascotas
            // 
            this.Mascotas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Mascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mascotas.Location = new System.Drawing.Point(89, 67);
            this.Mascotas.Name = "Mascotas";
            this.Mascotas.Size = new System.Drawing.Size(106, 152);
            this.Mascotas.TabIndex = 0;
            this.Mascotas.Text = "Mascotas";
            this.Mascotas.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.Location = new System.Drawing.Point(89, 288);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(106, 152);
            this.Clientes.TabIndex = 1;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = false;
            // 
            // Vacunas
            // 
            this.Vacunas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Vacunas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vacunas.Location = new System.Drawing.Point(274, 140);
            this.Vacunas.Name = "Vacunas";
            this.Vacunas.Size = new System.Drawing.Size(106, 214);
            this.Vacunas.TabIndex = 2;
            this.Vacunas.Text = "Vacunas";
            this.Vacunas.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(6, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(6, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(476, 20);
            this.textBox2.TabIndex = 1;
            // 
            // BuscadorCliente
            // 
            this.BuscadorCliente.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BuscadorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscadorCliente.Location = new System.Drawing.Point(6, 86);
            this.BuscadorCliente.Name = "BuscadorCliente";
            this.BuscadorCliente.Size = new System.Drawing.Size(133, 23);
            this.BuscadorCliente.TabIndex = 2;
            this.BuscadorCliente.Text = "Buscar Cliente";
            this.BuscadorCliente.UseVisualStyleBackColor = false;
            // 
            // BuscadorMascota
            // 
            this.BuscadorMascota.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BuscadorMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscadorMascota.Location = new System.Drawing.Point(6, 291);
            this.BuscadorMascota.Name = "BuscadorMascota";
            this.BuscadorMascota.Size = new System.Drawing.Size(133, 23);
            this.BuscadorMascota.TabIndex = 3;
            this.BuscadorMascota.Text = "Buscar Mascota";
            this.BuscadorMascota.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 541);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Vacunas;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Mascotas;
        private System.Windows.Forms.Button BuscadorMascota;
        private System.Windows.Forms.Button BuscadorCliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

