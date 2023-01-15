using System.Windows.Forms;
using System.Data.OleDb;

namespace GestaoSEGSAL.DAO
{
    class ConnectionFactory
    {
        static public string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\db_gestao_segsal.accdb;" + "jet oledb:database password=190112;";

        OleDbConnection conn = new OleDbConnection();

        public ConnectionFactory()
        {
            conn.ConnectionString = strConn;
        }

        public OleDbConnection ToConnect()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void ToDisconnect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}

