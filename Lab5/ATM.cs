using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5.Repository;
namespace Lab5
{
    public delegate void SendMsg(string no,string name);//create delegate
    public partial class ATM : Form
    {
        SendMsg sendMsg; // delegate
        AccountDAO dao = new AccountDAO();
        public ATM()
        {
            InitializeComponent();
            sendMsg= new SendMsg(sendMsgNo);//call delegate
            dao.setConnect();
            dao.InitListView(listView);
        }
        public void sendMsgNo(string no,string name)
        {
            lbAccountName.Text = no;
            accountNo.Text = name;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            try
            {
                dao.checkBalance(tbBalance, accountNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
        
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbAmount.Text = "500";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbAmount.Text = "1000";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbAmount.Text = "1500";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbAmount.Text = "2000";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbAmount.Text = "3000";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbAmount.Text = "5000";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(tbAmount.Text == "")
            {
                MessageBox.Show("You need choose amount first", "Error");
            }
            else
            {
                dao.deposit(tbAmount, accountNo);
                MessageBox.Show("Successfully");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbAmount.Text == "" && tbOther.Text =="")
                {
                    MessageBox.Show("You need choose amount first", "Error");
                }
                else if(tbOther.Text == "" && tbAmount.Text != "")
                {
                    dao.withdraw(tbAmount, accountNo);
                    MessageBox.Show("Successfully");
                    dao.CreateListView(listView, tbAmount);
                }
                else if(tbOther.Text != "" && tbAmount.Text == "")
                {
                    dao.withdraw(tbOther, accountNo);
                    MessageBox.Show("Successfully");
                    dao.CreateListView(listView, tbOther);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
