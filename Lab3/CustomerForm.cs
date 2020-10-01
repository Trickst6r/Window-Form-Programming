﻿using System;
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
    public partial class CustomerForm : Form
    {
        CustomerDAO customer = new CustomerDAO();
        public CustomerForm()
        {
            InitializeComponent();
            customer.InitListView(listView);

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {              
                customer.CreateCustomer(listView,tbName,rdTop,dtBirth,tbAddress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
