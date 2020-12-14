using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practica_loginDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.practica_loginDataSet.usuarios);

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Logincs lg = new Logincs();
            lg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Funciones.mostrar();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            FormCreate fc = new FormCreate();
            fc.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            FormUpdate fu = new FormUpdate();
            fu.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            FormDelete fd = new FormDelete();
            fd.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Funciones.mostrar();
        }
    }
}
