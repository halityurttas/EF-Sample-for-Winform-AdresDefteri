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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DAL.DatalarEntities context = new DAL.DatalarEntities();
            var enuTelefonlar = from t in context.telefonlar
                                select t;
            this.dataGridView1.DataSource = enuTelefonlar.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            Form1_Load(sender, e);
        }
    }
}
