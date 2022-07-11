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
using System.Configuration;

namespace eClerx.Question2.Kallem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["masterCon"].ConnectionString);


            cmd = new SqlCommand("Select CustomerId, CustomerName, City, CreditLimit from Customer", con);

            ComboSortBy.Text = "--Select One--";
            ComboSortBy.Items.Add("Credit Limit: Low to High");
            ComboSortBy.Items.Add("Credit Limit: High to Low");
            ComboSortBy.Items.Add("Customer Namw: A-Z");
            ComboSortBy.Items.Add("Customer Name: Z-A");

            //Open the connection
            con.Open();

            //Execute the command and fetch datas
            reader = cmd.ExecuteReader();

            //Read the first row
            reader.Read();

            //Store into releavant TextBoxes
            TxtCustomerCity.Text = reader["City"].ToString();
            //ComboSortBy.Text = reader["CreditLimit"].ToString();

            //Close the reader object
            reader.Close();

            //Dispose Command Object
            cmd.Dispose();

            //Close the connection
            con.Close();
        }

        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["masterCon"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select CustomerId, CustomerName, City, CreditLimit from Customer Where City = "+ TxtCustomerCity.Text, con))
                {
                    ds = new DataSet();
                    adapter.Fill(ds, "Ext");

                    //cmd.Parameters.AddWithValue("@CustomerCity", TxtCustomerCity.Text);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                   

                    DataView dv = ds.Tables["Ext"].DefaultView;

                    if (ComboSortBy.SelectedIndex == 0)
                    {
                        dv.RowFilter = "ORDER BY CreditLimit ASC";
                    }
                    else if (ComboSortBy.SelectedIndex == 1)
                    {
                        dv.RowFilter = "ORDER BY CreditLimit DESC";
                    }
                    else if (ComboSortBy.SelectedIndex == 2)
                    {
                        dv.RowFilter = "ORDER BY CustomerName ASC";
                    }
                    else
                    {
                        dv.RowFilter = "ORDER BY CustomerName DESC";
                    }

                    GridCustomerInfo.DataSource = dv;
                }
                
            }
        }
    }
}

