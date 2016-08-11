using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SqlSugar;
namespace SqlSugarTest.Demos
{
    public class CreateClass : IDemos
    {
        public void Init()
        {
            using (var db = SugarDao.GetInstance())
            {

                //根据当前数据库生成所有表的实体类文件 （参数：SqlSugarClient ，文件目录，命名空间）
                db.ClassGenerating.CreateClassFiles(db,@"D:\SqlSugarModelFiles2","Models");
                //根据表名生成实体类文件
                //db.ClassGenerating.CreateClassFilesByTableNames(db, Server.MapPath("~/Models"), "Models" , "student","school");

                //根据表名生成class字符串
                var str = db.ClassGenerating.TableNameToClass(db, "Student");

                //根据SQL语句生成class字符串
                var str2 = db.ClassGenerating.SqlToClass(db, "select top 1 * from Student", "student");
            }
        }
    }
}
