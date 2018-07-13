using LiquorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiquorLibrary.DataAccess;
using System.Data;
using Dapper;

namespace LiquorLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        private const string db = "CRELiquorStory";

        public List<LiquorModel> GetLiquor_All()
        {
            List<LiquorModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<LiquorModel>("dbo.spGetInventory_Liquor").ToList();

                foreach (LiquorModel lm in output)
                {
                    var l = new DynamicParameters();
                    l.Add("@CreateDate", lm.CreateStartDate);
                    l.Add("@CreateDate", lm.CreateEndDate);

                    
                }
            }
            return output;
        }
        
    }
}
