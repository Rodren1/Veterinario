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
            this.Datos = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.Mascotas = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.insertCliente = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxNombreC = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.insertMascota = new System.Windows.Forms.Button();
            this.textBoxDueño = new System.Windows.Forms.TextBox();
            this.labelDueño = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxEspecie = new System.Windows.Forms.TextBox();
            this.labelEspecie = new System.Windows.Forms.Label();
            this.textBoxNombre_mascota = new System.Windows.Forms.TextBox();
            this.labelNombre_mascota = new System.Windows.Forms.Label();
            this.textBoxCodigo_identif = new System.Windows.Forms.TextBox();
            this.labelCodigo_identif = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBoxDniUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuarioDni = new System.Windows.Forms.Label();
            this.registroUsuarios = new System.Windows.Forms.Button();
            this.textBoxTelefonoUs = new System.Windows.Forms.TextBox();
            this.labelTelefonoUs = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxNombre_us = new System.Windows.Forms.TextBox();
            this.labelDniUs = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
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
            this.tabPage1.Controls.Add(this.Datos);
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
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(89, 288);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(298, 90);
            this.Datos.TabIndex = 2;
            this.Datos.Text = "Datos";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.Location = new System.Drawing.Point(281, 80);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(106, 152);
            this.Clientes.TabIndex = 1;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = false;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
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
            this.Mascotas.Click += new System.EventHandler(this.Mascotas_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Teal;
            this.tabPage3.Controls.Add(this.insertCliente);
            this.tabPage3.Controls.Add(this.textBoxEmail);
            this.tabPage3.Controls.Add(this.labelEmail);
            this.tabPage3.Controls.Add(this.textBoxTelefono);
            this.tabPage3.Controls.Add(this.labelTelefono);
            this.tabPage3.Controls.Add(this.textBoxDireccion);
            this.tabPage3.Controls.Add(this.labelDireccion);
            this.tabPage3.Controls.Add(this.textBoxApellido);
            this.tabPage3.Controls.Add(this.labelApellido);
            this.tabPage3.Controls.Add(this.textBoxNombreC);
            this.tabPage3.Controls.Add(this.labelNombre);
            this.tabPage3.Controls.Add(this.textBoxDNI);
            this.tabPage3.Controls.Add(this.labelDni);
            this.tabPage3.ImageIndex = 3;
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(488, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registrar Clientes";
            // 
            // insertCliente
            // 
            this.insertCliente.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.insertCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertCliente.Location = new System.Drawing.Point(138, 336);
            this.insertCliente.Name = "insertCliente";
            this.insertCliente.Size = new System.Drawing.Size(182, 41);
            this.insertCliente.TabIndex = 12;
            this.insertCliente.Text = "Registrar Cliente";
            this.insertCliente.UseVisualStyleBackColor = false;
            this.insertCliente.Click += new System.EventHandler(this.insertCliente_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.Location = new System.Drawing.Point(201, 253);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(203, 26);
            this.textBoxEmail.TabIndex = 11;
            // 
            // labelEmail
            // 
            this.labelEmail.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.labelEmail.Location = new System.Drawing.Point(72, 253);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(96, 23);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email : ";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxTelefono.Location = new System.Drawing.Point(201, 221);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(203, 26);
            this.textBoxTelefono.TabIndex = 9;
            // 
            // labelTelefono
            // 
            this.labelTelefono.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTelefono.Location = new System.Drawing.Point(72, 221);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(96, 23);
            this.labelTelefono.TabIndex = 8;
            this.labelTelefono.Text = "Telefono : ";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxDireccion.Location = new System.Drawing.Point(201, 189);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(203, 26);
            this.textBoxDireccion.TabIndex = 7;
            // 
            // labelDireccion
            // 
            this.labelDireccion.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDireccion.Location = new System.Drawing.Point(72, 189);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(96, 23);
            this.labelDireccion.TabIndex = 6;
            this.labelDireccion.Text = "Direccion";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxApellido.Location = new System.Drawing.Point(201, 157);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(203, 26);
            this.textBoxApellido.TabIndex = 5;
            // 
            // labelApellido
            // 
            this.labelApellido.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.SystemColors.Window;
            this.labelApellido.Location = new System.Drawing.Point(72, 157);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(96, 23);
            this.labelApellido.TabIndex = 4;
            this.labelApellido.Text = "Apellido : ";
            // 
            // textBoxNombreC
            // 
            this.textBoxNombreC.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreC.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxNombreC.Location = new System.Drawing.Point(201, 125);
            this.textBoxNombreC.Name = "textBoxNombreC";
            this.textBoxNombreC.Size = new System.Drawing.Size(203, 26);
            this.textBoxNombreC.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.labelNombre.Location = new System.Drawing.Point(72, 125);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(96, 23);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre : ";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxDNI.Location = new System.Drawing.Point(201, 93);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(203, 26);
            this.textBoxDNI.TabIndex = 1;
            // 
            // labelDni
            // 
            this.labelDni.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDni.Location = new System.Drawing.Point(72, 93);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(96, 23);
            this.labelDni.TabIndex = 0;
            this.labelDni.Text = "DNI : ";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Teal;
            this.tabPage4.Controls.Add(this.insertMascota);
            this.tabPage4.Controls.Add(this.textBoxDueño);
            this.tabPage4.Controls.Add(this.labelDueño);
            this.tabPage4.Controls.Add(this.textBoxEdad);
            this.tabPage4.Controls.Add(this.labelEdad);
            this.tabPage4.Controls.Add(this.textBoxEspecie);
            this.tabPage4.Controls.Add(this.labelEspecie);
            this.tabPage4.Controls.Add(this.textBoxNombre_mascota);
            this.tabPage4.Controls.Add(this.labelNombre_mascota);
            this.tabPage4.Controls.Add(this.textBoxCodigo_identif);
            this.tabPage4.Controls.Add(this.labelCodigo_identif);
            this.tabPage4.ImageIndex = 2;
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(488, 506);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Registrar Mascotas";
            // 
            // insertMascota
            // 
            this.insertMascota.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.insertMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertMascota.Location = new System.Drawing.Point(148, 294);
            this.insertMascota.Name = "insertMascota";
            this.insertMascota.Size = new System.Drawing.Size(182, 41);
            this.insertMascota.TabIndex = 20;
            this.insertMascota.Text = "Registrar Mascota";
            this.insertMascota.UseVisualStyleBackColor = false;
            this.insertMascota.Click += new System.EventHandler(this.insertMascota_Click);
            // 
            // textBoxDueño
            // 
            this.textBoxDueño.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDueño.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxDueño.Location = new System.Drawing.Point(212, 223);
            this.textBoxDueño.Name = "textBoxDueño";
            this.textBoxDueño.Size = new System.Drawing.Size(203, 26);
            this.textBoxDueño.TabIndex = 19;
            // 
            // labelDueño
            // 
            this.labelDueño.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueño.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDueño.Location = new System.Drawing.Point(76, 223);
            this.labelDueño.Name = "labelDueño";
            this.labelDueño.Size = new System.Drawing.Size(118, 23);
            this.labelDueño.TabIndex = 18;
            this.labelDueño.Text = "Dueño : ";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEdad.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxEdad.Location = new System.Drawing.Point(212, 191);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(203, 26);
            this.textBoxEdad.TabIndex = 17;
            // 
            // labelEdad
            // 
            this.labelEdad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.ForeColor = System.Drawing.SystemColors.Window;
            this.labelEdad.Location = new System.Drawing.Point(76, 191);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(118, 23);
            this.labelEdad.TabIndex = 16;
            this.labelEdad.Text = "Edad :";
            // 
            // textBoxEspecie
            // 
            this.textBoxEspecie.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEspecie.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxEspecie.Location = new System.Drawing.Point(212, 159);
            this.textBoxEspecie.Name = "textBoxEspecie";
            this.textBoxEspecie.Size = new System.Drawing.Size(203, 26);
            this.textBoxEspecie.TabIndex = 15;
            // 
            // labelEspecie
            // 
            this.labelEspecie.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecie.ForeColor = System.Drawing.SystemColors.Window;
            this.labelEspecie.Location = new System.Drawing.Point(76, 159);
            this.labelEspecie.Name = "labelEspecie";
            this.labelEspecie.Size = new System.Drawing.Size(118, 23);
            this.labelEspecie.TabIndex = 14;
            this.labelEspecie.Text = "Especie : ";
            // 
            // textBoxNombre_mascota
            // 
            this.textBoxNombre_mascota.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxNombre_mascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre_mascota.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxNombre_mascota.Location = new System.Drawing.Point(212, 127);
            this.textBoxNombre_mascota.Name = "textBoxNombre_mascota";
            this.textBoxNombre_mascota.Size = new System.Drawing.Size(203, 26);
            this.textBoxNombre_mascota.TabIndex = 13;
            // 
            // labelNombre_mascota
            // 
            this.labelNombre_mascota.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelNombre_mascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre_mascota.ForeColor = System.Drawing.SystemColors.Window;
            this.labelNombre_mascota.Location = new System.Drawing.Point(76, 127);
            this.labelNombre_mascota.Name = "labelNombre_mascota";
            this.labelNombre_mascota.Size = new System.Drawing.Size(118, 23);
            this.labelNombre_mascota.TabIndex = 12;
            this.labelNombre_mascota.Text = "Nombre : ";
            // 
            // textBoxCodigo_identif
            // 
            this.textBoxCodigo_identif.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxCodigo_identif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo_identif.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxCodigo_identif.Location = new System.Drawing.Point(212, 95);
            this.textBoxCodigo_identif.Name = "textBoxCodigo_identif";
            this.textBoxCodigo_identif.Size = new System.Drawing.Size(203, 26);
            this.textBoxCodigo_identif.TabIndex = 11;
            // 
            // labelCodigo_identif
            // 
            this.labelCodigo_identif.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelCodigo_identif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo_identif.ForeColor = System.Drawing.SystemColors.Window;
            this.labelCodigo_identif.Location = new System.Drawing.Point(76, 95);
            this.labelCodigo_identif.Name = "labelCodigo_identif";
            this.labelCodigo_identif.Size = new System.Drawing.Size(118, 23);
            this.labelCodigo_identif.TabIndex = 10;
            this.labelCodigo_identif.Text = "Identificador : ";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Teal;
            this.tabPage5.Controls.Add(this.textBoxDniUsuario);
            this.tabPage5.Controls.Add(this.labelUsuarioDni);
            this.tabPage5.Controls.Add(this.registroUsuarios);
            this.tabPage5.Controls.Add(this.textBoxTelefonoUs);
            this.tabPage5.Controls.Add(this.labelTelefonoUs);
            this.tabPage5.Controls.Add(this.textBoxContraseña);
            this.tabPage5.Controls.Add(this.labelContraseña);
            this.tabPage5.Controls.Add(this.textBoxNombre_us);
            this.tabPage5.Controls.Add(this.labelDniUs);
            this.tabPage5.ImageIndex = 4;
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(488, 506);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Registro";
            // 
            // textBoxDniUsuario
            // 
            this.textBoxDniUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDniUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDniUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxDniUsuario.Location = new System.Drawing.Point(207, 98);
            this.textBoxDniUsuario.Name = "textBoxDniUsuario";
            this.textBoxDniUsuario.Size = new System.Drawing.Size(203, 26);
            this.textBoxDniUsuario.TabIndex = 36;
            // 
            // labelUsuarioDni
            // 
            this.labelUsuarioDni.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelUsuarioDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioDni.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUsuarioDni.Location = new System.Drawing.Point(71, 98);
            this.labelUsuarioDni.Name = "labelUsuarioDni";
            this.labelUsuarioDni.Size = new System.Drawing.Size(118, 23);
            this.labelUsuarioDni.TabIndex = 35;
            this.labelUsuarioDni.Text = "DNI : ";
            // 
            // registroUsuarios
            // 
            this.registroUsuarios.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.registroUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registroUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroUsuarios.Location = new System.Drawing.Point(149, 263);
            this.registroUsuarios.Name = "registroUsuarios";
            this.registroUsuarios.Size = new System.Drawing.Size(182, 41);
            this.registroUsuarios.TabIndex = 34;
            this.registroUsuarios.Text = "Registrar Usuario";
            this.registroUsuarios.UseVisualStyleBackColor = false;
            this.registroUsuarios.Click += new System.EventHandler(this.registroUsuarios_Click);
            // 
            // textBoxTelefonoUs
            // 
            this.textBoxTelefonoUs.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxTelefonoUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefonoUs.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxTelefonoUs.Location = new System.Drawing.Point(207, 201);
            this.textBoxTelefonoUs.Name = "textBoxTelefonoUs";
            this.textBoxTelefonoUs.Size = new System.Drawing.Size(203, 26);
            this.textBoxTelefonoUs.TabIndex = 33;
            // 
            // labelTelefonoUs
            // 
            this.labelTelefonoUs.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelTelefonoUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonoUs.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTelefonoUs.Location = new System.Drawing.Point(71, 201);
            this.labelTelefonoUs.Name = "labelTelefonoUs";
            this.labelTelefonoUs.Size = new System.Drawing.Size(118, 23);
            this.labelTelefonoUs.TabIndex = 32;
            this.labelTelefonoUs.Text = "Telefono :";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxContraseña.Location = new System.Drawing.Point(207, 169);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(203, 26);
            this.textBoxContraseña.TabIndex = 31;
            // 
            // labelContraseña
            // 
            this.labelContraseña.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.labelContraseña.Location = new System.Drawing.Point(71, 169);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(118, 23);
            this.labelContraseña.TabIndex = 30;
            this.labelContraseña.Text = "Contraseña : ";
            // 
            // textBoxNombre_us
            // 
            this.textBoxNombre_us.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxNombre_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre_us.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxNombre_us.Location = new System.Drawing.Point(207, 137);
            this.textBoxNombre_us.Name = "textBoxNombre_us";
            this.textBoxNombre_us.Size = new System.Drawing.Size(203, 26);
            this.textBoxNombre_us.TabIndex = 29;
            // 
            // labelDniUs
            // 
            this.labelDniUs.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelDniUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDniUs.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDniUs.Location = new System.Drawing.Point(71, 137);
            this.labelDniUs.Name = "labelDniUs";
            this.labelDniUs.Size = new System.Drawing.Size(118, 23);
            this.labelDniUs.TabIndex = 28;
            this.labelDniUs.Text = "Nombre : ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_dog_house_24px.png");
            this.imageList1.Images.SetKeyName(1, "icons8_animal_shelter_24px.png");
            this.imageList1.Images.SetKeyName(2, "icons8_customer_32px.png");
            this.imageList1.Images.SetKeyName(3, "portapapeles.png");
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 541);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "Veterinario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Mascotas;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxNombreC;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxDueño;
        private System.Windows.Forms.Label labelDueño;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox textBoxEspecie;
        private System.Windows.Forms.Label labelEspecie;
        private System.Windows.Forms.TextBox textBoxNombre_mascota;
        private System.Windows.Forms.Label labelNombre_mascota;
        private System.Windows.Forms.TextBox textBoxCodigo_identif;
        private System.Windows.Forms.Label labelCodigo_identif;
        private System.Windows.Forms.Button insertCliente;
        private System.Windows.Forms.Button insertMascota;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBoxTelefonoUs;
        private System.Windows.Forms.Label labelTelefonoUs;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxNombre_us;
        private System.Windows.Forms.Label labelDniUs;
        private System.Windows.Forms.Button registroUsuarios;
        private System.Windows.Forms.TextBox textBoxDniUsuario;
        private System.Windows.Forms.Label labelUsuarioDni;
    }
}

