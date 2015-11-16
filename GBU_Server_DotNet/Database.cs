using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GBU_Server_DotNet
{
    class Database
    {
        public struct CameraItem
        {
            public int no;
            public string name;
            public string id;
            public string pwd;
            public string url;
        }

        public Database()
        {
            
        }

        public int GetCameraList()
        {
            return 0;
        }

        public int InsertCamera(string name, string id, string pwd, string url)
        {
            return 0;
        }

        public int DeleteCamera(int no)
        {
            return 0;
        }


    }
}
