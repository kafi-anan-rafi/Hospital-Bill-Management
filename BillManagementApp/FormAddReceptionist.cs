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
    public partial class FormAddReceptionist : Form
    {
        private DataAccess Da { get; set; }
        private FormAdmin Fa { get; set; }
        public FormAddReceptionist()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public FormAddReceptionist(FormAdmin fa) : this()
        {
            this.Fa = fa;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fa.Show();
        }

        
        private void FormAddReceptionist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.validateData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                //insert
                var sql = @"insert into Users values('" + this.txtId.Text + "','" + this.txtName.Text + "','" + this.cmbGender.Text + "','" + this.dtpJoiningDate.Text + "','" + this.txtPassword.Text + "', 'receptionist')";
                
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data insertion successfull");
                else
                    MessageBox.Show("Data insertion failed");

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private bool validateData()
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtPassword.Text) || String.IsNullOrEmpty(this.cmbGender.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void FormAddReceptionist_Load(object sender, EventArgs e)
        {
            this.GenerateId();
        }

        private void GenerateId()
        {
            String sql = "select * from Users where role='receptionist' order by id desc";
            var ds = Da.ExecuteQuery(sql);

            String id = ds.Tables[0].Rows[0][0].ToString();

            string[] splitedString = id.Split('-');
            int number = Int32.Parse(splitedString[1]);
            number++;

            if (number < 10)
                this.txtId.Text = "r-00" + number;
            else if (number < 100)
                this.txtId.Text = "r-0" + number;
            else
                this.txtId.Text = "r-" + number;
        }
    }
}
