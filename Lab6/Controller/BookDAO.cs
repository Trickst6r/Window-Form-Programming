using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lab6.Models;
namespace Lab6.Controller
{
    class BookDAO
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;
        private SqlCommand sqlCommand;
        private DataSet ds;
        public SqlConnection connection()
        {
            string sql = "server=.;database=Lab6DB;uid=sa;pwd=123";
            sqlConnection = new SqlConnection(sql);
            return sqlConnection;
        }
        public void loadComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM Genre";
            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds, "Genre");
            comboBox.DataSource = ds.Tables["Genre"];
            comboBox.DisplayMember = "GenreName"; // ap dung cho cot ko khoa , display la hien thi string
            //comboBox.ValueMember = "Id"; //ap dung cho primary, value la hien thi int
        }
        public void addBook(Book book, string genreName)
        {
            int id = 0;
            string query = "SELECT * FROM Genre WHERE GenreName = @genre";
            sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@genre", genreName);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds, "Genre");
            foreach (DataRow item in ds.Tables["Genre"].Rows)
            {
                id = int.Parse(item["Id"].ToString());
            }
            string sql = "INSERT Book VALUES(@isbn,@title,@edition,@genre)";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@isbn",book.ISBN);
            sqlCommand.Parameters.AddWithValue("@title",book.TITLE);
            sqlCommand.Parameters.AddWithValue("@edition",book.EDITION);
            sqlCommand.Parameters.AddWithValue("@genre",id);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void loadBook(DataGridView dataGridView)
        {
            string sql = "SELECT * FROM Book";
            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds, "Book");
            dataGridView.DataSource = ds.Tables["Book"];
            //comboBox.DisplayMember = "GenreName"; // ap dung cho cot ko khoa , display la hien thi string
            //dataGridView.ValueMember = "Id"; //ap dung cho primary, value la hien thi int
        }
        public void bindingControl(DataGridView gridView,TextBox tbISBN,TextBox tbTitle, ComboBox cbGenre, TextBox tbEdition)
        {
            string cbGen = "";
            string sql = "SELECT * FROM Genre WHERE Id = @genID";
            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@genID", gridView.CurrentRow.Cells[3].Value.ToString());
            //MessageBox.Show(gridView.CurrentRow.Cells[3].Value.ToString());
            ds = new DataSet();
            sqlDataAdapter.Fill(ds, "Genre");
            foreach (DataRow item in ds.Tables["Genre"].Rows)
            {
                cbGen = item["GenreName"].ToString();
            }
            //MessageBox.Show(cbGen);
            tbISBN.Text = gridView.CurrentRow.Cells[0].Value.ToString();
            tbTitle.Text = gridView.CurrentRow.Cells[1].Value.ToString();
            //cbGenre.Text = gridView.CurrentRow.Cells[3].Value.ToString();
            cbGenre.Text = cbGen;
            tbEdition.Text = gridView.CurrentRow.Cells[2].Value.ToString();
        }
        public void updateBook(Book book)
        {
            string sql = "UPDATE Book SET  Title=@title, Edition=@edition, Genre_id=@genId WHERE ISBN=@isbn";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@title", book.TITLE);
            sqlCommand.Parameters.AddWithValue("@edition", book.EDITION);
            sqlCommand.Parameters.AddWithValue("@genId", book.GENRE_ID);
            sqlCommand.Parameters.AddWithValue("@isbn", book.ISBN);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void searchBook(TextBox tbFilter, DataGridView grid)
        {   
            if(tbFilter.Text == "")
            {
                string sql = "SELECT * FROM Book";
                sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
                ds = new DataSet();
                sqlDataAdapter.Fill(ds, "Book");
                grid.DataSource = ds.Tables["Book"];
            }
            else
            {
                string sql = "SELECT * FROM Book Where Title LIKE '%'+@a+'%'";
                sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@a",tbFilter.Text);
                ds = new DataSet();
                sqlDataAdapter.Fill(ds, "Book");
                grid.DataSource = ds.Tables["Book"];
            }
            
        }
    }
}
