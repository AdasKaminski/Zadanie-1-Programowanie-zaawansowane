using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt
{
    [Serializable]
    [XmlRoot("Dane")]
    public class Dane
    {
        private string imie;
        private string nazwisko;
        private string plec;
        private Adres adres;

        public Dane()
        { }

        public Dane(string imie, string nazwisko, string plec, Adres adres)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.plec = plec;
            this.adres = adres;
        }

        [XmlAttribute("Imie")]
        public string Imie { get => imie; set => imie = value; }
        [XmlAttribute("Nazwiko")]
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        [XmlAttribute("Plec")]
        public string Plec { get => plec; set => plec = value; }

        [XmlElement("Adres")]
        public Adres Adres { get => adres; set => adres = value; }

        public static List<Dane> ListAddDane = new List<Dane>();
        public List<Dane> AddDane()
        {
            Deserializacja odczyt = new Deserializacja();

           

            List<Adres> listAdres = new List<Adres>();
            
          

            ListAddDane = odczyt.wczytawanie();

            Console.WriteLine("Wprowadź Imię");
            string imiedane = Console.ReadLine();
            Console.WriteLine("Wprowadź Nazwisko");
            string nazwiskodane = Console.ReadLine();
            Console.WriteLine("Wprowadź płeć wzór(K/M/N)");
            string plecdane = Console.ReadLine();
            Console.WriteLine("Wprowadź miejscowosc");
            string miejscowoscadres = Console.ReadLine();
            Console.WriteLine("Wprowadź ulice");
            string ulicaadres = Console.ReadLine();
            Console.WriteLine("Wprowadź kod pocztowy");
            string kodadres = Console.ReadLine();
            Console.WriteLine("Wprowadź numer domu");
            string numeradres = Console.ReadLine();

            Adres adreslisty = new Adres(miejscowoscadres, ulicaadres,numeradres,kodadres);

            Dane dane = new Dane(imiedane, nazwiskodane, plecdane,adreslisty);
            ListAddDane.Add(dane);


            return ListAddDane;

        }
        public List<Dane> UsunDane()
        {
            Console.Clear();
            Console.WriteLine("Podaj imie");
            string imie = Console.ReadLine(); 

            
            for (int i = 0; i < ListAddDane.Count; i++)
            {
                if (ListAddDane[i].Imie == imie)
                {
                    ListAddDane.RemoveAt(i);
                    Console.Clear();
                    Console.WriteLine("Użytkownik został usunięty");
                    
                    Console.Clear();
                    return ListAddDane;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Podane imie nie istnieje");
                   
                    Console.Clear();
                }
            }
            return ListAddDane;
        }

        public override string ToString()
        {
            return $"\n Dane \n Imię:{Imie} \n Nazwisko: {Nazwisko} \n Płeć: {Plec} \n Adres: {Adres}";
        }
       
    }
}
