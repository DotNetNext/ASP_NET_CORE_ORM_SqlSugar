using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Collections;
using System.IO;

namespace SqlSugar
{
    /// <summary>
    /// ** 描述：类型转换
    /// ** 创始时间：2015-6-2
    /// ** 修改时间：-
    /// ** 作者：sunkaixuan
    /// ** 使用说明：http://www.cnblogs.com/sunkaixuan/p/4548028.html
    /// </summary>
    internal static class TypeParseExtenions
    {
        #region 强转成GUID 如果失败返回 0
        /// <summary>
        /// 强转成GUID 如果失败返回 GUID.EMPTY
        /// </summary>
        /// <param name="thisValue"></param>
        /// <returns></returns>
        public static Guid TryToGuid(this object thisValue)
        {
            Guid reval = Guid.Empty;
            if (thisValue != null && Guid.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return reval;
        }
        #endregion
        #region 强转成bool 如果失败返回 0
        /// <summary>
        /// 强转成bool 如果失败返回 false
        /// </summary>
        /// <param name="thisValue"></param>
        /// <returns></returns>
        public static bool TryToBoolean(this object thisValue)
        {
            bool reval = false;
            if (thisValue != null && Boolean.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return reval;
        }
        #endregion
        #region 强转成int 如果失败返回 0
        /// <summary>
        /// 强转成int 如果失败返回 0
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int TryToInt(this object thisValue)
        {
            int reval = 0;
            if (thisValue != null && int.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return reval;
        }
        #endregion
        #region 强转成int 如果失败返回 errorValue
        /// <summary>
        /// 强转成int 如果失败返回 errorValue
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int TryToInt(this object thisValue, int errorValue)
        {
            int reval = 0;
            if (thisValue != null && int.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return errorValue;
        }
        #endregion
        #region 强转成double 如果失败返回 0
        /// <summary>
        /// 强转成money 如果失败返回 0
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static double TryToMoney(this object thisValue)
        {
            double reval = 0;
            if (thisValue != null && double.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return 0;
        }
        #endregion
        #region 强转成double 如果失败返回 errorValue
        /// <summary>
        /// 强转成double 如果失败返回 errorValue
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="errorValue"></param>
        /// <returns></returns>
        public static double TryToMoney(this object thisValue, double errorValue)
        {
            double reval = 0;
            if (thisValue != null && double.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return errorValue;
        }
        #endregion
        #region 强转成string 如果失败返回 ""
        /// <summary>
        /// 强转成string 如果失败返回 ""
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string TryToString(this object thisValue)
        {
            if (thisValue != null) return thisValue.ToString().Trim();
            return "";
        }
        #endregion
        #region  强转成string 如果失败返回 errorValue
        /// <summary>
        /// 强转成string 如果失败返回 str
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="errorValue"></param>
        /// <returns></returns>
        public static string TryToString(this object thisValue, string errorValue)
        {
            if (thisValue != null) return thisValue.ToString().Trim();
            return errorValue;
        }
        #endregion
        #region 强转成Decimal 如果失败返回 0
        /// <summary>
        /// 强转成Decimal 如果失败返回 0
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Decimal TryToDecimal(this object thisValue)
        {
            Decimal reval = 0;
            if (thisValue != null && decimal.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return 0;
        }
        #endregion
        #region 强转成Decimal 如果失败返回 errorValue
        /// <summary>
        /// 强转成Decimal 如果失败返回 errorValue
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="errorValue"></param>
        /// <returns></returns>
        public static Decimal TryToDecimal(this object thisValue, decimal errorValue)
        {
            Decimal reval = 0;
            if (thisValue != null && decimal.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return errorValue;
        }
        #endregion
        #region 强转成DateTime 如果失败返回 DateTime.MinValue
        /// <summary>
        /// 强转成DateTime 如果失败返回 DateTime.MinValue
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static DateTime TryToDate(this object thisValue)
        {
            DateTime reval = DateTime.MinValue;
            if (thisValue != null && DateTime.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return reval;
        }
        #endregion
        #region 强转成DateTime 如果失败返回 errorValue
        /// <summary>
        /// 强转成DateTime 如果失败返回 errorValue
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="errorValue"></param>
        /// <returns></returns>
        public static DateTime TryToDate(this object thisValue, DateTime errorValue)
        {
            DateTime reval = DateTime.MinValue;
            if (thisValue != null && DateTime.TryParse(thisValue.ToString(), out reval))
            {
                return reval;
            }
            return errorValue;
        }
        #endregion

    }
}
