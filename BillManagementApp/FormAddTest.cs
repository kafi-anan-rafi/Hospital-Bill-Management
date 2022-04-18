using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillManagementApp
{
    public partial class FormAddTest : Form
    {
        private FormAdmin Fa { get; set; }

        public FormAddTest()
        {
            InitializeComponent();
        }
        public FormAddTest(FormAdmin fa) : this()
        {
            this.Fa = fa;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fa.Show();
        }
    }
}
