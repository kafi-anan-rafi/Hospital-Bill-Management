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
    public partial class FormReceptionist : Form
    {
        private FormLogin Fl { get; set; }
        public FormReceptionist ()
        {
            InitializeComponent();
        }

        public FormReceptionist(FormLogin fl, string name) : this()
        {
            this.Fl = fl;
            this.lblGreeting.Text += name;
        }


        private void FormReceptionist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Log Out Successful!");
            this.Fl.Show();
        }
    }
}
