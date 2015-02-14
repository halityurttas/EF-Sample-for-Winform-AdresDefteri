using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdresDefteri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DAL.telefonlar tlf = new DAL.telefonlar();
            tlf.AdiSoyadi = this.txtAdiSoyadi.Text;
            tlf.Telefon = this.txtTelefon.Text;
            tlf.GSM = this.txtGSM.Text;
            DAL.DatalarEntities de = new DAL.DatalarEntities();
            de.telefonlar.Add(tlf);
            de.SaveChanges();
            this.Close();
        }
    }
}
