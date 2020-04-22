namespace Veterinario
{
    partial class FichaMascotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichaMascotas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFichaNombreMascota = new System.Windows.Forms.Label();
            this.labelFichaEdad = new System.Windows.Forms.Label();
            this.labelFichaEspecie = new System.Windows.Forms.Label();
            this.labelFichaDueño = new System.Windows.Forms.Label();
            this.anteriorMascota = new System.Windows.Forms.Button();
            this.siguienteMascota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelFichaNombreMascota
            // 
            this.labelFichaNombreMascota.BackColor = System.Drawing.Color.Black;
            this.labelFichaNombreMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFichaNombreMascota.ForeColor = System.Drawing.SystemColors.Window;
            this.labelFichaNombreMascota.Location = new System.Drawing.Point(12, 184);
            this.labelFichaNombreMascota.Name = "labelFichaNombreMascota";
            this.labelFichaNombreMascota.Size = new System.Drawing.Size(429, 37);
            this.labelFichaNombreMascota.TabIndex = 1;
            // 
            // labelFichaEdad
            // 
            this.labelFichaEdad.BackColor = System.Drawing.Color.Black;
            this.labelFichaEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFichaEdad.ForeColor = System.Drawing.SystemColors.Window;
            this.labelFichaEdad.Location = new System.Drawing.Point(12, 288);
            this.labelFichaEdad.Name = "labelFichaEdad";
            this.labelFichaEdad.Size = new System.Drawing.Size(429, 37);
            this.labelFichaEdad.TabIndex = 2;
            // 
            // labelFichaEspecie
            // 
            this.labelFichaEspecie.BackColor = System.Drawing.Color.Black;
            this.labelFichaEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFichaEspecie.ForeColor = System.Drawing.SystemColors.Window;
            this.labelFichaEspecie.Location = new System.Drawing.Point(12, 235);
            this.labelFichaEspecie.Name = "labelFichaEspecie";
            this.labelFichaEspecie.Size = new System.Drawing.Size(429, 37);
            this.labelFichaEspecie.TabIndex = 3;
            // 
            // labelFichaDueño
            // 
            this.labelFichaDueño.BackColor = System.Drawing.Color.Black;
            this.labelFichaDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFichaDueño.ForeColor = System.Drawing.SystemColors.Window;
            this.labelFichaDueño.Location = new System.Drawing.Point(11, 339);
            this.labelFichaDueño.Name = "labelFichaDueño";
            this.labelFichaDueño.Size = new System.Drawing.Size(429, 37);
            this.labelFichaDueño.TabIndex = 4;
            // 
            // anteriorMascota
            // 
            this.anteriorMascota.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.anteriorMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anteriorMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anteriorMascota.Location = new System.Drawing.Point(103, 492);
            this.anteriorMascota.Name = "anteriorMascota";
            this.anteriorMascota.Size = new System.Drawing.Size(97, 38);
            this.anteriorMascota.TabIndex = 5;
            this.anteriorMascota.Text = "Anterior";
            this.anteriorMascota.UseVisualStyleBackColor = false;
            this.anteriorMascota.Click += new System.EventHandler(this.anteriorMascota_Click);
            // 
            // siguienteMascota
            // 
            this.siguienteMascota.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.siguienteMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siguienteMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siguienteMascota.Location = new System.Drawing.Point(271, 491);
            this.siguienteMascota.Name = "siguienteMascota";
            this.siguienteMascota.Size = new System.Drawing.Size(97, 38);
            this.siguienteMascota.TabIndex = 6;
            this.siguienteMascota.Text = "Siguiente";
            this.siguienteMascota.UseVisualStyleBackColor = false;
            this.siguienteMascota.Click += new System.EventHandler(this.siguienteMascota_Click);
            // 
            // FichaMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(496, 541);
            this.Controls.Add(this.siguienteMascota);
            this.Controls.Add(this.anteriorMascota);
            this.Controls.Add(this.labelFichaDueño);
            this.Controls.Add(this.labelFichaEspecie);
            this.Controls.Add(this.labelFichaEdad);
            this.Controls.Add(this.labelFichaNombreMascota);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FichaMascotas";
            this.Text = "FichaMascotas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFichaNombreMascota;
        private System.Windows.Forms.Label labelFichaEdad;
        private System.Windows.Forms.Label labelFichaEspecie;
        private System.Windows.Forms.Label labelFichaDueño;
        private System.Windows.Forms.Button anteriorMascota;
        private System.Windows.Forms.Button siguienteMascota;
    }
}