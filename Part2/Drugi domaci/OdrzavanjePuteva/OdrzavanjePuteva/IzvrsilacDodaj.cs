using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OdrzavanjePuteva.Entiteti;

namespace OdrzavanjePuteva
{
    public partial class IzvrsilacDodaj : Form
    {
        public IzvrsilacDodaj()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Izvrsilac t = new Izvrsilac();

            t.Adresa = txtAdresa.Text;
            t.Ime = txtIme.Text;
            t.Prezime = txtPrezime.Text;
            t.Jmbg = txtJmbg.Text;
            t.OcevoIme = txtOcevoIme.Text;
            t.Specijalnost = txtSpec.Text;
            //MessageBox.Show(cbx.SelectedItem.ToString());
            t.MatBrNadredjenog = cbx.SelectedItem.ToString();
            t.GodinaRodjenja = txtGod.Text;
            DTOManager.CreateIzvrsilac(t);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void IzvrsilacDodaj_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }
        private void PopulateInfos()
        {
            cbx.Items.Clear();
            List<IzvrsilacPregled> izvrsioci = DTOManager.GetIzvrsiociInfo();
            foreach(IzvrsilacPregled ip in izvrsioci)
            {
                cbx.Items.Add(ip.Jmbg);
            }
            cbx.Refresh();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
