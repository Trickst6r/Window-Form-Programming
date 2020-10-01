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
namespace Lab9_ExploringWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            setConnect();
            loadStore();
        }
        private SqlConnection connect;
        private SqlDataAdapter adapter;
        private DataSet dataset;
        private SqlConnection setConnect()
        {
            string uri = "server=.;database=Lab9;uid=sa;pwd=123";
            connect = new SqlConnection(uri);
            return connect;
        }
        private void InitTabControl()
        {
            tabControl1.TabPages.Remove(tabSearchbystore);
            tabControl1.TabPages.Remove(tabAddstore);
        }
        private void InitTabpage()
        {
            tabControl1.TabPages.Insert(1, tabAddstore);
            tabControl1.TabPages.Insert(2,tabSearchbystore);
            tabControl1.SelectedTab = tabAddstore;

        }
        private void createStore()
        {
            string query = "INSERT Store VALUES(@id,@name,@phone,@location,@number)";
            adapter = new SqlDataAdapter(query, connect);
            adapter.SelectCommand.Parameters.AddWithValue("@id", tbSCode.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@name", tbSName.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@phone", tbSPhone.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@location", tbSLocation.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@number", trackBarS.Value);
            dataset = new DataSet();
            adapter.Fill(dataset, "Store");

        }
        private void InitNotifyIcon()
        {
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = "Message";
            notifyIcon1.BalloonTipTitle = "The SMS is running";
            notifyIcon1.ShowBalloonTip(2);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTabControl();
            InitNotifyIcon();
        }
        private bool checkLogin()
        {
            string query = "SELECT * FROM Employee WHERE Id = @id AND EmployeeName =@name";
            adapter = new SqlDataAdapter(query, connect);
            adapter.SelectCommand.Parameters.AddWithValue("@id", tbUser.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@name", tbPass.Text);
            dataset = new DataSet();
            adapter.Fill(dataset, "Employee");
            if(dataset.Tables["Employee"].Rows.Count > 0)
            {   
                MessageBox.Show("Hello "+ tbPass.Text + "!!!");
                return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkLogin())
                {
                    InitTabpage();
                }
                else
                {
                    MessageBox.Show("Invalid", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateS_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(tbSCode.Text))
                {
                    MessageBox.Show("Store Code is invalid");
                    tbSCode.Focus();
                    return;
                }
                else
                {
                    createStore();
                    MessageBox.Show("ok");
                    loadStore();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadStore()
        {
            string query = "SELECT * FROM Store";
            adapter = new SqlDataAdapter(query, connect);
            dataset = new DataSet();
            adapter.Fill(dataset, "Store");
            dataGridView1.DataSource = dataset.Tables["Store"];
        }

        private void trackBarS_Scroll(object sender, EventArgs e)
        {
            trbnumber.Text = trackBarS.Value.ToString();
        }
        private void UpdateStore()
        {
            int row = dataGridView1.CurrentRow.Index;
            string scode = dataGridView1.Rows[row].Cells[0].Value.ToString();
            string name = dataGridView1.Rows[row].Cells[1].Value.ToString();
            string phone = dataGridView1.Rows[row].Cells[2].Value.ToString();
            string location = dataGridView1.Rows[row].Cells[3].Value.ToString();
            int number = int.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());


            string query = "UPDATE Store SET StoreName=@name,StorePhone=@phone,Location=@location,EmployeeNumber=@number WHERE StoreCode=@code";
            adapter = new SqlDataAdapter(query, connect);
            adapter.SelectCommand.Parameters.AddWithValue("@name", name);
            adapter.SelectCommand.Parameters.AddWithValue("@phone", phone);
            adapter.SelectCommand.Parameters.AddWithValue("@location", location);
            adapter.SelectCommand.Parameters.AddWithValue("@number", number);
            adapter.SelectCommand.Parameters.AddWithValue("@code", scode);
            dataset = new DataSet();
            adapter.Fill(dataset, "Store");

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateStore();
                MessageBox.Show("ok");
                loadStore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteStore()
        {
            int row = dataGridView1.CurrentRow.Index;
            string scode = dataGridView1.Rows[row].Cells[0].Value.ToString();
            
            string query = "DELETE FROM  Store WHERE StoreCode=@code";
            adapter = new SqlDataAdapter(query, connect);
            adapter.SelectCommand.Parameters.AddWithValue("@code", scode);
            dataset = new DataSet();
            adapter.Fill(dataset, "Store");

        }

        private void tabAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
