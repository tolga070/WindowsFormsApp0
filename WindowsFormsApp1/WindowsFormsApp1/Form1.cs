using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int x = 278, y=317;
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.SetBounds(x= x-10, y, 82, 73);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.SetBounds(x = x+10, y, 82, 73);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

    }
}
