using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5.Models;
using Lab5.Repository;
namespace Lab5
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            dao.setConnect();
        }
        AccountDAO dao = new AccountDAO();
        private void button1_Click(object sender, EventArgs e)
        {
            if (dao.checkLogin(tbNo.Text, tbPin.Text) == true)
            {
                this.Hide();
                ATM atm = new ATM();
                dao.getNameAccount(tbNo, AccountName);
                atm.sendMsgNo(AccountName.Text,tbNo.Text);//goi delegate
                atm.Show();
            }
            else
            {
                MessageBox.Show("Invalid", "Error");
            }
        }

        private void llbOpenaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new OpenAccount().Show();
        }
    }
}
