using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using OdrzavanjePuteva.Entiteti;
using OdrzavanjePuteva.Mapiranja;


namespace OdrzavanjePuteva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IzvrsilacInfo izvr = new IzvrsilacInfo();
            izvr.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VozilaInfo vozila = new VozilaInfo();
            vozila.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GradilisteInfo gradiliste = new GradilisteInfo();
            gradiliste.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpoljniSaradnikInfo spoljniSaradnik = new SpoljniSaradnikInfo();
            spoljniSaradnik.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeonicaInfo deonica = new DeonicaInfo();
            deonica.Show();
        }
    }
}
