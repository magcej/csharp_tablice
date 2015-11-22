using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tablice
{


    class Program
    {
        static void Main(string[] args)
        {


            //tu testujesz kod, zakładamy, że tablica składa się z elementów nieujemnych
            //watość -1 pełni specjalne znaczenie
            uint[] tab = { 1, 4, 3, 2, 1, 9, 5, 2, 8, 0, 2, 1, 4, 6, 7 };


            Console.WriteLine("Czy jest 7? {0}", czyJest(tab, 7));
            Console.WriteLine("Czy jest 12? {0}", czyJest(tab, 12));

            //wypelnij(tab, 7);
            uint[] tab1 = { 1, 2, 3 };
            uint[] tab2 = { 1, 2, 3 };
            uint[] tab3 = { 1, 2, 4 };
            Console.WriteLine(equal(tab1, tab));


            Console.WriteLine(wypiszDoString(tab));

            Console.WriteLine("Gdzie jest {0} ma byc 5", gdzieJest(tab, 9));

            Console.WriteLine("Bedzie {0} wystapien", ileWystąpien(tab, 2));

            uint[] prosta = { 1, 2, 3, 4, 5 };
            odwroc(prosta);
            Console.WriteLine("Tablica w odwrotnej kolejnosci {0}", wypiszDoString(prosta));

            uint[] klon = klonuj(prosta);
            Console.WriteLine("Tablica sklonowana: {0}", wypiszDoString(klon));

            uint najmniejszy = minimum(prosta);
            Console.WriteLine("Minimum to {0}", najmniejszy);

            Console.WriteLine("Indeks minimum to {0}", indexMinimum(prosta));
            Console.WriteLine("Suma elementow wynosi {0}", suma(prosta));
            Console.WriteLine("Srednia elementow wynosi {0}", sredniaArytmetyczna(prosta));
            Console.WriteLine("Mediana {0}", mediana(prosta));

            uint[] parzysta = { 6, 5, 4, 2, 3, 1 };
            Console.WriteLine("Mediana parzystej tablicy {0}", mediana(parzysta));

            uint[] doModalnej = { 2, 3, 1, 4, 3, 2, 3, 5 };
            Console.WriteLine("Moda {0}", modalna(doModalnej));

            uint[] brakMody = { 1, 2, 3, 1, 2, 3 };
            Console.WriteLine("Brak modalnej {0}", modalna(brakMody));

        }

        ///////////////////////////////////////////////

        /// <summary>
        /// Wypełnia tablicę zadaną wartością
        /// </summary>
        /// <param name="a"> tablica, niepusta</param>
        /// <param name="wartosc">zadana wartość, którą wypełniona będzie tablica</param>
        public static void wypelnij(uint[] a, uint wartosc)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                a[i] = wartosc;
            }

            /*# uzupełnij/popraw kod */
        } //koniec wypelnij



        /// <summary>
        /// zwraca tablicę (w postaci string) zamieszczając jej elementy w nawiasie [ ... ] oddzielone przecinkami
        /// </summary>
        /// <param name="a">tablica niepusta</param>
        /// <returns>reprezentacja tablicy w postaci string</returns>
        public static string wypiszDoString(uint[] a)
        {
            String str = "[";
            foreach (uint liczba in a)
            {
                str = str + liczba.ToString();
                str = str + " ";
            }
            str = str + "]";
            return str;
        } //koniec wypiszDoString()


        /// <summary>
        /// Porównuje dwie tablice.
        /// </summary>
        /// <param name="a">pierwsza tablica do porównania</param>
        /// <param name="b">druga tablica do porównania</param>
        /// <returns>true - gdy tablice są takiego samego rozmiaru i zawierają te same elementy na tych samych miejscach; 
        ///          false w przeciwnym przypadku</returns>
        public static bool equal(uint[] a, uint[] b)
        {
            return a.SequenceEqual(b);
        } //koniec equal()



        /// <summary>
        /// Sprawdza, czy dany klucz jest w tablicy.
        /// </summary>
        /// <param name="a">tablica</param>
        /// <param name="klucz">poszukiwana wartość</param>
        /// <returns>true - jeśli poszukiwany klucz występuje w tablicy; false - w przeciwnym przypadku.</returns>
        public static bool czyJest(uint[] a, uint klucz)
        {
            int indeks = Array.IndexOf(a, klucz);
            return (indeks >= 0);

        }//koniec czyJest()


        /// <summary>
        /// Sprawdza, gdzie jest (indeks) dany klucz w tablicy. Jeśli nie ma, zwraca -1.
        /// </summary>
        /// <param name="a">tablica</param>
        /// <param name="klucz">poszukiwana wartość</param>
        /// <returns>indeks pierwszego wystąpienia poszukiwanego elementu; -1 jeśli nie występuje.</returns>
        public static int gdzieJest(uint[] a, uint klucz)
        {
            return Array.IndexOf(a, klucz);


            /*# uzupełnij/popraw kod */

        } //koniec gdzieJest()


        /// <summary>
        /// Zlicza liczbę wystąpień zadanego klucza w tablicy. Jeśli nie ma, zwraca -1.
        /// </summary>
        /// <param name="a">tablica</param>
        /// <param name="klucz">poszukiwana wartość</param>
        /// <returns>liczba wystąpień klucza w tablicy lub -1, jeśli klucz nie występuje</returns>
        public static int ileWystąpien(uint[] a, uint klucz)
        {
            int licznik = 0;
            foreach (uint x in a)
            {
                if (x == klucz)
                {
                    licznik++;
                }
            }


            /*# uzupełnij/popraw kod */
            return licznik;

        }//koniec ileWystąpien()



        /// <summary>
        /// Odwraca tablicę: pierwszy staje się ostatnim, drugi - przedostatnim, ...
        /// </summary>
        /// <param name="a">tablica</param>
        public static void odwroc(uint[] a)
        {
            int poczatek = 0;
            int koniec = a.Length - 1;

            while (poczatek < koniec)
            {
                uint pomoc = a[poczatek];
                a[poczatek] = a[koniec];
                a[koniec] = pomoc;
                poczatek++;
                koniec--;
            }

        } //koniec odwróć()    


        /// <summary>
        /// Tworzy duplikat tablicy zadanej jako argument.
        /// </summary>
        /// <param name="a">tablica dana, niepusta</param>
        /// <returns>sklonowana tablica</returns>
        public static uint[] klonuj(uint[] a)
        {
            uint[] b = new uint[a.Length];// new uint[a.Length]
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }



            return b;
        }//koniec klonuj()


        /// <summary>
        /// Wyznacza minimalną wartość w tablicy
        /// </summary>
        /// <param name="a">tablica niepusta</param>
        /// <returns>wartość minimalna w tablicy</returns>
        public static uint minimum(uint[] a)
        {
            return a.Min();
        }//koniec minimum()


        /// <summary>
        /// Wyznacza indeks elementu minimalnego tablicy
        /// </summary>
        /// <param name="a">tablica niepusta</param>
        /// <returns>indeks minimalnego elementu tablicy</returns>
        public static int indexMinimum(uint[] a)
        {

            return Array.IndexOf(a, a.Min());
        }//koniec minimum()


        /// <summary>
        /// Oblicza sumę wszystkich elementów tablicy.
        /// </summary>
        /// <param name="a">tablica niepusta</param>
        /// <returns>suma elementów tablicy</returns>
        public static uint suma(uint[] a)
        {
            uint suma = 0;
            foreach (uint element in a)
            {
                suma += element;
            }
            return suma;
        } //koniec suma()


        /// <summary>
        /// Oblicza średnią arytmetyczną elementów tablicy.
        /// </summary>
        /// <param name="a">tablica</param>
        /// <returns>średnia arytmetyczna elementów tablicy</returns>
        public static double sredniaArytmetyczna(uint[] a)
        {
            uint s = suma(a);
            return s / a.Length;

        }//koniec sredniaArytmetyczna()



        /// <summary>
        /// Wyznacza medianę liczb w tablicy
        /// </summary>
        /// <param name="a">tablica niepusta</param>
        /// <returns>mediana (watość środkowa w tablicy posorowanej): https://pl.wikipedia.org/wiki/Mediana </returns>
        public static double mediana(uint[] a)
        {
            uint[] b = klonuj(a); //nie chcemy zniszczyc tablicy a[]
            Array.Sort<uint>(b);  //sortujemy kopię tablicy

            if (a.Length % 2 == 0)
            {
                // Parzysta długość
                int prawySrodkowy = a.Length / 2;
                int lewySrodkowy = prawySrodkowy - 1;

                return (b[lewySrodkowy] + b[prawySrodkowy]) / 2.0;
            }
            else
            { // Nieparzysta długość
                int srodkowy = ((a.Length + 1) / 2) - 1;
                return b[srodkowy];
            }

            return (double)-1;
        }//koniec mediana()



        /// <summary>
        /// Modalna, dominanta (wartość występująca najczęściej)
        /// </summary>
        /// <param name="a">tablica</param>
        /// <returns>modalna, lub -1 jeśli nie wystepuje</returns>
        public static int modalna(uint[] a)
        {
            /*# uzupełnij/popraw kod */
            uint[] wystapienia = new uint[a.Length];
            Array.Clear(wystapienia, 0, wystapienia.Length);

            for (int i = 0; i < a.Length; i++)
            {
                int pozycja = gdzieJest(a, a[i]);
                wystapienia[pozycja]++;
            }

            uint maxWys = wystapienia.Max();
            int indexMaxWys = Array.IndexOf(wystapienia, maxWys);
            int ostatniMaxWys = Array.LastIndexOf(wystapienia, maxWys);

            if (indexMaxWys != ostatniMaxWys)
            {
                return -1;
            }

            return (int)a[indexMaxWys];
        }//koniec mediana()
    }





}
