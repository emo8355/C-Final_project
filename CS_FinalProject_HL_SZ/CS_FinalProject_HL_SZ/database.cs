using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace CS_FinalProject_HL_SZ
{
    public class Database
    {
        static private readonly string connectionString = "Server=tcp:bcitszhl.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=Adp001;Password=Admin001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private readonly SqlConnection cnn = new SqlConnection(connectionString);
        private SqlCommand command;
        private SqlDataAdapter insert = new SqlDataAdapter();
        private SqlDataReader dataReader;
        public Database()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public void ConfirmConnect()
        {
            cnn.Open();
            MessageBox.Show("Connect confirm");
            cnn.Close();
        }

        public void testWrite()
        {
            cnn.Open();
            string sql = "Insert into category (name) values ('comic')";
            command = new SqlCommand(sql, cnn);
            insert.InsertCommand = new SqlCommand(sql, cnn);
            insert.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("data inserted");
            command.Dispose();
            cnn.Close();
        }

        public ListDictionary testRead()
        {
            cnn.Open();
            string sql = "select * from category";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            ListDictionary DataList = new ListDictionary();
            while (dataReader.Read())
                DataList.Add(dataReader.GetValue(0), dataReader.GetValue(1));
            command.Dispose();
            cnn.Close();
            return DataList;
        }

        public bool LoginUser(string email,string password)
        {
            cnn.Open();
            string sql = $"SELECT * FROM admin WHERE email ='{email}' AND password = '{password}' ";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            bool isCorrect = dataReader.Read();
            command.Dispose();
            cnn.Close();
            if (isCorrect)
                return true;
            else
                return false;
            
        }

        public void CreateUser(string firstname, string lastname, string email, string password)
        {
            cnn.Open();
            string sql = $"Insert into admin (firstname,lastname,email,password) values ('{firstname}','{lastname}','{email}','{password}')";
            command = new SqlCommand(sql, cnn);
            insert.InsertCommand = new SqlCommand(sql, cnn);
            insert.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        public void CreateCategory(string category)
        {
            try
            {
                cnn.Open();
                string sql = $"Insert into category (name) values ('{category}') ";
                command = new SqlCommand(sql, cnn);
                insert.InsertCommand = new SqlCommand(sql, cnn);
                insert.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Can not duplicate data");
                cnn.Close();
            }
            
        }

        public void CreateAuthor( string firstname, string lastname)
        {
            try
            {
                cnn.Open();
                string sql = $"Insert into author (firstname, lastname) values ('{firstname}','{lastname}')";
                command = new SqlCommand(sql, cnn);
                insert.InsertCommand = new SqlCommand(sql, cnn);
                insert.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Can not duplicate data");
                cnn.Close();
            }
        }

        public void UpdateAuthor(string firstname, string lastname, int id)
        {
            try
            {
                cnn.Open();
                string sql = $"UPDATE author SET firstname = '{firstname}', lastname = '{lastname}' WHERE author_id = '{id}'";
                command = new SqlCommand(sql, cnn);
                insert.InsertCommand = new SqlCommand(sql, cnn);
                insert.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("something went wrong, try again later");
                cnn.Close();
            }
        }

        public void CreateBook(string title, string language, string categoryId, string authorId, DateTime date)
        {
            try
            {
                cnn.Open();
                string sql = $"Insert into books (title, language, category_id, author_id, published_date) values ('{title}','{language}','{categoryId}','{authorId}','{date}')";
                command = new SqlCommand(sql, cnn);
                insert.InsertCommand = new SqlCommand(sql, cnn);
                insert.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("something went wrong, try again later");
                cnn.Close();
            }
        }

        public void UpdateBook(string title, string language, string categoryId, string authorId, DateTime date, int id )
        {
            try
            {
                cnn.Open();
                string sql = $"UPDATE books SET title = '{title}', language = '{language}' , category_id = '{categoryId}' , author_id = '{authorId}' , published_date = '{date}' WHERE book_id = '{id}'";
                command = new SqlCommand(sql, cnn);
                insert.InsertCommand = new SqlCommand(sql, cnn);
                insert.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("something went wrong, try again later");
                cnn.Close();
            }
        }

        public void UpdateBookStatus( int status, string id)
        {
            try
            {
                cnn.Open();
                string sql = $"UPDATE books SET isBorrowed = '{status}'  WHERE book_id = '{id}'";
                command = new SqlCommand(sql, cnn);
                insert.InsertCommand = new SqlCommand(sql, cnn);
                insert.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("something went wrong, try again later");
                cnn.Close();
            }
        }

        public void RemoveColumnById(string table, string typeID,int id)
        {
            cnn.Open();
            string sql = $"Delete {table} WHERE {typeID} = {id}";
            command = new SqlCommand(sql, cnn);
            insert.InsertCommand = new SqlCommand(sql, cnn);
            insert.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

    }
}