namespace Veterinario
{
    partial class VentanaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Vacunas = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.Mascotas = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BuscadorMascota = new System.Windows.Forms.Button();
            this.BuscadorCliente = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.tabControl1.ImageList = this.imageList1;
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
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            // 
            // Vacunas
            // 
            this.Vacunas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Vacunas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vacunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vacunas.Location = new System.Drawing.Point(274, 140);
            this.Vacunas.Name = "Vacunas";
            this.Vacunas.Size = new System.Drawing.Size(106, 214);
            this.Vacunas.TabIndex = 2;
            this.Vacunas.Text = "Vacunas";
            this.Vacunas.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.Location = new System.Drawing.Point(89, 288);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(106, 152);
            this.Clientes.TabIndex = 1;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = false;
            // 
            // Mascotas
            // 
            this.Mascotas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Mascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mascotas.Location = new System.Drawing.Point(89, 80);
            this.Mascotas.Name = "Mascotas";
            this.Mascotas.Size = new System.Drawing.Size(106, 152);
            this.Mascotas.TabIndex = 0;
            this.Mascotas.Text = "Mascotas";
            this.Mascotas.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.BuscadorMascota);
            this.tabPage2.Controls.Add(this.BuscadorCliente);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(488, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscador";
            // 
            // BuscadorMascota
            // 
            this.BuscadorMascota.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BuscadorMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscadorMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscadorMascota.Location = new System.Drawing.Point(6, 291);
            this.BuscadorMascota.Name = "BuscadorMascota";
            this.BuscadorMascota.Size = new System.Drawing.Size(152, 37);
            this.BuscadorMascota.TabIndex = 3;
            this.BuscadorMascota.Text = "Buscar Mascota";
            this.BuscadorMascota.UseVisualStyleBackColor = false;
            // 
            // BuscadorCliente
            // 
            this.BuscadorCliente.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BuscadorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscadorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscadorCliente.Location = new System.Drawing.Point(6, 86);
            this.BuscadorCliente.Name = "BuscadorCliente";
            this.BuscadorCliente.Size = new System.Drawing.Size(152, 32);
            this.BuscadorCliente.TabIndex = 2;
            this.BuscadorCliente.Text = "Buscar Cliente";
            this.BuscadorCliente.UseVisualStyleBackColor = false;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(6, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 20);
            this.textBox1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_search_32px.png");
            this.imageList1.Images.SetKeyName(1, "icons8_dog_house_24px.png");
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 541);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.Text = "Veterinario";
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
        private System.Windows.Forms.ImageList imageList1;
    }
}

