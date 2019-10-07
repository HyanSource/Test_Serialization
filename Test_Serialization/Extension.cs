using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


static class Extension
{
    /// <summary>
    /// 序列化泛型
    /// </summary>
    public static string Ser<T>(this T obj) where T : class
    {
        XmlSerializer xs = new XmlSerializer(obj.GetType());

        using (StringWriter stringWeiter = new StringWriter())
        {
            using (XmlWriter writer = XmlWriter.Create(stringWeiter))
            {
                xs.Serialize(writer, obj);
                return stringWeiter.ToString();
            }
        }
    }

    public static void DeSer<T>(this string xmlmsg, out T result) where T : class
    {
        XmlSerializer xdes = new XmlSerializer(typeof(T));

        using (StringReader reader = new StringReader(xmlmsg))
        {
            object desobj = xdes.Deserialize(reader);
            result = (T)desobj;
        }
    }
}

