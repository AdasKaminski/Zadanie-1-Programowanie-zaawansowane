using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Projekt
{
    class Deserializacja
    {
        XmlSerializer odczyt = new XmlSerializer(typeof(List<Dane>));
        List<Dane> nowaLista = new List<Dane>();
        public List<Dane> wczytawanie()
        {

            try
            {
                using (TextReader wczytywaniedoListy = new StreamReader(@"./dane.xml"))
                {
                    var obj = odczyt.Deserialize(wczytywaniedoListy);
                    nowaLista = (List<Dane>)obj;
               }
            
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            return nowaLista;
        }

    }
}
