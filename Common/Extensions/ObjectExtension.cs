using System.Linq;

namespace Common.Extensions
{
    public static class ObjectExtension
    {
        public static string ToStringLinq(this object o)
        {
            return string.Join(",", (from p in o.GetType().GetProperties()
                select string.Format("{0}{1}{2}", p.Name, '=', p.GetValue(o, null))));
        }
    }
}
