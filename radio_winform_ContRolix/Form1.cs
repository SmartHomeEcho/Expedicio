using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace radio_winform_ContRolix
{
    public partial class Form1 : Form
    {
        static List<uzenet> adatok = new List<uzenet>();
        public Form1()
        {
           
            Thread t = new Thread(new ThreadStart(Kedzokepernyo));
            t.Start();
            Thread.Sleep(3000);
            t.Abort();
            Thread f = new Thread(new ThreadStart(Fokepernyo));
            
            InitializeComponent();
            StreamReader olvas = new StreamReader("veetel.txt");
            while (!olvas.EndOfStream)
            {
                adatok.Add(new uzenet(olvas.ReadLine(), olvas.ReadLine()));
            }
            olvas.Close();
            
            panel3.Visible = true;
            feladat2panel.Visible = false;
            feladat3panel.Visible = false;
            feladat4panel.Visible = false;

        }

        public void Kedzokepernyo() => Application.Run(mainForm: new Form2());
        public void Fokepernyo() => Application.Run(mainForm: new Form1());

        private void menu_Click(object sender, EventArgs e)
        {
            if (oldalsopanel.Width == 40)
            {
                oldalsopanel.Visible = false;
                oldalsopanel.Width = 260;
                Panelanimator.ShowSync(oldalsopanel);
                Logoanimator.ShowSync(logo);
            }
            else
            {
                Logoanimator.Hide(logo);
                oldalsopanel.Visible = false;
                oldalsopanel.Width = 40;
                Panelanimator.ShowSync(oldalsopanel);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Visible = true;
            a.BringToFront();

        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Icon.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            feladat2panel.Visible = true;
            feladat3panel.Visible = false;
            feladat4panel.Visible = false;
            feladat5panel.Visible = false;
            feladat7panel.Visible = false;
            feladat2moelso.Text = "Az első üzenet rögzítője: " + adatok[0].radioamatorszama;
            feladat2moutolso.Text = "Az utolsó üzenet rögzítője: " + adatok[adatok.Count - 1].radioamatorszama;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            feladat2panel.Visible = true;
            feladat3listbox.Items.Clear();
            feladat3panel.Visible = true;
            feladat4panel.Visible = false;
            feladat5panel.Visible = false;
            feladat7panel.Visible = false;
            int keresettindex = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].Szoveg.Contains("farkas"))
                {

                    keresettindex = i;
                    feladat3listbox.Items.Add($"{adatok[keresettindex].nap} nap,{adatok[keresettindex].radioamatorszama}rádióamatőr");

                }
            }

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            feladat4listbox.Items.Clear();
            feladat4panel.Visible = true;
            feladat2panel.Visible = true;
            feladat3panel.Visible = true;
            feladat5panel.Visible = false;
            feladat7panel.Visible = false;




            int[] napok = new int[12];

            for (int i = 0; i < 12; i++)
            {
                napok[i] = 0;

            }
            foreach (uzenet x in adatok)
            {
                napok[x.nap]++;
            }

            for (int i = 1; i < 12; i++)
            {
                feladat4listbox.Items.Add($"{i}. nap: {napok[i]} rádióamatőr");


            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            feladat2panel.Visible = true;
            feladat3panel.Visible = true;
            feladat4panel.Visible = true;
            feladat5panel.Visible = true;
            feladat7panel.Visible = false;

            char[][] adas = new char[12][];
            for (int i = 1; i < 12; i++)
            {
                adas[i] = new char[90];
                for (int j = 0; j < 90; j++)
                {
                    adas[i][j] = '#';
                }
            }
            foreach (uzenet u in adatok)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (u.Szoveg[i] != '#')
                    {
                        adas[u.nap][i] = u.Szoveg[i];
                    }
                }
            }
            try
            {

                StreamWriter iro = new StreamWriter("adaas.txt");
                for (int i = 1; i < 12; i++)
                {
                    for (int j = 0; j < 90; j++)
                    {
                        iro.Write(adas[i][j]);
                    }
                    iro.WriteLine();
                }
                iro.Close();
                Form3 a = new Form3();
                a.Visible = true;
                a.BringToFront();
                a.form3label1.Text = "Az aadas.txt fájl írása sikerült";

            }
            catch (Exception)
            {
                Form3 a = new Form3();
                a.Visible = true;
                a.BringToFront();
                a.form3label1.Text = "Az aadas.txt fájl írása nem sikerült";

            }

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            feladat2panel.Visible = true;
            feladat3panel.Visible = true;
            feladat4panel.Visible = true;
            feladat5panel.Visible = true;
            feladat7panel.Visible = true;
            feladat7molabel.Text = "";



        }
        private void Kereses_Click(object sender, EventArgs e)
        {


            bool VanEFeljegyzes = false;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].radioamatorszama == Convert.ToInt32(amatorinfo.Text != null) && adatok[i].nap == Convert.ToInt32(napinfo.Text != null) && adatok[i].Szoveg.Contains("/"))
                {
                    VanEFeljegyzes = true;
                    string info = adatok[i].Szoveg.Substring(0, 4);
                    if (info.Contains("#"))
                    {
                        feladat7molabel.Text = "Nincs információ";

                    }
                    else
                    {
                        info = info.Trim();
                        string[] farkasok = info.Split('/');
                        feladat7molabel.Text = "A megfigyelt egyedek száma: " + (Convert.ToInt32(farkasok[0]) + Convert.ToInt32(farkasok[1]));
                    }
                }

            }
            if (VanEFeljegyzes == false)
            {
                feladat7molabel.Text = "Nincs ilyen feljegyzés, vagy nem adtál meg egy értéket";
            }
        }

        private void ujranagyitas(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            Icon.Visible = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double Beallitas = trackBar1.Value;
            this.Opacity = Math.Round((Beallitas / 100), 2);
        }
    }
    class uzenet
    {
        public int nap { get; set; }
        public int radioamatorszama { get; set; }
        public string Szoveg { get; set; }

        public uzenet(string sor1, string sor2)
        {
            string[] adatok = sor1.Split(' ');
            nap = Convert.ToInt32(adatok[0]);
            radioamatorszama = Convert.ToInt32(adatok[1]);
            Szoveg = sor2;
        }

        public int Farkasokszama()
        {
            int db = -1;
            string[] eszleles = Szoveg.Split(' ')[0].Split('/');
            if (eszleles.Length == 2 && szame(eszleles[0]) && szame(eszleles[1]))
            {
                db = Convert.ToInt32(eszleles[0]) + Convert.ToInt32(eszleles[1]);
            }
            return db;
        }
        private bool szame(string szo)
        {
            bool valasz = true;
            for (int i = 1; i < szo.Length; i++)
            {
                if (szo[i] < '0' || szo[i] > '9')
                {
                    valasz = false;
                }
            }
            return valasz;
        }



    }
}
