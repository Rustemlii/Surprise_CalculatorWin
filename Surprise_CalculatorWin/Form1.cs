namespace Surprise_CalculatorWin
{
    public partial class Form1 : Form
    {
        decimal reqem1 = 0;
        char ope;
        decimal netice;


        public Form1()
        {
            InitializeComponent();
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "1";
        }

        private void buttonToplama_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                reqem1 = Convert.ToDecimal(textBox1.Text);//textbox-un icerisini Decimala cevirib,
                                                          //evvelce yaziriq yoxsa normal olaraq xeta verecek
                ope = '+';
                textBox1.Text = "";

            }
            else
            {

                MessageBox.Show("Toplayacaginiz reqemi qeyd edin", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonBeraber_Click(object sender, EventArgs e)
        {

            decimal reqem2 = Convert.ToDecimal(textBox1.Text);
            if (ope == '+')
            {
                netice = reqem1 + reqem2;
                textBox1.Text = netice.ToString();
            }
            else if (ope == '-')
            {
                netice = reqem1 - reqem2;
                textBox1.Text = netice.ToString();
            }
            else if (ope == '*')
            {
                netice = reqem1 * reqem2;
                textBox1.Text = netice.ToString();
            }
            else if (ope == '/')
            {
                netice = reqem1 / reqem2;
                textBox1.Text = netice.ToString();
            }
            else if (ope == '%')
            {
                netice = (reqem1 * reqem2) / 100;
                textBox1.Text = netice.ToString();
            }
        }

        private void buttonSilmeButov_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "2";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }


        }

        private void buttonCixma_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                reqem1 = Convert.ToDecimal(textBox1.Text);
                ope = '-';
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Çixacaginiz reqemi qeyd edin", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonVurma_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                reqem1 = Convert.ToDecimal(textBox1.Text);
                ope = '*';
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Vuracaginiz reqemi qeyd edin", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonBolme_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                reqem1 = Convert.ToDecimal(textBox1.Text);
                ope = '/';
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Böleceyiniz reqemi qeyd edin", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void buttonFaiz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                reqem1 = Convert.ToDecimal(textBox1.Text);
                ope = '%';
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Faizin tapmaq istediyiniz reqemi qeyd edin", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonSilmeTekTek_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = (textBox1.Text.Remove(textBox1.TextLength - 1)).ToString();
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void buttonVergul_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))// Contain et eger varsa "," elave etme
            {
                textBox1.Text += ",";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "2580")
            {
                Form3 f = new Form3();
                f.Show();
                textBox1.Text = "0";
            }
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}