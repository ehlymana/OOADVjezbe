using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CVMaker cvMaker = new CVMaker();
            cvMaker.napraviCV("Ime", "Prezime", "UNSA", "Inžinjer elektrotehnike");

            Console.Out.WriteLine("-----Prva obrada-----");
            cvMaker.proslijediDalje();
            cvMaker.obradi();
            CV cv = cvMaker.Cv;
            Console.Out.WriteLine("Trenutni CV: " + cv.Ime + ", " + cv.Prezime + ", " + cv.MjestoStanovanja + ", "
                + cv.Univerzitet + ", " + cv.Rating + ", " + cv.Fakultet + ", " + cv.Zanimanje + ", " + cv.Slika);

            Console.Out.WriteLine("-----Druga obrada-----");
            cvMaker.proslijediDalje();
            cvMaker.obradi();
            cv = cvMaker.Cv;
            Console.Out.WriteLine("Trenutni CV: " + cv.Ime + ", " + cv.Prezime + ", " + cv.MjestoStanovanja + ", "
                + cv.Univerzitet + ", " + cv.Rating + ", " + cv.Fakultet + ", " + cv.Zanimanje + ", " + cv.Slika);

            Console.Out.WriteLine("-----Treća obrada-----");
            cvMaker.proslijediDalje();
            cvMaker.obradi();
            cv = cvMaker.Cv;
            Console.Out.WriteLine("Trenutni CV: " + cv.Ime + ", " + cv.Prezime + ", " + cv.MjestoStanovanja + ", "
                + cv.Univerzitet + ", " + cv.Rating + ", " + cv.Fakultet + ", " + cv.Zanimanje + ", " + cv.Slika);
        }
    }
}
