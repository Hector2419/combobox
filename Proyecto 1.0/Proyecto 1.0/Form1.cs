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
            comboBox1.Items.Add("Dollar");
            comboBox1.Items.Add("Mexican Peso");
            comboBox1.Items.Add("Euro");
            comboBox1.Items.Add("Yen");
            comboBox1.Items.Add("Soles");
            comboBox1.Items.Add("Rupias");
            comboBox1.Items.Add("Libra");
            comboBox2.Items.Add("Dollar");
            comboBox2.Items.Add("Mexican Peso");
            comboBox2.Items.Add("Euro");
            comboBox2.Items.Add("Yen");
            comboBox2.Items.Add("Soles");
            comboBox2.Items.Add("Rupias");
            comboBox2.Items.Add("Libra");
        }

        private void ArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double o,res;
            string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            coin = comboBox1.Text;
            op = comboBox2.Text;
            n = float.Parse(textBox1.Text); 
            if (coin == "Dollar")
            {
                if (op == "Dollar")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                }
                else if (op== "Mexican Peso")
                {
                    o = 19.51;
                    res = n*o;
                    result = res.ToString();
                    textBox2.Text = result;
                }
                else if (op == "Euro")
                {
                    o = 0.91;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                }
                else if (op == "Yen")
                {
                    o = 107.43;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                }
                else if (op == "Soles")
                {
                    o = 3.34;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;

                }
                else if (op == "Rupias")
                {
                    o = 71.87;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                }
                else if (op == "Libra")
                {
                    o = 0.81;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                }
            }
            else if (coin == "Mexican Peso")
            {
                if (op == "Dollar")
                {

                }
                else if (op == "Mexican Peso")
                {

                }
                else if (op == "Euro")
                {

                }
                else if (op == "Yen")
                {

                }
                else if (op == "Soles")
                {

                }
                else if (op == "Rupias")
                {

                }
                else if (op == "Libra")
                {

                }
            }
            else if (coin == "Euro")
            {
                if (op == "Dollar")
                {

                }
                else if (op == "Mexican Peso")
                {

                }
                else if (op == "Euro")
                {

                }
                else if (op == "Yen")
                {

                }
                else if (op == "Soles")
                {

                }
                else if (op == "Rupias")
                {

                }
                else if (op == "Libra")
                {

                }
            }
            else if (coin == "Yen")
            {
                if (op == "Dollar")
                {

                }
                else if (op == "Mexican Peso")
                {

                }
                else if (op == "Euro")
                {

                }
                else if (op == "Yen")
                {

                }
                else if (op == "Soles")
                {

                }
                else if (op == "Rupias")
                {

                }
                else if (op == "Libra")
                {

                }
            }
            else if (coin == "Soles")
            {
                if (op == "Dollar")
                {

                }
                else if (op == "Mexican Peso")
                {

                }
                else if (op == "Euro")
                {

                }
                else if (op == "Yen")
                {

                }
                else if (op == "Soles")
                {

                }
                else if (op == "Rupias")
                {

                }
                else if (op == "Libra")
                {

                }
            }
            else if (coin == "Rupias")
            {
                if (op == "Dollar")
                {

                }
                else if (op == "Mexican Peso")
                {

                }
                else if (op == "Euro")
                {

                }
                else if (op == "Yen")
                {

                }
                else if (op == "Soles")
                {

                }
                else if (op == "Rupias")
                {

                }
                else if (op == "Libra")
                {

                }
            }
            else if (coin == "Libra")
            {
                if (op == "Dollar")
                {

                }
                else if (op == "Mexican Peso")
                {

                }
                else if (op == "Euro")
                {

                }
                else if (op == "Yen")
                {

                }
                else if (op == "Soles")
                {

                }
                else if (op == "Rupias")
                {

                }
                else if (op == "Libra")
                {

                }
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
