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
    public partial class FormAdmin : Form
    {
        private FormLogin Fl { get; set; }
        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(FormLogin fl, string name) : this()
        {
            this.Fl = fl;
            this.lblGreeting.Text += name;
        }

        // application closed
        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddReceptionist_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new FormAddReceptionist(this).Show();
            }
            catch (Exception excp)
            {
                MessageBox.Show("An Error occured: " + excp.Message);
            }
            
        }

        private void btnAddTests_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new FormAddTest(this).Show();
            }
            catch (Exception excp)
            {
                MessageBox.Show("An Error occured: " + excp.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Log Out Successful!");
            this.Fl.Show();
        }
    }
}
