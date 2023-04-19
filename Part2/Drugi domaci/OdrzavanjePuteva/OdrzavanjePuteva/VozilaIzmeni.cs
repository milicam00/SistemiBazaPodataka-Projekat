using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Linq;
using OdrzavanjePuteva.Entiteti;
using NHibernate;

namespace OdrzavanjePuteva
{
    public partial class VozilaIzmeni : Form
    {
        public Putnicka vozilo;
        public VozilaIzmeni()
        {
            InitializeComponent();
        }
        public VozilaIzmeni(int i)
        {
            InitializeComponent();
            this.PopulateData(i);
        }
        private void PopulateData(int id)
        {
            ISession session = DataLayer.GetSession();
            Putnicka izv = session.Get<Putnicka>(id);
            txtReg.Text = izv.RegistarskaOznaka;
            txtGor.Text = izv.TipGoriva;
            txtBoja.Text = izv.Boja;
            txtZAP.Text = izv.RadnaZapremina.ToString();
            txtBrMeS.Text = izv.BrojMesta.ToString();

            listBox1.Items.Clear();
            List<Nadzornik> nadzornici = DTOManager.GetNadzornici(izv.IdVozila);
            int m = 1;
            foreach(Koriste k in izv.RadniciKoriste)
            {
                Nadzornik nad = new Nadzornik();
                foreach(Nadzornik na in nadzornici)
                {
                    if (k.Nadzornik.IdRadnika == na.IdRadnika)
                        nad = na;
                }

                string str = $"{nad.Ime} {nad.Prezime} {nad.Jmbg} {k.DatumOd.ToShortDateString()} - {k.DatumDo.ToShortDateString()}";
                listBox1.Items.Add(str);
                m++;
            }
            listBox1.Refresh();

            cbxNad.Items.Clear();
            List<Nadzornik> nadzorniks = DTOManager.GetNadzornici();
            foreach(Nadzornik n in nadzorniks)
            {
                cbxNad.Items.Add($"{n.Jmbg}");
            }
            cbxNad.Refresh();
            session.Close();
            vozilo = izv;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vozilo.Boja = txtBoja.Text;
            vozilo.BrojMesta = Convert.ToInt32(txtBrMeS.Text);
            vozilo.RegistarskaOznaka = txtReg.Text;
            vozilo.TipGoriva = txtGor.Text;
            vozilo.RadnaZapremina = Convert.ToInt32(txtZAP.Text);

            ISession s = DataLayer.GetSession();
            s.Update(vozilo);
            s.Flush();
            s.Close();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        private void RefreshListBox()
        {
            listBox1.Items.Clear();
            List<Nadzornik> nadz = DTOManager.GetNadzornici(vozilo.IdVozila);

            int p = 1;
            foreach(Koriste kor in vozilo.RadniciKoriste)
            {
                Nadzornik n = new Nadzornik();
                foreach(Nadzornik nad in nadz)
                {
                    if(kor.Nadzornik.IdRadnika==nad.IdRadnika)
                    {
                        n = nad;
                    }
                }
                //string str = $"Od datuma: {kor.DatumOd} do datuma: {kor.DatumDo} - {n.Ime} {n.Prezime} {n.Jmbg}";

                string str = $"{n.Ime} {n.Prezime} {n.Jmbg} {kor.DatumOd.ToShortDateString()} - {kor.DatumDo.ToShortDateString()}";
                listBox1.Items.Add(str);
                p++;
            }
            listBox1.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Koriste kor = new Koriste();
            kor.DatumOd = datOd.Value;
            kor.DatumDo= datDo.Value;
            kor.Vozilo = vozilo;
            kor.Nadzornik = DTOManager.GetNadzornik(cbxNad.SelectedItem.ToString());
            vozilo.RadniciKoriste.Add(kor);

            ISession s = DataLayer.GetSession();
            s.Save(kor);
            s.Flush();
            s.Update(vozilo);
            s.Flush();
            s.Close();
            this.RefreshListBox();
        }
    }
}
