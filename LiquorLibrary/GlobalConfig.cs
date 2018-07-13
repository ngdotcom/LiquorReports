using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LiquorLibrary.DataAccess;

namespace LiquorLibrary
{
    public static class GlobalConfig
    {
        public const string LiquorFile = "LiquorReport.csv";

        public static IDataConnection Connections { get; private set; }

        public static void InitializeConnections (DatabaseType db)
        {
            if (db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connections = text;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManger.ConnectionStrings[name].ConnectionString;
        }
    }
}
