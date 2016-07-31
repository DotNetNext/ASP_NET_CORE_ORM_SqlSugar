using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SqlSugar;
namespace SqlSugarTest.Demos
{
    public class SugarDao
    {
        public static SqlSugarClient GetInstance()
        {
        
                return new SqlSugarClient("server=.;uid=sa;pwd=sasa;database=SqlSugarTest");
        }
    }
}
