using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_FinalProject_HL_SZ
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void CategoryNavigate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.categoryScreen.Show();
        }

        private void AuthorsNavigate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.authorsScreen.Show();
        }

        private void BooksNavigate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.bookScreen.Show();
        }

        private void LendBooksNavigate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.lendBookScreen.Show();
        }

        private void ReturnBooksNavigate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.returnBookScreen.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.loginScreen.Show();
        }
    }
}
