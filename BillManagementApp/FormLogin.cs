using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BillManagementApp
{
    public partial class FormLogin : Form
    {
        private DataAccess Da { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                string sql = "select* from Users where id = '"+this.txtUserId.Text+"'";
                SqlConnection sqlcon = new SqlConnection("Data Source=LAPTOP-D8IFE1Q2;Initial Catalog=BillManagement;Persist Security Info=True;User ID=Kafi Anan;Password=kafianan");
                sqlcon.Open();
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (txtUserId.Text == ds.Tables[0].Rows[0][0].ToString() && txtPassword.Text == ds.Tables[0].Rows[0][4].ToString())
                    {
                        MessageBox.Show("login successful!");
                        this.Hide();
                        new FormAdmin().Show();
                    }
                    else
                    {
                        MessageBox.Show("ID password could not matched!");

                    }
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Error occured: " + excp.Message);
            }
            */


            try
            {
                String sql = "select * from Users where id ='" + this.txtUserId.Text + "'";
                var ds = Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    String id = ds.Tables[0].Rows[0][0].ToString();
                    String password = ds.Tables[0].Rows[0][4].ToString();

                    if (this.txtUserId.Text == id && this.txtPassword.Text == password)
                    {
                        string name = ds.Tables[0].Rows[0][1].ToString();
                        // admin login
                        if (ds.Tables[0].Rows[0][5].ToString() == "admin")
                        {
                            //MessageBox.Show("Admin Login Successful");
                            this.Hide();
                            new FormAdmin(this, name).Show();
                        }
                        else
                        {
                            //reciptionist login
                            //MessageBox.Show("Receptionist Login Successful");
                            this.Hide();
                            new FormReceptionist(this, name).Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Id and Password could not match!");
                    }
                }
                else
                {
                    MessageBox.Show("User not found!");
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("An Error has occured: " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }
    }
}
