using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Course
{
    public partial class fHRD : Form
    {
        public fHRD()
        {
            InitializeComponent();
        }

        private void fHRD_Load(object sender, EventArgs e)
        {        
            nUpKoef.Increment=Convert.ToDecimal(0.01);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tBCountry.Text == "" || tBTitle.Text == "" || cBColor.Text == "")
            {
                DialogResult = DialogResult.None;
                return;
            }
            if (Convert.ToString(Tag) == "tabHRC" && cBLF.Text == "")
            {
                DialogResult = DialogResult.None;
                return;
            }
            if (Convert.ToString(Tag) == "tabHRA" && (cBLF.Text == "" || cBTE.Text == ""))
            {
                DialogResult = DialogResult.None;
                return;
            }
            if (Convert.ToString(Tag) == "tabFA" && cBMTE.Text == "")
            {
                DialogResult = DialogResult.None;
                return;
            }
            fEditing f = Owner as fEditing;
            Dimensions d = new Dimensions();
            d.a = Convert.ToInt32(nUpA.Value);
            d.b = Convert.ToInt32(nUpB.Value);
            d.c = Convert.ToInt32(nUpC.Value);
            if (Convert.ToString(Tag) == "tabHRC")
                f.listHRC.Add(new HRC(d, cBColor.Text, Convert.ToDouble(nUpM.Value),
                    Convert.ToInt32(nUpPrise.Value), tBCountry.Text, tBTitle.Text, Convert.ToDouble(nUpKoef.Value),
                    Convert.ToInt32(nUpCountCam.Value), Convert.ToInt32(nUpVF.Value), cBLF.Text, Convert.ToInt32(nUpContComp.Value)));
            if (Convert.ToString(Tag) == "tabHRA")
                f.listHRA.Add(new HRA(d, cBColor.Text, Convert.ToDouble(nUpM.Value),
                    Convert.ToInt32(nUpPrise.Value), tBCountry.Text, tBTitle.Text, Convert.ToDouble(nUpKoef.Value),
                    Convert.ToInt32(nUpCountCam.Value), Convert.ToInt32(nUpVF.Value), cBLF.Text, cBTE.Text));
            if (Convert.ToString(Tag) == "tabFC")
                f.listFC.Add(new FC(d, cBColor.Text, Convert.ToDouble(nUpM.Value),
                    Convert.ToInt32(nUpPrise.Value), tBCountry.Text, tBTitle.Text, Convert.ToDouble(nUpKoef.Value),
                    Convert.ToInt32(nUpNo.Value), Convert.ToInt32(nUpContComp.Value)));
            if (Convert.ToString(Tag) == "tabFA")
                f.listFA.Add(new FA(d, cBColor.Text, Convert.ToDouble(nUpM.Value),
                    Convert.ToInt32(nUpPrise.Value), tBCountry.Text, tBTitle.Text, Convert.ToDouble(nUpKoef.Value),
                    Convert.ToInt32(nUpCountCam.Value), cBMTE.Text));
        }

        private void fHRD_Shown(object sender, EventArgs e)
        {
            fEditing f = Owner as fEditing;
            if (Convert.ToString(Tag) == "tabHRC")
            {
                grBFr.Enabled = false;
                grBHRA.Enabled = false;
            }
            if (Convert.ToString(Tag) == "tabHRA")
            {
                grBFr.Enabled = false;
                grBHRC.Enabled = false;
            }
            if (Convert.ToString(Tag) == "tabFC")
            {
                grBHR.Enabled = false;
                grBFA.Enabled = false;
            }
            if (Convert.ToString(Tag) == "tabFA")
            {
                grBHR.Enabled = false;
                grBFC.Enabled = false;
            }
            bSave.Visible = !f.flEd;
            bChange.Visible = f.flEd;
            if (!f.flEd) return;
            if (Convert.ToString(Tag) == "tabHRC")
               ShowHRC(f.listHRC, f.n);
            if (Convert.ToString(Tag) == "tabHRA")
                ShowHRA(f.listHRA, f.n);
            if (Convert.ToString(Tag) == "tabFC")
                ShowFC(f.listFC, f.n);
            if (Convert.ToString(Tag) == "tabFA")
                ShowFA(f.listFA, f.n);
            

        }

        void ShowHRD(List <HRD> list,int k)
        {
            tBTitle.Text = list[k].title;
            cBColor.Text = list[k].color;
            nUpM.Value = Convert.ToDecimal(list[k].Weight);
            nUpA.Value = Convert.ToDecimal(list[k].dimensions.a);
            nUpB.Value = Convert.ToDecimal(list[k].dimensions.b);
            nUpC.Value = Convert.ToDecimal(list[k].dimensions.c);
            nUpPrise.Value = Convert.ToDecimal(list[k].Prise);
            tBCountry.Text = list[k].producingCountry;
            nUpKoef.Value = Convert.ToDecimal(list[k].Percent);
        }
        void ShowHR(List<HRD> list, int k)
        {
            nUpCountCam.Value = Convert.ToDecimal((list[k] as HR).NumberOfCameras);
            nUpVF.Value = Convert.ToDecimal((list[k] as HR).FreezerVolume);
            cBLF.Text = (list[k] as HR).freezerLocation;
        }
        void ShowHRC(List<HRD> list, int k)
        {
            ShowHRD(list, k);
            ShowHR(list, k);
            nUpContComp.Value = Convert.ToDecimal((list[k] as HRC).NumberOfCompressors);
        }
        void ShowHRA(List<HRD> list, int k)
        {
            ShowHRD(list, k);
            ShowHR(list, k);
            cBTE.Text = (list[k] as HRA).TypeOfEnergy;
        }
        void ShowF(List<HRD> list, int k)
        {
            nUpNo.Value = Convert.ToDecimal((list[k] as Freezer).NoiseLevel);
        }

        void ShowFC(List<HRD> list, int k)
        {
            ShowHRD(list, k);
            ShowF(list, k);
            nUpMCountCom.Value = Convert.ToDecimal((list[k] as FC).NumberOfCompressors);
        }
        void ShowFA(List<HRD> list, int k)
        {
            ShowHRD(list, k);
            ShowF(list, k);
            cBMTE.Text = (list[k] as FA).TypeOfEnergy;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            fEditing f = Owner as fEditing;
            if (Convert.ToString(Tag) == "tabHRC")
                EdHRC(f.listHRC, f.n);
            if (Convert.ToString(Tag) == "tabHRA")
                EdHRA(f.listHRA, f.n);
            if (Convert.ToString(Tag) == "tabFC")
                EdFC(f.listFC, f.n);
            if (Convert.ToString(Tag) == "tabFA")
                EdFA(f.listFA, f.n);
        }
        void EdHRD(List<HRD> list, int k)
        {
            list[k].title=tBTitle.Text;
            list[k].color=cBColor.Text;
            list[k].Weight = Convert.ToInt32(nUpM.Value);
            Dimensions d = new Dimensions();
            d.a = Convert.ToInt32(nUpA.Value);
            d.b = Convert.ToInt32(nUpB.Value);
            d.c = Convert.ToInt32(nUpC.Value);
            list[k].dimensions = d;
            list[k].Prise = Convert.ToInt32( nUpPrise.Value);
            list[k].producingCountry=tBCountry.Text;
            list[k].Percent = Convert.ToDouble(nUpKoef.Value);
        }
        void EdHR(List<HRD> list, int k)
        {
            (list[k] as HR).NumberOfCameras = Convert.ToInt32(nUpCountCam.Value);
            (list[k] as HR).FreezerVolume = Convert.ToInt32(nUpVF.Value);
            (list[k] as HR).freezerLocation=cBLF.Text;
        }
        void EdHRC(List<HRD> list, int k)
        {
            EdHRD(list, k);
            EdHR(list, k);
            (list[k] as HRC).NumberOfCompressors = Convert.ToInt32(nUpContComp.Value);
            
        }
        void EdHRA(List<HRD> list, int k)
        {
            EdHRD(list, k);
            EdHR(list, k);
           (list[k] as HRA).TypeOfEnergy= cBTE.Text;
        }
        void EdF(List<HRD> list, int k)
        {
            (list[k] as Freezer).NoiseLevel = Convert.ToInt32(nUpNo.Value);
         
        }

        void EdFC(List<HRD> list, int k)
        {
            EdHRD(list, k);
            EdF(list, k);
            (list[k] as FC).NumberOfCompressors=Convert.ToInt32(nUpMCountCom.Value);
        }
        void EdFA(List<HRD> list, int k)
        {
            EdHRD(list, k);
            EdF(list, k);
            (list[k] as FA).TypeOfEnergy=cBMTE.Text;
        }
       
    }
}
