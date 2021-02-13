using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskaSluzba.Models
{
    public class Student
    {
        static int trenutniBroj = 0;

        #region Properties

        [Key]
        [Required]
        public string Ime { get; set; }
        
        [Required]
        public string Prezime { get; set; }

        [Required]
        public int BrojIndeksa { get; set; }
        
        [Required]
        public int GodinaStudija { get; set; }

        [NotMapped]
        public List<Predmet> UpisaniPredmeti { get; set; }

        #endregion

        #region Konstruktor

        public Student() { }

        public Student(string name, string surname, int year)
        {
            Ime = name;
            Prezime = surname;
            BrojIndeksa = SljedećiIndex();
            GodinaStudija = year;
            UpisaniPredmeti = new List<Predmet>();
        }

        #endregion

        #region Metode

        public int SljedećiIndex()
        {
            return trenutniBroj++;
        }

        #endregion
    }
}
