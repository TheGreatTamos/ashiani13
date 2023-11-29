using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penisSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("خطا: لطفا طول عسگرتان را وارد نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float size = Convert.ToInt32(textBox1.Text);

                if (size >= 13 && size < 189)
                {
                    string tolAsgarBeAshiani = (size / 13).ToString();
                    MessageBox.Show("طول عسگر شما برابر است با: " + tolAsgarBeAshiani + "آشیانی", "نتیجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (size < 13)
                {
                    MessageBox.Show("خطا: عسگر شما بسیار کوچک است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("خطا: عسگر شما بسیار بزرگ است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
