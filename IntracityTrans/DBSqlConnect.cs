using System.Data.SqlClient;

namespace IntracityTrans
{
    class DBSqlConnect
    {
        public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
        {

            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection con = new SqlConnection(connString);

            return con;
        }
    }
}
