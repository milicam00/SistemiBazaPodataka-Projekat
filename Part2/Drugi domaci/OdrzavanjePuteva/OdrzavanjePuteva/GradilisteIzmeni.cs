using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdrzavanjePuteva
{
    public partial class GradilisteIzmeni : Form
    {
        public GradilisteBasic gradBasic;
        public GradilisteIzmeni()
        {
            InitializeComponent();
        }

        public GradilisteIzmeni(GradilisteBasic gb)
        {
            this.gradBasic = gb;
            InitializeComponent();
            PopulateData();
        }
        private void PopulateData()
        {
            txtTIP.Text = gradBasic.Tip.ToString();
        }
        private void GradilisteIzmeni_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                gradBasic.Tip = txtTIP.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show("Greska!");
            }

        }
    }
}
