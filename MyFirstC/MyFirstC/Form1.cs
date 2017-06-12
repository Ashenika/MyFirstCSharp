using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtans.Text = txtans.Text + one.Text;
        }

        

        private void two_Click(object sender, EventArgs e)
        {
            txtans.Text = txtans.Text + two.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            txtans.Text = txtans.Text + three.Text;
        }

        private void four_Click(object sender, EventArgs e)
        {
            txtans.Text = txtans.Text + four.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtans.Text = txtans.Text + five.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            txtans.Text = txtans.Text + six.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            txtans.Text = txtans.Text + seven.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            txtans.Text = txtans.Text + eight.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            txtans.Text = txtans.Text + nine.Text;
        }

        private void zone_Click(object sender, EventArgs e)
        {
            txtans.Text = txtans.Text + zero.Text;
        }

        double total1 = 0;
        double total2 = 0;

        private void dou_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            total2 = total1 + double.Parse(txtans.Text);
            txtans.Text = total2.ToString();
            total1 = 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtans.Text);
            txtans.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtans.Clear();
        }

        private void txtans_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
