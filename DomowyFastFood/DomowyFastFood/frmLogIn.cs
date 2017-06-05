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
    public partial class frmLogIn : Form
    {
        public int _Authorization { get; set; }

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister r = new frmRegister();
            r.Show();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            using (DomowyFastFoodContext Context = new DomowyFastFoodContext())
            {
                if (Context.Klients.AsParallel().Where(x => x.Nick == txtBoxLogin.Text).Count() > 0
                    && Context.Klients.AsParallel().Where(x => x.Password == txtBoxPassword.Text).Count() > 0)
                {
                    frmUserControlPanel r = new frmUserControlPanel();
                    r.Show();
                }
                else if (Context.Pracowniks.AsParallel().Where(x => x.Nick == txtBoxLogin.Text).Count() > 0
                    && Context.Pracowniks.AsParallel().Where(x => x.Password == txtBoxPassword.Text).Count() > 0)
                {
                    _Authorization = Context.Pracowniks.AsParallel().Where(x => x.Nick == txtBoxLogin.Text).FirstOrDefault().Autoryzacja;
                    frmAdminControlPanel r = new frmAdminControlPanel(_Authorization);
                    r.Show();
                }
                else MessageBox.Show("Błąd Logowania", "Niepoprawny login lub hasło", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
