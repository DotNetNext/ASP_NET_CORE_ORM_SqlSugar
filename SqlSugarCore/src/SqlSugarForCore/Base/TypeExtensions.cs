using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
namespace SqlSugar
{
    public static class TypeExtensions
    {
        public static PropertyInfo[] GetProperties(this Type type)
        {
            var reval = type.GetTypeInfo().GetProperties();
            return reval;
        }
        public static PropertyInfo GetProperty(this Type type, string name)
        {
            var reval = type.GetTypeInfo().GetProperty(name);
            return reval;
        }

        public static FieldInfo GetField(this Type type, string name)
        {
            var reval = type.GetTypeInfo().GetField(name);
            return reval;
        }

        public static bool IsEnum(this Type type)
        {
            var reval = type.GetTypeInfo().IsEnum;
            return reval;
        }

        public static MethodInfo GetMethod(this Type type, string name)
        {
            var reval = type.GetTypeInfo().GetMethod(name);
            return reval;
        }
        public static MethodInfo GetMethod(this Type type, string name, Type[] types)
        {
            var reval = type.GetTypeInfo().GetMethod(name, types);
            return reval;
        }
        public static ConstructorInfo GetConstructor(this Type type, Type[] types)
        {
            var reval = type.GetTypeInfo().GetConstructor(types);
            return reval;
        }
    }
}
