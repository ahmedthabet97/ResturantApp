using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantApp
{
    public partial class report : Form
    {
        public DateTime Day { get; set; }
        public report()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            string con = "Server=localhost;Initial Catalog = UmnitiResturant;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(con);
            SqlCommand sqlCommand = new SqlCommand();       
            sqlCommand.CommandText = $"select * From Orders where OrderDate ='{Day}' ";
            sqlCommand.Connection = connection;
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            List<Orders> orders = new List<Orders>();
            foreach (DataRow row in dt.Rows)
            {
                Orders ORDER = new Orders();
                ORDER.Id = (int)row["Id"];
                ORDER.Name = row["MealsName"].ToString();
                ORDER.Quantity =(int)row["Quantity"];
                ORDER.Price = (int)row["Price"];
                ORDER.Tax = (int)row["tax"];
                ORDER.TotalPrice = (int)row["TotalPrice"];
                ORDER.Date = (DateTime)row["OrderDate"];
             //   ORDER.Time = ((DateTime)row["OrderTime"]).ToLongTimeString();
                orders.Add(ORDER);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Day = dateTimePicker1.Value;
           // MessageBox.Show(Day.ToShortDateString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
