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
using NHibernate;

namespace OdrzavanjePuteva
{
    public partial class VozilaInfo : Form
    {
        public VozilaInfo()
        {
            InitializeComponent();
        }

        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<PutnickaPregled> vozila= DTOManager.GetVozInfo();
            foreach(PutnickaPregled vozilo in vozila)
            {
                ListViewItem item = new ListViewItem(new string[] { vozilo.IdVozila.ToString(), vozilo.RegistarskaOznaka.ToString(), vozilo.TipGoriva.ToString(), vozilo.Boja.ToString(), vozilo.RadnaZapremina.ToString() });
                listView1.Items.Add(item);
            }
            listView1.Refresh();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VozilaDodaj dodForm = new VozilaDodaj();
            if (dodForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PopulateInfos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Molimo Vas odaberite vozilo!");
            }

            int idd = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ISession s = DataLayer.GetSession();
            Putnicka vv = s.Get<Putnicka>(idd);
            s.Close();

            VozilaIzmeni vForm = new VozilaIzmeni(vv.IdVozila);
            if(vForm.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                PopulateInfos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Molimo Vas odaberite vozilo!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ISession s = DataLayer.GetSession();
            Putnicka p = s.Get<Putnicka>(id);
            s.Delete(p);
            s.Flush();
            s.Close();
            PopulateInfos();
        }

        private void VozilaInfo_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
            listView1.Columns[0].Width = 0;
        }
    }
}
