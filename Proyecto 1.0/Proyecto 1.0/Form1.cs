using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Proyecto_1._0
{

    public partial class Form1 : Form
    {
        double n;
        string op, coin, result;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dollar USD");
            comboBox1.Items.Add("Mexican Peso MXN");
            comboBox1.Items.Add("Euro EUR");
            comboBox1.Items.Add("Yen JPY");
            comboBox1.Items.Add("Soles PEN");
            comboBox1.Items.Add("Rupias INR");
            comboBox1.Items.Add("Libra GBP");
            comboBox2.Items.Add("Dollar USD");
            comboBox2.Items.Add("Mexican Peso MXN");
            comboBox2.Items.Add("Euro EUR");
            comboBox2.Items.Add("Yen JPY");
            comboBox2.Items.Add("Soles PEN");
            comboBox2.Items.Add("Rupias INR");
            comboBox2.Items.Add("Libra GBP");
        }

        private void ArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string i, t;
            //string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            i = comboBox1.Text;
            t = comboBox2.Text;
            comboBox2.Text = i;
            comboBox1.Text = t;
            textBox3.Clear();
            double o, res;
            string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            coin = comboBox1.Text;
            op = comboBox2.Text;
            n = float.Parse(textBox1.Text);
            if (coin == "Dollar USD")
            {
                if (op == "Dollar USD")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 19.51;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.91;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 107.43;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 3.34;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 71.87;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.809251;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Mexican Peso MXN")
            {
                if (op == "Dollar USD")
                {
                    o = 0.051;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Euro EUR")
                {
                    o = 0.0464174;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 5.52;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.17;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 3.68647;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.0415030;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Euro EUR")
            {
                if (op == "Dollar USD")
                {
                    o = 1.10;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 21.5436;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Yen JPY")
                {
                    o = 118.79;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 3.69;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 79.386;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.894153;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Yen JPY")
            {
                if (op == "Dollar USD")
                {
                    o = 0.0093;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.18132;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.00842;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Soles PEN")
                {
                    o = 0.031070;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 0.668590;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.007529;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Soles PEN")
            {
                if (op == "Dollar USD")
                {
                    o = 0.299081;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 5.83099;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.270749;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 32.1631;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Rupias INR")
                {
                    o = 21.4953;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.242018;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Rupias INR")
            {
                if (op == "Dollar USD")
                {
                    o = 0.0139140;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.271263;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.0125967;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 1.49568;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.0465217;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Libra GBP")
                {
                    o = 0.0112627;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Libra GBP")
            {
                if (op == "Dollar USD")
                {
                    o = 1.23571;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 24.0946;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 1.11838;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 132.856;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 4.13192;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 88.7889;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double o, res;
            string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            coin = comboBox1.Text;
            op = comboBox2.Text;
            n = float.Parse(textBox1.Text);
            if (coin == "Dollar USD")
            {
                if (op == "Dollar USD")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 19.51;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.91;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 107.43;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 3.34;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 71.87;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.809251;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Mexican Peso MXN")
            {
                if (op == "Dollar USD")
                {
                    o = 0.051;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Euro EUR")
                {
                    o = 0.0464174;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 5.52;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.17;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 3.68647;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.0415030;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Euro EUR")
            {
                if (op == "Dollar USD")
                {
                    o = 1.10;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 21.5436;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Yen JPY")
                {
                    o = 118.79;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 3.69;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 79.386;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.894153;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Yen JPY")
            {
                if (op == "Dollar USD")
                {
                    o = 0.0093;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.18132;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.00842;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Soles PEN")
                {
                    o = 0.031070;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 0.668590;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.007529;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Soles PEN")
            {
                if (op == "Dollar USD")
                {
                    o = 0.299081;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 5.83099;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.270749;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 32.1631;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Rupias INR")
                {
                    o = 21.4953;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.242018;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Rupias INR")
            {
                if (op == "Dollar USD")
                {
                    o = 0.0139140;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.271263;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.0125967;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 1.49568;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.0465217;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Libra GBP")
                {
                    o = 0.0112627;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Libra GBP")
            {
                if (op == "Dollar USD")
                {
                    o = 1.23571;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 24.0946;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 1.11838;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 132.856;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 4.13192;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 88.7889;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
             
            
        }
    }
        
    
}
