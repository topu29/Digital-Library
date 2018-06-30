using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BL;
using System.IO;

namespace Digital_Library
{
    public partial class Home_Entry_New_Book : Form
    {
        public Home_Entry_New_Book()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_form home = new Home_form();
            home.Show();
            this.Hide();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Book_ID_textBox.Text != "" && Book_Name_textBox.Text != "" && Author_textBox.Text != "" && Quantity_textBox.Text != "" && Category_textBox.Text != "")
                {
                    
                    Digital_library_entity information = new Digital_library_entity();

                    information.Book_Name = Book_Name_textBox.Text;
                    information.Author = Author_textBox.Text;
                    information.Category = Category_textBox.Text;
                    information.Quantity = Quantity_textBox.Text;
                    information.Serial_No = Book_ID_textBox.Text;
                    information.Arrival_Date = Arrival_Date_textBox.Text;

                    Digital_library_bl LibraryBL = new Digital_library_bl();

                    if (LibraryBL.Entry_book(information))
                    {
                        MessageBox.Show("Entry Successfull");
                        Home_form home = new Home_form();
                        home.Show();
                        this.Hide();
                        // clear();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Entry!!");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Book_ID_textBox.Clear();
            Book_Name_textBox.Clear();
            Author_textBox.Clear();
            Category_textBox.Clear();
            Quantity_textBox.Clear();
            Arrival_Date_textBox.Clear();
        }
    }
}
