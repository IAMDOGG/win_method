using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayresult();  
        }

        public void displayresult() {
            int width = Convert.ToInt32(txtWidth.Text);
            int length = Convert.ToInt32(txtLength.Text);

            lblPerimeter.Text = CalculatePerimeter(width, length).ToString();
            lblArea.Text = CalculateArea(width, length).ToString();


        }
       static int CalculatePerimeter(int w, int l)
        {
            return (w + l) * 2;
        }

        static int CalculateArea(int wid, int len)
        {
            return wid * len;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
