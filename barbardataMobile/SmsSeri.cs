using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace barbardataMobile
{
    [Serializable]
    [XmlTypeAttribute(Namespace = "barbardata")]
    public class SmsSeri
    {
        [XmlIgnore()]
        private string _Message;
        [XmlIgnore()]
        private string _To;
        [XmlIgnore()]
        private string _From;

        [XmlElementAttribute("sms-message", DataType = "string", IsNullable = true)]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
        [XmlElementAttribute("sms-recipient", DataType = "string", IsNullable = true)]
        public string To
        {
            get { return _To; }
            set { _To = value; }
        }
        [XmlElementAttribute("sms-from", DataType = "string", IsNullable = true)]
        public string From
        {
            get { return _From; }
            set { _From = value; }
        }


    }
}
