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
    public partial class SpoljniSaradnikIzmeni : Form
    {
        private SpoljniSaradnik sp;
        public SpoljniSaradnikIzmeni()
        {
            InitializeComponent();
        }
        private SpoljniSaradnik GetSpoljni(int idd)
        {
            ISession session = DataLayer.GetSession();
            SpoljniSaradnik sp = session.Get<SpoljniSaradnik>(idd);
            session.Close();
            return sp;
        }

        private Nadzornik GetNadzornik(int id)
        {
            ISession s = DataLayer.GetSession();
            Nadzornik ret = s.Get<Nadzornik>(id);
            s.Close();
            return ret;
        }

        public SpoljniSaradnikIzmeni(int x)
        {
            InitializeComponent();
            SpoljniSaradnik spoljni = GetSpoljni(x);
            this.sp = spoljni;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpoljniSaradnik saradnik = s.Get<SpoljniSaradnik>(sp.IdSpoljnogSaradnika);
                saradnik.BrUgovoraODelu = Convert.ToInt32(textBox1.Text);
                saradnik.Nadzornik = DTOManager.GetNadzornik(cbxNad.SelectedItem.ToString());
                s.Update(saradnik);
                s.Flush();
                s.Close();

                this.Close();
                this.DialogResult = DialogResult.OK;

            }
            catch(Exception ec)
            {

            }


        }

        private void SpoljniSaradnikIzmeni_Load(object sender, EventArgs e)
        {
            textBox1.Text = sp.BrUgovoraODelu.ToString();
            cbxNad.Items.Clear();
            Nadzornik nadzornik = GetNadzornik(sp.Nadzornik.IdRadnika);
            List<Nadzornik> nadz = DTOManager.GetNadzornici();
            foreach(Nadzornik n in nadz)
            {
                cbxNad.Items.Add($"{n.Jmbg}");
                listBox1.Items.Add($"{n.Ime} {n.Prezime} {n.Jmbg}");

            }
            cbxNad.SelectedItem = nadzornik.Jmbg;
            cbxNad.Refresh();
            listBox1.Refresh();
        }
    }
}
