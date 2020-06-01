using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zonk
{
    public partial class WinForm : Form
    {
        
        public WinForm()
        {
            InitializeComponent();
        }

        private void btn_Again_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WinForm_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("..\\..\\points.txt");
            lb_score.Text = "Ваш счет: " + sr.ReadLine();
        }
    }
}
