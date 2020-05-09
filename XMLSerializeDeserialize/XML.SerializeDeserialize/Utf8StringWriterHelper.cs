using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML.SerializeDeserialize
{
    public class Utf8StringWriterHelper : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
