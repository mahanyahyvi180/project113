using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int x;
        private void button1_Click(object sender, EventArgs e)
        {
            if (true && Convert.ToBoolean(x++))
                label1.Text = x.ToString();
        }
    }
}
