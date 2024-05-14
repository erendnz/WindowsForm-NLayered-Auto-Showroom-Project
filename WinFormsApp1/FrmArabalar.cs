using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndPL
{
    public partial class FrmArabalar : Form
    {
        public FrmArabalar()
        {
            InitializeComponent();
        }
        GaleriBLL bll = new GaleriBLL();
        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void FrmArabalar_Load(object sender, EventArgs e)
        {
            MarkalariDoldur();
            ModelleriDoldur(((Marka)comboBox1.Items[0]).MarkaID);
        }

        private void MarkalariDoldur()
        {
            comboBox1.DataSource = bll.Markalar.Tumu().ToList();
            comboBox1.DisplayMember = "MarkaAdi";
            comboBox1.ValueMember = "MarkaID";
        }

        private void ModelleriDoldur(int id)
        {

            comboBox2.DataSource = bll.Modeller.Tumu(x => x.MarkaID == id).ToList();
            comboBox2.DisplayMember = "ModelAdi";
            comboBox2.ValueMember = "ModelID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //ModelleriDoldur(11);
        }

    

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ModelleriDoldur(int.Parse(comboBox1.SelectedValue.ToString()));
        }
    }
}
