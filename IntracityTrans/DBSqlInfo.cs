using System.Data.SqlClient;

namespace IntracityTrans
{
    class DBSqlInfo
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = Properties.Settings.Default.Host;
            string database = Properties.Settings.Default.DB;
            string username = Properties.Settings.Default.User;
            string password = Properties.Settings.Default.Pass;

            return DBSqlConnect.GetDBConnection(datasource, database, username, password);
        }
    }
}
