using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Projekt
{
    [Serializable]
    [XmlRoot("Adres")]
    public class Adres
    {
        private string miasto;
        private string ulica;
        private string numer;
        private string kod;
        [XmlAttribute("miasto")]
        public string Miasto { get => miasto; set => miasto = value; }
        [XmlAttribute("ulica")]
        public string Ulica { get => ulica; set => ulica = value; }
        [XmlAttribute("numer")]
        public string Numer { get => numer; set => numer = value; }
        [XmlAttribute("kod")]
        public string Kod { get => kod; set => kod = value; }

       

        public Adres()
        { }

        public Adres(string miasto, string ulica, string numer, string kod)
        {
            this.miasto = miasto;
            this.ulica = ulica;
            this.numer = numer;
            this.kod = kod;
        }

        public override string ToString()
        {
            return $"\nmiejscowosc: {Miasto} \n Ulica: {Ulica} \n Numer: {Numer} \n Kod pocztowy: {Kod}";
        }
       

    }

}
