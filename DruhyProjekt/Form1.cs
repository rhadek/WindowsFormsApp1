using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DruhyProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo1 = Convert.ToInt32(textBox1.Text);
            int cislo2 = Convert.ToInt32(textBox2.Text);
            int an = cislo1; ;
            for (int i = 1;i < cislo2; i++)
            {
                an *= cislo1;
            }
            label1.Text = (an).ToString();
        }
    }
}
