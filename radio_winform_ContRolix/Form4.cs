using System;
using System.Windows.Forms;

namespace radio_winform_ContRolix
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void igengomb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nemgomb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }
    }
}
