using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiquorLibrary.Models;

namespace LiquorLibrary.DataAccess
{
    public interface IDataConnection
    {
        List<LiquorModel> GetLiquor_All();
    }
}
