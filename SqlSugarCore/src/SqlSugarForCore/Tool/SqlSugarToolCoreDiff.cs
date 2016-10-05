using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SqlSugar
{
    /// <summary>
    /// SqlSugarTool局部类与Core有差异的部分(方便工具移植到.NetCore版本)
    /// </summary>
    public partial class SqlSugarTool
    {
        private static void FillValueTypeToDictionary<T>(Type type, IDataReader dr, List<T> strReval)
        {
            using (IDataReader re = dr)
            {
                Dictionary<string, string> reval = new Dictionary<string, string>();
                while (re.Read())
                {
                    if (SqlSugarTool.DicOO == type)
                    {
                        var kv = new KeyValuePair<object, object>(dr.GetValue(0), re.GetValue(1));
                        strReval.Add((T)Convert.ChangeType(kv, typeof(KeyValuePair<object, object>)));
                    }
                    else if (SqlSugarTool.Dicii == type)
                    {
                        var kv = new KeyValuePair<int, int>(dr.GetValue(0).ObjToInt(), re.GetValue(1).ObjToInt());
                        strReval.Add((T)Convert.ChangeType(kv, typeof(KeyValuePair<int, int>)));
                    }
                    else if (SqlSugarTool.DicSi == type)
                    {
                        var kv = new KeyValuePair<string, int>(dr.GetValue(0).ObjToString(), re.GetValue(1).ObjToInt());
                        strReval.Add((T)Convert.ChangeType(kv, typeof(KeyValuePair<string, int>)));
                    }
                    else if (SqlSugarTool.DicSo == type)
                    {
                        var kv = new KeyValuePair<string, object>(dr.GetValue(0).ObjToString(), re.GetValue(1));
                        strReval.Add((T)Convert.ChangeType(kv, typeof(KeyValuePair<string, object>)));
                    }
                    else if (SqlSugarTool.DicSS == type)
                    {
                        var kv = new KeyValuePair<string, string>(dr.GetValue(0).ObjToString(), dr.GetValue(1).ObjToString());
                        strReval.Add((T)Convert.ChangeType(kv, typeof(KeyValuePair<string, string>)));
                    }
                    else
                    {
                        Check.Exception(true, "暂时不支持该类型的Dictionary 你可以试试 Dictionary<string ,string>或者联系作者！！");
                    }
                }
            }
        }
        private static void FillValueTypeToArray<T>(Type type, IDataReader dr, List<T> strReval)
        {
            using (IDataReader re = dr)
            {
                int count = dr.FieldCount;
                var childType = type.GetElementType();
                while (re.Read())
                {
                    object[] array = new object[count];

                    if (childType == SqlSugarTool.StringType)
                        strReval.Add((T)Convert.ChangeType(array.Select(it => it.ObjToString()).ToArray(), type));
                    else if (childType == SqlSugarTool.ObjType)
                        strReval.Add((T)Convert.ChangeType(array.Select(it => it).ToArray(), type));
                    else if (childType == SqlSugarTool.BoolType)
                        strReval.Add((T)Convert.ChangeType(array.Select(it => it.ObjToBool()).ToArray(), type));
                    else if (childType == SqlSugarTool.ByteType)
                        strReval.Add((T)Convert.ChangeType(array.Select(it => (byte)it).ToArray(), type));
                    else if (childType == SqlSugarTool.DecType)
                        strReval.Add((T)Convert.ChangeType(array.Select(it => it.ObjToDecimal()).ToArray(), type));
                    else if (childType == SqlSugarTool.GuidType)
                        strReval.Add((T)Convert.ChangeType(array.Select(it => Guid.Parse(it.ObjToString())).ToArray(), type));
                    else if (childType == SqlSugarTool.DateType)
                        strReval.Add((T)Convert.ChangeType(array.Select(it => it.ObjToDate()).ToArray(), type));
                    else if (childType == SqlSugarTool.IntType)
                        strReval.Add((T)Convert.ChangeType(array.Select(it => it.ObjToInt()).ToArray(), type));
                    else
                        Check.Exception(true, "暂时不支持该类型的Array 你可以试试 object[] 或者联系作者！！");
                }
            }
        }

        /// <summary>
        /// 获取参数到键值集合根据页面Request参数
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> GetParameterDictionary(bool isNotNullAndEmpty = false)
        {
            throw new SqlSugarException("Core版枯不支持该函数");
        }

        /// <summary>
        /// 获取参数到键值集合根据页面Request参数
        /// </summary>
        /// <returns></returns>
        public static SqlParameter[] GetParameterArray(bool isNotNullAndEmpty = false)
        {
            throw new SqlSugarException("Core版枯不支持该函数");
        }
    }
}
