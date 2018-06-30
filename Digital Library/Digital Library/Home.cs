using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Library
{
    public partial class Home_form : Form
    {
        public Home_form()
        {
            InitializeComponent();
        }
        private void Logout(object sender, MouseEventArgs e)
        {
            Login_form h = new Login_form();
            h.Show();
            this.Hide();

        }

        private void Entry_New_Student_button_Click(object sender, EventArgs e)
        {
           

        }

        private void New_Book_Entry_button_Click(object sender, EventArgs e)
        {
            Home_Entry_New_Book book = new Home_Entry_New_Book();
            book.Show();
            this.Hide();
        }

        private void View_all_books_button_Click(object sender, EventArgs e)
        {
            All_Books a = new All_Books();
            a.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
