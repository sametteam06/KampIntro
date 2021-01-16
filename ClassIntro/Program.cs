using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Samet";
            int yas = 26;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Python";
            kurs1.Egitmen = "Gamze";
            kurs1.IzlenmeOrani = 60;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Samet";
            kurs2.IzlenmeOrani = 60;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen);
                Console.WriteLine(kurs.KursAdi);

            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani{ get; set; }

    }
}
