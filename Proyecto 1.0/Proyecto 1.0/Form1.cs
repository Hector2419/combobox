﻿using System;
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
            comboBox1.Items.Add("Quetzal GTQ");
            comboBox2.Items.Add("Quetzal GTQ");
            comboBox1.Items.Add("Colombian peso COP");
            comboBox2.Items.Add("Colombian peso COP");
            comboBox1.Items.Add("Bolivars BOB");
            comboBox2.Items.Add("Bolivars BOB");
            comboBox1.Items.Add("Swiss franc CHF");
            comboBox2.Items.Add("Swiss franc CHF");
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
                else if (op == "Quetzal GTQ")
                {
                    o = 7.68075;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 3365.41;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 6.90516;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.987924;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 0.395351;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 173.175;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.355286;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.0509936;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 8.49866;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 3724.04;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 7.64082;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 1.09450;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 0.0710064;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 31.1200;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.063885;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.00913888;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 2.31031;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 1012.31;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 2.07702;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.297611;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 0.08214;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 47.4069;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.0972411;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.0139131;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 9.47663;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 4152.26;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 8.51800;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 1.23069;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Quetzal GTQ")
            {
                if (op == "Dollar USD")
                {
                    o = 0.130196;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 2.53121;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.117665;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 14.0805;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.432843;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 9.24152;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.105518;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Colombian peso COP")
                {
                    o = 438.184;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.899022;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.128501;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Colombian peso COP")
            {
                if (op == "Dollar USD")
                {
                    o = 0.000297140;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.00577450;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.000268526;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 0.0321337;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.000987838;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 0.0210940;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.000240833;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 0.00228214;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.00205186;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.128501;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Bolivars BOB")
            {
                if (op == "Dollar USD")
                {
                    o = 0.144819;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 2.81463;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.130876;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 15.6531;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.481459;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 10.2837;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.117398;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 1.11232;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 487.362;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.143153;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Swiss franc CHF")
            {
                if (op == "Dollar USD")
                {
                    o = 1.01222;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 19.6103;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.913661;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 109.423;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 3.36009;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 71.8746;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.812550;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 7.7800;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 7.78203;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 6.98552;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You can send an email to the following email address.\nPrices@ucol.mx ");
         
        }

        private void AboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creators:\n Ana Julia Carrizales Garcia\n Angelina Nohemi Colazo Medrano\n Nelsy Andrea Marical Flores\n Ashley Itzel Monroy Rivera\n Diana Lizbeth Orbe Sanchez\n Diana Lizeth Vargas Velazques\n Saul Benitez Silva\n Hector Francisco Cazadero Garduño\n                          3B");
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
                else if (op == "Quetzal GTQ")
                {
                    o = 7.68075;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 3365.41;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 6.90516;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.987924;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 0.395351;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 173.175;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.355286;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.0509936;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 8.49866;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 3724.04;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 7.64082;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 1.09450;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 0.0710064;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 31.1200;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.063885;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.00913888;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 2.31031;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 1012.31;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 2.07702;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.297611;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 0.08214;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 47.4069;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.0972411;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.0139131;
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
                else if (op == "Quetzal GTQ")
                {
                    o = 9.47663;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 4152.26;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 8.51800;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 1.23069;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Quetzal GTQ")
            {
                if (op == "Dollar USD")
                {
                    o = 0.130196;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 2.53121;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.117665;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 14.0805;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.432843;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 9.24152;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.105518;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Colombian peso COP")
                {
                    o = 438.184;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.899022;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.128501;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Colombian peso COP")
            {
                if (op == "Dollar USD")
                {
                    o = 0.000297140;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.00577450;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.000268526;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 0.0321337;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.000987838;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 0.0210940;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.000240833;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 0.00228214;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.00205186;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.128501;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Bolivars BOB")
            {
                if (op == "Dollar USD")
                {
                    o = 0.144819;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 2.81463;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.130876;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 15.6531;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.481459;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 10.2837;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.117398;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 1.11232;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 487.362;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Swiss franc CHF")
                {
                    o = 0.143153;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Swiss franc CHF")
            {
                if (op == "Dollar USD")
                {
                    o = 1.01222;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 19.6103;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.913661;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 109.423;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 3.36009;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 71.8746;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libra GBP")
                {
                    o = 0.812550;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 7.7800;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian peso COP")
                {
                    o = 7.78203;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 6.98552;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Swiss franc CHF")
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
