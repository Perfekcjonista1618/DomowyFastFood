using HtmlAgilityPack;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace DomowyFastFood
{
    public partial class frmUserControlPanel : Form 
    {
        string path = @"SyncDateTime.txt";
        public string Identity { get; set; }
        public frmUserControlPanel(string Identity)
        {
            InitializeComponent();
            this.Identity = Identity;
        }

        private void UserControlPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'domowyFastFoodDataSet1.Restauracja' table. You can move, or remove it, as needed.
            this.restauracjaTableAdapter.Fill(this.domowyFastFoodDataSet1.Restauracja);
            
            var Lines = File.ReadAllText(path);
            lblSyncInfo.Text = Lines;
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            using (DomowyFastFoodContext Context = new DomowyFastFoodContext())
            {
                var currentDate = $"{DateTime.Now.ToShortDateString()} \t {DateTime.Now.ToShortTimeString()}";

                lblSyncInfo.Text = currentDate;

                File.WriteAllText(path,$"");
                File.AppendAllText(path, currentDate);

                string url = "http://www.poswieciekuchni.pl/menu-dnia/";
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = web.Load(url);


                var node = document.DocumentNode
                               .SelectNodes("//div[@class='wpb_wrapper']/p[position() > 5]").ToArray();

                string Dinner = string.Empty;

                if (node != null)
                {
                    foreach (var item in node)
                    {
                        Dinner += item.InnerText;
                    }
                }
                var Result = Context.Restauracjas.SingleOrDefault(x => x.ID_Restauracji == 1);
                if (Result != null)
                {
                    Result.DanieDnia = Dinner;
                    Context.SaveChanges();
                }
                this.OnLoad(e);
               // frmUserControlPanel form = new frmUserControlPanel(Identity);
               // form.Show();
                //this.Close();
                

                //            var node = document.DocumentNode.Descendants("P")
                //.Select(y => y.Descendants()
                //.Where(x => x.Attributes["class"].Value == "wpb_wrapper"))
                //.ToArray();

                //HtmlWeb web = new HtmlWeb();
                //var document = web.Load("");

                //HtmlNode[] nodes = document.DocumentNode.SelectNodes("//*[@id=block - views - dish - of - the - day - block]").ToArray();
                //MessageBox.Show(nodes[0].InnerText);
                //var Result = Context.Restauracjas.SingleOrDefault(x => x.NazwaRestauracji == "Maximus");
                //if (Result != null)
                //{
                //    Result.DanieDnia = nodes[0].InnerText;
                //    Context.SaveChanges();
                //}
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (DomowyFastFoodContext Context = new DomowyFastFoodContext())
            {
                var client = Context.Klients.SingleOrDefault(x => x.Nick == Identity);
                var id = client.ID_Klienta;
                //var id = int.Parse(dgvBazaSK.Rows[dgvBazaSK.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                Context.Zamowienies.Add(new Zamowienie
                {
                    ID_Zamowienia = Context.Zamowienies.Max(x => x.ID_Zamowienia) + 1,
                    ID_Klienta = id,
                    ID_Restauracji = int.Parse(dgvRestaurant.Rows[dgvRestaurant.SelectedCells[0].RowIndex].Cells[0].Value.ToString()),
            });
                Context.SaveChanges();
                MessageBox.Show("Pomyslnie dodano zamowienie","Zamow!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
