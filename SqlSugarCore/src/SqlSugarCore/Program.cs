using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SqlSugar;
using SqlSugarTest.Demos;

namespace SqlSugarTest
{
    public class Program
    {
        public static void Main(string[] args)
        {

            using (SqlSugarClient db = new SqlSugarClient("server=.;uid=sa;pwd=sasa;database=SqlSugarTest"))
            {
                var dt= db.GetDataTable("select * from student where id=@id", new { id = 1 });

                string switch_on = "Select";
                IDemos demo = null;
                switch (switch_on)
                {
                    //ADO.NET基本功能
                    case "Ado": demo = new Ado(); break;
                    case "Select": demo = new Select(); break;
                }

                demo.Init();
            }
        }
    }
}
