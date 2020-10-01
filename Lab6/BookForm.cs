using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab6.Controller;
using Lab6.Models;
using System.Text.RegularExpressions;
namespace Lab6
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }
        BookDAO dao = new BookDAO();
        private void loadData()
        {
            dao.loadComboBox(cbGenre);
            dao.loadBook(gridView);
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            dao.connection();
            loadData();
            dao.bindingControl(gridView, tbISBN, tbTitle, cbGenre, tbEdition);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbISBN.Text))
                {
                    throw new Exception("ISBN can not blank.");
                }
                if(Regex.IsMatch(tbISBN.Text, "^B(0-9){3}$"))
                {
                    throw new Exception("ISBN is format Bxxx with xxx are digits.");
                }
                if (String.IsNullOrEmpty(tbTitle.Text))
                {
                    throw new Exception("Title can not blank.");
                }
                if (String.IsNullOrEmpty(tbEdition.Text) || int.Parse(tbEdition.Text) < 0)
                {
                    throw new Exception("Edition is invalid.");
                }

                Book book = new Book
                {
                    ISBN = tbISBN.Text,
                    TITLE = tbTitle.Text,
                    EDITION = int.Parse(tbEdition.Text),
                    GENRE_ID = int.Parse(cbGenre.Text),
                };
                dao.addBook(book, cbGenre.Text);
                MessageBox.Show("Congratulation!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView_KeyUp(object sender, KeyEventArgs e)
        {
            dao.bindingControl(gridView, tbISBN, tbTitle, cbGenre, tbEdition);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book
                {
                    ISBN = tbISBN.Text,
                    TITLE = tbTitle.Text,
                    EDITION = int.Parse(tbEdition.Text),
                    GENRE_ID = int.Parse(cbGenre.Text),
                };
                dao.updateBook(book);
                MessageBox.Show("Update Successfully!!!");
                dao.loadBook(gridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            dao.searchBook(tbFilter, gridView);
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dao.bindingControl(gridView, tbISBN, tbTitle, cbGenre, tbEdition);
        }
    }
}
