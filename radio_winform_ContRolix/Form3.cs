using System;
using System.Windows.Forms;

namespace radio_winform_ContRolix
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_kesleltetes.Start();
            iconform3.Enabled = true;
        }

        private void icon_kesleltetes_Tick(object sender, EventArgs e)
        {
            iconform3.Enabled = false;
            icon_kesleltetes.Stop();
        }
        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
