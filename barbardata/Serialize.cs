using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace barbardata
{
    public class Serialize
    {
        public static byte[] Object2ByteArray(object o, Type t)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                XmlSerializer xmls = new XmlSerializer(t);
                xmls.Serialize(ms, o);
                return ms.ToArray();
            }
            catch { return null; }
        }

        public static object ByteArray2Object(byte[] b, Type t)
        {
            try
            {
                MemoryStream ms = new MemoryStream(b);
                XmlSerializer xmls = new XmlSerializer(t);
                ms.Position = 0;
                return xmls.Deserialize(ms);
            }
            catch (Exception e)
            { return null; }
        }
    }
}
