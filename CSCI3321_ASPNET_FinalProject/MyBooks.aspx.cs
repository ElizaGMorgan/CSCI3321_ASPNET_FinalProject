using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class MyBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /// TODO: Dynamiclly build your book collection with the following information
            /// 1. Book title
            /// 2. Author's LastName and FirstName
            /// 3. Price
            /// 4. Publish date
            /// 5. Publisher's name
            /// 6. Genre
            /// 
            // 1. Create a SqlConnection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            // 2. Create a SqlCommand object using the above connection object
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Books.Title, Authors.FirstName, Authors.LastName, Books.Price, Books.PublishDate, Publishers.PublisherName, Genres.GenreName FROM (((Books INNER JOIN Authors ON Books.BookID = Authors.AuthorID) INNER JOIN Publishers ON Books.BookID = Publishers.PublisherID) INNER JOIN Genres ON Books.BookID = Genres.GenreID);";

            // 3. Open the connection and execute the command
            // store the returned data in a SqlDataReader object
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // 4. if there is data in the SqlDataReader object
            // then loop through each record to build the table to display the books
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TableRow trow = new TableRow();
                    TableCell tcolumn = new TableCell();
                    tcolumn.Text = reader["Title"].ToString();
                    trow.Cells.Add(tcolumn);

                    tcolumn = new TableCell();
                    tcolumn.Text = reader["FirstName"].ToString();
                    trow.Cells.Add(tcolumn);

                    tcolumn = new TableCell();
                    tcolumn.Text = reader["LastName"].ToString();
                    trow.Cells.Add(tcolumn);

                    tcolumn = new TableCell();
                    tcolumn.Text = reader["Price"].ToString();
                    trow.Cells.Add(tcolumn);

                    tcolumn = new TableCell();
                    tcolumn.Text = reader["PublishDate"].ToString();
                    trow.Cells.Add(tcolumn);

                    tcolumn = new TableCell();
                    tcolumn.Text = reader["PublisherName"].ToString();
                    trow.Cells.Add(tcolumn);

                    tcolumn = new TableCell();
                    tcolumn.Text = reader["GenreName"].ToString();
                    trow.Cells.Add(tcolumn);

                    tblBookCollection.Rows.Add(trow);
                    // Build the table
                }

            }
        }
    }
}