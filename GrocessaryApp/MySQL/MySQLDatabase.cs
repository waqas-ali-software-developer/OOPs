using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Reflection.Metadata.BlobBuilder;

namespace GrocessaryApp.MySQL
{
    internal class MySQLDatabase
    {

        public void GetCustomer()
        {


            // Create a connection string  
            //            string ConnectionString = "Integrated Security = SSPI; " +
            //"Initial Catalog= Northwind; " + " Data source = localhost; ";
            string ConnectionString = "Data Source=localhost;port=3306;Initial Catalog=amazon;User Id=root;password=123456";
            string SQL = @"select ID,Name from students";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
                conn.Open();
            MySqlCommand findAllBooks = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQL,
                CommandType = CommandType.Text
            };

            try
            {
                MySqlDataReader dr = findAllBooks.ExecuteReader();

                while (dr.Read())
                {
              
                    Console.Write(dr["name"].ToString() + ", ");
                }

                dr.Close();
            }
            catch (Exception e)
            {
                throw new Exception("ERROR: retrieval of books failed", e);
            }
            /*
                        // create a connection object  
                        MySqlConnection conn = new MySqlConnection(ConnectionString);

                        // Create a command object  
                        MySqlCommand cmd = new MySqlCommand(SQL, conn);
                        conn.Open();

                        // Call ExecuteReader to return a DataReader  
                        MySqlDataReader reader = cmd.ExecuteReader();
                        Console.WriteLine("=============================");

                        while (reader.Read())
                        {
                            Console.Write(reader["id"].ToString() + ", ");
                            Console.Write(reader["name"].ToString() + ", ");
                            //Console.Write(reader["ContactTitle"].ToString() + ", ");
                            //Console.WriteLine(reader["Address"].ToString() + ", ");
                        }

                        //Release resources  
                        reader.Close();
                        conn.Close();
                        */
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            /* string constr = "Data Source=localhost;port=3306;Initial Catalog=SampleDB;User Id=mudassar;password=pass@123";
                 using (MySqlConnection con = new MySqlConnection(constr))
                 {
                     using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Customers"))
                     {
                         using (MySqlDataAdapter sda = new MySqlDataAdapter())
                         {
                             cmd.Connection = con;
                             sda.SelectCommand = cmd;
                             using (DataTable dt = new DataTable())
                             {
                                 sda.Fill(dt);
                                 GridView1.DataSource = dt;
                                 GridView1.DataBind();
                             }
                         }
                     }
                 }*/

        }

    }
}
