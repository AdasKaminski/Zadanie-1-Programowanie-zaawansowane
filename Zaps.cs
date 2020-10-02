using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt
{
    public class Zapis : ISerializacja
    {
        XmlSerializer Zapisz = new XmlSerializer(typeof(List<Dane>));

        public void Serializacja(List<Dane> Dane)
        {
            try
            {
                using (TextWriter zapisz = new StreamWriter(@"./dane.xml"))
                {
                    Zapisz.Serialize(zapisz, Dane);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
