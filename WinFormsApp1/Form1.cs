using WndPL;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarkalar frmMarka = new FrmMarkalar();
            frmMarka.ShowDialog();
        }

        private void arabalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArabalar frmAraba = new FrmArabalar();
            frmAraba.ShowDialog();
        }
    }
}