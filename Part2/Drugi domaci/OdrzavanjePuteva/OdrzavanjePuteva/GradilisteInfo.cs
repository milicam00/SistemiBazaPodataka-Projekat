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
    public partial class GradilisteInfo : Form
    {
        public int GradilisteId { get; set; }
        public GradilisteInfo()
        {
            InitializeComponent();
        }

        public GradilisteInfo(int id)
        {
            this.GradilisteId = id;
            InitializeComponent();
        }

        public void PopulateInfos()
        {
            listView1.Items.Clear();
            List<GradilistePregled> gradilista = DTOManager.GetGradilisteInfo();
            foreach(GradilistePregled gp in gradilista)
            {
                ListViewItem item = new ListViewItem(new string[] { gp.IdGradilista.ToString(), gp.Tip.ToString() });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GradilisteDodaj gradiliste = new GradilisteDodaj();
            if (gradiliste.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PopulateInfos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Molimo Vas odaberite gradiliste!");
                return;
            }
            int gradId = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            GradilisteBasic gb = DTOManager.GetGradilisteBasic(gradId);
            GradilisteIzmeni gForm = new GradilisteIzmeni(gb);
            if(gForm.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                DTOManager.UpdateGradilisteBasic(gForm.gradBasic);
                PopulateInfos();
            }
        }

        private void GradilisteInfo_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
            listView1.Columns[0].Width = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Molimo Vas odaberite!");
                return;
            }
            int idd = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.DeleteGradiliste(idd);
            PopulateInfos();
        }
    }
}
