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
using NHibernate.Linq;

namespace OdrzavanjePuteva
{
    public partial class DeonicaDodaj : Form
    {
        List<Gradiliste> gradilista;
        public DeonicaDodaj()
        {
            InitializeComponent();
            gradilista = new List<Gradiliste>();
            PopulateDeonica();


        }
        private void PopulateDeonica()
        {
            ISession s = DataLayer.GetSession();
            IEnumerable<Gradiliste> deonice = from p in s.Query<Gradiliste>() select p;
            foreach(Gradiliste p in deonice)
            {
                gradilista.Add(p);
            }
            s.Close();
            List<Izvrsilac> izv = DTOManager.GetIzvrsilac();
            cbxJmbg.Items.Clear();
            foreach(Izvrsilac iz in izv)
            {
                cbxJmbg.Items.Add($"{iz.Jmbg}");
                listBox1.Items.Add($"{iz.Ime} {iz.Prezime} {iz.Jmbg}");
            }
            cbxJmbg.Refresh();
            listBox1.Refresh();

            cbxTip.Items.Clear();
            foreach(Gradiliste grad in gradilista)
            {
                cbxTip.Items.Add($"{grad.Tip}");
            }
            cbxTip.Refresh();
        }

       
        private void DeonicaDodaj_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Deonica deonica = new Deonica();
            deonica.Izvrsilac = DTOManager.getIzvrsilacJMBG(cbxJmbg.SelectedItem.ToString());
            deonica.OdGrada = txtOdGrada.Text;
            deonica.DoGrada = txtDoGrada.Text;
            deonica.OdKilometra = Convert.ToInt32(txtOdKilometra.Text);
            deonica.DoKilometra = Convert.ToInt32(txtDoKilometra.Text);
            deonica.DatumOd = datumOd.Value;
            deonica.DatumDo = datumDo.Value;
            Gradiliste gradiliste = new Gradiliste();

            foreach(Gradiliste g in gradilista)
            {
                if(g.Tip==cbxTip.SelectedItem.ToString())
                {
                    gradiliste = g;
                }
            }

            Gradiliste gra = s.Get<Gradiliste>(gradiliste.IdGradilista);
            deonica.Gradiliste = gra;
            gra.Deonice.Add(deonica);
            s.Save(deonica);
            s.Flush();

            gra.Deonice.Add(deonica);
            s.Update(gra);
            s.Flush();
            s.Close();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
