using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SqlSugar;
namespace SqlSugarTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
   
            using (SqlSugarClient db = new SqlSugarClient("server=.;uid=sa;pwd=sasa;database=SqlSugarTest")) {
               var dt=  db.GetDataTable("select * from School");
               var dataTable = db.Sqlable().From<School>("s").SelectToDataTable("*");
               dynamic dy = db.Sqlable().From<School>("s").SelectToDynamic("*");

               var list=  db.Queryable<Student>().Where(it => it.id == 1).ToList();

            }
        }
    }
}
