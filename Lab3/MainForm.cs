using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Repository;
namespace Lab3
{
    public partial class MainForm : Form
    {
            InitControl init = new InitControl();
        public MainForm()
        {
            InitializeComponent();
            init.InitProgressBar(progressBar1);
            initTimer();
        }

        public void initTimer()
        {
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Text = "Today's : " + DateTime.Now.ToLongTimeString() + "\n" + DateTime.Now.ToShortDateString();
        }
        

        private void treeView1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            if (treeView1.Nodes[0].Nodes[0].Nodes[0].IsSelected)
            {
                CustomerForm customerForm = new CustomerForm();
                customerForm.TopLevel = false;
                customerForm.Visible = true;
                splitContainer1.Panel2.Controls.Add(customerForm);
            }
            else if (treeView1.Nodes[0].Nodes[1].Nodes[0].IsSelected)
            {
                BillForm billForm = new BillForm();
                billForm.TopLevel = false;
                billForm.Visible = true;
                splitContainer1.Panel2.Controls.Add(billForm);
            }
            
        }
    }
}
