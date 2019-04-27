using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lightbrowse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView1.Navigate("https://www.duckduckgo.com");
        }

        private void NewTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 popUpForm = new Form1();
            popUpForm.Show();
        }

        private void CreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Made by les beaux oiseaux#8668");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string momgay = UrlEncodeExtended(textBox1.Text);
            var momgay2 = new System.Uri("https://www.duckduckgo.com/?q="+momgay);
            webView1.Navigate(momgay2);
            textBox1.Text = "https://www.duckduckgo.com/?q="+momgay;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            webView1.GoForward();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            webView1.GoBack();
        }

        public static string UrlEncodeExtended(string value)
        {
            char[] chars = value.ToCharArray();
            StringBuilder encodedValue = new StringBuilder();
            foreach (char c in chars)
            {
                encodedValue.Append("%" + ((int)c).ToString("X2"));
            }
            return encodedValue.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var momgay = new System.Uri(textBox1.Text);
           webView1.Navigate(momgay);
        }

    }
}
