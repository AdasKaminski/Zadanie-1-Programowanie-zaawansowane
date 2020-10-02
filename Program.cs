using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        enum Menu
        {
            dodaj_użytkownika_i_adres = 1,
            modyfikuj_dane_użytkownika_i_adres,
            usuń_użytkownika_i_adres,
            wczytaj,
            wyloguj
        };
        static void Main(string[] args)
        {
            Dane dodawanie = new Dane();
            ISerializacja Serializacja = new Zapis();


            bool k = true;
            while (k)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                int i = 1;

                foreach (Menu menu in (Menu[])Enum.GetValues(typeof(Menu)))
                {
                    Console.Write($"[{i++}]. ");
                    Console.WriteLine(String.Concat(menu.ToString().Replace('_', ' ')));
                }

                Menu start;
                string choosenOption = Console.ReadLine().Replace(' ', '_');
                bool MenuConfirmed = Enum.TryParse<Menu>(choosenOption, out start);

                if (!MenuConfirmed)
                {
                    Console.WriteLine("Wybrałeś niepoprawną opcję");
                }

                switch (start)
                {
                    case Menu.dodaj_użytkownika_i_adres:
                      
                        Serializacja.Serializacja(dodawanie.AddDane());

                        break;
                    case Menu.usuń_użytkownika_i_adres:
                        Dane usuwanie = new Dane();
                        usuwanie.UsunDane();


                        break;

                    case Menu.modyfikuj_dane_użytkownika_i_adres:
                        Dane modyfikacja = new Dane();
                        modyfikacja.UsunDane();

                        Serializacja.Serializacja(dodawanie.AddDane());

                        break;
                    case Menu.wczytaj:
                        Deserializacja deserializacja = new Deserializacja();
                        deserializacja.wczytawanie().ForEach(Console.WriteLine);
                        Console.ReadKey();
                        
                        break;
                    case Menu.wyloguj:

                        k = false;
                        break;

                }
            }
        }
    }
}
