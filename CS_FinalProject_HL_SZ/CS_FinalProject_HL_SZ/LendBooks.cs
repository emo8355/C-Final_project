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
    public partial class LendBooks : Form
    {
        private string connString = "Server=tcp:bcitszhl.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=Adp001;Password=Admin001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public LendBooks()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            string str = @"
                select 
                	books.book_id, 
                	books.title, 
                	books.language, 
                	category.name as category, 
                	CONCAT(author.firstname,' ',author.lastname) as fullname,
                	books.isBorrowed as status,
                    CASE WHEN books.isBorrowed = 0 THEN 'false' ELSE 'true' END AS status
                from books
                	INNER JOIN category ON category.category_id =books.category_id
                	LEFT JOIN author on author.author_id = books.author_id
                WHERE books.isBorrowed = 0";
            dataGridView1.Rows.Clear();
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Lend"].Index && e.RowIndex >= 0)
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Global.database.UpdateBookStatus(1, id);
            }
            this.load();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.controlScreen.Show();
        }

        private void LendBooks_Load(object sender, EventArgs e)
        {
            this.load();
        }
    }
}
