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
    public partial class SpoljniSaradnikInfo : Form
    {
        public SpoljniSaradnikInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpoljniSaradnikDodaj ss = new SpoljniSaradnikDodaj();
            ss.ShowDialog();
            PopulateInfos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo Vas odaberite spoljnog saradnika!");
                return;
            }
            int Id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            SpoljniSaradnikIzmeni si = new SpoljniSaradnikIzmeni(Id);
            si.ShowDialog();
            if (si.DialogResult == DialogResult.OK)
                PopulateInfos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo Vas odaberite izvrsioca!");
                return;
            }

            int idd = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            SpoljniSaradnikPregled ss = DTOManager.GetSpoljniSaradnik(idd);

            DTOManager.DeleteSpoljniSaradnikPregled(ss);
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<SpoljniSaradnikPregled> saradnici = DTOManager.GetSpoljniSaradniciInfo();
            foreach (SpoljniSaradnikPregled op in saradnici)
            {
                ListViewItem item = new ListViewItem(new string[] { op.IdSpoljnogSaradnika.ToString(), op.BrUgovoraODelu.ToString() });

                listView1.Items.Add(item);
                listView1.Refresh();
            }
            listView1.Refresh();
        }

        private void SpoljniSaradnikInfo_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
            listView1.Columns[0].Width = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
