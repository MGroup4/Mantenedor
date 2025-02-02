﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void AbrirFormEnPanel(object Formhijo)
        {
            if (this.Pvie.Controls.Count > 0)
                this.Pvie.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pvie.Controls.Add(fh);
            this.Pvie.Tag = fh;
            fh.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmUsuario());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAgente());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmPropiedad());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmUsuario());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormPropiedadesDispo());
;        }
    }
}
