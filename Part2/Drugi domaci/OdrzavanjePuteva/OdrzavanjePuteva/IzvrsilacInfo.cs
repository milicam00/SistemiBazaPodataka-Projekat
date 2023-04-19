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
    public partial class IzvrsilacInfo : Form
    {
        public int IzvrsilacId { get; set; }
        public IzvrsilacInfo()
        {
            InitializeComponent();
        }
        public IzvrsilacInfo(int Id)
        {
            this.IzvrsilacId = Id;
            InitializeComponent();
        }


        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<IzvrsilacPregled> izvr = DTOManager.GetIzvrsiociInfo();
            foreach(IzvrsilacPregled iz in izvr)
            {
                ListViewItem item = new ListViewItem(new string[] { iz.IdRadnika.ToString(), iz.GodinaRodjenja, iz.Adresa, iz.Jmbg, iz.Ime, iz.Prezime });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IzvrsilacDodaj izvr = new IzvrsilacDodaj();
            if (izvr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PopulateInfos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Molimo Vas odaberite izvrsioca!");
                return;
            }
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            IzvrsilacBasic izvrsilac = DTOManager.GetIzvrsilacBasic(id);
            /// IzvrsilacIzmeni izmeni = new IzvrsilacIzmeni(izvrsilac);
            IzvrsilacIzmeni izm = new IzvrsilacIzmeni(izvrsilac);
            if(izm.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                DTOManager.UpdateIzvrsilacBasic(izm.izvrsilacBasic);
                PopulateInfos();
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Molimo Vas odaberite izvrsioca!");
                return;
            }
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.DeleteIzvrsilacPregled(id);
            PopulateInfos();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IzvrsilacInfo_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
            listView1.Columns[0].Width = 0;
        }
    }
}
