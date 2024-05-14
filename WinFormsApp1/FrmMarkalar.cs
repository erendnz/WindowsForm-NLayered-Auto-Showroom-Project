using BLL;
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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        GaleriBLL bll = new GaleriBLL();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.Markalar.Tumu().ToList();
        }
    }
}
