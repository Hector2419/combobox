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
        double coin, result;
        string op;
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

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
