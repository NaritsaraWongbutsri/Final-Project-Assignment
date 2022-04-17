namespace electricity_bill_calculation
{
    public partial class Form1 : Form
    {
        int b2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "pea" || textBox2.Text != "1234")
            {
                MessageBox.Show("User ??? Password ???!!!", "???????????");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                b2++;
                if (b2 == 3)
                {
                    MessageBox.Show("User ??? Password ???!!! ???? 3 ???????????????????????", "??????????????? 3 ?????");
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                Form2 f2 = new Form2();
            }
        }
    }

    internal class Form2
    {
        public Form2()
        {
        }
    }
}