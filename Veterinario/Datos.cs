﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class Datos : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemon = new DataTable();
        public Datos()
        {
            InitializeComponent();
            dataGridView1.DataSource = miConexion.getAllClMa();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    }
}
