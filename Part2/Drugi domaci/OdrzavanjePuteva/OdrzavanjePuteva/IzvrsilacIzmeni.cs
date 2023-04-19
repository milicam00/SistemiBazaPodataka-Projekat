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
    public partial class IzvrsilacIzmeni : Form
    {
        public IzvrsilacBasic izvrsilacBasic;
        public IzvrsilacIzmeni()
        {
            InitializeComponent();
        }

        public IzvrsilacIzmeni(IzvrsilacBasic i)
        {
            this.izvrsilacBasic = i;
            InitializeComponent();
            PopulateData();
        }
        private void refreshListBox()
        {
            ISession s = DataLayer.GetSession();

            Izvrsilac izv = s.Get<Izvrsilac>(izvrsilacBasic.IdRadnika);
            listBox2.Items.Clear();
            List<Vozilo> vInfos = DTOManager.GetVozilaInfo(izvrsilacBasic.IdRadnika);

            int m = 1;
            foreach (Upravlja u in izv.UpravljaVozilima)
            {
                Vozilo op = new Vozilo();
                foreach (Vozilo nadd in vInfos)
                {
                    if (u.Vozilo.IdVozila == nadd.IdVozila)
                        op = nadd;
                }

                string s1 = $"Od datuma: {u.DatumOd} do datuma: {u.DatumDo} - {op.RegistarskaOznaka} {op.Boja} {op.TipGoriva} {op.RadnaZapremina}";
                listBox2.Items.Add(s1);
                m++;
            }
            listBox2.Refresh();
            s.Close();
        }
        private void PopulateData()
        {
            txtIme.Text = izvrsilacBasic.Ime;
            txtOcevoIme.Text = izvrsilacBasic.OcevoIme;
            textBox3.Text = izvrsilacBasic.Prezime;
            txtMatNad.Text = izvrsilacBasic.MatBrNadredjenog;

            ISession s = DataLayer.GetSession();
            Izvrsilac izvr = s.Get<Izvrsilac>(izvrsilacBasic.IdRadnika);
            s.Close();


            lbxDeonica.Items.Clear();
            List<DeonicaPregled> dInfos = DTOManager.GetDeonicaInfo(izvr);
            int p = 1;
            foreach(DeonicaPregled d in dInfos)
            {
                lbxDeonica.Items.Add($"{p}){d.OdKilometra} {d.DoKilometra} {d.OdGrada} {d.DoGrada}");
                p++;
            }
            lbxDeonica.Refresh();


            this.refreshListBox();


            cbxVozilo.Items.Clear();
            //List<VoziloPregled> v = DTOManager.GetVozilaInfo();
            List<PutnickaPregled> v = DTOManager.GetPutnickaInfo();
            //int k = 1;
            foreach(PutnickaPregled w in v)
            {
                //  cbxVozilo.Items.Add($"{ w.RegistarskaOznaka}");
                cbxVozilo.Items.Add($"{w.RegistarskaOznaka}");
                //k++;
            }
            cbxVozilo.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            izvrsilacBasic.OcevoIme = txtOcevoIme.Text;
            izvrsilacBasic.MatBrNadredjenog = txtMatNad.Text;
            izvrsilacBasic.Ime = txtIme.Text;
            izvrsilacBasic.Prezime = textBox3.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Izvrsilac izvr = s.Load<Izvrsilac>(izvrsilacBasic.IdRadnika);
            Upravlja up = new Upravlja();
            up.RadnikIzvrsilac = izvr;
            Vozilo voz = DTOManager.GetVozilo(cbxVozilo.SelectedItem.ToString());
            up.Vozilo = voz;
            up.DatumOd = datumOd.Value;
            up.DatumDo = datumDo.Value;
            s.Save(up);
            s.Flush();
            s.Close();
            this.refreshListBox();
        }

        private void IzvrsilacIzmeni_Load(object sender, EventArgs e)
        {

        }
    }
}
