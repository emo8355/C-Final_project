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

namespace CS_FinalProject_HL_SZ
{
    public partial class Books : Form
    {
        private string connString = "Server=tcp:bcitszhl.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=Adp001;Password=Admin001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private bool mode = false;
        private int id;
        public Books()
        {
            InitializeComponent();
            loadCategory();
            loadAuthors();
            load();
        }

        public void load()
        {

            string str = "select books.book_id, books.title, books.language, category.name as category, CONCAT(author.firstname,' ',author.lastname) as fullname " +
                "from books " +
                "INNER JOIN category ON category.category_id =books.category_id" +
                " LEFT JOIN author on author.author_id = books.author_id";
            dataGridView1.Rows.Clear();
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
            con.Close();
        }

        public void loadCategory()
        {
            string str = $"select * from category";
            dataGridView1.Rows.Clear();
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            DataSet dataset = new DataSet();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dataset);
            CategorySelect.DataSource = dataset.Tables[0];
            CategorySelect.DisplayMember = "name";
            CategorySelect.ValueMember = "category_id";
            con.Close();
        }

        public void loadAuthors()
        {
            string str = "select author_id, CONCAT(firstname,' ',lastname) as fullname from author";
            dataGridView1.Rows.Clear();
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            DataSet dataset = new DataSet();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dataset);
            AuthorSelect.DataSource = dataset.Tables[0];
            AuthorSelect.DisplayMember = "fullname";
            AuthorSelect.ValueMember = "author_id";
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookTitle = bookInput.Text;
            string language = langinput.Text;
            string category = CategorySelect.SelectedValue.ToString();
            string author = AuthorSelect.SelectedValue.ToString();
            DateTime publishedDate = DateTime.Parse(dateInput.Text);
            if (mode)
                Global.database.UpdateBook(bookTitle, language, category, author, publishedDate,id);
            else
                Global.database.CreateBook(bookTitle, language, category, author, publishedDate);
            mode = false;
            this.load();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                mode = true;
                string query = $"SELECT title, language, published_date FROM books WHERE book_id = {id}";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bookInput.Text = dr[0].ToString();
                    langinput.Text = dr[1].ToString();
                    dateInput.Text = dr[2].ToString();
                }

                conn.Close();

            }
            else if (e.ColumnIndex == dataGridView1.Columns["Detele"].Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Global.database.RemoveColumnById("books", "book_id", id);
                this.load();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.controlScreen.Show();
        }
    }
}
