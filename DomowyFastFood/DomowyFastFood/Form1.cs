using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowyFastFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDate.Text = $"{DateTime.Now.ToShortDateString()} \t {DateTime.Now.ToShortTimeString()}";

            HtmlWeb web = new HtmlWeb();
            var document = web.Load("http://maximus.bielsko.pl");

            HtmlNode[] nodes = document.DocumentNode.SelectNodes("//div[@id='red_circle']").ToArray();
            textBox1.Text = nodes[0].InnerText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'domowyFastFoodDataSet.Restauracja' table. You can move, or remove it, as needed.
            this.restauracjaTableAdapter.Fill(this.domowyFastFoodDataSet.Restauracja);

        }
    }
}
