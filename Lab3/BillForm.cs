using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Lab3
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
            billDao.initCity(domainUpDown2);
            billDao.InitQuantity(numericUpDown2);
            billDao.InitListView(listView1);
        }

        Repository.BillDao billDao = new Repository.BillDao();

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int total = 0;
                int price = int.Parse(txtPrice.Text);
                int qoh = int.Parse(numericUpDown2.Value.ToString());
                total = price * qoh;
                lbSubtotal.Text = total.ToString() + " $";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!Regex.IsMatch(txtProductID.Text, "^[P][0-9]{3}$"))
                {
                    MessageBox.Show("Invalid Product ID");
                    txtProductID.Focus();
                    return;
                }
                else
                        {
                            billDao.CreateBill(listView1, txtInvoiceCode, dateTimePicker1, txtCustomerName, domainUpDown2, txtProductName, numericUpDown2, txtPrice);
                        }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
