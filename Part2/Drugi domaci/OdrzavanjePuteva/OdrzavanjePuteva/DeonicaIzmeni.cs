using OdrzavanjePuteva.Entiteti;
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

namespace OdrzavanjePuteva
{
    public partial class DeonicaIzmeni : Form
    {
        public Deonica deonica;
        public DeonicaIzmeni(Deonica d)
        {
            this.deonica = d;
            InitializeComponent();
            PopulateData();
        }
         private void PopulateData()
        {
            txtOdKil.Text = deonica.OdKilometra.ToString();
            txtDoKil.Text = deonica.DoKilometra.ToString();
            txtOdG.Text = deonica.OdGrada.ToString();
            txtDoG.Text = deonica.DoGrada.ToString();
            datumOd.Value = deonica.DatumOd;
            datumDo.Value = deonica.DatumDo;

            List<Izvrsilac> izvrsioci = DTOManager.GetIzvrsilac();
            cbxJmbg.Items.Clear();
            foreach(Izvrsilac izv in izvrsioci)
            {
                cbxJmbg.Items.Add($"{izv.Jmbg}");
                listBox1.Items.Add($"{izv.Ime} {izv.Prezime} {izv.Jmbg}");
            }

            Izvrsilac izvrsilac = DTOManager.GetIzvrsilac(deonica.Izvrsilac.IdRadnika);
            cbxJmbg.SelectedItem = izvrsilac.Jmbg;
            cbxJmbg.Refresh();
            listBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            deonica.Izvrsilac = DTOManager.getIzvrsilacJMBG(cbxJmbg.SelectedItem.ToString());
            deonica.OdGrada = txtOdG.Text;
            deonica.DoGrada = txtDoG.Text;
            deonica.OdKilometra = Convert.ToInt32(txtOdKil.Text);
            deonica.DoKilometra = Convert.ToInt32(txtDoKil.Text);
            deonica.DatumOd = datumOd.Value;
            deonica.DatumDo = datumDo.Value;

            s.Update(deonica);
            s.Flush();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
