using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    enum Status { B, S} //B-budzet S-samofinansiranje
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s.ToString());
        }
    }

    class Student
    {
        string prezime;
        string ime;
        DateTime rodj;
        string adresa;
        string telefon;
        string e_mail;
        string br_indeksa;
        string god_upisa;
        string god_studija;
        Status status;
        float prosek;

        public Student()
        {
            Console.WriteLine("Unesi ime studenta: ");
            ime=Console.ReadLine();
            Console.WriteLine("Unesi prezime studenta: ");
            prezime = Console.ReadLine();
        }

        public override string ToString()
        {
            return ime + " " + prezime;
        }

    }
}
