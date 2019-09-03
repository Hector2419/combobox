using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Webbrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
            link.Text = ("www.Google.com");
        }
        private void Ir_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(link.Text);
        }
        private void Agregarfavoritos_Click(object sender, EventArgs e)
        {
            seleccionarfavoritos.Items.Add(webBrowser1.Url.ToString());
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Link_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Link_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                webBrowser1.Navigate(link.Text);
            }
        }

        private void Seleccionarfavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(seleccionarfavoritos.SelectedItem.ToString());
        }
    }
}
