using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace KIEMSOAT_RAVAO
{
    class ConfigKetNoi
    {
        public static OracleConnection GetDBConnection()
        {
            string host = "172.16.9.7";
            int port = 1521;
            string sid = "ORCL";
            string user = "QCU_RS";
            string password = "QCU_RS";
            return ketnoi.GetDBConnection(host, port, sid, user, password);
        }
    }
}
