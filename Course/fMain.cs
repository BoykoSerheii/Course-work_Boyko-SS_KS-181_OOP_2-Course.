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
    public partial class fMain : Form
    {


        public fMain()
        {
            InitializeComponent();

        }
        private void lFind_Click(object sender, EventArgs e)
        {
            try
            {
                fFind f = new fFind();
                f.Owner = this;
                f.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Щось пішло не так :(");
            }
        }

        private void lEditing_Click(object sender, EventArgs e)
        {
            try
            {
                fIdentification fI = new fIdentification();
                if (fI.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Помилка пароля!");
                    return;
                }
                fEditing fE = new fEditing();
                fE.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Щось пішло не так :(");
            }

        }

       

     
       
    }
}
