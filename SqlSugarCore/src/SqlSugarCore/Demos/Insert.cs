using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlSugarTest.Demos
{
    public class Insert : IDemos
    {
        public void Init()
        {
            using (SqlSugarClient db = SugarDao.GetInstance())//开启数据库连接
            {
                Student s = new Student()
                {
                    name = "张" + new Random().Next(1, int.MaxValue)
                };

                db.Insert(s); //插入一条记录 (有主键也好，没主键也好，有自增列也好都可以插进去)


                List<Student> list = new List<Student>()
                {
                     new Student()
                {
                     name="张"+new Random().Next(1,int.MaxValue)
                },
                 new Student()
                {
                     name="张"+new Random().Next(1,int.MaxValue)
                }
                };

                db.InsertRange(list); //批量插入
            }
        }
    }
}
