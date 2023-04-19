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
    public partial class DeonicaInfo : Form
    {

        public int DeonicaId { get; set; }
        public DeonicaInfo()
        {
            InitializeComponent();
        }

        public DeonicaInfo(int idd)
        {
            this.DeonicaId = idd;
            InitializeComponent();
        }

        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<DeonicaPregled> deonice = DTOManager.GetDeonicaInfo();
            foreach(DeonicaPregled deo in deonice)
            {
                ListViewItem item = new ListViewItem(new string[] { deo.IdDeonice.ToString(), deo.OdKilometra.ToString(), deo.DoKilometra.ToString() });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DeonicaDodaj deonica = new DeonicaDodaj();
            if (deonica.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PopulateInfos();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo Vas odaberite deonicu!");
                return;
            }
            int idD = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Deonica deonica = DTOManager.GetDeonica(idD);
           
            
            DeonicaIzmeni dizmForm = new DeonicaIzmeni(deonica);
            if (dizmForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PopulateInfos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Molimo Vas odaberite deonicu!");
                return;
            }

            int idDeo = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            ISession s = DataLayer.GetSession();

            Deonica deo = s.Get<Deonica>(idDeo);
            s.Delete(deo);
            s.Flush();
            s.Close();
            this.PopulateInfos();
        }

        private void DeonicaInfo_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
            listView1.Columns[0].Width = 0;
        }
    }
}
