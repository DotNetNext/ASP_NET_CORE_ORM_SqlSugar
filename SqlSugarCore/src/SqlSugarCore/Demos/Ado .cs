using Models;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlSugarTest.Demos
{
    public class Ado:IDemos
    {
        public void Init()
        {
            using (SqlSugarClient db = SugarDao.GetInstance())//开启数据库连接
            {
                var r1 = db.GetDataTable("select * from student");
                var r2 = db.GetSingle<Student>("select top 1 * from student");
                var r3 = db.GetScalar("select  count(1) from student");
                var r4 = db.GetReader("select  count(1) from student");
                r4.Dispose();
                var r5 = db.GetString("select  top 1 name from student");
                var r6 = db.ExecuteCommand("select 1");
            }
        }

    }
}
