using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zonk
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
