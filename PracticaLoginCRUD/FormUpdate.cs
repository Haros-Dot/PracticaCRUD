﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLoginCRUD
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.actualizar(Int32.Parse(txtID.Text), txtuser.Text, txtpass.Text);
            MessageBox.Show(mensaje);
            this.Close();

        }
    }
}
