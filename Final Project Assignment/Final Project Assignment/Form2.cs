using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Assignment
{
    public partial class Form2 : Form
    {
        double count, count1, count2, count3, count4, count5, count6, sum, sum1, sum2, sum3, sum4, sum5, sum6, sum7, sumn, sumf, sumper, sumall;

        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(1.39);
            comboBox1.Items.Add(2.39);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(comboBox1.Text);
            count = double.Parse(textBox1.Text);
            if (count > 15)
            {
                count1 = count - 15;
                sum = 15 * 1.8632;
            }
            else
            {
                sum = count * 1.8632;
            }
            if (count1 > 10)
            {
                count2 = count1 - 10;
                sum1 = 10 * 2.5026;
            }
            else
            {
                sum1 = count1 * 2.5026;
            }
            if (count2 > 10)
            {
                count3 = count2 - 10;
                sum2 = 10 * 2.7549;
            }
            else
            {
                sum2 = count2 * 2.7549;
            }
            if (count3 >= 65)
            {
                count4 = count3 - 65;
                sum3 = 65 * 3.1381;
            }
            else
            {
                sum3 = count3 * 3.1381;
            }
            if (count4 >= 50)
            {
                count5 = count4 - 50;
                sum4 = 50 * 3.2315;
            }
            else
            {
                sum4 = count4 * 3.2315;
            }
            if (count5 >= 150)
            {
                count6 = count5 - 150;
                sum5 = 150 * 3.7362;
            }
            else
            {
                sum5 = count5 * 3.7362;
            }
            if (count6 >= 400)
            {
                sum6 = count6 = 3.9361;
            }
            sum7 = sum + sum1 + sum2 + sum3 + sum4 + sum5 + sum6;
            sumn = sum7 + 8.19;
            sumf = count * a;
            sumper = (sum + sumf) * 7 / 100;
            sumall = sumn + sumf + sumper;
            textBox3.Text = sumn.ToString("#,###.00");
            textBox4.Text = sumf.ToString("#,###.00");
            textBox5.Text = sumper.ToString("#,###.00");
            textBox6.Text = sumall.ToString("#,###.00");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("คุณไม่ได้กรอกข้อมูล", "คำเตือน");
                    textBox1.Focus();
                }
                else
                {
                    comboBox1.Focus();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Text = "";
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Focus();
        }
    }

}
