﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelixSoftware.Formularios;

namespace CelixSoftware
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Principal pagina = new Principal();
            pagina.Show();
            this.Hide();
        }
    }
}
