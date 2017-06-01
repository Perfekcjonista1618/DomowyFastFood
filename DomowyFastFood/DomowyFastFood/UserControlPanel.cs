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
    public partial class UserControlPanel : Form
    {
        public UserControlPanel()
        {
            InitializeComponent();
        }

        private void UserControlPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'domowyFastFoodDataSet1.Restauracja' table. You can move, or remove it, as needed.
            this.restauracjaTableAdapter.Fill(this.domowyFastFoodDataSet1.Restauracja);

        }
    }
}
