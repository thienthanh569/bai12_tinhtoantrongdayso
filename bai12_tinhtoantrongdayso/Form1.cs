using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai12_tinhtoantrongdayso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(txtMin.Text);
            int max = Convert.ToInt32(txtMax.Text);
            int chan = 0; int le = 0;

            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {


                    chan += i;
                }
                else
                {
                    le += i;

                }

            }
        }

    }
}
