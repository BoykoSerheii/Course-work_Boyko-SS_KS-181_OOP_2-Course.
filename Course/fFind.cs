using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Course
{
    public partial class fFind : Form
    {
        public List<HRD> listHRC { get; set; }
        public List<HRD> listHRA { get; set; }
        public List<HRD> listFC { get; set; }
        public List<HRD> listFA { get; set; }

        int lx = 350;
        int ly = 380;

       
        int x0 = 5;
        int y0 = 0;
        int kx = 0, ky = 0;
        int x = 0, y = 0;
        int m;  

            public bool In(Point Pos,HRD hrd)
            {
                if (rBPriseM.Checked)
                    if (hrd.Prise > 15000)
                        return false;
                if (rBPriseB.Checked)
                    if (hrd.Prise < 15000)
                        return false;
                if (rBMM.Checked)
                    if (hrd.Weight > 50)
                        return false;
                if (rBMB.Checked)
                    if (hrd.Weight < 50)
                        return false;
                if (rBFLV.Checked)
                    if (hrd.dimensions.c > 150)
                        return false;
                if (rBFLN.Checked)
                    if (hrd.dimensions.c < 150)
                        return false;
                int x0 = 5;
                int y0 = 5;
                Panel p = new Panel();
                Label lR = new Label();
                p.Location = Pos;
                p.Font = new Font("Segoe Print", 12);
                lR.Location = new Point(x0,y0);
                lR.ForeColor = Color.Black;
                lR.Text = hrd.Info();
                lR.Size = new Size(lx, ly);
                p.Controls.Add(lR);
                p.AutoSize = true;
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Tag = "P";
                Controls.Add(p);
                listPanel.Add(p);
                return true;
            }
        
        
        fMain myOwner;
        List<Point> listLocation = new List<Point>();
        public List<Panel> listPanel = new List<Panel>();
        public fFind()
        {
            InitializeComponent();
            m = Controls.Count;
            y0 = cBFind.Location.Y + label1.Height + 5;
            x0 = gBFL.Location.X + gBFL.Width + 5;
            listHRC = new List<HRD>();
            listHRA = new List<HRD>();
            listFC = new List<HRD>();
            listFA = new List<HRD>();
        }

        private void fFind_Load(object sender, EventArgs e)
        {
            myOwner = Owner as fMain;
            ReadFile(listHRC, Application.StartupPath + "\\DBHRC\\" + "HRC.txt", 1);
            ReadFile(listHRA, Application.StartupPath + "\\DBHRA\\" + "HRA.txt", 2);
            ReadFile(listFC, Application.StartupPath + "\\DBFC\\" + "FC.txt", 3);
            ReadFile(listFA, Application.StartupPath + "\\DBFA\\" + "FA.txt", 4);   
            cBFind.SelectedIndex = 0;
        }

        void LocationList(List<HRD> list)
        {
            for (int i = 0; i <list.Count; i++)
            {
                if (x + 2 * lx > this.ClientSize.Width)
                {
                    kx = 0;
                    ky++;

                }
                x = x0 + kx * (lx + 15);
                y = y0 + ky * (ly + 15);      
                if(In(new Point(x, y), list[i]))
                kx++;
            }
        }
        

        private void cBFind_TextChanged(object sender, EventArgs e)
        {
            kx = 0; ky = 0;
            x = 0; y = 0;
            for (int i = this.Controls.Count-1; i >= m; i--)
                Controls.RemoveAt(i);
            if (cBFind.SelectedIndex == 0)
            {
                LocationList(listHRC);
                LocationList(listHRA);
                LocationList(listFC);
                LocationList(listFA);
            }
            if (cBFind.SelectedIndex == 1)
            {
                LocationList(listHRC);
                LocationList(listHRA);
            }
            if (cBFind.SelectedIndex == 2)
            {
                LocationList(listFC);
                LocationList(listFA);
            }
            if (cBFind.SelectedIndex == 3)
                LocationList(listHRC);
            if (cBFind.SelectedIndex == 4)
                LocationList(listHRA);
            
            if (cBFind.SelectedIndex == 5)
                LocationList(listFC);
            if (cBFind.SelectedIndex == 6)
                LocationList(listFA);
        }
        void ReadFile(List<HRD> list, string fileName, int k)
        {
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr = new StreamReader(fileName, enc);
            while (!sr.EndOfStream)
            {
                string[] mas = sr.ReadLine().Split(new char[] { '*' });
                switch (k)
                {
                    case 1: list.Add(new HRC(mas));
                        break;
                    case 2: list.Add(new HRA(mas));
                        break;
                    case 3: list.Add(new FC(mas));
                        break;
                    case 4: list.Add(new FA(mas));
                        break;
                }
            }
            sr.Close();
        }

        private void bEsc_Click(object sender, EventArgs e)
        {
            rBFLN.Checked = false;
            rBFLV.Checked = false;
            rBMB.Checked = false;
            rBMM.Checked = false;
            rBPriseB.Checked = false;
            rBPriseM.Checked = false;
            cBFind_TextChanged(sender, new EventArgs());
        }

        

       

       

    }
}
