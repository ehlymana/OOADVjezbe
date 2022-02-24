using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CVMaker cvMaker = new CVMaker();
            cvMaker.napraviCV("Ime i Prezime", "UNSA", "Inžinjer elektrotehnike");

            CV cv = cvMaker.Cv;
            Console.Out.WriteLine("-----Prije obrade-----");
            Console.Out.WriteLine("Trenutni CV: " + cv.ImeIPrezime + ", " + cv.MjestoStanovanja + ", " + cv.Zanimanje
                 + ", " + cv.Univerzitet + ", " + cv.Rating + ", " + cv.Fakultet);

            Console.Out.WriteLine("-----Prva obrada-----");
            cvMaker.proslijediDalje();
            cvMaker.obradi();
            cv = cvMaker.Cv;
            Console.Out.WriteLine("Trenutni CV: " + cv.ImeIPrezime + ", " + cv.MjestoStanovanja + ", " + cv.Zanimanje
                 + ", " + cv.Univerzitet + ", " + cv.Rating + ", " + cv.Fakultet);

            Console.Out.WriteLine("-----Druga obrada-----");
            cvMaker.proslijediDalje();
            cvMaker.obradi();
            cv = cvMaker.Cv;
            Console.Out.WriteLine("Trenutni CV: " + cv.ImeIPrezime + ", " + cv.MjestoStanovanja + ", " + cv.Zanimanje
                 + ", " + cv.Univerzitet + ", " + cv.Rating + ", " + cv.Fakultet);
        }
    }
}
