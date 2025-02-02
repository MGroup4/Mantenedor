﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormPropiedadesDispo : Form
    {
        public FormPropiedadesDispo()
        {
            InitializeComponent();
        }

        public void MostrarRegistro()
        {
            DGV.DataSource = N_Venta.MostrarRegistro();
        }

        public void MostrarRegistroAlquiler()
        {
            DGV.DataSource = N_Alquiler.MostrarRegistro();
        }

        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
        }


        private void buttonComprarAlquilar_Click(object sender, EventArgs e)
        {
            FrmVentaAdd formulariom = new FrmVentaAdd();
            formulariom.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            formulariom.ShowDialog();
        }

        private void FormPropiedadesDispo_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void buttonMostrarVenta_Click(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void buttonMostrarAlquiler_Click(object sender, EventArgs e)
        {
            MostrarRegistroAlquiler();
        }
    }
}
