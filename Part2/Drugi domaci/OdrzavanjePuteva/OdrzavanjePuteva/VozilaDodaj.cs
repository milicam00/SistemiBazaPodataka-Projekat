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
using OdrzavanjePuteva.Entiteti;

namespace OdrzavanjePuteva
{
    public partial class VozilaDodaj : Form
    {
        public Putnicka vozilo;
        public VozilaDodaj()
        {
            InitializeComponent();
            vozilo = new Putnicka();
        }

        public VozilaDodaj(int id)
        {
            InitializeComponent();
            vozilo = new Putnicka();
        }
        private void VozilaDodajcs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vozilo.Boja = txtBoja.Text;
            vozilo.BrojMesta = Convert.ToInt32(txtBrMesta.Text);
            vozilo.RegistarskaOznaka = txtReg.Text;
            vozilo.RadnaZapremina = Convert.ToInt32(txtZap.Text);
            vozilo.TipGoriva = txtGor.Text;

            ISession s = DataLayer.GetSession();
            s.Save(vozilo);
            s.Flush();
            s.Close();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();


        }
    }
}
