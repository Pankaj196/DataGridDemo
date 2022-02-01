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
namespace DataGridDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection conn = null;
        private void button1_Click(object sender, EventArgs e)
        {
           string conn = "data source =devops.aapnainfotech.com;database=DataGridDemo; uid=apnsa; pwd=W98rd41lMravjL5";
            //SqlCommand cmd= new SqlCommand("select * from Student_Demo",conn);
            //conn.Open();
            string query = "select * from Product";
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            DataSet ds=new DataSet();
            adapter.Fill(ds, "Product");
            dataGridView1.DataSource = ds.Tables["Product"];
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //string conn = "data source =devops.aapnainfotech.com;database=DataGridDemo; uid=apnsa; pwd=W98rd41lMravjL5";
            //MDI m = new MDI();
            //m.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
        }
    }
}
