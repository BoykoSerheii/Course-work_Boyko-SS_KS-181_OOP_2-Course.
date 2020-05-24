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
    public partial class fEditing : Form
    {
        
        int x0 = 5;
        int y0=5;
        public bool flEd { get; set; }
        public int n { get; set; }
        Label[] lHRC;
        Label[] lHRA;
        Label[] lFC;
        Label[] lFA;
        Label[,] LHRC;
        Label[,] LHRA;
        Label[,] LFC;
        Label[,] LFA;




        public List<HRD> listHRC { get; set; }
        public List<HRD> listHRA { get; set; }
        public List<HRD> listFC { get; set; }
        public List<HRD> listFA { get; set; }

        

        public fEditing()
        {
            InitializeComponent();

            listHRC = new List<HRD>();
            listHRA = new List<HRD>();
            listFC = new List<HRD>();
            listFA = new List<HRD>();
            flEd = false;
        }
        

        private void fEditing_Shown(object sender, EventArgs e)
        {
            
            LabelLocation(lHRC);
            LabelLocation(LHRC,lHRC[0].Location.X,lHRC[0].Location.Y+lHRC[0].Height,listHRC);

            LabelLocation(lHRA);
            LabelLocation(LHRA, lHRA[0].Location.X, lHRA[0].Location.Y + lHRA[0].Height,listHRA);

            LabelLocation(lFC);
            LabelLocation(LFC, lFC[0].Location.X, lFC[0].Location.Y + lFC[0].Height, listFC);

            LabelLocation(lFA);
            LabelLocation(LFA, lFA[0].Location.X, lFA[0].Location.Y + lFA[0].Height, listFA);
        }

        private void fEditing_Load(object sender, EventArgs e)
        {
            ReadFile(listHRC, Application.StartupPath + "\\DBHRC\\" + "HRC.txt",1);
            TableBuilding(ref lHRC, tabHRC, Application.StartupPath + "\\DBHRC\\" + "HRC_Ch.txt");
            ListBuilding(ref LHRC, lHRC, tabHRC, listHRC.Count);

            ReadFile(listHRA, Application.StartupPath + "\\DBHRA\\" + "HRA.txt",2);
            TableBuilding(ref lHRA, tabHRA, Application.StartupPath + "\\DBHRA\\" + "HRA_Ch.txt");
            ListBuilding(ref LHRA, lHRA, tabHRA, listHRA.Count);

            ReadFile(listFC, Application.StartupPath + "\\DBFC\\" + "FC.txt", 3);
            TableBuilding(ref lFC, tabFC, Application.StartupPath + "\\DBFC\\" + "FC_Ch.txt");
            ListBuilding(ref LFC, lFC, tabFC, listFC.Count);

            ReadFile(listFA, Application.StartupPath + "\\DBFA\\" + "FA.txt", 4);
            TableBuilding(ref lFA, tabFA, Application.StartupPath + "\\DBFA\\" + "FA_Ch.txt");
            ListBuilding(ref LFA, lFA, tabFA, listFA.Count);
            
        }

        void ReadFile(List<HRD> list,string fileName,int k)
        {
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr = new StreamReader(fileName, enc);
            while (!sr.EndOfStream)
            {
                string s=sr.ReadLine();
                if(s=="") break;
                string[] mas = s.Split(new char[] { '*' });
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
        void TableBuilding(ref Label [] l,TabPage tab,string fileName)
        {
            List<string> strLab = new List<string>();
            strLab.Add("Нoмер  ** ");
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr = new StreamReader(fileName,enc);
            while (!sr.EndOfStream)
                strLab.Add(sr.ReadLine());
            sr.Close();
            for (int i = 0; i < strLab.Count; i++)
                        strLab[i] = strLab[i].Replace('*', '\n');
            int n = strLab.Count;
            l = new Label[n];
            for (int i = 0; i < n; i++)
            {
                l[i] = new Label();
                l[i].AutoSize = true;
                l[i].BorderStyle = BorderStyle.FixedSingle;
                l[i].Text = strLab[i];
            }
            tab.Controls.AddRange(l);   
        }
        void LabelLocation(Label[] l)
        {
            l[0].Location = new Point(x0, y0);
            for (int i = 1; i < l.Length; i++)
                l[i].Location = new Point(l[i - 1].Location.X + l[i - 1].Width, y0);          
        }
        void LabelLocation(Label[,] l, int x,int y,List<HRD> list)
        {
            if (list.Count == 0) return;
            int h = l[0, 0].Height;
            for (int i = 0; i < l.GetLength(0); i++)
            {
                l[i, 0].Text = Convert.ToString(i+1);
                l[i, 0].Location = new Point(x, y+i*h);
                l[i,0].MouseDown+=new MouseEventHandler(Label_MouseDown);
                l[i, 0].Tag = i;
                List<string> rez = list[i].HRDChar();
                for (int j = 1; j <l.GetLength(1); j++)
                {
                    l[i, j].Text = rez[j - 1];
                    l[i, j].Location = new Point(l[i, j - 1].Location.X + l[i, j - 1].Width, y + i * h);
                }
            }
        }
        void ListBuilding(ref Label [,] l, Label [] lM,TabPage tab, int n)
        {
            int m = lM.Length;
            if(n==0)
                return;
            l = new Label[n,m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    l[i, j] = new Label();
                    l[i, j].Width = lM[j].Width;
                    l[i, j].BorderStyle = BorderStyle.FixedSingle;
                    tab.Controls.Add(l[i, j]);
                }
        }

  
        private void tabHRC_Click(object sender, EventArgs e)
        {
            flEd = false;
            if (ShowFHD("tabHRC") == DialogResult.OK)
            {
                AddLabel(LHRC, tabHRC);
                ListBuilding(ref LHRC, lHRC, tabHRC, listHRC.Count);
                LabelLocation(LHRC, lHRC[0].Location.X, lHRC[0].Location.Y + lHRC[0].Height, listHRC);
            }
           
        }

        void AddLabel(Label[,] l, TabPage tab)
        {
            if (l == null) return;
             for (int i = 0; i < l.GetLength(0); i++)
                   for (int j = 0; j <l.GetLength(1); j++)
                       tab.Controls.Remove(l[i, j]);
        }

        private void tabHRA_Click(object sender, EventArgs e)
        {
            flEd = false;
            if (ShowFHD("tabHRA") == DialogResult.OK)
            {
                AddLabel(LHRA, tabHRA);
                ListBuilding(ref LHRA, lHRA, tabHRA, listHRA.Count);
                LabelLocation(LHRA, lHRA[0].Location.X, lHRA[0].Location.Y + lHRA[0].Height, listHRA);
            }
        }

        private void tabFC_Click(object sender, EventArgs e)
        {
            flEd = false;
            if (ShowFHD("tabFC") == DialogResult.OK)
            {
                AddLabel(LFC, tabFC);
                ListBuilding(ref LFC, lFC, tabFC, listFC.Count);
                LabelLocation(LFC, lFC[0].Location.X, lFC[0].Location.Y + lFC[0].Height, listFC);
            }
        }

        private void tabFA_Click(object sender, EventArgs e)
        {
            flEd = false;
            if (ShowFHD("tabFA") == DialogResult.OK)
            {
                AddLabel(LFA, tabFA);
                ListBuilding(ref LFA, lFA, tabFA, listFA.Count);
                LabelLocation(LFA, lFA[0].Location.X, lFA[0].Location.Y + lFA[0].Height, listFA);
            }
        }

        DialogResult ShowFHD(string s)
        {
            fHRD f = new fHRD();
            f.Tag = s;
            f.Owner = this;
            return f.ShowDialog();
        }

        private void fEditing_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveFile(listHRC, Application.StartupPath + "\\DBHRC\\" + "HRC.txt");
            SaveFile(listHRA, Application.StartupPath + "\\DBHRA\\" + "HRA.txt");
            SaveFile(listFC, Application.StartupPath + "\\DBFC\\" + "FC.txt");
            SaveFile(listFA, Application.StartupPath + "\\DBFA\\" + "FA.txt");
        }
        void SaveFile(List<HRD> list, string fileName)
        {
            Encoding enc = Encoding.GetEncoding(1251);
            StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), enc);
            for (int i = 0; i < list.Count; i++)
                sw.WriteLine(list[i].FileInfo());
            sw.Close();
        }
        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Right)
            {
                if (MessageBox.Show("Хочете видалити запис?", "Запит", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                Label l=sender as Label;
                int k = Convert.ToInt32(l.Tag);
                if (l.Parent == tabHRC)
                    DeleteLabel(k, tabHRC, listHRC, lHRC, ref LHRC);
                if (l.Parent == tabHRA)
                    DeleteLabel(k, tabHRA, listHRA, lHRA, ref LHRA);
                if (l.Parent == tabFC)
                    DeleteLabel(k, tabFC, listFC, lFC, ref LFC);
                if (l.Parent == tabFA)
                    DeleteLabel(k, tabFA, listFA, lFA, ref LFA);
            }

            if (e.Button == MouseButtons.Left)
            {
                if (MessageBox.Show("Хочете редагувати запис?", "Запит", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                Label l = sender as Label;
                n = Convert.ToInt32(l.Tag);
                flEd = true;
                if (l.Parent == tabHRC)
                    if (ShowFHD("tabHRC") == DialogResult.OK)
                        EdingLabel(LHRC, listHRC, n);
                if (l.Parent == tabHRA)
                    if (ShowFHD("tabHRA") == DialogResult.OK)
                        EdingLabel(LHRA, listHRA, n);
                if (l.Parent == tabFC)
                    if (ShowFHD("tabFC") == DialogResult.OK)
                        EdingLabel(LFC, listFC, n);
                if (l.Parent == tabFA)
                    if (ShowFHD("tabFA") == DialogResult.OK)
                        EdingLabel(LFA, listFA, n);
            }
        }
        void DeleteLabel(int k, TabPage tab, List<HRD> list, Label[] L1D,ref Label[,] L2D)
        {
            list.RemoveAt(k);
            AddLabel(L2D, tab);
            ListBuilding(ref L2D, L1D, tab, list.Count);
            LabelLocation(L2D, L1D[0].Location.X, L1D[0].Location.Y + L1D[0].Height, list);
        }
        void EdingLabel(Label[,] L2D, List<HRD> list,int n)
        {
            List<string> rez = list[n].HRDChar();
            for (int j = 1; j < L2D.GetLength(1); j++)
                L2D[n, j].Text = rez[j - 1];
        }
    }
}
