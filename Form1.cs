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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void ChkBrger_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBrger.Checked == true)
            {
                TxtBurger.Enabled = true;
            }
            if (ChkBrger.Checked == false)
            {
                TxtBurger.Enabled = false;
                TxtBurger.Text = "0";
            }
        }

        private void ChkPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPizza.Checked == true)
            {
                TxtPizza.Enabled = true;
            }
            if (ChkPizza.Checked == false)
            {
                TxtPizza.Enabled = false;
                TxtPizza.Text = "0";
            }
        }

        private void ChkCheaken_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCheaken.Checked == true)
            {
                TxtCheacken.Enabled = true;
            }
            if (ChkCheaken.Checked == false)
            {
                TxtCheacken.Enabled = false;
                TxtCheacken.Text = "0";
            }
        }

        private void ChkWater_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkWater.Checked == true)
            {
                TxtWater.Enabled = true;
            }
            if (ChkWater.Checked == false)
            {
                TxtWater.Enabled = false;
                TxtWater.Text = "0";


            }
        }

        private void ChkCola_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCola.Checked == true)
            {
                TxtCola.Enabled = true;
            }
            if (ChkCola.Checked == false)
            {
                TxtCola.Enabled = false;
                TxtCola.Text = "0";
            }
        }

        private void ChkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTea.Checked == true)
            {
                TxtTea.Enabled = true;
            }
            if (ChkTea.Checked == false)
            {
                TxtTea.Enabled = false;
                TxtTea.Text = "0";

            }
        }

        private void ChkOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkOrange.Checked == true)
            {
                TxtOrange.Enabled = true;
            }
            if (ChkOrange.Checked == false)
            {
                TxtOrange.Enabled = false;
                TxtOrange.Text = "0";

            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //GetPrice Of Order


        private void TxtReceipt_TextChanged(object sender, EventArgs e)
        {
           
        }
        double SubTotal ;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.Parse(TxtBurgerPrice.Text) > 0)
            {
                SubTotal = 0;
                int ColaPrice = int.Parse(TxtColaPrice.Text) * int.Parse(TxtCola.Text);
                int OrangePrice = int.Parse(TxtOrangePrice.Text) * int.Parse(TxtOrange.Text);
                int TeaPrice = int.Parse(TxtTeaPrice.Text) * int.Parse(TxtTea.Text);
                int WaterPrice = int.Parse(TxtWaterPrice.Text) * int.Parse(TxtWater.Text);

                TxtReceipt.Clear();
                TxtReceipt.AppendText(Environment.NewLine);
                TxtReceipt.AppendText("\t\t\t CODESPACE RESTURANT\t" + DateLbl.Text + Environment.NewLine);
                TxtReceipt.AppendText("\t\t\t **************************************" + Environment.NewLine);
                if (ChkBrger.Checked == true)
                {
                    int bugerPrice = int.Parse(TxtBurgerPrice.Text) * int.Parse(TxtBurger.Text);

                    TxtReceipt.AppendText("\t Burger  \t" + $"Quant\t{TxtBurger.Text}\t" + bugerPrice + Environment.NewLine);
                    SubTotal += bugerPrice;
                }
                if (ChkPizza.Checked == true)
                {
                    int PizzaPrice = int.Parse(TxtPizzaPrice.Text) * int.Parse(TxtPizza.Text);
                    TxtReceipt.AppendText("\t Pizza  \t\t" + $"Quant\t{TxtPizza.Text}\t" + PizzaPrice + Environment.NewLine);
                    SubTotal += PizzaPrice;
                }
                if (ChkCheaken.Checked == true)
                {
                    int CheackenPrice = int.Parse(TxtCheckanPrice.Text) * int.Parse(TxtCheacken.Text);

                    TxtReceipt.AppendText("\t cheacken \t" + $"Quant\t{TxtCheacken.Text}\t" + CheackenPrice + Environment.NewLine);
                    SubTotal += CheackenPrice;
                }
                TxtReceipt.AppendText(Environment.NewLine);
                TxtReceipt.AppendText("\t\t\t **************************************" + Environment.NewLine);

                TxtReceipt.AppendText($"\t subTotal {SubTotal} \t tax\t{SubTotal * .1}\t total\t {SubTotal + SubTotal * .1}   {Environment.NewLine}");

                SubTotalRes.Text = "" + SubTotal;
                LblTaxRes.Text = "" + SubTotal * .1;// 10% percent service
                LblTotalRes.Text = (SubTotal * .1 + SubTotal).ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string message = "What is your Password ";
            //string title = "your password";
            //MessageBoxButtons buttons = MessageBoxButtons.OK;
            //DialogResult result = MessageBox.Show(message, title, buttons);
                
            
            TxtReceipt.Clear();
            ChkCheaken.Checked = false;
            ChkCola.Checked = false;
            ChkOrange.Checked = false;
            ChkPizza.Checked = false;
            ChkTea.Checked = false;
            ChkWater.Checked = false;
            ChkBrger.Checked = false;
            LblTaxRes.Text = "0";
            LblTotalRes.Text = "0";
            SubTotalRes.Text = "0";

            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TxtReceipt.Text,new Font("Century Gothic",12,FontStyle.Regular),Brushes.Blue,new Point(130));

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

         
     
        //to Make Quatity textBox and price is only positive Number
        private void onlyPosiveNum(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
            
        }

        private void btnPriceChange_Click(object sender, EventArgs e)
        {
            
                Form2 f2 = new Form2();
                f2.ShowDialog();
                string pass = f2.GetPassword();
                if (pass == "123")
                {
                    TxtBurgerPrice.Enabled = true;
                    TxtCheckanPrice.Enabled = true;
                }
                else
                {
                    MessageBox.Show("رقم سري خاطئ");
                }
            
            
        }

        private void btncloseEdit_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.ShowDialog();
            string pass = f2.GetPassword();
            if (pass == "123")
            {
                TxtBurgerPrice.Enabled = false;
                TxtCheckanPrice.Enabled = false;


            }
            else 
            {
                MessageBox.Show("رقم سري خاطئ");
            }
            

        }
        //insert data on database
        private void btnAddDb_Click(object sender, EventArgs e)
        {
            string con = "Server=localhost;Initial Catalog = UmnitiResturant;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            int price, qunt, total;
            //*  [dbo].[Orders] ([MealsName],[Quantity],[Price],[tax],[TotalPrice],[OrderDate],[OrderTime])  VALUES
            if (ChkBrger.Checked)
            {
               // price = int.Parse(TxtBurgerPrice.Text);
                qunt = int.Parse(TxtBurger.Text);
                price = int.Parse(TxtBurgerPrice.Text) * int.Parse(TxtBurger.Text);
                total = price + price * 10/100;
                sqlCommand.CommandText = $"insert into Orders values (N'{lblBurgr.Text}',{qunt},{price},{10},{total},'{DateTime.Now.ToShortDateString()}','{DateTime.Now.ToLongTimeString()}') ";
                sqlCommand.Connection = connection;
                sqlCommand.ExecuteNonQuery();
                connection.Close();

            }
            MessageBox.Show("done");
            //MessageBox.Show(DateTime.Now.ToLongTimeString);


            //
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            string pass = form2.GetPassword();
            if (pass == "123u")
            {
                report r = new report();
                r.Show();
            }
            else 
            {
                MessageBox.Show("رقم سري خاطئ");
            }
        }

        private void DateLbl_Click(object sender, EventArgs e)
        {

        }
    }
 }

