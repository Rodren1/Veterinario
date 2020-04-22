namespace Veterinario
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsuarioTBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTBox = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.Label();
            this.inicioSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioTBox
            // 
            this.UsuarioTBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UsuarioTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTBox.ForeColor = System.Drawing.SystemColors.Window;
            this.UsuarioTBox.Location = new System.Drawing.Point(84, 227);
            this.UsuarioTBox.Name = "UsuarioTBox";
            this.UsuarioTBox.Size = new System.Drawing.Size(181, 26);
            this.UsuarioTBox.TabIndex = 0;
            // 
            // ContraseñaTBox
            // 
            this.ContraseñaTBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ContraseñaTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaTBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ContraseñaTBox.Location = new System.Drawing.Point(84, 306);
            this.ContraseñaTBox.Name = "ContraseñaTBox";
            this.ContraseñaTBox.Size = new System.Drawing.Size(181, 26);
            this.ContraseñaTBox.TabIndex = 1;
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(81, 189);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(77, 23);
            this.usuario.TabIndex = 2;
            this.usuario.Text = "Usuario";
            // 
            // contraseña
            // 
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(81, 280);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(105, 23);
            this.contraseña.TabIndex = 3;
            this.contraseña.Text = "Contraseña";
            // 
            // inicioSesion
            // 
            this.inicioSesion.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.inicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioSesion.Location = new System.Drawing.Point(101, 348);
            this.inicioSesion.Name = "inicioSesion";
            this.inicioSesion.Size = new System.Drawing.Size(139, 50);
            this.inicioSesion.TabIndex = 4;
            this.inicioSesion.Text = "Iniciar Sesión";
            this.inicioSesion.UseVisualStyleBackColor = false;
            this.inicioSesion.Click += new System.EventHandler(this.inicioSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(377, 445);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inicioSesion);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.ContraseñaTBox);
            this.Controls.Add(this.UsuarioTBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsuarioTBox;
        private System.Windows.Forms.TextBox ContraseñaTBox;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.Button inicioSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}