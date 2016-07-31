using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Collections;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace SqlSugar
{
    /// <summary>
    /// 作者：sunkaixaun
    /// </summary>
    public class JsonConverter
    {
        /// <summary>
        /// dataTable转成JSON
        /// add sunkaixuan 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static string DataTableToJson(DataTable table)
        {
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            foreach (DataRow row in table.Rows)
            {
                Dictionary<string, object>  childRow = new Dictionary<string, object>();
                foreach (DataColumn col in table.Columns)
                {
                    childRow.Add(col.ColumnName, row[col.ColumnName]);
                }
                parentRow.Add(childRow);
            }
            return JsonConvert.SerializeObject(parentRow);
        }

        public static string DataTableToJson(DataTable table, string dateFormat)
        {
            var reval = DataTableToJson(table);
            if (dateFormat.IsNullOrEmpty()) return reval;
            reval = Regex.Replace(reval, @"\\/Date\((\d+)\)\\/", match =>
            {
                DateTime dt = new DateTime(1970, 1, 1);
                dt = dt.AddMilliseconds(long.Parse(match.Groups[1].Value));
                dt = dt.ToLocalTime();
                return dt.ToString(dateFormat);
            });
            return reval;
        }


        /// <summary>
        /// json转换object动态类
        /// add duk by 2016-05-19
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static dynamic ConvertJson(string json)
        {
            var dy=JsonConvert.DeserializeObject<dynamic>(json);
            return dy;
        }

    }
}
