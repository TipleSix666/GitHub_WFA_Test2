using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub_WFA_Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentYear = int.Parse(textBox1.Text);
            int birthYear = int.Parse(textBox2.Text);
            MessageBox.Show($"Your age: {currentYear - birthYear}");
        }
    }
}
